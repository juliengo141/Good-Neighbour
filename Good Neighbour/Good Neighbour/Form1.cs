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
    public partial class GoodNeighbourForm : Form
    {
        public GoodNeighbourForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            login myForm = new login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            createProfile myForm = new createProfile();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
