﻿
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
using DevExpress.Xpo;

namespace QuanLy_CuaHangDongHo
{
    public partial class frm_NhanVien : Form
    {

        //public bool ReadOnlyMode { get; set; }
        public frm_NhanVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form

            // This line of code is generated by Data Source Configuration Wizard
            nhanvienTableAdapter1.Fill(cuahang_donghoDataSet1.NHANVIEN);
        }

        SqlConnection Connection;
        string str = @"Data Source=TONG2004;Initial Catalog=cuahang_dongho_new;Integrated Security=True;Encrypt=False";
        //private FormDongHo formDongHo; // Khai báo đối tượng form DongHo
        //public frm_NhanVien(FormDongHo dongHoForm)
        //{
        //    InitializeComponent();
        //    this.WindowState = FormWindowState.Maximized;

        //    this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
        //    formDongHo = dongHoForm; // Truyền đối tượng form DongHo từ constructor
        //    LoadMaDongHo(); // Tải danh sách mã đồng hồ
        //}

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
            commmand.CommandText = "select * from NHANVIEN"; // Thay bằng câu truy vấn thực tế của bạn
                                                             // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Nạp dữ liệu vào DataGridView
            dgvnhanvien.DataSource = table;

            // Thiết lập giao diện cho DataGridView
            dgvnhanvien.Columns["MANHANVIEN"].HeaderText = "MÃ NHÂN VIÊN";
            //dgvnhanvien.Columns["MADONGHO"].HeaderText = "MÃ ĐỒNG HỒ";
            dgvnhanvien.Columns["HONV"].HeaderText = "HỌ NHÂN VIÊN";
            dgvnhanvien.Columns["TENNV"].HeaderText = "TÊN NHÂN VIÊN";
            dgvnhanvien.Columns["GIOITINHNV"].HeaderText = "GIỚI TÍNH";
            dgvnhanvien.Columns["NGAYSINHNV"].HeaderText = "NGÀY SINH";
            dgvnhanvien.Columns["DIACHINV"].HeaderText = "ĐỊA CHỈ";
            dgvnhanvien.Columns["SDTNV"].HeaderText = "SỐ ĐIỆN THOẠI";
            dgvnhanvien.Columns["EMAILNV"].HeaderText = "EMAIL";


            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {
            txtMaNV.ReadOnly = false;
            txtHoNV.ReadOnly = false;
            txtTenNV.ReadOnly = false;
            comboBoxGT.Enabled = true;
            dateTimeNgaySinh.Enabled = true;
            txtDCNV.ReadOnly = false;
            txtSdtNV.ReadOnly = false;
            txtEmNV.ReadOnly = false;

            //cb_madongho.Enabled = true;
            //button1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvnhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvnhanvien.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvnhanvien.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvnhanvien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvnhanvien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvnhanvien.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvnhanvien.RowsDefaultCellStyle.BackColor = Color.White;
            dgvnhanvien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvnhanvien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvnhanvien.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvnhanvien.ReadOnly = true;

            // Đặt border
            dgvnhanvien.BorderStyle = BorderStyle.Fixed3D;
            dgvnhanvien.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvnhanvien.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvnhanvien.AllowUserToResizeColumns = false;
            dgvnhanvien.AllowUserToResizeRows = false;
        }




        
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtMaNV.Text = "";
            //this.cb_madongho.Text = "";
            this.txtHoNV.Text = "";
            this.txtTenNV.Text = "";
            this.comboBoxGT.Text = "Chọn giới tính";
            this.dateTimeNgaySinh.Value = DateTime.Now;
            this.txtDCNV.Text = "";
            this.txtSdtNV.Text = "0";
            this.txtEmNV.Text = "";

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;

        }

            private void btnXoa_Click(object sender, EventArgs e)
            {
            string manv = this.txtMaNV.Text.Trim();
            // Lấy mã đồng hồ từ ComboBox (hoặc TextBox, tùy vào thiết kế giao diện của bạn)
            //string maDongHo = cb_madongho.SelectedValue.ToString();
            XoaNhanVien(manv);
            //if (string.IsNullOrEmpty(manv))
            //{
            //    MessageBox.Show("Vui lòng chọn mã nhà nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Hiển thị hộp thoại xác nhận
            //DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi có mã nhân viên: {manv} không?",
            //                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result != DialogResult.Yes)
            //{
            //    return; // Người dùng chọn "No", thoát khỏi hàm
            //}


            //    //string sql = String.Format("DELETE FROM NHANVIEN WHERE MANHANVIEN = @MaNhanVien");
            //    string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            //    SqlConnection conn = new SqlConnection(connString);
            //try
            //{
            //    conn.Open();
            //    // 1. Xóa các bản ghi trong bảng con (DONGHO) trước
            //    string sqlDeleteDongHo = "DELETE FROM DONGHO WHERE MANHANHVIEN = @MaNhanVien";
            //    using (SqlCommand cmdDeleteDongHo = new SqlCommand(sqlDeleteDongHo, conn))
            //    {
            //        cmdDeleteDongHo.Parameters.AddWithValue("@MaNhanVien", manv);
            //        cmdDeleteDongHo.ExecuteNonQuery();

            //        // 2. Xóa bản ghi trong bảng cha (NHANVIEN) sau cùng
            //        string sqlDeleteParent = "DELETE FROM NHANVIEN WHERE MANHANHVIEN = @MaNhanVien";
            //        using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
            //        {
            //            cmdDeleteParent.Parameters.AddWithValue("@MaNhanVien", manv);
            //            int rowsAffected = cmdDeleteParent.ExecuteNonQuery();
            //            if (rowsAffected > 0)
            //            {
            //                MessageBox.Show("Xóa đồng hồ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                loaddata();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Không tìm thấy mã đồng hồ để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
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
            //    loaddata();
        }


        private void XoaNhanVien(string manv)
        {
            // Kiểm tra mã đồng hồ có rỗng hay không
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên với mã: {manv} không? \nLưu ý: Khi xóa, Nhân viên này sẽ bị xóa khỏi tất cả các form và dữ liệu liên quan trong hệ thống.", "Xác nhận xóa",
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
                    WHERE MADONGHO IN (SELECT MADONGHO FROM DONGHO WHERE MANHANVIEN = @MaNhanVien)";
                    using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, conn))
                    {
                        cmdDeleteMua.Parameters.AddWithValue("@MaNhanVien", manv);
                        cmdDeleteMua.ExecuteNonQuery();
                    }

                    // 1. Xóa các bản ghi trong bảng con (DONGHO) trước
                    string sqlDeleteDongHo = "DELETE FROM DONGHO WHERE MANHANVIEN = @MaNhanVien";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteDongHo, conn))
                    {
                        cmdDeleteChild.Parameters.AddWithValue("@MaNhanVien", manv);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 2. Xóa bản ghi trong bảng cha (NHANVIEN) sau cùng
                    string sqlDeleteParent = "DELETE FROM NHANVIEN WHERE MANHANVIEN = @MaNhanVien";
                    using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
                    {
                        cmdDeleteParent.Parameters.AddWithValue("@MaNhanVien", manv);
                        int rowsAffected = cmdDeleteParent.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã nhân viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FormDongHo_Load(object sender, EventArgs e)
        {
            //if (ReadOnlyMode)
            //{
            //    // Disable các điều khiển nhập liệu
            //    txtMaNV.ReadOnly = true;
            //    txtHoNV.ReadOnly = true;
            //    txtTenNV.ReadOnly = true;
            //    comboBoxGT.Enabled = false;
            //    dateTimeNgaySinh.Enabled = false;
            //    txtDCNV.ReadOnly = true;
            //    txtSdtNV.ReadOnly = true;
            //    txtEmNV.ReadOnly = true;

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
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            loaddata();
            //LoadMaDongHo();
        }

        public void hienthiReader(SqlDataReader reader)
        {
            
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string manv = txtMaNV.Text;
            //string madongho = cb_madongho.Text;
            string honv = txtHoNV.Text;
            string tennv = txtTenNV.Text;
            string gioitinhnv = comboBoxGT.Text;
            string ngaysinhnv = dateTimeNgaySinh.Text;
            string diachinv = txtDCNV.Text;
            string sdtnv = txtSdtNV.Text;
            string emailnv = txtEmNV.Text;

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
            dgvnhanvien.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e) 
        {
            // Lấy dữ liệu từ các điều khiển
            string manv = txtMaNV.Text;
            //string madongho = cb_madongho.Text;
            string honv = txtHoNV.Text;
            string tennv = txtTenNV.Text;
            string gioitinhnv = comboBoxGT.Text;
            string ngaysinhnv = dateTimeNgaySinh.Text;
            string diachinv = txtDCNV.Text;
            string sdtnv = txtSdtNV.Text;
            string emailnv = txtEmNV.Text;

            if (!emailnv.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi");
                return;
            }

            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE NHANVIEN " +
                         "SET HONV = @HoNV, TENNV = @TenNV, GIOITINHNV = @GioiTinhNV, NGAYSINHNV = @NgaySinhNV, " +
                         "DIACHINV = @DiaChiNV, SDTNV = @SDTNV, EMAILNV = @EmailNV " +
                         "WHERE MANHANVIEN = @MaNV";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaNV", manv);
                //cmd.Parameters.AddWithValue("@MaDongHo", madongho);
                cmd.Parameters.AddWithValue("@HoNV", honv);
                cmd.Parameters.AddWithValue("@TenNV", tennv);
                cmd.Parameters.AddWithValue("@GioiTinhNV", gioitinhnv);
                cmd.Parameters.AddWithValue("@NgaySinhNV", DateTime.Parse(ngaysinhnv));
                cmd.Parameters.AddWithValue("@DiaChiNV", diachinv);
                cmd.Parameters.AddWithValue("@SDTNV", sdtnv);
                cmd.Parameters.AddWithValue("@EmailNV", emailnv);

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
            dgvnhanvien.Enabled = true;
            btnLuu.Enabled = false;

            txtMaNV.ReadOnly = true;
            txtHoNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            comboBoxGT.Enabled = false;
            dateTimeNgaySinh.Enabled = false;
            txtDCNV.ReadOnly = true;
            txtSdtNV.ReadOnly = true;
            txtEmNV.ReadOnly = true;

            //cb_madongho.Enabled = false;
            button1.Enabled = false;
        }
        
        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuahang_donghoDataSet1);

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
                    (form as FormDongHo)?.LoadMaNhanVien();

                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvnhanvien.CurrentRow.Index;

            txtMaNV.Text = dgvnhanvien.Rows[i].Cells[0].Value.ToString();
            //cb_madongho.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString();
            txtHoNV.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString();
            txtTenNV.Text = dgvnhanvien.Rows[i].Cells[2].Value.ToString();
            comboBoxGT.Text = dgvnhanvien.Rows[i].Cells[3].Value.ToString().Trim();
            dateTimeNgaySinh.Text = dgvnhanvien.Rows[i].Cells[4].Value.ToString();
            txtDCNV.Text = dgvnhanvien.Rows[i].Cells[5].Value.ToString();
            txtSdtNV.Text = dgvnhanvien.Rows[i].Cells[6].Value.ToString();
            txtEmNV.Text = dgvnhanvien.Rows[i].Cells[7].Value.ToString();

            txtMaNV.ReadOnly = true;
            txtHoNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;           
            dateTimeNgaySinh.Enabled = false;
            txtDCNV.ReadOnly = true;
            txtSdtNV.ReadOnly = true;
            txtEmNV.ReadOnly = true;

            comboBoxGT.Enabled = false;
            //button1.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            resetForm();
            string manv = this.txtMaNV.Text.Trim();
            //string madongho = this.cb_madongho.Text.Trim();
            //if (string.IsNullOrEmpty(madongho))
            //{
            //    MessageBox.Show("Vui lòng chọn mã đồng hồ hợp lệ.", "Cảnh báo");
            //    return;
            //}
            string honv = this.txtHoNV.Text.Trim();
            string tennv = this.txtTenNV.Text.Trim();
            string gioitinhnv = this.comboBoxGT.Text.Trim();
            string ngaysinhnv = this.dateTimeNgaySinh.Value.ToString("yyyy-MM-dd");
            string diachinv = this.txtDCNV.Text.Trim();
            string sdtnv = this.txtSdtNV.Text.Trim();
            string emailnv = this.txtEmNV.Text.Trim();




            if (string.IsNullOrEmpty(manv) || /*string.IsNullOrEmpty(madongho) ||*/
            string.IsNullOrEmpty(honv) || string.IsNullOrEmpty(tennv) ||
            string.IsNullOrEmpty(gioitinhnv) || string.IsNullOrEmpty(ngaysinhnv) ||
            string.IsNullOrEmpty(diachinv) || string.IsNullOrEmpty(sdtnv) || string.IsNullOrEmpty(emailnv))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO NHANVIEN (MANHANVIEN, HONV, TENNV, GIOITINHNV, NGAYSINHNV, DIACHINV, SDTNV, EMAILNV) " +
                 "VALUES (@MANHANVIEN, @HONV, @TENNV, @GIOITINHNV, @NGAYSINHNV, @DIACHINV, @SDTNV, @EMAILNV)";
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
                cmd.Parameters.AddWithValue("@MANHANVIEN", manv);
                //cmd.Parameters.AddWithValue("@MADONGHO", madongho);
                cmd.Parameters.AddWithValue("@HONV", honv);
                cmd.Parameters.AddWithValue("@TENNV", tennv);
                cmd.Parameters.AddWithValue("@GIOITINHNV", gioitinhnv);
                cmd.Parameters.AddWithValue("@NGAYSINHNV", Convert.ToDateTime(ngaysinhnv));
                cmd.Parameters.AddWithValue("@DIACHINV", diachinv);
                cmd.Parameters.AddWithValue("@SDTNV", sdtnv);
                cmd.Parameters.AddWithValue("@EMAILNV", emailnv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!");

            }

            catch (Exception ex)
            {
                
                MessageBox.Show("Mã nhân viên " + manv + " đã có trong CSDL! ");
            }

            finally
            {
                loaddata();
                conn.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDongHo frm = new FormDongHo();
            frm.ReadOnlyMode = true;
            // Hiển thị thông báo nhắc nhở người dùng
            MessageBox.Show("Lưu ý: Chỉ được xem thông tin, không cho phép thao tác chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm.ShowDialog();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                lblLuuYMaNV.Text = "Mã nhân viên sẽ không thể sửa khi cập nhật!";
                lblLuuYMaNV.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYMaNV.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

      
    }
}


        
