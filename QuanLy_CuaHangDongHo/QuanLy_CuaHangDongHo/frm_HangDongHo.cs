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
    public partial class frm_HangDongHo : Form
    {
        public bool ReadOnlyMode { get; set; }
        public frm_HangDongHo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection Connection;
        string str = @"Data Source=TONG2004;Initial Catalog=cuahang_dongho_new;Integrated Security=True;Encrypt=False";


        //public void LoadMaDongHo()
        //{
        //    using (SqlConnection connection = new SqlConnection(str))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand("SELECT MADONGHO FROM DONGHO", connection))
        //        {
        //            SqlDataReader reader = command.ExecuteReader();
        //            cb_madongho.Items.Clear();
        //            while (reader.Read())
        //            {
        //                cb_madongho.Items.Add(reader["MADONGHO"].ToString()); // Thêm mã điện thoại vào ComboBox
        //            }
        //        }
        //    }
        //}
        //private FormDongHo formDongHo; // Khai báo đối tượng form DongHo
        //public frm_HangDongHo(FormDongHo dongHoForm)
        //{
        //    InitializeComponent();
        //    this.WindowState = FormWindowState.Maximized;

        //    this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
        //    formDongHo = dongHoForm; // Truyền đối tượng form DongHo từ constructor
        //    LoadMaDongHo(); // Tải danh sách mã đồng hồ
        //}

        //private void LoadMaDongHo()
        //{
        //    // Lấy danh sách mã đồng hồ từ form DongHo
        //    DataTable dt = formDongHo.GetMaDongHoList();

        //    // Gán dữ liệu vào ComboBox
        //    cb_madongho.DataSource = dt;
        //    cb_madongho.DisplayMember = "MADONGHO"; // Hiển thị mã đồng hồ
        //    cb_madongho.ValueMember = "MADONGHO";   // Giá trị là mã đồng hồ
        //}

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
            commmand.CommandText = "select * from HANGDONGHO"; // Thay bằng câu truy vấn thực tế của bạn
            // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Gắn dữ liệu cho DataGridView
            dgvnhanhieu.DataSource = table;

            // Thiết lập giao diện cho DataGridView
            dgvnhanhieu.Columns["MAHANG"].HeaderText = "MÃ HÀNG";
            //dgvnhanhieu.Columns["MADONGHO"].HeaderText = "MÃ ĐỒNG HỒ";
            dgvnhanhieu.Columns["TENHANG"].HeaderText = "TÊN HÃNG";

            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {
            txtMaHang.ReadOnly = false;
            txtTenHang.ReadOnly = false;

            //cb_madongho.Enabled = true;
            //button1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvnhanhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvnhanhieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvnhanhieu.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvnhanhieu.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvnhanhieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvnhanhieu.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvnhanhieu.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvnhanhieu.RowsDefaultCellStyle.BackColor = Color.White;
            dgvnhanhieu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvnhanhieu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvnhanhieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvnhanhieu.ReadOnly = true;

            // Đặt border
            dgvnhanhieu.BorderStyle = BorderStyle.Fixed3D;
            dgvnhanhieu.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvnhanhieu.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvnhanhieu.AllowUserToResizeColumns = false;
            dgvnhanhieu.AllowUserToResizeRows = false;
        }

        private void frm_HangDongHo_Load(object sender, EventArgs e)
        {
            //if (ReadOnlyMode)
            //{
            //    // Disable các điều khiển nhập liệu
            //    txtMaHang.ReadOnly = true;
            //    txtTenHang.ReadOnly = true;

              
            //    //cb_madongho.Enabled = false;
            //    btnCapNhat.Enabled = false;
            //    btnThem.Enabled = false;
            //    btnSua.Visible = false;
            //    btnXoa.Visible = false;
            //    //button1.Enabled = false;
            //    btnLuu.Enabled = false;

            //}
            Connection = new SqlConnection(str);
            Connection.Open();

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            loaddata();
            //LoadMaDongHo();
        }

        private void btnThoatChucNang_Click(object sender, EventArgs e)
        {
            // Đóng Form 
            this.Close();

            // Hiển thị lại Form 
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormDongHo)
                {
                    form.Show();
                    (form as FormDongHo)?.LoadMaHang();

                    break;
                }
            }
        }

        private void dgvnhanhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           

            int i;

            i = dgvnhanhieu.CurrentRow.Index;

            txtMaHang.Text = dgvnhanhieu.Rows[i].Cells[0].Value.ToString();
            //cb_madongho.Text = dgvnhanhieu.Rows[i].Cells[1].Value.ToString();
            txtTenHang.Text = dgvnhanhieu.Rows[i].Cells[1].Value.ToString();

            txtMaHang.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            //cb_madongho.Enabled = false;
            button1.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDongHo frm = new FormDongHo();
            frm.ReadOnlyMode = true;
            // Hiển thị thông báo nhắc nhở người dùng
            MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm.ShowDialog();
        }

            private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                lblLuuYMaHang.Text = "Mã hãng đồng hồ sẽ không thể sửa khi cập nhật!";
                lblLuuYMaHang.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYMaHang.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtMaHang.Text = "";
            //this.cb_madongho.Text = "";
            this.txtTenHang.Text = "";         

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã đồng hồ từ ComboBox (hoặc TextBox, tùy vào thiết kế giao diện của bạn)
            //string maDongHo = cb_madongho.SelectedValue.ToString();
            string manhang = this.txtMaHang.Text;
            XoaHang(manhang);
            //// Hiển thị hộp thoại xác nhận
            //DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi có mã đồng hồ: {manhang} không?",
            //                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result != DialogResult.Yes)
            //{
            //    return; // Người dùng chọn "No", thoát khỏi hàm
            //}

            //string sql = String.Format("DELETE FROM HANGDONGHO WHERE MAHANG = @MaHang");
            //string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            //SqlConnection conn = new SqlConnection(connString);
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@MaHang", manhang);

            //    int kq = cmd.ExecuteNonQuery();
            //    if (kq != -1)
            //    {
            //        MessageBox.Show(" Da xoa thanh cong! " + manhang);
            //        sql = "select * from HANGDONGHO"; // Load lại dữ liệu để hiển thị lên form cmd.CommandText= sql;
            //        cmd.CommandText = sql;
            //        SqlDataReader reader = cmd.ExecuteReader();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(manhang + " Khong xoa thanh cong! ");
            //}
            //finally
            //{

            //    conn.Close();
            //}
            //loaddata();
        }

        private void XoaHang(string manhang)
        {
            // Kiểm tra mã đồng hồ có rỗng hay không
            if (string.IsNullOrEmpty(manhang))
            {
                MessageBox.Show("Vui lòng nhập mã hãng đồng hồ để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa hãng đồng hồ với mã: {manhang} không? \nLưu ý: Khi xóa Hãng đồng hồ này sẽ bị xóa khỏi tất cả các form và dữ liệu liên quan trong hệ thống.", "Xác nhận xóa",
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

                    // 1. Xóa các bản ghi trong bảng MUA trước
                    string sqlDeleteMua = @"
                    DELETE FROM MUA 
                    WHERE MADONGHO IN (SELECT MADONGHO FROM DONGHO WHERE MAHANG = @MaHang)";
                    using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, conn))
                    {
                        cmdDeleteMua.Parameters.AddWithValue("@MaHang", manhang);
                        cmdDeleteMua.ExecuteNonQuery();
                    }

                    // 2. Xóa các bản ghi trong bảng con (DONGHO) trước
                    string sqlDeleteDongHo = "DELETE FROM DONGHO WHERE MAHANG = @MaHang";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteDongHo, conn))
                    {
                        cmdDeleteChild.Parameters.AddWithValue("@MaHang", manhang);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 3. Xóa bản ghi trong bảng cha (NHANVIEN) sau cùng
                    string sqlDeleteParent = "DELETE FROM HANGDONGHO WHERE MAHANG = @MaHang";
                    using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
                    {
                        cmdDeleteParent.Parameters.AddWithValue("@MaHang", manhang);
                        int rowsAffected = cmdDeleteParent.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa hãng đồng hồ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã hãng đồng hồ để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string manhang = this.txtMaHang.Text;
            //string madongho = this.cb_madongho.Text;
            string tenhang = this.txtTenHang.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nhà cung cấp này không?",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            resetForm();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvnhanhieu.Enabled = false;
            btnLuu.Enabled = true;
        }
            private void btnLuu_Click(object sender, EventArgs e)
        {
            string manhang = this.txtMaHang.Text;
            //string madongho = this.cb_madongho.Text;
            string tenhang = this.txtTenHang.Text;
            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE HANGDONGHO " +
                         "SET/* MADONGHO = @MaDongHo,*/ TENHANG = @TenHang " +
                         "WHERE MAHANG = @MaHang";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHang", manhang);
                //cmd.Parameters.AddWithValue("@MaDongHo", madongho);
                cmd.Parameters.AddWithValue("@TenHang", tenhang);       

                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa hãng đồng hồ thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hãng đồng hồ để sửa.", "Lỗi");
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
            dgvnhanhieu.Enabled = true;
            btnLuu.Enabled = false;

            txtMaHang.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            //cb_madongho.Enabled = false;
            //button1.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            resetForm();
            string manhang = this.txtMaHang.Text.Trim();
            //string madongho = this.cb_madongho.Text.Trim();
            //if (string.IsNullOrEmpty(madongho))
            //{
            //    MessageBox.Show("Vui lòng chọn mã đồng hồ hợp lệ.", "Cảnh báo");
            //    return;
            //}
            string tenhang = this.txtTenHang.Text.Trim();

            if (string.IsNullOrEmpty(manhang) ||
               //string.IsNullOrEmpty(madongho) ||
               string.IsNullOrEmpty(tenhang))
               
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO HANGDONGHO (MAHANG,/* MADONGHO,*/ TENHANG) " +
                 "VALUES (@MAHANG,/* @MADONGHO,*/ @TENHANG)";
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                // Kiểm tra mã đồng hồ có tồn tại không
                string checkSql = "SELECT COUNT(*) FROM DONGHO WHERE MADONGHO = @MADONGHO";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                //checkCmd.Parameters.AddWithValue("@MADONGHO", madongho);

                //int count = (int)checkCmd.ExecuteScalar();
                //if (count == 0)
                //{
                //    MessageBox.Show("Mã đồng hồ không hợp lệ. Vui lòng chọn mã đồng hồ hợp lệ hoặc cập nhập mã đồng hồ mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAHANG", manhang);
                //cmd.Parameters.AddWithValue("@MADONGHO", madongho);
                cmd.Parameters.AddWithValue("@TENHANG", tenhang);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm vào hãng đồng thành công!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Mã hãng đồng hồ " + manhang + " đã có trong CSDL! ");
            }
            finally
            {
                loaddata();
                conn.Close();
            }
        }

        private void cb_madongho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
