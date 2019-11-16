using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace Restaurante_Express
{
    class Conexion
    {
        private string cadena = "server=localhost;database= restaurante_express; Uid=root;pasword=;";
        public MySqlConnection cn; //entablar conexion
        public MySqlCommand cmd; //comando
        public MySqlDataReader dr; //leer informacion
        public MySqlDataAdapter da; //adaptador 
        public DataTable dt; // mostrar los datos en una tabla

        public string error; //variable para cachar el error
        public DataRow fila; // mostrar un registro de una consulta

        public void Conectar()
        {
           
                cn = new MySqlConnection(cadena);
                cn.Open();
            


        }

        public void Desconectar()
        {
            cn.Close();
        }

        public string ERROR
        {
            get { return error; }
            set { error = value; }
        }
        public bool LeerTablaDatos(string consulta)
        {
            try
            {
                this.Conectar();
                cmd = new MySqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
