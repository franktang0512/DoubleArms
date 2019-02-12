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
        private int arm1_x, arm1_y;
        private int arm1_width, arm1_height;

        Arm arm;


        //enum Position
        //{
        //    Left, Right, Up, Down
        //}
        //private Position _objPosition;

        public Form1()
        {
            InitializeComponent();
            arm1_x = 0;
            arm1_y = 100;
            arm1_width = 100;
            arm1_height = 30;
        }

        private void ForArm1_Tick(object sender, EventArgs e)
        {
            arm1_width += 1;
            Console.WriteLine("000000000000000000");
            Invalidate();
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, arm1_x, arm1_y, arm1_width, arm1_height);
        }
    }
}
