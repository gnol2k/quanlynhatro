using Quản_Lý_Nhà_Trọ.NHATRO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhà_Trọ
{
    
    public partial class frmChinh : Form
    {
        Timer t = new Timer();
        public frmChinh()
        {
            InitializeComponent();
        }
  

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            frmQLHD open_qlhd = new frmQLHD();
            open_qlhd.ShowDialog();

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang open_khachhang = new frmKhachHang();
            open_khachhang.ShowDialog();
        }

        private void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu open_dichvu = new frmDichVu();
            open_dichvu.ShowDialog();
        }



        private void btnThuChi_Click(object sender, EventArgs e)
        {
            //frmQuanLyThuChi open_thuchi = new frmQuanLyThuChi();
            //open_thuchi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Thoat = MessageBox.Show("Thoát Chương Trình?","Thông Báo",MessageBoxButtons.YesNo);
            Application.Exit();        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            frmPhong open_phong = new frmPhong();
            open_phong.ShowDialog();
        }

  

        private void tínhTiềnTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinhTienTro tientro = new frmTinhTienTro();
            tientro.MdiParent = this.MdiParent;
            tientro.Show();


        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            frmSodotro sdtr = new frmSodotro();
            sdtr.MdiParent = this.MdiParent;
            sdtr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmThuChi tc = new frmThuChi();
            tc.MdiParent = this.MdiParent;
            tc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLoaiPhong loaiphong = new frmLoaiPhong();
            loaiphong.MdiParent = this.MdiParent;
            loaiphong.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDichVu dv = new frmDichVu();
            dv.MdiParent = this.MdiParent;
            dv.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.MdiParent = this.MdiParent;
            help.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn Có Muốn Đăng Xuất?", "Thông Báo", MessageBoxButtons.YesNo) ;
            if (DialogResult.Yes == thoat)
            {
                Close();
                    Application.Run(new frmĐangNhap());
                    
            }
            
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            //    //labDongHo.Text = DateTime.Now.ToString("HH:mm:ss");
            //    t.Interval = 10000;
            //    t.Tick += new EventHandler(this.t_Tick);
            //    t.Start();
            //}
            ////private void t_Tick(Object sender, EventArgs e)
            //{
            //    int hh = DateTime.Now.Hour;
            //    int mm = DateTime.Now.Minute;
            //    int ss = DateTime.Now.Second;
            //    string time = "";
            //    if (hh > 12)
            //    {
            //        hh = hh - 12;
            //    }
            //    else
            //    {
            //        time += hh;
            //    }
            //    time += ":";
            //    if (mm > 12)
            //    {
            //        mm = mm - 12;
            //    }
            //    else
            //    {
            //        time += mm;
            //    }
            //    time += ":";
            //    if (ss < 10)
            //    {
            //        time += "0" + ss;
            //    }
            //    else
            //    {
            //        time += ss;
            //    }
            //    labDongHo.Text = time;
        }
        private void t_Tick(object sender,EventArgs e)
        {
            int hh = DateTime.Now.Hour;
             int mm = DateTime.Now.Minute;
              int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10)
            {
                time += "0" +hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if ( ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            labClock.Text = time;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qltk qltk = new qltk();
            qltk.MdiParent = this.MdiParent;
            qltk.Show();

        }

       
        private void quảnLýKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RpKhachHang rpkh = new RpKhachHang();
            rpkh.MdiParent = this.MdiParent;
            rpkh.Show();
        }

        private void quảnLýThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RpThuChi rptc = new RpThuChi();
            rptc.MdiParent = this.MdiParent;
            rptc.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RpHoaDon rphđ = new RpHoaDon();
            rphđ.MdiParent = this.MdiParent;
            rphđ.Show();
        }

        private void thuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RpHopDong rphd = new RpHopDong();
            rphd.MdiParent = this.MdiParent;
            rphd.Show();
        }

        private void đăngKíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDKTK dktk = new frmDKTK();
            dktk.MdiParent = this.MdiParent;
            dktk.Show();
        }

        private void labClock_Click(object sender, EventArgs e)
        {
            

        }

    }
}
