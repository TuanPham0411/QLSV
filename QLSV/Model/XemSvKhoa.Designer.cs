namespace QLSV.Model
{
    partial class XemSvKhoa
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
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.qlsv = new QLSV.qlsv();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new QLSV.qlsvTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new QLSV.qlsvTableAdapters.TableAdapterManager();
            this.sinhVienTableAdapter = new QLSV.qlsvTableAdapters.SinhVienTableAdapter();
            this.cmbMakhoa = new System.Windows.Forms.ComboBox();
            this.cmbTenkhoa = new System.Windows.Forms.ComboBox();
            this.grvSv = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(26, 9);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(52, 13);
            maKhoaLabel.TabIndex = 1;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(26, 41);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(56, 13);
            tenKhoaLabel.TabIndex = 2;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // qlsv
            // 
            this.qlsv.DataSetName = "qlsv";
            this.qlsv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qlsv;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLSV.qlsvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMakhoa
            // 
            this.cmbMakhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "MaKhoa", true));
            this.cmbMakhoa.DataSource = this.kHOABindingSource;
            this.cmbMakhoa.DisplayMember = "MaKhoa";
            this.cmbMakhoa.Location = new System.Drawing.Point(84, 6);
            this.cmbMakhoa.Name = "cmbMakhoa";
            this.cmbMakhoa.Size = new System.Drawing.Size(178, 21);
            this.cmbMakhoa.TabIndex = 2;
            // 
            // cmbTenkhoa
            // 
            this.cmbTenkhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "TenKhoa", true));
            this.cmbTenkhoa.DataSource = this.kHOABindingSource;
            this.cmbTenkhoa.DisplayMember = "TenKhoa";
            this.cmbTenkhoa.Location = new System.Drawing.Point(84, 38);
            this.cmbTenkhoa.Name = "cmbTenkhoa";
            this.cmbTenkhoa.Size = new System.Drawing.Size(178, 21);
            this.cmbTenkhoa.TabIndex = 3;
            // 
            // grvSv
            // 
            this.grvSv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grvSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSv.Location = new System.Drawing.Point(12, 65);
            this.grvSv.Name = "grvSv";
            this.grvSv.Size = new System.Drawing.Size(351, 246);
            this.grvSv.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(279, 36);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(84, 23);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qlsv;
            // 
            // XemSvKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 323);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.grvSv);
            this.Controls.Add(tenKhoaLabel);
            this.Controls.Add(this.cmbTenkhoa);
            this.Controls.Add(maKhoaLabel);
            this.Controls.Add(this.cmbMakhoa);
            this.IconOptions.Image = global::QLSV.Properties.Resources.usergroup_32x32;
            this.Name = "XemSvKhoa";
            this.Text = "Xem Sinh viên theo Khoa";
            this.Load += new System.EventHandler(this.XemSvKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qlsv qlsv;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private qlsvTableAdapters.KHOATableAdapter kHOATableAdapter;
        private qlsvTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMakhoa;
        private System.Windows.Forms.ComboBox cmbTenkhoa;
        private System.Windows.Forms.DataGridView grvSv;
        private System.Windows.Forms.Button btnXem;
        private qlsvTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
    }
}