using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Semana8_Formulario_login_usuario
{
    public partial class Fusuarios : Form
    {
        // Crear la variable para la conexión
         public OleDbConnection miconexion;

        // Crear la variable para saber cuál actualizar 
        public string usuario_modificar;
        private OleDbConnection myCon;
        private object tusuarioTableAdapter;
        private object sistemaDataSet;
        private object tusuarioBindingSource;

        //Creamos cadena de conexión como variable publica antes de la función fusuario() 
        public string cadena_conexion = "Database=agenda;Data Source=localhost;User Id =dba;Password=12345";
        private object _sistema_mdbDataSet1;

        public Fusuarios()
        {
            
            InitializeComponent();
        }

        private void Fusuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet1.contactos' Puede moverla o quitarla según sea necesario.
            this.contactosTableAdapter.Fill(this.agendaDataSet1.contactos);
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.contactos' Puede moverla o quitarla según sea necesario.
            this.contactosTableAdapter.Fill(this.agendaDataSet.contactos);
            // TODO: esta línea de código carga datos en la tabla '_sistema_mdbDataSet1.Username' Puede moverla o quitarla según sea necesario.
            this.usernameTableAdapter.Fill(this._sistema_mdbDataSet1);
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.contactos' Puede moverla o quitarla según sea necesario.
            this.contactosTableAdapter.Fill(this.agendaDataSet.contactos);
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            try
            {
                string consulta = "select * from contactos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
         
        }



        private void bprimero_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MoveFirst();
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MoveNext();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MoveLast();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "seleccione nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bguardar_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "INSERT INTO contactos(nombre,clave,nivel) Values(?nombre,?clave,?nivel)";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 40).Value = txtusuario.Text;
                    myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 45).Value = txtclave.Text;
                    myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 4).Value = lstnivel.Text;

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    string consulta = "select * from contactos";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "agenda");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "agenda";

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //} 
                //catch (System.Exception) 
                //{ 
                // MessageBox.Show("Hay campos vacios", "Alerta!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //} 

                bnuevo.Visible = true;
                bguardar.Visible = false;

                //Desabilitar campos, se activan al crear nuevo registro 
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo.Focus();
            }


        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            
            }

        private void btbuscar_Click(object sender, EventArgs e)
        {

        }
    }

    }

    

        
    
    

