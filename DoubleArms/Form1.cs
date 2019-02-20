using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleArms
{
    public partial class Form1 : Form
    {
        int lockcount;
        Arm LeftArm;
        Arm RightArm;
        Food LeftFood;
        Food RightFood;

        Graphics backGraphics;
        Bitmap backBmp;

        public Form1()
        {
            InitializeComponent();
            this.INTERRUPT.Enabled = false;
            lockcount = 0;

            LeftArm = new Arm("left", 0, 40, 65, 0);
            RightArm = new Arm("right", this.panel2.Width - 80, 40, this.panel2.Width - 80, 0);

            LeftFood = new Food(65, 105);
            RightFood = new Food((this.panel2.Width - 15) / 2, 105);

            backBmp = new Bitmap(this.panel2.DisplayRectangle.Width, this.panel2.DisplayRectangle.Height);
            backGraphics = Graphics.FromImage(backBmp);


            ForArm1.Stop();
        }
        //Timer 定時跑出各種狀態
        private void ForArm1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(lockcount);
            aa();
            //BalanceWorking();
            FoodMove();
            Repaint();
        }
        void Repaint()
        {
            backGraphics.Clear(Color.White);
            //底盤
            backGraphics.FillRectangle(Brushes.Green, 0, 115, this.Width, 15);
            //障礙物L
            backGraphics.FillRectangle(Brushes.Gray, this.panel2.Width / 2 - 40, 95, 15, 20);
            //障礙物R
            backGraphics.FillRectangle(Brushes.Gray, this.panel2.Width / 2 + 25, 95, 15, 20);

            //x軸長方形L
            backGraphics.FillRectangle(Brushes.BlueViolet, LeftArm.xaxis_X, LeftArm.xaxis_Z, LeftArm.xaxis_Width, LeftArm.xaxis_Height);
            //z軸長方形L
            backGraphics.FillRectangle(Brushes.Navy, LeftArm.zaxis_X, LeftArm.zaxis_Z, LeftArm.zaxis_Width, LeftArm.zaxis_Height);

            //x軸長方形R
            backGraphics.FillRectangle(Brushes.BlueViolet, RightArm.xaxis_X, RightArm.xaxis_Z, RightArm.xaxis_Width, RightArm.xaxis_Height);
            //z軸長方形R
            backGraphics.FillRectangle(Brushes.Navy, RightArm.zaxis_X, RightArm.zaxis_Z, RightArm.zaxis_Width, RightArm.zaxis_Height);

            //左邊Food
            if (LeftFood.getColor() == 0)
            {
                backGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0, 255)), this.LeftFood.getX(), this.LeftFood.getZ(), this.LeftFood.getWidth(), this.LeftFood.getHeight());
            }
            if (LeftFood.getColor() == 1)
            {
                backGraphics.FillRectangle(Brushes.Peru, this.LeftFood.getX(), this.LeftFood.getZ(), this.LeftFood.getWidth(), this.LeftFood.getHeight());
            }
            //右邊Food
            if (RightFood.getColor() == 0)
            {
                backGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0, 255)), this.RightFood.getX(), this.RightFood.getZ(), this.RightFood.getWidth(), this.RightFood.getHeight());
            }
            if (RightFood.getColor() == 1)
            {
                backGraphics.FillRectangle(Brushes.Peru, this.RightFood.getX(), this.RightFood.getZ(), this.RightFood.getWidth(), this.RightFood.getHeight());
            }
            this.panel2.CreateGraphics().DrawImageUnscaled(backBmp, 0, 0);
        }

        //Food移動的條件
        void FoodMove()
        {
            LeftFoodMove();
            RightFoodMove();
        }
        //左Food
        void LeftFoodMove()
        {
            if (LeftArm.zaxis_X == 65 && LeftArm.zaxis_Z > 10 && LeftArm.parall == 0 && LeftArm.virtical == 1)
            {
                this.LeftFood.setXZ(65, 105);
                LeftFood.setColor(1);
            }

            if (LeftArm.zaxis_X == (this.panel2.Width - 15) / 2 && (LeftArm.zaxis_Z < 10) && LeftArm.parall == 0 && LeftArm.virtical == 2)
            {
                LeftArm.seize = 0;
                LeftFood.setColor(0);
            }
            if (LeftArm.seize == 1)
            {
                LeftFood.setXZ(LeftArm.zaxis_X, LeftArm.zaxis_Z + LeftArm.zaxis_Height);
            }
            if (LeftArm.seize == 2)
            {
                LeftFood.setXZ((this.panel2.Width - 15) / 2, 105);
            }
        }
        //右Food
        void RightFoodMove()
        {
            if (RightArm.zaxis_X == (this.panel2.Width - 15) / 2 && RightArm.zaxis_Z > 10 && RightArm.parall == 0 && RightArm.virtical == 1)
            {
                RightFood.setXZ((this.panel2.Width - 15) / 2, 105);
                RightFood.setColor(1);
            }

            if (RightArm.zaxis_X == this.panel2.Width - 80 && RightArm.zaxis_Z < 10 && RightArm.parall == 0 && RightArm.virtical == 2)
            {
                RightArm.seize = 0;
                RightFood.setColor(0);
            }
            if (RightArm.seize == 1)
            {
                RightFood.setXZ(RightArm.zaxis_X, RightArm.zaxis_Z + RightArm.zaxis_Height);
            }
            if (RightArm.seize == 2)
            {
                RightFood.setXZ(this.panel2.Width - 80, 105);
            }
        }
        
        //使兩邊手臂運動協調
        void LockSetting()
        {
            if (LeftArm.zaxis_X > this.panel2.Width / 2 - 40-10)
            {
                lockcount = 1;
            }
            if (LeftArm.zaxis_X<= this.panel2.Width / 2 - 40 && RightArm.zaxis_X >= this.panel2.Width / 2 + 25)
            {
                lockcount = 0;
            }
            if (RightArm.zaxis_X < this.panel2.Width / 2 + 25 )
            {
                lockcount = 2;
            }
            
        }


        void aa() {
            LockSetting();
            if ((Convert.ToInt32(FrontCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) > 0)&& (Convert.ToInt32(MiddleCount.Text.ToString()) <= Convert.ToInt32(LoadConstrain.Text))) {
                if (Convert.ToInt32(MiddleCount.Text.ToString()) == Convert.ToInt32(LoadConstrain.Text))
                {
                    if (lockcount == 0) {
                        RightArmWoking();
                        Console.WriteLine("[-----]");
                        if (LeftArm.zaxis_X > 65 && LeftArm.zaxis_Z >= 0) {
                            Console.WriteLine("[**********]");
                            LeftArmWorking();
                        }


                    }
                    if (lockcount == 1) {
                        LeftArmWorking();
                        if (RightArm.zaxis_X>this.panel2.Width/2+25/*RB<RX*/) {
                            RightArmWoking();
                        }
                    }
                    if (lockcount == 2) {
                        RightArmWoking();
                        if ((LeftArm.zaxis_X > 65 && LeftArm.zaxis_Z >=0)&& LeftArm.zaxis_X < this.panel2.Width / 2 - 40/*LX未歸零&&LX<LB*/)
                        {
                            LeftArmWorking();
                        }
                    }
                }
                else
                {
                    if (lockcount == 0) {
                        RightArmWoking();
                        LeftArmWorking();
                    }
                    if (lockcount == 1) {
                        LeftArmWorking();
                        if (RightArm.zaxis_X > this.panel2.Width / 2 + 25/*RB<RX*/) { RightArmWoking(); }
                    }
                    if (lockcount == 2) {
                        RightArmWoking();
                        if (LeftArm.zaxis_X < this.panel2.Width / 2 - 40/*LB>LX*/) { LeftArmWorking(); }
                    }

                }

            }
            if ((Convert.ToInt32(FrontCount.Text.ToString()) == 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) <= Convert.ToInt32(LoadConstrain.Text))) {
                if (Convert.ToInt32(MiddleCount.Text.ToString()) == Convert.ToInt32(LoadConstrain.Text))
                {
                    if (lockcount == 0) {
                        RightArmWoking();
                        if (LeftArm.zaxis_X > 65 && LeftArm.zaxis_Z >= 0/*LX未歸零*/) { LeftArmWorking(); }
                    }
                    if (lockcount == 1) {
                        LeftArmWorking();
                        if (RightArm.zaxis_X > this.panel2.Width / 2 + 25/*RB<RX*/) { RightArmWoking(); }

                    }
                    if (lockcount == 2) {
                        RightArmWoking();
                        if ((LeftArm.zaxis_X > 65 && LeftArm.zaxis_Z >= 0) && LeftArm.zaxis_X < this.panel2.Width / 2 - 40/*LX未歸零&&LX<LB*/) { LeftArmWorking(); }
                    }
                }
                else
                {
                    if (lockcount == 0) {
                        RightArmWoking();
                        if ((LeftArm.zaxis_X > 65 && LeftArm.zaxis_Z >= 0)|| LeftArm.seize==1/*LX未歸零||L.seize==1*/) { LeftArmWorking(); }

                    }
                    if (lockcount == 1) {
                        LeftArmWorking();
                        if (RightArm.zaxis_X > this.panel2.Width / 2 + 25/*RB<RX*/) { RightArmWoking(); }

                    }
                    if (lockcount == 2) {
                        RightArmWoking();
                        if (((LeftArm.zaxis_X > 65 && LeftArm.zaxis_Z >= 0)||LeftArm.seize==1) && LeftArm.zaxis_X < this.panel2.Width / 2 - 40/*LX<LB &&(LX未歸零||L.seize==1)*/) { LeftArmWorking(); }

                    }

                }

            }
            if ((Convert.ToInt32(FrontCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) == 0)) {

                if (lockcount == 0) {
                    LeftArmWorking();
                    if (RightArm.seize==1||(RightArm.zaxis_X<this.panel2.Width-80&&RightArm.zaxis_Z>=0)/*(RX未歸零||R.seize==1)*/) { RightArmWoking(); }
                }
                if (lockcount == 1) {
                    LeftArmWorking();
                    if (RightArm.seize == 1 || (RightArm.zaxis_X < this.panel2.Width - 80 && RightArm.zaxis_Z >=0)/*(RX未歸零||R.seize==1)*/) { RightArmWoking(); }
                }
                if (lockcount == 2) {
                    if (RightArm.seize==1/*(R.seize==1)*/) { RightArmWoking(); }
                    if (LeftArm.zaxis_X < this.panel2.Width / 2 - 40/*(LX<LB)*/) { LeftArmWorking(); }
                }
            }

            if ((Convert.ToInt32(FrontCount.Text.ToString()) == 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) == 0))
            {
                if (lockcount == 0)
                {
                    if (LeftArm.seize == 1 || (LeftArm.getZX() > 65 && LeftArm.getZZ() == 0) || (LeftArm.getZX() == this.panel2.Width / 2 - 40 && LeftArm.getZZ() >= 0)) { LeftArmWorking(); }
                    if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                }
                else
                {
                    if (lockcount == 1)
                    {
                        if (LeftArm.seize == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                        if (RightArm.zaxis_X >= this.panel2.Width / 2 + 25 + 20 || RightArm.parall == 1)
                        {
                            if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                        }

                    }
                    else if (lockcount == 2)
                    {
                        if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                        if (LeftArm.seize == 1 || (LeftArm.getZX() > 65 && LeftArm.getZZ() == 0) || (LeftArm.getZX() == this.panel2.Width / 2 - 40 && LeftArm.getZZ() >= 0)) { LeftArmWorking(); }
                    }
                }

            }

        }

        void BalanceWorking()
        {
            LockSetting();
            Console.WriteLine(lockcount);
            if ((Convert.ToInt32(FrontCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) > 0))
            {
                if (LeftArm.zaxis_X >= this.panel2.Width / 2 - 40)
                {
                    //Console.WriteLine(LeftArm.zaxis_X.ToString() + "," + lockcount.ToString() + "[" + (this.panel2.Width / 2 - 40).ToString() + "]");
                    lockcount = 1;
                }
                if (lockcount == 0)
                {
                    LeftArmWorking();
                    RightArmWoking();
                }
                else
                {
                    if (lockcount == 1)
                    {
                        LeftArmWorking();
                        if (RightArm.zaxis_X >= this.panel2.Width / 2 + 25 + 20 || RightArm.parall == 1)
                        {
                            RightArmWoking();
                        }

                    }
                    else if (lockcount == 2)
                    {
                        RightArmWoking();
                        if (LeftArm.zaxis_X <= this.panel2.Width / 2 - 40)
                        {
                            LeftArmWorking();
                        }
                    }
                }
            }
            else
            {
                if ((Convert.ToInt32(FrontCount.Text.ToString()) == 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) == 0))
                {
                    if (lockcount == 0)
                    {
                        if (LeftArm.seize == 1 || (LeftArm.getZX() > 65 && LeftArm.getZZ() == 0) || (LeftArm.getZX() == this.panel2.Width / 2 - 40 && LeftArm.getZZ() >= 0)) { LeftArmWorking(); }
                        if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                    }
                    else
                    {
                        if (lockcount == 1)
                        {
                            if (LeftArm.seize == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                            if (RightArm.zaxis_X >= this.panel2.Width / 2 + 25 + 20 || RightArm.parall == 1)
                            {
                                if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                            }

                        }
                        else if (lockcount == 2)
                        {
                            if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                            if (LeftArm.seize == 1 || (LeftArm.getZX() > 65 && LeftArm.getZZ() == 0) || (LeftArm.getZX() == this.panel2.Width / 2 - 40 && LeftArm.getZZ() >= 0)) { LeftArmWorking(); }
                        }
                    }

                }
                else
                {
                    LockSetting();
                    if (Convert.ToInt32(FrontCount.Text.ToString()) == 0 || Convert.ToInt32(MiddleCount.Text.ToString()) > 0)
                    {

                        if (lockcount == 0)
                        {
                            if (LeftArm.seize == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                            RightArmWoking();
                            //if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                        }
                        else
                        {
                            if (lockcount == 1)
                            {
                                if (LeftArm.seize == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                                if (RightArm.zaxis_X >= this.panel2.Width / 2 + 25 + 20 || RightArm.parall == 1)
                                {
                                    RightArmWoking();
                                    //if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                                }

                            }
                            else if (lockcount == 2)
                            {
                                if (RightArm.seize == 1 || (RightArm.getZZ() >= 0)) { RightArmWoking(); }
                                if (LeftArm.seize == 1 || (LeftArm.getZX() > 65 && LeftArm.getZZ() == 0) || (LeftArm.getZX() == this.panel2.Width / 2 - 40 && LeftArm.getZZ() >= 0)) { LeftArmWorking(); }
                            }
                        }

                    }
                    if (Convert.ToInt32(FrontCount.Text.ToString()) > 0 || Convert.ToInt32(MiddleCount.Text.ToString()) == 0)
                    {
                        if (lockcount == 0)
                        {
                            LeftArmWorking();
                            //if (LeftArm.seize == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                            if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                        }
                        else
                        {
                            if (lockcount == 1)
                            {
                                LeftArmWorking();
                                //if (LeftArm.seize == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                                if (RightArm.zaxis_X >= this.panel2.Width / 2 + 25 + 20 || RightArm.parall == 1)
                                {
                                    RightArmWoking();
                                    //if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                                }

                            }
                            else if (lockcount == 2)
                            {
                                if (RightArm.seize == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                                if (LeftArm.zaxis_X <= this.panel2.Width / 2 - 40 - 10 || LeftArm.parall == 2)
                                {
                                    LeftArmWorking();
                                    //if (LeftArm.seize == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                                }
                            }
                        }

                    }
                }
            }

        }
        //左手臂運動
        void LeftArmWorking()
        {
            /********************************左手臂*************************************/
            for (int i = 0; i < Convert.ToInt32(speed1.Text); i++)
            {
                if (LeftArm.zaxis_Z == 0)
                {
                    if (LeftArm.zaxis_X == (this.panel2.Width - 15) / 2)
                    {
                        if (LeftArm.parall == 1 && LeftArm.virtical == 0)
                        {
                            //向下指示
                            LeftArm.parall = 0;
                            LeftArm.virtical = 1;
                        }
                        if (LeftArm.parall == 0 && LeftArm.virtical == 2)
                        {
                            //向左指示
                            LeftArm.parall = 2;
                            LeftArm.virtical = 0;
                        }
                    }
                    if (LeftArm.zaxis_X == 65)
                    {
                        if ((LeftArm.parall == 0 && LeftArm.virtical == 0) || (LeftArm.parall == 2 && LeftArm.virtical == 0))
                        {
                            //向下指示
                            LeftArm.parall = 0;
                            LeftArm.virtical = 1;

                        }
                        if (LeftArm.parall == 0 && LeftArm.virtical == 2)
                        {
                            //向右指示
                            LeftArm.parall = 1;
                            LeftArm.virtical = 0;
                        }
                    }
                }
                if (LeftArm.zaxis_Z == 40)
                {
                    LeftArm.parall = 0;
                    LeftArm.virtical = 2;
                    if (LeftArm.zaxis_X == (this.panel2.Width - 15) / 2)
                    {
                        LeftArm.Release();
                        MiddleCount.Text = (Convert.ToInt32(MiddleCount.Text) + 1).ToString();
                    }
                    if (LeftArm.zaxis_X == 65)
                    {
                        LeftArm.Seize();
                        FrontCount.Text = (Convert.ToInt32(FrontCount.Text) - 1).ToString();
                    }

                }
                /**************************************************************************************/
                if (LeftArm.parall == 2 && LeftArm.virtical == 0)
                {
                    LeftArm.Left();
                }
                if (LeftArm.parall == 1 && LeftArm.virtical == 0)
                {
                    LeftArm.Right();
                }
                if (LeftArm.parall == 0 && LeftArm.virtical == 1)
                {
                    LeftArm.Down();
                }
                if (LeftArm.parall == 0 && LeftArm.virtical == 2)
                {
                    LeftArm.UP();
                }

            }

        }
        //右手臂運動
        void RightArmWoking()
        {
            /********************************右手臂*************************************/
            for (int i = 0; i < Convert.ToInt32(speed2.Text); i++) {
                if (RightArm.zaxis_Z == 0)
                {
                    if (RightArm.zaxis_X == (this.panel2.Width - 15) / 2)
                    {
                        if (RightArm.parall == 2 && RightArm.virtical == 0)
                        {
                            //向下指示
                            RightArm.parall = 0;
                            RightArm.virtical = 1;
                        }
                        if (RightArm.parall == 0 && RightArm.virtical == 2)
                        {
                            //向右指示
                            RightArm.parall = 1;
                            RightArm.virtical = 0;
                        }
                    }
                    if (RightArm.zaxis_X == this.panel2.Width - 80)
                    {
                        if ((RightArm.parall == 0 && RightArm.virtical == 0) || (RightArm.parall == 0 && RightArm.virtical == 2))
                        {
                            //向左指示
                            RightArm.parall = 2;
                            RightArm.virtical = 0;

                        }
                        if (RightArm.parall == 1 && RightArm.virtical == 0)
                        {
                            //向下指示
                            RightArm.parall = 0;
                            RightArm.virtical = 1;
                        }
                    }
                }
                if (RightArm.zaxis_Z == 40)
                {
                    RightArm.parall = 0;
                    RightArm.virtical = 2;
                    if (RightArm.zaxis_X == (this.panel2.Width - 15) / 2)
                    {
                        RightArm.Seize();
                        MiddleCount.Text = (Convert.ToInt32(MiddleCount.Text) - 1).ToString();
                    }
                    if (RightArm.zaxis_X == this.panel2.Width - 80)
                    {
                        RightArm.Release();
                        EndCount.Text = (Convert.ToInt32(EndCount.Text) + 1).ToString();
                    }

                }
                /**************************************************************************************/
                if (RightArm.parall == 2 && RightArm.virtical == 0)
                {
                    RightArm.Left();
                }
                if (RightArm.parall == 1 && RightArm.virtical == 0)
                {
                    RightArm.Right();
                }
                if (RightArm.parall == 0 && RightArm.virtical == 1)
                {
                    RightArm.Down();
                }
                if (RightArm.parall == 0 && RightArm.virtical == 2)
                {
                    RightArm.UP();
                }

            }

        }

        //畫布呈現結果
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //底盤
            e.Graphics.FillRectangle(Brushes.Green, 0, 115, this.Width, 15);
            //障礙物L
            e.Graphics.FillRectangle(Brushes.Gray, this.panel2.Width / 2 - 40, 95, 15, 20);
            //障礙物R
            e.Graphics.FillRectangle(Brushes.Gray, this.panel2.Width / 2 + 25, 95, 15, 20);

            //x軸長方形L
            e.Graphics.FillRectangle(Brushes.BlueViolet, LeftArm.xaxis_X, LeftArm.xaxis_Z, LeftArm.xaxis_Width, LeftArm.xaxis_Height);
            //z軸長方形L
            e.Graphics.FillRectangle(Brushes.Navy, LeftArm.zaxis_X, LeftArm.zaxis_Z, LeftArm.zaxis_Width, LeftArm.zaxis_Height);

            //x軸長方形R
            e.Graphics.FillRectangle(Brushes.BlueViolet, RightArm.xaxis_X, RightArm.xaxis_Z, RightArm.xaxis_Width, RightArm.xaxis_Height);
            //z軸長方形R
            e.Graphics.FillRectangle(Brushes.Navy, RightArm.zaxis_X, RightArm.zaxis_Z, RightArm.zaxis_Width, RightArm.zaxis_Height);

            //左邊Food
            if (LeftFood.getColor() == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, this.LeftFood.getX(), this.LeftFood.getZ(), this.LeftFood.getWidth(), this.LeftFood.getHeight());
            }
            if (LeftFood.getColor() == 1)
            {
                e.Graphics.FillRectangle(Brushes.Peru, this.LeftFood.getX(), this.LeftFood.getZ(), this.LeftFood.getWidth(), this.LeftFood.getHeight());
            }
            //右邊Food
            if (RightFood.getColor() == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, this.RightFood.getX(), this.RightFood.getZ(), this.RightFood.getWidth(), this.RightFood.getHeight());
            }
            if (RightFood.getColor() == 1)
            {
                e.Graphics.FillRectangle(Brushes.Peru, this.RightFood.getX(), this.RightFood.getZ(), this.RightFood.getWidth(), this.RightFood.getHeight());
            }
        }

        private void START_Click(object sender, EventArgs e)
        {
            ForArm1.Start();
            START.Enabled = false;
            this.INTERRUPT.Enabled = true;
        }

        private void INTERRUPT_Click(object sender, EventArgs e)
        {
            if (INTERRUPT.Text.ToString().Equals("中斷"))
            {
                ForArm1.Stop();
                INTERRUPT.Text = "繼續";

            }
            else
            {
                ForArm1.Start();
                INTERRUPT.Text = "中斷";
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
