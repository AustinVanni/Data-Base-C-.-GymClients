using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


namespace IEFI_PROGRAMACION_LOGICA
{
    public partial class FrmSociosDeudores : Form
    {
        public FrmSociosDeudores()
        {
            InitializeComponent();
        }

        ClsSocios ObjDeudores = new ClsSocios();



        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            ClsSocios x = new ClsSocios();
            ObjDeudores.ListarDeudores(dgvDeudores);
            
            lblTotal.Text = x.TotalDeuda.ToString();
            lblPromedio.Text = x.PromedioDeuda.ToString();


        }

        private void BtnImprimirDeudores_Click(object sender, EventArgs e)
        {
            prtDialog.ShowDialog();
            prtDocument.PrinterSettings = prtDialog.PrinterSettings;
            prtDocument.Print();


            MessageBox.Show("Reporte impreso exitosamente");
        }

        private void prtDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs Reporte, DataGridView GrillaListado, String titulo)
        {
           

            ClsSocios x = new ClsSocios();
            x.ImprimirDeudores(Reporte, GrillaListado, titulo);

        }

        private void btnExportarDeudores_Click(object sender, EventArgs e)
        {

        }

       





    
    }
}
