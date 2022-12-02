using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_PROGRAMACION_LOGICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNuevosSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevosSocios v = new FrmAgregarNuevosSocios();
            v.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listadoDeTodosLosSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoDeSocios v = new FrmListadoDeSocios();
            v.ShowDialog();

        }

        private void listadoDeSociosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSociosDeudores z = new FrmSociosDeudores();
            z.ShowDialog();

        }

        private void buscarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaSocio x = new FrmBusquedaSocio();
            x.ShowDialog();

        }

        private void listadoDeSociosEnUnBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaPorBarrio x = new FrmBusquedaPorBarrio();
            x.ShowDialog();

        }

        private void listadoDeSociosDeUnaActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaActividad v = new FrmBusquedaActividad();
            v.ShowDialog();
        }
    }
}
