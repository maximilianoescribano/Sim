<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridSimulacion = New System.Windows.Forms.DataGridView()
        Me.relojDiaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndDemandaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.demandaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndDemoraCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.demoraCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ordenColocadaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.llegadaPedidoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoOrdenamientoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoMantenimientoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoStockOutCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoTotalDiaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoAcumuladoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioB = New System.Windows.Forms.RadioButton()
        Me.radioA = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtHasta = New System.Windows.Forms.NumericUpDown()
        Me.txtDesde = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSimular = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtProbDemora4 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemora3 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemora2 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemora1 = New System.Windows.Forms.NumericUpDown()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtProbDemanda50 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemanda40 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemanda30 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemanda20 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemanda10 = New System.Windows.Forms.NumericUpDown()
        Me.txtProbDemanda0 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCosto3 = New System.Windows.Forms.NumericUpDown()
        Me.txtCosto2 = New System.Windows.Forms.NumericUpDown()
        Me.txtCosto1 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCantidadPedido = New System.Windows.Forms.NumericUpDown()
        Me.txtCA = New System.Windows.Forms.NumericUpDown()
        Me.txtCS = New System.Windows.Forms.NumericUpDown()
        Me.txtCantDias = New System.Windows.Forms.NumericUpDown()
        CType(Me.gridSimulacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        CType(Me.txtProbDemora4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemora3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemora2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemora1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox5.SuspendLayout()
        CType(Me.txtProbDemanda50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemanda40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemanda30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemanda20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemanda10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbDemanda0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCosto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCantidadPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridSimulacion
        '
        Me.gridSimulacion.AllowUserToAddRows = False
        Me.gridSimulacion.AllowUserToDeleteRows = False
        Me.gridSimulacion.AllowUserToResizeRows = False
        Me.gridSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSimulacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.relojDiaCol, Me.rndDemandaCol, Me.demandaCol, Me.rndDemoraCol, Me.demoraCol, Me.ordenColocadaCol, Me.llegadaPedidoCol, Me.stockCol, Me.costoOrdenamientoCol, Me.costoMantenimientoCol, Me.costoStockOutCol, Me.costoTotalDiaCol, Me.costoAcumuladoCol})
        Me.gridSimulacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gridSimulacion.Location = New System.Drawing.Point(10, 291)
        Me.gridSimulacion.Name = "gridSimulacion"
        Me.gridSimulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSimulacion.Size = New System.Drawing.Size(960, 306)
        Me.gridSimulacion.TabIndex = 0
        '
        'relojDiaCol
        '
        Me.relojDiaCol.HeaderText = "Día"
        Me.relojDiaCol.Name = "relojDiaCol"
        Me.relojDiaCol.Width = 30
        '
        'rndDemandaCol
        '
        DataGridViewCellStyle13.NullValue = Nothing
        Me.rndDemandaCol.DefaultCellStyle = DataGridViewCellStyle13
        Me.rndDemandaCol.HeaderText = "RND Demanda"
        Me.rndDemandaCol.Name = "rndDemandaCol"
        Me.rndDemandaCol.Width = 70
        '
        'demandaCol
        '
        Me.demandaCol.HeaderText = "Demanda"
        Me.demandaCol.Name = "demandaCol"
        Me.demandaCol.Width = 60
        '
        'rndDemoraCol
        '
        Me.rndDemoraCol.HeaderText = "RND Demora"
        Me.rndDemoraCol.Name = "rndDemoraCol"
        Me.rndDemoraCol.Width = 60
        '
        'demoraCol
        '
        Me.demoraCol.HeaderText = "Demora"
        Me.demoraCol.Name = "demoraCol"
        Me.demoraCol.Width = 60
        '
        'ordenColocadaCol
        '
        Me.ordenColocadaCol.HeaderText = "Orden Colocada"
        Me.ordenColocadaCol.Name = "ordenColocadaCol"
        Me.ordenColocadaCol.Width = 70
        '
        'llegadaPedidoCol
        '
        Me.llegadaPedidoCol.HeaderText = "Llegada Pedido"
        Me.llegadaPedidoCol.Name = "llegadaPedidoCol"
        Me.llegadaPedidoCol.Width = 60
        '
        'stockCol
        '
        Me.stockCol.HeaderText = "Stock (en decenas)"
        Me.stockCol.Name = "stockCol"
        Me.stockCol.Width = 60
        '
        'costoOrdenamientoCol
        '
        Me.costoOrdenamientoCol.HeaderText = "Costo Ordenamiento"
        Me.costoOrdenamientoCol.Name = "costoOrdenamientoCol"
        '
        'costoMantenimientoCol
        '
        Me.costoMantenimientoCol.HeaderText = "Costo de Mantenimiento"
        Me.costoMantenimientoCol.Name = "costoMantenimientoCol"
        Me.costoMantenimientoCol.Width = 80
        '
        'costoStockOutCol
        '
        Me.costoStockOutCol.HeaderText = "Costo de Stock Out"
        Me.costoStockOutCol.Name = "costoStockOutCol"
        Me.costoStockOutCol.Width = 80
        '
        'costoTotalDiaCol
        '
        Me.costoTotalDiaCol.HeaderText = "Costo Total del Día"
        Me.costoTotalDiaCol.Name = "costoTotalDiaCol"
        Me.costoTotalDiaCol.Width = 80
        '
        'costoAcumuladoCol
        '
        Me.costoAcumuladoCol.HeaderText = "Costo Acumulado"
        Me.costoAcumuladoCol.Name = "costoAcumuladoCol"
        Me.costoAcumuladoCol.Width = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de Días"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.radioB)
        Me.Panel1.Controls.Add(Me.radioA)
        Me.Panel1.Location = New System.Drawing.Point(250, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 59)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Política"
        '
        'radioB
        '
        Me.radioB.AutoSize = True
        Me.radioB.Location = New System.Drawing.Point(71, 35)
        Me.radioB.Name = "radioB"
        Me.radioB.Size = New System.Drawing.Size(102, 17)
        Me.radioB.TabIndex = 1
        Me.radioB.TabStop = True
        Me.radioB.Text = "B (cada 10 dias)"
        Me.radioB.UseVisualStyleBackColor = True
        '
        'radioA
        '
        Me.radioA.AutoSize = True
        Me.radioA.Location = New System.Drawing.Point(71, 7)
        Me.radioA.Name = "radioA"
        Me.radioA.Size = New System.Drawing.Size(96, 17)
        Me.radioA.TabIndex = 0
        Me.radioA.TabStop = True
        Me.radioA.Text = "A (cada 7 dias)"
        Me.radioA.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtHasta)
        Me.Panel2.Controls.Add(Me.txtDesde)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(467, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 59)
        Me.Panel2.TabIndex = 8
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(129, 33)
        Me.txtHasta.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtHasta.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(71, 20)
        Me.txtHasta.TabIndex = 9
        Me.txtHasta.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(128, 7)
        Me.txtDesde.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtDesde.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(72, 20)
        Me.txtDesde.TabIndex = 8
        Me.txtDesde.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mostrar"
        '
        'btnSimular
        '
        Me.btnSimular.Location = New System.Drawing.Point(734, 23)
        Me.btnSimular.Name = "btnSimular"
        Me.btnSimular.Size = New System.Drawing.Size(85, 35)
        Me.btnSimular.TabIndex = 9
        Me.btnSimular.Text = "Simular"
        Me.btnSimular.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(105, 600)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(111, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 600)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Costo Total $"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.groupBox6)
        Me.groupBox3.Controls.Add(Me.groupBox5)
        Me.groupBox3.Location = New System.Drawing.Point(11, 84)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Size = New System.Drawing.Size(419, 202)
        Me.groupBox3.TabIndex = 26
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Probabilidades"
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.txtProbDemora4)
        Me.groupBox6.Controls.Add(Me.txtProbDemora3)
        Me.groupBox6.Controls.Add(Me.txtProbDemora2)
        Me.groupBox6.Controls.Add(Me.txtProbDemora1)
        Me.groupBox6.Controls.Add(Me.label16)
        Me.groupBox6.Controls.Add(Me.label17)
        Me.groupBox6.Controls.Add(Me.label18)
        Me.groupBox6.Controls.Add(Me.label19)
        Me.groupBox6.Location = New System.Drawing.Point(211, 24)
        Me.groupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox6.Size = New System.Drawing.Size(190, 125)
        Me.groupBox6.TabIndex = 8
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "Demora (en dias)"
        '
        'txtProbDemora4
        '
        Me.txtProbDemora4.DecimalPlaces = 2
        Me.txtProbDemora4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemora4.Location = New System.Drawing.Point(43, 89)
        Me.txtProbDemora4.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemora4.Name = "txtProbDemora4"
        Me.txtProbDemora4.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemora4.TabIndex = 15
        Me.txtProbDemora4.Value = New Decimal(New Integer() {25, 0, 0, 131072})
        '
        'txtProbDemora3
        '
        Me.txtProbDemora3.DecimalPlaces = 2
        Me.txtProbDemora3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemora3.Location = New System.Drawing.Point(43, 68)
        Me.txtProbDemora3.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemora3.Name = "txtProbDemora3"
        Me.txtProbDemora3.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemora3.TabIndex = 14
        Me.txtProbDemora3.Value = New Decimal(New Integer() {40, 0, 0, 131072})
        '
        'txtProbDemora2
        '
        Me.txtProbDemora2.DecimalPlaces = 2
        Me.txtProbDemora2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemora2.Location = New System.Drawing.Point(43, 46)
        Me.txtProbDemora2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemora2.Name = "txtProbDemora2"
        Me.txtProbDemora2.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemora2.TabIndex = 13
        Me.txtProbDemora2.Value = New Decimal(New Integer() {20, 0, 0, 131072})
        '
        'txtProbDemora1
        '
        Me.txtProbDemora1.DecimalPlaces = 2
        Me.txtProbDemora1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemora1.Location = New System.Drawing.Point(43, 24)
        Me.txtProbDemora1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemora1.Name = "txtProbDemora1"
        Me.txtProbDemora1.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemora1.TabIndex = 12
        Me.txtProbDemora1.Value = New Decimal(New Integer() {15, 0, 0, 131072})
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(16, 93)
        Me.label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(13, 13)
        Me.label16.TabIndex = 3
        Me.label16.Text = "4"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(16, 71)
        Me.label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(13, 13)
        Me.label17.TabIndex = 2
        Me.label17.Text = "3"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(16, 50)
        Me.label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(13, 13)
        Me.label18.TabIndex = 1
        Me.label18.Text = "2"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(16, 26)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(13, 13)
        Me.label19.TabIndex = 0
        Me.label19.Text = "1"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.txtProbDemanda50)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda40)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda30)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda20)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda10)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda0)
        Me.groupBox5.Controls.Add(Me.Label8)
        Me.groupBox5.Controls.Add(Me.Label7)
        Me.groupBox5.Controls.Add(Me.label15)
        Me.groupBox5.Controls.Add(Me.label14)
        Me.groupBox5.Controls.Add(Me.label11)
        Me.groupBox5.Controls.Add(Me.label10)
        Me.groupBox5.Location = New System.Drawing.Point(17, 24)
        Me.groupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox5.Size = New System.Drawing.Size(170, 173)
        Me.groupBox5.TabIndex = 1
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Demanda por dia (decenas)"
        '
        'txtProbDemanda50
        '
        Me.txtProbDemanda50.DecimalPlaces = 2
        Me.txtProbDemanda50.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemanda50.Location = New System.Drawing.Point(40, 141)
        Me.txtProbDemanda50.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemanda50.Name = "txtProbDemanda50"
        Me.txtProbDemanda50.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemanda50.TabIndex = 18
        Me.txtProbDemanda50.Value = New Decimal(New Integer() {18, 0, 0, 131072})
        '
        'txtProbDemanda40
        '
        Me.txtProbDemanda40.DecimalPlaces = 2
        Me.txtProbDemanda40.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemanda40.Location = New System.Drawing.Point(40, 117)
        Me.txtProbDemanda40.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemanda40.Name = "txtProbDemanda40"
        Me.txtProbDemanda40.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemanda40.TabIndex = 17
        Me.txtProbDemanda40.Value = New Decimal(New Integer() {22, 0, 0, 131072})
        '
        'txtProbDemanda30
        '
        Me.txtProbDemanda30.DecimalPlaces = 2
        Me.txtProbDemanda30.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemanda30.Location = New System.Drawing.Point(40, 94)
        Me.txtProbDemanda30.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemanda30.Name = "txtProbDemanda30"
        Me.txtProbDemanda30.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemanda30.TabIndex = 16
        Me.txtProbDemanda30.Value = New Decimal(New Integer() {25, 0, 0, 131072})
        '
        'txtProbDemanda20
        '
        Me.txtProbDemanda20.DecimalPlaces = 2
        Me.txtProbDemanda20.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemanda20.Location = New System.Drawing.Point(40, 72)
        Me.txtProbDemanda20.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemanda20.Name = "txtProbDemanda20"
        Me.txtProbDemanda20.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemanda20.TabIndex = 15
        Me.txtProbDemanda20.Value = New Decimal(New Integer() {18, 0, 0, 131072})
        '
        'txtProbDemanda10
        '
        Me.txtProbDemanda10.DecimalPlaces = 2
        Me.txtProbDemanda10.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemanda10.Location = New System.Drawing.Point(40, 49)
        Me.txtProbDemanda10.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemanda10.Name = "txtProbDemanda10"
        Me.txtProbDemanda10.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemanda10.TabIndex = 14
        Me.txtProbDemanda10.Value = New Decimal(New Integer() {12, 0, 0, 131072})
        '
        'txtProbDemanda0
        '
        Me.txtProbDemanda0.DecimalPlaces = 2
        Me.txtProbDemanda0.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtProbDemanda0.Location = New System.Drawing.Point(40, 24)
        Me.txtProbDemanda0.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtProbDemanda0.Name = "txtProbDemanda0"
        Me.txtProbDemanda0.Size = New System.Drawing.Size(76, 20)
        Me.txtProbDemanda0.TabIndex = 13
        Me.txtProbDemanda0.Value = New Decimal(New Integer() {5, 0, 0, 131072})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 143)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "50"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "40"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(16, 96)
        Me.label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(19, 13)
        Me.label15.TabIndex = 3
        Me.label15.Text = "30"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(16, 74)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(19, 13)
        Me.label14.TabIndex = 2
        Me.label14.Text = "20"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(16, 51)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(19, 13)
        Me.label11.TabIndex = 1
        Me.label11.Text = "10"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(16, 28)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(13, 13)
        Me.label10.TabIndex = 0
        Me.label10.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCosto3)
        Me.GroupBox1.Controls.Add(Me.txtCosto2)
        Me.GroupBox1.Controls.Add(Me.txtCosto1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(225, 99)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costo de las decenas pedidas  (en pesos)"
        '
        'txtCosto3
        '
        Me.txtCosto3.DecimalPlaces = 2
        Me.txtCosto3.Location = New System.Drawing.Point(110, 68)
        Me.txtCosto3.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtCosto3.Name = "txtCosto3"
        Me.txtCosto3.Size = New System.Drawing.Size(76, 20)
        Me.txtCosto3.TabIndex = 9
        Me.txtCosto3.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'txtCosto2
        '
        Me.txtCosto2.DecimalPlaces = 2
        Me.txtCosto2.Location = New System.Drawing.Point(110, 45)
        Me.txtCosto2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtCosto2.Name = "txtCosto2"
        Me.txtCosto2.Size = New System.Drawing.Size(76, 20)
        Me.txtCosto2.TabIndex = 8
        Me.txtCosto2.Value = New Decimal(New Integer() {280, 0, 0, 0})
        '
        'txtCosto1
        '
        Me.txtCosto1.DecimalPlaces = 2
        Me.txtCosto1.Location = New System.Drawing.Point(110, 24)
        Me.txtCosto1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtCosto1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCosto1.Name = "txtCosto1"
        Me.txtCosto1.Size = New System.Drawing.Size(76, 20)
        Me.txtCosto1.TabIndex = 7
        Me.txtCosto1.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 71)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "200 o Más"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 50)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "101-200"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 26)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "0-100"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 26)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Pedido (decenas):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 50)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "CA (en pesos)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 71)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "CS (en pesos)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCantidadPedido)
        Me.GroupBox2.Controls.Add(Me.txtCA)
        Me.GroupBox2.Controls.Add(Me.txtCS)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Location = New System.Drawing.Point(467, 189)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(225, 97)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores del enunciado (por dia y unidad)"
        '
        'txtCantidadPedido
        '
        Me.txtCantidadPedido.Location = New System.Drawing.Point(110, 22)
        Me.txtCantidadPedido.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtCantidadPedido.Name = "txtCantidadPedido"
        Me.txtCantidadPedido.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidadPedido.TabIndex = 12
        Me.txtCantidadPedido.Value = New Decimal(New Integer() {180, 0, 0, 0})
        '
        'txtCA
        '
        Me.txtCA.DecimalPlaces = 2
        Me.txtCA.Location = New System.Drawing.Point(110, 45)
        Me.txtCA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtCA.Name = "txtCA"
        Me.txtCA.Size = New System.Drawing.Size(76, 20)
        Me.txtCA.TabIndex = 11
        Me.txtCA.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'txtCS
        '
        Me.txtCS.DecimalPlaces = 2
        Me.txtCS.Location = New System.Drawing.Point(110, 67)
        Me.txtCS.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtCS.Name = "txtCS"
        Me.txtCS.Size = New System.Drawing.Size(76, 20)
        Me.txtCS.TabIndex = 10
        Me.txtCS.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'txtCantDias
        '
        Me.txtCantDias.Location = New System.Drawing.Point(137, 29)
        Me.txtCantDias.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtCantDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantDias.Name = "txtCantDias"
        Me.txtCantDias.Size = New System.Drawing.Size(79, 20)
        Me.txtCantDias.TabIndex = 28
        Me.txtCantDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 627)
        Me.Controls.Add(Me.txtCantDias)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSimular)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridSimulacion)
        Me.Name = "frm_main"
        Me.Text = "frm_main"
        CType(Me.gridSimulacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        CType(Me.txtProbDemora4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemora3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemora2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemora1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        CType(Me.txtProbDemanda50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemanda40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemanda30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemanda20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemanda10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbDemanda0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCosto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCantidadPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridSimulacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioB As System.Windows.Forms.RadioButton
    Friend WithEvents radioA As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSimular As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents groupBox6 As GroupBox
    Private WithEvents label16 As Label
    Private WithEvents label17 As Label
    Private WithEvents label18 As Label
    Private WithEvents label19 As Label
    Private WithEvents groupBox5 As GroupBox
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label20 As Label
    Private WithEvents Label22 As Label
    Private WithEvents Label21 As Label
    Private WithEvents Label9 As Label
    Private WithEvents GroupBox2 As GroupBox
    Friend WithEvents relojDiaCol As DataGridViewTextBoxColumn
    Friend WithEvents rndDemandaCol As DataGridViewTextBoxColumn
    Friend WithEvents demandaCol As DataGridViewTextBoxColumn
    Friend WithEvents rndDemoraCol As DataGridViewTextBoxColumn
    Friend WithEvents demoraCol As DataGridViewTextBoxColumn
    Friend WithEvents ordenColocadaCol As DataGridViewTextBoxColumn
    Friend WithEvents llegadaPedidoCol As DataGridViewTextBoxColumn
    Friend WithEvents stockCol As DataGridViewTextBoxColumn
    Friend WithEvents costoOrdenamientoCol As DataGridViewTextBoxColumn
    Friend WithEvents costoMantenimientoCol As DataGridViewTextBoxColumn
    Friend WithEvents costoStockOutCol As DataGridViewTextBoxColumn
    Friend WithEvents costoTotalDiaCol As DataGridViewTextBoxColumn
    Friend WithEvents costoAcumuladoCol As DataGridViewTextBoxColumn
    Friend WithEvents txtCantDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDesde As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtHasta As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCosto1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCosto2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCosto3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCantidadPedido As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCA As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCS As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemora4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemora3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemora2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemora1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemanda50 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemanda40 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemanda30 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemanda20 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemanda10 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProbDemanda0 As System.Windows.Forms.NumericUpDown
End Class
