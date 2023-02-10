namespace FilmCollectionProject
{
    partial class Categories
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.netDataSet = new FilmCollectionProject.netDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new FilmCollectionProject.netDataSetTableAdapters.categoryTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.netDataSet1 = new FilmCollectionProject.netDataSet();
            this.editCategoryBtn = new System.Windows.Forms.Button();
            this.lblCategorySelected = new System.Windows.Forms.Label();
            this.categoryName2 = new System.Windows.Forms.TextBox();
            this.selectedCategory = new System.Windows.Forms.ComboBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.lblCategoryToAdd = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.removeCategoryBtn = new System.Windows.Forms.Button();
            this.lblCategoryToRemove = new System.Windows.Forms.Label();
            this.selectedCategory2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 4);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(371, 507);
            this.dataGridView1.TabIndex = 0;
            // 
            // netDataSet
            // 
            this.netDataSet.DataSetName = "netDataSet";
            this.netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.netDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.Location = new System.Drawing.Point(380, 387);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(561, 123);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.Controls.Add(this.addCategoryBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCategoryToAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.categoryName, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(380, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 122);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.editCategoryBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCategorySelected, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.categoryName2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.selectedCategory, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(380, 131);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 122);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // netDataSet1
            // 
            this.netDataSet1.DataSetName = "netDataSet";
            this.netDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editCategoryBtn
            // 
            this.editCategoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editCategoryBtn.Location = new System.Drawing.Point(376, 3);
            this.editCategoryBtn.Name = "editCategoryBtn";
            this.tableLayoutPanel3.SetRowSpan(this.editCategoryBtn, 2);
            this.editCategoryBtn.Size = new System.Drawing.Size(182, 116);
            this.editCategoryBtn.TabIndex = 0;
            this.editCategoryBtn.Text = "Edit";
            this.editCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // lblCategorySelected
            // 
            this.lblCategorySelected.AutoSize = true;
            this.lblCategorySelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategorySelected.Location = new System.Drawing.Point(3, 0);
            this.lblCategorySelected.Name = "lblCategorySelected";
            this.lblCategorySelected.Size = new System.Drawing.Size(180, 36);
            this.lblCategorySelected.TabIndex = 1;
            this.lblCategorySelected.Text = "Select Category To Edit:";
            this.lblCategorySelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryName2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.categoryName2, 2);
            this.categoryName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryName2.Location = new System.Drawing.Point(3, 39);
            this.categoryName2.Multiline = true;
            this.categoryName2.Name = "categoryName2";
            this.categoryName2.Size = new System.Drawing.Size(367, 80);
            this.categoryName2.TabIndex = 2;
            // 
            // selectedCategory
            // 
            this.selectedCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedCategory.FormattingEnabled = true;
            this.selectedCategory.Items.AddRange(new object[] {
            "Comedy",
            "Fantasy",
            "Drama"});
            this.selectedCategory.Location = new System.Drawing.Point(189, 3);
            this.selectedCategory.Name = "selectedCategory";
            this.selectedCategory.Size = new System.Drawing.Size(181, 24);
            this.selectedCategory.TabIndex = 3;
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCategoryBtn.Location = new System.Drawing.Point(377, 3);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.tableLayoutPanel2.SetRowSpan(this.addCategoryBtn, 2);
            this.addCategoryBtn.Size = new System.Drawing.Size(181, 116);
            this.addCategoryBtn.TabIndex = 0;
            this.addCategoryBtn.Text = "Add";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // lblCategoryToAdd
            // 
            this.lblCategoryToAdd.AutoSize = true;
            this.lblCategoryToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoryToAdd.Location = new System.Drawing.Point(3, 0);
            this.lblCategoryToAdd.Name = "lblCategoryToAdd";
            this.lblCategoryToAdd.Size = new System.Drawing.Size(368, 36);
            this.lblCategoryToAdd.TabIndex = 1;
            this.lblCategoryToAdd.Text = "Category Name:";
            this.lblCategoryToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryName
            // 
            this.categoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryName.Location = new System.Drawing.Point(3, 39);
            this.categoryName.Multiline = true;
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(368, 80);
            this.categoryName.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel4.Controls.Add(this.removeCategoryBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCategoryToRemove, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.selectedCategory2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(380, 259);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(561, 122);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // removeCategoryBtn
            // 
            this.removeCategoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeCategoryBtn.Location = new System.Drawing.Point(377, 3);
            this.removeCategoryBtn.Name = "removeCategoryBtn";
            this.tableLayoutPanel4.SetRowSpan(this.removeCategoryBtn, 2);
            this.removeCategoryBtn.Size = new System.Drawing.Size(181, 116);
            this.removeCategoryBtn.TabIndex = 0;
            this.removeCategoryBtn.Text = "Remove";
            this.removeCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // lblCategoryToRemove
            // 
            this.lblCategoryToRemove.AutoSize = true;
            this.lblCategoryToRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoryToRemove.Location = new System.Drawing.Point(3, 0);
            this.lblCategoryToRemove.Name = "lblCategoryToRemove";
            this.lblCategoryToRemove.Size = new System.Drawing.Size(368, 61);
            this.lblCategoryToRemove.TabIndex = 1;
            this.lblCategoryToRemove.Text = "Selecet Category To Remove:";
            this.lblCategoryToRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedCategory2
            // 
            this.selectedCategory2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCategory2.FormattingEnabled = true;
            this.selectedCategory2.Items.AddRange(new object[] {
            "Horror",
            "Comedy",
            "Fantasy"});
            this.selectedCategory2.Location = new System.Drawing.Point(3, 64);
            this.selectedCategory2.Name = "selectedCategory2";
            this.selectedCategory2.Size = new System.Drawing.Size(368, 24);
            this.selectedCategory2.TabIndex = 2;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private netDataSet netDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private netDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private netDataSet netDataSet1;
        private System.Windows.Forms.Button editCategoryBtn;
        private System.Windows.Forms.Label lblCategorySelected;
        private System.Windows.Forms.TextBox categoryName2;
        private System.Windows.Forms.ComboBox selectedCategory;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Label lblCategoryToAdd;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button removeCategoryBtn;
        private System.Windows.Forms.Label lblCategoryToRemove;
        private System.Windows.Forms.ComboBox selectedCategory2;
    }
}