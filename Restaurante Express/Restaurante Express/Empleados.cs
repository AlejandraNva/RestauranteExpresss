using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Restaurante_Express;

namespace Restaurante_Express
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        clase_empleados emp;

        public void BuscarRegistro()
        {
            //int id_empleado;
            //if (!int.TryParse(txtid.Text, out id_empleado))
            //{
            //    errorProvider1.SetError(txtid, "ID no valido");
            //    txtid.Focus();
            //    return;
            //}
            //errorProvider1.SetError(txtid, "");
            emp = new clase_empleados(int.Parse(txtid.Text));
            if (emp.Buscar(txtnombre, txtapellidos, txtedad))
            {
                MessageBox.Show("Se ha encontrado el Empleado", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se encontro el Empleado..", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void Buscar()
        {
            clase_empleados ce = new clase_empleados();
            if (ce.LeerReporte1(txtbuscar.Text))
            {
                dataGridView1.DataSource = ce.dt;
            }
        }


        public void llenargrid()
        {
            emp = new clase_empleados();
            if (emp.Leer())
            {
                dataGridView1.DataSource = emp.dt;
            }
            else
            {
                MessageBox.Show(emp.ERROR);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            emp = new clase_empleados(txtnombre.Text, txtapellidos.Text, Convert.ToInt16(txtedad.Text));
            if (emp.agregar())
            {
                MessageBox.Show("Empleado añadido.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                llenargrid();
            }
            else
            {
                errorProvider1.SetError(txtedad, "");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
            emp = new clase_empleados(int.Parse(txtid.Text),txtnombre.Text, txtapellidos.Text, Convert.ToInt16(txtedad.Text));
            if (emp.actualizar())
            {
                MessageBox.Show("Empleado Actualizado...", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenargrid();
            }
            else
            {
                MessageBox.Show("Empleado no Actualizado....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
           
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            

            DialogResult Eliminar = MessageBox.Show("Realmente quieres Eliminar este Empleado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Eliminar == DialogResult.Yes)
            {
                emp = new clase_empleados(int.Parse(txtid.Text));
                if (emp.eliminar())
                {
                    MessageBox.Show("Se ha eliminado el empelado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenargrid();
                }
                else
                {
                    MessageBox.Show("No se elimino el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            llenargrid();
            emp = new clase_empleados();
            emp.llenarEmpleados(cbempleados);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre.Text = txtnombre.Text.ToUpper();
        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {
            txtapellidos.Text = txtapellidos.Text.ToUpper();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro(); 
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            FormRestaurante obj = new FormRestaurante();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int pos;
                pos = dataGridView1.CurrentRow.Index;
                txtid.Text = dataGridView1[0, pos].Value.ToString();
                txtnombre.Text = dataGridView1[1, pos].Value.ToString();
                txtapellidos.Text = dataGridView1[2, pos].Value.ToString();
                txtedad.Text = dataGridView1[2, pos].Value.ToString();

            }
        }

        private void grdatospersonales_Enter(object sender, EventArgs e)
        {

        }

        private void Empleados_Load_1(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void cbempleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void buscar()
        {
            emp = new clase_empleados();
            if (emp.LeerReporte1(txtbuscar.Text))
            {
                dataGridView1.DataSource = emp.dt;
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtbuscar.Text))
            {
                llenargrid();
            }
            else
            {
                Buscar();
            }

        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txtid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtapellidos.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txtedad.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
