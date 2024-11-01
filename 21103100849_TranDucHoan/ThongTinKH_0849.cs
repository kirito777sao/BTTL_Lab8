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
    public partial class ThongTinKH_0849 : Form
    {
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        public ThongTinKH_0849()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Họ Tên"); txtTen.Focus(); return; }
            if (cbGT.Text == "") { MessageBox.Show("Chưa Nhập Giới Tính"); cbGT.Focus(); return; }
            if (txtDC.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Địa Chỉ"); txtDC.Focus(); return; }
            if (txtSDT.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Điện Thoại"); txtSDT.Focus(); return; }
            kncsdl.ThemKH(txtMa.Text.Trim(), txtTen.Text, cbGT.Text, txtDC.Text, txtSDT.Text);
            DuaDLVaoBang();
            ClearTexts();
            MessageBox.Show("Thêm Thành Công");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // Sửa thông tin khách hàng
            if (txtTen.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Họ Tên"); txtTen.Focus(); return; }
            if (cbGT.Text == "") { MessageBox.Show("Chưa Nhập Giới Tính"); cbGT.Focus(); return; }
            if (txtDC.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Địa Chỉ"); txtDC.Focus(); return; }
            if (txtSDT.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Điện Thoại"); txtSDT.Focus(); return; }
            kncsdl.SuaKhachHang(txtTen.Text, cbGT.Text, txtDC.Text, txtSDT.Text, txtMa.Text);
            DuaDLVaoBang();
            ClearTexts();
            MessageBox.Show("Sửa Thành Công");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows == null) { return; }
            if (dgv1.SelectedRows[0].Cells[0].Value == null) { return; }
            if (MessageBox.Show("Có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv1.SelectedRows)
                {
                    string ma = row.Cells[0].Value.ToString();
                    kncsdl.XoaKH(ma);
                }
                DuaDLVaoBang();
                ClearTexts();
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            // Tìm kiếm mặt hàng theo mã
            DataTable dt = kncsdl.TimKiemKhachHang(int.Parse(txtMa.Text));
            if (dt != null)
            {
                dgv1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ThongTinKH_0849_Load(object sender, EventArgs e)
        {
            DuaDLVaoBang();
        }

        void ClearTexts()
        {
            txtMa.Clear();
            txtTen.Clear();
            cbGT.SelectedIndex = -1;
            txtDC.Clear();
            txtSDT.Clear();
        }

        void DuaDLVaoBang()
        {
            dgv1.DataSource = kncsdl.getAllKH();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //chỉ số của hàng ddang chọn 
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgv1.Rows[i];
                txtMa.Text = r.Cells[0].Value.ToString();
                txtTen.Text = r.Cells[1].Value.ToString();
                cbGT.Text = r.Cells[2].Value.ToString();
                txtDC.Text = r.Cells[3].Value.ToString();
                txtSDT.Text = r.Cells[4].Value.ToString();
            }
        }
    }
}
