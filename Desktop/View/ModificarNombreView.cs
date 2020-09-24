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
    public partial class ModificarNombreView : Form
    {
        ConsultasService consultasService = new ConsultasService();
        public ModificarNombreView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void onChangeName(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newName.Text))
            {
                dataModificarNombre.DataSource=consultasService.consulta3(newName.Text);
            }
        }

        private void onNameWrite(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void onNameWrited(object sender, KeyEventArgs e)
        {
            if (newName.Text.Trim().Length > 0)
            {
                cambiarNombre.Enabled = true;
            }
            else
            {
                cambiarNombre.Enabled = false;
            }
        }
    }
}
