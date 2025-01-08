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
{
    public partial class frm_Mua : Form
    {
        public bool ReadOnlyMode { get; set; }

        public frm_Mua()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
        }

        SqlConnection Connection;
        string str = @"Data Source=TONG2004;Initial Catalog=cuahang_dongho_new;Integrated Security=True;Encrypt=False";

        //private frm_KhachHang frm_khachhhang; // Khai báo đối tượng form DongHo

       
        //public frm_Mua(frm_KhachHang khachhangForm)
        //{
        //    InitializeComponent();
        //    this.WindowState = FormWindowState.Maximized;

        //    this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
        //    frm_khachhhang = khachhangForm; // Truyền đối tượng form DongHo từ constructor
        //    LoadMaDongHo(); // Tải danh sách mã đồng hồ
        //}

        public void LoadMaDongHo()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MADONGHO FROM DONGHO", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cb_madongho.Items.Clear();
                    while (reader.Read())
                    {
                        cb_madongho.Items.Add(reader["MADONGHO"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }                
            }
        }


        private void cb_madongho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_madongho.SelectedItem != null) // Kiểm tra giá trị không null
    {
                string selectedMaDongHo = cb_madongho.SelectedItem.ToString();
                LoadDonGia(selectedMaDongHo); // Gọi phương thức LoadDonGia
            }
    else
            {
                txtSLM.Text = ""; // Xóa giá trị nếu không có đồng hồ được chọn
            }
        }

        private void LoadDonGia(string maDongHo)
        {
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            string sql = "SELECT GIA FROM DONGHO WHERE MADONGHO = @MADONGHO";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MADONGHO", maDongHo);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) // Nếu tìm thấy giá của mã đồng hồ
                    {
                        txtSLM.Text = reader["GIA"].ToString(); // Hiển thị giá vào TextBox
                    }
                    else
                    {
                        txtSLM.Text = ""; // Nếu không tìm thấy giá, xóa nội dung TextBox
                        MessageBox.Show("Không tìm thấy giá cho mã đồng hồ được chọn.", "Thông báo");
                    }
                }
            }
        }

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

      

        public void LoadMaPhieuBaoHanh()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MAPHIEUBAOHANH FROM PHIEUBAOHANH", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    // Xóa dữ liệu cũ trong ComboBox
                    cb_mapbh.Items.Clear();
                    while (reader.Read())
                    {
                        cb_mapbh.Items.Add(reader["MAPHIEUBAOHANH"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }




        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private SqlCommand commmand;
       public void loaddata()
        {
            // Khởi tạo kết nối
            Connection = new SqlConnection(str);
            Connection.Open();

            // Tạo command và thiết lập câu truy vấn
            commmand = Connection.CreateCommand();
            commmand.CommandText = "select * from MUA"; // Thay bằng câu truy vấn thực tế của bạn
                                                                   // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Nạp dữ liệu vào DataGridView
            dgvmua.DataSource = table;

            dgvmua.Columns["MAPHIEUBAOHANH"].HeaderText = "MÃ PHIẾU BẢO HÀNH";
            dgvmua.Columns["MADONGHO"].HeaderText = "MÃ ĐỒNG HỒ";
            dgvmua.Columns["MAKHACHHANG"].HeaderText = "MÃ KHÁCH HÀNG";
            dgvmua.Columns["NGAYMUA"].HeaderText = "NGÀY MUA";
            dgvmua.Columns["DONGIA"].HeaderText = "ĐƠN GIÁ";
            dgvmua.Columns["GHICHU"].HeaderText = "GHI CHÚ";




            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {
            dateTimeNgayMua.Enabled = true;
            txtGhiChu.ReadOnly = false;
            txtSLM.ReadOnly = true;

            cb_makhachhang.Enabled = true;
            button1.Enabled = true;

            cb_madongho.Enabled = true;
            button2.Enabled = true;

            cb_mapbh.Enabled = true;
            button3.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvmua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvmua.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvmua.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvmua.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvmua.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvmua.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvmua.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvmua.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmua.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvmua.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvmua.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvmua.ReadOnly = true;

            // Đặt border
            dgvmua.BorderStyle = BorderStyle.Fixed3D;
            dgvmua.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvmua.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvmua.AllowUserToResizeColumns = false;
            dgvmua.AllowUserToResizeRows = false;
        }

        private void frm_Mua_Load(object sender, EventArgs e)
        {
            if (ReadOnlyMode)
            {
                // Disable các điều khiển nhập liệu
                txtGhiChu.ReadOnly = true;
                txtSLM.ReadOnly = true;
                dateTimeNgayMua.Enabled = false;

                cb_makhachhang.Enabled = false;
                button1.Enabled = false;

                cb_madongho.Enabled = false;
                button2.Enabled = false;

                cb_mapbh.Enabled = false;
                button3.Enabled = false;

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
            LoadMaDongHo();
            cb_madongho.SelectedIndexChanged += cb_madongho_SelectedIndexChanged; // Liên kết sự kiện
            LoadMaKhachHang();
            LoadMaPhieuBaoHanh();
            txtSLM.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtGhiChu.Text = "";
            this.cb_makhachhang.Text = "";
            this.cb_madongho.Text = "";
            this.cb_mapbh.Text = "";
            this.txtSLM.Text = "";
            this.dateTimeNgayMua.Value = DateTime.Now;


            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madcgh = this.txtSLM.Text;
            // Lấy mã đồng hồ từ ComboBox (hoặc TextBox, tùy vào thiết kế giao diện của bạn)
            string maKH = this.cb_makhachhang.Text;

            if (string.IsNullOrEmpty(madcgh))
            {
                MessageBox.Show("Vui lòng chọn mã địa chi giao hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi có mã khách hàng: {maKH} không?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return; // Người dùng chọn "No", thoát khỏi hàm
            }


            string sql = String.Format("DELETE FROM MUA WHERE DONGIA = @DonGia");
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DonGia", madcgh);

                int kq = cmd.ExecuteNonQuery();
                if (kq != -1)
                {
                    MessageBox.Show(" Da xoa thanh cong! " + madcgh);
                    sql = "select * from MUA"; // Load lại dữ liệu để hiển thị lên form cmd.CommandText= sql;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string soluongmua = txtSLM.Text;
            string maKH = cb_makhachhang.Text;
            string maDH = cb_madongho.Text;
            string maphieubaohanh = cb_mapbh.Text;
            string ghichu = txtGhiChu.Text;
            string ngaymua = dateTimeNgayMua.Text;



            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin mua hàng này không?",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            resetForm();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvmua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string soluongmua = txtSLM.Text;
            string maKH = cb_makhachhang.Text;
            string maDH = cb_madongho.Text;
            string maphieubaohanh = cb_mapbh.Text;
            string ghichu = txtGhiChu.Text;
            string ngaymua = dateTimeNgayMua.Text;

            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE MUA " +
                         "SET MAPHIEUBAOHANH = @MaPhieuBaoHanh ,MADONGHO = @MaDongHo, MAKHACHHANG = @MaKhachHang, NGAYMUA = @NgayMua, GHICHU = @GhiChu " +
                         "WHERE DONGIA = @DonGia";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaPhieuBaoHanh", maphieubaohanh);
                cmd.Parameters.AddWithValue("@MaDongHo", maDH);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKH);
                cmd.Parameters.AddWithValue("@NgayMua", ngaymua);
                cmd.Parameters.AddWithValue("@DonGia", soluongmua);
                cmd.Parameters.AddWithValue("@GhiChu", ghichu);

                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa mua hàng thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy số lượng mua hàng để sửa.", "Lỗi");
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
            dgvmua.Enabled = true;
            btnLuu.Enabled = false;

            txtGhiChu.ReadOnly = true;
            txtSLM.ReadOnly = true;
            dateTimeNgayMua.Enabled = false;

            cb_makhachhang.Enabled = false;
            button1.Enabled = false;

            cb_madongho.Enabled = false;
            button2.Enabled = false;

            cb_mapbh.Enabled = false;
            button3.Enabled = false;
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
            string soluongmua = this.txtSLM.Text.Trim();
            string maKH = this.cb_makhachhang.Text.Trim();
            string maDH = this.cb_madongho.Text.Trim();
            string maphieubaohanh = this.cb_mapbh.Text.Trim();
            string ghichu = this.txtGhiChu.Text.Trim();
            string ngaymua = this.dateTimeNgayMua.Text.Trim();
         
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng hợp lệ.", "Cảnh báo");
                return;
            }

            if (string.IsNullOrEmpty(maDH))
            {
                MessageBox.Show("Vui lòng chọn mã đồng hồ hợp lệ.", "Cảnh báo");
                return;
            }

            if (string.IsNullOrEmpty(maphieubaohanh))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu bảo hành hợp lệ.", "Cảnh báo");
                return;
            }





            if (string.IsNullOrEmpty(maphieubaohanh) || string.IsNullOrEmpty(maDH) ||
            string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(ngaymua) ||
            string.IsNullOrEmpty(soluongmua) || string.IsNullOrEmpty(ghichu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO MUA (MAPHIEUBAOHANH, MADONGHO, MAKHACHHANG, NGAYMUA, DONGIA, GHICHU) " +
                 "VALUES (@MAPHIEUBAOHANH, @MADONGHO, @MAKHACHHANG, @NGAYMUA, @DONGIA, @GHICHU)";
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                // Kiểm tra mã đồng hồ có tồn tại không
                string checkSql = "SELECT COUNT(*) FROM DONGHO WHERE MADONGHO = @MADONGHO";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@MADONGHO", maDH);

                int count = (int)checkCmd.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Mã đồng hồ không hợp lệ. Vui lòng chọn mã đồng hồ hợp lệ hoặc cập nhập mã đồng hồ mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mã khách hàng
                string checkKhachHangSql = "SELECT COUNT(*) FROM KHACHHANG WHERE MAKHACHHANG = @MAKH";
                SqlCommand checkKhachHangCmd = new SqlCommand(checkKhachHangSql, conn);
                checkKhachHangCmd.Parameters.AddWithValue("@MAKH", maKH);
                int khachHangCount = (int)checkKhachHangCmd.ExecuteScalar();
                if (khachHangCount == 0)
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ. Vui lòng chọn mã khách hàng đúng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mã phiếu bảo hành
                string checkPhieuBHSql = "SELECT COUNT(*) FROM PHIEUBAOHANH WHERE MAPHIEUBAOHANH = @MAPHIEUBH";
                SqlCommand checkPhieuBHCmd = new SqlCommand(checkPhieuBHSql, conn);
                checkPhieuBHCmd.Parameters.AddWithValue("@MAPHIEUBH", maphieubaohanh);
                int phieuBHCount = (int)checkPhieuBHCmd.ExecuteScalar();
                if (phieuBHCount == 0)
                {
                    MessageBox.Show("Mã phiếu bảo hành không hợp lệ. Vui lòng chọn mã phiếu bảo hành đúng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAPHIEUBAOHANH", maphieubaohanh);
                cmd.Parameters.AddWithValue("@MADONGHO", maDH);
                cmd.Parameters.AddWithValue("@MAKHACHHANG", maKH);
                cmd.Parameters.AddWithValue("@NGAYMUA", ngaymua);
                cmd.Parameters.AddWithValue("@DONGIA", soluongmua);
                cmd.Parameters.AddWithValue("@GHICHU", ghichu);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mua hàng thành công!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Đơn giá " + soluongmua + " đã có trong CSDL! ");
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormDongHo frm = new FormDongHo();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_PhieuBH frm = new frm_PhieuBH();
            frm.ShowDialog();
        }

        private void dgvmua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvmua.CurrentRow.Index;

            cb_mapbh.Text = dgvmua.Rows[i].Cells[0].Value.ToString();
            cb_madongho.Text = dgvmua.Rows[i].Cells[1].Value.ToString();
            cb_makhachhang.Text = dgvmua.Rows[i].Cells[2].Value.ToString();
            dateTimeNgayMua.Text = dgvmua.Rows[i].Cells[3].Value.ToString();
            txtSLM.Text = dgvmua.Rows[i].Cells[4].Value.ToString().Trim();
            txtGhiChu.Text = dgvmua.Rows[i].Cells[5].Value.ToString().Trim();

            txtGhiChu.ReadOnly = true;
            txtSLM.ReadOnly = true;
            dateTimeNgayMua.Enabled = false;

            cb_madongho.Enabled = false;
            button2.Enabled = false;

            cb_mapbh.Enabled = false;
            button3.Enabled = false;

            cb_makhachhang.Enabled = false;
            button1.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        
    }
}
