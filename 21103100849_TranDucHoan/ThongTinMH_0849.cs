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
    public partial class ThongTinMH_0849 : Form
    {
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        public ThongTinMH_0849()
        {
            InitializeComponent();
        }

        private void btThem_0849_Click(object sender, EventArgs e)
        {
            if (txtTenMH_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Tên Mặt Hàng"); txtTenMH_0849.Focus(); return; }
            if (txtDVT_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Đơn Vị Tính"); txtDVT_0849.Focus(); return; }
            kncsdl.ThemMH(txtMaMH_0849.Text.Trim(), txtTenMH_0849.Text, txtDVT_0849.Text);
            DuaDLVaoBang();
            ClearTexts();
            MessageBox.Show("Thêm Thành Công");
        }

        private void btSua_0849_Click(object sender, EventArgs e)
        {
            // Sửa thông tin mặt hàng
            if (txtTenMH_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Tên Mặt Hàng"); txtTenMH_0849.Focus(); return; }
            if (txtDVT_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Đơn Vị Tính"); txtDVT_0849.Focus(); return; }
            kncsdl.SuaMatHang(txtMaMH_0849.Text.Trim(), txtTenMH_0849.Text, txtDVT_0849.Text);
            DuaDLVaoBang();
            ClearTexts();
            MessageBox.Show("Sửa Thành Công");
        }

        private void btXoa_0849_Click(object sender, EventArgs e)
        {
            if (dgv1_0849.SelectedRows == null) { return; }
            if (dgv1_0849.SelectedRows[0].Cells[0].Value == null) { return; }
            if (MessageBox.Show("Có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv1_0849.SelectedRows)
                {
                    string ma = row.Cells[0].Value.ToString();
                    kncsdl.XoaMH(ma);
                }
                DuaDLVaoBang();
                ClearTexts();
            }
        }

        private void btTimKiem_0849_Click(object sender, EventArgs e)
        {
            // Tìm kiếm mặt hàng theo mã
            DataTable dt = kncsdl.TimKiemMatHang(int.Parse(txtMaMH_0849.Text));
            if (dt != null)
            {
                dgv1_0849.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo");
            }
        }

        private void btThoat_0849_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void DuaDLVaoBang()
        {
            dgv1_0849.DataSource = kncsdl.getAllMH();
        }

        void ClearTexts()
        {
            txtMaMH_0849.Clear();
            txtTenMH_0849.Clear();
            txtDVT_0849.Clear();
        }

        private void ThongTinMH_0849_Load(object sender, EventArgs e)
        {
            DuaDLVaoBang();
        }

        private void dgv1_0849_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //chỉ số của hàng ddang chọn 
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgv1_0849.Rows[i];
                txtMaMH_0849.Text = r.Cells[0].Value.ToString();
                txtTenMH_0849.Text = r.Cells[1].Value.ToString();
                txtDVT_0849.Text = r.Cells[2].Value.ToString();
            }
        }
    }
}
