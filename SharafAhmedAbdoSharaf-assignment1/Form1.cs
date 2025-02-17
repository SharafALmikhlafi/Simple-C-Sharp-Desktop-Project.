using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            country.SelectedItem = "Yemen";
            email.Validating += Validate_Email;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Validate_Email(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string regexPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email.Text, regexPattern))
            {
                MessageBox.Show(
                    "Invalid email format!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                e.Cancel = true;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            string fullName = full_name.Text.ToString().Trim();
            string emailAddress = email.Text.ToString().Trim();
            string gender = gender_male.Checked ? "Male" : gender_female.Checked ? "Female" : "";

            string favoriteColor = colorPicker.Color.Name;

            string birthDate = birthdate.Value.ToString("dd/MM/yyyy");
            string chosenCountry = country.SelectedItem?.ToString() ?? "Not selected";
            preview.Text = $"Name: {fullName},  " +
                $"Email: {emailAddress},\n" +
                $"Gender: {gender},  " +
                $"Favorite Color: {favoriteColor},\n" +
                $"Birth Date: {birthDate},  " +
                $"Country: {chosenCountry}";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gender_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
