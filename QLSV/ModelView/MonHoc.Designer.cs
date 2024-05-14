namespace QLSV.Model
{
    partial class MonHoc
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
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label tenMHLabel;
            System.Windows.Forms.Label soTietLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
            this.qlsv = new QLSV.qlsv();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monTableAdapter = new QLSV.qlsvTableAdapters.MonTableAdapter();
            this.tableAdapterManager = new QLSV.qlsvTableAdapters.TableAdapterManager();
            this.monBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.monBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maMHComboBox = new System.Windows.Forms.ComboBox();
            this.tenMHTextBox = new System.Windows.Forms.TextBox();
            this.soTietTextBox = new System.Windows.Forms.TextBox();
            this.monDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maMHLabel = new System.Windows.Forms.Label();
            tenMHLabel = new System.Windows.Forms.Label();
            soTietLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingNavigator)).BeginInit();
            this.monBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(48, 36);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(43, 13);
            maMHLabel.TabIndex = 1;
            maMHLabel.Text = "Mã MH:";
            // 
            // tenMHLabel
            // 
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(48, 63);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(47, 13);
            tenMHLabel.TabIndex = 3;
            tenMHLabel.Text = "Tên MH:";
            // 
            // soTietLabel
            // 
            soTietLabel.AutoSize = true;
            soTietLabel.Location = new System.Drawing.Point(48, 90);
            soTietLabel.Name = "soTietLabel";
            soTietLabel.Size = new System.Drawing.Size(44, 13);
            soTietLabel.TabIndex = 5;
            soTietLabel.Text = "Số Tiết:";
            // 
            // qlsv
            // 
            this.qlsv.DataSetName = "qlsv";
            this.qlsv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.qlsv;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = this.monTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV.qlsvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monBindingNavigator
            // 
            this.monBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.monBindingNavigator.BindingSource = this.monBindingSource;
            this.monBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.monBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.monBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.monBindingNavigatorSaveItem});
            this.monBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.monBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.monBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.monBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.monBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.monBindingNavigator.Name = "monBindingNavigator";
            this.monBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.monBindingNavigator.Size = new System.Drawing.Size(342, 25);
            this.monBindingNavigator.TabIndex = 0;
            this.monBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // monBindingNavigatorSaveItem
            // 
            this.monBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.monBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("monBindingNavigatorSaveItem.Image")));
            this.monBindingNavigatorSaveItem.Name = "monBindingNavigatorSaveItem";
            this.monBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.monBindingNavigatorSaveItem.Text = "Save Data";
            this.monBindingNavigatorSaveItem.Click += new System.EventHandler(this.monBindingNavigatorSaveItem_Click);
            // 
            // maMHComboBox
            // 
            this.maMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "MaMH", true));
            this.maMHComboBox.DataSource = this.monBindingSource;
            this.maMHComboBox.DisplayMember = "MaMH";
            this.maMHComboBox.Location = new System.Drawing.Point(97, 33);
            this.maMHComboBox.Name = "maMHComboBox";
            this.maMHComboBox.Size = new System.Drawing.Size(159, 21);
            this.maMHComboBox.TabIndex = 2;
            // 
            // tenMHTextBox
            // 
            this.tenMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "TenMH", true));
            this.tenMHTextBox.Location = new System.Drawing.Point(97, 60);
            this.tenMHTextBox.Name = "tenMHTextBox";
            this.tenMHTextBox.Size = new System.Drawing.Size(159, 21);
            this.tenMHTextBox.TabIndex = 4;
            // 
            // soTietTextBox
            // 
            this.soTietTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "SoTiet", true));
            this.soTietTextBox.Location = new System.Drawing.Point(98, 87);
            this.soTietTextBox.Name = "soTietTextBox";
            this.soTietTextBox.Size = new System.Drawing.Size(158, 21);
            this.soTietTextBox.TabIndex = 6;
            // 
            // monDataGridView
            // 
            this.monDataGridView.AutoGenerateColumns = false;
            this.monDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.monDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.monDataGridView.DataSource = this.monBindingSource;
            this.monDataGridView.Location = new System.Drawing.Point(12, 114);
            this.monDataGridView.Name = "monDataGridView";
            this.monDataGridView.Size = new System.Drawing.Size(318, 213);
            this.monDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaMH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenMH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoTiet";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoTiet";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 62;
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 339);
            this.Controls.Add(this.monDataGridView);
            this.Controls.Add(soTietLabel);
            this.Controls.Add(this.soTietTextBox);
            this.Controls.Add(tenMHLabel);
            this.Controls.Add(this.tenMHTextBox);
            this.Controls.Add(maMHLabel);
            this.Controls.Add(this.maMHComboBox);
            this.Controls.Add(this.monBindingNavigator);
            this.IconOptions.Image = global::QLSV.Properties.Resources.editname_32x32;
            this.Name = "MonHoc";
            this.Text = "Danh mục Môn học";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingNavigator)).EndInit();
            this.monBindingNavigator.ResumeLayout(false);
            this.monBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qlsv qlsv;
        private System.Windows.Forms.BindingSource monBindingSource;
        private qlsvTableAdapters.MonTableAdapter monTableAdapter;
        private qlsvTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator monBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton monBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox maMHComboBox;
        private System.Windows.Forms.TextBox tenMHTextBox;
        private System.Windows.Forms.TextBox soTietTextBox;
        private System.Windows.Forms.DataGridView monDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}