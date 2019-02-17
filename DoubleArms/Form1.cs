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

        int virtical = 0, parall = 0,virtical_r = 0, parall_r = 0;
        int lockcount = 0;
        Arm LeftArm;
        Arm RightArm;
        Food LeftFood;
        Food RightFood;
        public Form1()
        {
            InitializeComponent();

            LeftArm = new Arm("",0, 40, 65, 0);
            RightArm = new Arm("",this.panel2.Width - 80, 40, this.panel2.Width - 80, 0);

            LeftFood = new Food(65,105);
            RightFood = new Food(194,105);
            RightFood.setXZ((this.panel2.Width-15)/2,105);

            ForArm1.Stop();
        }

        private void ForArm1_Tick(object sender, EventArgs e)
        {
            BalanceWorking();
            FoodMove();
            this.panel2.Invalidate();
        }
        
        void FoodMove() {
            //Console.WriteLine("{0},{1},{2},{3}", LeftArm.zaxis_X, LeftArm.zaxis_Z, parall, virtical);
            //Console.WriteLine("{0},{1},{2},{3}", LeftFood.X,LeftFood.Z,LeftFood.color,"-w-w-w-w-w-w-s-s-s-s-s");

            if (LeftArm.zaxis_X == 65 && LeftArm.zaxis_Z == 1 && parall == 0 && virtical == 1)
            {
                this.LeftFood.X = 65;
                this.LeftFood.Z = 105;
                LeftFood.color = 1;
            }

            if (LeftArm.zaxis_X == (this.panel2.Width - 15) / 2  && LeftArm.zaxis_Z == 0 && parall == 0 && virtical == 2)
            {
                LeftArm.seize = 0;
                LeftFood.color = 0;
            }
            if (LeftArm.seize == 1)
            {
                LeftFood.X = LeftArm.zaxis_X;
                LeftFood.Z = LeftArm.zaxis_Z + LeftArm.zaxis_Height;
            }
            if (LeftArm.seize == 2)
            {

                LeftFood.X = (this.panel2.Width - 15) / 2;
                LeftFood.Z = 105;

            }
            //----------------------------------------------------------------------------------------------------------------------
            if (RightArm.zaxis_X == 194 && RightArm.zaxis_Z == 1 && parall_r == 0 && virtical_r == 1)
            {
                RightFood.X = 194;
                RightFood.Z = 105;
                RightFood.color = 1;
            }

            if (RightArm.zaxis_X == this.panel2.Width - 80 && RightArm.zaxis_Z == 0 && parall_r == 0 && virtical_r == 2)
            {
                RightArm.seize = 0;
                RightFood.color = 0;
            }
            if (RightArm.seize == 1)
            {
                RightFood.X = RightArm.zaxis_X;
                RightFood.Z = RightArm.zaxis_Z + RightArm.zaxis_Height;
            }
            if (RightArm.seize == 2)
            {

                RightFood.X = this.panel2.Width - 80;
                RightFood.Z = 105;

            }



        }

        void BalanceWorking() {
            if (LeftArm.zaxis_X > this.panel2.Width / 2 - 40)
            {
                lockcount = 1;
            }
            if (LeftArm.xaxis_X + LeftArm.xaxis_Width == this.panel2.Width / 2 - 40)
            {
                lockcount = 0;
            }
            if (RightArm.zaxis_X + 2 < this.panel2.Width / 2 + 40)
            {
                lockcount = 2;
            }
            if (RightArm.xaxis_X == this.panel2.Width / 2 + 40)
            {
                lockcount = 0;
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

                    if (RightArm.xaxis_X >= this.panel2.Width / 2 + 40)
                    {
                        RightArmWoking();


                    }

                }
                else if (lockcount == 2)
                {
                    RightArmWoking();

                    if (LeftArm.zaxis_X < this.panel2.Width / 2 - 40)
                    {
                        LeftArmWorking();

                    }
                }


            }
        }
        void LeftArmWorking() {
            /********************************左手臂*************************************/
            if (LeftArm.zaxis_Z == 0)
            {
                if (parall == 0 && virtical == 0) { virtical = 1; }

                if (parall == 2 && virtical == 0)
                {
                    LeftArm.Left();
                    if (LeftArm.xaxis_X + LeftArm.xaxis_Width == 80)
                    {
                        parall = 0;
                        virtical = 0;
                    }
                }
                if (parall == 0 && virtical == 2)
                {
                    parall = 1;
                    virtical = 0;
                    if (LeftArm.xaxis_X + LeftArm.xaxis_Width == (this.panel2.Width + 15) / 2) { parall = 2; virtical = 0; }
                }

            }
            if (LeftArm.zaxis_Z <= 41)
            {

                if (parall == 0 && virtical == 1) { LeftArm.Down(); }
                if (parall == 0 && virtical == 2) { LeftArm.UP(); }

            }
            if (LeftArm.zaxis_Z == 41) {
                /*/****/////////
                virtical = 2;
                if (LeftArm.zaxis_X == 65) {
                    LeftArm.Seize();                 
                }
                if (LeftArm.zaxis_X == (this.panel2.Width - 15) / 2) {
                    LeftArm.Release(); 
                }
                
            }
            if (LeftArm.xaxis_X + LeftArm.xaxis_Width < (this.panel2.Width + 15) / 2 && parall == 1 && virtical == 0) { LeftArm.Right(); }

            if (LeftArm.xaxis_X + LeftArm.xaxis_Width == (this.panel2.Width + 15) / 2 && parall == 1 && virtical == 0)
            {
                parall = 0;
                virtical = 1;
            }
            /*********************************************************************/
        }

        void RightArmWoking() {
            /********************************右手臂*************************************/
            if (RightArm.zaxis_Z == 0)
            {
                if (parall_r == 0 && virtical_r == 0) { parall_r = 2; }
                if (parall_r == 2 && virtical_r == 0)
                {
                    if (RightArm.xaxis_X == (this.panel2.Width - 15) / 2)
                    {
                        parall_r = 0;
                        virtical_r = 1;
                    }
                    RightArm.R_Left();

                }

                if (parall_r == 0 && virtical_r == 2)
                {
                    parall_r = 1;
                    virtical_r = 0;
                    if (RightArm.xaxis_X == this.panel2.Width - 80) { parall_r = 2; virtical_r = 0; }
                }
                if (parall_r == 1 && virtical_r == 0)
                {
                    RightArm.R_Right();
                }

            }

            if (RightArm.zaxis_Z <= 41)
            {
                if (parall_r == 0 && virtical_r == 1) { RightArm.Down(); }
                if (parall_r == 0 && virtical_r == 2) { RightArm.UP(); }

            }
            if (RightArm.zaxis_Z == 41) {
                virtical_r = 2;
                if (RightArm.zaxis_X == 323)
                {
                    RightArm.Release();
                }
                if (RightArm.zaxis_X == 194)
                {
                    RightArm.Seize();
                    
                }

            }

            if (RightArm.xaxis_X == this.panel2.Width - 80 && parall_r == 1 && virtical_r == 0)
            {
                parall_r = 0;
                virtical_r = 1;
            }
            if (RightArm.xaxis_X > (this.panel2.Width - 15) / 2 && parall_r == 2 && virtical_r == 0) { RightArm.R_Left(); }

            if (RightArm.xaxis_X == (this.panel2.Width - 15) / 2 && parall_r == 2 && virtical_r == 0)
            {
                parall_r = 0;
                virtical_r = 1;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(this.panel2.Width);

            //底盤
            e.Graphics.FillRectangle(Brushes.Green, 0, 115, this.Width, 15);
            //障礙物L
            e.Graphics.FillRectangle(Brushes.Gray, this.panel2.Width / 2 - 40, 95, 15, 20);
            //障礙物R
            e.Graphics.FillRectangle(Brushes.Gray, this.panel2.Width / 2 + 40, 95, 15, 20);

            //x軸長方形L
            e.Graphics.FillRectangle(Brushes.BlueViolet, LeftArm.xaxis_X, LeftArm.xaxis_Z, LeftArm.xaxis_Width, LeftArm.xaxis_Height);
            //z軸長方形L
            e.Graphics.FillRectangle(Brushes.Navy, LeftArm.zaxis_X, LeftArm.zaxis_Z, LeftArm.zaxis_Width, LeftArm.zaxis_Height);

            //x軸長方形R
            e.Graphics.FillRectangle(Brushes.BlueViolet, RightArm.xaxis_X, RightArm.xaxis_Z, RightArm.xaxis_Width, RightArm.xaxis_Height);
            //z軸長方形R
            e.Graphics.FillRectangle(Brushes.Navy, RightArm.zaxis_X, RightArm.zaxis_Z, RightArm.zaxis_Width, RightArm.zaxis_Height);
            
            //left food
            if (LeftFood.color == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, this.LeftFood.X, this.LeftFood.Z, this.LeftFood.Width, this.LeftFood.Height);
            }
            if (LeftFood.color == 1)
            {
                e.Graphics.FillRectangle(Brushes.Peru, this.LeftFood.X, this.LeftFood.Z, this.LeftFood.Width, this.LeftFood.Height);
            }

            //righy food
            if (RightFood.color == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, this.RightFood.X, this.RightFood.Z, this.RightFood.Width, this.RightFood.Height);
            }
            if (RightFood.color == 1)
            {
                e.Graphics.FillRectangle(Brushes.Peru, this.RightFood.X, this.RightFood.Z, this.RightFood.Width, this.RightFood.Height);
            }
        }

        private void START_Click(object sender, EventArgs e)
        {
            ForArm1.Start();
        }

        private void INTERRUPT_Click(object sender, EventArgs e)
        {
            if (INTERRUPT.Text.ToString().Equals("中斷"))
            {
                ForArm1.Stop();
                INTERRUPT.Text = "繼續";

            }
            else {
                ForArm1.Start();
                INTERRUPT.Text = "中斷";
            }            
        }
    }
}
