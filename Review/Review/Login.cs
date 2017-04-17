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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = tbacc.Text.ToString();
            string pass = tbpass.Text.ToString();
            string msg = "";
            if(acc == "")
            {
                msg += "Tài khoảng không được để trống \n";
            }else if(acc.Length <= 3)
            {
                msg += "Tài khoảng không được nhỏ hơn 3 ký tự \n";
            }
            if (pass == "")
            {
                msg += "Mật khẩu không được để trống \n";
            }
            else if (pass.Length <= 3)
            {
                msg += "Mật khẩu không được nhỏ hơn 3 ký tự \n";
            }
            if(msg == "")
            {
                tbMsg.Text = "Đăng nhập thành công";
                this.Hide();
                Phim phim = new Phim();
                phim.Show();
            }
            else
            {
                tbMsg.Text = msg;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
