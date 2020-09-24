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
    public partial class CantidadPuestosView : Form
    {
        private ConsultasService consultasService = new ConsultasService();
        public CantidadPuestosView()
        {
            InitializeComponent();
            dataCantidadPuestos.DataSource = consultasService.consulta2();
        }

        private void onRefresh(object sender, EventArgs e)
        {
            dataCantidadPuestos.DataSource = consultasService.consulta2();
        }
    }
}
