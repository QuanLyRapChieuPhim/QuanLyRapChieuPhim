using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using DTO;
using BUS;

namespace Review
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dvgNhanVien.DataSource = GetNhanVien();
            dvgNVDel_Up.DataSource = GetNhanVien();


        }
        private List<NhanVien> GetNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            qlrBUS qlr = new qlrBUS();
            return qlr.GetNhanVien(sql);
        }

        private void dvgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dvgNhanVien.Rows[e.RowIndex];
            edtMaNhanVien.Text = Convert.ToString(dgvr.Cells[0].Value);
            edtHoNhanVien.Text = Convert.ToString(dgvr.Cells[1].Value);
            edtTenNhanVien.Text = Convert.ToString(dgvr.Cells[2].Value);
            edtGioitinh.Text = Convert.ToString(dgvr.Cells[4].Value);
            edtNgaysinh.Text = Convert.ToString(dgvr.Cells[3].Value);
            edtCMND.Text = Convert.ToString(dgvr.Cells[5].Value);
            edtDiachi.Text = Convert.ToString(dgvr.Cells[6].Value);
            edtDienthoai.Text = Convert.ToString(dgvr.Cells[7].Value);
            edtMail.Text = Convert.ToString(dgvr.Cells[8].Value);
            edtChucVu.Text = Convert.ToString(dgvr.Cells[9].Value);
            edtNgayVaoLam.Text = Convert.ToString(dgvr.Cells[10].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma, ho, ten, diachi, ngaysinh, email, chucvu, ngayvaolam;
            bool gioitinh;
            int sdt, cmnd;
            ma= edtMaNV.Text;
            ho= edtAdd_Ho.Text;
            ten= edtAdd_Ten.Text;
            gioitinh= Convert.ToBoolean(edtAdd_GioiTinh.Text);
            ngaysinh= edtAdd_NgaySinh.Text;
            cmnd= Convert.ToInt32(edtAdd_CMND.Text);
            diachi= edtAdd_DiaChi.Text;
            sdt= Convert.ToInt32(edtAdd_SDT.Text);
            email= edtAdd_Email.Text;
            chucvu= edtAdd_ChucVu.Text;
            ngayvaolam= edtAdd_NgayVaoLam.Text;

            NhanVien nhanvien = new NhanVien(ma, ho, ten, ngaysinh, gioitinh, cmnd, diachi, sdt, email, chucvu, ngayvaolam);
            int i = new qlrBUS().addNhanVien(nhanvien);
            dvgNhanVien.DataSource = GetNhanVien();
        }

        private void dvgNVDel_Up_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dvgNVDel_Up.Rows[e.RowIndex];
            edtMa_NV.Text = Convert.ToString(dgvr.Cells[0].Value);
            edtHoDel_Up.Text = Convert.ToString(dgvr.Cells[1].Value);
            edtTenDel_Up.Text = Convert.ToString(dgvr.Cells[2].Value);
            edtGioiTinhDel_Up.Text = Convert.ToString(dgvr.Cells[4].Value);
            edtNgaysinhDel_Up.Text = Convert.ToString(dgvr.Cells[3].Value);
            edtCMNDDel_Up.Text = Convert.ToString(dgvr.Cells[5].Value);
            edtDiachiDel_Up.Text = Convert.ToString(dgvr.Cells[6].Value);
            edtDienThoaiDel_Up.Text = Convert.ToString(dgvr.Cells[7].Value);
            edtEmailDel_Up.Text = Convert.ToString(dgvr.Cells[8].Value);
            edtChucvuDel_Up.Text = Convert.ToString(dgvr.Cells[9].Value);
            edtNgayvaolamDel_Up.Text = Convert.ToString(dgvr.Cells[10].Value);
        }

        private void btnDelNhanVien_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NhanVien";
            NhanVien nhanvien = new NhanVien(edtMa_NV.Text, edtHoDel_Up.Text, edtTenDel_Up.Text, edtNgaysinhDel_Up.Text, Convert.ToBoolean(edtGioiTinhDel_Up.Text), Convert.ToInt32(edtCMNDDel_Up.Text), edtDiachiDel_Up.Text, Convert.ToInt32(edtDienThoaiDel_Up.Text), edtEmailDel_Up.Text, edtChucvuDel_Up.Text, edtNgayvaolamDel_Up.Text);
            int i = new qlrBUS().delNhanVien(nhanvien);
            dvgNVDel_Up.DataSource = new qlrBUS().GetNhanVien(sql);
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NhanVien";
            NhanVien nhanvien = new NhanVien(edtMa_NV.Text, edtHoDel_Up.Text, edtTenDel_Up.Text, edtNgaysinhDel_Up.Text, Convert.ToBoolean(edtGioiTinhDel_Up.Text), Convert.ToInt32(edtCMNDDel_Up.Text), edtDiachiDel_Up.Text, Convert.ToInt32(edtDienThoaiDel_Up.Text), edtEmailDel_Up.Text, edtChucvuDel_Up.Text, edtNgayvaolamDel_Up.Text);
            int i = new qlrBUS().upDateNhanVien(nhanvien);
            dvgNVDel_Up.DataSource = new qlrBUS().GetNhanVien(sql);
            dvgNhanVien.DataSource = new qlrBUS().GetNhanVien(sql);
        }

    }
}
