using MySql.Data.MySqlClient;
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

namespace dash
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = true;


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set up connection string
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            // Get user input
            string firstName = textBox3.Text;
            string lastName = textBox4.Text;
            string email = textBox2.Text;
            string password = textBox5.Text;
            string type = comboBox1.Text;

            // Validate user input
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if email already exists in database
            mySqlConnection.Open();
            MySqlCommand checkEmailCommand = new MySqlCommand($"SELECT COUNT(*) FROM user WHERE Email='{email}'", mySqlConnection);
            int count = Convert.ToInt32(checkEmailCommand.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Email already exists. Please choose a different email.");
                mySqlConnection.Close();
                return;
            }

            // Insert new user into database
            MySqlCommand insertCommand = new MySqlCommand($"INSERT INTO user (First_Name, Last_Name, Email, Pass, Type) VALUES ('{firstName}', '{lastName}', '{email}', '{password}', '{type}')", mySqlConnection);
            insertCommand.ExecuteNonQuery();
            MessageBox.Show("Sign-up successful!");

            // Close database connection
            mySqlConnection.Close();

            // Hide Form3 and open Form2
            this.Hide();
            Signin form2 = new Signin();
            
        }



    }
}


