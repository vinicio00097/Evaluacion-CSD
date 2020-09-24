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

        private void onCodigoWrite(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void onNombreWrite(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (Codigo.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                if (Nombre.TextLength <= 0)
                {
                    button1.Enabled = false;
                }
            }
        }

        private void onCodigoWrite(object sender, KeyEventArgs e)
        {

        }

        private void onCodigoWrited(object sender, KeyEventArgs e)
        {
            if (Codigo.Text.Trim().Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                if (Nombre.Text.Trim().Length <= 0)
                {
                    button1.Enabled = false;
                }
            }
        }

        private void onNombreWrited(object sender, KeyEventArgs e)
        {
            if (Nombre.Text.Trim().Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                if (Codigo.Text.Trim().Length <= 0)
                {
                    button1.Enabled = false;
                }
            }
        }
    }
}
