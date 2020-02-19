using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var HospitalList = new List<Hospital>();
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pharmacy_Click(object sender, EventArgs e)
        {
            label3.Text = "Search for pharmacy by Eircode: ";
            label4.Text = "Search for pharmacy by Name: ";
        }

        private void hospital_Click(object sender, EventArgs e)
        {
            label3.Text = "Search for hospital by Eircode: ";
            label4.Text = "Search for hospital by Name: ";
        }

        private void gp_Click(object sender, EventArgs e)
        {
            label3.Text = "Search for GP by Eircode: ";
            label4.Text = "Search for GP by Name: ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
