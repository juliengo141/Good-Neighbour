using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Neighbour
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            GoodNeighbourForm myForm = new GoodNeighbourForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void makeARequestButton_Click(object sender, EventArgs e)
        {
            makeARequest myForm = new makeARequest();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void findAJobButton_Click(object sender, EventArgs e)
        {
            findAJob myForm = new findAJob();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
