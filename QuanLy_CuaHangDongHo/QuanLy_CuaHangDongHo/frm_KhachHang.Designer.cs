namespace QuanLy_CuaHangDongHo
{
    partial class frm_KhachHang
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
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.cbGtKH = new System.Windows.Forms.ComboBox();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblLuuYMaKH = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDCKH = new System.Windows.Forms.TextBox();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cuahang_donghoDataSet1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.donghoTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter();
            this.cuahang_donghoDataSet2 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.cuahang_donghoDataSet3 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.thongsokithuatTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.nhanvienTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnThoatChucNang = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.colSDTNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHONV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHINV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(367, 263);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(251, 27);
            this.txtCMND.TabIndex = 27;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.button1);
            this.panelInput.Controls.Add(this.button3);
            this.panelInput.Controls.Add(this.cbGtKH);
            this.panelInput.Controls.Add(this.dateTimeNgaySinh);
            this.panelInput.Controls.Add(this.lblLuuYMaKH);
            this.panelInput.Controls.Add(this.txtCMND);
            this.panelInput.Controls.Add(this.label10);
            this.panelInput.Controls.Add(this.txtDCKH);
            this.panelInput.Controls.Add(this.txtSdtKH);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.txtEmailKH);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtTenKH);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtHoKH);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.txtMaKH);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 539);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1356, 449);
            this.panelInput.TabIndex = 12;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(235, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 34);
            this.button3.TabIndex = 37;
            this.button3.Text = "Xem Địa Chỉ Giao Hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbGtKH
            // 
            this.cbGtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGtKH.FormattingEnabled = true;
            this.cbGtKH.Items.AddRange(new object[] {
            "Chọn giới tính",
            "Nam",
            "Nữ"});
            this.cbGtKH.Location = new System.Drawing.Point(934, 91);
            this.cbGtKH.Name = "cbGtKH";
            this.cbGtKH.Size = new System.Drawing.Size(265, 28);
            this.cbGtKH.TabIndex = 36;
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(934, 301);
            this.dateTimeNgaySinh.MinDate = new System.DateTime(1929, 12, 31, 0, 0, 0, 0);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(265, 27);
            this.dateTimeNgaySinh.TabIndex = 35;
            this.dateTimeNgaySinh.Value = new System.DateTime(2024, 12, 13, 16, 56, 11, 0);
            // 
            // lblLuuYMaKH
            // 
            this.lblLuuYMaKH.AutoSize = true;
            this.lblLuuYMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuuYMaKH.Location = new System.Drawing.Point(353, 120);
            this.lblLuuYMaKH.Name = "lblLuuYMaKH";
            this.lblLuuYMaKH.Size = new System.Drawing.Size(279, 16);
            this.lblLuuYMaKH.TabIndex = 34;
            this.lblLuuYMaKH.Text = "Mã khách hàng sẽ không thể sửa khi cập nhật!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(208, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "CMND/CCCD:";
            // 
            // txtDCKH
            // 
            this.txtDCKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCKH.Location = new System.Drawing.Point(934, 140);
            this.txtDCKH.MaxLength = 50;
            this.txtDCKH.Name = "txtDCKH";
            this.txtDCKH.Size = new System.Drawing.Size(265, 27);
            this.txtDCKH.TabIndex = 25;
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdtKH.Location = new System.Drawing.Point(934, 196);
            this.txtSdtKH.MaxLength = 50;
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(265, 27);
            this.txtSdtKH.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORM KHÁCH HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ngày Sinh Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(702, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới Tính Khách Hàng: ";
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailKH.Location = new System.Drawing.Point(934, 249);
            this.txtEmailKH.MaxLength = 50;
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(265, 27);
            this.txtEmailKH.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(702, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email Khách Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(702, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số Điện Thoại Khách Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(702, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa Chỉ Khách Hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(367, 202);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(251, 27);
            this.txtTenKH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ Khách Hàng:";
            // 
            // txtHoKH
            // 
            this.txtHoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoKH.Location = new System.Drawing.Point(367, 146);
            this.txtHoKH.MaxLength = 50;
            this.txtHoKH.Name = "txtHoKH";
            this.txtHoKH.Size = new System.Drawing.Size(251, 27);
            this.txtHoKH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(367, 90);
            this.txtMaKH.MaxLength = 20;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(251, 27);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // cuahang_donghoDataSet1
            // 
            this.cuahang_donghoDataSet1.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // donghoTableAdapter1
            // 
            this.donghoTableAdapter1.ClearBeforeFill = true;
            // 
            // cuahang_donghoDataSet2
            // 
            this.cuahang_donghoDataSet2.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuahang_donghoDataSet3
            // 
            this.cuahang_donghoDataSet3.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongsokithuatTableAdapter1
            // 
            this.thongsokithuatTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkhachhang.Location = new System.Drawing.Point(3, 24);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.RowHeadersWidth = 51;
            this.dgvkhachhang.RowTemplate.Height = 24;
            this.dgvkhachhang.Size = new System.Drawing.Size(1350, 910);
            this.dgvkhachhang.TabIndex = 9;
            this.dgvkhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellContentClick);
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvkhachhang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1356, 937);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
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
            this.toolStripMenu.Size = new System.Drawing.Size(1356, 51);
            this.toolStripMenu.TabIndex = 11;
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
            this.btnCapNhat.Text = "Câp Nhật";
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
            // openFileDialogChonAnh
            // 
            this.openFileDialogChonAnh.FileName = "openFileDialog";
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
            // colDIACHINV
            // 
            this.colDIACHINV.FieldName = "DIACHINV";
            this.colDIACHINV.MinWidth = 61;
            this.colDIACHINV.Name = "colDIACHINV";
            this.colDIACHINV.Visible = true;
            this.colDIACHINV.VisibleIndex = 5;
            this.colDIACHINV.Width = 227;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "Xem Phiếu Mua Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 988);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "frm_KhachHang";
            this.Text = "fm_KhachHang";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSDTNV;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblLuuYMaKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDCKH;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter donghoTableAdapter1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet2;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet3;
        private cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter thongsokithuatTableAdapter1;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHONV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINHNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINHNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHINV;
        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.ComboBox cbGtKH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}