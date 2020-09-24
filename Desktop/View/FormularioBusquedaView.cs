using Evaluacion_IM.Services;
using Evaluacion_IM.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_IM.View
{
    public partial class FormularioBusquedaView : Form
    {
        ConsultasService consultasService = new ConsultasService();
        public FormularioBusquedaView()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onBuscar(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Codigo.Text) || !String.IsNullOrEmpty(Nombre.Text))
            {
                busquedaDataGrid.DataSource=consultasService.consulta1(Nombre.Text, Codigo.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
