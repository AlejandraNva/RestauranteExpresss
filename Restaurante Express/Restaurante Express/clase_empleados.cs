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
    class clase_empleados : Conexion
    {
        private int id_empleado;
        private string nombre, apellidos;
        private Int16 edad;

        public int ID_EMPLEADO
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public Int16 EDAD
        {
            get { return edad; }
            set { edad = value; }
        }
        public clase_empleados()
        {

        }
        public clase_empleados(string nombre, string apellidos, Int16 edad)
        {
            //constructor para inicializar valores para insertar
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }
        public clase_empleados(int id_empleado, string nombre, string apellidos, Int16 edad)
        {
            //constructor para inicializar valores para actualizar
            this.id_empleado = id_empleado;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }
        public clase_empleados(int id_empleado)
        {
            //constructor para inicializar valores para eliminar
            this.id_empleado = id_empleado;
        }
        public bool Leer()
        {
            return LeerTablaDatos("select * from vistaempleado");
        }
        public bool LeerReporte(string nombre, string apellidos)
        {
            return LeerTablaDatos("select * from Empleados where nombre like '" + nombre + "%' and apellidos like '" + apellidos + "%' order by apellidos, nombre");

        }

        public bool LeerReporte1(string nombre)
        {
            return LeerTablaDatos("select * from Empleados where Nombre like '" + nombre + '"' );

        }

        public bool validacion(TextBox txt_nombre, TextBox txt_apellidos)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_apellidos.Text))
                return true;
            else
                return false;

        }
        public bool agregar()
        {
            Conectar();
            try
            {
                cmd = new MySqlCommand("INSERT INTO Empleados (Nombre, Apellidos, Edad) VALUES (@nombre,@apellidos,@edad)", cn);

                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@apellidos", MySqlDbType.VarChar, 50).Value = apellidos;
                cmd.Parameters.Add("@edad", MySqlDbType.Int16).Value = edad;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool actualizar()
        {
            Conectar();
            try
            {
                cmd = new MySqlCommand("UPDATE Empleados SET Nombre=@nombre, Apellidos = @apellidos, Edad = @edad where id_Empleado = @id_empleado", cn);

                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@apellidos", MySqlDbType.VarChar, 50).Value = apellidos;
                cmd.Parameters.Add("@edad", MySqlDbType.Int16).Value = edad;
                cmd.Parameters.Add("@id_empleado", MySqlDbType.Int16).Value = id_empleado;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public int buscar()
        {
            Conectar();
            try
            {
                cmd = new MySqlCommand("SELECT id_empleado FROM Empleados WHERE id_empleado=@id_empleado", cn);
                cmd.Parameters.Add("@id_empleado", MySqlDbType.Int16).Value = id_empleado;
                cmd.ExecuteNonQuery();
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }


        }
        public int avanzado(int id, string nom, string apepa, string apema)
        {
            Conectar();
            try
            {
                cmd = new MySqlCommand("SELECT *FROM Empleados where id_Empleado=@id_empleado, nombre=@nombre, apellidos=@apellidos", cn);
                dt = new DataTable();
                da.Fill(dt);


                cmd.Parameters.Add("@id_empleado", MySqlDbType.Int16).Value = id_empleado;
                cmd.Parameters.Add("@nombre", MySqlDbType.Int32).Value = nombre;
                cmd.Parameters.Add("@apellidos", MySqlDbType.Int32).Value = apellidos;
                return 0;
            }
            catch
            {
                return -1;
            }
        }
        public bool eliminar()
        {
            Conectar();
            try
            {
                cmd = new MySqlCommand("DELETE FROM Empleados where id_Empleado=@id_empleado", cn);
                cmd.Parameters.Add("@id_empleado", MySqlDbType.Int16).Value = id_empleado;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Buscar(TextBox n, TextBox ap, TextBox e)
        {
            bool bandera = false;
            Conectar();
            try
            {
                cmd = new MySqlCommand("SELECT * FROM Empleados where id_Empleado = @id_empleado", cn);
                cmd.Parameters.Add("@id_empleado", MySqlDbType.Int16).Value = this.id_empleado;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    n.Text = dr["nombre"].ToString();
                    ap.Text = dr["apellidos"].ToString();
                    e.Text = dr["edad"].ToString();
                }
                dr.Close();
                return bandera;
            }

            catch (Exception ex)
            {

                return false;
            }
        }
        public void llenarEmpleados(ComboBox cb)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("Select id_empleado, nombre+' '+apellidos as nombreC from empleados", cn);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                fila = dt.NewRow();
                fila["nombreC"] = "Selecciona un Empleado";
                dt.Rows.InsertAt(fila, 0);
                cb.ValueMember = "id_empleado";
                cb.DisplayMember = "nombreC";
                cb.DataSource = dt;
            }
            catch (Exception ex)  
            {

                MessageBox.Show("error al cargar el combo box de empleado");
            }
        }
    }
}
    