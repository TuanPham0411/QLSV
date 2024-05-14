namespace QLSV.Model
{
    partial class NhapDiem
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
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label tenMHLabel;
            this.qlsv = new QLSV.qlsv();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QLSV.qlsvTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new QLSV.qlsvTableAdapters.TableAdapterManager();
            this.monTableAdapter = new QLSV.qlsvTableAdapters.MonTableAdapter();
            this.cmbMaso = new System.Windows.Forms.ComboBox();
            this.cmbHoten = new System.Windows.Forms.ComboBox();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaTableAdapter = new QLSV.qlsvTableAdapters.KetQuaTableAdapter();
            maSoLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            tenMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(34, 15);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(40, 13);
            maSoLabel.TabIndex = 1;
            maSoLabel.Text = "Mã Số:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(34, 42);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(45, 13);
            hoTenLabel.TabIndex = 2;
            hoTenLabel.Text = "Họ Tên:";
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(34, 69);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(43, 13);
            maMHLabel.TabIndex = 4;
            maMHLabel.Text = "Mã MH:";
            // 
            // tenMHLabel
            // 
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(34, 96);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(47, 13);
            tenMHLabel.TabIndex = 6;
            tenMHLabel.Text = "Tên MH:";
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
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = this.monTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLSV.qlsvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMaso
            // 
            this.cmbMaso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSo", true));
            this.cmbMaso.DataSource = this.sinhVienBindingSource;
            this.cmbMaso.DisplayMember = "MaSo";
            this.cmbMaso.Location = new System.Drawing.Point(85, 12);
            this.cmbMaso.Name = "cmbMaso";
            this.cmbMaso.Size = new System.Drawing.Size(155, 21);
            this.cmbMaso.TabIndex = 2;
            // 
            // cmbHoten
            // 
            this.cmbHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "HoTen", true));
            this.cmbHoten.DataSource = this.sinhVienBindingSource;
            this.cmbHoten.DisplayMember = "HoTen";
            this.cmbHoten.Location = new System.Drawing.Point(85, 39);
            this.cmbHoten.Name = "cmbHoten";
            this.cmbHoten.Size = new System.Drawing.Size(155, 21);
            this.cmbHoten.TabIndex = 3;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.qlsv;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "MaMH", true));
            this.cmbMaMH.DataSource = this.monBindingSource;
            this.cmbMaMH.DisplayMember = "MaMH";
            this.cmbMaMH.Location = new System.Drawing.Point(85, 66);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(155, 21);
            this.cmbMaMH.TabIndex = 5;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "TenMH", true));
            this.cmbTenMH.DataSource = this.monBindingSource;
            this.cmbTenMH.DisplayMember = "TenMH";
            this.cmbTenMH.Location = new System.Drawing.Point(85, 93);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(155, 21);
            this.cmbTenMH.TabIndex = 7;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(85, 120);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(71, 21);
            this.txtDiem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Điểm:";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(163, 147);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(77, 23);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.qlsv;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 189);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(tenMHLabel);
            this.Controls.Add(this.cmbTenMH);
            this.Controls.Add(maMHLabel);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.cmbHoten);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(this.cmbMaso);
            this.IconOptions.Image = global::QLSV.Properties.Resources.insert_32x32;
            this.Name = "NhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
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
        private qlsvTableAdapters.MonTableAdapter monTableAdapter;
        private System.Windows.Forms.BindingSource monBindingSource;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private qlsvTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
    }
}