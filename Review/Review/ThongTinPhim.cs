using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

using BUS;
using DTO;
namespace Review
{
    public partial class ThongTinPhim : Form
    {
        OpenFileDialog open;

        public ThongTinPhim()
        {
            InitializeComponent();
        }

        private void ThongTinPhim_Load(object sender, EventArgs e)
        {
            dgvPhim.DataSource = GetPhim();
            ChonMaPhim();
        }

        private List<PhimDTO> GetPhim()
        {
            try
            {
                string sql = "SELECT * FROM Phim";
                return (new PhimBus().GetPhimBUS(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //private void XoaMaPhim()
        //{
        //    string maphim;
        //    List<PhimDTO> film = new List<PhimDTO>();
        //    film = GetPhim();
        //    for (int i = 0; i < film.Count; i++)
        //    {
        //        maphim = film[i].MaPhim;
        //        cbMaPhim.Items.Remove(maphim);
        //    }
        //}

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = open.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtHinhAnh.Text = open.FileName;
                picImage.ImageLocation = open.FileName;
            }
        }      

        private void cbMaPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbMaPhim.SelectedIndex;
            OnePhimBus np = new OnePhimBus();
            PhimDTO phim = np.GetOnePhimBUS(cbMaPhim.Text);
            //picImage.ImageLocation = open.FileName;
            txtTenPhim.Text = phim.TenPhim;
            txtDaoDien.Text = phim.DaoDien;
            txtQuocGia.Text = phim.QuocGia;
            txtNam.Text = phim.Nam.ToString();
            txtThoiLuong.Text = phim.ThoiLuong.ToString();
            txtTheLoai.Text = phim.TheLoai;
            picImage.Image = ConvertByteToImage(phim.HinhAnh);
        }        

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhim, tenPhim, daoDien, quocGia, theLoai;
            int nam, thoiLuong;
            byte[] hinhAnh;

            maPhim = Convert.ToString(cbMaPhim.Text);
            tenPhim = Convert.ToString(txtTenPhim.Text);
            daoDien = Convert.ToString(txtDaoDien.Text);
            quocGia = Convert.ToString(txtQuocGia.Text);
            nam = Convert.ToInt32(txtNam.Text);
            thoiLuong = Convert.ToInt32(txtThoiLuong.Text);
            theLoai = Convert.ToString(txtTheLoai.Text);
            hinhAnh = ConvertImageToByte();

            PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai, hinhAnh);
            int themphim = new ThemPhimBus().Them_PhimBus(film);

            dgvPhim.DataSource = GetPhim();
            cbMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtQuocGia.Text = txtTheLoai.Text = txtNam.Text = txtThoiLuong.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhim, tenPhim, daoDien, quocGia, theLoai;
            int nam, thoiLuong;
            byte[] hinhAnh;

            maPhim = Convert.ToString(cbMaPhim.Text);
            tenPhim = Convert.ToString(txtTenPhim.Text);
            daoDien = Convert.ToString(txtDaoDien.Text);
            quocGia = Convert.ToString(txtQuocGia.Text);
            theLoai = Convert.ToString(txtTheLoai.Text);
            nam = Convert.ToInt32(txtNam.Text);
            thoiLuong = Convert.ToInt32(txtThoiLuong.Text);
            hinhAnh = ConvertImageToByte();

            PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai, hinhAnh);
            int suaphim = new SuaPhimBus().Sua_PhimBus(film);

            dgvPhim.DataSource = GetPhim();
            cbMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtQuocGia.Text = txtTheLoai.Text = txtNam.Text = txtThoiLuong.Text = txtHinhAnh.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhim, tenPhim, daoDien, quocGia, theLoai;
            int nam, thoiLuong;

            maPhim = Convert.ToString(cbMaPhim.Text);
            tenPhim = Convert.ToString(txtTenPhim.Text);
            daoDien = Convert.ToString(txtDaoDien.Text);
            quocGia = Convert.ToString(txtQuocGia.Text);
            theLoai = Convert.ToString(txtTheLoai.Text);
            nam = Convert.ToInt32(txtNam.Text);
            thoiLuong = Convert.ToInt32(txtThoiLuong.Text);

            PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai);
            int xoaphim = new XoaPhimBus().Xoa_PhimBus(film);

            dgvPhim.DataSource = GetPhim();
            cbMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtQuocGia.Text = txtTheLoai.Text = txtNam.Text = txtThoiLuong.Text = txtHinhAnh.Text = "";
        }

        public byte[] ConvertImageToByte()
        {
            FileStream fs;
            fs = new FileStream(txtHinhAnh.Text, FileMode.Open, FileAccess.Read);

            byte[] picbyte = new byte[fs.Length];

            fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        public Image ConvertByteToImage(byte[] bytnp)
        {
            Image hinhanh;
            using (MemoryStream stream = new MemoryStream(bytnp))
            {
                hinhanh = Image.FromStream(stream);
            }
            return hinhanh;
        }

        private void ChonMaPhim()
        {
            string maphim;
            List<PhimDTO> film = new List<PhimDTO>();
            film = GetPhim();
            for (int i = 0; i < film.Count; i++)
            {
                maphim = film[i].MaPhim;
                cbMaPhim.Items.Add(maphim);
            }
        }
    }
}
