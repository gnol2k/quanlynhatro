using Quản_Lý_Nhà_Trọ.NHATRO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhà_Trọ
{
    public partial class frmPhong : Form
    {
        NhaTroContextDB context = new NhaTroContextDB();
        public frmPhong()
        {

            InitializeComponent();

        }


        private void frmPhong_Load(object sender, EventArgs e)
        {
            _LoadList();
            btnSua.Enabled = false;
         
        }

        private void _LoadList()
        {
            try
            {
                
                List<PHONG> listPhong = context.PHONGs.ToList(); // lấy ds Khách Hàng
                BindGrid(listPhong);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<PHONG> listKhachHang)
        {
            grvPHONGTRO.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = grvPHONGTRO.Rows.Add();
                grvPHONGTRO.Rows[index].Cells[0].Value = item.MaSP;
                grvPHONGTRO.Rows[index].Cells[1].Value = item.TENCHUPHONG;
                grvPHONGTRO.Rows[index].Cells[2].Value = item.DienTich;
                grvPHONGTRO.Rows[index].Cells[3].Value = item.GiaPhong;
                grvPHONGTRO.Rows[index].Cells[4].Value = item.TinhTrang;
                grvPHONGTRO.Rows[index].Cells[5].Value = item.MaKV;
            }
        }
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbDienTich.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Diện Tích", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbDienTich.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbTinhTrang.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tình Trạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbTinhTrang.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbMaKV.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbMaKV.Focus();
                return false;
            }
            return true;

        }
        bool b;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                NhaTroContextDB context = new NhaTroContextDB();
                PHONG timphong = context.PHONGs.FirstOrDefault(p => p.MaSP == txtMaSP.Text);
                if (timphong == null)
                {
                    timphong = new PHONG();
                    timphong.MaSP = txtMaSP.Text;
                    timphong.TENCHUPHONG = txtTenCP.Text;
                    timphong.DienTich = float.Parse(this.cbbDienTich.Text);
                    timphong.GiaPhong = float.Parse(this.cbbGiaPhong.Text);
                    timphong.TinhTrang = cbbTinhTrang.Text;
                    timphong.MaKV = cbbMaKV.Text;
                    context.PHONGs.Add(timphong);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Mới Thành Công");
                    Cleardulieu();


                }
                else
                {
                    MessageBox.Show("Mã Số Phòng Đã Có Trong Dữ Liệu");
                    /*timphong.MaSP = txtMaSP.Text;
                    timphong.TENCHUPHONG = txtTenCP.Text;
                    timphong.DienTich = float.Parse(this.cbbDienTich.SelectedValue.ToString());
                    timphong.GiaPhong = float.Parse(this.cbbGiaPhong.SelectedValue.ToString());
                    timphong.TinhTrang = (this.cbbTinhTrang.SelectedValue.ToString());*/

                }

                BindGrid(context.PHONGs.ToList());
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaTroContextDB context = new NhaTroContextDB();
            PHONG timphong = context.PHONGs.FirstOrDefault(p => p.MaSP == txtMaSP.Text);
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (timphong == null)
                {
                    // throw new Exception("Không tìm thấy Mã Số Phòng cần xóa");
                    MessageBox.Show("Mã Số Phòng Chưa Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HOADON timmasp = context.HOADONs.FirstOrDefault(p => p.MaSP == txtMaSP.Text);
                    if (timmasp == null)
                    { 
                        DialogResult dlg = MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo);
                        if (dlg == DialogResult.Yes)
                        {
                            context.PHONGs.Remove(timphong);
                            context.SaveChanges();
                            BindGrid(context.PHONGs.ToList());

                            MessageBox.Show("Xóa Thành Công");
                            Cleardulieu();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Số Phòng Đã Có Trong Hóa Đơn Không Được Xóa", "Lỗi");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (grvPHONGTRO.SelectedRows.Count > 0)
            //{
                PHONG timphong = context.PHONGs.FirstOrDefault(p => p.MaSP == txtMaSP.Text);
               if (timphong != null)
               {
                    timphong.MaSP = txtMaSP.Text;
                    timphong.TENCHUPHONG = txtTenCP.Text;
                    timphong.DienTich = float.Parse(cbbDienTich.Text);
                    timphong.GiaPhong = float.Parse(cbbGiaPhong.Text);
                    timphong.TinhTrang = cbbTinhTrang.Text;
                    timphong.MaKV = cbbMaKV.Text;

                    context.SaveChanges();

                    _LoadList();
                    MessageBox.Show("Sửa Thành Công");
                    Cleardulieu();
                }
                 else
                {
                MessageBox.Show("Mã Số Phòng Chưa Tồn Tại Bạn Cần Thêm mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BindGrid(context.PHONGs.ToList());
                
            }
        private void grvPHONGTRO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                DataGridViewRow row = new DataGridViewRow();
                row = grvPHONGTRO.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenCP.Text = row.Cells[1].Value.ToString();
                cbbGiaPhong.Text = row.Cells[3].Value.ToString();
                cbbDienTich.Text = row.Cells[2].Value.ToString();
                cbbTinhTrang.Text = row.Cells[4].Value.ToString();
                cbbMaKV.Text = row.Cells[5].Value.ToString();
                btnSua.Enabled = true;
            }
            catch
            {

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
                grvPHONGTRO.Rows.Clear();
                List<PHONG> listPhong = context.PHONGs.ToList();
                foreach (PHONG item in listPhong)
                {
                    if (item.MaSP.Contains(txtTimKiem.Text) || item.TENCHUPHONG.Contains(txtTimKiem.Text) || item.DienTich.ToString().Contains(txtTimKiem.Text)|| item.GiaPhong.ToString().Contains(txtTimKiem.Text)|| item.TinhTrang.Contains(txtTimKiem.Text) || item.MaKV.Contains(txtTimKiem.Text))
                    {
                        int index = grvPHONGTRO.Rows.Add();
                        grvPHONGTRO.Rows[index].Cells[0].Value = item.MaSP;
                        grvPHONGTRO.Rows[index].Cells[1].Value = item.TENCHUPHONG;
                        grvPHONGTRO.Rows[index].Cells[2].Value = item.DienTich;
                        grvPHONGTRO.Rows[index].Cells[3].Value = item.GiaPhong;
                        grvPHONGTRO.Rows[index].Cells[4].Value = item.TinhTrang;
                        grvPHONGTRO.Rows[index].Cells[5].Value = item.MaKV;
                    }
                }
            }
        }
        private void Cleardulieu()
        {
            txtMaSP.Text = "";
            txtTenCP.Text = "";
            cbbDienTich.SelectedItem = null ;
            cbbGiaPhong.SelectedItem = null;
            cbbTinhTrang.SelectedItem = null;
            cbbMaKV.SelectedItem = null; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cleardulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
