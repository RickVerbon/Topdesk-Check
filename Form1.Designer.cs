namespace Topdesk_Api
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_statuscodetext = new System.Windows.Forms.Label();
            this.lbl_last = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(44, 27);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(101, 31);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Start timer";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_statuscodetext
            // 
            this.lbl_statuscodetext.AutoSize = true;
            this.lbl_statuscodetext.Location = new System.Drawing.Point(14, 70);
            this.lbl_statuscodetext.Name = "lbl_statuscodetext";
            this.lbl_statuscodetext.Size = new System.Drawing.Size(88, 15);
            this.lbl_statuscodetext.TabIndex = 1;
            this.lbl_statuscodetext.Text = "Last new ticket:";
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(103, 70);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(12, 15);
            this.lbl_last.TabIndex = 2;
            this.lbl_last.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Refresh rate in seconds:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(151, 7);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 91);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_last);
            this.Controls.Add(this.lbl_statuscodetext);
            this.Controls.Add(this.btn_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Topdesk Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_connect;
        private Label lbl_statuscodetext;
        private Label lbl_last;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private NumericUpDown numericUpDown1;
    }
}