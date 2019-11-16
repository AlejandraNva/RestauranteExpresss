using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Restaurante_Express
{
    class clase_platillos:Conexion
    {
        private int id_platillo, id_categoria;
        double precio;
        private string nombre;

        public int ID_PLATILLO
        {
            get { return id_platillo; }
            set { id_platillo = value; }
        }
        public int ID_CATEGORIA
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        public double PRECIO
        {
            get { return precio; }
            set { precio = value; }
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public clase_platillos()
        {

        }

        public clase_platillos(string nombre, int id_categoria,double precio)
        {
            //constructor para inicializar valores para insertar
            this.nombre = nombre;
            this.id_categoria = id_categoria;
            this.precio = precio;
        }

        public clase_platillos(int id_platillo, string nombre, int id_categoria, double precio)
        {
            //constructor para inicializar valores para actualizar
            this.id_platillo = id_platillo;
            this.nombre = nombre;
            this.id_categoria = id_categoria;
            this.precio = precio;

        }
        public clase_platillos(int id_platillo)
        {
            //constructor para inicializar valores para eliminar
            this.id_platillo = id_platillo;
        }
        public bool Leer()
        {
            return LeerTablaDatos("Select * from reporteplatillo");
        }
        public bool LeerReporte(string nombre, int id_categoria, double precio)
        {
            return LeerTablaDatos("select * from platillos where nombre like '" + nombre + "%' id_categoria like '" + id_categoria + "%' and precio like'" + precio + "%' order by nombre, id_categoria, precio");

        }

        public bool BuscarCategoria(string categoria)
        {
            return LeerTablaDatos("select  id_Platillo as ID, Nombre, id_categoria as Categoria, Precio from platillos where id_categoria = (select id_categoria from categorias where Nombre LIKE '" + categoria +"%')");

        }

        public bool Validacion(TextBox nombre, ComboBox categoria, TextBox precio)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text)) /*|| string.IsNullOrWhiteSpace(categoria.Text) || string.IsNullOrWhiteSpace(precio.Text))*/
                return true;
            else
                return false;

        }
        public bool Agregar()
        {
           
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO platillos (Nombre,id_categoria,Precio) VALUES (@nombre,@id_categoria,@precio)", cn);
            
                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@id_categoria", MySqlDbType.VarChar, 60).Value = id_categoria;
                cmd.Parameters.Add("@precio", MySqlDbType.Decimal).Value = precio;

                cmd.ExecuteNonQuery();
                Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool actualizar()
        {
         
            try
            {
                Conectar();
                cmd = new MySqlCommand("UPDATE platillos SET Nombre=@nombre,id_categoria=@id_categoria,Precio=@precio where id_Platillo=@id_platillo", cn);
                cmd.Parameters.Add("@id_platillo",MySqlDbType.Int16).Value = id_platillo;
                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@id_categoria", MySqlDbType.VarChar, 60).Value = id_categoria;
                cmd.Parameters.Add("@precio", MySqlDbType.Decimal).Value = precio;

                cmd.ExecuteNonQuery();
                Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool eliminar()
        {
        
            try
            {
                Conectar();
                cmd = new MySqlCommand("DELETE FROM platillos where id_Platillo=@id_platillo", cn);
                cmd.Parameters.Add("@id_platillo", MySqlDbType.Int16).Value = id_platillo;
                cmd.ExecuteNonQuery();
                Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool buscar(TextBox nombre, TextBox precio, ComboBox categoria)
        {
            bool bandera = false;
            Conectar();
            try
            {
                cmd = new MySqlCommand("SELECT * FROM Platillos where id_platillo = @id_platillo", cn);
                cmd.Parameters.Add("@id_platillo", MySqlDbType.Int16).Value = this.id_platillo;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nombre.Text = dr["nombre"].ToString();
                    precio.Text = dr["precio"].ToString();


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

        //public void llenarProveedores(ComboBox cb)
        //{
        //    try
        //    {
        //        Conectar();
        //        cmd = new MySqlCommand("Select * from proveedores order by nombreproveedor", cn);
        //        da = new MySqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        fila = dt.NewRow();
        //        fila["nombreproveedor"] = "";
        //        dt.Rows.InsertAt(fila, 0);
        //        cb.ValueMember = "idproveedor";
        //        cb.DisplayMember = "nombreproveedor";
        //        cb.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("error al cargar el combo box de proveedores..." + ex);
        //    }
        //}
        public void llenarCategorias(ComboBox cb)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("Select * from categorias order by Nombre", cn);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                fila = dt.NewRow();
                fila["Nombre"] = "";
                dt.Rows.InsertAt(fila, 0);
                cb.ValueMember = "id_categoria";
                cb.DisplayMember = "Nombre";
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("error al cargar el combo box de empleados");
            }
        }
    }
}
