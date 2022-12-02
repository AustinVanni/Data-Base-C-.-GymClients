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
    public partial class FrmListadoDeSocios : Form
    {
        public FrmListadoDeSocios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
             ClsSocios ObjCli = new ClsSocios();
            ObjCli.ListarTodos(dgvSocios);
            
            lblTotal.Text = ObjCli.TotalDeuda.ToString("0.00");
            lblPromedio.Text = ObjCli.PromedioDeuda.ToString("0.00");
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtDialog.ShowDialog();
            prtDocument.PrinterSettings = prtDialog.PrinterSettings;
            prtDocument.Print();


            MessageBox.Show("Reporte impreso exitosamente");

        }

        private void prtDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ClsSocios x = new ClsSocios();
            x.Imprimir(e);

        }

        private void FrmListadoDeSocios_Load(object sender, EventArgs e)
        {

        }
    }
}
