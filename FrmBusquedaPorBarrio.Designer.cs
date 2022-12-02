
namespace IEFI_PROGRAMACION_LOGICA
{
    partial class FrmBusquedaPorBarrio
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
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.dgvBarrio = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(31, 26);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(506, 21);
            this.cmbBarrio.TabIndex = 0;
            // 
            // dgvBarrio
            // 
            this.dgvBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvBarrio.Location = new System.Drawing.Point(31, 53);
            this.dgvBarrio.Name = "dgvBarrio";
            this.dgvBarrio.Size = new System.Drawing.Size(506, 298);
            this.dgvBarrio.TabIndex = 1;
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
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(346, 474);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 35);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(444, 474);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(92, 35);
            this.BtnExportar.TabIndex = 32;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(111, 488);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 31;
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Promedio ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total de la deuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Menor Deudor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mayor Deudor";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(111, 444);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayor
            // 
            this.lblMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor.Location = new System.Drawing.Point(111, 404);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 23);
            this.lblMayor.TabIndex = 25;
            this.lblMayor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenor
            // 
            this.lblMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor.Location = new System.Drawing.Point(111, 361);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 23);
            this.lblMenor.TabIndex = 24;
            this.lblMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(248, 474);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 37);
            this.btnListar.TabIndex = 23;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmBusquedaPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvBarrio);
            this.Controls.Add(this.cmbBarrio);
            this.Name = "FrmBusquedaPorBarrio";
            this.Text = "FrmBusquedaPorBarrio";
            this.Load += new System.EventHandler(this.FrmBusquedaPorBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.DataGridView dgvBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Button btnListar;
    }
}