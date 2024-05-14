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
    public partial class XemSvKhoa : DevExpress.XtraEditors.XtraForm
    {
        public XemSvKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlsv);

        }

        private void XemSvKhoa_Load(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.qlsv.SinhVien);
            this.kHOATableAdapter.Fill(this.qlsv.KHOA);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dt = sinhVienTableAdapter.GetDataByMaKhoa(cmbMakhoa.Text);
            grvSv.DataSource = dt;
            DataGridViewColumn col = grvSv.Columns["MaKhoa"];
            col.Visible = false;
        }
    }
}