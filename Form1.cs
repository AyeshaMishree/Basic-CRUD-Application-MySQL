
//installed 3 things to connect this project to mysql (from official website)
// 1  mysql-8.1.0-winx64
// 2  mysql-workbench-community-8.0.34-winx64 (username=root, password any)
// 3  mysql-connector-net-8.1.0   
// open project>Solution explorer>add>references>extensions>MySQL.Data>click ok (agr extensions me mysql.data show nhi ho raha to pehly code krlo connection k code k bad wo khudi aa jaega)
// open project>Tools>NuGet package manager>manage NuGet package>Browse>search for MySQL.Data (by Oracle)>install
// then start coding (dont need to connect MySQL workbench from any other way)

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
namespace MySQL_conn
{
    public partial class Form1 : Form
    {   
        private string connectionString = "Server=localhost;Database=CRUD;Uid=root;Pwd=ayesha7705;";
        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        //main coding starts from here 
        // for buttons "view, save, delete, update, clear"

        private void viewbtn_Click(object sender, EventArgs e)
        {
            {
                // Create a connection to the MySQL database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT * FROM employees";
                        //employees is the name of table in MySQL workbech in Dtabase named CRUD in C#_CRUD window
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            DataTable dataTable = new DataTable();
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                adapter.Fill(dataTable);
                            }
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text;
            int age;
            string email = textBox6.Text;
            string address = textBox5.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter values for name, email, and address.");
                return;
            }

            if (!int.TryParse(textBox7.Text, out age))
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO employees (Name, Age, Email, Address) VALUES (@Name, @Age, @Email, @Address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data saved successfully!");
                    textBox5.Clear(); textBox6.Clear();
                    textBox7.Clear(); textBox8.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                        string name = selectedRow.Cells["Name"].Value.ToString();
                        int age = Convert.ToInt32(selectedRow.Cells["Age"].Value);
                        string email = selectedRow.Cells["Email"].Value.ToString();
                        string query = "DELETE FROM employees WHERE Name = @Name";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("data deleted successfully!");
                        textBox5.Clear(); textBox6.Clear();
                        textBox7.Clear(); textBox8.Clear(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        //fazool hay (dataGridView1_CellContentClick)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox5.Clear(); textBox6.Clear();
            textBox7.Clear(); textBox8.Clear();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                string name = textBox8.Text;
                int age;
                string email = textBox6.Text;
                string address = textBox5.Text;
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please enter values for name, email, and address.");
                    return;
                }
                if (!int.TryParse(textBox7.Text, out age))
                {
                    MessageBox.Show("Age must be a valid number.");
                    return;
                }
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                        string oldName = selectedRow.Cells["Name"].Value.ToString();
                        int oldAge = Convert.ToInt32(selectedRow.Cells["Age"].Value);
                        string oldEmail = selectedRow.Cells["Email"].Value.ToString();
                        string oldAddress = selectedRow.Cells["Address"].Value.ToString();
                        string query = "UPDATE employees SET Name = @NewName, Age = @Age, Email = @Email, Address = @Address WHERE Name = @OldName AND Age = @OldAge AND Email = @OldEmail AND Address = @OldAddress";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@NewName", name);
                            cmd.Parameters.AddWithValue("@Age", age);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@OldName", oldName);
                            cmd.Parameters.AddWithValue("@OldAge", oldAge);
                            cmd.Parameters.AddWithValue("@OldEmail", oldEmail);
                            cmd.Parameters.AddWithValue("@OldAddress", oldAddress);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Selected row updated successfully.");
                        textBox5.Clear(); textBox6.Clear();
                        textBox7.Clear(); textBox8.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // to make sure a valid row is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string age = selectedRow.Cells["Age"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();

                // to populate TextBoxes with the data 
                textBox8.Text = name;
                textBox7.Text = age;
                textBox6.Text = email;
                textBox5.Text = address;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //jb form load(run) ho to cursur ka focus name waly textbox pay ho
            textBox8.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
