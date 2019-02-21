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
        int lockcount, home;
        int pf, pm, pl;

        Arm LeftArm, RightArm;
        Food LeftFood, RightFood;

        Graphics backGraphics;
        Bitmap backBmp;

        public Form1()
        {
            InitializeComponent();
            this.INTERRUPT.Enabled = false;
            EndCount.Enabled = false;
            lockcount = 0;
            home = 0;
            pf = Convert.ToInt32(FrontCount.Text);
            pm = Convert.ToInt32(MiddleCount.Text);
            pl = Convert.ToInt32(LoadConstrain.Text);

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
            try
            {
                if (Convert.ToInt32(FrontCount.Text) >= 0 && Convert.ToInt32(MiddleCount.Text) >= 0 && Convert.ToInt32(LoadConstrain.Text) >= 0)
                {
                    pf = Convert.ToInt32(FrontCount.Text);

                    if (Convert.ToInt32(MiddleCount.Text) <= Convert.ToInt32(LoadConstrain.Text))
                    {
                        pm = Convert.ToInt32(MiddleCount.Text);
                        pl = Convert.ToInt32(LoadConstrain.Text);
                        MakeToHome();
                        Repaint();
                    }
                    else
                    {
                        ForArm1.Stop();
                        INTERRUPT.Text = "繼續";
                        MessageBox.Show("中間區域請勿超過負載限制");
                        FrontCount.Text = pf.ToString();
                        MiddleCount.Text = pm.ToString();
                        LoadConstrain.Text = pl.ToString();
                    }
                }
                else
                {
                    ForArm1.Stop();
                    INTERRUPT.Text = "繼續";
                    MessageBox.Show("請輸入正整數");
                    FrontCount.Text = pf.ToString();
                    MiddleCount.Text = pm.ToString();
                    LoadConstrain.Text = pl.ToString();
                }
            }
            catch
            {
                ForArm1.Stop();
                MessageBox.Show("數值格式為正整數");
                FrontCount.Text = pf.ToString();
                MiddleCount.Text = pm.ToString();
                LoadConstrain.Text = pl.ToString();
                ForArm1.Start();
            }
        }
        //重新繪圖
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
            backGraphics.FillRectangle(Brushes.BlueViolet, LeftArm.getXX(), LeftArm.getXZ(), LeftArm.getXWidth(), LeftArm.getXHeight());
            //z軸長方形L
            backGraphics.FillRectangle(Brushes.Navy, LeftArm.getZX(), LeftArm.getZZ(), LeftArm.getZWidth(), LeftArm.getZHeight());

            //x軸長方形R
            backGraphics.FillRectangle(Brushes.BlueViolet, RightArm.getXX(), RightArm.getXZ(), RightArm.getXWidth(), RightArm.getXHeight());
            //z軸長方形R
            backGraphics.FillRectangle(Brushes.Navy, RightArm.getZX(), RightArm.getZZ(), RightArm.getZWidth(), RightArm.getZHeight());

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
        //Food移動
        void FoodMove()
        {
            LeftFoodMove();
            RightFoodMove();
        }
        //左Food移動的條件
        void LeftFoodMove()
        {
            if (LeftArm.getZX() == 65 && LeftArm.getZZ() > 10 && LeftArm.getParall() == 0 && LeftArm.getVirtical() == 1)
            {
                this.LeftFood.setXZ(65, 105);
                LeftFood.setColor(1);
            }

            if (LeftArm.getZX() == (this.panel2.Width - 15) / 2 && (LeftArm.getZZ() < 10) && LeftArm.getParall() == 0 && LeftArm.getVirtical() == 2)
            {
                LeftArm.setSeize(0);
                LeftFood.setColor(0);
            }
            if (LeftArm.getSeize() == 1)
            {
                LeftFood.setXZ(LeftArm.getZX(), LeftArm.getZZ() + LeftArm.getZHeight());
            }
            if (LeftArm.getSeize() == 2)
            {
                LeftFood.setXZ((this.panel2.Width - 15) / 2, 105);
            }
        }
        //右Food移動的條件
        void RightFoodMove()
        {
            if (RightArm.getZX() == (this.panel2.Width - 15) / 2 && RightArm.getZZ() > 10 && RightArm.getParall() == 0 && RightArm.getVirtical() == 1)
            {
                RightFood.setXZ((this.panel2.Width - 15) / 2, 105);
                RightFood.setColor(1);
            }

            if (RightArm.getZX() == this.panel2.Width - 80 && RightArm.getZZ() < 10 && RightArm.getParall() == 0 && RightArm.getVirtical() == 2)
            {
                RightArm.setSeize(0);
                RightFood.setColor(0);
            }
            if (RightArm.getSeize() == 1)
            {
                RightFood.setXZ(RightArm.getZX(), RightArm.getZZ() + RightArm.getZHeight());
            }
            if (RightArm.getSeize() == 2)
            {
                RightFood.setXZ(this.panel2.Width - 80, 105);
            }
        }

        //設定中間區域取放物的手臂
        void LockSetting()
        {
            if (LeftArm.getZX() > this.panel2.Width / 2 - 40 - 10)
            {
                lockcount = 1;
            }
            if (LeftArm.getZX() <= this.panel2.Width / 2 - 40 && RightArm.getZX() >= this.panel2.Width / 2 + 25)
            {
                lockcount = 0;
            }
            if (RightArm.getZX() < this.panel2.Width / 2 + 25)
            {
                lockcount = 2;
            }

        }

        //使兩邊手臂運動協調
        void BalanceWorking()
        {
            LockSetting();
            if ((Convert.ToInt32(FrontCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) <= Convert.ToInt32(LoadConstrain.Text)))
            {
                if (Convert.ToInt32(MiddleCount.Text.ToString()) == Convert.ToInt32(LoadConstrain.Text))
                {
                    if (lockcount == 0)
                    {
                        RightArmWoking();
                        if (LeftArm.getZX() > 65 && LeftArm.getZZ() >= 0)
                        {
                            LeftArmWorking();
                        }


                    }
                    if (lockcount == 1)
                    {
                        LeftArmWorking();
                        if (RightArm.getZX() > this.panel2.Width / 2 + 25/*RB<RX*/)
                        {
                            RightArmWoking();
                        }
                    }
                    if (lockcount == 2)
                    {
                        RightArmWoking();
                        if ((LeftArm.getZX() > 65 && LeftArm.getZZ() >= 0) && LeftArm.getZX() < this.panel2.Width / 2 - 40/*LX未歸零&&LX<LB*/)
                        {
                            LeftArmWorking();
                        }
                    }
                }
                else
                {
                    if (lockcount == 0)
                    {
                        RightArmWoking();
                        LeftArmWorking();
                    }
                    if (lockcount == 1)
                    {
                        LeftArmWorking();
                        if (RightArm.getZX() > this.panel2.Width / 2 + 25/*RB<RX*/) { RightArmWoking(); }
                    }
                    if (lockcount == 2)
                    {
                        RightArmWoking();
                        if (LeftArm.getZX() < this.panel2.Width / 2 - 40/*LB>LX*/) { LeftArmWorking(); }
                    }

                }

            }
            if ((Convert.ToInt32(FrontCount.Text.ToString()) == 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) <= Convert.ToInt32(LoadConstrain.Text)))
            {
                if (Convert.ToInt32(MiddleCount.Text.ToString()) == Convert.ToInt32(LoadConstrain.Text))
                {
                    if (lockcount == 0)
                    {
                        RightArmWoking();
                        if (LeftArm.getZX() > 65 && LeftArm.getZZ() >= 0/*LX未歸零*/) { LeftArmWorking(); }
                    }
                    if (lockcount == 1)
                    {
                        LeftArmWorking();
                        if (RightArm.getZX() > this.panel2.Width / 2 + 25/*RB<RX*/) { RightArmWoking(); }

                    }
                    if (lockcount == 2)
                    {
                        RightArmWoking();
                        if ((LeftArm.getZX() > 65 && LeftArm.getZZ() >= 0) && LeftArm.getZX() < this.panel2.Width / 2 - 40/*LX未歸零&&LX<LB*/) { LeftArmWorking(); }
                    }
                }
                else
                {
                    if (lockcount == 0)
                    {
                        RightArmWoking();
                        if ((LeftArm.getZX() > 65 && LeftArm.getZZ() >= 0) || LeftArm.getSeize() == 1/*LX未歸零||L.seize==1*/) { LeftArmWorking(); }

                    }
                    if (lockcount == 1)
                    {
                        LeftArmWorking();
                        if (RightArm.getZX() > this.panel2.Width / 2 + 25/*RB<RX*/) { RightArmWoking(); }

                    }
                    if (lockcount == 2)
                    {
                        RightArmWoking();
                        if (((LeftArm.getZX() > 65 && LeftArm.getZZ() >= 0) || LeftArm.getSeize() == 1) && LeftArm.getZX() < this.panel2.Width / 2 - 40/*LX<LB &&(LX未歸零||L.seize==1)*/) { LeftArmWorking(); }

                    }

                }

            }
            if ((Convert.ToInt32(FrontCount.Text.ToString()) > 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) == 0))
            {

                if (lockcount == 0)
                {
                    LeftArmWorking();
                    if (RightArm.getSeize() == 1 || (RightArm.getZX() < this.panel2.Width - 80 && RightArm.getZZ() >= 0)/*(RX未歸零||R.seize==1)*/) { RightArmWoking(); }
                }
                if (lockcount == 1)
                {
                    LeftArmWorking();
                    if (RightArm.getSeize() == 1 || (RightArm.getZX() < this.panel2.Width - 80 && RightArm.getZZ() >= 0)/*(RX未歸零||R.seize==1)*/) { RightArmWoking(); }
                }
                if (lockcount == 2)
                {
                    if (RightArm.getSeize() == 1/*(R.seize==1)*/) { RightArmWoking(); }
                    if (LeftArm.getZX() < this.panel2.Width / 2 - 40/*(LX<LB)*/) { LeftArmWorking(); }
                }
            }

            if ((Convert.ToInt32(FrontCount.Text.ToString()) == 0) && (Convert.ToInt32(MiddleCount.Text.ToString()) == 0))
            {
                if (lockcount == 0)
                {
                    if (LeftArm.getSeize() == 1 || (LeftArm.getZX() > 65 && LeftArm.getZZ() == 0) || (LeftArm.getZX() == this.panel2.Width / 2 - 40 && LeftArm.getZZ() >= 0)) { LeftArmWorking(); }
                    if (RightArm.getSeize() == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                }
                else
                {
                    if (lockcount == 1)
                    {
                        if (LeftArm.getSeize() == 1 || LeftArm.getZX() > 75 || LeftArm.getZZ() > 10) { LeftArmWorking(); }
                        if (RightArm.getZX() >= this.panel2.Width / 2 + 25 + 20 || RightArm.getParall() == 1)
                        {
                            if (RightArm.getSeize() == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                        }

                    }
                    else if (lockcount == 2)
                    {
                        if (RightArm.getSeize() == 1 || RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() > 0) { RightArmWoking(); }
                        if (LeftArm.getSeize() == 1 || (LeftArm.getZX() > 65 && LeftArm.getZZ() == 0) || (LeftArm.getZX() == this.panel2.Width / 2 - 40 && LeftArm.getZZ() >= 0)) { LeftArmWorking(); }
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
                if (LeftArm.getZZ() == 0)
                {
                    if (LeftArm.getZX() == (this.panel2.Width - 15) / 2)
                    {
                        if (LeftArm.getParall() == 1 && LeftArm.getVirtical() == 0)
                        {
                            //向下指示
                            LeftArm.setParall(0);
                            LeftArm.setVirtical(1);
                        }
                        if (LeftArm.getParall() == 0 && LeftArm.getVirtical() == 2)
                        {
                            //向左指示
                            LeftArm.setParall(2);
                            LeftArm.setVirtical(0);
                        }
                    }
                    if (LeftArm.getZX() == 65)
                    {
                        if ((LeftArm.getParall() == 0 && LeftArm.getVirtical() == 0) || (LeftArm.getParall() == 2 && LeftArm.getVirtical() == 0))
                        {
                            //向下指示
                            LeftArm.setParall(0);
                            LeftArm.setVirtical(1);

                        }
                        if (LeftArm.getParall() == 0 && LeftArm.getVirtical() == 2)
                        {
                            //向右指示
                            LeftArm.setParall(1);
                            LeftArm.setVirtical(0);
                        }
                    }
                }
                if (LeftArm.getZZ() == 40)
                {
                    LeftArm.setParall(0);
                    LeftArm.setVirtical(2);
                    if (LeftArm.getZX() == (this.panel2.Width - 15) / 2)
                    {
                        LeftArm.Release();
                        MiddleCount.Text = (Convert.ToInt32(MiddleCount.Text) + 1).ToString();
                    }
                    if (LeftArm.getZX() == 65)
                    {
                        LeftArm.Seize();
                        FrontCount.Text = (Convert.ToInt32(FrontCount.Text) - 1).ToString();
                    }

                }
                /**************************************************************************************/
                if (LeftArm.getParall() == 2 && LeftArm.getVirtical() == 0)
                {
                    LeftArm.Left();
                }
                if (LeftArm.getParall() == 1 && LeftArm.getVirtical() == 0)
                {
                    LeftArm.Right();
                }
                if (LeftArm.getParall() == 0 && LeftArm.getVirtical() == 1)
                {
                    LeftArm.Down();
                }
                if (LeftArm.getParall() == 0 && LeftArm.getVirtical() == 2)
                {
                    LeftArm.UP();
                }

            }

        }
        //右手臂運動
        void RightArmWoking()
        {
            /********************************右手臂*************************************/
            for (int i = 0; i < Convert.ToInt32(speed2.Text); i++)
            {
                if (RightArm.getZZ() == 0)
                {
                    if (RightArm.getZX() == (this.panel2.Width - 15) / 2)
                    {
                        if (RightArm.getParall() == 2 && RightArm.getVirtical() == 0)
                        {
                            //向下指示
                            RightArm.setParall(0);
                            RightArm.setVirtical(1);
                        }
                        if (RightArm.getParall() == 0 && RightArm.getVirtical() == 2)
                        {
                            //向右指示
                            RightArm.setParall(1);
                            RightArm.setVirtical(0);
                        }
                    }
                    if (RightArm.getZX() == this.panel2.Width - 80)
                    {
                        if ((RightArm.getParall() == 0 && RightArm.getVirtical() == 0) || (RightArm.getParall() == 0 && RightArm.getVirtical() == 2))
                        {
                            //向左指示
                            RightArm.setParall(2);
                            RightArm.setVirtical(0);

                        }
                        if (RightArm.getParall() == 1 && RightArm.getVirtical() == 0)
                        {
                            //向下指示
                            RightArm.setParall(0);
                            RightArm.setVirtical(1);
                        }
                    }
                }
                if (RightArm.getZZ() == 40)
                {
                    RightArm.setParall(0);
                    RightArm.setVirtical(2);
                    if (RightArm.getZX() == (this.panel2.Width - 15) / 2)
                    {
                        RightArm.Seize();
                        MiddleCount.Text = (Convert.ToInt32(MiddleCount.Text) - 1).ToString();
                    }
                    if (RightArm.getZX() == this.panel2.Width - 80)
                    {
                        RightArm.Release();
                        EndCount.Text = (Convert.ToInt32(EndCount.Text) + 1).ToString();
                    }

                }
                /**************************************************************************************/
                if (RightArm.getParall() == 2 && RightArm.getVirtical() == 0)
                {
                    RightArm.Left();
                }
                if (RightArm.getParall() == 1 && RightArm.getVirtical() == 0)
                {
                    RightArm.Right();
                }
                if (RightArm.getParall() == 0 && RightArm.getVirtical() == 1)
                {
                    RightArm.Down();
                }
                if (RightArm.getParall() == 0 && RightArm.getVirtical() == 2)
                {
                    RightArm.UP();
                }

            }

        }

        void MakeToHome()
        {
            if (home == 0)
            {
                BalanceWorking();
                FoodMove();
            }
            if (home == 1)
            {
                if ((LeftArm.getZX() > 65 || LeftArm.getZZ() >= 0) || (RightArm.getZX() < this.panel2.Width - 80 || RightArm.getZZ() >= 0))
                {
                    LeftArm.setSeize(2);
                    RightArm.setSeize(2);
                    LeftFood.setColor(0);
                    RightFood.setColor(0);
                    if (LeftArm.getZZ() > 0)
                    {
                        LeftArm.UP();
                    }
                    else if (LeftArm.getZZ() == 0)
                    {
                        if (LeftArm.getZX() > 65)
                        {
                            LeftArm.Left();
                        }
                    }
                    if (RightArm.getZZ() > 0)
                    {
                        RightArm.UP();
                    }
                    else if (RightArm.getZZ() == 0)
                    {
                        if (RightArm.getZX() < this.panel2.Width - 80)
                        {
                            RightArm.Right();
                        }
                    }

                }
                if (LeftArm.getZX() == 65 && LeftArm.getZZ() == 0 && (RightArm.getZX() == this.panel2.Width - 80 && RightArm.getZZ() == 0))
                {
                    home = 0;
                    ForArm1.Stop();
                    FrontCount.Enabled = true;
                    MiddleCount.Enabled = true;
                    LoadConstrain.Enabled = true;

                    LeftArm.setSeize(0);
                    LeftArm.setParall(0);
                    LeftArm.setVirtical(0);

                    RightArm.setSeize(0);
                    RightArm.setParall(0);
                    RightArm.setVirtical(0);
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
            e.Graphics.FillRectangle(Brushes.BlueViolet, LeftArm.getXX(), LeftArm.getXZ(), LeftArm.getXWidth(), LeftArm.getXHeight());
            //z軸長方形L
            e.Graphics.FillRectangle(Brushes.Navy, LeftArm.getZX(), LeftArm.getZZ(), LeftArm.getZWidth(), LeftArm.getZHeight());

            //x軸長方形R
            e.Graphics.FillRectangle(Brushes.BlueViolet, RightArm.getXX(), RightArm.getXZ(), RightArm.getXWidth(), RightArm.getXHeight());
            //z軸長方形R
            e.Graphics.FillRectangle(Brushes.Navy, RightArm.getZX(), RightArm.getZZ(), RightArm.getZWidth(), RightArm.getZHeight());

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
            FrontCount.Enabled = false;
            MiddleCount.Enabled = false;
            LoadConstrain.Enabled = false;
        }

        private void INTERRUPT_Click(object sender, EventArgs e)
        {
            if (INTERRUPT.Text.ToString().Equals("中斷"))
            {
                ForArm1.Stop();
                INTERRUPT.Text = "繼續";
                Home.Enabled = false;
                FrontCount.Enabled = true;
                MiddleCount.Enabled = true;
                LoadConstrain.Enabled = true;
            }
            else
            {
                ForArm1.Start();
                INTERRUPT.Text = "中斷";
                Home.Enabled = true;
                FrontCount.Enabled = false;
                MiddleCount.Enabled = false;
                LoadConstrain.Enabled = false;
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            home = 1;

            if (START.Enabled)
            {
                MessageBox.Show("手臂位置已於初始階段");
            }
            else
            {
                this.INTERRUPT.Enabled = false;
                this.INTERRUPT.Text = "中斷";                

                START.Enabled = true;
                FrontCount.Enabled = true;
                MiddleCount.Enabled = true;
                LoadConstrain.Enabled = true;

            }
        }
    }
}
