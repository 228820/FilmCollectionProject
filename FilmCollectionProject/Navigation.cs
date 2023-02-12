using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FilmCollectionProject
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
            this.FormClosing += Navigation_FormClosing;
            
        }

        private void filmsBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("filmsBtn_Click");
        }

        private void actorsBtn_Click(object sender, EventArgs e)
        {
            Form frm = new Actors();
            frm.ShowDialog();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            Form frm = new Categories();
            frm.ShowDialog();
        }

        private void directorsBtn_Click(object sender, EventArgs e)
        {
            Form frm = new Directors();
            frm.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            /* Determines whether the user wants to exit the application. */
            if (MessageBox.Show("Exit application?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                // The user wants to exit the application. Close everything down.
                Application.Exit();
            }
      
        }

        private void Navigation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                /* Determines whether the user wants to exit the application. */
                if (MessageBox.Show("Exit application?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // The user wants to exit the application. Close everything down.
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
