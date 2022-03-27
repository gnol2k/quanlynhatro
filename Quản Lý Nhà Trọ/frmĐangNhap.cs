using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhà_Trọ
{
    public partial class frmĐangNhap : Form
    {
        public qltk qltk;
        public frmĐangNhap()
        {
            InitializeComponent();
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTaiKhoan.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;
            }
            return true;

        }
        public void btnThoat_Click(object sender, EventArgs e)
         {
            DialogResult thoat = MessageBox.Show("Bạn có muốn Thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (thoat == DialogResult.Yes)
            {
                Close();
            }
        }

        public void btnĐangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();

        }

        public void KiemTraDangNhap()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QEN4LJI\SQLEXPRESS;Initial Catalog=QLNHATRO;Integrated Security=True");
            try
            {
                if (CheckControl())
                {
                    con.Open();
                    string tk = txtTenTaiKhoan.Text;
                    string mk = txtMatKhau.Text;
                    string sql = " select * from DANGNHAP where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read() == true)
                    {
                        frmChinh chinh = new frmChinh();
                        chinh.ShowDialog();
                        this.Hide();
                        txtMatKhau.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Tên Đăng nhập Hoặc Mật Khẩu Không Đúng", "Thông Báo");
                        txtTenTaiKhoan.Text = "";
                        txtMatKhau.Text = "";
                        txtTenTaiKhoan.Focus();
                    }
                }
            }
            catch
            {

            }
        }

        public void frmĐangNhap_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Focus();
        }

        public void btnĐangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter )
            {
                KiemTraDangNhap();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            frmDKTK dktk = new frmDKTK();
            dktk.MdiParent = this.MdiParent;
            dktk.Show();
        }

        public void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
