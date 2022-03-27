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
    public partial class frmHelp : Form
    {
        private TreeView treeView1;
        private WebBrowser webBrowser1;

        public frmHelp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thông Tin");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hướng dẫn tính tiền trọ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hướng dẫn đăng nhập");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hướng dẫn quản lý hợp đồng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hướng dẫn quản lý khách hàng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hướng dẫn quản lý thu chi");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hướng Dẫn", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-2, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodeThongtin";
            treeNode1.Text = "Thông Tin";
            treeNode2.Name = "nodeTTTR";
            treeNode2.Text = "Hướng dẫn tính tiền trọ";
            treeNode3.Name = "NodeDangNhap";
            treeNode3.Text = "Hướng dẫn đăng nhập";
            treeNode4.Name = "nodeHopDong";
            treeNode4.Text = "Hướng dẫn quản lý hợp đồng";
            treeNode5.Name = "nodeKhachHang";
            treeNode5.Text = "Hướng dẫn quản lý khách hàng";
            treeNode6.Name = "nodeThuChi";
            treeNode6.Text = "Hướng dẫn quản lý thu chi";
            treeNode7.Name = "nodeHuongDan";
            treeNode7.Text = "Hướng Dẫn";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(173, 477);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(177, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(656, 465);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmHelp
            // 
            this.ClientSize = new System.Drawing.Size(837, 468);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trợ Giúp";
            this.ResumeLayout(false);

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch(e.Node.Name)
            {
                case "nodeThongtin":
                    webBrowser1.Navigate(@"D:\Quản Lý Nhà Trọ\Quản Lý Nhà Trọ\Help\Gioithieu3.mht");
                    break;
                case "nodeTTTR":
                    webBrowser1.Navigate(@"D:\Quản Lý Nhà Trọ\Quản Lý Nhà Trọ\Help\Hướng Dẫn Tính Tiền Trọ2.mht");
                    break;
                case "NodeDangNhap":
                    webBrowser1.Navigate(@"D:\Quản Lý Nhà Trọ\Quản Lý Nhà Trọ\Help\huongdandangnhap.hmt.mht");
                    break;
                case "nodeHopDong":
                    webBrowser1.Navigate(@"D:\Quản Lý Nhà Trọ\Quản Lý Nhà Trọ\Help\huongdanquanlyhopdong.mht");
                    break;
                case "nodeKhachHang":
                    webBrowser1.Navigate(@"D:\Quản Lý Nhà Trọ\Quản Lý Nhà Trọ\Help\huongdanquanlykhachhang.mht");
                    break;
                case "nodeThuChi":
                    webBrowser1.Navigate(@"D:\Quản Lý Nhà Trọ\Quản Lý Nhà Trọ\Help\huongdanquanlythuchi.mht");
                    break;
                default:
                    break;
                  
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
