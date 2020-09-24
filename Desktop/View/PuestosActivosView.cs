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
    public partial class PuestosActivosView : Form
    {
        ConsultasService consultasService = new ConsultasService();
        public PuestosActivosView()
        {
            InitializeComponent();
            dataPuestosActivos.DataSource = consultasService.consulta4();
        }

        private void onRefresh(object sender, EventArgs e)
        {
            dataPuestosActivos.DataSource = consultasService.consulta4();
        }
    }
}
