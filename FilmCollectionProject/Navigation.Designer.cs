namespace FilmCollectionProject
{
    partial class Navigation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filmsBtn = new System.Windows.Forms.Button();
            this.actorsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.directorsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.filmsBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.actorsBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoriesBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.directorsBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // filmsBtn
            // 
            this.filmsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filmsBtn.Location = new System.Drawing.Point(3, 3);
            this.filmsBtn.Name = "filmsBtn";
            this.filmsBtn.Size = new System.Drawing.Size(260, 219);
            this.filmsBtn.TabIndex = 0;
            this.filmsBtn.Text = "Films";
            this.filmsBtn.UseVisualStyleBackColor = true;
            this.filmsBtn.Click += new System.EventHandler(this.filmsBtn_Click);
            // 
            // actorsBtn
            // 
            this.actorsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorsBtn.Location = new System.Drawing.Point(269, 3);
            this.actorsBtn.Name = "actorsBtn";
            this.actorsBtn.Size = new System.Drawing.Size(260, 219);
            this.actorsBtn.TabIndex = 1;
            this.actorsBtn.Text = "Actors";
            this.actorsBtn.UseVisualStyleBackColor = true;
            this.actorsBtn.Click += new System.EventHandler(this.actorsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.Location = new System.Drawing.Point(535, 3);
            this.exitBtn.Name = "exitBtn";
            this.tableLayoutPanel1.SetRowSpan(this.exitBtn, 2);
            this.exitBtn.Size = new System.Drawing.Size(262, 444);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoriesBtn.Location = new System.Drawing.Point(3, 228);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(260, 219);
            this.categoriesBtn.TabIndex = 3;
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.UseVisualStyleBackColor = true;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // directorsBtn
            // 
            this.directorsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorsBtn.Location = new System.Drawing.Point(269, 228);
            this.directorsBtn.Name = "directorsBtn";
            this.directorsBtn.Size = new System.Drawing.Size(260, 219);
            this.directorsBtn.TabIndex = 4;
            this.directorsBtn.Text = "Directors";
            this.directorsBtn.UseVisualStyleBackColor = true;
            this.directorsBtn.Click += new System.EventHandler(this.directorsBtn_Click);
            // 
            // Nawigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Nawigation";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button filmsBtn;
        private System.Windows.Forms.Button actorsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button directorsBtn;
    }
}

