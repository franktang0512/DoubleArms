namespace DoubleArms
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ForArm1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Loading = new System.Windows.Forms.Label();
            this.LoadConstrain = new System.Windows.Forms.TextBox();
            this.EndCount = new System.Windows.Forms.TextBox();
            this.MiddleCount = new System.Windows.Forms.TextBox();
            this.FrontCount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.speed1 = new System.Windows.Forms.TextBox();
            this.speed2 = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.INTERRUPT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForArm1
            // 
            this.ForArm1.Enabled = true;
            this.ForArm1.Interval = 10;
            this.ForArm1.Tick += new System.EventHandler(this.ForArm1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.06798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.93202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.61194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.38806F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 419);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Loading);
            this.panel1.Controls.Add(this.LoadConstrain);
            this.panel1.Controls.Add(this.EndCount);
            this.panel1.Controls.Add(this.MiddleCount);
            this.panel1.Controls.Add(this.FrontCount);
            this.panel1.Location = new System.Drawing.Point(125, 329);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 86);
            this.panel1.TabIndex = 1;
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.Location = new System.Drawing.Point(99, 51);
            this.Loading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(82, 15);
            this.Loading.TabIndex = 4;
            this.Loading.Text = "滿載數量：";
            // 
            // LoadConstrain
            // 
            this.LoadConstrain.Location = new System.Drawing.Point(193, 42);
            this.LoadConstrain.Margin = new System.Windows.Forms.Padding(4);
            this.LoadConstrain.Name = "LoadConstrain";
            this.LoadConstrain.Size = new System.Drawing.Size(132, 25);
            this.LoadConstrain.TabIndex = 3;
            this.LoadConstrain.Text = "3";
            // 
            // EndCount
            // 
            this.EndCount.Location = new System.Drawing.Point(376, 8);
            this.EndCount.Margin = new System.Windows.Forms.Padding(4);
            this.EndCount.Name = "EndCount";
            this.EndCount.Size = new System.Drawing.Size(132, 25);
            this.EndCount.TabIndex = 2;
            this.EndCount.Text = "0";
            // 
            // MiddleCount
            // 
            this.MiddleCount.Location = new System.Drawing.Point(193, 8);
            this.MiddleCount.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleCount.Name = "MiddleCount";
            this.MiddleCount.Size = new System.Drawing.Size(132, 25);
            this.MiddleCount.TabIndex = 1;
            this.MiddleCount.Text = "1";
            // 
            // FrontCount
            // 
            this.FrontCount.Location = new System.Drawing.Point(25, 8);
            this.FrontCount.Margin = new System.Windows.Forms.Padding(4);
            this.FrontCount.Name = "FrontCount";
            this.FrontCount.Size = new System.Drawing.Size(132, 25);
            this.FrontCount.TabIndex = 0;
            this.FrontCount.Text = "9";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(125, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 311);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // speed1
            // 
            this.speed1.Location = new System.Drawing.Point(3, 33);
            this.speed1.Name = "speed1";
            this.speed1.Size = new System.Drawing.Size(100, 25);
            this.speed1.TabIndex = 2;
            this.speed1.Text = "2";
            // 
            // speed2
            // 
            this.speed2.Location = new System.Drawing.Point(6, 33);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(84, 25);
            this.speed2.TabIndex = 3;
            this.speed2.Text = "1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Home);
            this.panel3.Controls.Add(this.EXIT);
            this.panel3.Controls.Add(this.START);
            this.panel3.Controls.Add(this.INTERRUPT);
            this.panel3.Location = new System.Drawing.Point(16, 489);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 81);
            this.panel3.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(4, 18);
            this.Home.Margin = new System.Windows.Forms.Padding(4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(176, 46);
            this.Home.TabIndex = 6;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(760, 18);
            this.EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(131, 46);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(264, 18);
            this.START.Margin = new System.Windows.Forms.Padding(4);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(199, 46);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // INTERRUPT
            // 
            this.INTERRUPT.Location = new System.Drawing.Point(471, 18);
            this.INTERRUPT.Margin = new System.Windows.Forms.Padding(4);
            this.INTERRUPT.Name = "INTERRUPT";
            this.INTERRUPT.Size = new System.Drawing.Size(149, 46);
            this.INTERRUPT.TabIndex = 2;
            this.INTERRUPT.Text = "中斷";
            this.INTERRUPT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.INTERRUPT.UseVisualStyleBackColor = true;
            this.INTERRUPT.Click += new System.EventHandler(this.INTERRUPT_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.speed1);
            this.panel4.Location = new System.Drawing.Point(3, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 88);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.speed2);
            this.panel5.Location = new System.Drawing.Point(674, 328);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 88);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "左臂速度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "右臂速度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "機器手臂";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ForArm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button INTERRUPT;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TextBox EndCount;
        private System.Windows.Forms.TextBox MiddleCount;
        private System.Windows.Forms.TextBox FrontCount;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.TextBox LoadConstrain;
        private System.Windows.Forms.TextBox speed1;
        private System.Windows.Forms.MaskedTextBox speed2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}

