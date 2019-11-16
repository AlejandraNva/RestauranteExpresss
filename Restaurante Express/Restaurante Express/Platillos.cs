using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante_Express;


namespace Restaurante_Express

{
    public partial class Platillos : Form
    {
        public Platillos()
        {
            InitializeComponent();
        }

        clase_platillos pla;

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //pla = new clase_platillos(txtnombre.Text, Int16.Parse(cbcategoria.Text), Convert.ToDouble(txtprecio.Text));
            //if (pla.Agregar())
            //{
            //    MessageBox.Show("Bebida añadida.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    llenargrid();
            //}

            try
            {
                pla = new clase_platillos(txtnombre.Text, Convert.ToInt32(cbcategoria.SelectedValue.ToString()), Convert.ToDouble(txtprecio.Text));
                if (pla.Agregar())
                {
                    MessageBox.Show("Platillo añadido.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    llenargrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( "El error es:" + ex);
                throw;
            }
         


    
            //else
            //{
            //    string cat;
            //    cat = cbcategoria.SelectedItem.ToString();
            //    int id_categoria;
            //    int.TryParse(cbcategoria.Text, out id_categoria);
            //    double precio;
            //    double.TryParse(txtprecio.Text, out precio);
            //    pla = new clase_platillos(txtnombre.Text, cat, precio);
            //    if (pla.Agregar())
            //    {
            //        MessageBox.Show("Se ha insertado correctamente el platillo..", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        llenargrid();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se ha insertado el platillo", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            FormRestaurante obj = new FormRestaurante();
            obj.Show();
            this.Hide();
        }

        public void Buscar()
        {
            clase_platillos cp = new clase_platillos();
            if (cp.BuscarCategoria(txtbuscar.Text))
            {
                dataGridView1.DataSource = cp.dt;
            }
         
        }
      



        private void Platillos_Load(object sender, EventArgs e)
        {
            pla = new clase_platillos();
            pla.llenarCategorias(cbcategoria);
            llenargrid();
            //pla = new clase_platillos();
            //pla.llenarEmpleados(cbcategoria);
        }
        public void llenargrid()
        {
            pla = new clase_platillos();
            if (pla.Leer())
            {
                dataGridView1.DataSource = pla.dt;
            }
            else
            {
                MessageBox.Show(pla.ERROR);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //int id_platillo;
            //if (!int.TryParse(txtid.Text, out id_platillo))
            //{
            //    errorProvider1.SetError(txtid, " ID no valido");
            //    txtid.Focus();
            //    return;
            //}
            //errorProvider1.SetError(txtid, "");

            //DialogResult Eliminar = MessageBox.Show("Realmente quieres eliminar la bebida?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ////if (Eliminar == DialogResult.Yes)
            //{
                pla = new clase_platillos(Convert.ToInt32(txtid.Text));
                if (pla.eliminar())
                {
                    MessageBox.Show("Se ha eliminado la bebida..", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenargrid();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la bebida..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            //int id_platillo;
            //if (!int.TryParse(txtid.Text, out id_platillo))
            //{
            //    errorProvider1.SetError(txtid, "ID no valido");
            //    txtid.Focus();
            //    return;
            //}
            //errorProvider1.SetError(txtid, "");
            pla = new clase_platillos(Convert.ToInt32(txtid.Text),txtnombre.Text,Convert.ToInt32(cbcategoria.SelectedValue.ToString()),Convert.ToDouble(txtprecio.Text));
            if (pla.actualizar())
            {
                MessageBox.Show("Se ha modificado la bebida..", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenargrid();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la bebida..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int id_platillo;
            if (!int.TryParse(txtid.Text, out id_platillo))
            {
                errorProvider1.SetError(txtid, "ID no valido");
                txtid.Focus();
                return;
            }
            errorProvider1.SetError(txtid, "");
            pla = new clase_platillos(id_platillo);
            if (pla.buscar(txtnombre,txtprecio, cbcategoria))
            {
                MessageBox.Show("Se ha encontrado el platillo", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("No se encontro ningun platillo", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int pos;
                pos = dataGridView1.CurrentRow.Index;
                txtid.Text = dataGridView1[0, pos].Value.ToString();
                txtnombre.Text = dataGridView1[1, pos].Value.ToString();
                txtprecio.Text = dataGridView1[2, pos].Value.ToString();
                cbcategoria.Text = dataGridView1[2, pos].Value.ToString();

            } 
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            clase_platillos cp = new clase_platillos();
            if (cp.BuscarCategoria(txtbuscar.Text))
            {
                Buscar();
            }
            else
            {
                llenargrid();
            }

        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txtid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbcategoria.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtprecio.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }
    }
    }


