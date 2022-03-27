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
    public partial class frmTinhTienTro : Form
    {
        NhaTroContextDB context = new NhaTroContextDB();
        public frmTinhTienTro()
        {
            InitializeComponent();
            dgvTinhTienPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        void Data()
        {
            try
            {

                List<HOADON> listHoadon = context.HOADONs.ToList();// lấy ds Khách Hàng
                List<PHONG> listPhong = context.PHONGs.ToList();
                BindGrid(listHoadon);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmTinhTienTro_Load(object sender, EventArgs e)
        {
            Data();
        }


        private void BindGrid(List<HOADON> listHoadon)
        {
            dgvTinhTienPhong.Rows.Clear();
            foreach (var item in listHoadon)
            {
                int index = dgvTinhTienPhong.Rows.Add();
                dgvTinhTienPhong.Rows[index].Cells[0].Value = item.MaHD;

                dgvTinhTienPhong.Rows[index].Cells[1].Value = item.MaSP;
                dgvTinhTienPhong.Rows[index].Cells[2].Value = item.TIENDIEN;
                dgvTinhTienPhong.Rows[index].Cells[3].Value = item.TIENNUOC;
                dgvTinhTienPhong.Rows[index].Cells[5].Value = item.TONGTIEN;
                dgvTinhTienPhong.Rows[index].Cells[6].Value = item.THOIGIAN;
                dgvTinhTienPhong.Rows[index].Cells[7].Value = item.GHICHU;
                dgvTinhTienPhong.Rows[index].Cells[4].Value = item.PHONG.GiaPhong;

            }

        }

        private void btnTienDV_Click(object sender, EventArgs e)
        {
            /*  string  MaSP = "";
                MaSP = cbbMaSP.Text;
                if (string.IsNullOrEmpty(MaSP))
                {
                    MessageBox.Show("Chưa Chọn Mã Số Phòng");
                    cbbMaSP.Focus();
                    return;
                }
                else
                {*/
            float TienDV = 0;


            if (checkboxTienRac.Checked == true)
            {
                TienDV += 20000;
                txtTienDichVu.Text = String.Format("{0:#,###}VND", TienDV);
            }
            else
            {
                TienDV += TienDV;
                txtTienDichVu.Text = String.Format("{0:#,###}VND", TienDV);
            }
            if (checkBoxInternet.Checked == true)
            {
                TienDV += 50000;
                txtTienDichVu.Text = String.Format("{0:#,###}VND", TienDV);
            }
            else
            {
                TienDV += TienDV;
                txtTienDichVu.Text = String.Format("{0:#,###}VND", TienDV);
            }
            if (checkBoxGiuXe.Checked == true)
            {
                TienDV += 100000;
                txtTienDichVu.Text = String.Format("{0:#,###}VND", TienDV);
            }
            else
            {
                TienDV += TienDV;
                txtTienDichVu.Text = String.Format("{0:#,###}VND", TienDV);
            }


        }
        public bool Checkthongtin()
        {
            if (txtTienDien.Text == "" || txtTienNuoc.Text == "" || txtMaHD.Text == "" || txtMaSP.Text == "" || string.IsNullOrWhiteSpace(cbbGiaPhong.Text) || string.IsNullOrWhiteSpace(cbbTinhTrang.Text) || txtTienDichVu.Text == "")
            {
                MessageBox.Show("Xin Hãy Nhập Đầy Đủ Thông Tin...");
                return false;
            }
            return true;
        }
        void TinhTienTro()
        {
            float TongTien = 0;
            if (txtTienDichVu.Text == "VND")
            {
                TongTien = float.Parse(txtTienDien.Text.Replace(".", "").Replace("VND", "")) + float.Parse(txtTienNuoc.Text.Replace(".", "").Replace("VND", ""))  /*+float.Parse(cbbGiaPhong.Text.Replace(".", "").Replace("VND", ""))*/;
                //txtTongTien.Text = String.Format("{0:#,###}VND", TongTien);

            }
            else
            {
                TongTien = float.Parse(txtTienDien.Text.Replace(".", "").Replace("VND", "")) + float.Parse(txtTienNuoc.Text.Replace(".", "").Replace("VND", "")) + float.Parse(txtTienDichVu.Text.Replace(".", "").Replace("VND", ""));//+ float.Parse(cbbGiaPhong.Text.Replace(".", "").Replace("VND", ""));

            }
            txtTongTien.Text = (TongTien + Convert.ToInt32(cbbGiaPhong.SelectedItem.ToString())).ToString();

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
          
        }
        bool b;
        private void txtTinhTien_Click(object sender, EventArgs e)
        {
            if (Checkthongtin())
            {

                TinhTienTro();
                HOADON timhd = context.HOADONs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
                //  PHONG timphong = context.PHONGs.FirstOrDefault(p => p.MaSP == txtMaSP.Text);
                string text = this.cbbGiaPhong.Text;
                Data();
                /* if (timhd == null)
                 {
                     MessageBox.Show("Mã Số Phòng Chưa Tồn Tại Trong Danh Sách Phòng", "Lỗi");
                 }
                 else
                 {*/
                if (timhd != null)
                {
                    timhd.MaHD = txtMaHD.Text;
                    timhd.MaSP = txtMaSP.Text;
                    timhd.TIENDIEN = float.Parse(this.txtTienDien.Text.Replace(".", "").Replace("VND", ""));
                    timhd.TIENNUOC = float.Parse(this.txtTienNuoc.Text.Replace(".", "").Replace("VND", ""));
                    timhd.TONGTIEN = float.Parse(this.txtTongTien.Text);
                    timhd.THOIGIAN = DateTime.Parse(dtpTienPhong.Text);
                    timhd.GHICHU = cbbTinhTrang.Text;
                    timhd.PHONG.GiaPhong = float.Parse(text);
                    MessageBox.Show("Sửa Thành Công");
                    TinhTienTro();
                    Data();
                    Cleardulieu();

                    context.SaveChanges();

                }
                else
                {

                    timhd = new HOADON();
                    timhd.MaHD = txtMaHD.Text;
                    timhd.MaSP = txtMaSP.Text;
                    timhd.TIENDIEN = float.Parse(txtTienDien.Text.Replace(".", "").Replace("VND", ""));
                    timhd.TIENNUOC = float.Parse(txtTienNuoc.Text.Replace(".", "").Replace("VND", ""));
                    timhd.TONGTIEN = float.Parse(txtTongTien.Text);
                    timhd.THOIGIAN = DateTime.Parse(dtpTienPhong.Text);
                    timhd.GHICHU = cbbTinhTrang.Text;
                    // timhd.PHONG.GiaPhong = float.Parse(text);
                    context.HOADONs.Add(timhd);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Mới Thành Công");
                    Data();
                    Cleardulieu();
                }
            }
        }
        //  }

        private void NewMethod()
        {
            context.SaveChanges();
        }

        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaTroContextDB context = new NhaTroContextDB();
            List<HOADON> listHoadon = context.HOADONs.ToList();
        }

        private void dgvTinhTienPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTinhTienPhong.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtMaSP.Text = row.Cells[1].Value.ToString();
                txtTienDien.Text = row.Cells[2].Value.ToString();
                txtTienNuoc.Text = row.Cells[3].Value.ToString();
                cbbGiaPhong.Text = row.Cells[4].Value.ToString();
                txtTongTien.Text = row.Cells[5].Value.ToString();
                dtpTienPhong.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());
                cbbTinhTrang.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void txtTienDichVu_TextChanged(object sender, EventArgs e)
        {
            //if (txtTienDichVu.Text == "")
            //{
            //    float ShowTienDv = 0;
            //    ShowTienDv = float.Parse(txtTongTien.Text.Replace(".", "").Replace("VND", "")) - float.Parse(txtTienDien.Text.Replace(".", "").Replace("VND", "")) - float.Parse(txtTienNuoc.Text.Replace(".", "").Replace("VND", ""));
            //}
        }

        private void txtSCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*  if (char.IsDigit(e.KeyChar))
              {
                  e.Handled = false;
              }
              else
              {
                  e.Handled = true;
              }*/
        }


        private void dgvTinhTienPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOADON timhd = context.HOADONs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (timhd == null)
                {
                    // throw new Exception("Không tìm thấy Mã Số Phòng cần xóa");
                    MessageBox.Show("Mã Hóa Đơn Chưa Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        context.HOADONs.Remove(timhd);
                        context.SaveChanges();
                        BindGrid(context.HOADONs.ToList());

                        MessageBox.Show("Xóa Thành Công");
                        Cleardulieu();
                    }
                }
            }

        }
        long n;
        private void Nhapsomcd()
        {
            if (long.TryParse(txtSCD.Text, out n))
            {
                label15.Text = "";
            }
            else
            {
                label15.ForeColor = Color.Red;
                label15.Text = "Nhập số";

            }
        }
        private void txtSCD_TextChanged(object sender, EventArgs e)
        {
            Nhapsomcd();
            //if (long.TryParse(txtSCD.Text, out n))
            //{
            //    label15.Text = "";
            //}
            //else
            //{
            //    label15.ForeColor = Color.Red;
            //    label15.Text = "Lỗi";
            //    // MessageBox.Show("Cần Nhập Số", "Lỗi");
            //    // txtSCD.Focus();
            //}
        }
        private void nhapmoismđ()
        {
            if (long.TryParse(txtSMĐ.Text, out n))
            {
                label16.Text = "";
            }
            else
            {
                label16.ForeColor = Color.Red;
                label16.Text = "Nhập số";

            }
        }
        private void txtSMĐ_TextChanged(object sender, EventArgs e)
        {

            nhapmoismđ();
            //if (long.TryParse(txtSCD.Text, out n))
            //{
            //    label15.Text = "";
            //}
            //else
            //{
            //    label15.ForeColor = Color.Red;
            //    label15.Text = "Lỗi";
            //    // MessageBox.Show("Cần Nhập Số", "Lỗi");
            //    // txtSCD.Focus();
            //}
        }

        private void nhapmoimacn()
        {
            if (long.TryParse(txtSCN.Text, out n))
            {
                label17.Text = "";
            }
            else
            {
                label17.ForeColor = Color.Red;
                label17.Text = "Nhập số";


            }
        }
        private void txtSCN_TextChanged(object sender, EventArgs e)
        {

            nhapmoimacn();
            //if (long.TryParse(txtSCN.Text, out n))
            //{
            //    label17.Text = "";
            //}
            //else
            //{
            //    label17.ForeColor = Color.Red;
            //    label17.Text = "Lỗi";
            //    //  MessageBox.Show("Cần Nhập Số", "Lỗi");
            //    // txtSCN.Focus();

            //}
        }
        private void nhapmoimamn()
        {
          
   
            if (long.TryParse(txtSMN.Text, out n))
            {
                label18.Text = "";
            }
            else
            {
                label18.ForeColor = Color.Red;
                label18.Text = "Nhập số";


            }
        }
        private void txtSMN_TextChanged(object sender, EventArgs e)
        {
            nhapmoimamn();
            //if (long.TryParse(txtSCD.Text, out n))
            //{
            //    label15.Text = "";
            //}
            //else
            //{
            //    label15.ForeColor = Color.Red;
            //    label15.Text = "Lỗi";
            //    // MessageBox.Show("Cần Nhập Số", "Lỗi");
            //    // txtSCD.Focus();
            //}
        }

        //private void txtSCD_Leave(object sender, EventArgs e)
        //{
        //    if (long.TryParse(txtSCD.Text, out n))
        //    {
        //        label15.Text = "";
        //    }
        //    else
        //    {
        //        label15.ForeColor = Color.Red;
        //        label15.Text = "Lỗi";
        //       // MessageBox.Show("Cần Nhập Số", "Lỗi");
        //       // txtSCD.Focus();
        //    }
        //}

        //private void txtSMĐ_Leave(object sender, EventArgs e)
        //{

        //    if (long.TryParse(txtSMĐ.Text, out n))
        //    {
        //        label17.Text = "";
        //    }
        //    else
        //    {
        //        label17.ForeColor = Color.Red;
        //        label17.Text = "Lỗi";
        //       // MessageBox.Show("Cần Nhập Số", "Lỗi");
        //       // txtSMĐ.Focus();

        //    }
        //}

        //private void txtSCN_Leave(object sender, EventArgs e)
        //{
        //    if (long.TryParse(txtSCN.Text, out n))
        //    {
        //        label17.Text = "";
        //    }
        //    else
        //    {
        //        label17.ForeColor = Color.Red;
        //        label17.Text = "Lỗi";
        //      //  MessageBox.Show("Cần Nhập Số", "Lỗi");
        //       // txtSCN.Focus();

        //    }
        //}

        //private void txtSMN_Leave(object sender, EventArgs e)
        //{
        //    if (long.TryParse(txtSMN.Text, out n))
        //    {
        //        label18.Text = "";
        //    }
        //    else
        //    {
        //        label18.ForeColor = Color.Red;
        //        label18.Text = "Lỗi";
        //       // MessageBox.Show("Cần Nhập Số", "Lỗi");
        //       // txtSMN.Focus();


        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            RpHoaDon rpttr = new RpHoaDon();
            rpttr.MdiParent = this.MdiParent;
            rpttr.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                Data();
            }
            else
            {
                dgvTinhTienPhong.Rows.Clear();
                List<HOADON> listhoadon = context.HOADONs.ToList();
                foreach (HOADON item in listhoadon)
                {
                    if (item.MaHD.Contains(txtTimKiem.Text) || item.MaSP.Contains(txtTimKiem.Text) || item.TIENDIEN.ToString().Contains(txtTimKiem.Text) || item.TIENNUOC.ToString().Contains(txtTimKiem.Text) || item.PHONG.GiaPhong.ToString().Contains(txtTimKiem.Text) || item.TONGTIEN.ToString().Contains(txtTimKiem.Text) || item.THOIGIAN.ToString().Contains(txtTimKiem.Text) || item.GHICHU.Contains(txtTimKiem.Text))

                    {
                        int index = dgvTinhTienPhong.Rows.Add();
                        dgvTinhTienPhong.Rows[index].Cells[0].Value = item.MaHD;
                        dgvTinhTienPhong.Rows[index].Cells[1].Value = item.MaSP;
                        dgvTinhTienPhong.Rows[index].Cells[2].Value = item.TIENDIEN;
                        dgvTinhTienPhong.Rows[index].Cells[3].Value = item.TIENNUOC;
                        dgvTinhTienPhong.Rows[index].Cells[4].Value = item.PHONG.GiaPhong;
                        dgvTinhTienPhong.Rows[index].Cells[5].Value = item.TONGTIEN;
                        dgvTinhTienPhong.Rows[index].Cells[6].Value = item.THOIGIAN;
                        dgvTinhTienPhong.Rows[index].Cells[7].Value = item.GHICHU;

                    }
                }
            }
        }

        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            PHONG timphong = context.PHONGs.FirstOrDefault(p => p.MaSP == txtMaSP.Text);
            string text = this.cbbGiaPhong.Text;
            Data();
            if (timphong != null || txtMaSP.Text == "")
            {
            }
            else
            {
                MessageBox.Show("Mã Số Phòng Chưa Tồn Tại");
                txtMaSP.Text = "";
            }
        }

        private void txtMaHD_Leave(object sender, EventArgs e)
        {
            HOADON timhd = context.HOADONs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
            string text = this.cbbGiaPhong.Text;
            Data();
            if (timhd != null)
            {
               // MessageBox.Show("Mã Hóa Đơn Đã Tồn Tại.Bạn muốn sửa??", "Sửa", MessageBoxButtons.YesNo);
                if (MessageBox.Show("Mã Hóa Đơn Đã Tồn Tại.Bạn muốn sửa??", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    txtMaHD.Text = "";
                    txtMaHD.Focus();
                }
            }
            else
            {

            }
        }

        private void btnTinhDien_Leave(object sender, EventArgs e)
        {

        }
        private void Cleardulieu()
        {
            txtMaHD.Text = "";
            txtMaSP.Text = "";
            cbbGiaPhong.SelectedItem = null;
            cbbTinhTrang.SelectedItem = null;
            txtSCD.Text = "";
            txtSMĐ.Text = "";
            txtSCN.Text = "";
            txtSMN.Text = "";
            txtTienDien.Text = "";
            txtTienNuoc.Text = "";
            txtTienDichVu.Text = "";
            checkBoxGiuXe.Checked = false;
            checkBoxInternet.Checked = false;
            checkboxTienRac.Checked = false;
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            txtTongTien.Text = "";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Cleardulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSCD_Leave(object sender, EventArgs e)
        {
            if (txtSCD.Text == "")
            {

            }

            else if (long.TryParse(txtSCD.Text, out n))
            {
                TinhTienDien();
            }
            else
            {
                txtSCD.Text = "";
                label15.Text = "";
            }
        }
        private void txtSCN_Leave(object sender, EventArgs e)
        {
            if (txtSCN.Text == "")
            {

            }

            else if (long.TryParse(txtSCN.Text, out n))
            {
                TinhTienNuoc();
            }
            else
            {
                txtSCN.Text = "";
                label17.Text = "";
            }
        }
        private void txtSMN_Leave(object sender, EventArgs e)
        {
            if (txtSMN.Text == "")
            {

            }
            
           else if (long.TryParse(txtSMN.Text, out n))
            {
                TinhTienNuoc();
            }
            else
            {
                txtSMN.Text = "";
                label18.Text = "";
            }
        }

      

        private void txtSMĐ_Leave(object sender, EventArgs e)
        {
            if (txtSMĐ.Text == null)
            {
                label16.Text = "";
            }
            
            else if (long.TryParse(txtSMĐ.Text, out n))
            {
                TinhTienDien();
            }
            else
            {
                txtSMĐ.Text = "";
                label16.Text = "";
            }
  
        }
        private void TinhTienDien()
        {
            string SoCuDien = "", SoMoiDien = "", MaSP = "";
            float socuD = 0, somoiD = 0, tongdien = 0;
            SoCuDien = txtSCD.Text;
            SoMoiDien = txtSMĐ.Text;
            MaSP = txtMaSP.Text;
            nhapmoismđ();
            Nhapsomcd();
            if (txtSCD.Text == "" || txtSMĐ.Text == "")
            {
              
            }
            else
            {
                float a = float.Parse(this.txtSCD.Text);
                float b = float.Parse(this.txtSMĐ.Text);
                if (a >= b)
                {
                    MessageBox.Show("Số Điện Cũ Phải Nhỏ Hơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSCD.Text = "";
                    txtSMĐ.Text = "";
                    label15.Text = null ;
                    label16.Text = null ;
                }
                else
                {
                    socuD = float.Parse(SoCuDien);
                    somoiD = float.Parse(SoMoiDien);


                    tongdien = (somoiD - socuD) * 2000;
                    txtTienDien.Text = String.Format("{0:#,###}VND", tongdien);
                }
                nhapmoismđ();
                Nhapsomcd();
            }
        }
        private void TinhTienNuoc()
        {
            string SoCuNuoc = "", SoMoiNuoc = "";// MaSP = "";
            float socuN = 0, somoiN = 0, tongnuoc = 0;
            SoCuNuoc = txtSCN.Text;
            SoMoiNuoc = txtSMN.Text;
            nhapmoimamn();
            nhapmoimacn();
            if (txtSCN.Text == "" || txtSMN.Text == "")
            {

            }
            else
            {
                float a = float.Parse(this.txtSCN.Text);
                float b = float.Parse(this.txtSMN.Text);
                if (a >= b)
                {
                    MessageBox.Show("Số Nước Cũ Phải Nhỏ Hơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSMN.Text = "";
                    txtSCN.Text = "";
                    label17.Text = "";
                    label18.Text = "";
                }
                else
                {
                    socuN = float.Parse(SoCuNuoc);
                    somoiN = float.Parse(SoMoiNuoc);
                    tongnuoc = (somoiN - socuN) * 4000;
                    txtTienNuoc.Text = String.Format("{0:#,###}VND", tongnuoc);
                }
                nhapmoimamn();
                nhapmoimacn();
            }
        }

        private void checkBoxInternet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTienDien_TextChanged(object sender, EventArgs e)
        {
            TinhTienDien();
        }
        //private void TinhTienDV()
        //{
        //    float TienDV = 0;
        //    if (checkboxTienRac.Checked == true)
        //        TienDV += 20000;
        //    if (checkBoxInternet.Checked == true)
        //        TienDV += 50000;
        //    if (checkBoxGiuXe.Checked == true)
        //        TienDV += 100000;
        //    txtTienDichVu.Text = String.Format("{0:#,###}VND", TienDV);
        //}
    } 
}
