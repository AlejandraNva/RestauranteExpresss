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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }
        clase_bebidas beb;

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string descripcion = txtdescripcion.Text;
            clase_bebidas cb = new clase_bebidas(nombre,descripcion);
            if (cb.Agregar())
            {
                MessageBox.Show("Bebida Agregada");
                llenargrid();
                txtnombre.Text = txtdescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            //beb = new clase_bebidas(txtnombre.Text, txtdescripcion.Text);
            //if (beb.Agregar())
            //{
            //    MessageBox.Show("Bebida añadida.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    llenargrid();
            //}
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id_bebida;
            if (!int.TryParse(txtid.Text, out id_bebida))
            {
                errorProvider1.SetError(txtid, " ID no valido");
                txtid.Focus();
                return;
            }
            errorProvider1.SetError(txtid, "");

            DialogResult Eliminar = MessageBox.Show("Realmente quieres eliminar la bebida?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Eliminar == DialogResult.Yes)
            {
                beb = new clase_bebidas(id_bebida);
                if (beb.Eliminar(id_bebida) == true)
                {
                    MessageBox.Show("Se ha eliminado la bebida..", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenargrid();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la bebida..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int id_bebida;
            if (!int.TryParse(txtid.Text, out id_bebida))
            {
                errorProvider1.SetError(txtid, "ID no valido");
                txtid.Focus();
                return;
            }
            errorProvider1.SetError(txtid, "");


            if (beb.actualizar(id_bebida, txtnombre.Text, txtdescripcion.Text) == 0)
            {
                MessageBox.Show("Se ha actualiado correctamente la bebida", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenargrid();
            }
            else
            {
                MessageBox.Show("No se ha actualizado la bebida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }
        public void BuscarRegistro()
        {
            int id_bebida;
            if (!int.TryParse(txtid.Text, out id_bebida))
            {
                errorProvider1.SetError(txtid, "ID no valido");
                txtid.Focus();
                return;
            }
            errorProvider1.SetError(txtid, "");
            beb = new clase_bebidas(id_bebida);
            if (beb.Buscar(txtnombre, txtdescripcion))
            {
                MessageBox.Show("Se ha encontrado la bebida", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se encontro la bebida", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            FormRestaurante obj = new FormRestaurante();
            obj.Show();
            this.Hide();
        }

        private void Bebidas_Load(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int pos;
                pos = dataGridView1.CurrentRow.Index;
                txtid.Text = dataGridView1[0, pos].Value.ToString();
                txtnombre.Text = dataGridView1[1, pos].Value.ToString();
                txtdescripcion.Text = dataGridView1[2, pos].Value.ToString();

            }
        }
        public void llenargrid()
        {
            beb = new clase_bebidas();
            if (beb.Leer())
            {
                dataGridView1.DataSource = beb.dt;
            }
            else
            {
                MessageBox.Show(beb.ERROR);
            }
        }

        
    }
}
