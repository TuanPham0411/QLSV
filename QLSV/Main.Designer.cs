namespace QLSV
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Bar bar1;
            DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
            DevExpress.XtraBars.Bar toolBar;
            DevExpress.XtraBars.Bar bar3;
            this.btnSv = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnXem = new DevExpress.XtraBars.BarButtonItem();
            this.btnTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barQLSV = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            bar1 = new DevExpress.XtraBars.Bar();
            barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            toolBar = new DevExpress.XtraBars.Bar();
            bar3 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.barQLSV)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 1;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNhap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            bar1.Text = "Tools";
            // 
            // btnSv
            // 
            this.btnSv.Caption = "Sinh Viên";
            this.btnSv.Id = 3;
            this.btnSv.ImageOptions.Image = global::QLSV.Properties.Resources.usergroup_16x16;
            this.btnSv.ImageOptions.LargeImage = global::QLSV.Properties.Resources.usergroup_32x32;
            this.btnSv.Name = "btnSv";
            this.btnSv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSv_ItemClick);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Caption = "Khoa";
            this.btnKhoa.Id = 4;
            this.btnKhoa.ImageOptions.Image = global::QLSV.Properties.Resources.publicfix_16x16;
            this.btnKhoa.ImageOptions.LargeImage = global::QLSV.Properties.Resources.publicfix_32x32;
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoa_ItemClick);
            // 
            // btnMon
            // 
            this.btnMon.Caption = "Môn Học";
            this.btnMon.Id = 5;
            this.btnMon.ImageOptions.Image = global::QLSV.Properties.Resources.editname_16x16;
            this.btnMon.ImageOptions.LargeImage = global::QLSV.Properties.Resources.editname_32x32;
            this.btnMon.Name = "btnMon";
            this.btnMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMon_ItemClick);
            // 
            // btnNhap
            // 
            this.btnNhap.Caption = "Nhập Điểm";
            this.btnNhap.Id = 6;
            this.btnNhap.ImageOptions.Image = global::QLSV.Properties.Resources.insert_16x16;
            this.btnNhap.ImageOptions.LargeImage = global::QLSV.Properties.Resources.insert_32x32;
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhap_ItemClick);
            // 
            // btnXem
            // 
            this.btnXem.Caption = "Xem Điểm";
            this.btnXem.Id = 7;
            this.btnXem.ImageOptions.Image = global::QLSV.Properties.Resources.forcetesting_16x16;
            this.btnXem.ImageOptions.LargeImage = global::QLSV.Properties.Resources.forcetesting_32x32;
            this.btnXem.Name = "btnXem";
            this.btnXem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXem_ItemClick);
            // 
            // btnTK
            // 
            this.btnTK.Caption = "Thống Kê Khoa";
            this.btnTK.Id = 8;
            this.btnTK.ImageOptions.Image = global::QLSV.Properties.Resources.area2_16x16;
            this.btnTK.ImageOptions.LargeImage = global::QLSV.Properties.Resources.area2_32x32;
            this.btnTK.Name = "btnTK";
            this.btnTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTK_ItemClick);
            // 
            // barLargeButtonItem1
            // 
            barLargeButtonItem1.DropDownEnabled = false;
            barLargeButtonItem1.Enabled = false;
            barLargeButtonItem1.Id = 13;
            barLargeButtonItem1.Name = "barLargeButtonItem1";
            barLargeButtonItem1.Size = new System.Drawing.Size(110, 0);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 9;
            this.btnExit.ImageOptions.Image = global::QLSV.Properties.Resources.editingfillright_16x16;
            this.btnExit.ImageOptions.LargeImage = global::QLSV.Properties.Resources.editingfillright_32x32;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // toolBar
            // 
            toolBar.BarName = "Main menu";
            toolBar.DockCol = 0;
            toolBar.DockRow = 0;
            toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            toolBar.OptionsBar.AllowQuickCustomization = false;
            toolBar.OptionsBar.MultiLine = true;
            toolBar.OptionsBar.UseWholeRow = true;
            toolBar.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Hệ thống";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Chức năng";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Hỗ trợ";
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barStaticItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "connection";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "TuanPham";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.ImageOptions.Image = global::QLSV.Properties.Resources.customer_16x16;
            this.barStaticItem2.ImageOptions.LargeImage = global::QLSV.Properties.Resources.customer_32x32;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barQLSV
            // 
            this.barQLSV.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            bar1,
            toolBar,
            bar3});
            this.barQLSV.DockControls.Add(this.barDockControlTop);
            this.barQLSV.DockControls.Add(this.barDockControlBottom);
            this.barQLSV.DockControls.Add(this.barDockControlLeft);
            this.barQLSV.DockControls.Add(this.barDockControlRight);
            this.barQLSV.Form = this;
            this.barQLSV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barStaticItem2,
            this.btnSv,
            this.btnKhoa,
            this.btnMon,
            this.btnNhap,
            this.btnXem,
            this.btnTK,
            this.btnExit,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            barLargeButtonItem1});
            this.barQLSV.MainMenu = toolBar;
            this.barQLSV.MaxItemId = 14;
            this.barQLSV.StatusBar = bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barQLSV;
            this.barDockControlTop.Size = new System.Drawing.Size(709, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 544);
            this.barDockControlBottom.Manager = this.barQLSV;
            this.barDockControlBottom.Size = new System.Drawing.Size(709, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barQLSV;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 494);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(709, 50);
            this.barDockControlRight.Manager = this.barQLSV;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 494);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 571);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLSV.Properties.Resources.usergroup_32x32;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.barQLSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barQLSV;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem btnSv;
        private DevExpress.XtraBars.BarButtonItem btnKhoa;
        private DevExpress.XtraBars.BarButtonItem btnMon;
        private DevExpress.XtraBars.BarButtonItem btnNhap;
        private DevExpress.XtraBars.BarButtonItem btnXem;
        private DevExpress.XtraBars.BarButtonItem btnTK;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}