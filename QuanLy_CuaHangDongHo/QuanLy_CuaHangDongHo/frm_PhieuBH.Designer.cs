namespace QuanLy_CuaHangDongHo
{
    partial class frm_PhieuBH
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
            this.colNGAYSINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongsokithuatTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colMANHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHINV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvphieubaohanh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLuuYPBH = new System.Windows.Forms.Label();
            this.dateTimeNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayKT = new System.Windows.Forms.DateTimePicker();
            this.panelInput = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDCGH = new System.Windows.Forms.TextBox();
            this.colHONV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanvienTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donghoTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter();
            this.cuahang_donghoDataSet3 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.cuahang_donghoDataSet2 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.cuahang_donghoDataSet1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnThoatChucNang = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieubaohanh)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // thongsokithuatTableAdapter1
            // 
            this.thongsokithuatTableAdapter1.ClearBeforeFill = true;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
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
            // colDIACHINV
            // 
            this.colDIACHINV.FieldName = "DIACHINV";
            this.colDIACHINV.MinWidth = 61;
            this.colDIACHINV.Name = "colDIACHINV";
            this.colDIACHINV.Visible = true;
            this.colDIACHINV.VisibleIndex = 5;
            this.colDIACHINV.Width = 227;
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
            // colSDTNV
            // 
            this.colSDTNV.FieldName = "SDTNV";
            this.colSDTNV.MinWidth = 61;
            this.colSDTNV.Name = "colSDTNV";
            this.colSDTNV.Visible = true;
            this.colSDTNV.VisibleIndex = 6;
            this.colSDTNV.Width = 227;
            // 
            // dgvphieubaohanh
            // 
            this.dgvphieubaohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieubaohanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvphieubaohanh.Location = new System.Drawing.Point(3, 24);
            this.dgvphieubaohanh.Name = "dgvphieubaohanh";
            this.dgvphieubaohanh.RowHeadersWidth = 51;
            this.dgvphieubaohanh.RowTemplate.Height = 24;
            this.dgvphieubaohanh.Size = new System.Drawing.Size(1445, 461);
            this.dgvphieubaohanh.TabIndex = 10;
            this.dgvphieubaohanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieubaohanh_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Mã Phiếu Bảo Hành:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(695, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORM BẢO HÀNH";
            // 
            // lblLuuYPBH
            // 
            this.lblLuuYPBH.AutoSize = true;
            this.lblLuuYPBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuuYPBH.Location = new System.Drawing.Point(492, 122);
            this.lblLuuYPBH.Name = "lblLuuYPBH";
            this.lblLuuYPBH.Size = new System.Drawing.Size(302, 16);
            this.lblLuuYPBH.TabIndex = 34;
            this.lblLuuYPBH.Text = "Mã phiếu bảo hành sẽ không thể sửa khi cập nhật!";
            // 
            // dateTimeNgayBD
            // 
            this.dateTimeNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayBD.Location = new System.Drawing.Point(523, 155);
            this.dateTimeNgayBD.MinDate = new System.DateTime(1929, 12, 31, 0, 0, 0, 0);
            this.dateTimeNgayBD.Name = "dateTimeNgayBD";
            this.dateTimeNgayBD.Size = new System.Drawing.Size(241, 27);
            this.dateTimeNgayBD.TabIndex = 36;
            this.dateTimeNgayBD.Value = new System.DateTime(2024, 12, 13, 16, 56, 11, 0);
            // 
            // dateTimeNgayKT
            // 
            this.dateTimeNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayKT.Location = new System.Drawing.Point(523, 211);
            this.dateTimeNgayKT.MinDate = new System.DateTime(1929, 12, 31, 0, 0, 0, 0);
            this.dateTimeNgayKT.Name = "dateTimeNgayKT";
            this.dateTimeNgayKT.Size = new System.Drawing.Size(241, 27);
            this.dateTimeNgayKT.TabIndex = 37;
            this.dateTimeNgayKT.Value = new System.DateTime(2024, 12, 13, 16, 56, 11, 0);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.dateTimeNgayKT);
            this.panelInput.Controls.Add(this.dateTimeNgayBD);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.lblLuuYPBH);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtMaDCGH);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 539);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1451, 320);
            this.panelInput.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ngày Kết Thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Bắt Đầu:";
            // 
            // txtMaDCGH
            // 
            this.txtMaDCGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDCGH.Location = new System.Drawing.Point(523, 92);
            this.txtMaDCGH.MaxLength = 20;
            this.txtMaDCGH.Name = "txtMaDCGH";
            this.txtMaDCGH.Size = new System.Drawing.Size(241, 27);
            this.txtMaDCGH.TabIndex = 1;
            this.txtMaDCGH.TextChanged += new System.EventHandler(this.txtMaDCGH_TextChanged);
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
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // openFileDialogChonAnh
            // 
            this.openFileDialogChonAnh.FileName = "openFileDialog";
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
            // donghoTableAdapter1
            // 
            this.donghoTableAdapter1.ClearBeforeFill = true;
            // 
            // cuahang_donghoDataSet3
            // 
            this.cuahang_donghoDataSet3.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuahang_donghoDataSet2
            // 
            this.cuahang_donghoDataSet2.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuahang_donghoDataSet1
            // 
            this.cuahang_donghoDataSet1.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.toolStripMenu.Size = new System.Drawing.Size(1451, 51);
            this.toolStripMenu.TabIndex = 17;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvphieubaohanh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1451, 488);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu bảo hành";
            // 
            // frm_PhieuBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 859);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.panelInput);
            this.Name = "frm_PhieuBH";
            this.Text = "frm_PhieuBH";
            this.Load += new System.EventHandler(this.frm_PhieuBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieubaohanh)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINHNV;
        private cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter thongsokithuatTableAdapter1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHINV;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINHNV;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTNV;
        private System.Windows.Forms.DataGridView dgvphieubaohanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLuuYPBH;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBD;
        private System.Windows.Forms.DateTimePicker dateTimeNgayKT;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDCGH;
        private DevExpress.XtraGrid.Columns.GridColumn colHONV;
        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter donghoTableAdapter1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet3;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet2;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}