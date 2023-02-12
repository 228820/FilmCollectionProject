using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace FilmCollectionProject
{
    public partial class Categories : Form
    {
        private String connectionString;

        public Categories()
        {
            InitializeComponent();
            this.Load += InitComboBoxes;
            this.connectionString = ConfigurationManager.ConnectionStrings["FilmCollectionProject.Properties.Settings.netConnectionString"].ConnectionString;

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.netDataSet.category);
        }

        private void InitComboBoxes(object sender, EventArgs e)
        {
            FilmCollectionProject.netDataSet.categoryRow[] categoryNameArray = this.netDataSet.category.ToArray();
            int length = categoryNameArray.Length;
            for (int i = 0; i < length; i++)
            {
                this.selectedCategory.Items.Add(categoryNameArray[i].name);
                this.selectedCategory2.Items.Add(categoryNameArray[i].name);
            }
        }

        private void refreshData()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                String sql = "SELECT * from category";
                SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "category");
                this.dataGridView1.DataSource = DS.Tables[0];

                this.selectedCategory.Items.Clear();
                this.selectedCategory2.Items.Clear();
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    this.selectedCategory.Items.Add(row.ItemArray[1]);
                    this.selectedCategory2.Items.Add(row.ItemArray[1]);
                }
            }
        }

        private bool IsCategoryNameToAddValid()
        {
            if (this.categoryName.Text == "")
            {
                MessageBox.Show("Please enter a name.", "Info");
                return false;
            }
            else
            {
                String categoryName = char.ToUpper(this.categoryName.Text[0]) + this.categoryName.Text?.Substring(1)?.ToUpper();
                if (this.selectedCategory.Items.IndexOf(categoryName) != -1)
                {
                    MessageBox.Show("Please enter a different name. This one already exists in db.", "Info");
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }

        private bool IsCategoryNameToEditValid() {
            if ((string)this.selectedCategory.SelectedItem == "" || this.selectedCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Info");
                return false;
            } else
            {
                if (this.categoryName2.Text == "")
                {
                    MessageBox.Show("Please enter a name.", "Info");
                    return false;
                }
                else
                {
                    String categoryName = char.ToUpper(this.categoryName2.Text[0]) + this.categoryName2.Text?.Substring(1)?.ToUpper();
                    if (this.selectedCategory.Items.IndexOf(categoryName) != -1)
                    {
                        MessageBox.Show("Please enter a different name. This one already exists in db.", "Info");
                        return false;
                    }
                    else
                    {
                        return true;

                    }
                }
            }
        }

        private bool IsCategoryNameToRemoveValid()
        {
            if ((string)this.selectedCategory2.SelectedItem == "" || this.selectedCategory2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Info");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            String categoryName = char.ToUpper(this.categoryName.Text[0]) + this.categoryName.Text?.Substring(1)?.ToLower();
            if (this.IsCategoryNameToAddValid())
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "INSERT INTO category(name) VALUES(@name)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
                            command.Parameters["@name"].Value = categoryName;
                            command.ExecuteReader();
                            this.categoryName.Text = "";
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

        private void editCategoryBtn_Click(object sender, EventArgs e)
        {
            String categoryName = char.ToUpper(this.categoryName2.Text[0]) + this.categoryName2.Text?.Substring(1)?.ToLower();
            String selectedCategory = (String)this.selectedCategory.SelectedItem;
            if (this.IsCategoryNameToEditValid())
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "UPDATE category SET name = @name WHERE name = @selectedName";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
                            command.Parameters["@name"].Value = categoryName;
                            command.Parameters.Add(new SqlParameter("@selectedName", SqlDbType.VarChar));
                            command.Parameters["@selectedName"].Value = selectedCategory;
                            command.ExecuteReader();
                            this.categoryName2.Text = "";
                            this.selectedCategory.SelectedIndex = -1;
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

        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {
            String selectedCategory = (String)this.selectedCategory2.SelectedItem;
            if (this.IsCategoryNameToRemoveValid())
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "DELETE FROM category where name = @name";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
                            command.Parameters["@name"].Value = selectedCategory;
                            command.ExecuteReader();
                            this.selectedCategory2.SelectedIndex = -1;
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
