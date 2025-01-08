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
    public partial class frm_ThongSoKiThuat : Form
    {
        //public bool ReadOnlyMode { get; set; }

        public frm_ThongSoKiThuat()
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

        //public frm_ThongSoKiThuat(FormDongHo dongHoForm)
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
            commmand.CommandText = "select * from THONGSOKITHUAT"; // Thay bằng câu truy vấn thực tế của bạn
            // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Gắn dữ liệu cho DataGridView
            dgvcauhinh.DataSource = table;

            // Thiết lập giao diện cho DataGridView
            dgvcauhinh.Columns["MACAUHINH"].HeaderText = "MÃ CẤU HÌNH";
            //dgvcauhinh.Columns["MADONGHO"].HeaderText = "MÃ ĐỒNG HỒ";
            dgvcauhinh.Columns["KICHTHUOC"].HeaderText = "KÍCH THƯỚC";
            dgvcauhinh.Columns["TRONGLUONG"].HeaderText = "TRỌNG LƯỢNG";
            dgvcauhinh.Columns["XUATXU"].HeaderText = "XUẤT XỨ";
            dgvcauhinh.Columns["CHATLIEUVO"].HeaderText = "CHẤT LIỆU VỎ";
            dgvcauhinh.Columns["CHATLIEUDAYDEO"].HeaderText = "CHẤT LIỆU DÂY ĐEO";
            dgvcauhinh.Columns["CHATLIEUMATKINH"].HeaderText = "CHẤT LIỆU MẶT KÍNH";
            dgvcauhinh.Columns["KHANANGCHONGNUOC"].HeaderText = "KHẢ NĂNG CHỐNG NƯỚC";
            dgvcauhinh.Columns["TUOITHOPIN"].HeaderText = "TUỔI THỌ PIN";


            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {
            txtMaCH.ReadOnly = false;
            txtKichThuoc.ReadOnly = false;
            txtTrongLuong.ReadOnly = false;
            txtXuatXu.ReadOnly = false;
            txtCLvo.ReadOnly = false;
            txtCLdaydeo.ReadOnly = false;
            txtClmatkinh.ReadOnly = false;
            txtKNchongnuoc.ReadOnly = false;
            txtTthoPIN.ReadOnly = false;

            //cb_madongho.Enabled = true;
            //button1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvcauhinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvcauhinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvcauhinh.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvcauhinh.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvcauhinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvcauhinh.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvcauhinh.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvcauhinh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvcauhinh.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvcauhinh.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvcauhinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvcauhinh.ReadOnly = true;

            // Đặt border
            dgvcauhinh.BorderStyle = BorderStyle.Fixed3D;
            dgvcauhinh.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvcauhinh.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvcauhinh.AllowUserToResizeColumns = false;
            dgvcauhinh.AllowUserToResizeRows = false;
        }



        private void dgvcauhinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvcauhinh.CurrentRow.Index;

            txtMaCH.Text = dgvcauhinh.Rows[i].Cells[0].Value.ToString();
            //cb_madongho.Text = dgvcauhinh.Rows[i].Cells[1].Value.ToString();
            txtKichThuoc.Text = dgvcauhinh.Rows[i].Cells[1].Value.ToString();
            txtTrongLuong.Text = dgvcauhinh.Rows[i].Cells[2].Value.ToString();
            txtXuatXu.Text = dgvcauhinh.Rows[i].Cells[3].Value.ToString().Trim();
            txtCLvo.Text = dgvcauhinh.Rows[i].Cells[4].Value.ToString();
            txtCLdaydeo.Text = dgvcauhinh.Rows[i].Cells[5].Value.ToString();
            txtClmatkinh.Text = dgvcauhinh.Rows[i].Cells[6].Value.ToString();
            txtKNchongnuoc.Text = dgvcauhinh.Rows[i].Cells[7].Value.ToString();
            txtTthoPIN.Text = dgvcauhinh.Rows[i].Cells[8].Value.ToString();

            txtMaCH.ReadOnly = true;
            txtKichThuoc.ReadOnly = true;
            txtTrongLuong.ReadOnly = true;
            txtXuatXu.ReadOnly = true;
            txtCLvo.ReadOnly = true;
            txtCLdaydeo.ReadOnly = true;
            txtClmatkinh.ReadOnly = true;
            txtKNchongnuoc.ReadOnly = true;
            txtTthoPIN.ReadOnly = true;
            //cb_madongho.Enabled = false;
            //button1.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void frm_ThongSoKiThuat_Load(object sender, EventArgs e)
        {
            //if (ReadOnlyMode)
            //{
            //    // Disable các điều khiển nhập liệu
            //    txtMaCH.ReadOnly = true;
            //    txtKichThuoc.ReadOnly = true;
            //    txtTrongLuong.ReadOnly = true;
            //    txtXuatXu.ReadOnly = true;
            //    txtCLvo.ReadOnly = true;
            //    txtCLdaydeo.ReadOnly = true;
            //    txtClmatkinh.ReadOnly = true;
            //    txtKNchongnuoc.ReadOnly = true;
            //    txtTthoPIN.ReadOnly = true;

            //    cb_madongho.Enabled = false;
            //    btnCapNhat.Enabled = false;
            //    btnThem.Enabled = false;
            //    btnSua.Visible = false;
            //    btnXoa.Visible = false;
            //    button1.Enabled = false;
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
            // Đóng Form Nhân Viên
            this.Close();

            // Hiển thị lại Form Đồng Hồ
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormDongHo)
                {
                    form.Show();
                    (form as FormDongHo)?.LoadMaCauHinh();

                    break;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã đồng hồ từ ComboBox (hoặc TextBox, tùy vào thiết kế giao diện của bạn)
            //string maDongHo = cb_madongho.SelectedValue.ToString();

            string mach = this.txtMaCH.Text.Trim();
            XoaCauHinh(mach);
            //if (string.IsNullOrEmpty(mach))
            //{
            //    MessageBox.Show("Vui lòng chọn mã nhà cấu hình để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Hiển thị hộp thoại xác nhận
            //DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi có mã thông số kĩ thuật: {mach} không?",
            //                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result != DialogResult.Yes)
            //{
            //    return; // Người dùng chọn "No", thoát khỏi hàm
            //}

            //string sql = String.Format("DELETE FROM THONGSOKITHUAT WHERE MACAUHINH = @MaCauHinh");
            //string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            //SqlConnection conn = new SqlConnection(connString);
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@MaCauHinh", mach);

            //    int kq = cmd.ExecuteNonQuery();
            //    if (kq != -1)
            //    {
            //        MessageBox.Show(" Da xoa thanh cong! " + mach);
            //        sql = "select * from THONGSOKITHUAT"; // Load lại dữ liệu để hiển thị lên form cmd.CommandText= sql;
            //        cmd.CommandText = sql;
            //        SqlDataReader reader = cmd.ExecuteReader();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(mach + " Khong xoa thanh cong! ");
            //}
            //finally
            //{

            //    conn.Close();
            //}
            //loaddata();
            
        }

        private void XoaCauHinh(string mach)
        {
            // Kiểm tra mã đồng hồ có rỗng hay không
            if (string.IsNullOrEmpty(mach))
            {
                MessageBox.Show("Vui lòng nhập mã cấu hình để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa cấu hình với mã: {mach} không? \nLưu ý: Khi xóa, Cấu hình sẽ bị xóa khỏi tất cả các form và dữ liệu liên quan trong hệ thống.", "Xác nhận xóa",
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
                    WHERE MADONGHO IN (SELECT MADONGHO FROM DONGHO WHERE MACAUHINH = @MaCauHinh)";
                    using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, conn))
                    {
                        cmdDeleteMua.Parameters.AddWithValue("@MaCauHinh", mach);
                        cmdDeleteMua.ExecuteNonQuery();
                    }

                    // 2. Xóa các bản ghi trong bảng con (DONGHO) trước
                    string sqlDeleteDongHo = "DELETE FROM DONGHO WHERE MACAUHINH = @MaCauHinh";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteDongHo, conn))
                    {
                        cmdDeleteChild.Parameters.AddWithValue("@MaCauHinh", mach);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 3. Xóa bản ghi trong bảng cha (THONGSOKITHUAT) sau cùng
                    string sqlDeleteParent = "DELETE FROM THONGSOKITHUAT WHERE MACAUHINH = @MaCauHinh";
                    using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
                    {
                        cmdDeleteParent.Parameters.AddWithValue("@MaCauHinh", mach);
                        int rowsAffected = cmdDeleteParent.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã cấu hình để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();

            //Làm mới các hộp hội thoại
            this.txtMaCH.Text = "";
            //this.cb_madongho.Text = "";
            this.txtKichThuoc.Text = "";
            this.txtTrongLuong.Text = "";
            this.txtXuatXu.Text = "";
            this.txtCLvo.Text = "";
            this.txtCLdaydeo.Text = "";
            this.txtClmatkinh.Text = "";
            this.txtKNchongnuoc.Text = "";
            this.txtTthoPIN.Text = "";

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            resetForm();
            string macauhinh = this.txtMaCH.Text.Trim();
            //string madongho = this.cb_madongho.Text.Trim();
            //if (string.IsNullOrEmpty(madongho))
            //{
            //    MessageBox.Show("Vui lòng chọn mã đồng hồ hợp lệ.", "Cảnh báo");
            //    return;
            //}
            string kichthuoc = this.txtKichThuoc.Text.Trim();
            string trongluong = this.txtTrongLuong.Text.Trim();
            string xuatxu = this.txtXuatXu.Text.Trim();
            string CLvo = this.txtCLvo.Text.Trim();
            string CLdaydeo = this.txtCLdaydeo.Text.Trim();
            string Clmatkinh = this.txtClmatkinh.Text.Trim();
            string KNchongnuoc = this.txtKNchongnuoc.Text.Trim();
            string tuoithopin = this.txtTthoPIN.Text.Trim();


            if ((string.IsNullOrEmpty(macauhinh) ||
                //string.IsNullOrEmpty(madongho) ||
                string.IsNullOrEmpty(kichthuoc) ||
                string.IsNullOrEmpty(trongluong) ||
                string.IsNullOrEmpty(xuatxu) ||
                string.IsNullOrEmpty(CLvo)) ||
                string.IsNullOrEmpty(CLdaydeo) ||
                string.IsNullOrEmpty(Clmatkinh) ||
                string.IsNullOrEmpty(Clmatkinh) ||
                string.IsNullOrEmpty(KNchongnuoc) ||
                string.IsNullOrEmpty(tuoithopin))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO THONGSOKITHUAT (MACAUHINH,/* MADONGHO,*/ KICHTHUOC, TRONGLUONG, XUATXU, CHATLIEUVO, CHATLIEUDAYDEO, CHATLIEUMATKINH, KHANANGCHONGNUOC ,TUOITHOPIN) " +
                 "VALUES (@MACAUHINH/*, @MADONGHO*/, @KICHTHUOC, @TRONGLUONG, @XUATXU, @CHATLIEUVO, @CHATLIEUDAYDEO, @CHATLIEUMATKINH, @KHANANGCHONGNUOC, @TUOITHOPIN)";
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
                cmd.Parameters.AddWithValue("@MACAUHINH", macauhinh);
                //cmd.Parameters.AddWithValue("@MADONGHO", madongho);
                cmd.Parameters.AddWithValue("@KICHTHUOC", kichthuoc);
                cmd.Parameters.AddWithValue("@TRONGLUONG", trongluong);
                cmd.Parameters.AddWithValue("@XUATXU", xuatxu);
                cmd.Parameters.AddWithValue("@CHATLIEUVO", CLvo);
                cmd.Parameters.AddWithValue("@CHATLIEUDAYDEO", CLdaydeo);
                cmd.Parameters.AddWithValue("@CHATLIEUMATKINH", Clmatkinh);
                cmd.Parameters.AddWithValue("@KHANANGCHONGNUOC", KNchongnuoc);
                cmd.Parameters.AddWithValue("@TUOITHOPIN", tuoithopin);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông số kĩ thuật thành công!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Mã cấu hình " + macauhinh + " đã có trong CSDL! ");
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
            string macauhinh = txtMaCH.Text;
            //string madongho = cb_madongho.Text;
            string kichthuoc = txtKichThuoc.Text;
            string trongluong = txtTrongLuong.Text;
            string xuatxu = txtXuatXu.Text;
            string CLvo = txtCLvo.Text;
            string CLdaydeo = txtCLdaydeo.Text;
            string Clmatkinh = txtClmatkinh.Text;
            string KNchongnuoc = txtKNchongnuoc.Text;
            string tuoithopin = txtTthoPIN.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin thông số kĩ thuật này không?",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            resetForm();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvcauhinh.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string macauhinh = txtMaCH.Text;
            //string madongho = cb_madongho.Text;
            string kichthuoc = txtKichThuoc.Text;
            string trongluong = txtTrongLuong.Text;
            string xuatxu = txtXuatXu.Text;
            string CLvo = txtCLvo.Text;
            string CLdaydeo = txtCLdaydeo.Text;
            string Clmatkinh = txtClmatkinh.Text;
            string KNchongnuoc = txtKNchongnuoc.Text;
            string tuoithopin = txtTthoPIN.Text;

            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE THONGSOKITHUAT " +
                         "SET /*MADONGHO = @MaDongHo, */KICHTHUOC = @KichThuoc, TRONGLUONG = @TrongLuong, XUATXU = @XuatXu, " +
                         "CHATLIEUVO = @ChatlieuVo, CHATLIEUDAYDEO = @ChatleiudayDeo, CHATLIEUMATKINH = @ChatlieumatKinh, KHANANGCHONGNUOC = @KhanangchongNuoc, TUOITHOPIN = @TuoithoPin " +
                         "WHERE MACAUHINH = @MaCH";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaCH", macauhinh);
                //cmd.Parameters.AddWithValue("@MaDongHo", madongho);
                cmd.Parameters.AddWithValue("@KichThuoc", kichthuoc);
                cmd.Parameters.AddWithValue("@TrongLuong", trongluong);
                cmd.Parameters.AddWithValue("@XuatXu", xuatxu);
                cmd.Parameters.AddWithValue("@ChatlieuVo", CLvo);
                cmd.Parameters.AddWithValue("@ChatleiudayDeo", CLdaydeo);
                cmd.Parameters.AddWithValue("@ChatlieumatKinh", Clmatkinh);
                cmd.Parameters.AddWithValue("@KhanangchongNuoc", KNchongnuoc);
                cmd.Parameters.AddWithValue("@TuoithoPin", tuoithopin);

                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thông số kĩ thuật thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã cấu hình để sửa.", "Lỗi");
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
            dgvcauhinh.Enabled = true;
            btnLuu.Enabled = false;

            txtMaCH.ReadOnly = true;
            txtKichThuoc.ReadOnly = true;
            txtTrongLuong.ReadOnly = true;
            txtXuatXu.ReadOnly = true;
            txtCLvo.ReadOnly = true;
            txtCLdaydeo.ReadOnly = true;
            txtClmatkinh.ReadOnly = true;
            txtKNchongnuoc.ReadOnly = true;
            txtTthoPIN.ReadOnly = true;
            //cb_madongho.Enabled = false;
            //button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDongHo frm = new FormDongHo();
            frm.ReadOnlyMode = true;
            // Hiển thị thông báo nhắc nhở người dùng
            MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm.ShowDialog();
        }

        private void txtMaCH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCH.Text))
            {
                lblLuuYMaCH.Text = "Mã cấu hình sẽ không thể sửa khi cập nhật!";
                lblLuuYMaCH.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYMaCH.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

        
    }
}
