using Quản_Lý_Nhà_Trọ.NHATRO;
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
    public partial class frmKhachHang : Form
    {
        NhaTroContextDB context = new NhaTroContextDB();
        
        public frmKhachHang()
        {
            InitializeComponent();
            btnSua.Enabled = false;
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _LoadList();
        }
        private void _LoadList()
        {
            try
            {

                List<KHACHHANG> listkh = context.KHACHHANGs.ToList(); // lấy ds Khách Hàng
                BindGrid(listkh);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void BindGrid(List<KHACHHANG> listKhachHang)
        {
            grvKH.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = grvKH.Rows.Add();
                grvKH.Rows[index].Cells[0].Value = item.MaKH;
                grvKH.Rows[index].Cells[1].Value = item.TenKH;
                grvKH.Rows[index].Cells[2].Value = item.SDT;
                grvKH.Rows[index].Cells[3].Value = item.Diachi;
                grvKH.Rows[index].Cells[4].Value = item.CMND;
            }
        }
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Số CMND", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return false;
            }
            return true;
        }
        bool b;

        private void btnThem_Click_1(object sender, EventArgs e)
        {
                if (CheckControl())
                {
                    KHACHHANG timkh = context.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
                    if (timkh == null)
                    {
                        timkh = new KHACHHANG();
                        timkh.MaKH = txtMaKH.Text;
                        timkh.TenKH = txtTenKH.Text;
                        timkh.SDT = txtSDT.Text;
                        timkh.Diachi = txtDiaChi.Text;
                        timkh.CMND = txtCMND.Text;
                        context.KHACHHANGs.Add(timkh);
                        context.SaveChanges();
                        MessageBox.Show("Thêm Mới Thành Công");
                        Cleardulieu();
                    }
                    else
                    {
                        MessageBox.Show("Mã Số Khách Hàng Đã Có Trong Dữ Liệu");

                    }

                    BindGrid(context.KHACHHANGs.ToList());
                }
            }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            NhaTroContextDB context = new NhaTroContextDB();
            KHACHHANG timkh = context.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
            }
            else
            {
                if (timkh == null)
                    throw new Exception("Không tìm thấy Mã Số Khách Hàng cần xóa");
                DialogResult dlg = MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    context.KHACHHANGs.Remove(timkh);
                    context.SaveChanges();
                    BindGrid(context.KHACHHANGs.ToList());
                    MessageBox.Show("Xóa Thành Công");
                    Cleardulieu();
                }
            }
        }

        private void grvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = grvKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtCMND.Text = row.Cells[4].Value.ToString();
                btnSua.Enabled = true;
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaTroContextDB context = new NhaTroContextDB();
            KHACHHANG timkh = context.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
            if (timkh != null)
            {
                timkh.MaKH = txtMaKH.Text;
                timkh.TenKH = txtTenKH.Text;
                timkh.SDT = txtSDT.Text;
                timkh.Diachi = txtDiaChi.Text;
                timkh.CMND = txtCMND.Text;
                context.SaveChanges();
                _LoadList();
                MessageBox.Show("Sửa Thành Công");
                Cleardulieu();
            }
            else
            {
                MessageBox.Show("Mã Khách Hàng Chưa Tồn Tại Bạn Cần Thêm mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindGrid(context.KHACHHANGs.ToList());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                _LoadList();
            }
            else
            {
                grvKH.Rows.Clear();
                List<KHACHHANG> listPhong = context.KHACHHANGs.ToList();
                foreach (KHACHHANG item in listPhong)
                {
                    if (item.MaKH.Contains(txtTimKiem.Text) || item.TenKH.Contains(txtTimKiem.Text) || item.SDT.ToString().Contains(txtTimKiem.Text) || item.Diachi.ToString().Contains(txtTimKiem.Text) || item.CMND.Contains(txtTimKiem.Text))
                    {
                        int index = grvKH.Rows.Add();
                        grvKH.Rows[index].Cells[0].Value = item.MaKH;
                        grvKH.Rows[index].Cells[1].Value = item.TenKH;
                        grvKH.Rows[index].Cells[2].Value = item.SDT;
                        grvKH.Rows[index].Cells[3].Value = item.Diachi;
                        grvKH.Rows[index].Cells[4].Value = item.CMND;
                    
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RpKhachHang rpkh = new RpKhachHang();
            rpkh.MdiParent = this.MdiParent;
            rpkh.Show();
        }
        private void Cleardulieu()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cleardulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

    
