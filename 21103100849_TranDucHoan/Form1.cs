using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21103100849_TranDucHoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTTMH_0849_Click(object sender, EventArgs e)
        {
            ThongTinMH_0849 f1 = new ThongTinMH_0849();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void btCTBH_0849_Click(object sender, EventArgs e)
        {
            ChiTietBanHang_0849 f2 = new ChiTietBanHang_0849();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void btTKKH_0849_Click(object sender, EventArgs e)
        {
            TimKiemKH_0849 f3 = new TimKiemKH_0849();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void btTKMH_0849_Click(object sender, EventArgs e)
        {
            TimKiemMH_0849 f4 = new TimKiemMH_0849();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void btTKBH_0849_Click(object sender, EventArgs e)
        {
            TimKiemTTBH_0849 f5 = new TimKiemTTBH_0849();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }

        private void btThoat_0849_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btTTKH_0849_Click(object sender, EventArgs e)
        {
            ThongTinKH_0849 f1 = new ThongTinKH_0849();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }
    }
}
