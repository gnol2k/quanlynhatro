using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhà_Trọ
{
    public partial class frmDKTK : Form
    {

        NhaTroContextDB context = new NhaTroContextDB();

        public frmDKTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult thoat = MessageBox.Show("Bạn có muốn Thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (thoat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DANGNHAP timtk = context.DANGNHAPs.FirstOrDefault(p => p.TAIKHOAN == txtTaiKhoan.Text);
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tài Khoản! ");
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mật Khẩu! ");
                txtMatKhau.Focus();
            }
            else if (txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Lại Mật Khẩu! ");
                txtNhapLaiMatKhau.Focus();
            }
            else if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật Khẩu và Nhập Lại Mật Khẩu không đúng! ");
                txtNhapLaiMatKhau.Focus();
                txtNhapLaiMatKhau.SelectAll();
            }
            else if (timtk == null)
                {
                    timtk = new DANGNHAP();
                    timtk.TAIKHOAN = txtTaiKhoan.Text;
                    timtk.MATKHAU = txtMatKhau.Text;
                    context.DANGNHAPs.Add(timtk);
                    context.SaveChanges();
                    MessageBox.Show("Đăng Ký Thành Công");
       
                }
            else
            {
                MessageBox.Show("Mã Số Khách Hàng Đã Có Trong Dữ Liệu");
            }
        }

        private void frmDKTK_Load(object sender, EventArgs e)
        {

        }
        private void Checkthongtin()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tài Khoản! ");
                txtTaiKhoan.Focus();
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mật Khẩu! ");
                txtMatKhau.Focus();
            }
            if (txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Lại Mật Khẩu! ");
                txtNhapLaiMatKhau.Focus();
            }
            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật Khẩu và Nhập Lại Mật Khẩu không đúng! ");
                txtNhapLaiMatKhau.Focus();
                txtNhapLaiMatKhau.SelectAll();
            }
        }
    }

}
