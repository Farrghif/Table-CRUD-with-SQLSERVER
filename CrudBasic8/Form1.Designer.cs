namespace CrudBasic8
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label jenis_kelaminLabel;
            System.Windows.Forms.Label kelasLabel;
            System.Windows.Forms.Label namaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siswaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.siswaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.siswaDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.jenis_kelaminTextBox = new System.Windows.Forms.TextBox();
            this.kelasTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.importBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            jenis_kelaminLabel = new System.Windows.Forms.Label();
            kelasLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingNavigator)).BeginInit();
            this.siswaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(864, 95);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // jenis_kelaminLabel
            // 
            jenis_kelaminLabel.AutoSize = true;
            jenis_kelaminLabel.Location = new System.Drawing.Point(864, 127);
            jenis_kelaminLabel.Name = "jenis_kelaminLabel";
            jenis_kelaminLabel.Size = new System.Drawing.Size(103, 20);
            jenis_kelaminLabel.TabIndex = 4;
            jenis_kelaminLabel.Text = "jenis kelamin:";
            // 
            // kelasLabel
            // 
            kelasLabel.AutoSize = true;
            kelasLabel.Location = new System.Drawing.Point(864, 159);
            kelasLabel.Name = "kelasLabel";
            kelasLabel.Size = new System.Drawing.Size(50, 20);
            kelasLabel.TabIndex = 6;
            kelasLabel.Text = "kelas:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(864, 191);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(53, 20);
            namaLabel.TabIndex = 8;
            namaLabel.Text = "nama:";
            // 
            // siswaBindingNavigator
            // 
            this.siswaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.siswaBindingNavigator.BindingSource = this.siswaBindingSource;
            this.siswaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.siswaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.siswaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.siswaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.siswaBindingNavigatorSaveItem});
            this.siswaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.siswaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.siswaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.siswaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.siswaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.siswaBindingNavigator.Name = "siswaBindingNavigator";
            this.siswaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.siswaBindingNavigator.Size = new System.Drawing.Size(1120, 38);
            this.siswaBindingNavigator.TabIndex = 0;
            this.siswaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // siswaBindingNavigatorSaveItem
            // 
            this.siswaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.siswaBindingNavigatorSaveItem.Enabled = false;
            this.siswaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("siswaBindingNavigatorSaveItem.Image")));
            this.siswaBindingNavigatorSaveItem.Name = "siswaBindingNavigatorSaveItem";
            this.siswaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.siswaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // siswaDataGridView
            // 
            this.siswaDataGridView.AutoGenerateColumns = false;
            this.siswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siswaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.siswaDataGridView.DataSource = this.siswaBindingSource;
            this.siswaDataGridView.Location = new System.Drawing.Point(12, 56);
            this.siswaDataGridView.Name = "siswaDataGridView";
            this.siswaDataGridView.RowHeadersWidth = 62;
            this.siswaDataGridView.RowTemplate.Height = 28;
            this.siswaDataGridView.Size = new System.Drawing.Size(701, 447);
            this.siswaDataGridView.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(973, 92);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 3;
            // 
            // jenis_kelaminTextBox
            // 
            this.jenis_kelaminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "jenis_kelamin", true));
            this.jenis_kelaminTextBox.Location = new System.Drawing.Point(973, 124);
            this.jenis_kelaminTextBox.Name = "jenis_kelaminTextBox";
            this.jenis_kelaminTextBox.Size = new System.Drawing.Size(100, 26);
            this.jenis_kelaminTextBox.TabIndex = 5;
            // 
            // kelasTextBox
            // 
            this.kelasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "kelas", true));
            this.kelasTextBox.Location = new System.Drawing.Point(973, 156);
            this.kelasTextBox.Name = "kelasTextBox";
            this.kelasTextBox.Size = new System.Drawing.Size(100, 26);
            this.kelasTextBox.TabIndex = 7;
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(973, 188);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(100, 26);
            this.namaTextBox.TabIndex = 9;
            // 
            // importBTN
            // 
            this.importBTN.Location = new System.Drawing.Point(997, 334);
            this.importBTN.Name = "importBTN";
            this.importBTN.Size = new System.Drawing.Size(76, 39);
            this.importBTN.TabIndex = 27;
            this.importBTN.Text = "import";
            this.importBTN.UseVisualStyleBackColor = true;
            this.importBTN.Click += new System.EventHandler(this.importBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(857, 334);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(76, 39);
            this.deleteBTN.TabIndex = 26;
            this.deleteBTN.Text = "delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(997, 273);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(76, 39);
            this.editBTN.TabIndex = 25;
            this.editBTN.Text = "edit";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(857, 273);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(76, 39);
            this.addBTN.TabIndex = 24;
            this.addBTN.Text = "add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(983, 419);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(116, 39);
            this.cancelBTN.TabIndex = 23;
            this.cancelBTN.Text = "cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(843, 419);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(113, 39);
            this.saveBTN.TabIndex = 22;
            this.saveBTN.Text = "save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataSource = typeof(CrudBasic8.Siswa);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kelas";
            this.dataGridViewTextBoxColumn3.HeaderText = "kelas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "jenis_kelamin";
            this.dataGridViewTextBoxColumn4.HeaderText = "jenis_kelamin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 529);
            this.Controls.Add(this.importBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(jenis_kelaminLabel);
            this.Controls.Add(this.jenis_kelaminTextBox);
            this.Controls.Add(kelasLabel);
            this.Controls.Add(this.kelasTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.siswaDataGridView);
            this.Controls.Add(this.siswaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingNavigator)).EndInit();
            this.siswaBindingNavigator.ResumeLayout(false);
            this.siswaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siswaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource siswaBindingSource;
        private System.Windows.Forms.BindingNavigator siswaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton siswaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView siswaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox jenis_kelaminTextBox;
        private System.Windows.Forms.TextBox kelasTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Button importBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button saveBTN;
    }
}

