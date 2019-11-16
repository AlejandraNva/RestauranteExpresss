using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurante_Express
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=restaurante_express;Uid=root;pwd=;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlCommand conectanos = new MySqlCommand();
            codigo.Connection = conectar;

            codigo.CommandText = ("select * from usuarios where Nombre = '" + txtusuario.Text + "' and Contraseña = '" + txtcontraseña.Text + "' ");

            MySqlDataReader leer = codigo.ExecuteReader();
            if(leer.Read())
            {
                MessageBox.Show("Bienvenido..." + txtusuario.Text);
                FormRestaurante ir = new FormRestaurante();
                    ir.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
            conectar.Close();


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
