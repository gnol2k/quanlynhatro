using Quản_Lý_Nhà_Trọ.NHATRO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhà_Trọ
{
    public partial class frmQLHD : Form
    {
        AddNewData2 context = new AddNewData2();


        public frmQLHD()
        {
            InitializeComponent();

        }
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Hợp Đồng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHD.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Số Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTienCoc.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tiền Cọc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienCoc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpNgayLap.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Ngày Lập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayLap.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpNgayHetHan.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Ngày Hết Hạn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayHetHan.Focus();
                return false;
            }
            return true;

        }
        private void frmQLHD_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            txtMaHD.Focus();
            _LoadList();
        }
        private void _LoadList()
        {
            try
            {
                AddNewData2 context = new AddNewData2();
                List<HOPDONG> listhd = context.HOPDONGs.ToList();// lấy ds Khách Hàng
                BindGrid(listhd);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void ConvertDatetime()
        //{
        //    dtpNgayLap.Format  = DateTimePickerFormat.Custom;
        //    dtpNgayLap.CustomFormat = "dd-MM-yyyy";
        //    dtpNgayHetHan.Format = DateTimePickerFormat.Custom;
        //    dtpNgayHetHan.CustomFormat = "dd-MM-yyyy";
        //}
        private void BindGrid(List<HOPDONG> listQLHD)
        {
            grvQLHD.Rows.Clear();
            foreach (var item in listQLHD)
            {
               
                int index = grvQLHD.Rows.Add();
                grvQLHD.Rows[index].Cells[0].Value = item.MaHD;
                grvQLHD.Rows[index].Cells[1].Value = item.MaKH;
                grvQLHD.Rows[index].Cells[2].Value = item.MaSP;
                grvQLHD.Rows[index].Cells[3].Value = item.TienCoc;
                
                grvQLHD.Rows[index].Cells[4].Value = item.NGAYLAP;
                grvQLHD.Rows[index].Cells[5].Value = item.NGAYHETHAN;

            }
        }



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (CheckControl())
            {

                HOPDONG timhd = context.HOPDONGs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
                KHACHHANG timkh = context.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
                if (timkh == null)
                {
                    MessageBox.Show("Mã Khách Hàng Chưa Tồn Tại Trong Danh Sách Khách Hàng", "Lỗi");
                }
                else
                {
                    if (timhd == null)
                    {
                        timhd = new HOPDONG();
                        timhd.MaHD = txtMaHD.Text;
                        timhd.MaKH = txtMaKH.Text;
                        timhd.MaSP = txtMaSP.Text;
                        timhd.TienCoc = float.Parse(this.txtTienCoc.Text);
                        timhd.NGAYLAP = DateTime.Parse(dtpNgayLap.Text);
                        timhd.NGAYHETHAN = DateTime.Parse(dtpNgayHetHan.Text);
                        context.HOPDONGs.Add(timhd);
                        context.SaveChanges();
                        MessageBox.Show("Thêm Mới Thành Công");
                        Cleardulieu();
                    }
                    else
                    {
                        MessageBox.Show("Mã Số Khách Hàng Đã Có Trong Dữ Liệu");

                    }

                    BindGrid(context.HOPDONGs.ToList());
                }
            
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            HOPDONG timhd = context.HOPDONGs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Hợp Đồng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHD.Focus();
            }
            else
            {
                if (timhd == null)
                    throw new Exception("Không tìm thấy Mã Hợp Đồng Phòng cần xóa");
                DialogResult dlg = MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    context.HOPDONGs.Remove(timhd);
                    context.SaveChanges();
                    BindGrid(context.HOPDONGs.ToList());

                    MessageBox.Show("Xóa Thành Công");
                    Cleardulieu();
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                _LoadList();
            }
            else
            {
                grvQLHD.Rows.Clear();
                List<HOPDONG> listhd = context.HOPDONGs.ToList();
                foreach (HOPDONG item in listhd)
                {
                    if (item.MaHD.Contains(txtTimKiem.Text) || item.MaKH.Contains(txtTimKiem.Text) || item.MaSP.ToString().Contains(txtTimKiem.Text) || item.TienCoc.ToString().Contains(txtTimKiem.Text) || item.NGAYLAP.ToString().Contains(txtTimKiem.Text) || item.NGAYHETHAN.ToString().Contains(txtTimKiem.Text)) 
                    {
                        int index = grvQLHD.Rows.Add();
                        grvQLHD.Rows[index].Cells[0].Value = item.MaHD;
                        grvQLHD.Rows[index].Cells[1].Value = item.MaKH;
                        grvQLHD.Rows[index].Cells[2].Value = item.MaSP;
                        grvQLHD.Rows[index].Cells[3].Value = item.TienCoc;
                        grvQLHD.Rows[index].Cells[4].Value = item.NGAYLAP;
                        grvQLHD.Rows[index].Cells[5].Value = item.NGAYHETHAN;


                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HOPDONG timhd = context.HOPDONGs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
            if (timhd != null)
            {
                timhd.MaKH = txtMaSP.Text;
                timhd.MaHD = txtMaHD.Text;
                timhd.MaSP = txtMaSP.Text;
                timhd.TienCoc = float.Parse(txtTienCoc.Text);
                timhd.NGAYLAP = Convert.ToDateTime(this.dtpNgayLap.Text);
                timhd.NGAYHETHAN = Convert.ToDateTime(this.dtpNgayHetHan.Text);
                context.SaveChanges();

                _LoadList();
                MessageBox.Show("Sửa Thành Công");
                Cleardulieu();
            }
            else
            {
                MessageBox.Show("Mã Hợp Đồng Chưa Tồn Tại Bạn Cần Thêm mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindGrid(context.HOPDONGs.ToList());

        }
      
        private void grvQLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSua.Enabled = true;
                grvQLHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                btnSua.Enabled = true;
                DataGridViewRow row = new DataGridViewRow();
                row = grvQLHD.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtMaSP.Text = row.Cells[1].Value.ToString();
                txtMaKH.Text = row.Cells[2].Value.ToString();
                txtTienCoc.Text = row.Cells[3].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                dtpNgayHetHan.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
            catch
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            RpHopDong rphd = new RpHopDong();
            rphd.MdiParent = this.MdiParent;
            rphd.Show();
        }
        private void Cleardulieu()
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtMaSP.Text = "";
            txtTienCoc.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cleardulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaHD_Leave(object sender, EventArgs e)
        {

        }

        private void txtTienCoc_Leave(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(txtTienCoc.Text, out n) || txtTienCoc.Text == "")
            {

            }

            else
            {
                MessageBox.Show("Cần Nhập Số", "Lỗi");
                txtTienCoc.Text = "";
               
            }
        }
    }
}
    

