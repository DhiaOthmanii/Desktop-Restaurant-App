using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace dash
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            dataGridView1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;
            lb4.Visible = false;

            lb5.Visible = false;
            lb6.Visible = false;
            lb7.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            
            button13.Visible = false;
            label2.Visible = false;
            button12.Visible = false;
            textBox1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

            try
            {
                // Create MySqlConnection object
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Create MySqlCommand object
                MySqlCommand command = new MySqlCommand("SELECT * FROM user", connection);

                // Create MySqlDataAdapter object
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create DataTable object
                DataTable dataTable = new DataTable();

                // Fill the DataTable object with data
                adapter.Fill(dataTable);

                // Bind the DataTable object to the DataGridView control
                dataGridView1.DataSource = dataTable;
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
            lb3.Text = "Users";
            lb3.Visible = true;
            lb2.Visible = false;
            lb4.Visible = false;

            lb5.Visible = false;
            lb6.Visible = false;
            lb7.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = false;
            button10.Visible = false;
            button13.Visible = false;
            label2.Visible = false;
            button12.Visible = true;
            textBox1.Visible = true;



        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

            try
            {
                // Create MySqlConnection object
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Create MySqlCommand object
                MySqlCommand command = new MySqlCommand("SELECT * FROM staff", connection);

                // Create MySqlDataAdapter object
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create DataTable object
                DataTable dataTable = new DataTable();

                // Fill the DataTable object with data
                adapter.Fill(dataTable);

                // Bind the DataTable object to the DataGridView control
                dataGridView1.DataSource = dataTable;

                // Make the DataGridView control visible
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
            lb4.Text = "Staff";
            lb4.Visible = true;
            lb2.Visible = false;
            lb3.Visible = false;

            lb5.Visible = false;
            lb6.Visible = false;
            lb7.Visible = false;
            button3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = true;
            button10.Visible = false;
            button13.Visible = false;
            label2.Visible = false;
            button12.Visible = true;
            textBox1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "database=restaurant; server=localhost; user id=root; Convert Zero Datetime=True; Allow Zero Datetime=True;";

            try
            {
                // Create MySqlConnection object
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Create MySqlCommand object
                MySqlCommand command = new MySqlCommand("SELECT * FROM reservation", connection);

                // Create MySqlDataAdapter object
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create DataTable object
                DataTable dataTable = new DataTable();

                // Fill the DataTable object with data
                adapter.Fill(dataTable);

                // Bind the DataTable object to the DataGridView control
                dataGridView1.DataSource = dataTable;

                // Show the DataGridView control and the label
                dataGridView1.Visible = true;

            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
            lb2.Text = "Reservation";
            lb2.Visible = true;

            lb3.Visible = false;
            lb4.Visible = false;
            lb5.Visible = false;
            lb6.Visible = false;
            lb7.Visible = false;
            button2.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button13.Visible = false;
            label2.Visible = false;
            button12.Visible = true;
            textBox1.Visible = true;



        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

            try
            {
                // Create MySqlConnection object
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Create MySqlCommand object
                MySqlCommand command = new MySqlCommand("SELECT * FROM feedback", connection);

                // Create MySqlDataAdapter object
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create DataTable object
                DataTable dataTable = new DataTable();

                // Fill the DataTable object with data
                adapter.Fill(dataTable);

                // Bind the DataTable object to the DataGridView control
                dataGridView1.DataSource = dataTable;

                // Set the DataGridView control visible
                dataGridView1.Visible = true;



            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
            lb6.Text = "FeedBacks";
            lb6.Visible = true;


            lb3.Visible = false;
            lb4.Visible = false;
            lb5.Visible = false;
            lb2.Visible = false;
            lb7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button13.Visible = false;
            label2.Visible = false;
            button12.Visible = true;
            textBox1.Visible = true;
        }
        

        private void btn4_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

            try
            {
                // Create MySqlConnection object
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Create MySqlCommand object
                MySqlCommand command = new MySqlCommand("SELECT * FROM tables", connection);

                // Create MySqlDataAdapter object
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create DataTable object
                DataTable dataTable = new DataTable();

                // Fill the DataTable object with data
                adapter.Fill(dataTable);

                // Bind the DataTable object to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
            lb5.Text = "Tables";
            lb5.Visible = true;

            lb3.Visible = false;
            lb4.Visible = false;
            lb2.Visible = false;
            lb6.Visible = false;
            lb7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button6 .Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
            button13.Visible = false;
            label2.Visible = false;
            button12.Visible = true;
            textBox1.Visible = true;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Modify1_Click(object sender, EventArgs e)
        {

        }

        private void delete2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Loop through each cell in the row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Modify the cell value
                    cell.Value = "New Value";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

            MySqlConnection connection = new MySqlConnection(connectionString);

            string sql = "UPDATE user SET First_Name = @firstName, Last_Name = @lastName, Email = @email, Pass = @password , Type =@Type  WHERE Id_User = @id";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@firstName", "");
            command.Parameters.AddWithValue("@lastName", "");
            command.Parameters.AddWithValue("@email", "");
            command.Parameters.AddWithValue("@id", "");
            command.Parameters.AddWithValue("@password", "");
            command.Parameters.AddWithValue("@Type", "");

            connection.Open();

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                DataGridViewRow row = cell.OwningRow;
                if (!row.IsNewRow)
                {
                    command.Parameters["@firstName"].Value = row.Cells["First_Name"].Value;
                    command.Parameters["@lastName"].Value = row.Cells["Last_Name"].Value;
                    command.Parameters["@email"].Value = row.Cells["Email"].Value;
                    command.Parameters["@id"].Value = row.Cells["Id_User"].Value;
                    command.Parameters["@password"].Value = row.Cells["Pass"].Value;
                    command.Parameters["@Type"].Value = row.Cells["Type"].Value;

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
            MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string connectionString = "database=restaurant; server=localhost; user id=root; Allow Zero Datetime=True;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string sql = "UPDATE reservation SET First_Name = @firstName, Last_Name = @lastName, Email = @email, " +
                         "Phone_Number = @phoneNumber, Number_People = @numberPeople, Date_Reservation = @dateReservation " +
                         "WHERE Id_Reservation = @id";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@firstName", "");
            command.Parameters.AddWithValue("@lastName", "");
            command.Parameters.AddWithValue("@email", "");
            command.Parameters.AddWithValue("@phoneNumber", "");
            command.Parameters.AddWithValue("@numberPeople", "");
            command.Parameters.AddWithValue("@dateReservation", "");
            command.Parameters.AddWithValue("@id", "");

            connection.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                command.Parameters["@firstName"].Value = row.Cells["First_Name"].Value;
                command.Parameters["@lastName"].Value = row.Cells["Last_Name"].Value;
                command.Parameters["@email"].Value = row.Cells["Email"].Value;
                command.Parameters["@phoneNumber"].Value = row.Cells["Phone_Number"].Value;
                command.Parameters["@numberPeople"].Value = row.Cells["Number_People"].Value;

                // Check if the cell value is null before converting it to a DateTime object
                if (row.Cells["Date_Reservation"].Value != null)
                {
                    DateTime reservationDate;
                    if (DateTime.TryParseExact(row.Cells["Date_Reservation"].Value.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out reservationDate))
                    {
                        command.Parameters["@dateReservation"].Value = reservationDate;
                    }
                    else
                    {
                        command.Parameters["@dateReservation"].Value = DBNull.Value;
                    }
                }
                else
                {
                    // Do not set it to DBNull.Value here
                    command.Parameters["@dateReservation"].Value = null;
                }

                command.Parameters["@id"].Value = row.Cells["Id_Reservation"].Value;

                command.ExecuteNonQuery();
            }




            connection.Close();
            MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }







        private void button3_Click(object sender, EventArgs e)
        {

            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

            MySqlConnection connection = new MySqlConnection(connectionString);

            string sql = "UPDATE staff SET F_Name = @firstName, Email = @email, Phone_Number = @phoneNumber, Salaire = @salaire, Job = @job WHERE Id_Staff = @id";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@firstName", "");
            command.Parameters.AddWithValue("@email", "");
            command.Parameters.AddWithValue("@phoneNumber", "");
            command.Parameters.AddWithValue("@salaire", "");
            command.Parameters.AddWithValue("@job", "");
            command.Parameters.AddWithValue("@id", "");

            connection.Open();

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                DataGridViewRow row = cell.OwningRow;
                if (!row.IsNewRow)
                {
                    command.Parameters["@firstName"].Value = row.Cells["F_Name"].Value;
                    command.Parameters["@email"].Value = row.Cells["Email"].Value;
                    command.Parameters["@phoneNumber"].Value = row.Cells["Phone_Number"].Value;
                    command.Parameters["@salaire"].Value = row.Cells["Salaire"].Value;
                    command.Parameters["@job"].Value = row.Cells["Job"].Value;
                    command.Parameters["@id"].Value = row.Cells["Id_Staff"].Value;

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
            MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string sql = "UPDATE `tables` SET Capacity = @capacity, Emplacement = @emplacement, Statut = @statut WHERE Id_Table = @id";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@capacity", "");
            command.Parameters.AddWithValue("@emplacement", "");
            command.Parameters.AddWithValue("@statut", "");
            command.Parameters.AddWithValue("@id", "");

            connection.Open();

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                DataGridViewRow row = cell.OwningRow;
                if (!row.IsNewRow)
                {
                    command.Parameters["@capacity"].Value = row.Cells["Capacity"].Value;
                    command.Parameters["@emplacement"].Value = row.Cells["Emplacement"].Value;
                    command.Parameters["@statut"].Value = row.Cells["Statut"].Value;
                    command.Parameters["@id"].Value = row.Cells["Id_Table"].Value;

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
            MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string sql = "UPDATE feedback SET Title = @title, Body = @body WHERE Id_post = @id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@title", "");
            command.Parameters.AddWithValue("@body", "");
            command.Parameters.AddWithValue("@id", "");

            connection.Open();

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                DataGridViewRow row = cell.OwningRow;
                if (!row.IsNewRow)
                {
                    command.Parameters["@title"].Value = row.Cells["Title"].Value;
                    command.Parameters["@body"].Value = row.Cells["Body"].Value;
                    command.Parameters["@id"].Value = row.Cells["Id_post"].Value;

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();

            // Display message box
            MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this feedback?", "Delete Feedback", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string sql = "DELETE FROM feedback WHERE Id_post = @postId";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@postId", "");

                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int postId = (int)row.Cells["Id_post"].Value;
                        command.Parameters["@postId"].Value = postId;
                        command.ExecuteNonQuery();
                        dataGridView1.Rows.Remove(row);
                    }

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?", "Delete Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string sql = "DELETE FROM reservation WHERE Id_Reservation = @reservationId";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@reservationId", "");

                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int reservationId = (int)row.Cells["Id_Reservation"].Value;
                        command.Parameters["@reservationId"].Value = reservationId;
                        command.ExecuteNonQuery();
                        dataGridView1.Rows.Remove(row);
                    }

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Id_User"].Value);
                    string queryReservation = "DELETE FROM reservation WHERE User_id = " + id;
                    string queryUser = "DELETE FROM user WHERE Id_User = " + id;
                    MySqlConnection connection = new MySqlConnection("database=restaurant; server=localhost; user id=root; pwd=");
                    MySqlCommand commandReservation = new MySqlCommand(queryReservation, connection);
                    MySqlCommand commandUser = new MySqlCommand(queryUser, connection);
                    connection.Open();
                    commandReservation.ExecuteNonQuery();
                    commandUser.ExecuteNonQuery();
                    connection.Close();
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected staff member(s)?", "Delete Staff Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string sql = "DELETE FROM staff WHERE Id_Staff = @staffId";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@staffId", "");

                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int staffId = (int)row.Cells["Id_Staff"].Value;
                        command.Parameters["@staffId"].Value = staffId;
                        command.ExecuteNonQuery();
                        dataGridView1.Rows.Remove(row);
                    }

                    connection.Close();

                    MessageBox.Show("Selected staff member(s) have been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected table(s)?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string sql = "DELETE FROM tables WHERE Id_Table = @tableId";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@tableId", "");

                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int tableId = (int)row.Cells["Id_Table"].Value;
                        command.Parameters["@tableId"].Value = tableId;
                        command.ExecuteNonQuery();
                        dataGridView1.Rows.Remove(row);
                    }

                    connection.Close();

                    MessageBox.Show("Selected table(s) have been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            string connectionString = "database=restaurant; server=localhost; user id=root; pwd=";

            try
            {
                // Create MySqlConnection object
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Create MySqlCommand object
                MySqlCommand command = new MySqlCommand("SELECT * FROM affectation_tables", connection);

                // Create MySqlDataAdapter object
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create DataTable object
                DataTable dataTable = new DataTable();

                // Fill the DataTable object with data
                adapter.Fill(dataTable);

                // Bind the DataTable object to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
            label2.Visible = true;
            lb2.Visible = false;

            lb3.Visible = false;
            lb4.Visible = false;
            lb5.Visible = false;
            lb6.Visible = false;
            lb7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            
            button13.Visible = true;


        }

        private void button12_Click(object sender, EventArgs e)
        {


        }



        private void button13_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Delete Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        // Get the Id_Affectation value from the row
                        int idAffectation = int.Parse(row.Cells["Id_Affectation"].Value.ToString());

                        // Create a new connection to the database
                        using (MySqlConnection connection = new MySqlConnection("database=restaurant; server=localhost; user id=root; pwd="))
                        {
                            connection.Open();

                            // Create a new command to delete the row from the table
                            MySqlCommand command = new MySqlCommand("DELETE FROM affectation_tables WHERE Id_Affectation = @idAffectation", connection);
                            command.Parameters.AddWithValue("@idAffectation", idAffectation);

                            // Execute the command
                            command.ExecuteNonQuery();

                            // Close the connection
                            connection.Close();
                        }

                        // Remove the row from the DataGridView
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            
                // Clear any existing data in the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Get the search term from the TextBox
                string searchTerm = textBox1.Text;

                // Open a connection to the database
                string connectionString = "database=restaurant; server=localhost; user id=root; ";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Execute a search query on each table in the database
                string[] tables = { "affectation_tables", "feedback", "reservation", "staff", "tables", "user" };
                foreach (string table in tables)
                {
                    string query = "SELECT * FROM " + table + " WHERE ";
                    bool firstColumn = true;

                    // Add a WHERE clause for each column in the table
                    MySqlCommand cmd = new MySqlCommand("SHOW COLUMNS FROM " + table, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!firstColumn)
                        {
                            query += " OR ";
                        }
                        query += reader["Field"].ToString() + " LIKE '%" + searchTerm + "%'";
                        firstColumn = false;
                    }
                    reader.Close();

                    // Execute the search query and display the results in the DataGridView
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }

                // Close the database connection
                connection.Close();
            }


        }
    }

    


    

