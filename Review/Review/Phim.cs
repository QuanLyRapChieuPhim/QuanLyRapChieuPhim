using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using BUS;
using DTO;
using System.IO;

namespace Review
{
    public partial class Phim : Form
    {
        public Phim()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPhim.DataSource = GetPhim();
            ChonPhim();
        }

        private List<PhimDTO> GetPhim()
        {
            List<PhimDTO> film = new List<PhimDTO>();
            try
            {
                string sql = "SELECT * FROM Phim";
                PhimBus filmbus = new PhimBus();
                film = filmbus.GetPhimBUS(sql);// 1/return -> gọi BUS -> class BUS thực thi, 2/ BUS trả ngược lại list sau khi DAL hoàn thành
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return film;
        }

        private DataSet NgayChieu()
        {
            try
            {
                string sql = "Select L.* from LichChieu L, Phim P Where L.MaPhim = P.MaPhim and P.MaPhim =N'"+ lbMaPhim.Text + "'";
                return (new NgayChieuBUS().GetNgayChieuBUS(sql));
            }
            catch (SqlException ex)
            {                
                throw ex;
            }

        }

        private DataSet GioChieu()
        {
            try
            {
                string sql = "Select GioChieu from LichChieu where MaPhim = N'" + lbMaPhim.Text + "' and NgayChieu = '"+ lbNgayChieu.Text +"'";
                return (new GioChieuBUS().GetGioChieuBus(sql));
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }

        //private List<NgayChieuDTO> NgayChieu()
        //{
        //    List<NgayChieuDTO> ngaychieu = new List<NgayChieuDTO>();
        //    try
        //    {
        //        string sql = "Select * from NgayChieu";
        //        NgayChieuBUS ngaychieubus = new NgayChieuBUS();
        //        ngaychieu = ngaychieubus.GetNgayChieuBUS(sql);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    return ngaychieu;
        //}

        private void ChonPhim()
        {
            string tenphim;
            List<PhimDTO> film = new List<PhimDTO>();
            film = GetPhim();
            for (int i = 0; i < film.Count; i++)
            {
                tenphim = film[i].TenPhim;
                cbTenPhim.Items.Add(tenphim);
            }
        }

        private System.Drawing.Image ConvertBytetoImage(byte[] bytnp)
        {
            System.Drawing.Image QuocHuy;
            using (MemoryStream stream = new MemoryStream(bytnp))
            {
                QuocHuy = Image.FromStream(stream);
            }
            return QuocHuy;
        }

        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTenPhim.SelectedIndex;
            lbMaPhim.Text = dgvPhim.Rows[index].Cells[0].Value.ToString().Trim();
            lbTenPhim.Text = dgvPhim.Rows[index].Cells[1].Value.ToString().Trim();
            lbDaoDien.Text = dgvPhim.Rows[index].Cells[2].Value.ToString().Trim();
            lbQuocGia.Text = dgvPhim.Rows[index].Cells[3].Value.ToString().Trim();
            lbNam.Text = dgvPhim.Rows[index].Cells[4].Value.ToString().Trim();
            lbThoiLuong.Text = dgvPhim.Rows[index].Cells[5].Value.ToString().Trim();
            lbTheLoai.Text = dgvPhim.Rows[index].Cells[6].Value.ToString().Trim();
            //Lay Hinh
            OnePhimBus np = new OnePhimBus();
            PhimDTO phim = np.GetOnePhimBUS(lbMaPhim.Text);
            pictureBox1.Image = ConvertBytetoImage(phim.HinhAnh);

            cbNgayChieu.DataSource = NgayChieu().Tables[0];
            cbNgayChieu.DisplayMember = "NgayChieu";
            cbNgayChieu.ValueMember = "MaPhim";
        }

        private void cbNgayChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = gbInfo.Visible = lbTenPhim.Visible = lbGioChieu.Visible = true;
            lbNgayChieu.Text = cbNgayChieu.Text;
            lbGioChieu.DataSource = GioChieu().Tables[0];
            lbGioChieu.DisplayMember = "GioChieu";
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            ThongTinPhim form2 = new ThongTinPhim();
            form2.Show();
        }
    }
}
