using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCollectionProject
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void filmsBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("filmsBtn_Click");
        }

        private void actorsBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("actorsBtn_Click");
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("categoriesBtn_Click");
        }

        private void directorsBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("directorsBtn_Click");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("exitBtn_Click");
        }
    }
}
