using DevExpress.XtraBars;
using QLSV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnSv_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "SinhVien")
                {
                    f.Activate();
                    return;
                }
            }
            SinhVien sv = new SinhVien();
            sv.MdiParent = this;
            sv.Show();
        }

        private void btnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Khoa")
                {
                    f.Activate();
                    return;
                }
            }
            Khoa sv = new Khoa();
            sv.MdiParent = this;
            sv.Show();
        }

        private void btnMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "MonHoc")
                {
                    f.Activate();
                    return;
                }
            }
            MonHoc sv = new MonHoc();
            sv.MdiParent = this;
            sv.Show();
        }

        private void btnNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "NhapDiem")
                {
                    f.Activate();
                    return;
                }
            }
            NhapDiem sv = new NhapDiem();
            sv.MdiParent = this;
            sv.Show();
        }

        private void btnXem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "XemDiem")
                {
                    f.Activate();
                    return;
                }
            }
            XemDiem sv = new XemDiem();
            sv.MdiParent = this;
            sv.Show();
        }

        private void btnTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "XemSvKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            XemSvKhoa sv = new XemSvKhoa();
            sv.MdiParent = this;
            sv.Show();
        }
    }
}