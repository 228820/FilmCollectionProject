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
    public partial class Directors : Form
    {
        private String connectionString;

        public Directors()
        {
            InitializeComponent();
            this.Load += InitComboBoxes;
            this.connectionString = ConfigurationManager.ConnectionStrings["FilmCollectionProject.Properties.Settings.netConnectionString"].ConnectionString;

        }

        private void Directors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet.director' table. You can move, or remove it, as needed.
            this.directorTableAdapter.Fill(this.netDataSet.director);

        }

        private void InitComboBoxes(object sender, EventArgs e)
        {
            FilmCollectionProject.netDataSet.directorRow[] directorsNameArray = this.netDataSet.director.ToArray();
            int length = directorsNameArray.Length;
            for (int i = 0; i < length; i++)
            {
                this.selectedDirector.Items.Add(directorsNameArray[i].first_name + ' ' + directorsNameArray[i].last_name);
                this.selectedDirector2.Items.Add(directorsNameArray[i].first_name + ' ' + directorsNameArray[i].last_name);
            }
        }

        private void refreshData()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                String sql = "SELECT * from director";
                SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "actor");
                this.dataGridView1.DataSource = DS.Tables[0];

                this.selectedDirector.Items.Clear();
                this.selectedDirector2.Items.Clear();
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    this.selectedDirector.Items.Add((String)row.ItemArray[1] + ' ' + row.ItemArray[2]);
                    this.selectedDirector2.Items.Add((String)row.ItemArray[1] + ' ' + row.ItemArray[2]);
                }
            }
        }

        private bool IsDirectorToAddValid()
        {
            if (this.directorFirstNameToAdd.Text == "" || this.directorLastNameToAdd.Text == "")
            {
                MessageBox.Show("Please enter a director.", "Info");
                return false;
            }
            else
            {
                String firstName = (char.ToUpper(this.directorFirstNameToAdd.Text[0]) + this.directorFirstNameToAdd.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                String lastName = (char.ToUpper(this.directorLastNameToAdd.Text[0]) + this.directorLastNameToAdd.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                if (this.selectedDirector.Items.IndexOf(firstName + ' ' + lastName) != -1)
                {
                    MessageBox.Show("Please enter a different director. This one already exists in db.", "Info");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private bool IsDirectorToEditValid()
        {
            if ((string)this.selectedDirector.SelectedItem == "" || this.selectedDirector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a director.", "Info");
                return false;
            }
            else
            {
                if (this.directorFirstNameToEdit.Text == "" || this.directorLastNameToEdit.Text == "")
                {
                    MessageBox.Show("Please enter an actor.", "Info");
                    return false;
                }
                else
                {
                    String firstName = (char.ToUpper(this.directorFirstNameToEdit.Text[0]) + this.directorFirstNameToEdit.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                    String lastName = (char.ToUpper(this.directorLastNameToEdit.Text[0]) + this.directorLastNameToEdit.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                    if (this.selectedDirector.Items.IndexOf(firstName + ' ' + lastName) != -1)
                    {
                        MessageBox.Show("Please enter a different director. This one already exists in db.", "Info");
                        return false;
                    }
                    else
                    {
                        return true;

                    }
                }
            }
        }

        private bool IsDirectorToRemoveValid()
        {
            if ((string)this.selectedDirector2.SelectedItem == "" || this.selectedDirector2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a director.", "Info");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void addDirectorBtn_Click(object sender, EventArgs e)
        {
            if (this.IsDirectorToAddValid())
            {
                String firstName = (char.ToUpper(this.directorFirstNameToAdd.Text[0]) + this.directorFirstNameToAdd.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                String lastName = (char.ToUpper(this.directorLastNameToAdd.Text[0]) + this.directorLastNameToAdd.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "INSERT INTO director(first_name, last_name) VALUES(@firstName, @lastName)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.VarChar));
                            command.Parameters["@firstName"].Value = firstName;
                            command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.VarChar));
                            command.Parameters["@lastName"].Value = lastName;
                            command.ExecuteReader();
                            this.directorFirstNameToAdd.Text = "";
                            this.directorLastNameToAdd.Text = "";
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

        private void editDirectorBtn_Click(object sender, EventArgs e)
        {
            String selectedDirector = (String)this.selectedDirector.SelectedItem;
            if (this.IsDirectorToEditValid())
            {
                String firstName2 = (char.ToUpper(this.directorFirstNameToEdit.Text[0]) + this.directorFirstNameToEdit.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                String lastName2 = (char.ToUpper(this.directorLastNameToEdit.Text[0]) + this.directorLastNameToEdit.Text?.Substring(1)?.ToLower()).Replace(" ", "");
                String firstName = selectedDirector.Split(' ')[0];
                String lastName = selectedDirector.Split(' ')[1];
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "UPDATE director SET first_name = @firstName2, last_name = @lastName2 WHERE first_name = @firstName AND last_name = @lastName";
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
                            this.directorFirstNameToEdit.Text = "";
                            this.directorLastNameToEdit.Text = "";
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

        private void removeDirectorBtn_Click(object sender, EventArgs e)
        {
            String selectedDirector = (String)this.selectedDirector2.SelectedItem;
            if (this.IsDirectorToRemoveValid())
            {
                String firstName = selectedDirector.Split(' ')[0];
                String lastName = selectedDirector.Split(' ')[1];
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "DELETE FROM director where first_name = @firstName And last_name = @lastName";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.VarChar));
                            command.Parameters["@firstName"].Value = firstName;
                            command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.VarChar));
                            command.Parameters["@lastName"].Value = lastName;
                            command.ExecuteReader();
                            this.selectedDirector2.SelectedIndex = -1;
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
