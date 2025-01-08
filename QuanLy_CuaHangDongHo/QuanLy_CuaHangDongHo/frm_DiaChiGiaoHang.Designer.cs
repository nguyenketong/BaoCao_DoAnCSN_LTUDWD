namespace QuanLy_CuaHangDongHo
{
    partial class frm_DiaChiGiaoHang
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLuuYDCGH = new System.Windows.Forms.Label();
            this.cb_makhachhang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenTinh = new System.Windows.Forms.TextBox();
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDCGH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdiachigiaohang = new System.Windows.Forms.DataGridView();
            this.panelInput = new System.Windows.Forms.Panel();
            this.txtDCcuthe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHuyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.thongsokithuatTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter();
            this.cuahang_donghoDataSet3 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.nhanvienTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
            this.cuahang_donghoDataSet2 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.donghoTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.cuahang_donghoDataSet1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnThoatChucNang = new System.Windows.Forms.ToolStripButton();
            this.colMANHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHONV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHINV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiachigiaohang)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(417, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORM ĐỊA CHỈ GIAO HÀNG";
            // 
            // lblLuuYDCGH
            // 
            this.lblLuuYDCGH.AutoSize = true;
            this.lblLuuYDCGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuuYDCGH.Location = new System.Drawing.Point(320, 114);
            this.lblLuuYDCGH.Name = "lblLuuYDCGH";
            this.lblLuuYDCGH.Size = new System.Drawing.Size(312, 16);
            this.lblLuuYDCGH.TabIndex = 34;
            this.lblLuuYDCGH.Text = "Mã địa chỉ giao hàng sẽ không thể sửa khi cập nhật!";
            // 
            // cb_makhachhang
            // 
            this.cb_makhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_makhachhang.FormattingEnabled = true;
            this.cb_makhachhang.Location = new System.Drawing.Point(879, 88);
            this.cb_makhachhang.Name = "cb_makhachhang";
            this.cb_makhachhang.Size = new System.Drawing.Size(264, 28);
            this.cb_makhachhang.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(718, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Mã Khách Hàng:";
            // 
            // txtTenTinh
            // 
            this.txtTenTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTinh.Location = new System.Drawing.Point(367, 151);
            this.txtTenTinh.MaxLength = 50;
            this.txtTenTinh.Name = "txtTenTinh";
            this.txtTenTinh.Size = new System.Drawing.Size(242, 27);
            this.txtTenTinh.TabIndex = 25;
            // 
            // openFileDialogChonAnh
            // 
            this.openFileDialogChonAnh.FileName = "openFileDialog";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cập nhật Mã Khách Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên Tỉnh:";
            // 
            // txtMaDCGH
            // 
            this.txtMaDCGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDCGH.Location = new System.Drawing.Point(367, 84);
            this.txtMaDCGH.MaxLength = 20;
            this.txtMaDCGH.Name = "txtMaDCGH";
            this.txtMaDCGH.Size = new System.Drawing.Size(242, 27);
            this.txtMaDCGH.TabIndex = 1;
            this.txtMaDCGH.TextChanged += new System.EventHandler(this.txtMaDCGH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Địa Chỉ Giao Hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdiachigiaohang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1231, 427);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin địa chỉ giao hàng";
            // 
            // dgvdiachigiaohang
            // 
            this.dgvdiachigiaohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiachigiaohang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdiachigiaohang.Location = new System.Drawing.Point(3, 24);
            this.dgvdiachigiaohang.Name = "dgvdiachigiaohang";
            this.dgvdiachigiaohang.RowHeadersWidth = 51;
            this.dgvdiachigiaohang.RowTemplate.Height = 24;
            this.dgvdiachigiaohang.Size = new System.Drawing.Size(1225, 400);
            this.dgvdiachigiaohang.TabIndex = 9;
            this.dgvdiachigiaohang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdiachigiaohang_CellContentClick);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.txtDCcuthe);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtTenHuyen);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.lblLuuYDCGH);
            this.panelInput.Controls.Add(this.button1);
            this.panelInput.Controls.Add(this.cb_makhachhang);
            this.panelInput.Controls.Add(this.label11);
            this.panelInput.Controls.Add(this.txtTenTinh);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtMaDCGH);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 478);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1231, 312);
            this.panelInput.TabIndex = 15;
            // 
            // txtDCcuthe
            // 
            this.txtDCcuthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCcuthe.Location = new System.Drawing.Point(879, 205);
            this.txtDCcuthe.MaxLength = 50;
            this.txtDCcuthe.Name = "txtDCcuthe";
            this.txtDCcuthe.Size = new System.Drawing.Size(264, 27);
            this.txtDCcuthe.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Địa Chỉ Cụ Thể:";
            // 
            // txtTenHuyen
            // 
            this.txtTenHuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHuyen.Location = new System.Drawing.Point(367, 208);
            this.txtTenHuyen.MaxLength = 50;
            this.txtTenHuyen.Name = "txtTenHuyen";
            this.txtTenHuyen.Size = new System.Drawing.Size(242, 27);
            this.txtTenHuyen.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên Huyện:";
            // 
            // thongsokithuatTableAdapter1
            // 
            this.thongsokithuatTableAdapter1.ClearBeforeFill = true;
            // 
            // cuahang_donghoDataSet3
            // 
            this.cuahang_donghoDataSet3.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // cuahang_donghoDataSet2
            // 
            this.cuahang_donghoDataSet2.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donghoTableAdapter1
            // 
            this.donghoTableAdapter1.ClearBeforeFill = true;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // cuahang_donghoDataSet1
            // 
            this.cuahang_donghoDataSet1.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnCapNhat,
            this.btnLuu,
            this.btnThoatChucNang});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(8);
            this.toolStripMenu.Size = new System.Drawing.Size(1231, 51);
            this.toolStripMenu.TabIndex = 14;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QuanLy_CuaHangDongHo.Properties.Resources.add_free_icon_font_blue_24px;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnThem.Size = new System.Drawing.Size(92, 32);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QuanLy_CuaHangDongHo.Properties.Resources.edit_free_icon_font_blue_24px;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSua.Size = new System.Drawing.Size(77, 32);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QuanLy_CuaHangDongHo.Properties.Resources.trash_free_icon_font_blue_24px;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnXoa.Size = new System.Drawing.Size(78, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Image = global::QuanLy_CuaHangDongHo.Properties.Resources.disk_free_icon_font_blue_24px2;
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCapNhat.Size = new System.Drawing.Size(126, 32);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QuanLy_CuaHangDongHo.Properties.Resources.diskette_blue_24px1;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnLuu.Size = new System.Drawing.Size(105, 32);
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoatChucNang
            // 
            this.btnThoatChucNang.ForeColor = System.Drawing.Color.Black;
            this.btnThoatChucNang.Image = global::QuanLy_CuaHangDongHo.Properties.Resources.sign_out_alt_free_icon_font_blue_24px;
            this.btnThoatChucNang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoatChucNang.Name = "btnThoatChucNang";
            this.btnThoatChucNang.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnThoatChucNang.Size = new System.Drawing.Size(189, 32);
            this.btnThoatChucNang.Text = "Thoát chức năng";
            this.btnThoatChucNang.Click += new System.EventHandler(this.btnThoatChucNang_Click);
            // 
            // colMANHANVIEN
            // 
            this.colMANHANVIEN.FieldName = "MANHANVIEN";
            this.colMANHANVIEN.MinWidth = 61;
            this.colMANHANVIEN.Name = "colMANHANVIEN";
            this.colMANHANVIEN.Visible = true;
            this.colMANHANVIEN.VisibleIndex = 0;
            this.colMANHANVIEN.Width = 227;
            // 
            // colHONV
            // 
            this.colHONV.FieldName = "HONV";
            this.colHONV.MinWidth = 61;
            this.colHONV.Name = "colHONV";
            this.colHONV.Visible = true;
            this.colHONV.VisibleIndex = 1;
            this.colHONV.Width = 227;
            // 
            // colTENNV
            // 
            this.colTENNV.FieldName = "TENNV";
            this.colTENNV.MinWidth = 61;
            this.colTENNV.Name = "colTENNV";
            this.colTENNV.Visible = true;
            this.colTENNV.VisibleIndex = 2;
            this.colTENNV.Width = 227;
            // 
            // colGIOITINHNV
            // 
            this.colGIOITINHNV.FieldName = "GIOITINHNV";
            this.colGIOITINHNV.MinWidth = 61;
            this.colGIOITINHNV.Name = "colGIOITINHNV";
            this.colGIOITINHNV.Visible = true;
            this.colGIOITINHNV.VisibleIndex = 3;
            this.colGIOITINHNV.Width = 227;
            // 
            // colNGAYSINHNV
            // 
            this.colNGAYSINHNV.FieldName = "NGAYSINHNV";
            this.colNGAYSINHNV.MinWidth = 61;
            this.colNGAYSINHNV.Name = "colNGAYSINHNV";
            this.colNGAYSINHNV.Visible = true;
            this.colNGAYSINHNV.VisibleIndex = 4;
            this.colNGAYSINHNV.Width = 227;
            // 
            // colSDTNV
            // 
            this.colSDTNV.FieldName = "SDTNV";
            this.colSDTNV.MinWidth = 61;
            this.colSDTNV.Name = "colSDTNV";
            this.colSDTNV.Visible = true;
            this.colSDTNV.VisibleIndex = 6;
            this.colSDTNV.Width = 227;
            // 
            // colDIACHINV
            // 
            this.colDIACHINV.FieldName = "DIACHINV";
            this.colDIACHINV.MinWidth = 61;
            this.colDIACHINV.Name = "colDIACHINV";
            this.colDIACHINV.Visible = true;
            this.colDIACHINV.VisibleIndex = 5;
            this.colDIACHINV.Width = 227;
            // 
            // frm_DiaChiGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 790);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "frm_DiaChiGiaoHang";
            this.Text = "frm_DiaChiGiaoHang";
            this.Load += new System.EventHandler(this.frm_DiaChiGiaoHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiachigiaohang)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.Label lblLuuYDCGH;
        private System.Windows.Forms.ComboBox cb_makhachhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenTinh;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHONV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINHNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINHNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDCGH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHINV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdiachigiaohang;
        private System.Windows.Forms.Panel panelInput;
        private cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter thongsokithuatTableAdapter1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet3;
        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet2;
        private cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter donghoTableAdapter1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.TextBox txtDCcuthe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHuyen;
        private System.Windows.Forms.Label label2;
    }
}