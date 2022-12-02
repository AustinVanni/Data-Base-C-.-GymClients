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
    public partial class FrmBusquedaSocio : Form
    {
        public FrmBusquedaSocio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 IdCliente = Convert.ToInt32(txtIdSocio.Text);
            ClsSocios x = new ClsSocios();
            x.BuscarSocio(IdCliente);
            if (x.IdCliente != 0)
            {
                MessageBox.Show("Dato Encontrado");
                lblNombreSocio.Text = x.Nombre;
                txtDeuda.Text = x.Deuda.ToString();
                lblBarrio.Text = x.Direccion.ToString();
                
                 btnModificar.Enabled = true;
                 btnGuardar.Enabled = true;

            }
            else
            {
                limpiar();
                MessageBox.Show("Dato No Encontrado");



            }

        }
        private void limpiar()
        {
            txtIdSocio.Text = "";
            lblNombreSocio.Text = "";
            txtDeuda.Text = "";
            lblBarrio.Text = "";
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
           btnGuardar.Enabled = false;
            txtDeuda.ReadOnly = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtDeuda.ReadOnly = false;

            
            ClsSocios c = new ClsSocios();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtIdSocio.Text);
            ClsSocios cli = new ClsSocios();
            cli.Eliminar(id);
            MessageBox.Show("Dato Eliminado");
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtIdSocio.Text);
            ClsSocios cli = new ClsSocios();
            cli.Deuda = Convert.ToDecimal(txtDeuda.Text);
            cli.Modificar(id);
            MessageBox.Show("Dato Modificado");
            limpiar();

        }
    }
}
