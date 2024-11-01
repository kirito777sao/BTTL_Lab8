namespace _21103100849_TranDucHoan
{
    partial class ThongTinKH_0849
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(818, 345);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(115, 41);
            this.btThoat.TabIndex = 18;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(646, 345);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(115, 41);
            this.btTimKiem.TabIndex = 17;
            this.btTimKiem.Text = "TÌM KIẾM";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(471, 345);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 41);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(293, 345);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(115, 41);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "SỬA";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(120, 345);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(115, 41);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Location = new System.Drawing.Point(16, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 245);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKH,
            this.hoTen,
            this.gioiTinh,
            this.diaChi,
            this.dienThoai});
            this.dgv1.Location = new System.Drawing.Point(16, 31);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1022, 198);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "MaKH";
            this.maKH.HeaderText = "Mã KH";
            this.maKH.Name = "maKH";
            this.maKH.ReadOnly = true;
            this.maKH.Width = 150;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "HoTen";
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            this.hoTen.Width = 250;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 300;
            // 
            // dienThoai
            // 
            this.dienThoai.DataPropertyName = "DienThoai";
            this.dienThoai.HeaderText = "Điện Thoại";
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.ReadOnly = true;
            this.dienThoai.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 218);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHI TIẾT KHÁCH HÀNG";
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(153, 157);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(221, 21);
            this.cbGT.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(677, 94);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(282, 20);
            this.txtSDT.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(153, 99);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(221, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(677, 46);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(282, 20);
            this.txtDC.TabIndex = 6;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(153, 39);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(221, 20);
            this.txtMa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ĐIỆN THOẠI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐỊA CHỈ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GIỚI TÍNH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HỌ TÊN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ KH:";
            // 
            // ThongTinKH_0849
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 688);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinKH_0849";
            this.Text = "ThongTinKH_0849";
            this.Load += new System.EventHandler(this.ThongTinKH_0849_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}