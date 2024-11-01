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
    public partial class TimKiemKH_0849 : Form
    {
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        public TimKiemKH_0849()
        {
            InitializeComponent();
        }

        private void btTim_0849_Click(object sender, EventArgs e)
        {
            if (rdMaKH_0849.Checked)
            {
                if (txtNDTK_0849.Text.Trim() == "") { MessageBox.Show("Chưa nhập nội dung tìm kiếm!", "Thông báo"); txtNDTK_0849.Focus(); return; }
                int makh = int.Parse(txtNDTK_0849.Text);
                DataTable dt = kncsdl.TimKiemKhachHangTheoMa(makh);
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng với mã " + makh, "Thông báo");
                    return;
                }
                dgv3_0849.DataSource = dt;
            }
            else if (rdTenKH_0849.Checked)
            {
                if (txtNDTK_0849.Text.Trim() == "") { MessageBox.Show("Chưa nhập nội dung tìm kiếm!", "Thông báo"); txtNDTK_0849.Focus(); return; }
                string tenKH = txtNDTK_0849.Text;
                DataTable dt = kncsdl.TimKiemKhachHangTheoTen(tenKH);
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng với tên '" + tenKH + "'", "Thông báo");
                    return;
                }
                dgv3_0849.DataSource = dt;
            }
            else if (rdSDT_0849.Checked)
            {
                if (txtNDTK_0849.Text.Trim() == "") { MessageBox.Show("Chưa nhập nội dung tìm kiếm!", "Thông báo"); txtNDTK_0849.Focus(); return; }
                string sdt = txtNDTK_0849.Text;
                DataTable dt = kncsdl.TimKiemKhachHangTheoSDT(sdt);
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng với số điện thoại '" + sdt + "'", "Thông báo");
                    return;
                }
                dgv3_0849.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!", "Thông báo");
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
