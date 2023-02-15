using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FilmCollectionProject
{
    enum FilmRelationEnum
    {
        ActorsRelation,
        DirectorsRelation,
        CategoriesRelations
    }

    public partial class Films : Form
    {
        private String connectionString;
        private String filmId;

        private List<string> actorsIds = new List<string>();
        private List<string> directorsIds = new List<string>();
        private List<string> categoriesIds = new List<string>();


        public Films()
        {
            InitializeComponent();
            this.Load += InitComboBoxes;
            this.connectionString = ConfigurationManager.ConnectionStrings["FilmCollectionProject.Properties.Settings.netConnectionString"].ConnectionString;
        }

        private void InitComboBoxes(object sender, EventArgs e)
        {
            netDataSet.filmRow[] filmsNameArray = this.netDataSet.film.ToArray();
            netDataSet.actorRow[] actorsNameArray = this.netDataSet.actor.ToArray();
            netDataSet.directorRow[] directorsNameArray = this.netDataSet.director.ToArray();
            netDataSet.categoryRow[] categoriesNameArray = this.netDataSet.category.ToArray();

            for (int i = 0; i < filmsNameArray.Length; i++)
            {
                this.selectedFilm.Items.Add(filmsNameArray[i].name);
            }

            for (int i = 0; i < actorsNameArray.Length; i++)
            {
                this.selectedActor.Items.Add(actorsNameArray[i].first_name + ' ' + actorsNameArray[i].last_name);
            }

            for (int i = 0; i < directorsNameArray.Length; i++)
            {
                this.selectedDirector.Items.Add(directorsNameArray[i].first_name + ' ' + directorsNameArray[i].last_name);
            }

            for (int i = 0; i < categoriesNameArray.Length; i++)
            {
                this.selectedCategory.Items.Add(categoriesNameArray[i].name);
            }
        }


        private void refreshData()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                String sql = "SELECT * from film";
                SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "film");
                this.selectedFilm.Items.Clear();
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    this.selectedFilm.Items.Add(row.ItemArray[2]);
                }
            }
        }

        private void resetControls()
        {
            this.title.Text = "";
            this.duration.Text = "";
            this.year.Text = "";

            this.actorsList.Items.Clear();
            this.directorsList.Items.Clear();
            this.categoriesList.Items.Clear();

            this.title.ReadOnly = false;
            this.duration.ReadOnly = false;
            this.year.ReadOnly = false;

            this.editFilmBtn.Text = "Start Editing Film";
            this.editFilmBtn.Enabled = false;
        }

        private void removeFilmRelation(String sql, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add(new SqlParameter("@filmId", SqlDbType.VarChar));
                command.Parameters["@filmId"].Value = this.filmId;
                command.ExecuteReader();
            }
        }

        private void createFilmRelation(FilmRelationEnum relationToCreate, String sql, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add(new SqlParameter("@filmId", SqlDbType.VarChar));
                command.Parameters["@filmId"].Value = this.filmId;

                if(relationToCreate == FilmRelationEnum.ActorsRelation)
                {
                    command.Parameters.Add(new SqlParameter("@actorId", SqlDbType.VarChar));
                    for (int i = 0; i < this.actorsIds.Count; i++)
                    {
                        command.Parameters["@actorId"].Value = this.actorsIds[i];
                        using (SqlDataReader reader = command.ExecuteReader()) { }
                    }
                }

                if(relationToCreate == FilmRelationEnum.DirectorsRelation)
                {
                    command.Parameters.Add(new SqlParameter("@directorId", SqlDbType.VarChar));
                    for (int i = 0; i < this.directorsIds.Count; i++)
                    {
                        command.Parameters["@directorId"].Value = this.directorsIds[i];
                        using (SqlDataReader reader = command.ExecuteReader()) { }
                    }
                }

                if (relationToCreate == FilmRelationEnum.CategoriesRelations)
                {
                    command.Parameters.Add(new SqlParameter("@categoryId", SqlDbType.VarChar));
                    for (int i = 0; i < this.categoriesIds.Count; i++)
                    {
                        command.Parameters["@categoryId"].Value = this.categoriesIds[i];
                        using (SqlDataReader reader = command.ExecuteReader()) { }
                    }
                }
            }
        }

        private void getFilmId(String name, SqlConnection connection)
        {
            String sql = "SELECT * FROM film WHERE name = @name";
            using (SqlCommand command2 = new SqlCommand(sql, connection))
            {
                command2.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
                command2.Parameters["@name"].Value = name;
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.filmId = reader[0].ToString();
                    }
                }
            }
        }

        private void upsertFilm(String title, String duration, String year, String sql, SqlConnection connection, bool updating= false, String selectedFilm = "")
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add(new SqlParameter("@duration", SqlDbType.VarChar));
                command.Parameters["@duration"].Value = duration;
                command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
                command.Parameters["@name"].Value = title;
                command.Parameters.Add(new SqlParameter("@year", SqlDbType.VarChar));
                command.Parameters["@year"].Value = year;

                if(updating)
                {
                    command.Parameters.Add(new SqlParameter("@selectedFilm", SqlDbType.VarChar));
                    command.Parameters["@selectedFilm"].Value = selectedFilm;
                }

                command.ExecuteReader();
            }
        }


        private void getActorsIds(SqlConnection connection)
        {
            this.actorsIds.Clear();
            String sql = "SELECT * FROM actor WHERE first_name = @firstName AND last_name = @lastName";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.VarChar));

                for (int i = 0; i < this.actorsList.Items.Count; i++)
                {
                    String firstName = this.actorsList.Items[i].ToString().Split(' ')[0];
                    String lastName = this.actorsList.Items[i].ToString().Split(' ')[1];

                    command.Parameters["@firstName"].Value = firstName;
                    command.Parameters["@lastName"].Value = lastName;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.actorsIds.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }

        private void getDirectoriesIds(SqlConnection connection)
        {
            this.directorsIds.Clear();
            String sql = "SELECT * FROM director WHERE first_name = @firstName AND last_name = @lastName";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.VarChar));

                for (int i = 0; i < this.directorsList.Items.Count; i++)
                {
                    String firstName = this.directorsList.Items[i].ToString().Split(' ')[0];
                    String lastName = this.directorsList.Items[i].ToString().Split(' ')[1];

                    command.Parameters["@firstName"].Value = firstName;
                    command.Parameters["@lastName"].Value = lastName;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.directorsIds.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }

        private void getCategoriesIds(SqlConnection connection)
        {
            this.categoriesIds.Clear();
            String sql = "SELECT * FROM category WHERE name = @name";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));

                for (int i = 0; i < this.categoriesList.Items.Count; i++)
                {
                    command.Parameters["@name"].Value = categoriesList.Items[i];
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.categoriesIds.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }


        private bool IsFilmToAddValid()
        {
            if (this.title.Text == "" || this.year.Text == "" || this.duration.Text == "")
            {
                MessageBox.Show("Please enter film info.", "Info");
                return false;
            }
            else
            {
                if (this.selectedFilm.Items.IndexOf(this.title.Text) != -1)
                {
                    MessageBox.Show("Please enter a different film. This one already exists in db.", "Info");
                    return false;
                }
                else
                {
                    if (this.actorsList.Items.Count == 0)
                    {
                        MessageBox.Show("Please enter an actor.", "Info");
                        return false;
                    }
                    else if(this.directorsList.Items.Count == 0)
                    {
                        MessageBox.Show("Please enter a director.", "Info");
                        return false;
                    }
                    else if(this.categoriesList.Items.Count == 0)
                    {
                        MessageBox.Show("Please enter a category.", "Info");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private bool IsFilmToEditValid()
        {
            if (this.title.Text == "" || this.year.Text == "" || this.duration.Text == "")
            {
                MessageBox.Show("Please enter film info.", "Info");
                return false;
            }
            else
            {
                if (this.selectedFilm.Items.IndexOf(this.title.Text) != -1 && this.title.Text != (String)this.selectedFilm.SelectedItem)
                {
                    MessageBox.Show("Please enter a different film. This one already exists in db.", "Info");
                    return false;
                }
                else
                {
                    if (this.actorsList.Items.Count == 0)
                    {
                        MessageBox.Show("Please enter an actor.", "Info");
                        return false;
                    }
                    else if (this.directorsList.Items.Count == 0)
                    {
                        MessageBox.Show("Please enter a director.", "Info");
                        return false;
                    }
                    else if (this.categoriesList.Items.Count == 0)
                    {
                        MessageBox.Show("Please enter a category.", "Info");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private bool IsFilmToRemoveValid()
        {
            if ((string)this.selectedFilm.SelectedItem == "" || this.selectedFilm.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a film.", "Info");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsActorToAddValid()
        {
            if ((string)this.selectedActor.SelectedItem == "" || this.selectedActor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an actor.", "Info");
                return false;
            }
            else
            {
                String selectedActor = (String)this.selectedActor.SelectedItem;
                if (this.actorsList.Items.IndexOf(selectedActor) != -1)
                {
                    MessageBox.Show("Please select a different actor. This one already exists on actors list.", "Info");
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }

        private bool IsActorToRemoveValid()
        {
            if ((string)this.actorsList.SelectedItem == "" || this.actorsList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an actor.", "Info");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsDirectorToAddValid()
        {
            if ((string)this.selectedDirector.SelectedItem == "" || this.selectedDirector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an director.", "Info");
                return false;
            }
            else
            {
                String selectedDirector = (String)this.selectedDirector.SelectedItem;
                if (this.directorsList.Items.IndexOf(selectedDirector) != -1)
                {
                    MessageBox.Show("Please select a different director. This one already exists on directors list.", "Info");
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }

        private bool IsDirectorToRemoveValid()
        {
            if ((string)this.directorsList.SelectedItem == "" || this.directorsList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a director.", "Info");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsCategoryToAddValid()
        {
            if ((string)this.selectedCategory.SelectedItem == "" || this.selectedCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Info");
                return false;
            }
            else
            {
                String selectedCategory = (String)this.selectedCategory.SelectedItem;
                if (this.categoriesList.Items.IndexOf(selectedCategory) != -1)
                {
                    MessageBox.Show("Please select a different category. This one already exists on categories list.", "Info");
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }

        private bool IsCategoryToRemoveValid()
        {
            if ((string)this.categoriesList.SelectedItem == "" || this.categoriesList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Info");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFilmBtn_Click(object sender, EventArgs e)
        {
            if (this.addFilmBtn.Text == "Clear")
            {
                this.resetControls();
                this.selectedFilm.SelectedIndex = -1;
                this.addFilmBtn.Text = "Add";
                this.editFilmBtn.Text = "Start Editing Film";
                this.editFilmBtn.Enabled = false;
                this.addActorBtn.Enabled = true;
                this.addDirectorBtn.Enabled = true;
                this.addCategoryBtn.Enabled = true;
            }
            else
            {
                if(this.IsFilmToAddValid()) {
                    String name = this.title.Text;
                    String duration = this.duration.Text;
                    String year = this.year.Text;

                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        try
                        {
                            connection.Open();
                            String sql1 = "INSERT INTO FILM(duration ,name, year) VALUES(@duration, @name, @year)";
                            this.upsertFilm(name, duration, year, sql1, connection);
                            this.getFilmId(name, connection);

                            // ACTORS SECTION START
                            this.getActorsIds(connection);
                            String sql2 = "INSERT INTO film_actor(film_id, actor_id) VALUES(@filmId, @actorId)";
                            this.createFilmRelation(FilmRelationEnum.ActorsRelation, sql2, connection);
                            // ACTORS SECTION END

                            // DIRECTORS SECTION START
                            this.getDirectoriesIds(connection);
                            String sql3 = "INSERT INTO film_director(film_id, director_id) VALUES(@filmId, @directorId)";
                            this.createFilmRelation(FilmRelationEnum.DirectorsRelation, sql3, connection);
                            // DIRECTORS SECTION END

                            // CATEGORIES SECTION START
                            this.getCategoriesIds(connection);
                            String sql4 = "INSERT INTO film_category(film_id, category_id) VALUES(@filmId, @categoryId)";
                            this.createFilmRelation(FilmRelationEnum.CategoriesRelations, sql4, connection);
                            // CATEGORIES SECTION END
                        }
                        catch (SqlException ee)
                        {
                            MessageBox.Show(ee.Message, "Error Message");
                        }
                        finally
                        {
                            // Close the connection.
                            connection.Close();
                            this.resetControls();
                            this.refreshData();
                        }
                    }
                }
            }
        }

        private void editFilmBtn_Click(object sender, EventArgs e)
        {
            if (this.editFilmBtn.Text == "Start Editing Film")
            {
                this.addActorBtn.Enabled = true;
                this.addDirectorBtn.Enabled = true;
                this.addCategoryBtn.Enabled = true;

                this.removeActorBtn.Enabled = true;
                this.removeDirectorBtn.Enabled = true;
                this.removeCategoryBtn.Enabled = true;

                this.title.ReadOnly = false;
                this.duration.ReadOnly = false;
                this.year.ReadOnly = false;

                this.editFilmBtn.Text = "Edit Film";
            }
            else
            {
                if(this.IsFilmToEditValid())
                {
                    String duration = this.duration.Text;
                    String name = this.title.Text;
                    String year = this.year.Text;
                    String selectedFilm = (String)this.selectedFilm.SelectedItem;

                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // FILM SECTION START

                            String sql1 = "UPDATE film SET duration = @duration, name = @name, year = @year WHERE name = @selectedFilm";
                            this.upsertFilm(name, duration, year, sql1, connection, true, selectedFilm);
                            this.getFilmId(name, connection);

                            // FILM SECTION END

                            // ACTOR SECTION START
                            String sql2 = "DELETE FROM film_actor WHERE film_id = @filmId";
                            this.removeFilmRelation(sql2, connection);
                            this.getActorsIds(connection);
                            String sql3 = "INSERT INTO film_actor(film_id, actor_id) VALUES(@filmId, @actorId)";
                            this.createFilmRelation(FilmRelationEnum.ActorsRelation, sql3, connection);
                            // ACTOR SECTION END

                            // DIRECTOR SECTION START

                            String sql4 = "DELETE FROM film_director WHERE film_id = @filmId";
                            this.removeFilmRelation(sql4, connection);
                            this.getDirectoriesIds(connection);
                            String sql5 = "INSERT INTO film_director(film_id, director_id) VALUES(@filmId, @directorId)";
                            this.createFilmRelation(FilmRelationEnum.DirectorsRelation, sql5, connection);
                            // DIRECTOR SECTION END

                            // CATEGORY SECTION START
                            String sql6 = "DELETE FROM film_category WHERE film_id = @filmId";
                            this.removeFilmRelation(sql6, connection);
                            this.getCategoriesIds(connection);
                            String sql7 = "INSERT INTO film_category(film_id, category_id) VALUES(@filmId, @categoryId)";
                            this.createFilmRelation(FilmRelationEnum.CategoriesRelations, sql7, connection);
                            // CATEGORY SECTION END

                        }
                        catch (SqlException ee)
                        {
                            MessageBox.Show(ee.Message, "Error Message");
                        }
                        finally
                        {
                            // Close the connection.
                            connection.Close();
                            this.resetControls();
                            this.refreshData();
                        }
                    }
                }
            }
        }

        private void removeFilmBtn_Click(object sender, EventArgs e)
        {
            String selectedFilm = (String)this.selectedFilm.SelectedItem;
            if(this.IsFilmToRemoveValid())
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        this.getFilmId(selectedFilm, connection);

                        String sql1 = "DELETE FROM film_actor WHERE film_id = @filmId";
                        this.removeFilmRelation(sql1, connection);
     

                        String sql2 = "DELETE FROM film_director WHERE film_id = @filmId";
                        this.removeFilmRelation(sql2, connection);

                        String sql3 = "DELETE FROM film_category WHERE film_id = @filmId";
                        this.removeFilmRelation(sql3, connection);

                        String sql4 = "DELETE FROM film WHERE name = @selectedFilm";
                        using (SqlCommand command4 = new SqlCommand(sql4, connection))
                        {
                            command4.Parameters.Add(new SqlParameter("@selectedFilm", SqlDbType.VarChar));
                            command4.Parameters["@selectedFilm"].Value = selectedFilm;
                            command4.ExecuteReader();
                        }
                    }
                    catch (SqlException ee)
                    {
                        MessageBox.Show(ee.Message, "Error Message");
                    }
                    finally
                    {
                        // Close the connection.
                        connection.Close();
                        this.resetControls();
                        this.refreshData();
                        this.editFilmBtn.Enabled = false;
                    }
                }
            }
        }

        private void removeActorBtn_Click(object sender, EventArgs e)
        {
            if(this.IsActorToRemoveValid())
            {
                this.actorsList.Items.Remove(this.actorsList.SelectedItem);
                if(this.actorsList.Items.Count == 0)
                {
                    this.removeActorBtn.Enabled = false;
                }
            }
        }

        private void addActorBtn_Click(object sender, EventArgs e)
        {
            String selectedActor = (String)this.selectedActor.SelectedItem;
            if (this.IsActorToAddValid())
            {
                this.actorsList.Items.Add(selectedActor);
                this.selectedActor.SelectedIndex = -1;
                this.removeActorBtn.Enabled = true;

            }
        }

        private void removeDirectorBtn_Click(object sender, EventArgs e)
        {
            if (this.IsDirectorToRemoveValid())
            {
                this.directorsList.Items.Remove(this.directorsList.SelectedItem);
                if (this.directorsList.Items.Count == 0)
                {
                    this.removeDirectorBtn.Enabled = false;
                }
            }
        }

        private void addDirectorBtn_Click(object sender, EventArgs e)
        {
            String selectedDirector = (String)this.selectedDirector.SelectedItem;
            if (this.IsDirectorToAddValid())
            {
                this.directorsList.Items.Add(selectedDirector);
                this.selectedDirector.SelectedIndex = -1;
                this.removeDirectorBtn.Enabled = true;

            }
        }

        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {
            if (this.IsCategoryToRemoveValid())
            {
                this.categoriesList.Items.Remove(this.categoriesList.SelectedItem);
                if (this.categoriesList.Items.Count == 0)
                {
                    this.removeCategoryBtn.Enabled = false;
                }
            }
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            String selectedCategory = (String)this.selectedCategory.SelectedItem;
            if (this.IsCategoryToAddValid())
            {
                this.categoriesList.Items.Add(selectedCategory);
                this.selectedCategory.SelectedIndex = -1;
                this.removeCategoryBtn.Enabled = true;
            }
        }

        private void Films_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.netDataSet.category);
            // TODO: This line of code loads data into the 'netDataSet.director' table. You can move, or remove it, as needed.
            this.directorTableAdapter.Fill(this.netDataSet.director);
            // TODO: This line of code loads data into the 'netDataSet.actor' table. You can move, or remove it, as needed.
            this.actorTableAdapter.Fill(this.netDataSet.actor);
            // TODO: This line of code loads data into the 'netDataSet.film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.netDataSet.film);

        }

        private void selectedFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.selectedFilm.SelectedIndex == -1)
            {
                return;
            }

            String selectedFilm = (String)this.selectedFilm.SelectedItem;
            this.resetControls();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    String sql = "Select * FROM film f LEFT JOIN film_actor fa ON f.id = fa.film_id LEFT JOIN actor a ON fa.actor_id = a.id LEFT JOIN film_director fd ON f.id = fd.film_id LEFT JOIN director d on fd.director_id = d.id LEFT JOIN film_category fc ON f.id = fc.film_id LEFT JOIN category c ON fc.category_id = c.id WHERE f.name = @selectedFilm";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@selectedFilm", SqlDbType.VarChar));
                        command.Parameters["@selectedFilm"].Value = selectedFilm;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                this.title.Text = reader.GetString(2);
                                this.duration.Text = reader.GetInt32(1).ToString();
                                this.year.Text = reader.GetInt32(3).ToString();

                                if (this.actorsList.Items.IndexOf(reader.GetString(7) + ' ' + reader.GetString(8)) == -1)
                                {
                                    this.actorsList.Items.Add(reader.GetString(7) + ' ' + reader.GetString(8));
                                }

                                if (this.directorsList.Items.IndexOf(reader.GetString(12) + ' ' + reader.GetString(13)) == -1)
                                {
                                    this.directorsList.Items.Add(reader.GetString(12) + ' ' + reader.GetString(13));
                                }

                                if (this.categoriesList.Items.IndexOf(reader.GetString(17)) == -1)
                                {
                                    this.categoriesList.Items.Add(reader.GetString(17));
                                }

                                this.title.ReadOnly = true;
                                this.duration.ReadOnly = true;
                                this.year.ReadOnly = true;

                                this.addFilmBtn.Text = "Clear";

                                this.addActorBtn.Enabled = false;
                                this.addDirectorBtn.Enabled = false;
                                this.addCategoryBtn.Enabled = false;

                                this.removeActorBtn.Enabled = false;
                                this.removeDirectorBtn.Enabled = false;
                                this.removeCategoryBtn.Enabled = false;
                                this.editFilmBtn.Enabled = true;
                            }
                        }
                    }

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.Message, "Error Message");
                }
                finally
                {
                    // Close the connection.
                    connection.Close();
                }
            }
        }
    }
}
