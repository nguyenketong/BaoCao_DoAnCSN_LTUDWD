using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHangDongHo
{
    public partial class FormDongHo : Form
    {
        public bool ReadOnlyMode { get; set; }

        private int btnThucThi = -1;
        private const int BTN_QLNHANVIEN = 2;
        private const int CHUCNANG_THEM = 0;
        private const int CHUCNANG_SUA = 1;
        private int chucNangThucThi;

        private int position;
        private string hinhAnh;
        public FormDongHo()
        {

            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
           
        }

        SqlConnection Connection;
        string str = @"Data Source=TONG2004;Initial Catalog=cuahang_dongho_new;Integrated Security=True;Encrypt=False";


        public void LoadMaNhanVien()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MANHANVIEN FROM NHANVIEN", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cb_manhanvien.Items.Clear();
                    while (reader.Read())
                    {
                        cb_manhanvien.Items.Add(reader["MANHANVIEN"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }

        public void LoadMaCauHinh()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MACAUHINH FROM THONGSOKITHUAT", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cb_mach.Items.Clear();
                    while (reader.Read())
                    {
                        cb_mach.Items.Add(reader["MACAUHINH"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }

        public void LoadMaNCC()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MANHACUNGCAP FROM NHACUNGCAP", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cb_mancc.Items.Clear();
                    while (reader.Read())
                    {
                        cb_mancc.Items.Add(reader["MANHACUNGCAP"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }

        public void LoadMaHang()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MAHANG FROM HANGDONGHO", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cb_mahang.Items.Clear();
                    while (reader.Read())
                    {
                        cb_mahang.Items.Add(reader["MAHANG"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private SqlCommand commmand;
        void loaddata()
        {
            // Khởi tạo kết nối
            Connection = new SqlConnection(str);
            Connection.Open();

            // Tạo command và thiết lập câu truy vấn
            commmand = Connection.CreateCommand();
            commmand.CommandText = "select * from DONGHO"; // Thay bằng câu truy vấn thực tế của bạn
                                                              // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Gắn dữ liệu cho DataGridView
            dgvdongho.DataSource = table;

            // Thiết lập giao diện cho DataGridView
            dgvdongho.Columns["MADONGHO"].HeaderText = "MÃ ĐỒNG HỒ";
            dgvdongho.Columns["MAHANG"].HeaderText = "MÃ HÃNG";
            dgvdongho.Columns["MANHANVIEN"].HeaderText = "MÃ NHÂN VIÊN";
            dgvdongho.Columns["MACAUHINH"].HeaderText = "MÃ CẤU HÌNH";
            dgvdongho.Columns["MANHACUNGCAP"].HeaderText = "MÃ NHÀ CUNG CẤP";
            dgvdongho.Columns["TENDONGHO"].HeaderText = "TÊN ĐỒNG HỒ";
            dgvdongho.Columns["GIA"].HeaderText = "GIÁ";
            dgvdongho.Columns["SOLUONG"].HeaderText = "SỐ LƯỢNG";
            dgvdongho.Columns["MOTA"].HeaderText = "MÔ TẢ";
            dgvdongho.Columns["HINHANH"].HeaderText = "HÌNH ẢNH";
            dgvdongho.Columns["LOAIDONGHO"].HeaderText = "LOẠI ĐỒNG HỒ";
            dgvdongho.Columns["TRANGTHAI"].HeaderText = "TRẠNG THÁI";


            SetupDataGridViewFullScreen();
        }

        public DataTable GetMaDongHoList()
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string sql = "SELECT MADONGHO FROM DONGHO";          
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void resetForm()
        {
            cb_mahang.Enabled = true;
            cb_mach.Enabled = true;
            cb_mancc.Enabled = true;
            cb_manhanvien.Enabled = true;
            btnQLNhanVien.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            txtMaDongHo.ReadOnly = false;
            txtTenDongHo.ReadOnly = false;
            txtGia.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtMoTa.ReadOnly = false;
            txtLoai.ReadOnly = false;
            cbTrangThai.Enabled = true;
            pictureBoxHinhAnh.Enabled = true;

            button1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

       


        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvdongho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvdongho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvdongho.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvdongho.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvdongho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvdongho.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvdongho.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvdongho.RowsDefaultCellStyle.BackColor = Color.White;
            dgvdongho.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvdongho.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvdongho.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvdongho.ReadOnly = true;

            // Đặt border
            dgvdongho.BorderStyle = BorderStyle.Fixed3D;
            dgvdongho.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvdongho.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvdongho.AllowUserToResizeColumns = false;
            dgvdongho.AllowUserToResizeRows = false;
        }



        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            if (ReadOnlyMode)
            {
                // Disable các điều khiển nhập liệu
                txtMaDongHo.ReadOnly = true;
                cb_mahang.Enabled = false;
                cb_mach.Enabled = false;
                cb_manhanvien.Enabled = false;
                cb_mancc.Enabled = false;
                txtTenDongHo.ReadOnly = true;
                txtGia.ReadOnly = true;
                txtSoLuong.ReadOnly = true;
                txtLoai.ReadOnly = true;
                cbTrangThai.Enabled = false;
                txtMoTa.ReadOnly = true;


                btnCapNhat.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btnQLNhanVien.Enabled = false;
                btnLuu.Enabled = false;
            }


            Connection = new SqlConnection(str);
            Connection.Open();

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LoadMaNhanVien();
            LoadMaCauHinh();
            LoadMaNCC();
            LoadMaHang();
            loaddata();
        }

        public void hienthiReader(SqlDataReader reader)
        {
            //while (reader.Read())
            //{
            //    this.txtMaDongHo.Text = reader["MADONGHO"].ToString();
            //    this.txtTenDongHo.Text = reader["TENDONGHO"].ToString();
            //    this.comboBoxLoai.Text = reader["LOAIDONGHO"].ToString();
            //    this.txtGia.Text = reader["GIA"].ToString();
            //    this.comboBoxTrangThai.Text = reader["TRANGTHAI"].ToString();
            //    this.txtMoTa.Text = reader["MOTA"].ToString();
            //    this.txtSoLuong.Text = reader["SOLUONG"].ToString();

            //    string hinhAnh = reader["HINHANH"].ToString();
            //    if (!string.IsNullOrEmpty(hinhAnh) && System.IO.File.Exists(hinhAnh))
            //    {
            //        this.pictureBoxHinhAnh.Image = Image.FromFile(hinhAnh);
            //    }
            //    else
            //    {
            //        this.pictureBoxHinhAnh.Image = null; // Nếu không có ảnh, để trống
            //    }
            //}
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtMaDongHo.Text = "";
            this.txtTenDongHo.Text = "";
            this.txtGia.Text = "";
            this.txtSoLuong.Text = "";
            this.txtMoTa.Text = "";
            this.cb_manhanvien.Text = "";
            this.cb_mancc.Text = "";
            this.cb_mahang.Text = "";
            this.cb_mach.Text = "";
            this.pictureBoxHinhAnh.Controls.Clear();
            if (pictureBoxHinhAnh.Image != null)
            {
                string defaultImagePath = @"C:\Users\KE TONG\Downloads\Mau BAOCAODOAN\QuanLy_CuaHangDongHo\QuanLy_CuaHangDongHo\Icon\init_image.png"; // Đường dẫn ảnh mặc định
                if (File.Exists(defaultImagePath)) // Kiểm tra xem ảnh có tồn tại không
                {
                    pictureBoxHinhAnh.Image = Image.FromFile(defaultImagePath);
                }
                else
                {
                    MessageBox.Show("Ảnh mặc định không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            this.txtLoai.Text = "";
            this.cbTrangThai.Text = "";

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        //private void EnableButton()
        //{
        //    Color enableColor = Color.FromArgb(3, 169, 244); // Màu khi nút được bật
        //    switch (btnThucThi)
        //    {
        //        case BTN_QLNHANVIEN:
        //            btnQLNhanVien.Enabled = true;
        //            btnQLNhanVien.BackColor = enableColor;
        //            break;
        //    }
        //}

        //private void MoFormCon(Form formCon)
        //{
        //    if (!panelContainer.Controls.Contains(formCon))
        //    {
        //        formCon.TopLevel = false;
        //        panelContainer.Controls.Clear();
        //        panelContainer.Controls.Add(formCon);
        //        formCon.Show();
        //    }
        //}



        //private void DisableButton()
        //{
        //    Color disableColor = Color.FromArgb(1, 87, 155);
        //    switch (btnThucThi)
        //    {
        //        case BTN_QLNHANVIEN:
        //            btnQLNhanVien.BackColor = disableColor;
        //            break;

        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            //// Hiển thị thông báo nhắc nhở người dùng
            //MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm.ShowDialog();
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ThongSoKiThuat frm = new frm_ThongSoKiThuat();
            //frm.ReadOnlyMode = true;
            //// Hiển thị thông báo nhắc nhở người dùng
            //MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            frm_NhaCungCap frm = new frm_NhaCungCap();
            //frm.ReadOnlyMode = true;
            //// Hiển thị thông báo nhắc nhở người dùng
            //MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm.ShowDialog();
        }

        private void pictureBoxHinhAnh_Click_1(object sender, EventArgs e)
        {
            if(openFileDialogChonAnh.ShowDialog() == DialogResult.OK)
        {
                string fullPath = openFileDialogChonAnh.FileName;

                // Giải phóng ảnh cũ trước khi gán ảnh mới
                if (pictureBoxHinhAnh.Image != null)
                {
                    pictureBoxHinhAnh.Image.Dispose();
                }

                // Gán ảnh mới
                pictureBoxHinhAnh.Image = Image.FromFile(fullPath);

                // Cập nhật đường dẫn để lưu vào cơ sở dữ liệu dưới dạng tương đối
                string projectPath = AppDomain.CurrentDomain.BaseDirectory; // Lấy thư mục gốc của ứng dụng
                string relativePath = fullPath.Replace(projectPath, ""); // Lưu đường dẫn tương đối
                hinhAnh = relativePath;
            }

            // Tắt chức năng chọn ảnh
            pictureBoxHinhAnh.Tag = "Disabled";

            // Mở lại chức năng chọn ảnh
            pictureBoxHinhAnh.Tag = "Enabled";
        }

        private void dONGHOGridControl_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvdongho_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số dòng hợp lệ
            {
                // Lấy dòng hiện tại từ DataGridView
                DataGridViewRow selectedRow = dgvdongho.Rows[e.RowIndex];

                // Gán giá trị từ các cột của dòng được chọn vào các điều khiển
                txtMaDongHo.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                cb_mahang.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                cb_manhanvien.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                cb_mach.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                cb_mancc.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                txtTenDongHo.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                txtGia.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                txtSoLuong.Text = selectedRow.Cells[7].Value?.ToString() ?? string.Empty;
                txtMoTa.Text = selectedRow.Cells[8].Value?.ToString() ?? string.Empty;
                string folderPath = @"C:\Users\KE TONG\Downloads\Mau BAOCAODOAN\QuanLy_CuaHangDongHo\QuanLy_CuaHangDongHo\Image\";
                string imagePath = selectedRow.Cells[9].Value?.ToString() ?? string.Empty;

                // Kiểm tra và hiển thị hình ảnh lên PictureBox
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBoxHinhAnh.ImageLocation = imagePath;
                }
                else
                {
                    MessageBox.Show(
                        $"Không tìm thấy hình ảnh tại đường dẫn: {imagePath}",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    pictureBoxHinhAnh.Image = null; // Xóa ảnh hiện tại nếu không tìm thấy
                }
                txtLoai.Text = selectedRow.Cells[10].Value?.ToString() ?? string.Empty;
                cbTrangThai.Text = selectedRow.Cells[11].Value?.ToString() ?? string.Empty;
            }

            txtMaDongHo.ReadOnly = true;
            txtTenDongHo.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            pictureBoxHinhAnh.Enabled = false;
            
            cb_mahang.Enabled = false;
            cb_mach.Enabled = false;
            cb_mancc.Enabled = false;
            cb_manhanvien.Enabled = false;
            btnQLNhanVien.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            txtLoai.ReadOnly = true;
            cbTrangThai.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnThoatChucNang_Click(object sender, EventArgs e)
        {
            // Đóng Form 
            this.Close();

            // Hiển thị lại Form 
            foreach (Form form in Application.OpenForms)
            {
                if (form is frm_Mua)
                {
                    form.Show();
                    (form as frm_Mua)?.LoadMaDongHo();
                    break;
                }

                //if (form is frm_NhanVien)
                //{
                //    form.Show();
                //    (form as frm_NhanVien)?.LoadMaDongHo();
                //    break;
                //}

                //if (form is frm_ThongSoKiThuat)
                //{
                //    form.Show();
                //    (form as frm_ThongSoKiThuat)?.LoadMaDongHo();
                //    break;
                //}

                //if (form is frm_NhaCungCap)
                //{
                //    form.Show();
                //    (form as frm_NhaCungCap)?.LoadMaDongHo();
                //    break;
                //}


                //if (form is frm_HangDongHo)
                //{
                //    form.Show();
                //    (form as frm_HangDongHo)?.LoadMaDongHo();
                //    break;
                //}
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_HangDongHo frm = new frm_HangDongHo();
            //frm.ReadOnlyMode = true;
            //// Hiển thị thông báo nhắc nhở người dùng
            //MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madongho = txtMaDongHo.Text;
            string mahang = cb_mahang.Text;
            string manv =cb_manhanvien.Text;
            string mach = cb_mach.Text;
            string mancc = cb_mancc.Text;
            string tendongho = txtTenDongHo.Text;
            string gia = txtGia.Text;
            string soluong = txtSoLuong.Text;
            string mota = txtMoTa.Text;
            string hinhanh = pictureBoxHinhAnh.Text;
            string loai = txtLoai.Text;
            string trangthai = cbTrangThai.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin đồng hồ này không?",
                                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            resetForm();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvdongho.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string madongho = txtMaDongHo.Text;
            string mahang = cb_mahang.Text;
            string manv = cb_manhanvien.Text;
            string mach = cb_mach.Text;
            string mancc = cb_mancc.Text;
            string tendongho = txtTenDongHo.Text;
            string gia = txtGia.Text;
            string soluong = txtSoLuong.Text;
            string mota = txtMoTa.Text;
            string hinhanh = string.IsNullOrEmpty(hinhAnh) ? "default.jpg" : hinhAnh; // Gán ảnh mặc định nếu không có ảnh
            string loai = txtLoai.Text;
            string trangthai = cbTrangThai.Text;

            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE DONGHO " +
                         "SET MAHANG = @MaHang, MANHANVIEN = @MaNhanVien, MACAUHINH = @MaCauHinh, MANHACUNGCAP = @MaNhaCungCap, TENDONGHO = @TenDongHo, GIA = @Gia, SOLUONG = @SoLuong,  MOTA = @MoTa, HINHANH = @HinhAnh, LOAIDONGHO = @Loai, TRANGTHAI = @TrangThai " +
                         "WHERE MADONGHO = @MaDongHo";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDongHo", madongho);
                cmd.Parameters.AddWithValue("@MaHang", mahang);
                cmd.Parameters.AddWithValue("@MaNhanVien", manv);
                cmd.Parameters.AddWithValue("@MaCauHinh", mach);
                cmd.Parameters.AddWithValue("@MaNhaCungCap", mancc);
                cmd.Parameters.AddWithValue("@TenDongHo", tendongho);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@SoLuong", soluong);
                cmd.Parameters.AddWithValue("@MoTa", mota);
                cmd.Parameters.AddWithValue("@HinhAnh", hinhanh);
                cmd.Parameters.AddWithValue("@Loai", loai);
                cmd.Parameters.AddWithValue("@TrangThai", trangthai);

                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa đồng hồ thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã đồng hồ để sửa.", "Lỗi");
                }

                // Cập nhật lại dữ liệu trên DataGridView (nếu cần)
                loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi");
            }
            finally
            {
                conn.Close();
            }
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvdongho.Enabled = true;
            btnLuu.Enabled = false;


            txtMaDongHo.ReadOnly = true;
            txtTenDongHo.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            pictureBoxHinhAnh.Enabled = true;
            txtLoai.ReadOnly = true;
            cbTrangThai.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDongHo = this.txtMaDongHo.Text.Trim();
            XoaDongHo(maDongHo);

            //// Kiểm tra mã đồng hồ có rỗng hay không
            //if (string.IsNullOrEmpty(madongho))
            //{
            //    MessageBox.Show("Vui lòng nhập mã đồng hồ để xóa.");
            //    return;
            //}

            //// Hiển thị hộp thoại xác nhận
            //DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đồng hồ với mã: {madongho} không?", "Xác nhận xóa",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);

            //if (result != DialogResult.Yes)
            //{
            //    return; // Thoát nếu người dùng chọn "No"
            //}

            //// Chuỗi kết nối và câu lệnh SQL
            //string connString = "server=TONG2004; database=cuahang_dongho; Integrated Security=SSPI;";
            //string sql = "DELETE FROM DONGHO WHERE MADONGHO = @MADONGHO";

            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //    try
            //    {
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand(sql, conn);
            //        cmd.Parameters.AddWithValue("@MADONGHO", madongho);

            //        int kq = cmd.ExecuteNonQuery(); // Thực thi lệnh xóa

            //        if (kq > 0) // Kiểm tra số bản ghi bị ảnh hưởng
            //        {
            //            MessageBox.Show($"Đã xóa thành công đồng hồ với mã: {madongho}");
            //            loaddata(); // Gọi phương thức tải lại dữ liệu
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Không tìm thấy đồng hồ với mã: {madongho}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Không thể xóa đồng hồ với mã: {madongho}. Lỗi: {ex.Message}");
            //    }
            //}
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //resetForm();
            string madongho = txtMaDongHo.Text.Trim();
            string mahang = cb_mahang.Text.Trim();
            string manv = cb_manhanvien.Text.Trim();
            string mach = cb_mach.Text.Trim();
            string mancc = cb_mancc.Text.Trim();
            string tendongho = txtTenDongHo.Text.Trim();
            string gia = txtGia.Text.Trim();
            string soluong = txtSoLuong.Text.Trim();
            string mota = txtMoTa.Text.Trim();
            string hinhanh = hinhAnh;
            string loai = txtLoai.Text.Trim();
            string trangthai = cbTrangThai.Text.Trim();



            if (string.IsNullOrEmpty(madongho) ||
                string.IsNullOrEmpty(tendongho) ||
                string.IsNullOrEmpty(gia) ||
                string.IsNullOrEmpty(soluong) ||
                string.IsNullOrEmpty(mota) ||
                string.IsNullOrEmpty(hinhanh) ||
                string.IsNullOrEmpty(loai) ||
                string.IsNullOrEmpty(trangthai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Chuỗi kết nối
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            string sql = "INSERT INTO DONGHO (MADONGHO, MAHANG, MANHANVIEN, MACAUHINH, MANHACUNGCAP, TENDONGHO, GIA, SOLUONG, MOTA, HINHANH, LOAIDONGHO, TRANGTHAI) " +
                         "VALUES (@MADONGHO, @MAHANG, @MANHANVIEN, @MACAUHINH, @MANHACUNGCAP, @TENDONGHO, @GIA, @SOLUONG, @MOTA, @HINHANH, @LOAIDONGHO, @TRANGTHAI)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra mã nhân viên có tồn tại không
                    string checkSql = "SELECT COUNT(*) FROM NHANVIEN WHERE MANHANVIEN = @MANHANVIEN";
                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@MANHANVIEN", manv);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Mã nhân viên không hợp lệ. Vui lòng chọn mã nhân viên hợp lệ hoặc cập nhập mã nhân viên mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra mã cấu hình
                    string checkKhachHangSql = "SELECT COUNT(*) FROM THONGSOKITHUAT WHERE MACAUHINH = @MACAUHINH";
                    SqlCommand checkKhachHangCmd = new SqlCommand(checkKhachHangSql, conn);
                    checkKhachHangCmd.Parameters.AddWithValue("@MACAUHINH", mach);
                    int khachHangCount = (int)checkKhachHangCmd.ExecuteScalar();
                    if (khachHangCount == 0)
                    {
                        MessageBox.Show("Mã cấu hình không hợp lệ. Vui lòng chọn mã cấu hình hợp lệ hoặc cập nhập mã cấu hình mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra mã nhà cung cấp
                    string checkPhieuBHSql = "SELECT COUNT(*) FROM NHACUNGCAP WHERE MANHACUNGCAP = @MANHACUNGCAP";
                    SqlCommand checkPhieuBHCmd = new SqlCommand(checkPhieuBHSql, conn);
                    checkPhieuBHCmd.Parameters.AddWithValue("@MANHACUNGCAP", mancc);
                    int phieuBHCount = (int)checkPhieuBHCmd.ExecuteScalar();
                    if (phieuBHCount == 0)
                    {
                        MessageBox.Show("Mã nhà cung cấp không hợp lệ. Vui lòng chọn mã nhà cung cấp hợp lệ hoặc cập nhập mã nhà cung cấp mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    // Kiểm tra mã hang
                    string checkHangDHSql = "SELECT COUNT(*) FROM HANGDONGHO WHERE MAHANG = @MAHANG";
                    SqlCommand checkHangDHCmd = new SqlCommand(checkHangDHSql, conn);
                    checkHangDHCmd.Parameters.AddWithValue("@MAHANG", mahang);
                    int HangDHCount = (int)checkHangDHCmd.ExecuteScalar();
                    if (HangDHCount == 0)
                    {
                        MessageBox.Show("Mã hãng đồng hồ không hợp lệ. Vui lòng chọn mã hãng đồng hồ hợp lệ hoặc cập nhập mã hãng đồng hồ mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Gán giá trị cho các tham số
                    cmd.Parameters.AddWithValue("@MADONGHO", madongho);
                    cmd.Parameters.AddWithValue("@MAHANG", mahang);
                    cmd.Parameters.AddWithValue("@MANHANVIEN", manv);
                    cmd.Parameters.AddWithValue("@MACAUHINH", mach);
                    cmd.Parameters.AddWithValue("@MANHACUNGCAP", mancc);
                    cmd.Parameters.AddWithValue("@TENDONGHO", tendongho);
                    cmd.Parameters.AddWithValue("@GIA", gia);
                    cmd.Parameters.AddWithValue("@SOLUONG", soluong);
                    cmd.Parameters.AddWithValue("@MOTA", mota);
                    cmd.Parameters.AddWithValue("@HINHANH", hinhanh);
                    cmd.Parameters.AddWithValue("@LOAIDONGHO", loai);
                    cmd.Parameters.AddWithValue("@TRANGTHAI", trangthai);
                    // Thực thi câu lệnh SQL
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm đồng hồ thành công!");

                    // Gọi phương thức tải lại dữ liệu
                    loaddata();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Mã đồng hồ " + madongho + " đã có trong CSDL! ");
                }
                finally
                {

                    conn.Close();
                }
            }
        }

        private void txtMaDongHo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDongHo.Text))
            {
                lblLuuYMaDH.Text = "Mã đồng hồ sẽ không thể sửa khi cập nhật!";
                lblLuuYMaDH.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYMaDH.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

        private void XoaDongHo(string maDongHo)
        {
            // Kiểm tra mã đồng hồ có rỗng hay không
            if (string.IsNullOrEmpty(maDongHo))
            {
                MessageBox.Show("Vui lòng nhập mã đồng hồ để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng với mã: {maDongHo} không? \nLưu ý: Khi xóa, Đồng hồ này sẽ bị xóa khỏi tất cả các form và dữ liệu liên quan trong hệ thống.", "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return; // Thoát nếu người dùng chọn "No"
            }
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=True; Encrypt=False;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    //// 1. Xóa các bản ghi trong bảng con (HANGDONGHO) trước
                    //string sqlDeleteChild = "DELETE FROM HANGDONGHO WHERE MADONGHO = @MaDongHo";
                    //using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteChild, conn))
                    //{
                    //    cmdDeleteChild.Parameters.AddWithValue("@MaDongHo", maDongHo);
                    //    cmdDeleteChild.ExecuteNonQuery();
                    //}

                    //// 2. Xóa các bản ghi trong bảng con (NHANVIEN) trước
                    //string sqlDeleteNhanVien = "DELETE FROM NHANVIEN WHERE MADONGHO = @MaDongHo";
                    //using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteNhanVien, conn))
                    //{
                    //    cmdDeleteChild.Parameters.AddWithValue("@MaDongHo", maDongHo);
                    //    cmdDeleteChild.ExecuteNonQuery();
                    //}

                    //// 3. Xóa các bản ghi trong bảng con (THONGSOKITHUAT) trước
                    //string sqlDeleteThongSoKiThuat = "DELETE FROM THONGSOKITHUAT WHERE MADONGHO = @MaDongHo";
                    //using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteThongSoKiThuat, conn))
                    //{
                    //    cmdDeleteChild.Parameters.AddWithValue("@MaDongHo", maDongHo);
                    //    cmdDeleteChild.ExecuteNonQuery();
                    //}

                    //// 4. Xóa các bản ghi trong bảng con (NHACUNGCAP) trước
                    //string sqlDeleteNhaCungCap = "DELETE FROM NHACUNGCAP WHERE MADONGHO = @MaDongHo";
                    //using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteNhaCungCap, conn))
                    //{
                    //    cmdDeleteChild.Parameters.AddWithValue("@MaDongHo", maDongHo);
                    //    cmdDeleteChild.ExecuteNonQuery();
                    //}

                    // 5. Xóa các bản ghi trong bảng con (MUA) trước
                    string sqlDeleteMua = "DELETE FROM MUA WHERE MADONGHO = @MaDongHo";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteMua, conn))
                    { 
                        cmdDeleteChild.Parameters.AddWithValue("@MaDongHo", maDongHo);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 6. Xóa bản ghi trong bảng cha (DONGHO) sau cùng
                    string sqlDeleteParent = "DELETE FROM DONGHO WHERE MADONGHO = @MaDongHo";
                    using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
                    {
                        cmdDeleteParent.Parameters.AddWithValue("@MaDongHo", maDongHo);
                        int rowsAffected = cmdDeleteParent.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa đồng hồ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã đồng hồ để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialogChonAnh_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dONGHOBindingSource11_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource9_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource5_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cuahangdonghoDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource10_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource8_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLuuYMaDH_Click(object sender, EventArgs e)
        {

        }

        private void txtLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDongHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource6_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource7_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cuahangdonghoDataSet1BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource12_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource13_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource14_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource15_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dONGHOBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    
}
