namespace assignment1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.full_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gender_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picked_color = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.signup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.Label();
            this.gender_male = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // full_name
            // 
            this.full_name.AcceptsTab = true;
            this.full_name.BackColor = System.Drawing.SystemColors.Window;
            this.full_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.full_name.Location = new System.Drawing.Point(161, 62);
            this.full_name.Margin = new System.Windows.Forms.Padding(2);
            this.full_name.MaxLength = 150;
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(278, 24);
            this.full_name.TabIndex = 1;
            this.full_name.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Window;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(622, 62);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(278, 24);
            this.email.TabIndex = 2;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.Window;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Location = new System.Drawing.Point(161, 111);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(278, 24);
            this.pass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_female.Location = new System.Drawing.Point(622, 177);
            this.gender_female.Margin = new System.Windows.Forms.Padding(2);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(85, 24);
            this.gender_female.TabIndex = 5;
            this.gender_female.Text = "Female";
            this.gender_female.UseVisualStyleBackColor = true;
            this.gender_female.CheckedChanged += new System.EventHandler(this.gender_female_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Favorite Color";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // picked_color
            // 
            this.picked_color.AllowDrop = true;
            this.picked_color.AutoSize = true;
            this.picked_color.Location = new System.Drawing.Point(221, 167);
            this.picked_color.Margin = new System.Windows.Forms.Padding(2);
            this.picked_color.Name = "picked_color";
            this.picked_color.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.picked_color.Size = new System.Drawing.Size(88, 34);
            this.picked_color.TabIndex = 6;
            this.picked_color.Text = "Pick Color";
            this.picked_color.UseVisualStyleBackColor = true;
            this.picked_color.Click += new System.EventHandler(this.button1_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(37, 462);
            this.signup.Margin = new System.Windows.Forms.Padding(2);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(430, 42);
            this.signup.TabIndex = 20;
            this.signup.Text = "Register";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Results:";
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(177, 231);
            this.birthdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(278, 24);
            this.birthdate.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Birthdate";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Austria",
            "Azerbaijan",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Channel Islands",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "DR Congo",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Faeroe Islands",
            "Finland",
            "France",
            "French Guiana",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Isle of Man",
            "Israel",
            "Palastine",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macao",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nepal",
            "Netherlands",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Panama",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Réunion",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "State of Palestine",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "The Bahamas",
            "Timor-Leste",
            "Togo",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Venezuela",
            "Vietnam",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.country.Location = new System.Drawing.Point(622, 236);
            this.country.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(278, 24);
            this.country.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Country";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // preview
            // 
            this.preview.AutoSize = true;
            this.preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview.Location = new System.Drawing.Point(96, 342);
            this.preview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(0, 29);
            this.preview.TabIndex = 26;
            this.preview.Click += new System.EventHandler(this.label9_Click);
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_male.Location = new System.Drawing.Point(622, 140);
            this.gender_male.Margin = new System.Windows.Forms.Padding(2);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(66, 24);
            this.gender_male.TabIndex = 4;
            this.gender_male.Text = "Male";
            this.gender_male.UseVisualStyleBackColor = true;
            this.gender_male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.gender_male);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picked_color);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender_female);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton gender_female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button picked_color;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label preview;
        private System.Windows.Forms.RadioButton gender_male;
    }
}

