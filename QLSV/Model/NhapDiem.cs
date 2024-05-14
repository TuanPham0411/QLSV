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

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlsv);
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            this.monTableAdapter.Fill(this.qlsv.Mon);
            this.sinhVienTableAdapter.Fill(this.qlsv.SinhVien);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                this.ketQuaTableAdapter.InsertQuery(int.Parse(cmbMaso.Text), cmbMaMH.Text, int.Parse(txtDiem.Text));
                MessageBox.Show("Nhập điểm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}