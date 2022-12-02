using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Data.OleDb;

namespace IEFI_PROGRAMACION_LOGICA
{
    public partial class FrmAgregarNuevosSocios : Form
    {
        public FrmAgregarNuevosSocios()
        {
            InitializeComponent();
        }

        private void brnGrabar_Click(object sender, EventArgs e)
        {
            ClsSocios soc = new ClsSocios();
            soc.IdCliente = Convert.ToInt32(txtCodigo.Text);
            soc.Nombre = txtNombre.Text;
            soc.Deuda = Convert.ToDecimal(txtDeuda.Text);
            soc.IdBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            soc.Direccion = Convert.ToString(txtDireccion.Text);
            soc.IdActividad = Convert.ToInt32(cmbActividad.SelectedValue);

            
            soc.GrabarDatos();

            

            MessageBox.Show("Dato Guardado");
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
        }

        private void FrmAgregarNuevosSocios_Load(object sender, EventArgs e)
        {
            ClsSocios x = new ClsSocios();
            x.Listar(cmbBarrio);
            x.ListarActividad(cmbActividad);


            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
