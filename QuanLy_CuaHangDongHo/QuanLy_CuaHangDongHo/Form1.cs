using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHangDongHo
{
    public partial class Form1 : Form
    {
        //private int btnThucThi = -1;
        //private const int BTN_QLDONGHO = 0;
        //private const int BUTTON1 = 1;
        //private const int BUTTON2 = 2;
        //private const int BUTTON3 = 3;
        //private const int BUTTON4 = 4;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
        }

        private void EnableButton()
        {
            //Color enableColor = Color.FromArgb(3, 169, 244);
            //switch (btnThucThi)
            //{
            //    case BTN_QLDONGHO:
            //        btnQLDongHo.Enabled = true;
            //        btnQLDongHo.BackColor = enableColor;
            //        break;

            //    case BUTTON1:
            //        button1.Enabled = true;
            //        button1.BackColor = enableColor;
            //        break;

            //     case BUTTON2:
            //        button2.Enabled = true;
            //        button2.BackColor = enableColor;
            //        break;
   
            //    case BUTTON3:
            //        button3.Enabled = true;
            //        button3.BackColor = enableColor;
            //        break;

            //}
        }

        private void MoFormCon(Form formCon)
        {
            if (!panelContainer.Controls.Contains(formCon))
            {
                formCon.TopLevel = false;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(formCon);
                formCon.Show();
            }
        }

       

        private void DisableButton()
        {
            //Color disableColor = Color.FromArgb(1, 87, 155);
            //switch (btnThucThi)
            //{
            //    case BTN_QLDONGHO:
            //        btnQLDongHo.BackColor = disableColor;
            //        break;

            //    case BUTTON1:
            //        button1.BackColor= disableColor;
            //        break;

            //    case BUTTON2:
            //        button2.BackColor= disableColor;
            //        break;

            //    case BUTTON3:
            //        button3.BackColor= disableColor;
            //        break;

                
            //}
        }

       
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void btnQLDongHo_Click_1(object sender, EventArgs e)
        {
            FormDongHo  frm = new FormDongHo();
            frm.Show();
            //EnableButton();
            //btnThucThi = BTN_QLDONGHO;
            //DisableButton();
            //MoFormCon(new FormDongHo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanVienForm = new frm_NhanVien();
            nhanVienForm.Show();
            //EnableButton();
            //btnThucThi = BTN_QLDONGHO;
            //DisableButton();
            //MoFormCon(new frm_NhanVien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ThongSoKiThuat frm = new frm_ThongSoKiThuat();
            frm.ShowDialog();
            //EnableButton();
            //btnThucThi = BTN_QLDONGHO;
            //DisableButton();
            //MoFormCon(new frm_ThongSoKiThuat());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frm_NhaCungCap = new frm_NhaCungCap();
            frm_NhaCungCap.ShowDialog();
            //EnableButton();
            //btnThucThi = BTN_QLDONGHO;
            //DisableButton();
            //MoFormCon(new frm_NhaCungCap());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_HangDongHo frm = new frm_HangDongHo();
            frm.ShowDialog();
            //EnableButton();
            //btnThucThi = BTN_QLDONGHO;
            //DisableButton();
            //MoFormCon(new frm_HangDongHo());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm_KhachHang = new frm_KhachHang();
            frm_KhachHang.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_DiaChiGiaoHang frm = new frm_DiaChiGiaoHang();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_PhieuBH frm = new frm_PhieuBH();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_Mua frm = new frm_Mua();
            frm.ShowDialog();
        }

        

        private void button9_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HDSDHelp.chm");

        }
    }
}
