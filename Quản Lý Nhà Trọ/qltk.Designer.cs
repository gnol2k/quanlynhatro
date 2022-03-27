namespace Quản_Lý_Nhà_Trọ
{
    partial class qltk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qltk));
            this.txtKtrmk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKtrmk = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKtrmk
            // 
            this.txtKtrmk.Location = new System.Drawing.Point(130, 32);
            this.txtKtrmk.Name = "txtKtrmk";
            this.txtKtrmk.PasswordChar = '*';
            this.txtKtrmk.Size = new System.Drawing.Size(136, 20);
            this.txtKtrmk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mật Khẩu:";
            // 
            // btnKtrmk
            // 
            this.btnKtrmk.Location = new System.Drawing.Point(111, 58);
            this.btnKtrmk.Name = "btnKtrmk";
            this.btnKtrmk.Size = new System.Drawing.Size(75, 23);
            this.btnKtrmk.TabIndex = 2;
            this.btnKtrmk.Text = "Kiểm Tra";
            this.btnKtrmk.UseVisualStyleBackColor = true;
            this.btnKtrmk.Click += new System.EventHandler(this.btnKtrmk_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(273, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(21, 21);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // qltk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 90);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKtrmk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKtrmk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "qltk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qltk";
            this.Load += new System.EventHandler(this.qltk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKtrmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKtrmk;
        private System.Windows.Forms.Button btnThoat;
    }
}