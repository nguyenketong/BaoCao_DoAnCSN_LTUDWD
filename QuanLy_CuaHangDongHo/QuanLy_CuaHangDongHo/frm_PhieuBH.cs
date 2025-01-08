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
    public partial class frm_PhieuBH : Form
    {
        public frm_PhieuBH()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.None; // Ẩn tiêu đề của Form
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
            commmand.CommandText = "select * from PHIEUBAOHANH"; // Thay bằng câu truy vấn thực tế của bạn
                                                              // Cấu hình adapter
            adapter.SelectCommand = commmand;

            // Xóa dữ liệu cũ và nạp dữ liệu mới
            table.Clear();
            adapter.Fill(table);

            // Nạp dữ liệu vào DataGridView
            dgvphieubaohanh.DataSource = table;

            dgvphieubaohanh.Columns["MAPHIEUBAOHANH"].HeaderText = "MÃ PHIẾU BẢO HÀNH";
            dgvphieubaohanh.Columns["NGAYBATDAU"].HeaderText = "NGÀY BẮT ĐẦU";
            dgvphieubaohanh.Columns["NGAYKETTHUC"].HeaderText = "NGÀY KẾT THÚC";



            SetupDataGridViewFullScreen();
        }

        private void resetForm()
        {
            txtMaDCGH.ReadOnly = false;
            
            dateTimeNgayBD.Enabled = true;  
            dateTimeNgayKT.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }



        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvphieubaohanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvphieubaohanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvphieubaohanh.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvphieubaohanh.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvphieubaohanh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvphieubaohanh.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvphieubaohanh.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvphieubaohanh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvphieubaohanh.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvphieubaohanh.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvphieubaohanh.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvphieubaohanh.ReadOnly = true;

            // Đặt border
            dgvphieubaohanh.BorderStyle = BorderStyle.Fixed3D;
            dgvphieubaohanh.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvphieubaohanh.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvphieubaohanh.AllowUserToResizeColumns = false;
            dgvphieubaohanh.AllowUserToResizeRows = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetForm();
            //Làm mới các hộp hội thoại
            this.txtMaDCGH.Text = "";          
            this.dateTimeNgayBD.Value = DateTime.Now;
            this.dateTimeNgayKT.Value = DateTime.Now;


            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nRồi nhấn nút **Cập Nhật**.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = this.txtMaDCGH.Text.Trim();

            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu bảo hành để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu bảo hành với mã: {manv} không? \nLưu ý: Khi xóa, phiếu bảo hành này sẽ bị xóa khỏi tất cả các form và dữ liệu liên quan trong hệ thống.", "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", thì thoát khỏi hàm
            if (result != DialogResult.Yes)
            {
                return;
            }

            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=True; Encrypt=False;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // 1. Xóa các bản ghi trong bảng con (DIACHIGIAOHANG) trước
                    string sqlDeleteChild = "DELETE FROM MUA WHERE MAPHIEUBAOHANH = @MaPhieuBaoHanh";
                    using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteChild, conn))
                    {
                        cmdDeleteChild.Parameters.AddWithValue("@MaPhieuBaoHanh", manv);
                        cmdDeleteChild.ExecuteNonQuery();
                    }

                    // 2. Xóa bản ghi trong bảng cha (PHIEUBAOHANH)
                    string sqlDeleteParent = "DELETE FROM PHIEUBAOHANH WHERE MAPHIEUBAOHANH = @MaPhieuBaoHanh";
                    using (SqlCommand cmdDeleteParent = new SqlCommand(sqlDeleteParent, conn))
                    {
                        cmdDeleteParent.Parameters.AddWithValue("@MaPhieuBaoHanh", manv);
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
            //string sql = String.Format("DELETE FROM PHIEUBAOHANH WHERE MAPHIEUBAOHANH = @MAPHIEUBAOHANH");
            //string connString = "server=TONG2004; database=cuahang_dongho; Integrated Security=SSPI;";
            //SqlConnection conn = new SqlConnection(connString);
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@MAPHIEUBAOHANH", manv);

            //    int kq = cmd.ExecuteNonQuery();
            //    if (kq != -1)
            //    {
            //        MessageBox.Show(" Da xoa thanh cong! " + manv);
            //        sql = "select * from PHIEUBAOHANH"; // Load lại dữ liệu để hiển thị lên form cmd.CommandText= sql;
            //        cmd.CommandText = sql;
            //        SqlDataReader reader = cmd.ExecuteReader();
            //    }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(manv + " Khong xoa thanh cong! ");
            }
            //finally
            //{

            //    conn.Close();
            //}
            //loaddata();
        }



        private void frm_PhieuBH_Load(object sender, EventArgs e)
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
            string manv = txtMaDCGH.Text;            
            string ngaybatdau = dateTimeNgayBD.Text;
            string ngayketthuc = dateTimeNgayKT.Text;
           

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin phiếu bảo hành này không?",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            resetForm();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvphieubaohanh.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string manv = txtMaDCGH.Text;
            string ngaybatdau = dateTimeNgayBD.Text;
            string ngayketthuc = dateTimeNgayKT.Text;

            // Chuỗi kết nối cơ sở dữ liệu
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=True; Encrypt=False;";
            SqlConnection conn = new SqlConnection(connString);

            // Câu lệnh SQL cập nhật dữ liệu
            string sql = "UPDATE PHIEUBAOHANH " +
                         "SET MAPHIEUBAOHANH = @MaPhieuBaoHanh, NGAYBATDAU = @NgayBD, NGAYKETTHUC = @NgayKT " +
                         "WHERE MAPHIEUBAOHANH = @MaPhieuBaoHanh";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaPhieuBaoHanh", manv);
                cmd.Parameters.AddWithValue("@NgayBD", DateTime.Parse(ngaybatdau));
                cmd.Parameters.AddWithValue("@NgayKT", DateTime.Parse(ngayketthuc));


                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa phiếu bảo hành thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu bảo hành để sửa.", "Lỗi");
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
            dgvphieubaohanh.Enabled = true;
            btnLuu.Enabled = false;

            txtMaDCGH.ReadOnly = true;
            dateTimeNgayBD.Enabled = false;
            dateTimeNgayKT.Enabled = false;           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            resetForm();
            string manv = this.txtMaDCGH.Text.Trim();
            string ngaybatdau = this.dateTimeNgayBD.Value.ToString("yyyy-MM-dd"); 
            string ngayketthuc = this.dateTimeNgayKT.Value.ToString("yyyy-MM-dd"); 

            if (string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(ngaybatdau) ||
            string.IsNullOrEmpty(ngayketthuc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO PHIEUBAOHANH (MAPHIEUBAOHANH, NGAYBATDAU, NGAYKETTHUC) " +
                "VALUES (@MAPHIEUBAOHANH, @NGAYBATDAU, @NGAYKETTHUC)";
            string connString = "server=TONG2004; database=cuahang_dongho_new; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAPHIEUBAOHANH", manv);
                cmd.Parameters.AddWithValue("@NGAYBATDAU", DateTime.Parse(ngaybatdau));
                cmd.Parameters.AddWithValue("@NGAYKETTHUC", DateTime.Parse(ngayketthuc));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mã phiếu bảo hành thành công!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Mã phiếu bảo hành " + manv + " đã có trong CSDL! ");
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
                    (form as frm_Mua)?.LoadMaPhieuBaoHanh();
                    break;
                    
                }
            }
        }

        private void dgvphieubaohanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvphieubaohanh.CurrentRow.Index;

            txtMaDCGH.Text = dgvphieubaohanh.Rows[i].Cells[0].Value.ToString();         
            dateTimeNgayBD.Text = dgvphieubaohanh.Rows[i].Cells[1].Value.ToString();
            dateTimeNgayKT.Text = dgvphieubaohanh.Rows[i].Cells[2].Value.ToString();

            txtMaDCGH.ReadOnly = true;
            dateTimeNgayBD.Enabled = false;
            dateTimeNgayKT.Enabled = false;


            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void txtMaDCGH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDCGH.Text))
            {
                lblLuuYPBH.Text = "Mã khách hàng sẽ không thể sửa khi cập nhật!!";
                lblLuuYPBH.ForeColor = Color.Red;
            }
            else
            {
                lblLuuYPBH.Text = ""; // Xóa lưu ý khi có dữ liệu
            }
        }

    }
}
