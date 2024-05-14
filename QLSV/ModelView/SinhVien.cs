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
    public partial class SinhVien : XtraForm
    {
        public SinhVien()
        {
            InitializeComponent();
            chkNam.CheckedChanged += chkNam_CheckedChanged;
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlsv);

        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.qlsv.SinhVien);
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked)
            {
                chkNu.Checked = false;
            }
            else
            {
                chkNu.Checked = true;
            }
        }
    }
}