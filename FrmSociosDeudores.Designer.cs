
namespace IEFI_PROGRAMACION_LOGICA
{
    partial class FrmSociosDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.btnExportarDeudores = new System.Windows.Forms.Button();
            this.BtnImprimirDeudores = new System.Windows.Forms.Button();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDeudores.Location = new System.Drawing.Point(12, 12);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.Size = new System.Drawing.Size(506, 298);
            this.dgvDeudores.TabIndex = 0;
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(12, 444);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(92, 35);
            this.btnListarDeudores.TabIndex = 1;
            this.btnListarDeudores.Text = "Listar";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            this.btnListarDeudores.Click += new System.EventHandler(this.btnListarDeudores_Click);
            // 
            // btnExportarDeudores
            // 
            this.btnExportarDeudores.Location = new System.Drawing.Point(208, 444);
            this.btnExportarDeudores.Name = "btnExportarDeudores";
            this.btnExportarDeudores.Size = new System.Drawing.Size(92, 35);
            this.btnExportarDeudores.TabIndex = 2;
            this.btnExportarDeudores.Text = "Exportar";
            this.btnExportarDeudores.UseVisualStyleBackColor = true;
            this.btnExportarDeudores.Click += new System.EventHandler(this.btnExportarDeudores_Click);
            // 
            // BtnImprimirDeudores
            // 
            this.BtnImprimirDeudores.Location = new System.Drawing.Point(110, 444);
            this.BtnImprimirDeudores.Name = "BtnImprimirDeudores";
            this.BtnImprimirDeudores.Size = new System.Drawing.Size(92, 35);
            this.BtnImprimirDeudores.TabIndex = 3;
            this.BtnImprimirDeudores.Text = "Imprimir";
            this.BtnImprimirDeudores.UseVisualStyleBackColor = true;
            this.BtnImprimirDeudores.Click += new System.EventHandler(this.BtnImprimirDeudores_Click);
            // 
            // lblMenor
            // 
            this.lblMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor.Location = new System.Drawing.Point(399, 332);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 23);
            this.lblMenor.TabIndex = 4;
            this.lblMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayor
            // 
            this.lblMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor.Location = new System.Drawing.Point(399, 375);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 23);
            this.lblMayor.TabIndex = 5;
            this.lblMayor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(399, 415);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mayor Deudor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Menor Deudor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total de la deuda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Promedio ";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(399, 459);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 11;
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dni Socio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deuda";
            this.Column3.Name = "Column3";
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // prtDocument
            // 
            // 
            // FrmSociosDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 491);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.BtnImprimirDeudores);
            this.Controls.Add(this.btnExportarDeudores);
            this.Controls.Add(this.btnListarDeudores);
            this.Controls.Add(this.dgvDeudores);
            this.Name = "FrmSociosDeudores";
            this.Text = "FrmSociosDeudores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeudores;
        private System.Windows.Forms.Button btnListarDeudores;
        private System.Windows.Forms.Button btnExportarDeudores;
        private System.Windows.Forms.Button BtnImprimirDeudores;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PrintDialog prtDialog;
        private System.Drawing.Printing.PrintDocument prtDocument;
    }
}