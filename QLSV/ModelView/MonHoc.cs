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
    public partial class MonHoc : DevExpress.XtraEditors.XtraForm
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlsv);
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            this.monTableAdapter.Fill(this.qlsv.Mon);
        }
    }
}