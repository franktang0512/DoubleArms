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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EXIT = new System.Windows.Forms.Button();
            this.LOAD = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.INTERRUPT = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.HOME = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.15804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.84196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.73965F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.26035F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(148, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 250);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 356);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(648, 53);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Controls.Add(this.LOAD);
            this.panel1.Controls.Add(this.SAVE);
            this.panel1.Controls.Add(this.INTERRUPT);
            this.panel1.Controls.Add(this.START);
            this.panel1.Controls.Add(this.HOME);
            this.panel1.Location = new System.Drawing.Point(13, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 43);
            this.panel1.TabIndex = 2;
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(546, 3);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(98, 37);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.EXIT.UseVisualStyleBackColor = true;
            // 
            // LOAD
            // 
            this.LOAD.Location = new System.Drawing.Point(463, 7);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(63, 29);
            this.LOAD.TabIndex = 4;
            this.LOAD.Text = "LOAD";
            this.LOAD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.LOAD.UseVisualStyleBackColor = true;
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(393, 7);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(64, 29);
            this.SAVE.TabIndex = 3;
            this.SAVE.Text = "SAVE";
            this.SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SAVE.UseVisualStyleBackColor = true;
            // 
            // INTERRUPT
            // 
            this.INTERRUPT.Location = new System.Drawing.Point(275, 3);
            this.INTERRUPT.Name = "INTERRUPT";
            this.INTERRUPT.Size = new System.Drawing.Size(112, 37);
            this.INTERRUPT.TabIndex = 2;
            this.INTERRUPT.Text = "中斷";
            this.INTERRUPT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.INTERRUPT.UseVisualStyleBackColor = true;
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(120, 3);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(149, 37);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            // 
            // HOME
            // 
            this.HOME.Location = new System.Drawing.Point(3, 3);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(111, 37);
            this.HOME.TabIndex = 0;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "機器手臂";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormView_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ForArm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button LOAD;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button INTERRUPT;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Panel panel2;
    }
}

