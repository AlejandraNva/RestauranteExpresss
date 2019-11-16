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
using CrystalDecisions.CrystalReports.Engine;

namespace Restaurante_Express
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        ReportDocument cryrpt = new ReportDocument();
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=restaurante_express;Uid=root;pwd=;");
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from reporteplatillo", con);
            DataSet dst = new DataSet();
            sda.Fill(dst, "reporteplatillo");
            cryrpt.Load(@"C:\Users\Rodrigo\Desktop\Restaurante Express\Restaurante Express\CrystalReport1.rpt");
            cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
        }



        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost;database=restaurante_express;Uid=root;pwd=;");
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from vistaempleado", con);
            DataSet dst = new DataSet();
            sda.Fill(dst, "vistaempleado");
            cryrpt.Load(@"C:\Users\Rodrigo\Desktop\Restaurante Express\Restaurante Express\CrystalReport2.rpt");
            cryrpt.SetDataSource(dst);
            crystalReportViewer2.ReportSource = cryrpt;
        }
    }
}
