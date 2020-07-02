namespace TP5_Simulacion
{
    partial class Form2
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
            this.lblCantHojasLibro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridEuler = new System.Windows.Forms.DataGridView();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadHojasLibroLeer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoMasUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamañoMasUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHIntegracion = new System.Windows.Forms.TextBox();
            this.lblHIntegracion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEuler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantHojasLibro
            // 
            this.lblCantHojasLibro.AutoSize = true;
            this.lblCantHojasLibro.Location = new System.Drawing.Point(472, 81);
            this.lblCantHojasLibro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantHojasLibro.Name = "lblCantHojasLibro";
            this.lblCantHojasLibro.Size = new System.Drawing.Size(35, 13);
            this.lblCantHojasLibro.TabIndex = 66;
            this.lblCantHojasLibro.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Cantidad de hojas del libro";
            // 
            // gridEuler
            // 
            this.gridEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEuler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiempo,
            this.CantidadHojasLibroLeer,
            this.Diferencial,
            this.TiempoMasUno,
            this.TamañoMasUno});
            this.gridEuler.Location = new System.Drawing.Point(12, 121);
            this.gridEuler.Name = "gridEuler";
            this.gridEuler.Size = new System.Drawing.Size(569, 351);
            this.gridEuler.TabIndex = 64;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo (i)";
            this.Tiempo.Name = "Tiempo";
            // 
            // CantidadHojasLibroLeer
            // 
            this.CantidadHojasLibroLeer.HeaderText = "Cantidad Hojas Leidas";
            this.CantidadHojasLibroLeer.Name = "CantidadHojasLibroLeer";
            // 
            // Diferencial
            // 
            this.Diferencial.HeaderText = "dT/dt = K/5";
            this.Diferencial.Name = "Diferencial";
            this.Diferencial.Width = 125;
            // 
            // TiempoMasUno
            // 
            this.TiempoMasUno.HeaderText = "Tiempo (i+1)";
            this.TiempoMasUno.Name = "TiempoMasUno";
            // 
            // TamañoMasUno
            // 
            this.TamañoMasUno.HeaderText = "Cantidad Hojas Leidas (i + 1)";
            this.TamañoMasUno.Name = "TamañoMasUno";
            // 
            // txtHIntegracion
            // 
            this.txtHIntegracion.AcceptsReturn = true;
            this.txtHIntegracion.Location = new System.Drawing.Point(149, 81);
            this.txtHIntegracion.Margin = new System.Windows.Forms.Padding(2);
            this.txtHIntegracion.Name = "txtHIntegracion";
            this.txtHIntegracion.ReadOnly = true;
            this.txtHIntegracion.Size = new System.Drawing.Size(66, 20);
            this.txtHIntegracion.TabIndex = 63;
            this.txtHIntegracion.Text = "0,1";
            // 
            // lblHIntegracion
            // 
            this.lblHIntegracion.AutoSize = true;
            this.lblHIntegracion.Location = new System.Drawing.Point(11, 88);
            this.lblHIntegracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHIntegracion.Name = "lblHIntegracion";
            this.lblHIntegracion.Size = new System.Drawing.Size(116, 13);
            this.lblHIntegracion.TabIndex = 62;
            this.lblHIntegracion.Text = "Paso de integración (h)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tiempo Lectura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 60;
            this.label1.Text = "Metodo de Euler";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 535);
            this.Controls.Add(this.lblCantHojasLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridEuler);
            this.Controls.Add(this.txtHIntegracion);
            this.Controls.Add(this.lblHIntegracion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridEuler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCantHojasLibro;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView gridEuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHojasLibroLeer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoMasUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamañoMasUno;
        public System.Windows.Forms.TextBox txtHIntegracion;
        private System.Windows.Forms.Label lblHIntegracion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}