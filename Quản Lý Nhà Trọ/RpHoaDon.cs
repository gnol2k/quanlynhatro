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
    public partial class RpHoaDon : Form
    {
        public RpHoaDon()
        {
            InitializeComponent();
        }

        private void RpHoaDon_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'QLNHATRODataSet.HOADON' table. You can move, or remove it, as needed.
            //this.HOADONTableAdapter.Fill(this.QLNHATRODataSet.HOADON);

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNHATRODataSet.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.QLNHATRODataSet.HOADON, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
