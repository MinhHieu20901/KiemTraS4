using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraS4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text =="Admin" && txtMatKhau.Text == "Admin")
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
        }
    }
}
