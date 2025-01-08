namespace QuanLy_CuaHangDongHo
{
    partial class frm_ThongSoKiThuat
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnThoatChucNang = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClmatkinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKNchongnuoc = new System.Windows.Forms.TextBox();
            this.txtCLdaydeo = new System.Windows.Forms.TextBox();
            this.txtCLvo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTthoPIN = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblLuuYMaCH = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cuahang_donghoDataSet1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.donghoTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter();
            this.cuahang_donghoDataSet2 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.nhanvienTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
            this.cuahang_donghoDataSet3 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.thongsokithuatTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter();
            this.dgvcauhinh = new System.Windows.Forms.DataGridView();
            this.colMANHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHONV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHINV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripMenu.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcauhinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStripMenu.Size = new System.Drawing.Size(1433, 51);
            this.toolStripMenu.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Cấu Hình:";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCH.Location = new System.Drawing.Point(368, 72);
            this.txtMaCH.MaxLength = 20;
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(266, 27);
            this.txtMaCH.TabIndex = 1;
            this.txtMaCH.TextChanged += new System.EventHandler(this.txtMaCH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trọng Lượng:";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKichThuoc.Location = new System.Drawing.Point(368, 128);
            this.txtKichThuoc.MaxLength = 50;
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(266, 27);
            this.txtKichThuoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kích Thước:";
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrongLuong.Location = new System.Drawing.Point(368, 184);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(266, 27);
            this.txtTrongLuong.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(708, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chất Liệu Vỏ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(708, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chất Liệu Dây Đeo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(708, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Chất Liệu Mặt Kính:";
            // 
            // txtClmatkinh
            // 
            this.txtClmatkinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClmatkinh.Location = new System.Drawing.Point(909, 184);
            this.txtClmatkinh.MaxLength = 50;
            this.txtClmatkinh.Name = "txtClmatkinh";
            this.txtClmatkinh.Size = new System.Drawing.Size(255, 27);
            this.txtClmatkinh.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Xuất Xứ:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatXu.Location = new System.Drawing.Point(368, 240);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(266, 27);
            this.txtXuatXu.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(708, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Khả Năng Chống Nước:";
            // 
            // txtKNchongnuoc
            // 
            this.txtKNchongnuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKNchongnuoc.Location = new System.Drawing.Point(909, 238);
            this.txtKNchongnuoc.Name = "txtKNchongnuoc";
            this.txtKNchongnuoc.Size = new System.Drawing.Size(255, 27);
            this.txtKNchongnuoc.TabIndex = 22;
            // 
            // txtCLdaydeo
            // 
            this.txtCLdaydeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLdaydeo.Location = new System.Drawing.Point(909, 131);
            this.txtCLdaydeo.MaxLength = 50;
            this.txtCLdaydeo.Name = "txtCLdaydeo";
            this.txtCLdaydeo.Size = new System.Drawing.Size(255, 27);
            this.txtCLdaydeo.TabIndex = 24;
            // 
            // txtCLvo
            // 
            this.txtCLvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLvo.Location = new System.Drawing.Point(909, 75);
            this.txtCLvo.MaxLength = 50;
            this.txtCLvo.Name = "txtCLvo";
            this.txtCLvo.Size = new System.Drawing.Size(255, 27);
            this.txtCLvo.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(233, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tuổi Thọ Pin:";
            // 
            // txtTthoPIN
            // 
            this.txtTthoPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTthoPIN.Location = new System.Drawing.Point(368, 299);
            this.txtTthoPIN.Name = "txtTthoPIN";
            this.txtTthoPIN.Size = new System.Drawing.Size(266, 27);
            this.txtTthoPIN.TabIndex = 27;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.lblLuuYMaCH);
            this.panelInput.Controls.Add(this.button1);
            this.panelInput.Controls.Add(this.txtTthoPIN);
            this.panelInput.Controls.Add(this.label10);
            this.panelInput.Controls.Add(this.txtCLvo);
            this.panelInput.Controls.Add(this.txtCLdaydeo);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.txtKNchongnuoc);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.txtXuatXu);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.txtClmatkinh);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtTrongLuong);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtKichThuoc);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.txtMaCH);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 606);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1433, 360);
            this.panelInput.TabIndex = 8;
            // 
            // lblLuuYMaCH
            // 
            this.lblLuuYMaCH.AutoSize = true;
            this.lblLuuYMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuuYMaCH.Location = new System.Drawing.Point(341, 102);
            this.lblLuuYMaCH.Name = "lblLuuYMaCH";
            this.lblLuuYMaCH.Size = new System.Drawing.Size(259, 16);
            this.lblLuuYMaCH.TabIndex = 34;
            this.lblLuuYMaCH.Text = "Mã cấu hình sẽ không thể sửa khi cập nhật!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(909, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Xem Mã đồng hồ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(432, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORM THÔNG SỐ KĨ THUẬT";
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
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
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
            // dgvcauhinh
            // 
            this.dgvcauhinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcauhinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcauhinh.Location = new System.Drawing.Point(3, 24);
            this.dgvcauhinh.Name = "dgvcauhinh";
            this.dgvcauhinh.RowHeadersWidth = 51;
            this.dgvcauhinh.RowTemplate.Height = 24;
            this.dgvcauhinh.Size = new System.Drawing.Size(1427, 528);
            this.dgvcauhinh.TabIndex = 9;
            this.dgvcauhinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcauhinh_CellContentClick);
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
            // colSDTNV
            // 
            this.colSDTNV.FieldName = "SDTNV";
            this.colSDTNV.MinWidth = 61;
            this.colSDTNV.Name = "colSDTNV";
            this.colSDTNV.Visible = true;
            this.colSDTNV.VisibleIndex = 6;
            this.colSDTNV.Width = 227;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvcauhinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1433, 555);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cấu hình";
            // 
            // frm_ThongSoKiThuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 966);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "frm_ThongSoKiThuat";
            this.Text = "frm_ThongSoKiThuat";
            this.Load += new System.EventHandler(this.frm_ThongSoKiThuat_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcauhinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClmatkinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKNchongnuoc;
        private System.Windows.Forms.TextBox txtCLdaydeo;
        private System.Windows.Forms.TextBox txtCLvo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTthoPIN;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label9;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter donghoTableAdapter1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHONV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINHNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINHNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHINV;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTNV;
        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet3;
        private cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter thongsokithuatTableAdapter1;
        private System.Windows.Forms.DataGridView dgvcauhinh;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLuuYMaCH;
        private System.Windows.Forms.ToolStripButton btnLuu;
    }
}