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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.speed2 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Loading = new System.Windows.Forms.Label();
            this.LoadConstrain = new System.Windows.Forms.TextBox();
            this.EndCount = new System.Windows.Forms.TextBox();
            this.MiddleCount = new System.Windows.Forms.TextBox();
            this.FrontCount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.speed1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.INTERRUPT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.61194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.38806F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 335);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.speed2);
            this.panel5.Location = new System.Drawing.Point(505, 261);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(78, 70);
            this.panel5.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "右臂速度";
            // 
            // speed2
            // 
            this.speed2.Enabled = false;
            this.speed2.Location = new System.Drawing.Point(4, 26);
            this.speed2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(64, 22);
            this.speed2.TabIndex = 3;
            this.speed2.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Loading);
            this.panel1.Controls.Add(this.LoadConstrain);
            this.panel1.Controls.Add(this.EndCount);
            this.panel1.Controls.Add(this.MiddleCount);
            this.panel1.Controls.Add(this.FrontCount);
            this.panel1.Location = new System.Drawing.Point(94, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 69);
            this.panel1.TabIndex = 1;
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.Location = new System.Drawing.Point(74, 41);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(65, 12);
            this.Loading.TabIndex = 4;
            this.Loading.Text = "滿載數量：";
            // 
            // LoadConstrain
            // 
            this.LoadConstrain.Location = new System.Drawing.Point(145, 34);
            this.LoadConstrain.Name = "LoadConstrain";
            this.LoadConstrain.Size = new System.Drawing.Size(100, 22);
            this.LoadConstrain.TabIndex = 3;
            this.LoadConstrain.Text = "99999";
            // 
            // EndCount
            // 
            this.EndCount.Location = new System.Drawing.Point(282, 6);
            this.EndCount.Name = "EndCount";
            this.EndCount.Size = new System.Drawing.Size(100, 22);
            this.EndCount.TabIndex = 2;
            this.EndCount.Text = "0";
            // 
            // MiddleCount
            // 
            this.MiddleCount.Location = new System.Drawing.Point(145, 6);
            this.MiddleCount.Name = "MiddleCount";
            this.MiddleCount.Size = new System.Drawing.Size(100, 22);
            this.MiddleCount.TabIndex = 1;
            this.MiddleCount.Text = "1";
            // 
            // FrontCount
            // 
            this.FrontCount.Location = new System.Drawing.Point(19, 6);
            this.FrontCount.Name = "FrontCount";
            this.FrontCount.Size = new System.Drawing.Size(100, 22);
            this.FrontCount.TabIndex = 0;
            this.FrontCount.Text = "99999";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(94, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 249);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.speed1);
            this.panel4.Location = new System.Drawing.Point(2, 261);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 70);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "左臂速度";
            // 
            // speed1
            // 
            this.speed1.Enabled = false;
            this.speed1.Location = new System.Drawing.Point(2, 26);
            this.speed1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speed1.Name = "speed1";
            this.speed1.Size = new System.Drawing.Size(76, 22);
            this.speed1.TabIndex = 2;
            this.speed1.Text = "2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Home);
            this.panel3.Controls.Add(this.EXIT);
            this.panel3.Controls.Add(this.START);
            this.panel3.Controls.Add(this.INTERRUPT);
            this.panel3.Location = new System.Drawing.Point(12, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 65);
            this.panel3.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(3, 14);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(132, 37);
            this.Home.TabIndex = 6;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(570, 14);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(98, 37);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(198, 14);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(149, 37);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // INTERRUPT
            // 
            this.INTERRUPT.Location = new System.Drawing.Point(353, 14);
            this.INTERRUPT.Name = "INTERRUPT";
            this.INTERRUPT.Size = new System.Drawing.Size(112, 37);
            this.INTERRUPT.TabIndex = 2;
            this.INTERRUPT.Text = "中斷";
            this.INTERRUPT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.INTERRUPT.UseVisualStyleBackColor = true;
            this.INTERRUPT.Click += new System.EventHandler(this.INTERRUPT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "機器手臂";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
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

