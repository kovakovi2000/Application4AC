namespace Application4AC
{
    partial class AP4AC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_License = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TestLicense = new System.Windows.Forms.Button();
            this.lbl_Aim = new System.Windows.Forms.Label();
            this.lbl_Wh = new System.Windows.Forms.Label();
            this.lbl_Exp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_License
            // 
            this.tb_License.Location = new System.Drawing.Point(12, 25);
            this.tb_License.Name = "tb_License";
            this.tb_License.Size = new System.Drawing.Size(348, 20);
            this.tb_License.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "License:";
            // 
            // btn_TestLicense
            // 
            this.btn_TestLicense.Location = new System.Drawing.Point(148, 51);
            this.btn_TestLicense.Name = "btn_TestLicense";
            this.btn_TestLicense.Size = new System.Drawing.Size(75, 23);
            this.btn_TestLicense.TabIndex = 2;
            this.btn_TestLicense.Text = "Enter";
            this.btn_TestLicense.UseVisualStyleBackColor = true;
            this.btn_TestLicense.Click += new System.EventHandler(this.btn_TestLicense_Click);
            // 
            // lbl_Aim
            // 
            this.lbl_Aim.AutoSize = true;
            this.lbl_Aim.Location = new System.Drawing.Point(12, 91);
            this.lbl_Aim.Name = "lbl_Aim";
            this.lbl_Aim.Size = new System.Drawing.Size(24, 13);
            this.lbl_Aim.TabIndex = 3;
            this.lbl_Aim.Text = "Aim";
            // 
            // lbl_Wh
            // 
            this.lbl_Wh.AutoSize = true;
            this.lbl_Wh.Location = new System.Drawing.Point(165, 91);
            this.lbl_Wh.Name = "lbl_Wh";
            this.lbl_Wh.Size = new System.Drawing.Size(49, 13);
            this.lbl_Wh.TabIndex = 4;
            this.lbl_Wh.Text = "wallhack";
            // 
            // lbl_Exp
            // 
            this.lbl_Exp.AutoSize = true;
            this.lbl_Exp.Location = new System.Drawing.Point(316, 91);
            this.lbl_Exp.Name = "lbl_Exp";
            this.lbl_Exp.Size = new System.Drawing.Size(43, 13);
            this.lbl_Exp.TabIndex = 5;
            this.lbl_Exp.Text = "Exploits";
            // 
            // AP4AC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 113);
            this.Controls.Add(this.lbl_Exp);
            this.Controls.Add(this.lbl_Wh);
            this.Controls.Add(this.lbl_Aim);
            this.Controls.Add(this.btn_TestLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_License);
            this.Name = "AP4AC";
            this.Text = "AP4AC";
            this.Load += new System.EventHandler(this.AP4AC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_License;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TestLicense;
        private System.Windows.Forms.Label lbl_Aim;
        private System.Windows.Forms.Label lbl_Wh;
        private System.Windows.Forms.Label lbl_Exp;
    }
}

