using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//vu quoc quy
namespace MayTinh_Phi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
           txt_Sothunhat.Clear();
           txt_Sothuhai.Clear();
           txt_HienThiKetQua.Clear();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_Sothunhat.Text, out double sothu1) && (double.TryParse(txt_Sothuhai.Text, out double sothu2)))
            {
                double ketqua = 0;
                ketqua = sothu1 + sothu2;
                txt_HienThiKetQua.Text =ketqua.ToString();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu hợp lệ trước khi thực hiện phép cộng.");
            }

        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_Sothunhat.Text, out double sothu1) && (double.TryParse(txt_Sothuhai.Text, out double sothu2)))
            {
                double ketqua = 0;
                ketqua = sothu1 - sothu2;
                txt_HienThiKetQua.Text=ketqua.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu hợp lệ trước khi thực hiện phép cộng.");
            }
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_Sothunhat.Text, out double sothu1) && (double.TryParse(txt_Sothuhai.Text, out double sothu2)))
            {
                double ketqua = 0;
                ketqua = sothu1 * sothu2;
                txt_HienThiKetQua.Text=(ketqua.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu hợp lệ trước khi thực hiện phép cộng.");
            }
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txt_Sothunhat.Text, out double sothu1) && (double.TryParse(txt_Sothuhai.Text, out double sothu2)))
            {
                double ketqua = 0;
                ketqua = sothu1 / sothu2;
                txt_HienThiKetQua.Text = (ketqua.ToString());

                if(sothu2 == 0)
                {
                    MessageBox.Show("kHONG CHIA DUOC CHO 0");
                    txt_Sothuhai.Clear();
                    txt_HienThiKetQua.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu hợp lệ trước khi thực hiện phép cộng.");
            }
        }

        private void txt_Sothunhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block the input if it's not a valid character
            }
        }

        private void txt_Sothuhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block the input if it's not a valid character
            }
        }
    }

 }

