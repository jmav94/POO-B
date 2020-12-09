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
        // Cadena de Conexion
        const string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = test";
        // Objeto de conexion a la base de datos
        static MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
        // Declaracion de objeto que prepara el query + la conexion con la base de datos
        static MySqlCommand commandDatabase;
        // Declaracion del ejecutor del query
        static MySqlDataReader myReader;

        DataGridViewRow currentRow;
        public Form1()
        {
            InitializeComponent();
        }
        // Metodo para limpiar textboxes
        public void clearTextBoxes()
        {
            foreach (Control control in dgUsers.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            // Verificacion de conexion a la bd
            try
            {
                // Establecer conexion
                databaseConnection.Open();

                MessageBox.Show("Conexion a base de datos establecida con exito.");

                // Cerrar conexion
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            // Cantidad, nombre y encabezado de las columnas del dg + configuracion de tamaño automatico de los renglones
            dgUsers.ColumnCount = 4;
            dgUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            dgUsers.Columns[0].Name = "id";
            dgUsers.Columns[0].HeaderText = "id";
            dgUsers.Columns[1].Name = "firstname";
            dgUsers.Columns[1].HeaderText = "First name";
            dgUsers.Columns[2].Name = "lastname";
            dgUsers.Columns[2].HeaderText = "Last name";
            dgUsers.Columns[3].Name = "address";
            dgUsers.Columns[3].HeaderText = "Address";

            dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsers.MultiSelect = false;
            // Listar usuarios desde el inicio
            ListUsers();
        }
        private void SaveUser()
        {
            /* Creacion de objeto y asignacion de valores por medio de propiedades
            User user = new User();
            user.First_Name = txtFirstName.Text;
            user.Last_Name = txtLastName.Text;
            user.Address = txtAdress.Text;
            */

            // Creacion de objeto y asignacion desde constructor
            User user = new User(txtFirstName.Text, txtLastName.Text, txtAdress.Text);

            // Query para insercion de un registro a la bd
            string query = $"INSERT INTO `user` (`id`, `first_name`, `last_name`, `address`) VALUES (NULL, '{user.First_Name}', '{user.Last_Name}', '{user.Address}')";
            
            // Creacion de objeto con el query y la conexion
            commandDatabase = new MySqlCommand(query,databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion con la bd
                databaseConnection.Open();
                // Ejecutar el commandDatabase
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Usario insertado satisfatoriamente!");
                // Cerrar conexion a bd
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListUsers()
        { 
            // Limpiar controles
            lbUsuarios.Items.Clear();
            listView1.Items.Clear();
            dgUsers.Rows.Clear();

            // Query para consultar todos los campos y registros de la tabla user
            string query = "SELECT * FROM user";

            // Creacion de objeto con query y conexion a bd
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion conn bd
                databaseConnection.Open();
                // Ejecutar query y guardar el resultado en myReader
                myReader = commandDatabase.ExecuteReader();

                // Verificacion de que myReader tiene renglones con contenido
                if (myReader.HasRows)
                {
                    // Mientras pueda leer un siguiente reenglon...
                    while (myReader.Read())
                    {
                        // Creacion de objeto por cada registro devuelto
                        User user = new User(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3));

                        /* Muestra en consola del resultado
                        Console.WriteLine($"{myReader.GetString(0)} - {myReader.GetString(1)} - {myReader.GetString(2)} - {myReader.GetString(3)}");*/
                        
                        // Insertar objeto al listbox
                        lbUsuarios.Items.Add($"{user.Id} - {user.First_Name} - {user.Last_Name} - {user.Address}");

                        // Creacion de arreglo con strings con los datos del objeto
                        string[] row = { user.Id.ToString(), user.First_Name, user.Last_Name, user.Address };
                        // Creacion de objeto de tipo ListViewItem
                        var listViewItem = new ListViewItem(row);
                        //ListViewItem listViewItem = new ListViewItem(row);
                        
                        // Insercion de Item al control ListiView
                        listView1.Items.Add(listViewItem);

                        // Insertar objeto a DatagridView
                        dgUsers.Rows.Add(user.Id,user.First_Name,user.Last_Name,user.Address);
                    }
                }
                databaseConnection.Close();
                dgUsers.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void UpdateUser(User user)
        {
            string query = $"UPDATE `user` SET `first_name`= '{user.First_Name}',`last_name`= '{user.Last_Name}',`address`= '{user.Address}' WHERE id {user.Id}";
        }*/
        
        // Actualizar usuario en base a campo Id
        private void UpdateUser(User user)
        {
            string query = $"UPDATE `user` SET `first_name`= '{user.First_Name}',`last_name`= '{user.Last_Name}',`address`= '{user.Address}' WHERE `id` = '{txtId.Text}'";

            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                commandDatabase.ExecuteReader();
                // Actualizado satisfactoriamente
                MessageBox.Show("Usuario actualizado correctamente");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Registrar
            SaveUser();
            // Listar
            ListUsers();
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            ListUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User(txtFirstName.Text,txtLastName.Text,txtAdress.Text);
            UpdateUser(user);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete(int.Parse(txtId.Text));
        }
        private void Delete(int id)
        {
            string query = $"DELETE FROM `user` WHERE id = {id}";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                commandDatabase.ExecuteReader();
                // Eliminado satisfactoriamente
                MessageBox.Show("Eliminado satisfactoriamente");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select image to be upload";
            openFileDialog1.Filter = "Image Only(*.jpg;,*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        label5.Text = path;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        string query = $"UPDATE `user` SET `image`= '{path}'WHERE `id` = '{txtId.Text}'";

                        commandDatabase = new MySqlCommand(query, databaseConnection);
                        commandDatabase.CommandTimeout = 60;

                        databaseConnection.Open();
                        commandDatabase.ExecuteReader();
                        
                        MessageBox.Show("Imagen cargada correctamente");
                        databaseConnection.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Please upload an image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            int id =  (int) dgUsers.CurrentRow.Cells[0].Value;
            string query = $"SELECT `image` FROM `user` WHERE id = {id}";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                // Establecer conexion conn bd
                databaseConnection.Open();
                // Ejecutar query y guardar el resultado en myReader
                myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                        pictureBox1.Image = Image.FromFile(myReader["image"].ToString());
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox1.Image = null;
                databaseConnection.Close();
            }
        }

        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = null;
            int id = (int)dgUsers.CurrentRow.Cells[0].Value;
            string query = $"SELECT `image` FROM `user` WHERE id = {id}";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                // Establecer conexion conn bd
                databaseConnection.Open();
                // Ejecutar query y guardar el resultado en myReader
                myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                        pictureBox1.Image = Image.FromFile(myReader["image"].ToString());
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox1.Image = null;
                databaseConnection.Close();
            }
        }
    }
    
}
