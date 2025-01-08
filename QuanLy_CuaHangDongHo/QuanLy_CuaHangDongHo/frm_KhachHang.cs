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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
        }
        public DataTable GetMaKhachHangList()
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string sql = "SELECT MAKHACHHANG FROM KHACHHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        SqlConnection Connection;
        string str = @"Data Source=TONG2004;Initial Catalog=cuahang_dongho_new;Integrated Security=True;Encrypt=False";
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
            commmand.CommandText = "select * from KHACHHANG"; // Thay bằng câu truy vấn thực tế của bạn
                                                             // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Nạp dữ liệu vào DataGridView
            dgvkhachhang.DataSource = table;

            dgvkhachhang.Columns["MAKHACHHANG"].HeaderText = "MÃ KHÁCH HÀNG";
            dgvkhachhang.Columns["HOKH"].HeaderText = "HỌ KHÁCH HÀNG";
            dgvkhachhang.Columns["TENKH"].HeaderText = "TÊN KHÁCH HÀNG";
            dgvkhachhang.Columns["GIOITINHKH"].HeaderText = "GIỚI TÍNH";
            dgvkhachhang.Columns["CMND"].HeaderText = "CMND/CCCD";
            dgvkhachhang.Columns["DIACHIKH"].HeaderText = "ĐỊA CHỈ";
            dgvkhachhang.Columns["SDTKH"].HeaderText = "SDT KHÁCH HÀNG";
            dgvkhachhang.Columns["EMAILKH"].HeaderText = "EMAIL KHÁCH HÀNG";
            dgvkhachhang.Columns["NGAYSINHKH"].HeaderText = "NGÀY SINH";

            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {
            txtMaKH.ReadOnly = false;
            txtHoKH.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            cbGtKH.Enabled = true;
            dateTimeNgaySinh.Enabled = true;
            txtCMND.ReadOnly = false;
            txtDCKH.ReadOnly = false;
            txtSdtKH.ReadOnly = false;
            txtEmailKH.ReadOnly = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvkhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvkhachhang.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvkhachhang.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvkhachhang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvkhachhang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvkhachhang.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvkhachhang.RowsDefaultCellStyle.BackColor = Color.White;
            dgvkhachhang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvkhachhang.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvkhachhang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvkhachhang.ReadOnly = true;

            // Đặt border
            dgvkhachhang.BorderStyle = BorderStyle.Fixed3D;
            dgvkhachhang.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvkhachhang.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvkhachhang.AllowUserToResizeColumns = false;
            dgvkhachhang.AllowUserToResizeRows = false;
        }


        private void panelInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtMaKH.Text = "";
            this.txtHoKH.Text = "";
            this.txtTenKH.Text = "";
            this.cbGtKH.Text = "Chọn giới tính";
            this.txtCMND.Text = "";
            this.txtSdtKH.Text = "0";
            this.txtDCKH.Text = "";
            this.txtEmailKH.Text = "";
            this.dateTimeNgaySinh.Value = DateTime.Now;


            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = this.txtMaKH.Text.Trim();
            XoaKhachHang(manv);

            //if (string.IsNullOrEmpty(manv))
            //{
            //    MessageBox.Show("Vui lòng chọn mã nhà khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Hiển thị hộp thoại xác nhận
            //DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng với mã: {manv} không?", "Xác nhận xóa",
            //MessageBoxButtons.YesNo,
            //MessageBoxIcon.Question);

            //// Nếu người dùng chọn "No", thì thoát khỏi hàm
            //if (result != DialogResult.Yes)
            //{
            //    return;
            //}

            //string sql = String.Format("DELETE FROM KHACHHANG WHERE KHACHHANG = @KHACHHANG");
            //string connString = "server=TONG2004; database=cuahang_dongho; Integrated Security=SSPI;";
            //SqlConnection conn = new SqlConnection(connString);
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@KHACHHANG", manv);

            //    int kq = cmd.ExecuteNonQuery();
            //    if (kq != -1)
            //    {
            //        MessageBox.Show(" Da xoa thanh cong! " + manv);
            //        sql = "select * from KHACHHANG"; // Load lại dữ liệu để hiển thị lên form cmd.CommandText= sql;
            //        cmd.CommandText = sql;
            //        SqlDataReader reader = cmd.ExecuteReader();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(manv + " Khong xoa thanh cong! ");
            //}
            //finally
            //{

            //    conn.Close();
            //}
            //loaddata();
        }


        private void XoaKhachHang(string manv)
        {
            // Kiểm tra mã đồng hồ có rỗng hay không
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng với mã: {manv} không? \nLưu ý: Khi xóa, Khách hàng này sẽ bị xóa khỏi tất cả các form và dữ liệu liên quan trong hệ thống.", "Xác nhận xóa",
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

                    // 1. Xóa các bản ghi trong bảng con (DIACHIGIAOHANG) trước
                    string sqlDeleteChild = "DELETE FROM DIACHIGIAOHANG WHERE MAKHACHHANG = @MaKhachHang";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteChild, conn))
                    {
                        cmdDeleteChild.Parameters.AddWithValue("@MaKhachHang", manv);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 2. Xóa các bản ghi trong bảng con (MUA) trước
                    string sqlDeleteMua = "DELETE FROM MUA WHERE MAKHACHHANG = @MaKhachHang";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteMua, conn))
                    {
                        cmdDeleteChild.Parameters.AddWithValue("@MaKhachHang", manv);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 3. Xóa bản ghi trong bảng cha (KHACHHANG) sau cùng
                    string sqlDeleteParent = "DELETE FROM KHACHHANG WHERE MAKHACHHANG = @MaKhachHang";
                    using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
                    {
                        cmdDeleteParent.Parameters.AddWithValue("@MaKhachHang", manv);
                        int rowsAffected = cmdDeleteParent.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã khách hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string manv = txtMaKH.Text;
            string hokh = txtHoKH.Text;
            string tenkh = txtTenKH.Text;
            string gioitinhkh = cbGtKH.Text;
            string ngaysinhkh = dateTimeNgaySinh.Text;
            string cmndkh = txtCMND.Text;
            string diachikh = txtDCKH.Text;
            string sdtkh = txtSdtKH.Text;
            string emailkh = txtEmailKH.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nhà khách hàng này không?",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            resetForm();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvkhachhang.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string hokh = txtHoKH.Text;
            string tenkh = txtTenKH.Text;
            string gioitinhkh = cbGtKH.Text;
            string ngaysinhkh = dateTimeNgaySinh.Text;
            string cmndkh = txtCMND.Text;
            string diachikh = txtDCKH.Text;
            string sdtkh = txtSdtKH.Text;
            string emailkh = txtEmailKH.Text;
            if (!emailkh.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi");
                return;
            }

            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=True; Encrypt=False;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE KHACHHANG " +
                         "SET MAKHACHHANG = @MaKhachHang, HOKH = @HoKH, TENKH = @TenKH, GIOITINHKH = @GioiTinhKH, CMND = @CmndKH, " +
                         "DIACHIKH = @DiaChiKH, SDTKH = @SdtKH, EMAILKH = @EmailKH, NGAYSINHKH = @NgaySinhKH " +
                         "WHERE MAKHACHHANG = @MaKhachHang";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaKhachHang", makh);
                cmd.Parameters.AddWithValue("@HoKH", hokh);
                cmd.Parameters.AddWithValue("@TenKH", tenkh);
                cmd.Parameters.AddWithValue("@GioiTinhKH", ngaysinhkh);
                cmd.Parameters.AddWithValue("@CmndKH", cmndkh);
                cmd.Parameters.AddWithValue("@DiaChiKH", diachikh);
                cmd.Parameters.AddWithValue("@SdtKH", sdtkh);
                cmd.Parameters.AddWithValue("@EmailKH", emailkh);
                cmd.Parameters.AddWithValue("@NgaySinhKH", DateTime.Parse(ngaysinhkh));


                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa khách hàng thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng để sửa.", "Lỗi");
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
            dgvkhachhang.Enabled = true;
            btnLuu.Enabled = false;

            txtMaKH.ReadOnly = true;
            txtHoKH.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            cbGtKH.Enabled = false;
            dateTimeNgaySinh.Enabled = false;
            txtCMND.ReadOnly = true;
            txtDCKH.ReadOnly = true;
            txtSdtKH.ReadOnly = true;
            txtEmailKH.ReadOnly = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            resetForm();
            string makh = this.txtMaKH.Text.Trim();
            string hokh = this.txtHoKH.Text.Trim();
            string tenkh = this.txtTenKH.Text.Trim();
            string gioitinhkh = this.cbGtKH.Text.Trim();
            string cmndkh = this.txtCMND.Text.Trim();
            string diachikh = this.txtDCKH.Text.Trim();
            string sdtkh = this.txtSdtKH.Text.Trim();
            string emailkh = this.txtEmailKH.Text.Trim();
            string ngaysinhkh = this.dateTimeNgaySinh.Value.ToString("yyyy-MM-dd"); ;

            if (string.IsNullOrEmpty(makh) || string.IsNullOrEmpty(hokh) ||
            string.IsNullOrEmpty(tenkh) || string.IsNullOrEmpty(gioitinhkh) ||
            string.IsNullOrEmpty(cmndkh) || string.IsNullOrEmpty(diachikh) ||
            string.IsNullOrEmpty(sdtkh) || string.IsNullOrEmpty(emailkh) || string.IsNullOrEmpty(ngaysinhkh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO KHACHHANG (MAKHACHHANG, HOKH, TENKH, GIOITINHKH, CMND, DIACHIKH, SDTKH, EMAILKH, NGAYSINHKH) " +
                "VALUES (@MAKHACHHANG, @HOKH, @TENKH, @GIOITINHKH, @CMND, @DIACHIKH, @SDTKH, @EMAILKH, @NGAYSINHKH)";
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAKHACHHANG", makh);
                cmd.Parameters.AddWithValue("@HOKH", hokh);
                cmd.Parameters.AddWithValue("@TENKH", tenkh);
                cmd.Parameters.AddWithValue("@GIOITINHKH", gioitinhkh);
                cmd.Parameters.AddWithValue("@CMND", cmndkh);
                cmd.Parameters.AddWithValue("@DIACHIKH", diachikh);
                cmd.Parameters.AddWithValue("@SDTKH", sdtkh);
                cmd.Parameters.AddWithValue("@EMAILKH", emailkh);
                cmd.Parameters.AddWithValue("@NGAYSINHKH", Convert.ToDateTime(ngaysinhkh));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Mã khách hàng " + makh + " đã có trong CSDL! ");
            }
            finally
            {
                loaddata();
                conn.Close();
            }
        }

        private void btnThoatChucNang_Click(object sender, EventArgs e)
        {
            // Đóng Form Nhân Viên
            this.Close();

            // Hiển thị lại Form Đồng Hồ
            foreach (Form form in Application.OpenForms)
            {
                if (form is frm_Mua)
                {
                    form.Show();

                    // Gọi phương thức để load lại dữ liệu (nếu có)
                    (form as frm_Mua)?.LoadMaKhachHang();
                    break;
                }
                if (form is frm_DiaChiGiaoHang)
                {
                    form.Show();

                    // Gọi phương thức để load lại dữ liệu (nếu có)
                    (form as frm_DiaChiGiaoHang)?.LoadMaKhachHang();
                    break;
                }
            }
        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvkhachhang.CurrentRow.Index;

            txtMaKH.Text = dgvkhachhang.Rows[i].Cells[0].Value.ToString();
            txtHoKH.Text = dgvkhachhang.Rows[i].Cells[1].Value.ToString();
            txtTenKH.Text = dgvkhachhang.Rows[i].Cells[2].Value.ToString();
            cbGtKH.Text = dgvkhachhang.Rows[i].Cells[3].Value.ToString();
            txtCMND.Text = dgvkhachhang.Rows[i].Cells[4].Value.ToString().Trim();
            txtDCKH.Text = dgvkhachhang.Rows[i].Cells[5].Value.ToString();
            txtSdtKH.Text = dgvkhachhang.Rows[i].Cells[6].Value.ToString();
            txtEmailKH.Text = dgvkhachhang.Rows[i].Cells[7].Value.ToString();
            dateTimeNgaySinh.Text = dgvkhachhang.Rows[i].Cells[8].Value.ToString();

            txtMaKH.ReadOnly = true;
            txtHoKH.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            cbGtKH.Enabled = false;
            dateTimeNgaySinh.Enabled = false;
            txtCMND.ReadOnly = true;
            txtDCKH.ReadOnly = true;
            txtSdtKH.ReadOnly = true;
            txtEmailKH.ReadOnly = true;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                lblLuuYMaKH.Text = "Mã khách hàng sẽ không thể sửa khi cập nhật!!";
                lblLuuYMaKH.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYMaKH.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_DiaChiGiaoHang frm = new frm_DiaChiGiaoHang();
            frm.ReadOnlyMode = true;
            // Hiển thị thông báo nhắc nhở người dùng
            MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Mua frm = new frm_Mua();
            frm.ReadOnlyMode = true;
            // Hiển thị thông báo nhắc nhở người dùng
            MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm.ShowDialog();
        }
    }
}
