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
    public partial class Actors : Form
    {
        private String connectionString;

        public Actors()
        {
            InitializeComponent();
            this.Load += InitComboBoxes;
            this.connectionString = ConfigurationManager.ConnectionStrings["FilmCollectionProject.Properties.Settings.netConnectionString"].ConnectionString;
        }

        private void Actors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet.actor' table. You can move, or remove it, as needed.
            this.actorTableAdapter.Fill(this.netDataSet.actor);
        }

        private void InitComboBoxes(object sender, EventArgs e)
        {
            FilmCollectionProject.netDataSet.actorRow[] actorNameArray = this.netDataSet.actor.ToArray();
            int length = actorNameArray.Length;
            for (int i = 0; i < length; i++)
            {
                this.selectedActor.Items.Add(actorNameArray[i].first_name + ' ' + actorNameArray[i].last_name);
                this.selectedActor2.Items.Add(actorNameArray[i].first_name + ' ' + actorNameArray[i].last_name);
            }
        }

        private void refreshData()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                String sql = "SELECT * from actor";
                SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "actor");
                this.dataGridView1.DataSource = DS.Tables[0];

                this.selectedActor.Items.Clear();
                this.selectedActor2.Items.Clear();
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    this.selectedActor.Items.Add((String)row.ItemArray[1] + ' ' + row.ItemArray[2]);
                    this.selectedActor2.Items.Add((String)row.ItemArray[1] + ' ' + row.ItemArray[2]);
                }
            }
        }

        private bool IsActorToAddValid()
        {
            if (this.actorFirstNameToAdd.Text == "" || this.actorLastNameToAdd.Text == "")
            {
                MessageBox.Show("Please enter an actor.", "Info");
                return false;
            }
            else
            {
                String firstName = char.ToUpper(this.actorFirstNameToAdd.Text[0]) + this.actorFirstNameToAdd.Text?.Substring(1);
                String lastName = char.ToUpper(this.actorLastNameToAdd.Text[0]) + this.actorLastNameToAdd.Text?.Substring(1);
                if (this.selectedActor.Items.IndexOf(firstName + ' ' + lastName) != -1)
                {
                    MessageBox.Show("Please enter a different actor. This one already exists in db.", "Info");
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }

        private bool IsActorToEditValid()
        {
            if ((string)this.selectedActor.SelectedItem == "" || this.selectedActor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an actor.", "Info");
                return false;
            } 
            else
            {
                if (this.actorFirstNameToEdit.Text == "" || this.actorLastNameToEdit.Text == "")
                {
                    MessageBox.Show("Please enter an actor.", "Info");
                    return false;
                }
                else
                {
                    String firstName = char.ToUpper(this.actorFirstNameToEdit.Text[0]) + this.actorFirstNameToEdit.Text?.Substring(1);
                    String lastName = char.ToUpper(this.actorLastNameToEdit.Text[0]) + this.actorLastNameToEdit.Text?.Substring(1);
                    if (this.selectedActor.Items.IndexOf(firstName + ' ' + lastName) != -1)
                    {
                        MessageBox.Show("Please enter a different actor. This one already exists in db.", "Info");
                        return false;
                    }
                    else
                    {
                        return true;

                    }
                }
            }
        }

        private bool IsActorToRemoveValid()
        {
            if ((string)this.selectedActor2.SelectedItem == "" || this.selectedActor2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an actor.", "Info");
                return false;
            }
            else
            {
                return true;
            }

        }


        private void addActorBtn_Click(object sender, EventArgs e)
        {
            if(this.IsActorToAddValid())
            {
                String firstName = this.actorFirstNameToAdd.Text;
                String lastName = this.actorLastNameToAdd.Text;
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "INSERT INTO actor(first_name, last_name) VALUES(@firstName, @lastName)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.VarChar));
                            command.Parameters["@firstName"].Value = firstName;
                            command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.VarChar));
                            command.Parameters["@lastName"].Value = lastName;
                            command.ExecuteReader();
                            this.actorFirstNameToAdd.Text = "";
                            this.actorLastNameToAdd.Text = "";
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
                this.refreshData();
            }
        }

        private void editActorBtn_Click(object sender, EventArgs e)
        {
            String selectedActor = (String)this.selectedActor.SelectedItem;
            if (this.IsActorToEditValid())
            {
                String firstName2 = this.actorFirstNameToEdit.Text;
                String lastName2 = this.actorLastNameToEdit.Text;
                String firstName = selectedActor.Split(' ')[0];
                String lastName = selectedActor.Split(' ')[1];
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "UPDATE actor SET first_name = @firstName2, last_name = @lastName2 WHERE first_name = @firstName AND last_name = @lastName";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@firstName2", SqlDbType.VarChar));
                            command.Parameters["@firstName2"].Value = firstName2;
                            command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.VarChar));
                            command.Parameters["@firstName"].Value = firstName;

                            command.Parameters.Add(new SqlParameter("@lastName2", SqlDbType.VarChar));
                            command.Parameters["@lastName2"].Value = lastName2;
                            command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.VarChar));
                            command.Parameters["@lastName"].Value = lastName;

                            command.ExecuteReader();
                            this.actorFirstNameToEdit.Text = "";
                            this.actorLastNameToEdit.Text = "";
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
                this.refreshData();
            }

        }

        private void removeActorBtn_Click(object sender, EventArgs e)
        {
            String selectedActor = (String)this.selectedActor2.SelectedItem;
            if (this.IsActorToRemoveValid())
            {
                String firstName = selectedActor.Split(' ')[0];
                String lastName = selectedActor.Split(' ')[1];
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "DELETE FROM actor where first_name = @firstName And last_name = @lastName";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.VarChar));
                            command.Parameters["@firstName"].Value = firstName;
                            command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.VarChar));
                            command.Parameters["@lastName"].Value = lastName;
                            command.ExecuteReader();
                            this.selectedActor2.SelectedIndex = -1;
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
                this.refreshData();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
