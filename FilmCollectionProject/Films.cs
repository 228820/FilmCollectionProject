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

namespace FilmCollectionProject
{
    public partial class Films : Form
    {
        private String connectionString;

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

            Console.WriteLine("filmsNameArray.Length: " + filmsNameArray.Length);
            Console.WriteLine("actorsNameArray.Length: " + actorsNameArray.Length);



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


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFilmBtn_Click(object sender, EventArgs e)
        {

        }

        private void editFilmBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeFilmBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeActorBtn_Click(object sender, EventArgs e)
        {

        }

        private void addActorBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeDirectorBtn_Click(object sender, EventArgs e)
        {

        }

        private void addDirectorBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {

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
            String selectedFilm = (String)this.selectedFilm.SelectedItem;

            this.title.Text = "";
            this.duration.Text = "";
            this.year.Text = "";
            this.actorsList.Items.Clear();
            this.directorsList.Items.Clear();
            this.categoriesList.Items.Clear();

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
                                this.actorsList.Items.Add(reader.GetString(7) + ' ' + reader.GetString(8));

                                if (this.directorsList.Items.IndexOf(reader.GetString(12) + ' ' + reader.GetString(13)) == -1)
                                {
                                    this.directorsList.Items.Add(reader.GetString(12) + ' ' + reader.GetString(13));
                                }

                                if (this.categoriesList.Items.IndexOf(reader.GetString(17)) == -1)
                                {
                                    this.categoriesList.Items.Add(reader.GetString(17));
                                }
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

                //this.refreshData();
        }
    }
}
