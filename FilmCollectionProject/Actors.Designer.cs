namespace FilmCollectionProject
{
    partial class Actors
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
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netDataSet = new FilmCollectionProject.netDataSet();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.removeActorBtn = new System.Windows.Forms.Button();
            this.lblActorToRemove = new System.Windows.Forms.Label();
            this.selectedActor2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActorToAdd = new System.Windows.Forms.Label();
            this.lblActorToAdd2 = new System.Windows.Forms.Label();
            this.addActorBtn = new System.Windows.Forms.Button();
            this.actorFirstNameToAdd = new System.Windows.Forms.TextBox();
            this.actorLastNameToAdd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.editActorBtn = new System.Windows.Forms.Button();
            this.lblSelectedActor = new System.Windows.Forms.Label();
            this.lblActorToEdit = new System.Windows.Forms.Label();
            this.lblActorToEdit2 = new System.Windows.Forms.Label();
            this.actorLastNameToEdit = new System.Windows.Forms.TextBox();
            this.actorFirstNameToEdit = new System.Windows.Forms.TextBox();
            this.selectedActor = new System.Windows.Forms.ComboBox();
            this.actorTableAdapter = new FilmCollectionProject.netDataSetTableAdapters.actorTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
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
            this.dataGridView1.DataSource = this.actorBindingSource;
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
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "actor";
            this.actorBindingSource.DataSource = this.netDataSet;
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
            this.tableLayoutPanel2.Controls.Add(this.removeActorBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblActorToRemove, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectedActor2, 0, 1);
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
            // removeActorBtn
            // 
            this.removeActorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeActorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeActorBtn.Location = new System.Drawing.Point(346, 4);
            this.removeActorBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeActorBtn.Name = "removeActorBtn";
            this.tableLayoutPanel2.SetRowSpan(this.removeActorBtn, 2);
            this.removeActorBtn.Size = new System.Drawing.Size(337, 156);
            this.removeActorBtn.TabIndex = 0;
            this.removeActorBtn.Text = "Remove";
            this.removeActorBtn.UseVisualStyleBackColor = true;
            this.removeActorBtn.Click += new System.EventHandler(this.removeActorBtn_Click);
            // 
            // lblActorToRemove
            // 
            this.lblActorToRemove.AutoSize = true;
            this.lblActorToRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActorToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActorToRemove.Location = new System.Drawing.Point(3, 0);
            this.lblActorToRemove.Name = "lblActorToRemove";
            this.lblActorToRemove.Size = new System.Drawing.Size(337, 82);
            this.lblActorToRemove.TabIndex = 1;
            this.lblActorToRemove.Text = "Select Actor To Remove:";
            this.lblActorToRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedActor2
            // 
            this.selectedActor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedActor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedActor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedActor2.FormattingEnabled = true;
            this.selectedActor2.Location = new System.Drawing.Point(3, 86);
            this.selectedActor2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectedActor2.Name = "selectedActor2";
            this.selectedActor2.Size = new System.Drawing.Size(337, 28);
            this.selectedActor2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.lblActorToAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblActorToAdd2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.addActorBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.actorFirstNameToAdd, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.actorLastNameToAdd, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(641, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(686, 164);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lblActorToAdd
            // 
            this.lblActorToAdd.AutoSize = true;
            this.lblActorToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActorToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActorToAdd.Location = new System.Drawing.Point(3, 0);
            this.lblActorToAdd.Name = "lblActorToAdd";
            this.lblActorToAdd.Size = new System.Drawing.Size(222, 82);
            this.lblActorToAdd.TabIndex = 0;
            this.lblActorToAdd.Text = "Actor First Name:";
            this.lblActorToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActorToAdd2
            // 
            this.lblActorToAdd2.AutoSize = true;
            this.lblActorToAdd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActorToAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActorToAdd2.Location = new System.Drawing.Point(231, 0);
            this.lblActorToAdd2.Name = "lblActorToAdd2";
            this.lblActorToAdd2.Size = new System.Drawing.Size(222, 82);
            this.lblActorToAdd2.TabIndex = 1;
            this.lblActorToAdd2.Text = "Actor Last Name:";
            this.lblActorToAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addActorBtn
            // 
            this.addActorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addActorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addActorBtn.Location = new System.Drawing.Point(459, 4);
            this.addActorBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addActorBtn.Name = "addActorBtn";
            this.tableLayoutPanel3.SetRowSpan(this.addActorBtn, 2);
            this.addActorBtn.Size = new System.Drawing.Size(224, 156);
            this.addActorBtn.TabIndex = 2;
            this.addActorBtn.Text = "Add";
            this.addActorBtn.UseVisualStyleBackColor = true;
            this.addActorBtn.Click += new System.EventHandler(this.addActorBtn_Click);
            // 
            // actorFirstNameToAdd
            // 
            this.actorFirstNameToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorFirstNameToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorFirstNameToAdd.Location = new System.Drawing.Point(3, 86);
            this.actorFirstNameToAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actorFirstNameToAdd.Multiline = true;
            this.actorFirstNameToAdd.Name = "actorFirstNameToAdd";
            this.actorFirstNameToAdd.Size = new System.Drawing.Size(222, 74);
            this.actorFirstNameToAdd.TabIndex = 3;
            // 
            // actorLastNameToAdd
            // 
            this.actorLastNameToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorLastNameToAdd.Location = new System.Drawing.Point(231, 86);
            this.actorLastNameToAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actorLastNameToAdd.Multiline = true;
            this.actorLastNameToAdd.Name = "actorLastNameToAdd";
            this.actorLastNameToAdd.Size = new System.Drawing.Size(222, 74);
            this.actorLastNameToAdd.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.23F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel4.Controls.Add(this.editActorBtn, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblSelectedActor, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblActorToEdit, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblActorToEdit2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.actorLastNameToEdit, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.actorFirstNameToEdit, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.selectedActor, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(641, 176);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(686, 164);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // editActorBtn
            // 
            this.editActorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editActorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editActorBtn.Location = new System.Drawing.Point(459, 4);
            this.editActorBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editActorBtn.Name = "editActorBtn";
            this.tableLayoutPanel4.SetRowSpan(this.editActorBtn, 2);
            this.editActorBtn.Size = new System.Drawing.Size(224, 156);
            this.editActorBtn.TabIndex = 0;
            this.editActorBtn.Text = "Edit";
            this.editActorBtn.UseVisualStyleBackColor = true;
            this.editActorBtn.Click += new System.EventHandler(this.editActorBtn_Click);
            // 
            // lblSelectedActor
            // 
            this.lblSelectedActor.AutoSize = true;
            this.lblSelectedActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedActor.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedActor.Name = "lblSelectedActor";
            this.lblSelectedActor.Size = new System.Drawing.Size(146, 82);
            this.lblSelectedActor.TabIndex = 1;
            this.lblSelectedActor.Text = "Select Actor To Edit:";
            this.lblSelectedActor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActorToEdit
            // 
            this.lblActorToEdit.AutoSize = true;
            this.lblActorToEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActorToEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActorToEdit.Location = new System.Drawing.Point(155, 0);
            this.lblActorToEdit.Name = "lblActorToEdit";
            this.lblActorToEdit.Size = new System.Drawing.Size(146, 82);
            this.lblActorToEdit.TabIndex = 2;
            this.lblActorToEdit.Text = "Actor First Name:";
            this.lblActorToEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActorToEdit2
            // 
            this.lblActorToEdit2.AutoSize = true;
            this.lblActorToEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActorToEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActorToEdit2.Location = new System.Drawing.Point(307, 0);
            this.lblActorToEdit2.Name = "lblActorToEdit2";
            this.lblActorToEdit2.Size = new System.Drawing.Size(146, 82);
            this.lblActorToEdit2.TabIndex = 3;
            this.lblActorToEdit2.Text = "Actor Last Name:";
            this.lblActorToEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actorLastNameToEdit
            // 
            this.actorLastNameToEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorLastNameToEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorLastNameToEdit.Location = new System.Drawing.Point(307, 86);
            this.actorLastNameToEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actorLastNameToEdit.Multiline = true;
            this.actorLastNameToEdit.Name = "actorLastNameToEdit";
            this.actorLastNameToEdit.Size = new System.Drawing.Size(146, 74);
            this.actorLastNameToEdit.TabIndex = 4;
            // 
            // actorFirstNameToEdit
            // 
            this.actorFirstNameToEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorFirstNameToEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorFirstNameToEdit.Location = new System.Drawing.Point(155, 86);
            this.actorFirstNameToEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actorFirstNameToEdit.Multiline = true;
            this.actorFirstNameToEdit.Name = "actorFirstNameToEdit";
            this.actorFirstNameToEdit.Size = new System.Drawing.Size(146, 74);
            this.actorFirstNameToEdit.TabIndex = 5;
            // 
            // selectedActor
            // 
            this.selectedActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedActor.DropDownWidth = 150;
            this.selectedActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedActor.FormattingEnabled = true;
            this.selectedActor.Location = new System.Drawing.Point(3, 86);
            this.selectedActor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectedActor.Name = "selectedActor";
            this.selectedActor.Size = new System.Drawing.Size(146, 28);
            this.selectedActor.TabIndex = 6;
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Actors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actors";
            this.Load += new System.EventHandler(this.Actors_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource actorBindingSource;
        private netDataSetTableAdapters.actorTableAdapter actorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button removeActorBtn;
        private System.Windows.Forms.Label lblActorToRemove;
        private System.Windows.Forms.ComboBox selectedActor2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblActorToAdd;
        private System.Windows.Forms.Label lblActorToAdd2;
        private System.Windows.Forms.Button addActorBtn;
        private System.Windows.Forms.TextBox actorFirstNameToAdd;
        private System.Windows.Forms.TextBox actorLastNameToAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button editActorBtn;
        private System.Windows.Forms.Label lblSelectedActor;
        private System.Windows.Forms.Label lblActorToEdit;
        private System.Windows.Forms.Label lblActorToEdit2;
        private System.Windows.Forms.TextBox actorLastNameToEdit;
        private System.Windows.Forms.TextBox actorFirstNameToEdit;
        private System.Windows.Forms.ComboBox selectedActor;
    }
}