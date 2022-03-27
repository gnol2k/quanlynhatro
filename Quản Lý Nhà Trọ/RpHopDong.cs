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
    public partial class RpHopDong : Form
    {
        public RpHopDong()
        {
            InitializeComponent();
        }

        private void RpHopDong_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'QLNHATRODataSet.HOPDONG' table. You can move, or remove it, as needed.
            //this.HOPDONGTableAdapter.Fill(this.QLNHATRODataSet.HOPDONG);

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtMaHD.Text == "")
            //{
            //    this.HOPDONGTableAdapter.Fill(this.QLNHATRODataSet.HOPDONG);

            //    this.reportViewer1.RefreshReport();

            //}
            this.HOPDONGTableAdapter.Fill(this.QLNHATRODataSet.HOPDONG, txtMaHD.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
