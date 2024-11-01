namespace _21103100849_TranDucHoan
{
    partial class ChiTietBanHang_0849
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv2_0849 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMAKH_0849 = new System.Windows.Forms.TextBox();
            this.txtSLHD_0849 = new System.Windows.Forms.TextBox();
            this.btSua_0849 = new System.Windows.Forms.Button();
            this.btThoat_0849 = new System.Windows.Forms.Button();
            this.btXoa_0849 = new System.Windows.Forms.Button();
            this.btThem_0849 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL_0849 = new System.Windows.Forms.TextBox();
            this.txtMaMH_0849 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNM_0849 = new System.Windows.Forms.DateTimePicker();
            this.maMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2_0849)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv2_0849);
            this.groupBox2.Location = new System.Drawing.Point(79, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 261);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HÓA ĐƠN CHI TIẾT BÁN HÀNG";
            // 
            // dgv2_0849
            // 
            this.dgv2_0849.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2_0849.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMH,
            this.tenMH,
            this.donViTinh,
            this.Column1,
            this.Column2});
            this.dgv2_0849.Location = new System.Drawing.Point(28, 34);
            this.dgv2_0849.Name = "dgv2_0849";
            this.dgv2_0849.Size = new System.Drawing.Size(807, 206);
            this.dgv2_0849.TabIndex = 0;
            this.dgv2_0849.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_0849_CellClick);
            this.dgv2_0849.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_0849_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHI TIẾT BÁN HÀNG";
            // 
            // txtMAKH_0849
            // 
            this.txtMAKH_0849.Location = new System.Drawing.Point(229, 196);
            this.txtMAKH_0849.Name = "txtMAKH_0849";
            this.txtMAKH_0849.Size = new System.Drawing.Size(187, 20);
            this.txtMAKH_0849.TabIndex = 20;
            // 
            // txtSLHD_0849
            // 
            this.txtSLHD_0849.Location = new System.Drawing.Point(229, 132);
            this.txtSLHD_0849.Name = "txtSLHD_0849";
            this.txtSLHD_0849.Size = new System.Drawing.Size(187, 20);
            this.txtSLHD_0849.TabIndex = 19;
            // 
            // btSua_0849
            // 
            this.btSua_0849.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua_0849.Location = new System.Drawing.Point(368, 615);
            this.btSua_0849.Name = "btSua_0849";
            this.btSua_0849.Size = new System.Drawing.Size(104, 43);
            this.btSua_0849.TabIndex = 18;
            this.btSua_0849.Text = "SỬA";
            this.btSua_0849.UseVisualStyleBackColor = true;
            this.btSua_0849.Click += new System.EventHandler(this.btSua_0849_Click);
            // 
            // btThoat_0849
            // 
            this.btThoat_0849.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat_0849.Location = new System.Drawing.Point(843, 615);
            this.btThoat_0849.Name = "btThoat_0849";
            this.btThoat_0849.Size = new System.Drawing.Size(104, 43);
            this.btThoat_0849.TabIndex = 17;
            this.btThoat_0849.Text = "THOÁT";
            this.btThoat_0849.UseVisualStyleBackColor = true;
            this.btThoat_0849.Click += new System.EventHandler(this.btThoat_0849_Click);
            // 
            // btXoa_0849
            // 
            this.btXoa_0849.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa_0849.Location = new System.Drawing.Point(592, 615);
            this.btXoa_0849.Name = "btXoa_0849";
            this.btXoa_0849.Size = new System.Drawing.Size(104, 43);
            this.btXoa_0849.TabIndex = 16;
            this.btXoa_0849.Text = "XÓA";
            this.btXoa_0849.UseVisualStyleBackColor = true;
            this.btXoa_0849.Click += new System.EventHandler(this.btXoa_0849_Click);
            // 
            // btThem_0849
            // 
            this.btThem_0849.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem_0849.Location = new System.Drawing.Point(121, 615);
            this.btThem_0849.Name = "btThem_0849";
            this.btThem_0849.Size = new System.Drawing.Size(104, 43);
            this.btThem_0849.TabIndex = 14;
            this.btThem_0849.Text = "THÊM";
            this.btThem_0849.UseVisualStyleBackColor = true;
            this.btThem_0849.Click += new System.EventHandler(this.btThem_0849_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "NGÀY MUA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "MÃ KHÁCH HÀNG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(118, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "SỐ LIỆU HÓA ĐƠN:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(683, 274);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(187, 20);
            this.txtDonGia.TabIndex = 27;
            // 
            // txtSL_0849
            // 
            this.txtSL_0849.Location = new System.Drawing.Point(683, 196);
            this.txtSL_0849.Name = "txtSL_0849";
            this.txtSL_0849.Size = new System.Drawing.Size(187, 20);
            this.txtSL_0849.TabIndex = 26;
            // 
            // txtMaMH_0849
            // 
            this.txtMaMH_0849.Location = new System.Drawing.Point(683, 132);
            this.txtMaMH_0849.Name = "txtMaMH_0849";
            this.txtMaMH_0849.Size = new System.Drawing.Size(187, 20);
            this.txtMaMH_0849.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ĐƠN GIÁ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "SỐ LƯỢNG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(572, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "MÃ MẶT HÀNG:";
            // 
            // dtpNM_0849
            // 
            this.dtpNM_0849.CustomFormat = "dd/MM/yyyy";
            this.dtpNM_0849.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNM_0849.Location = new System.Drawing.Point(229, 269);
            this.dtpNM_0849.Name = "dtpNM_0849";
            this.dtpNM_0849.Size = new System.Drawing.Size(187, 20);
            this.dtpNM_0849.TabIndex = 28;
            // 
            // maMH
            // 
            this.maMH.DataPropertyName = "STT";
            this.maMH.HeaderText = "STT";
            this.maMH.Name = "maMH";
            // 
            // tenMH
            // 
            this.tenMH.DataPropertyName = "MaMH";
            this.tenMH.HeaderText = "MÃ MẶT HÀNG";
            this.tenMH.Name = "tenMH";
            this.tenMH.Width = 250;
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "SoLuong";
            this.donViTinh.HeaderText = "SL";
            this.donViTinh.Name = "donViTinh";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DonGia";
            this.Column1.HeaderText = "ĐƠN GIÁ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ThanhTien";
            this.Column2.HeaderText = "THÀNH TIỀN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // ChiTietBanHang_0849
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 683);
            this.Controls.Add(this.dtpNM_0849);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSL_0849);
            this.Controls.Add(this.txtMaMH_0849);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMAKH_0849);
            this.Controls.Add(this.txtSLHD_0849);
            this.Controls.Add(this.btSua_0849);
            this.Controls.Add(this.btThoat_0849);
            this.Controls.Add(this.btXoa_0849);
            this.Controls.Add(this.btThem_0849);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietBanHang_0849";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietBanHang_0849";
            this.Load += new System.EventHandler(this.ChiTietBanHang_0849_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2_0849)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv2_0849;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMAKH_0849;
        private System.Windows.Forms.TextBox txtSLHD_0849;
        private System.Windows.Forms.Button btSua_0849;
        private System.Windows.Forms.Button btThoat_0849;
        private System.Windows.Forms.Button btXoa_0849;
        private System.Windows.Forms.Button btThem_0849;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL_0849;
        private System.Windows.Forms.TextBox txtMaMH_0849;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNM_0849;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}