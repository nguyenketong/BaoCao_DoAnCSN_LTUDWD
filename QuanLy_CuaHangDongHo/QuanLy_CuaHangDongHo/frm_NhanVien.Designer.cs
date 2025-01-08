namespace QuanLy_CuaHangDongHo
{
    partial class frm_NhanVien
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
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnThoatChucNang = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxGT = new System.Windows.Forms.ComboBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblLuuYMaNV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSdtNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDCNV = new System.Windows.Forms.TextBox();
            this.cuahang_donghoDataSet1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.donghoTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter();
            this.nhanvienTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.TableAdapterManager();
            this.nhanvienTableAdapter2 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripMenu.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogChonAnh
            // 
            this.openFileDialogChonAnh.FileName = "openFileDialog";
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
            this.toolStripMenu.Size = new System.Drawing.Size(1380, 51);
            this.toolStripMenu.TabIndex = 3;
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
            this.btnCapNhat.Image = global::QuanLy_CuaHangDongHo.Properties.Resources.disk_free_icon_font_blue_24px1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(390, 84);
            this.txtMaNV.MaxLength = 20;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(249, 27);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txtHoNV
            // 
            this.txtHoNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoNV.Location = new System.Drawing.Point(390, 140);
            this.txtHoNV.MaxLength = 50;
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(249, 27);
            this.txtHoNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ Nhân Viên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(390, 196);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(249, 27);
            this.txtTenNV.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(704, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Địa chỉ:";
            // 
            // comboBoxGT
            // 
            this.comboBoxGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGT.FormattingEnabled = true;
            this.comboBoxGT.Items.AddRange(new object[] {
            "Chọn giới tính",
            "Nam",
            "Nữ"});
            this.comboBoxGT.Location = new System.Drawing.Point(856, 87);
            this.comboBoxGT.Name = "comboBoxGT";
            this.comboBoxGT.Size = new System.Drawing.Size(261, 28);
            this.comboBoxGT.TabIndex = 5;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.lblLuuYMaNV);
            this.panelInput.Controls.Add(this.button1);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.txtEmNV);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.txtSdtNV);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.dateTimeNgaySinh);
            this.panelInput.Controls.Add(this.txtDCNV);
            this.panelInput.Controls.Add(this.comboBoxGT);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtTenNV);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtHoNV);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.txtMaNV);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 590);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1380, 360);
            this.panelInput.TabIndex = 5;
            // 
            // lblLuuYMaNV
            // 
            this.lblLuuYMaNV.AutoSize = true;
            this.lblLuuYMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuuYMaNV.Location = new System.Drawing.Point(387, 114);
            this.lblLuuYMaNV.Name = "lblLuuYMaNV";
            this.lblLuuYMaNV.Size = new System.Drawing.Size(267, 16);
            this.lblLuuYMaNV.TabIndex = 33;
            this.lblLuuYMaNV.Text = "Mã nhân viên sẽ không thể sửa khi cập nhật!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(856, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "Xem Mã đồng hồ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORM NHÂN VIÊN";
            // 
            // txtEmNV
            // 
            this.txtEmNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmNV.Location = new System.Drawing.Point(390, 306);
            this.txtEmNV.Name = "txtEmNV";
            this.txtEmNV.Size = new System.Drawing.Size(249, 27);
            this.txtEmNV.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Email:";
            // 
            // txtSdtNV
            // 
            this.txtSdtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdtNV.Location = new System.Drawing.Point(390, 252);
            this.txtSdtNV.Name = "txtSdtNV";
            this.txtSdtNV.Size = new System.Drawing.Size(249, 27);
            this.txtSdtNV.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số điên thoại:";
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(856, 141);
            this.dateTimeNgaySinh.MinDate = new System.DateTime(1929, 12, 31, 0, 0, 0, 0);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(261, 27);
            this.dateTimeNgaySinh.TabIndex = 18;
            this.dateTimeNgaySinh.Value = new System.DateTime(2024, 12, 13, 16, 56, 11, 0);
            // 
            // txtDCNV
            // 
            this.txtDCNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCNV.Location = new System.Drawing.Point(856, 196);
            this.txtDCNV.MaxLength = 50;
            this.txtDCNV.Name = "txtDCNV";
            this.txtDCNV.Size = new System.Drawing.Size(261, 27);
            this.txtDCNV.TabIndex = 17;
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
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.cuahang_donghoDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIACHIGIAOHANGTableAdapter = null;
            this.tableAdapterManager.DONGHOTableAdapter = this.donghoTableAdapter1;
            this.tableAdapterManager.HANGDONGHOTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.MUATableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nhanvienTableAdapter1;
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.THONGSOKITHUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanvienTableAdapter2
            // 
            this.nhanvienTableAdapter2.ClearBeforeFill = true;
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnhanvien.Location = new System.Drawing.Point(3, 24);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.Size = new System.Drawing.Size(1374, 512);
            this.dgvnhanvien.TabIndex = 6;
            this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvnhanvien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1380, 539);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 950);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "frm_NhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormDongHo_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxGT;
        private System.Windows.Forms.Panel panelInput;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter donghoTableAdapter1;
        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private System.Windows.Forms.TextBox txtDCNV;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.TextBox txtSdtNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private cuahang_donghoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter2;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLuuYMaNV;
        private System.Windows.Forms.ToolStripButton btnLuu;
    }
}