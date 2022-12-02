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
    public partial class FrmBusquedaActividad : Form
    {
        public FrmBusquedaActividad()
        {
            InitializeComponent();
        }

        private void FrmBusquedaActividad_Load(object sender, EventArgs e)
        {
            ClsSocios x = new ClsSocios();
            x.ListarActividad(cmbActividad);
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separado por coma|*.csv|Archivo de texto|*.txt";
            objArchivo.ShowDialog();
            Int32 IdActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            ClsSocios x = new ClsSocios();
            x.ReporteDeActividad(IdActividad);
            MessageBox.Show("reporte generado exitosamente!!!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 IdActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            ClsSocios x = new ClsSocios();
            x.ListarClientesPorActividad(dgvActividad, IdActividad);
            lblTotal.Text = x.TotalDeuda.ToString("0.00");
            //lblPromedio.Text = ObjCli.PromedioDeuda.ToString("0.00");

        }
    }
}
