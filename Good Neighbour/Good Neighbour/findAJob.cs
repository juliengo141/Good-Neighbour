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
    public partial class findAJob : Form
    {
        public findAJob()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string City = "Brampton";
            string Street = "Cherry Tree";

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps/dir/");

                if (Street != string.Empty)
                {
                    queryaddress.Append(Street + "," + "+");
                }

                if (City != string.Empty)
                {
                    queryaddress.Append(City + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        
    }
}
