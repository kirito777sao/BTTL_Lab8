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
    public partial class TimKiemTTBH_0849 : Form
    {
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        public TimKiemTTBH_0849()
        {
            InitializeComponent();
        }

        private void btTim_0849_Click(object sender, EventArgs e)
        {
            if (txtMaKH_0849.Text.Trim() != "")
            {
                if (int.TryParse(txtMaKH_0849.Text, out int maKH))
                {
                    DataTable dt = kncsdl.TimKiemBanHangTheoMaKH(maKH);
                    if (dt == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin bán hàng với mã khách hàng " + maKH, "Thông báo");
                        return;
                    }
                    dgv4_0849.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo");
                    return;
                }
            }
            else if (txtTenKH_0849.Text.Trim() != "")
            {
                string tenKH = txtTenKH_0849.Text;
                DataTable dt = kncsdl.TimKiemBanHangTheoTenKH(tenKH);
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin bán hàng với tên khách hàng '" + tenKH + "'", "Thông báo");
                    return;
                }
                dgv4_0849.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo");
                return;
            }
        }

        private void btThoat_0849_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
