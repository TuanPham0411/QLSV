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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV.Model
{
    public partial class XemDiem : XtraForm
    {
        public XemDiem()
        {
            InitializeComponent();
            cmbMaso.SelectedIndexChanged += cmbChange_SelectedIndexChanged;
            cmbHoten.SelectedIndexChanged += cmbChange_SelectedIndexChanged;
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            this.ketQuaTableAdapter.Fill(this.qlsv.KetQua);
            this.kHOATableAdapter.Fill(this.qlsv.KHOA);
            this.sinhVienTableAdapter.Fill(this.qlsv.SinhVien);
        }

        private void cmbChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = sinhVienTableAdapter.GetDataBy(int.Parse(cmbMaso.Text));
                string maso = dt.Rows[0]["MaKhoa"].ToString();
                DataTable dt_1 = kHOATableAdapter.GetDataBy(maso);
                txtTenkhoa.Text = dt_1.Rows[0]["TenKhoa"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dt = ketQuaTableAdapter.GetDataBy(int.Parse(cmbMaso.Text));
            grvDiem.DataSource = dt;

            if (grvDiem.Columns.Count >= 3)
            {
                DataGridViewColumn col1 = grvDiem.Columns["MaMH"];
                DataGridViewColumn col3 = grvDiem.Columns["TenMH"];

                int col1Index = col1.DisplayIndex;
                col1.DisplayIndex = col3.DisplayIndex;
                col3.DisplayIndex = col1Index;

                col1.Visible = false;
            }


        }
    }
}