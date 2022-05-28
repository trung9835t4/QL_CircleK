using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QL_CircleK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLL_NhanVien bll_NV = new BLL_NhanVien();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            //{
            //    MessageBox.Show("Không được bỏ trống " + lblTenDN.Text.ToLower());
            //    this.txtTenDN.Focus();
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            //{
            //    MessageBox.Show("Không được bỏ trống " + lblPassword.Text.ToLower());
            //    this.lblPassword.Focus();
            //    return;
            //}
            //ProcessLogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        public void ProcessLogin()
        {
            int result;
            result = bll_NV.DangNhap(txtTenDN.Text, txtPassword.Text); //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == 0)
            {
                MessageBox.Show("Sai tên đăng nhập" +" Hoặc mật khẩu" );
                return;
            }
            
            MessageBox.Show("Đăng nhập thành công.");

            if (Program.frm_BanHang == null || Program.frm_BanHang.IsDisposed)
            {

                Program.frm_BanHang = new frm_BanHang(bll_NV.load1NV(txtTenDN.Text));
            }
            this.Visible = false;
            Program.frm_BanHang.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập");
                this.txtTenDN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu" );
                this.txtPassword.Focus();
                return;
            }
            ProcessLogin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            int result;
            result = bll_NV.DangNhap(txtTenDN.Text, txtPassword.Text); //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == 0)
            {
                MessageBox.Show("Sai tên đăng nhập" + " Hoặc mật khẩu");
                return;
            }

            MessageBox.Show("Đăng nhập thành công.");

            if (Program.frm_BanHang == null || Program.frm_BanHang.IsDisposed)
            {

                Program.frm_BanHang = new frm_BanHang(bll_NV.load1NV(txtTenDN.Text));
            }
            this.Visible = false;
            Program.frm_BanHang.Show();
        }
    }
}
