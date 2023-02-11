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
    public partial class Actors : Form
    {
        public Actors()
        {
            InitializeComponent();
        }

        private void Actors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet.actor' table. You can move, or remove it, as needed.
            this.actorTableAdapter.Fill(this.netDataSet.actor);

        }
    }
}
