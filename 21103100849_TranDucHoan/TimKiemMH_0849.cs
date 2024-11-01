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
    public partial class TimKiemMH_0849 : Form
    {
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        public TimKiemMH_0849()
        {
            InitializeComponent();
        }

        private void btThoat_0849_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btTim_0849_Click(object sender, EventArgs e)
        {
            if (rdMaMH_0849.Checked)
            {
                if (txtNDTK_0849.Text.Trim() == "") { MessageBox.Show("Chưa nhập nội dung tìm kiếm!", "Thông báo"); txtNDTK_0849.Focus(); return; }
                int mamh = int.Parse(txtNDTK_0849.Text);
                DataTable dt = kncsdl.TimKiemMatHangTheoMa(mamh);
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng với mã " + mamh, "Thông báo");
                    return;
                }
                dgv4_0849.DataSource = dt;
            }
            else if (rdTenMH_0849.Checked)
            {
                if (txtNDTK_0849.Text.Trim() == "") { MessageBox.Show("Chưa nhập nội dung tìm kiếm!", "Thông báo"); txtNDTK_0849.Focus(); return; }
                string tenMH = txtNDTK_0849.Text;
                DataTable dt = kncsdl.TimKiemMatHangTheoTen(tenMH);
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng với tên '" + tenMH + "'", "Thông báo");
                    return;
                }
                dgv4_0849.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!", "Thông báo");
                return;
            }
        }
    }
}
