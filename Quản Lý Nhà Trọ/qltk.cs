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
    public partial class qltk : Form
    {
     
        AddNewData2 context = new AddNewData2();
        public qltk()
        {
            InitializeComponent();
        }

        private void btnKtrmk_Click(object sender, EventArgs e)
        {
            DANGNHAP timmk = context.DANGNHAPs.FirstOrDefault(p => p.MATKHAU ==txtKtrmk.Text);
            if (timmk == null)
            {
                MessageBox.Show("Mật Khẩu Không Đúng!", "Lỗi");
            }
            else
            {
              
                    frmqltk qltk = new frmqltk();
                    qltk.MdiParent = this.MdiParent;
                    qltk.Show();
                    this.Hide();
                
            }
        }

        private void qltk_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
