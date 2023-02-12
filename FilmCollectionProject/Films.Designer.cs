namespace FilmCollectionProject
{
    partial class Films
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
            this.lblSelectedFilm = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.selectedFilm = new System.Windows.Forms.ComboBox();
            this.addFilmBtn = new System.Windows.Forms.Button();
            this.editFilmBtn = new System.Windows.Forms.Button();
            this.removeFilmBtn = new System.Windows.Forms.Button();
            this.actorsList = new System.Windows.Forms.ListBox();
            this.directorsList = new System.Windows.Forms.ListBox();
            this.categoriesList = new System.Windows.Forms.ListBox();
            this.removeActorBtn = new System.Windows.Forms.Button();
            this.removeDirectorBtn = new System.Windows.Forms.Button();
            this.removeCategoryBtn = new System.Windows.Forms.Button();
            this.addActorBtn = new System.Windows.Forms.Button();
            this.addDirectorBtn = new System.Windows.Forms.Button();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.selectedActor = new System.Windows.Forms.ComboBox();
            this.selectedDirector = new System.Windows.Forms.ComboBox();
            this.selectedCategory = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.netDataSet = new FilmCollectionProject.netDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new FilmCollectionProject.netDataSetTableAdapters.filmTableAdapter();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorTableAdapter = new FilmCollectionProject.netDataSetTableAdapters.actorTableAdapter();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorTableAdapter = new FilmCollectionProject.netDataSetTableAdapters.directorTableAdapter();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new FilmCollectionProject.netDataSetTableAdapters.categoryTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblSelectedFilm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDuration, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblYear, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblActors, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDirectors, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategories, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.duration, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.year, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.selectedFilm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addFilmBtn, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.editFilmBtn, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.removeFilmBtn, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.actorsList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.directorsList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.categoriesList, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeActorBtn, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.removeDirectorBtn, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.removeCategoryBtn, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.addActorBtn, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.addDirectorBtn, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.addCategoryBtn, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.selectedActor, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.selectedDirector, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.selectedCategory, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1330, 691);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSelectedFilm
            // 
            this.lblSelectedFilm.AutoSize = true;
            this.lblSelectedFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedFilm.Location = new System.Drawing.Point(3, 62);
            this.lblSelectedFilm.Name = "lblSelectedFilm";
            this.lblSelectedFilm.Size = new System.Drawing.Size(326, 55);
            this.lblSelectedFilm.TabIndex = 0;
            this.lblSelectedFilm.Text = "Select Film:";
            this.lblSelectedFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(3, 172);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDuration.Location = new System.Drawing.Point(3, 282);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(326, 55);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYear.Location = new System.Drawing.Point(3, 392);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(326, 55);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActors.Location = new System.Drawing.Point(335, 0);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(326, 62);
            this.lblActors.TabIndex = 4;
            this.lblActors.Text = "Actors:";
            this.lblActors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectors.Location = new System.Drawing.Point(667, 0);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(326, 62);
            this.lblDirectors.TabIndex = 5;
            this.lblDirectors.Text = "Directors:";
            this.lblDirectors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategories.Location = new System.Drawing.Point(999, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(328, 62);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Categories:";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(3, 227);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(326, 55);
            this.title.TabIndex = 8;
            this.title.Text = "-";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.duration.Location = new System.Drawing.Point(3, 337);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(326, 55);
            this.duration.TabIndex = 9;
            this.duration.Text = "-";
            this.duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.year.Location = new System.Drawing.Point(3, 447);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(326, 55);
            this.year.TabIndex = 10;
            this.year.Text = "-";
            this.year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedFilm
            // 
            this.selectedFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedFilm.DropDownWidth = 300;
            this.selectedFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedFilm.FormattingEnabled = true;
            this.selectedFilm.Location = new System.Drawing.Point(3, 120);
            this.selectedFilm.Name = "selectedFilm";
            this.selectedFilm.Size = new System.Drawing.Size(326, 28);
            this.selectedFilm.TabIndex = 11;
            this.selectedFilm.SelectedIndexChanged += new System.EventHandler(this.selectedFilm_SelectedIndexChanged);
            // 
            // addFilmBtn
            // 
            this.addFilmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFilmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addFilmBtn.Location = new System.Drawing.Point(3, 505);
            this.addFilmBtn.Name = "addFilmBtn";
            this.addFilmBtn.Size = new System.Drawing.Size(326, 56);
            this.addFilmBtn.TabIndex = 12;
            this.addFilmBtn.Text = "Add Film";
            this.addFilmBtn.UseVisualStyleBackColor = true;
            this.addFilmBtn.Click += new System.EventHandler(this.addFilmBtn_Click);
            // 
            // editFilmBtn
            // 
            this.editFilmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editFilmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editFilmBtn.Location = new System.Drawing.Point(3, 567);
            this.editFilmBtn.Name = "editFilmBtn";
            this.editFilmBtn.Size = new System.Drawing.Size(326, 56);
            this.editFilmBtn.TabIndex = 13;
            this.editFilmBtn.Text = "Edit Film";
            this.editFilmBtn.UseVisualStyleBackColor = true;
            this.editFilmBtn.Click += new System.EventHandler(this.editFilmBtn_Click);
            // 
            // removeFilmBtn
            // 
            this.removeFilmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeFilmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeFilmBtn.Location = new System.Drawing.Point(3, 629);
            this.removeFilmBtn.Name = "removeFilmBtn";
            this.removeFilmBtn.Size = new System.Drawing.Size(326, 59);
            this.removeFilmBtn.TabIndex = 14;
            this.removeFilmBtn.Text = "Remove Film";
            this.removeFilmBtn.UseVisualStyleBackColor = true;
            this.removeFilmBtn.Click += new System.EventHandler(this.removeFilmBtn_Click);
            // 
            // actorsList
            // 
            this.actorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorsList.FormattingEnabled = true;
            this.actorsList.ItemHeight = 20;
            this.actorsList.Location = new System.Drawing.Point(335, 65);
            this.actorsList.Name = "actorsList";
            this.tableLayoutPanel1.SetRowSpan(this.actorsList, 8);
            this.actorsList.Size = new System.Drawing.Size(326, 434);
            this.actorsList.TabIndex = 15;
            // 
            // directorsList
            // 
            this.directorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorsList.FormattingEnabled = true;
            this.directorsList.ItemHeight = 20;
            this.directorsList.Location = new System.Drawing.Point(667, 65);
            this.directorsList.Name = "directorsList";
            this.tableLayoutPanel1.SetRowSpan(this.directorsList, 8);
            this.directorsList.Size = new System.Drawing.Size(326, 434);
            this.directorsList.TabIndex = 16;
            // 
            // categoriesList
            // 
            this.categoriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.ItemHeight = 20;
            this.categoriesList.Location = new System.Drawing.Point(999, 65);
            this.categoriesList.Name = "categoriesList";
            this.tableLayoutPanel1.SetRowSpan(this.categoriesList, 8);
            this.categoriesList.Size = new System.Drawing.Size(328, 434);
            this.categoriesList.TabIndex = 17;
            // 
            // removeActorBtn
            // 
            this.removeActorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeActorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeActorBtn.Location = new System.Drawing.Point(335, 505);
            this.removeActorBtn.Name = "removeActorBtn";
            this.removeActorBtn.Size = new System.Drawing.Size(326, 56);
            this.removeActorBtn.TabIndex = 18;
            this.removeActorBtn.Text = "Remove Actor";
            this.removeActorBtn.UseVisualStyleBackColor = true;
            this.removeActorBtn.Click += new System.EventHandler(this.removeActorBtn_Click);
            // 
            // removeDirectorBtn
            // 
            this.removeDirectorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeDirectorBtn.Location = new System.Drawing.Point(667, 505);
            this.removeDirectorBtn.Name = "removeDirectorBtn";
            this.removeDirectorBtn.Size = new System.Drawing.Size(326, 56);
            this.removeDirectorBtn.TabIndex = 19;
            this.removeDirectorBtn.Text = "Remove Director";
            this.removeDirectorBtn.UseVisualStyleBackColor = true;
            this.removeDirectorBtn.Click += new System.EventHandler(this.removeDirectorBtn_Click);
            // 
            // removeCategoryBtn
            // 
            this.removeCategoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeCategoryBtn.Location = new System.Drawing.Point(999, 505);
            this.removeCategoryBtn.Name = "removeCategoryBtn";
            this.removeCategoryBtn.Size = new System.Drawing.Size(328, 56);
            this.removeCategoryBtn.TabIndex = 20;
            this.removeCategoryBtn.Text = "Remove Category";
            this.removeCategoryBtn.UseVisualStyleBackColor = true;
            this.removeCategoryBtn.Click += new System.EventHandler(this.removeCategoryBtn_Click);
            // 
            // addActorBtn
            // 
            this.addActorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addActorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addActorBtn.Location = new System.Drawing.Point(335, 629);
            this.addActorBtn.Name = "addActorBtn";
            this.addActorBtn.Size = new System.Drawing.Size(326, 59);
            this.addActorBtn.TabIndex = 21;
            this.addActorBtn.Text = "Add Actor";
            this.addActorBtn.UseVisualStyleBackColor = true;
            this.addActorBtn.Click += new System.EventHandler(this.addActorBtn_Click);
            // 
            // addDirectorBtn
            // 
            this.addDirectorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addDirectorBtn.Location = new System.Drawing.Point(667, 629);
            this.addDirectorBtn.Name = "addDirectorBtn";
            this.addDirectorBtn.Size = new System.Drawing.Size(326, 59);
            this.addDirectorBtn.TabIndex = 22;
            this.addDirectorBtn.Text = "Add Director";
            this.addDirectorBtn.UseVisualStyleBackColor = true;
            this.addDirectorBtn.Click += new System.EventHandler(this.addDirectorBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCategoryBtn.Location = new System.Drawing.Point(999, 629);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(328, 59);
            this.addCategoryBtn.TabIndex = 23;
            this.addCategoryBtn.Text = "Add Director";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // selectedActor
            // 
            this.selectedActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedActor.FormattingEnabled = true;
            this.selectedActor.Location = new System.Drawing.Point(335, 567);
            this.selectedActor.Name = "selectedActor";
            this.selectedActor.Size = new System.Drawing.Size(326, 28);
            this.selectedActor.TabIndex = 24;
            // 
            // selectedDirector
            // 
            this.selectedDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedDirector.FormattingEnabled = true;
            this.selectedDirector.Location = new System.Drawing.Point(667, 567);
            this.selectedDirector.Name = "selectedDirector";
            this.selectedDirector.Size = new System.Drawing.Size(326, 28);
            this.selectedDirector.TabIndex = 25;
            // 
            // selectedCategory
            // 
            this.selectedCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedCategory.FormattingEnabled = true;
            this.selectedCategory.Location = new System.Drawing.Point(999, 567);
            this.selectedCategory.Name = "selectedCategory";
            this.selectedCategory.Size = new System.Drawing.Size(328, 28);
            this.selectedCategory.TabIndex = 26;
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(326, 56);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // netDataSet
            // 
            this.netDataSet.DataSetName = "netDataSet";
            this.netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "film";
            this.filmBindingSource.DataSource = this.netDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "actor";
            this.actorBindingSource.DataSource = this.netDataSet;
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "director";
            this.directorBindingSource.DataSource = this.netDataSet;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
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
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Films";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Films_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSelectedFilm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.ComboBox selectedFilm;
        private System.Windows.Forms.Button addFilmBtn;
        private System.Windows.Forms.Button editFilmBtn;
        private System.Windows.Forms.Button removeFilmBtn;
        private System.Windows.Forms.ListBox actorsList;
        private System.Windows.Forms.ListBox directorsList;
        private System.Windows.Forms.ListBox categoriesList;
        private System.Windows.Forms.Button removeActorBtn;
        private System.Windows.Forms.Button removeDirectorBtn;
        private System.Windows.Forms.Button removeCategoryBtn;
        private System.Windows.Forms.Button addActorBtn;
        private System.Windows.Forms.Button addDirectorBtn;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.ComboBox selectedActor;
        private System.Windows.Forms.ComboBox selectedDirector;
        private System.Windows.Forms.ComboBox selectedCategory;
        private System.Windows.Forms.Button backBtn;
        private netDataSet netDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private netDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private netDataSetTableAdapters.actorTableAdapter actorTableAdapter;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private netDataSetTableAdapters.directorTableAdapter directorTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private netDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
    }
}