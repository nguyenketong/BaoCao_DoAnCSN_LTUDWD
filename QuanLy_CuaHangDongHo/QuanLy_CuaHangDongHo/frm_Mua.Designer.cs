namespace QuanLy_CuaHangDongHo
{
    partial class frm_Mua
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
            this.nhanvienTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
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
            this.cuahang_donghoDataSet2 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.cuahang_donghoDataSet3 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_makhachhang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSLM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.dateTimeNgayMua = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_mapbh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_madongho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.thongsokithuatTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter();
            this.dgvmua = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colMANHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHONV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINHNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHINV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTNV = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
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
            this.toolStripMenu.Size = new System.Drawing.Size(1662, 51);
            this.toolStripMenu.TabIndex = 17;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ghi Chú:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1348, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cập nhật Mã Khách Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_makhachhang
            // 
            this.cb_makhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_makhachhang.FormattingEnabled = true;
            this.cb_makhachhang.Location = new System.Drawing.Point(1046, 83);
            this.cb_makhachhang.Name = "cb_makhachhang";
            this.cb_makhachhang.Size = new System.Drawing.Size(246, 28);
            this.cb_makhachhang.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(869, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Mã Khách Hàng:";
            // 
            // txtSLM
            // 
            this.txtSLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLM.Location = new System.Drawing.Point(543, 137);
            this.txtSLM.MaxLength = 50;
            this.txtSLM.Name = "txtSLM";
            this.txtSLM.Size = new System.Drawing.Size(190, 27);
            this.txtSLM.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(705, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORM MUA HÀNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn giá:";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.txtGhiChu);
            this.panelInput.Controls.Add(this.dateTimeNgayMua);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.button3);
            this.panelInput.Controls.Add(this.cb_mapbh);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.button2);
            this.panelInput.Controls.Add(this.cb_madongho);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.button1);
            this.panelInput.Controls.Add(this.cb_makhachhang);
            this.panelInput.Controls.Add(this.label11);
            this.panelInput.Controls.Add(this.txtSLM);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 473);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1662, 282);
            this.panelInput.TabIndex = 18;
            // 
            // dateTimeNgayMua
            // 
            this.dateTimeNgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayMua.Location = new System.Drawing.Point(543, 83);
            this.dateTimeNgayMua.MinDate = new System.DateTime(1929, 12, 31, 0, 0, 0, 0);
            this.dateTimeNgayMua.Name = "dateTimeNgayMua";
            this.dateTimeNgayMua.Size = new System.Drawing.Size(190, 27);
            this.dateTimeNgayMua.TabIndex = 44;
            this.dateTimeNgayMua.Value = new System.DateTime(2024, 12, 13, 16, 56, 11, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ngày Mua:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1348, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 32);
            this.button3.TabIndex = 42;
            this.button3.Text = "Cập nhật Mã phiếu bảo hành";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_mapbh
            // 
            this.cb_mapbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mapbh.FormattingEnabled = true;
            this.cb_mapbh.Location = new System.Drawing.Point(1046, 196);
            this.cb_mapbh.Name = "cb_mapbh";
            this.cb_mapbh.Size = new System.Drawing.Size(246, 28);
            this.cb_mapbh.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(869, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mã Phiếu Bảo Hành:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1348, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 32);
            this.button2.TabIndex = 39;
            this.button2.Text = "Cập nhật Mã đồng hồ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_madongho
            // 
            this.cb_madongho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_madongho.FormattingEnabled = true;
            this.cb_madongho.Location = new System.Drawing.Point(1046, 133);
            this.cb_madongho.Name = "cb_madongho";
            this.cb_madongho.Size = new System.Drawing.Size(246, 28);
            this.cb_madongho.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(869, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã Đồng Hồ:";
            // 
            // openFileDialogChonAnh
            // 
            this.openFileDialogChonAnh.FileName = "openFileDialog";
            // 
            // thongsokithuatTableAdapter1
            // 
            this.thongsokithuatTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvmua
            // 
            this.dgvmua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmua.Location = new System.Drawing.Point(3, 24);
            this.dgvmua.Name = "dgvmua";
            this.dgvmua.RowHeadersWidth = 51;
            this.dgvmua.RowTemplate.Height = 24;
            this.dgvmua.Size = new System.Drawing.Size(1656, 395);
            this.dgvmua.TabIndex = 9;
            this.dgvmua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmua_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvmua);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1662, 422);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Mua hàng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(36, 79);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(318, 172);
            this.txtGhiChu.TabIndex = 45;
            this.txtGhiChu.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // frm_Mua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 755);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.panelInput);
            this.Name = "frm_Mua";
            this.Text = "frm_Mua";
            this.Load += new System.EventHandler(this.frm_Mua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter donghoTableAdapter1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHONV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINHNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINHNV;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet2;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHINV;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_makhachhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSLM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTNV;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private cuahang_donghoDataSet1TableAdapters.THONGSOKITHUATTableAdapter thongsokithuatTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_madongho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cb_mapbh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNgayMua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvmua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}