namespace FilmCollectionProject
{
    partial class Directors
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netDataSet = new FilmCollectionProject.netDataSet();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDirectorToRemove = new System.Windows.Forms.Label();
            this.removeDirectorBtn = new System.Windows.Forms.Button();
            this.selectedDirector2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.directorTableAdapter = new FilmCollectionProject.netDataSetTableAdapters.directorTableAdapter();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.editDirectorBtn = new System.Windows.Forms.Button();
            this.addDirectorBtn = new System.Windows.Forms.Button();
            this.lblSelectedDirector = new System.Windows.Forms.Label();
            this.lblDirectorToEdit = new System.Windows.Forms.Label();
            this.lblDirectorToEdit2 = new System.Windows.Forms.Label();
            this.lblDirectorToAdd = new System.Windows.Forms.Label();
            this.lblDirectorToAdd2 = new System.Windows.Forms.Label();
            this.directorFirstNameToEdit = new System.Windows.Forms.TextBox();
            this.directorLastNameToEdit = new System.Windows.Forms.TextBox();
            this.directorFirstNameToAdd = new System.Windows.Forms.TextBox();
            this.directorLastNameToAdd = new System.Windows.Forms.TextBox();
            this.selectedDirector = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1330, 691);
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
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.directorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 4);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(632, 683);
            this.dataGridView1.TabIndex = 0;
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
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "director";
            this.directorBindingSource.DataSource = this.netDataSet;
            // 
            // netDataSet
            // 
            this.netDataSet.DataSetName = "netDataSet";
            this.netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBtn.Location = new System.Drawing.Point(641, 520);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(686, 167);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblDirectorToRemove, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.removeDirectorBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectedDirector2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(641, 348);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 164);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblDirectorToRemove
            // 
            this.lblDirectorToRemove.AutoSize = true;
            this.lblDirectorToRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectorToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectorToRemove.Location = new System.Drawing.Point(3, 0);
            this.lblDirectorToRemove.Name = "lblDirectorToRemove";
            this.lblDirectorToRemove.Size = new System.Drawing.Size(337, 82);
            this.lblDirectorToRemove.TabIndex = 0;
            this.lblDirectorToRemove.Text = "Select Director To Remove";
            this.lblDirectorToRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeDirectorBtn
            // 
            this.removeDirectorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeDirectorBtn.Location = new System.Drawing.Point(346, 4);
            this.removeDirectorBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeDirectorBtn.Name = "removeDirectorBtn";
            this.tableLayoutPanel2.SetRowSpan(this.removeDirectorBtn, 2);
            this.removeDirectorBtn.Size = new System.Drawing.Size(337, 156);
            this.removeDirectorBtn.TabIndex = 2;
            this.removeDirectorBtn.Text = "Remove";
            this.removeDirectorBtn.UseVisualStyleBackColor = true;
            this.removeDirectorBtn.Click += new System.EventHandler(this.removeDirectorBtn_Click);
            // 
            // selectedDirector2
            // 
            this.selectedDirector2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedDirector2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedDirector2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedDirector2.FormattingEnabled = true;
            this.selectedDirector2.Location = new System.Drawing.Point(3, 86);
            this.selectedDirector2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectedDirector2.Name = "selectedDirector2";
            this.selectedDirector2.Size = new System.Drawing.Size(337, 28);
            this.selectedDirector2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.23F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.Controls.Add(this.editDirectorBtn, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSelectedDirector, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDirectorToEdit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDirectorToEdit2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.directorFirstNameToEdit, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.directorLastNameToEdit, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.selectedDirector, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(641, 175);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(686, 166);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.addDirectorBtn, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDirectorToAdd, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDirectorToAdd2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.directorFirstNameToAdd, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.directorLastNameToAdd, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(641, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(686, 166);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // editDirectorBtn
            // 
            this.editDirectorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editDirectorBtn.Location = new System.Drawing.Point(459, 3);
            this.editDirectorBtn.Name = "editDirectorBtn";
            this.tableLayoutPanel3.SetRowSpan(this.editDirectorBtn, 2);
            this.editDirectorBtn.Size = new System.Drawing.Size(224, 160);
            this.editDirectorBtn.TabIndex = 0;
            this.editDirectorBtn.Text = "Edit";
            this.editDirectorBtn.UseVisualStyleBackColor = true;
            this.editDirectorBtn.Click += new System.EventHandler(this.editDirectorBtn_Click);
            // 
            // addDirectorBtn
            // 
            this.addDirectorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addDirectorBtn.Location = new System.Drawing.Point(459, 3);
            this.addDirectorBtn.Name = "addDirectorBtn";
            this.tableLayoutPanel4.SetRowSpan(this.addDirectorBtn, 2);
            this.addDirectorBtn.Size = new System.Drawing.Size(224, 160);
            this.addDirectorBtn.TabIndex = 0;
            this.addDirectorBtn.Text = "Add";
            this.addDirectorBtn.UseVisualStyleBackColor = true;
            this.addDirectorBtn.Click += new System.EventHandler(this.addDirectorBtn_Click);
            // 
            // lblSelectedDirector
            // 
            this.lblSelectedDirector.AutoSize = true;
            this.lblSelectedDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedDirector.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedDirector.Name = "lblSelectedDirector";
            this.lblSelectedDirector.Size = new System.Drawing.Size(146, 83);
            this.lblSelectedDirector.TabIndex = 1;
            this.lblSelectedDirector.Text = "Select Director To Edit:";
            this.lblSelectedDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirectorToEdit
            // 
            this.lblDirectorToEdit.AutoSize = true;
            this.lblDirectorToEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectorToEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectorToEdit.Location = new System.Drawing.Point(155, 0);
            this.lblDirectorToEdit.Name = "lblDirectorToEdit";
            this.lblDirectorToEdit.Size = new System.Drawing.Size(146, 83);
            this.lblDirectorToEdit.TabIndex = 2;
            this.lblDirectorToEdit.Text = "Director First Name:";
            this.lblDirectorToEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirectorToEdit2
            // 
            this.lblDirectorToEdit2.AutoSize = true;
            this.lblDirectorToEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectorToEdit2.Location = new System.Drawing.Point(307, 0);
            this.lblDirectorToEdit2.Name = "lblDirectorToEdit2";
            this.lblDirectorToEdit2.Size = new System.Drawing.Size(146, 83);
            this.lblDirectorToEdit2.TabIndex = 3;
            this.lblDirectorToEdit2.Text = "Director Last Name:";
            this.lblDirectorToEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirectorToAdd
            // 
            this.lblDirectorToAdd.AutoSize = true;
            this.lblDirectorToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectorToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectorToAdd.Location = new System.Drawing.Point(3, 0);
            this.lblDirectorToAdd.Name = "lblDirectorToAdd";
            this.lblDirectorToAdd.Size = new System.Drawing.Size(222, 83);
            this.lblDirectorToAdd.TabIndex = 1;
            this.lblDirectorToAdd.Text = "Director First Name:";
            this.lblDirectorToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirectorToAdd2
            // 
            this.lblDirectorToAdd2.AutoSize = true;
            this.lblDirectorToAdd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectorToAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectorToAdd2.Location = new System.Drawing.Point(231, 0);
            this.lblDirectorToAdd2.Name = "lblDirectorToAdd2";
            this.lblDirectorToAdd2.Size = new System.Drawing.Size(222, 83);
            this.lblDirectorToAdd2.TabIndex = 2;
            this.lblDirectorToAdd2.Text = "Director Last Name:";
            this.lblDirectorToAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directorFirstNameToEdit
            // 
            this.directorFirstNameToEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorFirstNameToEdit.Location = new System.Drawing.Point(155, 86);
            this.directorFirstNameToEdit.Multiline = true;
            this.directorFirstNameToEdit.Name = "directorFirstNameToEdit";
            this.directorFirstNameToEdit.Size = new System.Drawing.Size(146, 77);
            this.directorFirstNameToEdit.TabIndex = 4;
            // 
            // directorLastNameToEdit
            // 
            this.directorLastNameToEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorLastNameToEdit.Location = new System.Drawing.Point(307, 86);
            this.directorLastNameToEdit.Multiline = true;
            this.directorLastNameToEdit.Name = "directorLastNameToEdit";
            this.directorLastNameToEdit.Size = new System.Drawing.Size(146, 77);
            this.directorLastNameToEdit.TabIndex = 5;
            // 
            // directorFirstNameToAdd
            // 
            this.directorFirstNameToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorFirstNameToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorFirstNameToAdd.Location = new System.Drawing.Point(3, 86);
            this.directorFirstNameToAdd.Multiline = true;
            this.directorFirstNameToAdd.Name = "directorFirstNameToAdd";
            this.directorFirstNameToAdd.Size = new System.Drawing.Size(222, 77);
            this.directorFirstNameToAdd.TabIndex = 3;
            // 
            // directorLastNameToAdd
            // 
            this.directorLastNameToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorLastNameToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorLastNameToAdd.Location = new System.Drawing.Point(231, 86);
            this.directorLastNameToAdd.Multiline = true;
            this.directorLastNameToAdd.Name = "directorLastNameToAdd";
            this.directorLastNameToAdd.Size = new System.Drawing.Size(222, 77);
            this.directorLastNameToAdd.TabIndex = 4;
            // 
            // selectedDirector
            // 
            this.selectedDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedDirector.DropDownWidth = 200;
            this.selectedDirector.FormattingEnabled = true;
            this.selectedDirector.Location = new System.Drawing.Point(3, 86);
            this.selectedDirector.Name = "selectedDirector";
            this.selectedDirector.Size = new System.Drawing.Size(146, 28);
            this.selectedDirector.TabIndex = 6;
            // 
            // Directors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Directors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directors";
            this.Load += new System.EventHandler(this.Directors_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private netDataSet netDataSet;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private netDataSetTableAdapters.directorTableAdapter directorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDirectorToRemove;
        private System.Windows.Forms.Button removeDirectorBtn;
        private System.Windows.Forms.ComboBox selectedDirector2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button editDirectorBtn;
        private System.Windows.Forms.Button addDirectorBtn;
        private System.Windows.Forms.Label lblSelectedDirector;
        private System.Windows.Forms.Label lblDirectorToEdit;
        private System.Windows.Forms.Label lblDirectorToEdit2;
        private System.Windows.Forms.Label lblDirectorToAdd;
        private System.Windows.Forms.Label lblDirectorToAdd2;
        private System.Windows.Forms.TextBox directorFirstNameToEdit;
        private System.Windows.Forms.TextBox directorLastNameToEdit;
        private System.Windows.Forms.TextBox directorFirstNameToAdd;
        private System.Windows.Forms.TextBox directorLastNameToAdd;
        private System.Windows.Forms.ComboBox selectedDirector;
    }
}