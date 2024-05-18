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
        private string checkKhoa;
        private string checkMakhoa;

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

        private void load_Combobox()
        {
            try
            {
                DataTable dt = sinhVienTableAdapter.GetDataBy(int.Parse(cmbMaso.Text));
                string maso = dt.Rows[0]["MaKhoa"].ToString();
                DataTable dt_1 = kHOATableAdapter.GetDataBy(maso);
                checkKhoa = dt_1.Rows[0]["TenKhoa"].ToString();
                checkMakhoa = dt_1.Rows[0]["MaKhoa"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Combobox();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            grvDiem.DataSource = null;
            load_Combobox();
            if (checkKhoa.TrimEnd() == txtKhoa.Text || checkMakhoa.TrimEnd() == txtKhoa.Text)
            {
                DataTable dt = ketQuaTableAdapter.GetDataBy(int.Parse(cmbMaso.Text));
                grvDiem.DataSource = dt;

                DataGridViewColumn col1 = grvDiem.Columns["MaMH"];
                DataGridViewColumn col3 = grvDiem.Columns["TenMH"];

                int col1Index = col1.DisplayIndex;
                col1.DisplayIndex = col3.DisplayIndex;
                col3.DisplayIndex = col1Index;

                col1.Visible = false;
            }
            else
            {
                MessageBox.Show("Thông tin Khoa chưa chính xác!\nVui lòng nhập lại.");
            }
        }
    }
}