using Evaluacion_IM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_IM.View
{
    public partial class PorcentajePuestosView : Form
    {
        ConsultasService consultasService = new ConsultasService();
        public PorcentajePuestosView()
        {
            InitializeComponent();
            dataPorcentajePuestos.DataSource = consultasService.consulta5();
        }

        private void onRefresh(object sender, EventArgs e)
        {
            dataPorcentajePuestos.DataSource = consultasService.consulta5();
        }
    }
}
