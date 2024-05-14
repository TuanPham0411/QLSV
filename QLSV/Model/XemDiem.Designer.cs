namespace QLSV.Model
{
    partial class XemDiem
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
            System.Windows.Forms.Label maSoLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.qlsv = new QLSV.qlsv();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QLSV.qlsvTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new QLSV.qlsvTableAdapters.TableAdapterManager();
            this.ketQuaTableAdapter = new QLSV.qlsvTableAdapters.KetQuaTableAdapter();
            this.kHOATableAdapter = new QLSV.qlsvTableAdapters.KHOATableAdapter();
            this.cmbMaso = new System.Windows.Forms.ComboBox();
            this.cmbHoten = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvDiem = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            maSoLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(29, 15);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(40, 13);
            maSoLabel.TabIndex = 1;
            maSoLabel.Text = "Mã Số:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(29, 42);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(45, 13);
            hoTenLabel.TabIndex = 2;
            hoTenLabel.Text = "Họ Tên:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(29, 69);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(56, 13);
            tenKhoaLabel.TabIndex = 4;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // qlsv
            // 
            this.qlsv.DataSetName = "qlsv";
            this.qlsv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qlsv;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = this.ketQuaTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLSV.qlsvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // cmbMaso
            // 
            this.cmbMaso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSo", true));
            this.cmbMaso.DataSource = this.sinhVienBindingSource;
            this.cmbMaso.DisplayMember = "MaSo";
            this.cmbMaso.Location = new System.Drawing.Point(91, 12);
            this.cmbMaso.Name = "cmbMaso";
            this.cmbMaso.Size = new System.Drawing.Size(149, 21);
            this.cmbMaso.TabIndex = 2;
            // 
            // cmbHoten
            // 
            this.cmbHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "HoTen", true));
            this.cmbHoten.DataSource = this.sinhVienBindingSource;
            this.cmbHoten.DisplayMember = "HoTen";
            this.cmbHoten.Location = new System.Drawing.Point(91, 39);
            this.cmbHoten.Name = "cmbHoten";
            this.cmbHoten.Size = new System.Drawing.Size(149, 21);
            this.cmbHoten.TabIndex = 3;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qlsv;
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "TenKhoa", true));
            this.txtTenkhoa.Location = new System.Drawing.Point(91, 66);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.Size = new System.Drawing.Size(149, 21);
            this.txtTenkhoa.TabIndex = 5;
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.qlsv;
            // 
            // grvDiem
            // 
            this.grvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDiem.Location = new System.Drawing.Point(12, 93);
            this.grvDiem.Name = "grvDiem";
            this.grvDiem.Size = new System.Drawing.Size(309, 217);
            this.grvDiem.TabIndex = 6;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(246, 66);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 322);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.grvDiem);
            this.Controls.Add(tenKhoaLabel);
            this.Controls.Add(this.txtTenkhoa);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.cmbHoten);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(this.cmbMaso);
            this.IconOptions.Image = global::QLSV.Properties.Resources.forcetesting_32x32;
            this.Name = "XemDiem";
            this.Text = "Xem Điểm";
            this.Load += new System.EventHandler(this.XemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qlsv qlsv;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private qlsvTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private qlsvTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMaso;
        private System.Windows.Forms.ComboBox cmbHoten;
        private qlsvTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private qlsvTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private System.Windows.Forms.DataGridView grvDiem;
        private System.Windows.Forms.Button btnXem;
    }
}