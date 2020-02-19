using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Hackathon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
                InitializeComponent();          
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pharmacy_Click(object sender, EventArgs e)
        {
            List<Pharmacy> PharmacyList = new List<Pharmacy>();


            var path = "pharmacy.csv"; // Habeeb, "Dubai Media City, Dubai"
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    Pharmacy h = new Pharmacy(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]);
                    PharmacyList.Add(h);
                }
            }
            label3.Text = "Search for pharmacy by Eircode: ";
            label4.Text = "Search for pharmacy by Name: ";
        }

        private void hospital_Click(object sender, EventArgs e)
        {
            List<Hospital> HospitalList = new List<Hospital>();


            var path = "hospital.csv"; // Habeeb, "Dubai Media City, Dubai"
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    Hospital h = new Hospital(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], fields[9], fields[10]);
                    HospitalList.Add(h);
                }
            }
            label3.Text = "Search for hospital by Eircode: ";
            label4.Text = "Search for hospital by Name: ";
        }

        private void gp_Click(object sender, EventArgs e)
        {
           
                List<GP> PharmacyList = new List<GP>();


                var path = "GP.csv"; // Habeeb, "Dubai Media City, Dubai"
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    // Skip the row with the column names
                    csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();
                        GP h = new GP(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7]);
                        PharmacyList.Add(h);
                    }
                }
            

            label3.Text = "Search for GP by Eircode: ";
            label4.Text = "Search for GP by Name: ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
