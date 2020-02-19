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

        bool check1 = true;
        bool check2 = false;
        bool check3 = false;

        private void pharmacy_Click(object sender, EventArgs e)
        {          
            label3.Text = "Search for pharmacy by Eircode: ";
            label4.Text = "Search for pharmacy by Name: ";
            check1 = true;
            check2 = false;
            check3 = false;
            
        }

        private void hospital_Click(object sender, EventArgs e)
        {         
            label3.Text = "Search for hospital by Eircode: ";
            label4.Text = "Search for hospital by Name: ";

            check1 = false;
            check2 = true;
            check3 = false;
        }

        private void gp_Click(object sender, EventArgs e)
        {
            label3.Text = "Search for GP by Eircode: ";
            label4.Text = "Search for GP by Name: ";

            check1 = false;
            check2 = false;
            check3 = true;
        }

        private void submit1_Click(object sender, EventArgs e)
        {
            List<Pharmacy> PharmacyList = new List<Pharmacy>();


            var path1 = "pharmacy.csv"; // Habeeb, "Dubai Media City, Dubai"
            using (TextFieldParser csvParser = new TextFieldParser(path1))
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

            List<Hospital> HospitalList = new List<Hospital>();


            var path2 = "hospital.csv"; // Habeeb, "Dubai Media City, Dubai"
            using (TextFieldParser csvParser = new TextFieldParser(path2))
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

            List<GP> GPList = new List<GP>();


            var path3 = "GP.csv"; // Habeeb, "Dubai Media City, Dubai"
            using (TextFieldParser csvParser = new TextFieldParser(path3))
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
                    GPList.Add(h);
                }
            }
           

            if (check1 == true )
            {
                string Eircode = inputEircode.Text;
                foreach (Building a in PharmacyList)
                {
                    if (a.Eircode.Equals(Eircode))
                    {
                        MessageBox.Show("Name: " + a.Name + "\n" + "Address: " + a.Address + "\n" + "Eircode: " + a.Eircode + "\n" + "Coordinate X: " + a.Coordinatex + "\n" + "Coordinate Y: " + a.Coordinatey);
                    }
                }

                string Name = InputName.Text;
                foreach (Building a in PharmacyList)
                {
                    if (a.Name.Equals(Name))
                    {
                        MessageBox.Show("Name: " + a.Name + "\n" + "Address: " + a.Address + "\n" + "Eircode: " + a.Eircode + "\n" + "Coordinate X: " + a.Coordinatex + "\n" + "Coordinate Y: " + a.Coordinatey);
                    }
                }
            }

            if (check2 == true )
            {
                string Eircode = inputEircode.Text;
                foreach (Building a in HospitalList)
                {
                    if (a.Eircode.Equals(Eircode))
                    {
                        MessageBox.Show("Name: " + a.Name + "\n" + "Address: " + a.Address + "\n" + "Eircode: " + a.Eircode + "\n" + "Coordinate X: " + a.Coordinatex + "\n" + "Coordinate Y: " + a.Coordinatey);
                    }
                }

                string Name = InputName.Text;
                foreach (Building a in PharmacyList)
                {
                    if (a.Name.Equals(Name))
                    {
                        MessageBox.Show("Name: " + a.Name + "\n" + "Address: " + a.Address + "\n" + "Eircode: " + a.Eircode + "\n" + "Coordinate X: " + a.Coordinatex + "\n" + "Coordinate Y: " + a.Coordinatey);
                    }
                }
            }

            if (check3 == true )
            {
                string Eircode = inputEircode.Text;
                foreach (Building a in GPList)
                {
                    if (a.Eircode.Equals(Eircode))
                    {
                        MessageBox.Show("Name: " + a.Name + "\n" + "Address: " + a.Address + "\n" + "Eircode: " + a.Eircode + "\n" + "Coordinate X: " + a.Coordinatex + "\n" + "Coordinate Y: " + a.Coordinatey);
                    }
                }

                string Name = InputName.Text;
                foreach (Building a in PharmacyList)
                {
                    if (a.Name.Equals(Name))
                    {
                        MessageBox.Show("Name: " + a.Name + "\n" + "Address: " + a.Address + "\n" + "Eircode: " + a.Eircode + "\n" + "Coordinate X: " + a.Coordinatex + "\n" + "Coordinate Y: " + a.Coordinatey);
                    }
                }
            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
