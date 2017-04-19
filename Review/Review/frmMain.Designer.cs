namespace Review
{
    partial class frmMain
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
            this.Login = new System.Windows.Forms.GroupBox();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(151, 40);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "groupBox1";
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(24, 47);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(106, 49);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "QLNV";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnQLNV);
            this.gbMenu.Controls.Add(this.button3);
            this.gbMenu.Controls.Add(this.button2);
            this.gbMenu.Location = new System.Drawing.Point(12, 58);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(151, 294);
            this.gbMenu.TabIndex = 3;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "groupBox1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 422);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.Login);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbMenu;
    }
}