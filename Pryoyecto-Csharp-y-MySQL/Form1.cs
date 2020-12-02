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

namespace Pryoyecto_Csharp_y_MySQL
{
    public partial class Form1 : Form
    {
        static string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = test";
        static MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                databaseConnection.Open();
                MessageBox.Show("Conexion a base de datos establecida con exito.");
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void SaveUser()
        {
            string query = $"INSERT INTO `user` (`id`, `first_name`, `last_name`, `address`) VALUES (NULL, '{txtFirstName.Text}', '{txtLastName.Text}', '{txtAdress.Text}')";
            
            MySqlCommand commandDatabase = new MySqlCommand(query,databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usario insertado satisfatoriamente!");

                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ListUsers()
        {
            string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = test";
            string query = "SELECT * FROM user";

            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetString(0)} - {reader.GetString(1)} - {reader.GetString(2)} - {reader.GetString(3)}");

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), };

                        var ListViewItem = new ListViewItem(row);
                        listView1.Items.Add(ListViewItem);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            SaveUser();
//            ListUsers();
        }
    }
}
