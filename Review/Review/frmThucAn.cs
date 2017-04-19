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
    public partial class frmThucAn : Form
    {
        public frmThucAn()
        {
            InitializeComponent();
        }

        private void frmThucAn_Load(object sender, EventArgs e)
        {
            dvgThucAn.DataSource = GetThucAn();

            cmbThucAnMaDel_Up.DataSource = GetThucAn();
            cmbThucAnMaDel_Up.DisplayMember = "ThucAn";
            cmbThucAnMaDel_Up.ValueMember = "MaThucAn";
        }

        private List<ThucAn> GetThucAn()
        {
            string sql = "SELECT * FROM ThucAn";
            qlrBUS qlr = new qlrBUS();
            return qlr.GetThucAn(sql);
        }

        private void dvgThucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dvgThucAn.Rows[e.RowIndex];
            edtMaThucAn.Text = Convert.ToString(dgvr.Cells[0].Value);
            edtTenThucAn.Text = Convert.ToString(dgvr.Cells[1].Value);
            edtDonVi.Text = Convert.ToString(dgvr.Cells[2].Value);
            edtDonGia.Text = Convert.ToString(dgvr.Cells[3].Value);
            edtCombo.Text = Convert.ToString(dgvr.Cells[4].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mathucan, tenthucan, donvi;
            int dongia, combo;

            mathucan= edtAdd_thucan.Text;
            tenthucan= edtAdd_tenthucan.Text;
            donvi= edtAdd_donvi.Text;
            dongia= Convert.ToInt32(edtAdd_dongia.Text);
            combo=Convert.ToInt32(edtAdd_combo.Text);

            ThucAn thucan = new ThucAn(mathucan, tenthucan, donvi, dongia, combo);
            int i = new qlrBUS().addThucAn(thucan);
            dvgThucAn.DataSource = GetThucAn();
        }

        private void cmbThucAnMaDel_Up_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cmbThucAnMaDel_Up.Text;

            string sql = "SELECT * FROM ThucAn WHERE MaThucAn= N'" + s + "'";
            qlrBUS qlr = new qlrBUS();

            dgvThucAnDel_Up.DataSource = qlr.GetThucAn(sql);
        }

        private void dgvDel_Up_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvThucAnDel_Up.Rows[e.RowIndex];
     
            edtTenThucAnDel_Up.Text = Convert.ToString(dgvr.Cells[1].Value);
            edtDonViDel_Up.Text = Convert.ToString(dgvr.Cells[2].Value);
            edtDonGiaDel_Up.Text = Convert.ToString(dgvr.Cells[4].Value);
            edtComboDel_Up.Text = Convert.ToString(dgvr.Cells[3].Value);
        }

        private void btnDelThucAn_Click(object sender, EventArgs e)
        {
            string s = cmbThucAnMaDel_Up.Text;

            string sql = "SELECT * FROM ThucAn WHERE MaThucAn= N'" + s + "'";
            KhachHang khachhang = new KhachHang(cmbThucAnMaDel_Up.Text, null, null, null, null, null, null, null, null);
            int i = new qlrBUS().del(khachhang);
            dgvThucAnDel_Up.DataSource = new qlrBUS().GetThucAn(sql);
            dvgThucAn.DataSource = GetThucAn();
            cmbThucAnMaDel_Up.DataSource = GetThucAn();
            cmbThucAnMaDel_Up.DisplayMember = "ThucAn";
            cmbThucAnMaDel_Up.ValueMember = "MaThucAn";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string s = cmbThucAnMaDel_Up.Text;

            string sql = "SELECT * FROM ThucAn WHERE MaThucAn= N'" + s + "'";
            ThucAn thucan = new ThucAn(cmbThucAnMaDel_Up.Text, edtTenThucAnDel_Up.Text, edtDonViDel_Up.Text, Convert.ToInt32(edtDonGiaDel_Up.Text), Convert.ToInt32(edtComboDel_Up.Text));
            int i = new qlrBUS().upDateThucAn(thucan);
            dvgThucAn.DataSource = GetThucAn();
            dgvThucAnDel_Up.DataSource = new qlrBUS().GetKhachHang(sql);
        }
    }
}
