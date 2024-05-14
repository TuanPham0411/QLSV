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
    public partial class Khoa : DevExpress.XtraEditors.XtraForm
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlsv);

        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsv.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qlsv.KHOA);

        }
    }
}