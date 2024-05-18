using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Model
{
    public partial class NhapDiem : DevExpress.XtraEditors.XtraForm
    {
        public NhapDiem()
        {
            InitializeComponent();
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            this.monTableAdapter.Fill(this.qlsv.Mon);
            this.sinhVienTableAdapter.Fill(this.qlsv.SinhVien);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtDiem.Text.Length > 0)
            {
                try
                {
                    this.ketQuaTableAdapter.InsertQuery(int.Parse(cmbMaso.Text), cmbMaMH.Text, int.Parse(txtDiem.Text));
                    MessageBox.Show("Nhập điểm thành công!");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("ERROR [23000]"))
                    {
                        DialogResult result = MessageBox.Show("Đã nhập điểm cho môn học này trước đó.\nCập nhật điểm số mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            CapNhatDiem(int.Parse(cmbMaso.Text), cmbMaMH.Text, int.Parse(txtDiem.Text));
                            MessageBox.Show("Cập nhật điểm thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào điểm số");
            }
        }

        private void CapNhatDiem(int maSo, string maMH, int diemMoi)
        {
            try
            {
                this.ketQuaTableAdapter.UpdateQuery(diemMoi, maSo, maMH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật điểm: " + ex.Message);
            }
        }
    }
}