using Evaluacion_IM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_IM
{
   public partial class Form1 : Form
   {
        private FormularioBusquedaView formularioBusqueda = new FormularioBusquedaView();
        private CantidadPuestosView cantidadPuestosView = new CantidadPuestosView();
        private ModificarNombreView modificarNombreView = new ModificarNombreView();
        private PuestosActivosView puestosActivosView = new PuestosActivosView();
        private PorcentajePuestosView porcentajePuestosView = new PorcentajePuestosView();

        public Form1()
      {
         InitializeComponent();
      }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void onFormularioBusqueda(object sender, EventArgs e)
        {
            formularioBusqueda.Close();
            formularioBusqueda= new FormularioBusquedaView();
            formularioBusqueda.Show();
        }

        private void onCantidadPuestos(object sender, EventArgs e)
        {
            cantidadPuestosView.Close();
            cantidadPuestosView = new CantidadPuestosView();
            cantidadPuestosView.Show();
        }

        private void onModificarNombre(object sender, EventArgs e)
        {
            modificarNombreView.Close();
            modificarNombreView=new ModificarNombreView();
            modificarNombreView.Show();
        }

        private void onPuestosActivos(object sender, EventArgs e)
        {
            puestosActivosView.Close();
            puestosActivosView = new PuestosActivosView();
            puestosActivosView.Show();
        }

        private void onPorcentajesPuestos(object sender, EventArgs e)
        {
            porcentajePuestosView.Close();
            porcentajePuestosView = new PorcentajePuestosView();
            porcentajePuestosView.Show();
        }

        private void onProgramaConsola(object sender, EventArgs e)
        {
            try
            {
                Process.Start("..\\..\\..\\Binaries\\Console\\ConsoleApp1.exe");
            }
            catch(Exception exc)
            {
                try
                {
                    Process.Start("..\\Console\\ConsoleApp1.exe");
                }
                catch (Exception exc2)
                {
                    Console.WriteLine(exc2);
                }
            }
        }
    }
}
