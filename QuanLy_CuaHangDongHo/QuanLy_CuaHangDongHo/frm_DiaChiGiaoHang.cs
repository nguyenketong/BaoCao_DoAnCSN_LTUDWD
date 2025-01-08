using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHangDongHo
{    public partial class frm_DiaChiGiaoHang : Form
    {
        public bool ReadOnlyMode { get; set; }

        public frm_DiaChiGiaoHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
        }
        SqlConnection Connection;
        string str = @"Data Source=TONG2004;Initial Catalog=cuahang_dongho_new;Integrated Security=True;Encrypt=False";

        //private frm_KhachHang frm_khachhhang; // Khai báo đối tượng form DongHo
        //public frm_DiaChiGiaoHang(frm_KhachHang khachhangForm)
        //{
        //    InitializeComponent();
        //    this.WindowState = FormWindowState.Maximized;

        //    this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
        //    frm_khachhhang = khachhangForm; // Truyền đối tượng form DongHo từ constructor
        //    LoadMaDongHo(); // Tải danh sách mã đồng hồ
        //}

        public void LoadMaKhachHang()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MAKHACHHANG FROM KHACHHANG", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    // Xóa dữ liệu cũ trong ComboBox
                    cb_makhachhang.Items.Clear();
                    while (reader.Read())
                    {
                        cb_makhachhang.Items.Add(reader["MAKHACHHANG"].ToString()); // Thêm mã điện thoại vào ComboBox
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
            commmand.CommandText = "select * from DIACHIGIAOHANG"; // Thay bằng câu truy vấn thực tế của bạn
                                                             // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Nạp dữ liệu vào DataGridView
            dgvdiachigiaohang.DataSource = table;

            dgvdiachigiaohang.Columns["MADIACHI"].HeaderText = "MÃ ĐỊA CHỈ";
            dgvdiachigiaohang.Columns["MAKHACHHANG"].HeaderText = "MÃ KHÁCH HÀNG";
            dgvdiachigiaohang.Columns["TENTINH"].HeaderText = "TÊN TỈNH";
            dgvdiachigiaohang.Columns["TENHUYEN"].HeaderText = "TÊN HUYỆN";
            dgvdiachigiaohang.Columns["DIACHICUTHE"].HeaderText = "ĐỊA CHỈ CỤ THỂ";



            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {
            txtMaDCGH.ReadOnly = false;
            txtTenTinh.ReadOnly = false;
            txtTenHuyen.ReadOnly = false;         
            txtDCcuthe.ReadOnly = false;

            cb_makhachhang.Enabled = true;
            button1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvdiachigiaohang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvdiachigiaohang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvdiachigiaohang.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvdiachigiaohang.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvdiachigiaohang.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvdiachigiaohang.RowsDefaultCellStyle.BackColor = Color.White;
            dgvdiachigiaohang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvdiachigiaohang.ReadOnly = true;

            // Đặt border
            dgvdiachigiaohang.BorderStyle = BorderStyle.Fixed3D;
            dgvdiachigiaohang.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvdiachigiaohang.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvdiachigiaohang.AllowUserToResizeColumns = false;
            dgvdiachigiaohang.AllowUserToResizeRows = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtMaDCGH.Text = "";
            this.cb_makhachhang.Text = "";
            this.txtTenTinh.Text = "";
            this.txtTenHuyen.Text = "";          
            this.txtDCcuthe.Text = "";

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madcgh = this.txtMaDCGH.Text;
            // Lấy mã đồng hồ từ ComboBox (hoặc TextBox, tùy vào thiết kế giao diện của bạn)
            //string maKH = cb_makhachhang.SelectedValue.ToString();

            if (string.IsNullOrEmpty(madcgh))
            {
                MessageBox.Show("Vui lòng chọn mã địa chi giao hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi có mã khách hàng: {madcgh} không?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return; // Người dùng chọn "No", thoát khỏi hàm
            }


            string sql = String.Format("DELETE FROM DIACHIGIAOHANG WHERE MADIACHI = @MaDiaChi");
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaDiaChi", madcgh);

                int kq = cmd.ExecuteNonQuery();
                if (kq != -1)
                {
                    MessageBox.Show(" Da xoa thanh cong! " + madcgh);
                    sql = "select * from DIACHIGIAOHANG"; // Load lại dữ liệu để hiển thị lên form cmd.CommandText= sql;
                    cmd.CommandText = sql;
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(madcgh + " Khong xoa thanh cong! ");
            }
            finally
            {

                conn.Close();
            }
            loaddata();
        }

        private void frm_DiaChiGiaoHang_Load(object sender, EventArgs e)
        {
            if (ReadOnlyMode)
            {
                // Disable các điều khiển nhập liệu
                txtMaDCGH.ReadOnly = true;
                txtTenTinh.ReadOnly = true;
                txtTenHuyen.ReadOnly = true;
                txtDCcuthe.ReadOnly = true;

                cb_makhachhang.Enabled = false;
                btnCapNhat.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                button1.Enabled = false;
                btnLuu.Enabled = false;
            }
            Connection = new SqlConnection(str);
            Connection.Open();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            loaddata();
            LoadMaKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string madcgh = txtMaDCGH.Text;
            string maKH = cb_makhachhang.Text;
            string tentinh = txtTenTinh.Text;
            string tenhuyen = txtTenHuyen.Text;    
            string dccuthe = txtDCcuthe.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin địa chỉ cụ thể này không?",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            resetForm();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvdiachigiaohang.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string madcgh = txtMaDCGH.Text;
            string maKH = cb_makhachhang.Text;
            string tentinh = txtTenTinh.Text;
            string tenhuyen = txtTenHuyen.Text;
            string dccuthe = txtDCcuthe.Text;

            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE DIACHIGIAOHANG " +
                         "SET MAKHACHHANG = @MaKhachHang ,TENTINH = @TenTinh, TENHUYEN = @TenHuyen, DIACHICUTHE = @DiaChiCuThe " +
                         "WHERE MADIACHI = @MaDiaChi";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaDiaChi", madcgh);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKH);
                cmd.Parameters.AddWithValue("@TenTinh", tentinh);
                cmd.Parameters.AddWithValue("@TenHuyen", tenhuyen);
                cmd.Parameters.AddWithValue("@DiaChiCuThe", dccuthe);             

                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên để sửa.", "Lỗi");
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
            dgvdiachigiaohang.Enabled = true;
            btnLuu.Enabled = false;

            txtMaDCGH.ReadOnly = true;
            txtTenTinh.ReadOnly = true;
            txtTenHuyen.ReadOnly = true;
            txtDCcuthe.ReadOnly = true;

            cb_makhachhang.Enabled = false;
            button1.Enabled = false;
        }

        private void btnThoatChucNang_Click(object sender, EventArgs e)
        {
            // Đóng Form Nhân Viên
            this.Close();

            // Hiển thị lại Form Đồng Hồ
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormDongHo)
                {
                    form.Show();
                    break;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            resetForm();
            string madcgh = this.txtMaDCGH.Text.Trim();
            string maKH = this.cb_makhachhang.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng hợp lệ.", "Cảnh báo");
                return;
            }
            string tentinh = this.txtTenTinh.Text.Trim();
            string tenhuyen = this.txtTenHuyen.Text.Trim();
            string dccuthe = this.txtDCcuthe.Text.Trim();




            if (string.IsNullOrEmpty(madcgh) || string.IsNullOrEmpty(maKH) ||
            string.IsNullOrEmpty(tentinh) || string.IsNullOrEmpty(tenhuyen) ||
            string.IsNullOrEmpty(dccuthe))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO DIACHIGIAOHANG (MADIACHI, MAKHACHHANG, TENTINH, TENHUYEN, DIACHICUTHE) " +
                 "VALUES (@MADIACHI, @MAKHACHHANG, @TENTINH, @TENHUYEN, @DIACHICUTHE)";
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                // Kiểm tra mã khách hàng có tồn tại không
                string checkSql = "SELECT COUNT(*) FROM KHACHHANG WHERE MAKHACHHANG = @MAKHACHHANG";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@MAKHACHHANG", maKH);

                int count = (int)checkCmd.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ. Vui lòng chọn mã khách hàng hợp lệ hoặc cập nhập mã khách hàng mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MADIACHI", madcgh);
                cmd.Parameters.AddWithValue("@MAKHACHHANG", maKH);
                cmd.Parameters.AddWithValue("@TENTINH", tentinh);
                cmd.Parameters.AddWithValue("@TENHUYEN", tenhuyen);
                cmd.Parameters.AddWithValue("@DIACHICUTHE", dccuthe);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Mã nhân viên " + madcgh + " đã có trong CSDL! ");
            }
            finally
            {
                loaddata();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang();
            frm.ShowDialog();
        }

        private void txtMaDCGH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDCGH.Text))
            {
                lblLuuYDCGH.Text = "Mã nhân viên sẽ không thể sửa khi cập nhật!";
                lblLuuYDCGH.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYDCGH.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

        private void dgvdiachigiaohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvdiachigiaohang.CurrentRow.Index;

            txtMaDCGH.Text = dgvdiachigiaohang.Rows[i].Cells[0].Value.ToString();
            cb_makhachhang.Text = dgvdiachigiaohang.Rows[i].Cells[1].Value.ToString();
            txtTenTinh.Text = dgvdiachigiaohang.Rows[i].Cells[2].Value.ToString();
            txtTenHuyen.Text = dgvdiachigiaohang.Rows[i].Cells[3].Value.ToString();
            txtDCcuthe.Text = dgvdiachigiaohang.Rows[i].Cells[4].Value.ToString();

            txtMaDCGH.ReadOnly = true;
            txtTenTinh.ReadOnly = true;
            txtTenHuyen.ReadOnly = true;
            txtDCcuthe.ReadOnly = true;

            cb_makhachhang.Enabled = false;
            button1.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }
    }

}
