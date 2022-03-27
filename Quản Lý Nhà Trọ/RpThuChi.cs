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
    public partial class RpThuChi : Form
    {
        public RpThuChi()
        {
            InitializeComponent();
        }

        private void RpThuChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNHATRODataSet.ThuChi' table. You can move, or remove it, as needed.
        //    this.ThuChiTableAdapter.Fill(this.QLNHATRODataSet.ThuChi);

        //    this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ThuChiTableAdapter.Fill(this.QLNHATRODataSet.ThuChi,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
