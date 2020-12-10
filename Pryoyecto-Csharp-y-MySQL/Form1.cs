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
        
        int idUser = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // Metodo para limpiar textboxes
        public void clearTextBoxes()
        {
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Verificacion de conexion a la bd
            /*try
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
            dgUsers.ColumnCount = 5;
            dgUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            dgUsers.Columns[0].Name = "id";
            dgUsers.Columns[0].HeaderText = "id";
            dgUsers.Columns[1].Name = "firstname";
            dgUsers.Columns[1].HeaderText = "First name";
            dgUsers.Columns[2].Name = "lastname";
            dgUsers.Columns[2].HeaderText = "Last name";
            dgUsers.Columns[3].Name = "address";
            dgUsers.Columns[3].HeaderText = "Address";
            dgUsers.Columns[4].Name = "imagepath";
            dgUsers.Columns[4].HeaderText = "Image Path";

            dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsers.MultiSelect = false;
            dgUsers.AllowUserToAddRows = false;
            // Listar usuarios desde el inicio
            ListUsers();
            ShowData();

            txtId.Enabled = false;
        }
        private void SaveUser(User user)
        {          
            // Query para insercion de un registro a la bd
            string query = $"INSERT INTO `user` (`id`, `first_name`, `last_name`, `address`) VALUES (NULL, '{user.First_Name}', '{user.Last_Name}', '{user.Address}')";

            // Creacion de objeto con el query y la conexion
            commandDatabase = new MySqlCommand(query, databaseConnection);
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
                        // Se agrega image path al objeto y se le da valor en base al registro SQL devuelto
                        user.Impage_Path = myReader.GetString(4);

                        /* Muestra en consola del resultado
                        Console.WriteLine($"{myReader.GetString(0)} - {myReader.GetString(1)} - {myReader.GetString(2)} - {myReader.GetString(3)}");*/

                        // Insertar objeto al listbox
                        lbUsuarios.Items.Add($"{user.Id} - {user.First_Name} - {user.Last_Name} - {user.Address} - {user.Impage_Path}");

                        // Creacion de arreglo con strings con los datos del objeto
                        string[] row = { user.Id.ToString(), user.First_Name, user.Last_Name, user.Address, user.Impage_Path };
                        // Creacion de objeto de tipo ListViewItem
                        var listViewItem = new ListViewItem(row);
                        //ListViewItem listViewItem = new ListViewItem(row);

                        // Insercion de Item al control ListiView
                        listView1.Items.Add(listViewItem);

                        // Insertar objeto a DatagridView
                        dgUsers.Rows.Add(user.Id, user.First_Name, user.Last_Name, user.Address, user.Impage_Path);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                dgUsers.AutoResizeColumns();
            }
        }

        // Actualizar usuario en base al renglon seleccionado del datagridview
        private void UpdateUser(User user)
        {
            string query = $"UPDATE `user` SET `first_name`= '{user.First_Name}',`last_name`= '{user.Last_Name}',`address`= '{user.Address}' WHERE `id` = '{user.Id}'";

            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                commandDatabase.ExecuteReader();
                // Actualizado satisfactoriamente
                MessageBox.Show("Usuario actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Creacion de objeto y asignacion desde constructor
            User user = new User(txtFirstName.Text, txtLastName.Text, txtAdress.Text);
            // Validamos el valor del textbox del id es vacio para  decidir que metodo ejecutar
            if (txtId.Text is "")
            {
                // Registrar
                SaveUser(user);
            }
            else
            {
                // Actualizar
                user.Id = int.Parse(txtId.Text);
                UpdateUser(user);
            }
            
            // Listar
            ListUsers();
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            ListUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            idUser = int.Parse(txtId.Text);
            Delete(idUser);
            ListUsers();
            clearTextBoxes();
            pictureBox1.Image = null;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // pase lo que pase siempre cierra la conexion a la bd
                databaseConnection.Close();
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
            
            try
            {
                idUser = int.Parse(txtId.Text);
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid image.");
                }
                else
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string projectPath = $"d:\\Test\\{filename}";
                    System.IO.File.Copy(openFileDialog1.FileName,projectPath);
                    projectPath = projectPath.Replace("\\", "\\\\");
                    // La carpeta en donde se guardaran las imagenes debe de tener permisos de lectura y escritura para el usuario que esta intentanto insertar.

                    string query = $"UPDATE `user` SET `image`= '{projectPath}' WHERE `id` = '{idUser}'";
                    commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    //we already define our connection globaly. We are just calling the object of connection.
                    databaseConnection.Open();
                    commandDatabase.ExecuteReader();
                    MessageBox.Show("Image uploaded successfully.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No has seleccionado ninguna imagen", "Error");
            }
            finally
            {
                databaseConnection.Close();
                ListUsers();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            if (databaseConnection.State == 0)
            // Tambien se puede validar asi: if(databaseConnection.State.ToString() == "Closed")
            {
                idUser = (int)dgUsers.CurrentRow.Cells[0].Value;
                clearTextBoxes();
                pictureBox1.Image = null;
                string query = $"SELECT * FROM user WHERE id = {idUser}";
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
                            // Llenar textboxes con los datos que regresa la consulta SQL
                            txtId.Text = myReader.GetString(0);
                            txtFirstName.Text = myReader.GetString(1);
                            txtLastName.Text = myReader.GetString(2);
                            txtAdress.Text = myReader.GetString(3);
                            // Cargar imagen a partir de la ruta devuelta por la consulta SQL
                            pictureBox1.Image = Image.FromFile(myReader.GetString(4));
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Este usuario no tiene una imagen asiganda.");
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
        }

        private void btnClearTextboxes_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            pictureBox1.Image = null;
        }
    } 
}
