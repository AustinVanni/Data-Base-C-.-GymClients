using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace IEFI_PROGRAMACION_LOGICA
{
    public partial class FrmBusquedaPorBarrio : Form
    {
        public FrmBusquedaPorBarrio()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 idBar = Convert.ToInt32(cmbBarrio.SelectedValue);
            ClsSocios x = new ClsSocios();
            x.LIstarClientesPorBarrio(dgvBarrio, idBar);
            lblTotal.Text = x.TotalDeuda.ToString("0.00");
           // lblPromedio.Text = ObjCli.PromedioDeuda.ToString("0.00");
        }

        private void FrmBusquedaPorBarrio_Load(object sender, EventArgs e)
        {
            ClsSocios x = new ClsSocios();
            x.Listar(cmbBarrio);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separado por coma|*.csv|Archivo de texto|*.txt";
            objArchivo.ShowDialog();
            Int32 idBar = Convert.ToInt32(cmbBarrio.SelectedValue);
            ClsSocios x = new ClsSocios();
            x.ReporteSocioBarrio(idBar);
            MessageBox.Show("reporte generado exitosamente!!!");
          
        }
    }
}
