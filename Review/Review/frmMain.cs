using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Review
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNhanVien"))
            {
                frmNhanVien frmNhanVien = new frmNhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.StartPosition = FormStartPosition.Manual;
                frmNhanVien.Location = new Point(200, 50);
                frmNhanVien.Show();
            }
            else
            {
                ActiveChildForm("frmNhanVien");
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmKhachHang"))
            {
                frmKhachHang frmKhachHang = new frmKhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.StartPosition = FormStartPosition.Manual;
                frmKhachHang.Location = new Point(200, 50);
                frmKhachHang.Show();
            }
            else
            {
                ActiveChildForm("frmKhachHang");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmThucAn"))
            {
                frmThucAn frmthucan = new frmThucAn();
                frmthucan.MdiParent = this;
                frmthucan.StartPosition = FormStartPosition.Manual;
                frmthucan.Location = new Point(200, 50);
                frmthucan.Show();
            }
            else
            {
                ActiveChildForm("frmThucAn");
            }
        }


    }
}
