namespace Quản_Lý_Nhà_Trọ
{
    partial class frmThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuChi));
            this.grvThuChi = new System.Windows.Forms.DataGridView();
            this.colMaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labPhi = new System.Windows.Forms.Label();
            this.labGhiChu = new System.Windows.Forms.Label();
            this.txtMaTC = new System.Windows.Forms.TextBox();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLoai = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labLoi = new System.Windows.Forms.Label();
            this.dtpThuChi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRpThuChi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvThuChi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvThuChi
            // 
            this.grvThuChi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvThuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTC,
            this.colLoai,
            this.colPhi,
            this.colGhiChu,
            this.colNgayTC});
            this.grvThuChi.Location = new System.Drawing.Point(15, 28);
            this.grvThuChi.Name = "grvThuChi";
            this.grvThuChi.Size = new System.Drawing.Size(542, 336);
            this.grvThuChi.TabIndex = 0;
            this.grvThuChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvThuChi_CellClick);
            // 
            // colMaTC
            // 
            this.colMaTC.HeaderText = "Mã Thu Chi";
            this.colMaTC.Name = "colMaTC";
            this.colMaTC.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Loại";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colPhi
            // 
            this.colPhi.HeaderText = "Phí";
            this.colPhi.Name = "colPhi";
            this.colPhi.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MaxInputLength = 60000;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // colNgayTC
            // 
            this.colNgayTC.HeaderText = "Ngày Thu,Chi";
            this.colNgayTC.MaxInputLength = 33767;
            this.colNgayTC.Name = "colNgayTC";
            this.colNgayTC.ReadOnly = true;
            this.colNgayTC.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Thu Chi:";
            // 
            // labPhi
            // 
            this.labPhi.AutoSize = true;
            this.labPhi.Location = new System.Drawing.Point(41, 82);
            this.labPhi.Name = "labPhi";
            this.labPhi.Size = new System.Drawing.Size(27, 13);
            this.labPhi.TabIndex = 3;
            this.labPhi.Text = "Phí:";
            // 
            // labGhiChu
            // 
            this.labGhiChu.AutoSize = true;
            this.labGhiChu.Location = new System.Drawing.Point(23, 125);
            this.labGhiChu.Name = "labGhiChu";
            this.labGhiChu.Size = new System.Drawing.Size(48, 13);
            this.labGhiChu.TabIndex = 4;
            this.labGhiChu.Text = "Ghi Chú:";
            // 
            // txtMaTC
            // 
            this.txtMaTC.Location = new System.Drawing.Point(92, 11);
            this.txtMaTC.Name = "txtMaTC";
            this.txtMaTC.Size = new System.Drawing.Size(100, 20);
            this.txtMaTC.TabIndex = 5;
            // 
            // txtPhi
            // 
            this.txtPhi.Location = new System.Drawing.Point(92, 82);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.Size = new System.Drawing.Size(100, 20);
            this.txtPhi.TabIndex = 7;
            this.txtPhi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtPhi.Leave += new System.EventHandler(this.txtPhi_Leave);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(92, 122);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(195, 20);
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(667, 316);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(135, 20);
            this.txtTimKiem.TabIndex = 21;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(584, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tìm Kiếm:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(772, 252);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 34);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(680, 252);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 34);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(587, 252);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 34);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLoai
            // 
            this.txtLoai.AutoSize = true;
            this.txtLoai.Location = new System.Drawing.Point(41, 48);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(30, 13);
            this.txtLoai.TabIndex = 2;
            this.txtLoai.Text = "Loại:";
            // 
            // cbbLoai
            // 
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbbLoai.Location = new System.Drawing.Point(92, 48);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(100, 21);
            this.cbbLoai.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(351, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "QUẢN LÝ THU CHI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labLoi);
            this.panel1.Controls.Add(this.dtpThuChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLoai);
            this.panel1.Controls.Add(this.labPhi);
            this.panel1.Controls.Add(this.labGhiChu);
            this.panel1.Controls.Add(this.txtMaTC);
            this.panel1.Controls.Add(this.txtPhi);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.cbbLoai);
            this.panel1.Location = new System.Drawing.Point(557, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 193);
            this.panel1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(231, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "        Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labLoi
            // 
            this.labLoi.AutoSize = true;
            this.labLoi.Location = new System.Drawing.Point(202, 88);
            this.labLoi.Name = "labLoi";
            this.labLoi.Size = new System.Drawing.Size(0, 13);
            this.labLoi.TabIndex = 12;
            // 
            // dtpThuChi
            // 
            this.dtpThuChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThuChi.Location = new System.Drawing.Point(92, 158);
            this.dtpThuChi.Name = "dtpThuChi";
            this.dtpThuChi.Size = new System.Drawing.Size(124, 20);
            this.dtpThuChi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thời Gian:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 366);
            this.panel2.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(846, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 32);
            this.panel3.TabIndex = 27;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 29);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtRpThuChi
            // 
            this.txtRpThuChi.Location = new System.Drawing.Point(562, 344);
            this.txtRpThuChi.Name = "txtRpThuChi";
            this.txtRpThuChi.Size = new System.Drawing.Size(75, 23);
            this.txtRpThuChi.TabIndex = 30;
            this.txtRpThuChi.Text = "Thống Kê";
            this.txtRpThuChi.UseVisualStyleBackColor = true;
            this.txtRpThuChi.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(871, 373);
            this.Controls.Add(this.txtRpThuChi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grvThuChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THU CHI";
            this.Load += new System.EventHandler(this.frmThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvThuChi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvThuChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPhi;
        private System.Windows.Forms.Label labGhiChu;
        private System.Windows.Forms.TextBox txtMaTC;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label txtLoai;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpThuChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTC;
        private System.Windows.Forms.Label labLoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txtRpThuChi;
        private System.Windows.Forms.Button button1;
    }
}