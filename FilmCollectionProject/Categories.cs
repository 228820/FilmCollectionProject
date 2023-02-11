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

        private bool IsCategoryNameValid()
        {
            if ((string)this.selectedCategory.SelectedItem == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add btn click");
        }

        private void editCategoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {
            String selectedCategory = (String)this.selectedCategory2.SelectedItem;

            if (this.IsCategoryNameValid())
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    try
                    {
                        Console.WriteLine("\nQuery data example:");
                        Console.WriteLine("=========================================\n");

                        connection.Open();

                        String sql = "DELETE FROM category where name = @name";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
                            command.Parameters["@name"].Value = selectedCategory;
                            command.ExecuteReader();
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

        }
    }
}
