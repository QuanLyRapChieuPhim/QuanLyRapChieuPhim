namespace Review
{
    partial class Phim
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
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.cbTenPhim = new System.Windows.Forms.ComboBox();
            this.lbTenPhim = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbThoiLuong = new System.Windows.Forms.Label();
            this.lbDaoDien = new System.Windows.Forms.Label();
            this.lbQuocGia = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.lbMaPhim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNgayChieu = new System.Windows.Forms.ComboBox();
            this.lbNgayChieu = new System.Windows.Forms.Label();
            this.lbGioChieu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhim
            // 
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Location = new System.Drawing.Point(12, 12);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.Size = new System.Drawing.Size(13, 21);
            this.dgvPhim.TabIndex = 0;
            this.dgvPhim.Visible = false;
            // 
            // cbTenPhim
            // 
            this.cbTenPhim.BackColor = System.Drawing.Color.White;
            this.cbTenPhim.ForeColor = System.Drawing.Color.Black;
            this.cbTenPhim.FormattingEnabled = true;
            this.cbTenPhim.Location = new System.Drawing.Point(201, 11);
            this.cbTenPhim.Name = "cbTenPhim";
            this.cbTenPhim.Size = new System.Drawing.Size(380, 21);
            this.cbTenPhim.TabIndex = 2;
            this.cbTenPhim.SelectedIndexChanged += new System.EventHandler(this.cbTenPhim_SelectedIndexChanged);
            // 
            // lbTenPhim
            // 
            this.lbTenPhim.AllowDrop = true;
            this.lbTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhim.ForeColor = System.Drawing.Color.Black;
            this.lbTenPhim.Location = new System.Drawing.Point(229, 73);
            this.lbTenPhim.Name = "lbTenPhim";
            this.lbTenPhim.Size = new System.Drawing.Size(352, 47);
            this.lbTenPhim.TabIndex = 3;
            this.lbTenPhim.Text = "Ten Phim";
            this.lbTenPhim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTenPhim.Visible = false;
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AllowDrop = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.ForeColor = System.Drawing.Color.Black;
            this.lbTheLoai.Location = new System.Drawing.Point(121, 117);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(162, 70);
            this.lbTheLoai.TabIndex = 3;
            this.lbTheLoai.Text = "TheLoai";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.ForeColor = System.Drawing.Color.Black;
            this.lbNam.Location = new System.Drawing.Point(121, 67);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(54, 16);
            this.lbNam.TabIndex = 3;
            this.lbNam.Text = "NamSX";
            // 
            // lbThoiLuong
            // 
            this.lbThoiLuong.AutoSize = true;
            this.lbThoiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiLuong.ForeColor = System.Drawing.Color.Black;
            this.lbThoiLuong.Location = new System.Drawing.Point(121, 92);
            this.lbThoiLuong.Name = "lbThoiLuong";
            this.lbThoiLuong.Size = new System.Drawing.Size(72, 16);
            this.lbThoiLuong.TabIndex = 3;
            this.lbThoiLuong.Text = "ThoiLuong";
            // 
            // lbDaoDien
            // 
            this.lbDaoDien.AutoSize = true;
            this.lbDaoDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDaoDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbDaoDien.Location = new System.Drawing.Point(121, 16);
            this.lbDaoDien.Name = "lbDaoDien";
            this.lbDaoDien.Size = new System.Drawing.Size(62, 16);
            this.lbDaoDien.TabIndex = 3;
            this.lbDaoDien.Text = "DaoDien";
            // 
            // lbQuocGia
            // 
            this.lbQuocGia.AutoSize = true;
            this.lbQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuocGia.ForeColor = System.Drawing.Color.Black;
            this.lbQuocGia.Location = new System.Drawing.Point(122, 41);
            this.lbQuocGia.Name = "lbQuocGia";
            this.lbQuocGia.Size = new System.Drawing.Size(61, 16);
            this.lbQuocGia.TabIndex = 3;
            this.lbQuocGia.Text = "QuocGia";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.lbQuocGia);
            this.gbInfo.Controls.Add(this.lbNam);
            this.gbInfo.Controls.Add(this.lbDaoDien);
            this.gbInfo.Controls.Add(this.lbTheLoai);
            this.gbInfo.Controls.Add(this.lbThoiLuong);
            this.gbInfo.Location = new System.Drawing.Point(229, 123);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(302, 204);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thể Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thời Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Năm Sản Xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quốc Gia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đạo diễn:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(95, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chọn Phim:";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.ForeColor = System.Drawing.Color.Black;
            this.btnBuyTicket.Location = new System.Drawing.Point(74, 292);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(75, 35);
            this.btnBuyTicket.TabIndex = 7;
            this.btnBuyTicket.Text = "Mua vé";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // lbMaPhim
            // 
            this.lbMaPhim.AllowDrop = true;
            this.lbMaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhim.ForeColor = System.Drawing.Color.Black;
            this.lbMaPhim.Location = new System.Drawing.Point(8, 32);
            this.lbMaPhim.Name = "lbMaPhim";
            this.lbMaPhim.Size = new System.Drawing.Size(28, 24);
            this.lbMaPhim.TabIndex = 3;
            this.lbMaPhim.Text = "Mã Phim";
            this.lbMaPhim.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(95, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày:";
            // 
            // cbNgayChieu
            // 
            this.cbNgayChieu.FormattingEnabled = true;
            this.cbNgayChieu.Location = new System.Drawing.Point(201, 38);
            this.cbNgayChieu.Name = "cbNgayChieu";
            this.cbNgayChieu.Size = new System.Drawing.Size(173, 21);
            this.cbNgayChieu.TabIndex = 9;
            this.cbNgayChieu.SelectedIndexChanged += new System.EventHandler(this.cbNgayChieu_SelectedIndexChanged);
            // 
            // lbNgayChieu
            // 
            this.lbNgayChieu.AutoSize = true;
            this.lbNgayChieu.Location = new System.Drawing.Point(31, 11);
            this.lbNgayChieu.Name = "lbNgayChieu";
            this.lbNgayChieu.Size = new System.Drawing.Size(35, 13);
            this.lbNgayChieu.TabIndex = 11;
            this.lbNgayChieu.Text = "label8";
            this.lbNgayChieu.Visible = false;
            // 
            // lbGioChieu
            // 
            this.lbGioChieu.FormattingEnabled = true;
            this.lbGioChieu.Location = new System.Drawing.Point(537, 128);
            this.lbGioChieu.Name = "lbGioChieu";
            this.lbGioChieu.Size = new System.Drawing.Size(44, 199);
            this.lbGioChieu.TabIndex = 12;
            this.lbGioChieu.Visible = false;
            // 
            // Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(588, 334);
            this.Controls.Add(this.lbGioChieu);
            this.Controls.Add(this.lbNgayChieu);
            this.Controls.Add(this.cbNgayChieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.lbMaPhim);
            this.Controls.Add(this.lbTenPhim);
            this.Controls.Add(this.cbTenPhim);
            this.Controls.Add(this.dgvPhim);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Phim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Phim";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.ComboBox cbTenPhim;
        private System.Windows.Forms.Label lbTenPhim;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbThoiLuong;
        private System.Windows.Forms.Label lbDaoDien;
        private System.Windows.Forms.Label lbQuocGia;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Label lbMaPhim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNgayChieu;
        private System.Windows.Forms.Label lbNgayChieu;
        private System.Windows.Forms.ListBox lbGioChieu;
    }
}

