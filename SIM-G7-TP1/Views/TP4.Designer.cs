namespace SIM_G7_TP1.Views
{
    partial class TP4
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
            this.Button1 = new System.Windows.Forms.Button();
            this.txtDaño = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.colDaño2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaño1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dañada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDaño = new System.Windows.Forms.DataGridView();
            this.colEntrega3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrega2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrega1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDemora = new System.Windows.Forms.DataGridView();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldaño = new System.Windows.Forms.Label();
            this.dgvDemanda = new System.Windows.Forms.DataGridView();
            this.demandaxSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_diasSimular = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_unidadesDias = new System.Windows.Forms.NumericUpDown();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.num_dias = new System.Windows.Forms.NumericUpDown();
            this.dgv_resultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_diasSimular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unidadesDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(761, 75);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 47;
            this.Button1.Text = "Filtrar";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // txtDaño
            // 
            this.txtDaño.Location = new System.Drawing.Point(605, 113);
            this.txtDaño.Name = "txtDaño";
            this.txtDaño.Size = new System.Drawing.Size(38, 20);
            this.txtDaño.TabIndex = 45;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(722, 77);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(33, 20);
            this.txtHasta.TabIndex = 44;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(688, 83);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(38, 13);
            this.Label8.TabIndex = 43;
            this.Label8.Text = "Hasta:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(649, 77);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(33, 20);
            this.txtDesde.TabIndex = 42;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(522, 83);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(121, 13);
            this.Label7.TabIndex = 41;
            this.Label7.Text = "Mostrar Semana Desde:";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(650, 111);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 40;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            // 
            // colDaño2
            // 
            this.colDaño2.HeaderText = "NO";
            this.colDaño2.Name = "colDaño2";
            this.colDaño2.Width = 35;
            // 
            // colDaño1
            // 
            this.colDaño1.HeaderText = "SI";
            this.colDaño1.Name = "colDaño1";
            this.colDaño1.Width = 35;
            // 
            // dañada
            // 
            this.dañada.HeaderText = "Daño";
            this.dañada.Name = "dañada";
            this.dañada.ReadOnly = true;
            // 
            // dgvDaño
            // 
            this.dgvDaño.AllowUserToAddRows = false;
            this.dgvDaño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaño.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dañada,
            this.colDaño1,
            this.colDaño2});
            this.dgvDaño.Location = new System.Drawing.Point(605, 23);
            this.dgvDaño.Name = "dgvDaño";
            this.dgvDaño.Size = new System.Drawing.Size(214, 46);
            this.dgvDaño.TabIndex = 39;
            // 
            // colEntrega3
            // 
            this.colEntrega3.HeaderText = "3";
            this.colEntrega3.Name = "colEntrega3";
            this.colEntrega3.Width = 35;
            // 
            // colEntrega2
            // 
            this.colEntrega2.HeaderText = "2";
            this.colEntrega2.Name = "colEntrega2";
            this.colEntrega2.Width = 35;
            // 
            // colEntrega1
            // 
            this.colEntrega1.HeaderText = "1";
            this.colEntrega1.Name = "colEntrega1";
            this.colEntrega1.Width = 35;
            // 
            // tiempoEntrega
            // 
            this.tiempoEntrega.HeaderText = "Tiempo de Entrega (Semanas)";
            this.tiempoEntrega.Name = "tiempoEntrega";
            this.tiempoEntrega.ReadOnly = true;
            this.tiempoEntrega.Width = 150;
            // 
            // dgvDemora
            // 
            this.dgvDemora.AllowUserToAddRows = false;
            this.dgvDemora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tiempoEntrega,
            this.colEntrega1,
            this.colEntrega2,
            this.colEntrega3});
            this.dgvDemora.Location = new System.Drawing.Point(300, 12);
            this.dgvDemora.Name = "dgvDemora";
            this.dgvDemora.Size = new System.Drawing.Size(299, 58);
            this.dgvDemora.TabIndex = 38;
            // 
            // col4
            // 
            this.col4.Frozen = true;
            this.col4.HeaderText = "3";
            this.col4.Name = "col4";
            this.col4.Width = 35;
            // 
            // lbldaño
            // 
            this.lbldaño.AutoSize = true;
            this.lbldaño.Location = new System.Drawing.Point(521, 116);
            this.lbldaño.Name = "lbldaño";
            this.lbldaño.Size = new System.Drawing.Size(78, 13);
            this.lbldaño.TabIndex = 46;
            this.lbldaño.Text = "Cantidad Daño";
            // 
            // dgvDemanda
            // 
            this.dgvDemanda.AllowUserToAddRows = false;
            this.dgvDemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demandaxSemana,
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.dgvDemanda.Location = new System.Drawing.Point(12, 12);
            this.dgvDemanda.Name = "dgvDemanda";
            this.dgvDemanda.Size = new System.Drawing.Size(282, 57);
            this.dgvDemanda.TabIndex = 37;
            // 
            // demandaxSemana
            // 
            this.demandaxSemana.Frozen = true;
            this.demandaxSemana.HeaderText = "Demanda por Semana";
            this.demandaxSemana.Name = "demandaxSemana";
            this.demandaxSemana.ReadOnly = true;
            // 
            // col1
            // 
            this.col1.Frozen = true;
            this.col1.HeaderText = "0";
            this.col1.Name = "col1";
            this.col1.Width = 35;
            // 
            // col2
            // 
            this.col2.Frozen = true;
            this.col2.HeaderText = "1";
            this.col2.Name = "col2";
            this.col2.Width = 35;
            // 
            // col3
            // 
            this.col3.Frozen = true;
            this.col3.HeaderText = "2";
            this.col3.Name = "col3";
            this.col3.Width = 35;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(741, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Mostrar Tabla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(367, 113);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Costo Promedio Semanal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "semanas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Simular:";
            // 
            // num_diasSimular
            // 
            this.num_diasSimular.Location = new System.Drawing.Point(367, 83);
            this.num_diasSimular.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_diasSimular.Name = "num_diasSimular";
            this.num_diasSimular.Size = new System.Drawing.Size(68, 20);
            this.num_diasSimular.TabIndex = 31;
            this.num_diasSimular.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tamaño de Pedido:";
            // 
            // num_unidadesDias
            // 
            this.num_unidadesDias.Location = new System.Drawing.Point(148, 109);
            this.num_unidadesDias.Name = "num_unidadesDias";
            this.num_unidadesDias.Size = new System.Drawing.Size(68, 20);
            this.num_unidadesDias.TabIndex = 29;
            this.num_unidadesDias.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(18, 87);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(124, 13);
            this.lbl_1.TabIndex = 28;
            this.lbl_1.Text = "Stock minimo reposicion:";
            // 
            // num_dias
            // 
            this.num_dias.Location = new System.Drawing.Point(148, 83);
            this.num_dias.Name = "num_dias";
            this.num_dias.Size = new System.Drawing.Size(68, 20);
            this.num_dias.TabIndex = 27;
            this.num_dias.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dgv_resultados
            // 
            this.dgv_resultados.AllowUserToAddRows = false;
            this.dgv_resultados.AllowUserToDeleteRows = false;
            this.dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultados.Location = new System.Drawing.Point(1, 140);
            this.dgv_resultados.Name = "dgv_resultados";
            this.dgv_resultados.ReadOnly = true;
            this.dgv_resultados.Size = new System.Drawing.Size(1029, 412);
            this.dgv_resultados.TabIndex = 26;
            this.dgv_resultados.Visible = false;
            // 
            // TP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 559);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtDaño);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgvDaño);
            this.Controls.Add(this.dgvDemora);
            this.Controls.Add(this.lbldaño);
            this.Controls.Add(this.dgvDemanda);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_diasSimular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_unidadesDias);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.num_dias);
            this.Controls.Add(this.dgv_resultados);
            this.Name = "TP4";
            this.Text = "TP4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_diasSimular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unidadesDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtDaño;
        internal System.Windows.Forms.TextBox txtHasta;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtDesde;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnSimular;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colDaño2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colDaño1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dañada;
        internal System.Windows.Forms.DataGridView dgvDaño;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colEntrega3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colEntrega2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colEntrega1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn tiempoEntrega;
        internal System.Windows.Forms.DataGridView dgvDemora;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col4;
        internal System.Windows.Forms.Label lbldaño;
        internal System.Windows.Forms.DataGridView dgvDemanda;
        internal System.Windows.Forms.DataGridViewTextBoxColumn demandaxSemana;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_diasSimular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_unidadesDias;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.NumericUpDown num_dias;
        private System.Windows.Forms.DataGridView dgv_resultados;
    }
}