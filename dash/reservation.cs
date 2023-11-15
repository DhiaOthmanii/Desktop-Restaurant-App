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
    public partial class reservation : Form
    {
        public reservation()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get user input
            string firstName = textBox3.Text;
            string lastName = textBox1.Text;
            string email = textBox2.Text;
            string phoneNumber = textBox4.Text;
            int numberPeople;
            DateTime dateReservation;

            // Validate all fields are filled
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || !int.TryParse(textBox5.Text, out numberPeople) || !DateTime.TryParse(dateTimePicker1.Text, out dateReservation))
            {
                MessageBox.Show("Please fill all fields with valid data.");
            }
            else
            {
                string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Retrieve user_id based on email
                    string getUserIdQuery = "SELECT Id_User FROM user WHERE Email = @email";

                    using (MySqlCommand getUserIdCommand = new MySqlCommand(getUserIdQuery, connection))
                    {
                        getUserIdCommand.Parameters.AddWithValue("@email", email);

                        connection.Open();
                        int userId = Convert.ToInt32(getUserIdCommand.ExecuteScalar());

                        if (userId != 0) // Check if user exists
                        {
                            // Insert reservation with retrieved user_id
                            string insertReservationQuery = "INSERT INTO reservation (First_Name, Last_Name, Email, Phone_Number, Number_People, Date_Reservation, User_id) " +
                                "VALUES (@first_name, @last_name, @email, @phone, @num_people, @date, @user_id)";

                            using (MySqlCommand command = new MySqlCommand(insertReservationQuery, connection))
                            {
                                command.Parameters.AddWithValue("@first_name", firstName);
                                command.Parameters.AddWithValue("@last_name", lastName);
                                command.Parameters.AddWithValue("@email", email);
                                command.Parameters.AddWithValue("@phone", phoneNumber);
                                command.Parameters.AddWithValue("@num_people", numberPeople);
                                command.Parameters.AddWithValue("@date", dateReservation);
                                command.Parameters.AddWithValue("@user_id", userId);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected == 1)
                                {
                                    MessageBox.Show("Reservation reserved successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Reservation could not be reserved. Please try again.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("User with the entered email does not exist.");
                        }
                    }
                }
            }




        }





    }
        
    }

    


