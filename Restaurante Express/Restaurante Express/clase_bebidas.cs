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
    class clase_bebidas : Conexion
    {
        private int id_bebida;
        private string nombre, descripcion;

        public int ID_BEBIDA
        {
            get { return id_bebida; }
            set { id_bebida = value; }
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public clase_bebidas()
        {

        }
            
            public clase_bebidas(string nombre, string descripcion)
            {
                //constructor para inicializar valores para insertar
                this.nombre = nombre;
                this.descripcion = descripcion;
            }
            public clase_bebidas(int id_bebida)
            {
                //constructor para inicializar valores para eliminar
                this.id_bebida = id_bebida;

            }
            public clase_bebidas(int id_bebida, string nombre, string descripcion)
            {
                //constructor para inicializar valores para actualizar
                this.id_bebida = id_bebida;
                this.nombre = nombre;
                this.descripcion = descripcion;

            }

            public bool Leer()
            {
                return LeerTablaDatos("Select * from Bebidas ");
            }
        public bool LeerReporte(string nombre, string descripcion)
        {
            return LeerTablaDatos("select * from Bebidas where nombre like '" + nombre + "%' and descripcion like '" + descripcion + "%' order by nombre,descripcion");

        }
        public bool validacion(TextBox textbox)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                    return true;
                else
                    return false;

            }

        public Boolean Agregar()
        {
            bool val = false;
            Conectar();
            MySqlCommand command = new MySqlCommand("AgregarBebida", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", this.nombre);
            command.Parameters.AddWithValue("@descripcion", this.descripcion);
            try
            {
                val = command.ExecuteNonQuery() > 0 ? true : false;
                Desconectar();
            }
            catch (Exception)
            {
                Desconectar();
                return false;
                throw;
            }
            return val;




            //try
            //{
            //    cmd = new MySqlCommand("INSERT INTO Bebidas (nombre,descripcion) VALUES (@nombre,@descripcion)", cn);

            //    cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 25).Value = nombre;
            //    cmd.Parameters.Add("@descripcion", MySqlDbType.String, 50).Value = descripcion;

            //    cmd.ExecuteNonQuery();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}


        }

        public bool Eliminar(int id)
            {
                Conectar();
                try
                {
                    cmd = new MySqlCommand("DELETE FROM Bebidas where id_bebida=@id_bebida", cn);
                    cmd.Parameters.Add("@id_bebida", MySqlDbType.Int16).Value = id;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            public int actualizar(int id, string nom, string des)
            {
                Conectar();
                try
                {
                    cmd = new MySqlCommand("update Bebidas set nombre=@nombre,descripcion=@descripcion where id_bebida=@id_bebida", cn);
                    cmd.Parameters.Add("@id_bebida", MySqlDbType.Int16).Value = id;
                    cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 25).Value = nom;
                    cmd.Parameters.Add("@descripcion", MySqlDbType.String, 50).Value = des;

                    cmd.ExecuteNonQuery();
                    return 0;

                }
                catch (Exception ex)
                {
                    return -1;
                }

            }

            public bool Buscar(TextBox nombre, TextBox descripcion)
            {
                bool bandera = false;
                Conectar();
                try
                {
                    cmd = new MySqlCommand("SELECT * FROM Bebidas where id_bebida = @id_bebida", cn);
                    cmd.Parameters.Add("@id_bebida", MySqlDbType.Int16).Value = this.id_bebida;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        nombre.Text = dr["nombre"].ToString();
                        descripcion.Text = dr["descripcion"].ToString();


                        bandera = true;

                    }
                    dr.Close();
                    return bandera;
                }

                catch (Exception ex)
                {

                    return false;
                }
            }
        

    }

}
