namespace QuanLy_CuaHangDongHo
{
    partial class frm_NhaCungCap
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
            this.txtEMncc = new System.Windows.Forms.TextBox();
            this.txtSDTncc = new System.Windows.Forms.TextBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnThoatChucNang = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblLuuYMaNCC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDCncc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nhanvienTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter();
            this.cuahang_donghoDataSet1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.cuahang_donghoDataSet2 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.donghoTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.cuahang_donghoDataSet3 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.nhacungcapTableAdapter1 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1TableAdapters.NHACUNGCAPTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvnhacungcap = new System.Windows.Forms.DataGridView();
            this.dONGHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuahangdonghoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONGHOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cuahang_donghoDataSet11 = new QuanLy_CuaHangDongHo.cuahang_donghoDataSet1();
            this.dONGHOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKNHACUNGCCUNGCAPDONGHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenu.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacungcap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangdonghoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNHACUNGCCUNGCAPDONGHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEMncc
            // 
            this.txtEMncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMncc.Location = new System.Drawing.Point(859, 96);
            this.txtEMncc.MaxLength = 50;
            this.txtEMncc.Name = "txtEMncc";
            this.txtEMncc.Size = new System.Drawing.Size(262, 27);
            this.txtEMncc.TabIndex = 25;
            // 
            // txtSDTncc
            // 
            this.txtSDTncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTncc.Location = new System.Drawing.Point(859, 158);
            this.txtSDTncc.MaxLength = 50;
            this.txtSDTncc.Name = "txtSDTncc";
            this.txtSDTncc.Size = new System.Drawing.Size(262, 27);
            this.txtSDTncc.TabIndex = 24;
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
            this.toolStripMenu.Size = new System.Drawing.Size(1388, 51);
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
            // openFileDialogChonAnh
            // 
            this.openFileDialogChonAnh.FileName = "openFileDialog";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.lblLuuYMaNCC);
            this.panelInput.Controls.Add(this.button1);
            this.panelInput.Controls.Add(this.txtEMncc);
            this.panelInput.Controls.Add(this.txtSDTncc);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtDCncc);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtTenNCC);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.txtMaNCC);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 498);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1388, 311);
            this.panelInput.TabIndex = 12;
            // 
            // lblLuuYMaNCC
            // 
            this.lblLuuYMaNCC.AutoSize = true;
            this.lblLuuYMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuuYMaNCC.Location = new System.Drawing.Point(344, 122);
            this.lblLuuYMaNCC.Name = "lblLuuYMaNCC";
            this.lblLuuYMaNCC.Size = new System.Drawing.Size(290, 16);
            this.lblLuuYMaNCC.TabIndex = 30;
            this.lblLuuYMaNCC.Text = "Mã nhà cung cấp sẽ không thể sửa khi cập nhật!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(876, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 32);
            this.button1.TabIndex = 28;
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
            this.label9.Size = new System.Drawing.Size(357, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORM NHÀ CUNG CẤP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số ĐT Nhà Cung Cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email Nhà Cung Cấp:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDCncc
            // 
            this.txtDCncc.Location = new System.Drawing.Point(367, 207);
            this.txtDCncc.Name = "txtDCncc";
            this.txtDCncc.Size = new System.Drawing.Size(242, 22);
            this.txtDCncc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhà Cung Cấp:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(367, 151);
            this.txtTenNCC.MaxLength = 50;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(242, 22);
            this.txtTenNCC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa Chỉ Nhà Cung Cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(367, 92);
            this.txtMaNCC.MaxLength = 20;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(242, 27);
            this.txtMaNCC.TabIndex = 1;
            this.txtMaNCC.TextChanged += new System.EventHandler(this.txtMaNCC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhà Cung Cấp:";
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // cuahang_donghoDataSet1
            // 
            this.cuahang_donghoDataSet1.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cuahang_donghoDataSet3
            // 
            this.cuahang_donghoDataSet3.DataSetName = "cuahang_donghoDataSet";
            this.cuahang_donghoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhacungcapTableAdapter1
            // 
            this.nhacungcapTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvnhacungcap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1388, 447);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // dgvnhacungcap
            // 
            this.dgvnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhacungcap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnhacungcap.Location = new System.Drawing.Point(3, 24);
            this.dgvnhacungcap.Name = "dgvnhacungcap";
            this.dgvnhacungcap.RowHeadersWidth = 51;
            this.dgvnhacungcap.RowTemplate.Height = 24;
            this.dgvnhacungcap.Size = new System.Drawing.Size(1382, 420);
            this.dgvnhacungcap.TabIndex = 0;
            this.dgvnhacungcap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhacungcap_CellContentClick);
            // 
            // dONGHOBindingSource
            // 
            this.dONGHOBindingSource.DataMember = "DONGHO";
            this.dONGHOBindingSource.DataSource = this.cuahang_donghoDataSet1;
            // 
            // cuahangdonghoDataSet1BindingSource
            // 
            this.cuahangdonghoDataSet1BindingSource.DataSource = this.cuahang_donghoDataSet1;
            this.cuahangdonghoDataSet1BindingSource.Position = 0;
            // 
            // dONGHOBindingSource1
            // 
            this.dONGHOBindingSource1.DataMember = "DONGHO";
            this.dONGHOBindingSource1.DataSource = this.cuahangdonghoDataSet1BindingSource;
            // 
            // cuahang_donghoDataSet11
            // 
            this.cuahang_donghoDataSet11.DataSetName = "cuahang_donghoDataSet1";
            this.cuahang_donghoDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dONGHOBindingSource2
            // 
            this.dONGHOBindingSource2.DataMember = "DONGHO";
            this.dONGHOBindingSource2.DataSource = this.cuahang_donghoDataSet11;
            // 
            // fKNHACUNGCCUNGCAPDONGHOBindingSource
            // 
            this.fKNHACUNGCCUNGCAPDONGHOBindingSource.DataMember = "FK_NHACUNGC_CUNGCAP_DONGHO";
            this.fKNHACUNGCCUNGCAPDONGHOBindingSource.DataSource = this.dONGHOBindingSource2;
            // 
            // frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 809);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.panelInput);
            this.Name = "frm_NhaCungCap";
            this.Text = "frm_NhaCungCap";
            this.Load += new System.EventHandler(this.frm_NhaCungCap_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacungcap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangdonghoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_donghoDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNHACUNGCCUNGCAPDONGHOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEMncc;
        private System.Windows.Forms.TextBox txtSDTncc;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDCncc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label1;
        private cuahang_donghoDataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet2;
        private cuahang_donghoDataSet1TableAdapters.DONGHOTableAdapter donghoTableAdapter1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet3;
        private cuahang_donghoDataSet1TableAdapters.NHACUNGCAPTableAdapter nhacungcapTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvnhacungcap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.Label lblLuuYMaNCC;
        private System.Windows.Forms.BindingSource dONGHOBindingSource;
        private System.Windows.Forms.BindingSource cuahangdonghoDataSet1BindingSource;
        private System.Windows.Forms.BindingSource dONGHOBindingSource1;
        private cuahang_donghoDataSet1 cuahang_donghoDataSet11;
        private System.Windows.Forms.BindingSource dONGHOBindingSource2;
        private System.Windows.Forms.BindingSource fKNHACUNGCCUNGCAPDONGHOBindingSource;
        private System.Windows.Forms.ToolStripButton btnLuu;
    }
}