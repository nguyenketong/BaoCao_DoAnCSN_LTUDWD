using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHangDongHo
{
    public partial class frm_NhaCungCap : Form
    {
        public bool ReadOnlyMode { get; set; }

        public frm_NhaCungCap()
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
        //public frm_NhaCungCap(FormDongHo dongHoForm)
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
            commmand.CommandText = "select * from NHACUNGCAP"; // Thay bằng câu truy vấn thực tế của bạn
            // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Gắn dữ liệu cho DataGridView
            dgvnhacungcap.DataSource = table;

            // Thiết lập giao diện cho DataGridView
            dgvnhacungcap.Columns["MANHACUNGCAP"].HeaderText = "MÃ NHÀ CUNG CẤP";
            //dgvnhacungcap.Columns["MADONGHO"].HeaderText = "MÃ ĐỒNG HỒ";
            dgvnhacungcap.Columns["TENNCC"].HeaderText = "TÊN NHÀ CUNG CẤP";
            dgvnhacungcap.Columns["DIACHINCC"].HeaderText = "ĐỊA CHỈ NHÀ CUNG CẤP";
            dgvnhacungcap.Columns["EMAILNCC"].HeaderText = "EMAIL NHÀ CUNG CẤP";
            dgvnhacungcap.Columns["SDTNCC"].HeaderText = "SDT NHÀ CUNG CẤP";


            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {            
            txtMaNCC.ReadOnly = false;
            txtTenNCC.ReadOnly = false;
            txtDCncc.ReadOnly = false;
            txtEMncc.ReadOnly = false;
            txtSDTncc.ReadOnly = false;

            //cb_madongho.Enabled = true;
            //button1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvnhacungcap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvnhacungcap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvnhacungcap.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvnhacungcap.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvnhacungcap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvnhacungcap.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvnhacungcap.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvnhacungcap.RowsDefaultCellStyle.BackColor = Color.White;
            dgvnhacungcap.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvnhacungcap.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvnhacungcap.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvnhacungcap.ReadOnly = true;

            // Đặt border
            dgvnhacungcap.BorderStyle = BorderStyle.Fixed3D;
            dgvnhacungcap.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvnhacungcap.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvnhacungcap.AllowUserToResizeColumns = false;
            dgvnhacungcap.AllowUserToResizeRows = false;
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
           
            //if (ReadOnlyMode)
            //{
            //    // Disable các điều khiển nhập liệu
            //    txtMaNCC.ReadOnly = true;
            //    txtTenNCC.ReadOnly = true;
            //    txtDCncc.ReadOnly = true;
            //    txtEMncc.ReadOnly = true;
            //    txtSDTncc.ReadOnly = true;

            //    //cb_madongho.Enabled = false;
            //    btnCapNhat.Enabled = false;
            //    btnThem.Enabled = false;
            //    btnSua.Visible = false;
            //    btnXoa.Visible = false;
            //    button1.Enabled = false;
            //    btnLuu.Enabled = false;
                
            //}
            Connection = new SqlConnection(str);
            Connection.Open();

            btnLuu.Enabled=false;
            btnSua.Enabled=false;
            btnXoa.Enabled=false;
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
                    (form as FormDongHo)?.LoadMaNCC();

                    break;
                }
            }
        }

        private void dgvnhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvnhacungcap.CurrentRow.Index;

            txtMaNCC.Text = dgvnhacungcap.Rows[i].Cells[0].Value.ToString();
            //cb_madongho.Text = dgvnhacungcap.Rows[i].Cells[1].Value.ToString();
            txtTenNCC.Text = dgvnhacungcap.Rows[i].Cells[1].Value.ToString();
            txtDCncc.Text = dgvnhacungcap.Rows[i].Cells[2].Value.ToString().Trim();
            txtEMncc.Text = dgvnhacungcap.Rows[i].Cells[3].Value.ToString();
            txtSDTncc.Text = dgvnhacungcap.Rows[i].Cells[4].Value.ToString();

            txtMaNCC.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDCncc.ReadOnly = true;
            txtEMncc.ReadOnly = true;
            txtSDTncc.ReadOnly = true;
            //cb_madongho.Enabled = false;
            //button1.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtMaNCC.Text = "";
            //this.cb_madongho.Text = "";
            this.txtTenNCC.Text = "";
            this.txtDCncc.Text = "";
            this.txtEMncc.Text = "";
            this.txtSDTncc.Text = "";

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã đồng hồ từ ComboBox (hoặc TextBox, tùy vào thiết kế giao diện của bạn)
            //string maDongHo = cb_madongho.SelectedValue.ToString();

            string mancc = this.txtMaNCC.Text.Trim();
            XoaNhaCungCap(mancc);
            //// Hiển thị hộp thoại xác nhận
            //DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi có mã đồng hồ: {mancc} không?",
            //                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result != DialogResult.Yes)
            //{
            //    return; // Người dùng chọn "No", thoát khỏi hàm
            //}

            //string sql = String.Format("DELETE FROM NHACUNGCAP WHERE MANHACUNGCAP = @MaNhaCungCap");
            //string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            //SqlConnection conn = new SqlConnection(connString);
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@MaNhaCungCap", mancc);

            //    int kq = cmd.ExecuteNonQuery();
            //    if (kq != -1)
            //    {
            //        MessageBox.Show(" Da xoa thanh cong! " + mancc);
            //        sql = "select * from NHACUNGCAP"; // Load lại dữ liệu để hiển thị lên form cmd.CommandText= sql;
            //        cmd.CommandText = sql;
            //        SqlDataReader reader = cmd.ExecuteReader();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(mancc + " Khong xoa thanh cong! ");
            //}
            //finally
            //{

            //    conn.Close();
            //}
            //loaddata();         
        }

        private void XoaNhaCungCap(string mancc)
        {
            // Kiểm tra mã đồng hồ có rỗng hay không
            if (string.IsNullOrEmpty(mancc))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà cung cấp với mã: {mancc} không? \nLưu ý: Khi xóa, Nhà cung cấp này sẽ bị xóa khỏi tất cả các form và dữ liệu liên quan trong hệ thống.", "Xác nhận xóa",
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
                    WHERE MADONGHO IN (SELECT MADONGHO FROM DONGHO WHERE MANHACUNGCAP = @MaNhaCungCap)";
                    using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, conn))
                    {
                        cmdDeleteMua.Parameters.AddWithValue("@MaNhaCungCap", mancc);
                        cmdDeleteMua.ExecuteNonQuery();
                    }

                    // 2. Xóa các bản ghi trong bảng con (DONGHO) trước
                    string sqlDeleteDongHo = "DELETE FROM DONGHO WHERE MANHACUNGCAP = @MaNhaCungCap";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteDongHo, conn))
                    {
                        cmdDeleteChild.Parameters.AddWithValue("@MaNhaCungCap", mancc);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 3. Xóa bản ghi trong bảng cha (NHACUNGCAP) sau cùng
                    string sqlDeleteParent = "DELETE FROM NHACUNGCAP WHERE MANHACUNGCAP = @MaNhaCungCap";
                    using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
                    {
                        cmdDeleteParent.Parameters.AddWithValue("@MaNhaCungCap", mancc);
                        int rowsAffected = cmdDeleteParent.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã nhà cung cấp để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDongHo frm = new FormDongHo();
            frm.ReadOnlyMode = true;
            // Hiển thị thông báo nhắc nhở người dùng
            MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            resetForm();
            string manhacc = this.txtMaNCC.Text.Trim();
            //string madongho = this.cb_madongho.Text.Trim();
            //if (string.IsNullOrEmpty(madongho))
            //{
            //    MessageBox.Show("Vui lòng chọn mã đồng hồ hợp lệ.", "Cảnh báo");
            //    return;
            //}
            string tennhacc = this.txtTenNCC.Text.Trim();
            string dcncc = this.txtDCncc.Text.Trim();
            string emailncc = this.txtEMncc.Text.Trim();
            if (!emailncc.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi");
                return;
            }
            string sdtncc = this.txtSDTncc.Text.Trim();



            if (string.IsNullOrEmpty(manhacc) ||
                //string.IsNullOrEmpty(madongho) ||
                string.IsNullOrEmpty(tennhacc) ||
                string.IsNullOrEmpty(dcncc) ||
                string.IsNullOrEmpty(emailncc) ||
                string.IsNullOrEmpty(sdtncc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO NHACUNGCAP (MANHACUNGCAP,/* MADONGHO,*/ TENNCC, DIACHINCC, EMAILNCC, SDTNCC) " +
                 "VALUES (@MANHACUNGCAP,/* @MADONGHO,*/ @TENNCC, @DIACHINCC, @EMAILNCC, @SDTNCC)";
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                //// Kiểm tra mã đồng hồ có tồn tại không
                //string checkSql = "SELECT COUNT(*) FROM DONGHO WHERE MADONGHO = @MADONGHO";
                //SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                //checkCmd.Parameters.AddWithValue("@MADONGHO", madongho);

                //int count = (int)checkCmd.ExecuteScalar();
                //if (count == 0)
                //{
                //    MessageBox.Show("Mã đồng hồ không hợp lệ. Vui lòng chọn mã đồng hồ hợp lệ hoặc cập nhập mã đồng hồ mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANHACUNGCAP", manhacc);
                //cmd.Parameters.AddWithValue("@MADONGHO", madongho);
                cmd.Parameters.AddWithValue("@TENNCC", tennhacc);
                cmd.Parameters.AddWithValue("@DIACHINCC", dcncc);
                cmd.Parameters.AddWithValue("@EMAILNCC", emailncc);
                cmd.Parameters.AddWithValue("@SDTNCC", sdtncc);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm vào nhà cung cấp thành công!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Mã nhà cung cấp " + manhacc + " đã có trong CSDL! ");
            }
            finally
            {
                loaddata();
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            // Lấy dữ liệu từ các điều khiển
            string manhacc = txtMaNCC.Text;
            //string madongho = cb_madongho.Text;
            string tennhacc = txtTenNCC.Text;
            string dcncc = txtDCncc.Text;
            string emailncc = txtEMncc.Text;
            string sdtncc = txtSDTncc.Text;

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
            dgvnhacungcap.Enabled = false;
            btnLuu.Enabled = true;
        }
            private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string manhacc = txtMaNCC.Text;
            //string madongho = cb_madongho.Text;
            string tennhacc = txtTenNCC.Text;
            string dcncc = txtDCncc.Text;
            string emailncc = txtEMncc.Text;
            string sdtncc = txtSDTncc.Text;

            if (!emailncc.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi");
                return;
            }
            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE NHACUNGCAP " +
                         "SET /*MADONGHO = @MaDongHo, */TENNCC = @TenNCC, DIACHINCC = @DiachiNCC, " +
                         "EMAILNCC = @EmailNCC, SDTNCC = @SdtNCC " +
                         "WHERE MANHACUNGCAP = @MaNhaCungCap";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhaCungCap", manhacc);
                //cmd.Parameters.AddWithValue("@MaDongHo", madongho);
                cmd.Parameters.AddWithValue("@TenNCC", tennhacc);
                cmd.Parameters.AddWithValue("@DiachiNCC", dcncc);
                cmd.Parameters.AddWithValue("@EmailNCC", emailncc);
                cmd.Parameters.AddWithValue("@SdtNCC", sdtncc);

                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhà cung cấp để sửa.", "Lỗi");
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
            dgvnhacungcap.Enabled = true;
            btnLuu.Enabled = false;

            txtMaNCC.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDCncc.ReadOnly = true;
            txtEMncc.ReadOnly = true;
            txtSDTncc.ReadOnly = true;
            //cb_madongho.Enabled = false;
            //button1.Enabled = false;

        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                lblLuuYMaNCC.Text = "Mã nhà cung cấp sẽ không thể sửa khi cập nhật!";
                lblLuuYMaNCC.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYMaNCC.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

        private void cb_madongho_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
