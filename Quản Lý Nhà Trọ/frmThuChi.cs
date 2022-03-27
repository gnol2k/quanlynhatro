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
    public partial class frmThuChi : Form
    {
        AddNewData thuChi = new AddNewData();
        public frmThuChi()
        {
            
            InitializeComponent();
        }

        private void frmThuChi_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            _LoadList();
        }
        private void _LoadList()
        {
            try
            {
                AddNewData thuChi = new AddNewData();
                List<ThuChi> listthuchi = thuChi.ThuChis.ToList();// lấy ds Khách Hàng
                BindGrid(listthuchi);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<ThuChi> listthuchi)
        {
            grvThuChi.Rows.Clear();
            foreach (var item in listthuchi)
            {
                int index = grvThuChi.Rows.Add();
                grvThuChi.Rows[index].Cells[0].Value = item.MaTC;
                grvThuChi.Rows[index].Cells[1].Value = item.Loai;
                grvThuChi.Rows[index].Cells[2].Value = item.Phi;
                grvThuChi.Rows[index].Cells[3].Value = item.ChuThich;
                grvThuChi.Rows[index].Cells[4].Value = item.NgayTC;

            }
        }

        private void grvThuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                grvThuChi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                btnSua.Enabled = true;
                DataGridViewRow row = new DataGridViewRow();
                row = grvThuChi.Rows[e.RowIndex];
                txtMaTC.Text = row.Cells[0].Value.ToString();
                cbbLoai.Text = row.Cells[1].Value.ToString();
                txtPhi.Text = row.Cells[2].Value.ToString();
                txtGhiChu.Text = row.Cells[3].Value.ToString();
                dtpThuChi.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
            }
            catch
            {

            }
        }
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtMaTC.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Thu Chi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTC.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbLoai.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Loại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbLoai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhi.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Phí", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGhiChu.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Chú Thích", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGhiChu.Focus();
                return false;
            }

            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                AddNewData thuChi = new AddNewData();
                ThuChi timmatc = thuChi.ThuChis.FirstOrDefault(p => p.MaTC == txtMaTC.Text);
                if (timmatc == null)
                {
                    timmatc = new ThuChi();
                    timmatc.MaTC = txtMaTC.Text;
                    timmatc.Loai = cbbLoai.Text;
                    timmatc.Phi = float.Parse(this.txtPhi.Text);
                    timmatc.ChuThich = txtGhiChu.Text;
                    timmatc.NgayTC = Convert.ToDateTime(this.dtpThuChi.Text);

                    thuChi.ThuChis.Add(timmatc);
                    thuChi.SaveChanges();
                    MessageBox.Show("Thêm Mới Thành Công");
                    Cleardulieu();


                }
                else
                {
                    MessageBox.Show("Mã Thu Chi Đã Có Trong Dữ Liệu");
                    txtMaTC.Text = "";
                    txtMaTC.Focus();


                }

                BindGrid(thuChi.ThuChis.ToList());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            AddNewData thuChi = new AddNewData();
            ThuChi timmatc = thuChi.ThuChis.FirstOrDefault(p => p.MaTC == txtMaTC.Text);
            if (string.IsNullOrWhiteSpace(txtMaTC.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Thu Chi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTC.Focus();
            }
            else
            {
                if (timmatc == null)
                {
                    MessageBox.Show("Mã Số Phòng Chưa Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        thuChi.ThuChis.Remove(timmatc);
                        thuChi.SaveChanges();
                        BindGrid(thuChi.ThuChis.ToList());

                        MessageBox.Show("Xóa Thành Công");
                        Cleardulieu();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
         //   if (grvThuChi.SelectedRows.Count > 0)
           // {
                AddNewData thuChi = new AddNewData();
                ThuChi timmatc = thuChi.ThuChis.FirstOrDefault(p => p.MaTC == txtMaTC.Text);
                if (timmatc != null)
                {
                    timmatc = new ThuChi();
                    timmatc.MaTC = txtMaTC.Text;
                    timmatc.Loai = cbbLoai.Text;
                    timmatc.Phi = float.Parse(this.txtPhi.Text);
                    timmatc.ChuThich = txtGhiChu.Text;
                    timmatc.NgayTC = Convert.ToDateTime(this.dtpThuChi.Text);
                    thuChi.SaveChanges();
                    _LoadList();
                    MessageBox.Show("Sửa Thành Công");
                     Cleardulieu();
                }
                else
                {
                    MessageBox.Show("Mã Thu Chi Chưa Tồn Tại Bạn Cần Thêm mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BindGrid(thuChi.ThuChis.ToList());
            }
       // }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                _LoadList();
            }
            else
            {
                grvThuChi.Rows.Clear();
                List<ThuChi> listthuchi = thuChi.ThuChis.ToList();
                foreach (ThuChi item in listthuchi)
                {
                    if (item.MaTC.Contains(txtTimKiem.Text) || item.Loai.Contains(txtTimKiem.Text) || item.Phi.ToString().Contains(txtTimKiem.Text) || item.ChuThich.ToString().Contains(txtTimKiem.Text)|| item.NgayTC.ToString().Contains(txtTimKiem.Text)) 
                    {
                        int index = grvThuChi.Rows.Add();
                        grvThuChi.Rows[index].Cells[0].Value = item.MaTC;
                        grvThuChi.Rows[index].Cells[1].Value = item.Loai;
                        grvThuChi.Rows[index].Cells[2].Value = item.Phi;
                        grvThuChi.Rows[index].Cells[3].Value = item.ChuThich;
                        grvThuChi.Rows[index].Cells[4].Value = item.NgayTC;
                       
                    }
                }
            }
        }

        //private void textBox3_Leave(object sender, EventArgs e)
        //{
        //    long n; 
        //    if (long.TryParse(textBox3.Text, out n))
        //    {
        //        labLoi.Text = "";
        //    }
           
        //    else
        //    {
        //        labLoi.ForeColor = Color.Red;
        //        labLoi.Text = "Nhập số";
        //        textBox3.Focus();
        //    }
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RpThuChi rphd = new RpThuChi();
            rphd.MdiParent = this.MdiParent;
            rphd.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(txtPhi.Text, out n))
            {
                labLoi.Text = "";
            }

            else
            {
                labLoi.ForeColor = Color.Red;
                labLoi.Text = "Nhập số";
                txtPhi.Focus();
               
            }   
        }
        private void Cleardulieu()
        {
            txtMaTC.Text = "";
            cbbLoai.SelectedItem = null;
            txtPhi.Text = "";
            txtGhiChu.Text = "";
            labLoi.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cleardulieu();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhi_Leave(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(txtPhi.Text, out n))
            {
            
            }

            else
            {
                txtPhi.Text = "";
                labLoi.Text = "";
            }
        }
    }
}
