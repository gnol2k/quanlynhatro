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
    public partial class frmqltk : Form
    {
        NhaTroContextDB context = new NhaTroContextDB();
        public frmqltk()
        {
           
            InitializeComponent();
        }

        private void frmqltk_Load(object sender, EventArgs e)
        {
            _LoadList();
        }
        private void _LoadList()
        {
            try
            {

                List<DANGNHAP> listdangnhap = context.DANGNHAPs.ToList(); 
                BindGrid(listdangnhap);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<DANGNHAP> listdangnhap)
        {
            dgvDangNhap.Rows.Clear();
            foreach (var item in listdangnhap)
            {
                int index = dgvDangNhap.Rows.Add();
                dgvDangNhap.Rows[index].Cells[0].Value = item.TAIKHOAN;
                dgvDangNhap.Rows[index].Cells[1].Value = item.MATKHAU;
               
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                _LoadList();
            }
            else
            {
                dgvDangNhap.Rows.Clear();
                List<DANGNHAP> listtaikhoan = context.DANGNHAPs.ToList();
                foreach (DANGNHAP item in listtaikhoan)
                {
                    if (item.TAIKHOAN.Contains(txtTimKiem.Text) || item.MATKHAU.Contains(txtTimKiem.Text))
                    {
                        int index = dgvDangNhap.Rows.Add();
                        dgvDangNhap.Rows[index].Cells[0].Value = item.TAIKHOAN;
                        dgvDangNhap.Rows[index].Cells[1].Value = item.MATKHAU;
                      
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
