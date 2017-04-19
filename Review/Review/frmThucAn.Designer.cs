namespace Review
{
    partial class frmThucAn
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvgThucAn = new System.Windows.Forms.DataGridView();
            this.edtDonVi = new System.Windows.Forms.TextBox();
            this.edtTenThucAn = new System.Windows.Forms.TextBox();
            this.edtCombo = new System.Windows.Forms.TextBox();
            this.edtDonGia = new System.Windows.Forms.TextBox();
            this.edtMaThucAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edtAdd_donvi = new System.Windows.Forms.TextBox();
            this.edtAdd_tenthucan = new System.Windows.Forms.TextBox();
            this.edtAdd_combo = new System.Windows.Forms.TextBox();
            this.edtAdd_dongia = new System.Windows.Forms.TextBox();
            this.edtAdd_thucan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemThucAn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.edtDonViDel_Up = new System.Windows.Forms.TextBox();
            this.edtTenThucAnDel_Up = new System.Windows.Forms.TextBox();
            this.edtComboDel_Up = new System.Windows.Forms.TextBox();
            this.edtDonGiaDel_Up = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSuaThucAn = new System.Windows.Forms.Button();
            this.btnDelThucAn = new System.Windows.Forms.Button();
            this.dgvThucAnDel_Up = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbThucAnMaDel_Up = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgThucAn)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAnDel_Up)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 304);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvgThucAn);
            this.tabPage1.Controls.Add(this.edtDonVi);
            this.tabPage1.Controls.Add(this.edtTenThucAn);
            this.tabPage1.Controls.Add(this.edtCombo);
            this.tabPage1.Controls.Add(this.edtDonGia);
            this.tabPage1.Controls.Add(this.edtMaThucAn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvgThucAn
            // 
            this.dvgThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgThucAn.Location = new System.Drawing.Point(0, 193);
            this.dvgThucAn.Name = "dvgThucAn";
            this.dvgThucAn.Size = new System.Drawing.Size(603, 94);
            this.dvgThucAn.TabIndex = 0;
            this.dvgThucAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgThucAn_CellClick);
            // 
            // edtDonVi
            // 
            this.edtDonVi.Location = new System.Drawing.Point(144, 100);
            this.edtDonVi.Name = "edtDonVi";
            this.edtDonVi.ReadOnly = true;
            this.edtDonVi.Size = new System.Drawing.Size(59, 20);
            this.edtDonVi.TabIndex = 2;
            // 
            // edtTenThucAn
            // 
            this.edtTenThucAn.Location = new System.Drawing.Point(144, 70);
            this.edtTenThucAn.Name = "edtTenThucAn";
            this.edtTenThucAn.ReadOnly = true;
            this.edtTenThucAn.Size = new System.Drawing.Size(170, 20);
            this.edtTenThucAn.TabIndex = 2;
            // 
            // edtCombo
            // 
            this.edtCombo.Location = new System.Drawing.Point(320, 42);
            this.edtCombo.Name = "edtCombo";
            this.edtCombo.ReadOnly = true;
            this.edtCombo.Size = new System.Drawing.Size(57, 20);
            this.edtCombo.TabIndex = 2;
            // 
            // edtDonGia
            // 
            this.edtDonGia.Location = new System.Drawing.Point(485, 127);
            this.edtDonGia.Name = "edtDonGia";
            this.edtDonGia.ReadOnly = true;
            this.edtDonGia.Size = new System.Drawing.Size(90, 20);
            this.edtDonGia.TabIndex = 2;
            // 
            // edtMaThucAn
            // 
            this.edtMaThucAn.Location = new System.Drawing.Point(144, 40);
            this.edtMaThucAn.Name = "edtMaThucAn";
            this.edtMaThucAn.ReadOnly = true;
            this.edtMaThucAn.Size = new System.Drawing.Size(100, 20);
            this.edtMaThucAn.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên thức ăn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn vị:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thức ăn: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Combo: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edtAdd_donvi);
            this.tabPage2.Controls.Add(this.edtAdd_tenthucan);
            this.tabPage2.Controls.Add(this.edtAdd_combo);
            this.tabPage2.Controls.Add(this.edtAdd_dongia);
            this.tabPage2.Controls.Add(this.edtAdd_thucan);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnThemThucAn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm thức ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edtAdd_donvi
            // 
            this.edtAdd_donvi.Location = new System.Drawing.Point(129, 81);
            this.edtAdd_donvi.Name = "edtAdd_donvi";
            this.edtAdd_donvi.Size = new System.Drawing.Size(59, 20);
            this.edtAdd_donvi.TabIndex = 27;
            // 
            // edtAdd_tenthucan
            // 
            this.edtAdd_tenthucan.Location = new System.Drawing.Point(129, 51);
            this.edtAdd_tenthucan.Name = "edtAdd_tenthucan";
            this.edtAdd_tenthucan.Size = new System.Drawing.Size(170, 20);
            this.edtAdd_tenthucan.TabIndex = 29;
            // 
            // edtAdd_combo
            // 
            this.edtAdd_combo.Location = new System.Drawing.Point(441, 51);
            this.edtAdd_combo.Name = "edtAdd_combo";
            this.edtAdd_combo.Size = new System.Drawing.Size(57, 20);
            this.edtAdd_combo.TabIndex = 28;
            // 
            // edtAdd_dongia
            // 
            this.edtAdd_dongia.Location = new System.Drawing.Point(441, 77);
            this.edtAdd_dongia.Name = "edtAdd_dongia";
            this.edtAdd_dongia.Size = new System.Drawing.Size(90, 20);
            this.edtAdd_dongia.TabIndex = 31;
            // 
            // edtAdd_thucan
            // 
            this.edtAdd_thucan.Location = new System.Drawing.Point(129, 21);
            this.edtAdd_thucan.Name = "edtAdd_thucan";
            this.edtAdd_thucan.Size = new System.Drawing.Size(100, 20);
            this.edtAdd_thucan.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên thức ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Đơn vị:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Đơn giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mã thức ăn: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Combo: ";
            // 
            // btnThemThucAn
            // 
            this.btnThemThucAn.Location = new System.Drawing.Point(177, 143);
            this.btnThemThucAn.Name = "btnThemThucAn";
            this.btnThemThucAn.Size = new System.Drawing.Size(122, 40);
            this.btnThemThucAn.TabIndex = 21;
            this.btnThemThucAn.Text = "button1";
            this.btnThemThucAn.UseVisualStyleBackColor = true;
            this.btnThemThucAn.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.edtDonViDel_Up);
            this.tabPage3.Controls.Add(this.edtTenThucAnDel_Up);
            this.tabPage3.Controls.Add(this.edtComboDel_Up);
            this.tabPage3.Controls.Add(this.edtDonGiaDel_Up);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.btnSuaThucAn);
            this.tabPage3.Controls.Add(this.btnDelThucAn);
            this.tabPage3.Controls.Add(this.dgvThucAnDel_Up);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.cmbThucAnMaDel_Up);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(722, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chỉnh sửa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // edtDonViDel_Up
            // 
            this.edtDonViDel_Up.Location = new System.Drawing.Point(153, 108);
            this.edtDonViDel_Up.Name = "edtDonViDel_Up";
            this.edtDonViDel_Up.Size = new System.Drawing.Size(59, 20);
            this.edtDonViDel_Up.TabIndex = 43;
            // 
            // edtTenThucAnDel_Up
            // 
            this.edtTenThucAnDel_Up.Location = new System.Drawing.Point(153, 78);
            this.edtTenThucAnDel_Up.Name = "edtTenThucAnDel_Up";
            this.edtTenThucAnDel_Up.Size = new System.Drawing.Size(170, 20);
            this.edtTenThucAnDel_Up.TabIndex = 45;
            // 
            // edtComboDel_Up
            // 
            this.edtComboDel_Up.Location = new System.Drawing.Point(465, 78);
            this.edtComboDel_Up.Name = "edtComboDel_Up";
            this.edtComboDel_Up.Size = new System.Drawing.Size(57, 20);
            this.edtComboDel_Up.TabIndex = 44;
            // 
            // edtDonGiaDel_Up
            // 
            this.edtDonGiaDel_Up.Location = new System.Drawing.Point(465, 104);
            this.edtDonGiaDel_Up.Name = "edtDonGiaDel_Up";
            this.edtDonGiaDel_Up.Size = new System.Drawing.Size(90, 20);
            this.edtDonGiaDel_Up.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Tên thức ăn:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Đơn vị:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Đơn giá:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(419, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Combo: ";
            // 
            // btnSuaThucAn
            // 
            this.btnSuaThucAn.Location = new System.Drawing.Point(554, 207);
            this.btnSuaThucAn.Name = "btnSuaThucAn";
            this.btnSuaThucAn.Size = new System.Drawing.Size(80, 32);
            this.btnSuaThucAn.TabIndex = 38;
            this.btnSuaThucAn.Text = "Sửa";
            this.btnSuaThucAn.UseVisualStyleBackColor = true;
            // 
            // btnDelThucAn
            // 
            this.btnDelThucAn.Location = new System.Drawing.Point(464, 207);
            this.btnDelThucAn.Name = "btnDelThucAn";
            this.btnDelThucAn.Size = new System.Drawing.Size(84, 32);
            this.btnDelThucAn.TabIndex = 37;
            this.btnDelThucAn.Text = "Xóa";
            this.btnDelThucAn.UseVisualStyleBackColor = true;
            this.btnDelThucAn.Click += new System.EventHandler(this.btnDelThucAn_Click);
            // 
            // dgvThucAnDel_Up
            // 
            this.dgvThucAnDel_Up.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucAnDel_Up.Location = new System.Drawing.Point(0, 189);
            this.dgvThucAnDel_Up.Name = "dgvThucAnDel_Up";
            this.dgvThucAnDel_Up.Size = new System.Drawing.Size(413, 89);
            this.dgvThucAnDel_Up.TabIndex = 36;
            this.dgvThucAnDel_Up.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDel_Up_CellClick);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(59, 54);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "Mã khách hàng: ";
            // 
            // cmbThucAnMaDel_Up
            // 
            this.cmbThucAnMaDel_Up.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThucAnMaDel_Up.FormattingEnabled = true;
            this.cmbThucAnMaDel_Up.Location = new System.Drawing.Point(153, 51);
            this.cmbThucAnMaDel_Up.Name = "cmbThucAnMaDel_Up";
            this.cmbThucAnMaDel_Up.Size = new System.Drawing.Size(132, 21);
            this.cmbThucAnMaDel_Up.TabIndex = 0;
            this.cmbThucAnMaDel_Up.SelectedIndexChanged += new System.EventHandler(this.cmbThucAnMaDel_Up_SelectedIndexChanged);
            // 
            // frmThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmThucAn";
            this.Text = "frmThucAn";
            this.Load += new System.EventHandler(this.frmThucAn_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgThucAn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAnDel_Up)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvgThucAn;
        private System.Windows.Forms.TextBox edtDonVi;
        private System.Windows.Forms.TextBox edtTenThucAn;
        private System.Windows.Forms.TextBox edtCombo;
        private System.Windows.Forms.TextBox edtDonGia;
        private System.Windows.Forms.TextBox edtMaThucAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThemThucAn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSuaThucAn;
        private System.Windows.Forms.Button btnDelThucAn;
        private System.Windows.Forms.DataGridView dgvThucAnDel_Up;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbThucAnMaDel_Up;
        private System.Windows.Forms.TextBox edtAdd_donvi;
        private System.Windows.Forms.TextBox edtAdd_tenthucan;
        private System.Windows.Forms.TextBox edtAdd_combo;
        private System.Windows.Forms.TextBox edtAdd_dongia;
        private System.Windows.Forms.TextBox edtAdd_thucan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtDonViDel_Up;
        private System.Windows.Forms.TextBox edtTenThucAnDel_Up;
        private System.Windows.Forms.TextBox edtComboDel_Up;
        private System.Windows.Forms.TextBox edtDonGiaDel_Up;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}