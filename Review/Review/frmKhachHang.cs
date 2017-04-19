using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DTO;
using BUS;

namespace Review
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dvgKhachHang.DataSource = GetKhachHang();

            cmbMaDel_Up.DataSource = GetKhachHang();
            cmbMaDel_Up.DisplayMember = "KhachHang";
            cmbMaDel_Up.ValueMember = "MaKhachHang";
        }

        private List<KhachHang> GetKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            qlrBUS qlr = new qlrBUS();
            return qlr.GetKhachHang(sql);
        }

        private void dvgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dvgKhachHang.Rows[e.RowIndex];
            edtMa.Text = Convert.ToString(dgvr.Cells[0].Value);
            edtHo.Text = Convert.ToString(dgvr.Cells[1].Value);
            edtTen.Text = Convert.ToString(dgvr.Cells[2].Value);
            edtGioitinh.Text = Convert.ToString(dgvr.Cells[3].Value);
            edtNgaysinh.Text = Convert.ToString(dgvr.Cells[4].Value);
            edtDiachi.Text = Convert.ToString(dgvr.Cells[5].Value);
            edtMail.Text = Convert.ToString(dgvr.Cells[6].Value);
            edtDienthoai.Text = Convert.ToString(dgvr.Cells[7].Value);
            edtDiem.Text = Convert.ToString(dgvr.Cells[8].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma, ho, ten, gioitinh, diachi, ngaysinh, email, sdt, diem;
            ma = edtAdd_ma.Text;
            ho = edtAdd_ho.Text;
            ten = edtAdd_ten.Text;
            gioitinh= edtAdd_gioitinh.Text;
            ngaysinh = edtAdd_ngaysinh.Text;
            diachi= edtAdd_diachi.Text;
            email= edtAdd_mail.Text;
            sdt= edtAdd_dienthoai.Text;
            diem = edtAdd_diem.Text;
            
            KhachHang khachhang = new KhachHang(ma, ho, ten, gioitinh, ngaysinh, diachi, email, sdt, diem);
            int i = new qlrBUS().add(khachhang);
            dvgKhachHang.DataSource = GetKhachHang();
        }

        private void cmbMaDel_Up_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cmbMaDel_Up.Text;

            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang= N'" + s + "'";
            qlrBUS qlr = new qlrBUS();

            dgvDel_Up.DataSource = qlr.GetKhachHang(sql);
        }

        private void dgvDel_Up_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvDel_Up.Rows[e.RowIndex];
            edtHoDel_Up.Text = Convert.ToString(dgvr.Cells[1].Value);
            edtTenDel_Up.Text = Convert.ToString(dgvr.Cells[2].Value);
            edtGioitinhDel_Up.Text = Convert.ToString(dgvr.Cells[3].Value);
            edtNgaysinhDel_Up.Text = Convert.ToString(dgvr.Cells[4].Value);
            edtDiachiDel_Up.Text = Convert.ToString(dgvr.Cells[5].Value);
            edtMailDel_Up.Text = Convert.ToString(dgvr.Cells[6].Value);
            edtDienthoaiDel_Up.Text = Convert.ToString(dgvr.Cells[7].Value);
            edtDiemDel_Up.Text = Convert.ToString(dgvr.Cells[8].Value);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string s = cmbMaDel_Up.Text;
            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang= N'" + s + "'";
            KhachHang khachhang = new KhachHang(cmbMaDel_Up.Text, edtHoDel_Up.Text, edtTenDel_Up.Text, edtGioitinhDel_Up.Text, edtNgaysinhDel_Up.Text, edtDiachiDel_Up.Text, edtMailDel_Up.Text, edtDienthoaiDel_Up.Text, edtDienthoaiDel_Up.Text);
            int i = new qlrBUS().del(khachhang);
            dgvDel_Up.DataSource = new qlrBUS().GetKhachHang(sql);
            dvgKhachHang.DataSource = GetKhachHang();
            cmbMaDel_Up.DataSource = GetKhachHang();
            cmbMaDel_Up.DisplayMember = "KhachHang";
            cmbMaDel_Up.ValueMember = "MaKhachHang";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string s = cmbMaDel_Up.Text;
            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang= N'" + s + "'";
            KhachHang khachhang = new KhachHang(cmbMaDel_Up.Text, edtHoDel_Up.Text, edtTenDel_Up.Text, edtGioitinhDel_Up.Text, edtNgaysinhDel_Up.Text, edtDiachiDel_Up.Text, edtMailDel_Up.Text, edtDienthoaiDel_Up.Text, edtDienthoaiDel_Up.Text);
            int i = new qlrBUS().upDate(khachhang);
            dvgKhachHang.DataSource = GetKhachHang();
            dgvDel_Up.DataSource = new qlrBUS().GetKhachHang(sql); 
        }


        
    }
}
