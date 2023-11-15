using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace dash
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            string email = textBox1.Text;
            string password = textBox2.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password");
            }
            else
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM user WHERE Email=@Email AND Pass=@Password", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@Email", email);
                mySqlCommand.Parameters.AddWithValue("@Password", password);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string userType = reader.GetString("Type");
                        if (userType == "admin")
                        {
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                        }
                        else if (userType == "customer")
                        {
                            this.Hide();
                            reservation reservationForm = new reservation();
                            reservationForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid user type");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
                mySqlConnection.Close();
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup form3 = new Signup(); // create an instance of Form3
            form3.Show(); // show Form3

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }
       
    }
}
