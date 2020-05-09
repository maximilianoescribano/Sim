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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.txtCantDias = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioB = New System.Windows.Forms.RadioButton()
        Me.radioA = New System.Windows.Forms.RadioButton()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSimular = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtProbDemora4 = New System.Windows.Forms.TextBox()
        Me.txtProbDemora3 = New System.Windows.Forms.TextBox()
        Me.txtProbDemora2 = New System.Windows.Forms.TextBox()
        Me.txtProbDemora1 = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtProbDemanda50 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProbDemanda40 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProbDemanda30 = New System.Windows.Forms.TextBox()
        Me.txtProbDemanda20 = New System.Windows.Forms.TextBox()
        Me.txtProbDemanda10 = New System.Windows.Forms.TextBox()
        Me.txtProbDemanda0 = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCosto3 = New System.Windows.Forms.TextBox()
        Me.txtCosto2 = New System.Windows.Forms.TextBox()
        Me.txtCosto1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidadPedido = New System.Windows.Forms.TextBox()
        Me.txtCA = New System.Windows.Forms.TextBox()
        Me.txtCS = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.gridSimulacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridSimulacion
        '
        Me.gridSimulacion.AllowUserToAddRows = False
        Me.gridSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSimulacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.relojDiaCol, Me.rndDemandaCol, Me.demandaCol, Me.rndDemoraCol, Me.demoraCol, Me.ordenColocadaCol, Me.llegadaPedidoCol, Me.stockCol, Me.costoOrdenamientoCol, Me.costoMantenimientoCol, Me.costoStockOutCol, Me.costoTotalDiaCol, Me.costoAcumuladoCol})
        Me.gridSimulacion.Location = New System.Drawing.Point(13, 377)
        Me.gridSimulacion.Margin = New System.Windows.Forms.Padding(4)
        Me.gridSimulacion.Name = "gridSimulacion"
        Me.gridSimulacion.Size = New System.Drawing.Size(1280, 358)
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
        DataGridViewCellStyle2.NullValue = Nothing
        Me.rndDemandaCol.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.Label1.Location = New System.Drawing.Point(19, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de Días"
        '
        'txtCantDias
        '
        Me.txtCantDias.Location = New System.Drawing.Point(183, 38)
        Me.txtCantDias.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantDias.Name = "txtCantDias"
        Me.txtCantDias.Size = New System.Drawing.Size(132, 22)
        Me.txtCantDias.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.radioB)
        Me.Panel1.Controls.Add(Me.radioA)
        Me.Panel1.Location = New System.Drawing.Point(379, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 73)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Política"
        '
        'radioB
        '
        Me.radioB.AutoSize = True
        Me.radioB.Location = New System.Drawing.Point(95, 43)
        Me.radioB.Margin = New System.Windows.Forms.Padding(4)
        Me.radioB.Name = "radioB"
        Me.radioB.Size = New System.Drawing.Size(38, 21)
        Me.radioB.TabIndex = 1
        Me.radioB.TabStop = True
        Me.radioB.Text = "B"
        Me.radioB.UseVisualStyleBackColor = True
        '
        'radioA
        '
        Me.radioA.AutoSize = True
        Me.radioA.Location = New System.Drawing.Point(95, 9)
        Me.radioA.Margin = New System.Windows.Forms.Padding(4)
        Me.radioA.Name = "radioA"
        Me.radioA.Size = New System.Drawing.Size(38, 21)
        Me.radioA.TabIndex = 0
        Me.radioA.TabStop = True
        Me.radioA.Text = "A"
        Me.radioA.UseVisualStyleBackColor = True
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(145, 9)
        Me.txtDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(132, 22)
        Me.txtDesde.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Desde"
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(145, 43)
        Me.txtHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(132, 22)
        Me.txtHasta.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtDesde)
        Me.Panel2.Controls.Add(Me.txtHasta)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(547, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 73)
        Me.Panel2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mostrar"
        '
        'btnSimular
        '
        Me.btnSimular.Location = New System.Drawing.Point(883, 15)
        Me.btnSimular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimular.Name = "btnSimular"
        Me.btnSimular.Size = New System.Drawing.Size(100, 28)
        Me.btnSimular.TabIndex = 9
        Me.btnSimular.Text = "Simular"
        Me.btnSimular.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(140, 738)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtTotal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 739)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Costo Total $"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.groupBox6)
        Me.groupBox3.Controls.Add(Me.groupBox5)
        Me.groupBox3.Location = New System.Drawing.Point(22, 95)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(531, 257)
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
        Me.groupBox6.Location = New System.Drawing.Point(254, 41)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(254, 138)
        Me.groupBox6.TabIndex = 8
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "Demora (en dias)"
        '
        'txtProbDemora4
        '
        Me.txtProbDemora4.Location = New System.Drawing.Point(57, 110)
        Me.txtProbDemora4.Name = "txtProbDemora4"
        Me.txtProbDemora4.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemora4.TabIndex = 7
        Me.txtProbDemora4.Text = "0,25"
        '
        'txtProbDemora3
        '
        Me.txtProbDemora3.Location = New System.Drawing.Point(57, 84)
        Me.txtProbDemora3.Name = "txtProbDemora3"
        Me.txtProbDemora3.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemora3.TabIndex = 6
        Me.txtProbDemora3.Text = "0,40"
        '
        'txtProbDemora2
        '
        Me.txtProbDemora2.Location = New System.Drawing.Point(57, 57)
        Me.txtProbDemora2.Name = "txtProbDemora2"
        Me.txtProbDemora2.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemora2.TabIndex = 5
        Me.txtProbDemora2.Text = "0,20"
        '
        'txtProbDemora1
        '
        Me.txtProbDemora1.Location = New System.Drawing.Point(57, 29)
        Me.txtProbDemora1.Name = "txtProbDemora1"
        Me.txtProbDemora1.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemora1.TabIndex = 4
        Me.txtProbDemora1.Text = "0,15"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(21, 115)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(16, 17)
        Me.label16.TabIndex = 3
        Me.label16.Text = "4"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(21, 87)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(16, 17)
        Me.label17.TabIndex = 2
        Me.label17.Text = "3"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(21, 61)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(16, 17)
        Me.label18.TabIndex = 1
        Me.label18.Text = "2"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(21, 32)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(16, 17)
        Me.label19.TabIndex = 0
        Me.label19.Text = "1"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.txtProbDemanda50)
        Me.groupBox5.Controls.Add(Me.Label8)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda40)
        Me.groupBox5.Controls.Add(Me.Label7)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda30)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda20)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda10)
        Me.groupBox5.Controls.Add(Me.txtProbDemanda0)
        Me.groupBox5.Controls.Add(Me.label15)
        Me.groupBox5.Controls.Add(Me.label14)
        Me.groupBox5.Controls.Add(Me.label11)
        Me.groupBox5.Controls.Add(Me.label10)
        Me.groupBox5.Location = New System.Drawing.Point(6, 32)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(203, 205)
        Me.groupBox5.TabIndex = 1
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Demanda por dia (decenas)"
        '
        'txtProbDemanda50
        '
        Me.txtProbDemanda50.Location = New System.Drawing.Point(65, 175)
        Me.txtProbDemanda50.Name = "txtProbDemanda50"
        Me.txtProbDemanda50.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemanda50.TabIndex = 11
        Me.txtProbDemanda50.Text = "0,18"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "50"
        '
        'txtProbDemanda40
        '
        Me.txtProbDemanda40.Location = New System.Drawing.Point(65, 144)
        Me.txtProbDemanda40.Name = "txtProbDemanda40"
        Me.txtProbDemanda40.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemanda40.TabIndex = 9
        Me.txtProbDemanda40.Text = "0,22"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "40"
        '
        'txtProbDemanda30
        '
        Me.txtProbDemanda30.Location = New System.Drawing.Point(65, 116)
        Me.txtProbDemanda30.Name = "txtProbDemanda30"
        Me.txtProbDemanda30.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemanda30.TabIndex = 7
        Me.txtProbDemanda30.Text = "0,25"
        '
        'txtProbDemanda20
        '
        Me.txtProbDemanda20.Location = New System.Drawing.Point(65, 88)
        Me.txtProbDemanda20.Name = "txtProbDemanda20"
        Me.txtProbDemanda20.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemanda20.TabIndex = 6
        Me.txtProbDemanda20.Text = "0,18"
        '
        'txtProbDemanda10
        '
        Me.txtProbDemanda10.Location = New System.Drawing.Point(65, 60)
        Me.txtProbDemanda10.Name = "txtProbDemanda10"
        Me.txtProbDemanda10.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemanda10.TabIndex = 5
        Me.txtProbDemanda10.Text = "0,12"
        '
        'txtProbDemanda0
        '
        Me.txtProbDemanda0.Location = New System.Drawing.Point(65, 29)
        Me.txtProbDemanda0.Name = "txtProbDemanda0"
        Me.txtProbDemanda0.Size = New System.Drawing.Size(100, 22)
        Me.txtProbDemanda0.TabIndex = 4
        Me.txtProbDemanda0.Text = "0,05"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(21, 115)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(24, 17)
        Me.label15.TabIndex = 3
        Me.label15.Text = "30"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(21, 87)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(24, 17)
        Me.label14.TabIndex = 2
        Me.label14.Text = "20"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(21, 61)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(24, 17)
        Me.label11.TabIndex = 1
        Me.label11.Text = "10"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(21, 32)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(16, 17)
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
        Me.GroupBox1.Location = New System.Drawing.Point(623, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 138)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costo de las decenas pedidas  (en pesos)"
        '
        'txtCosto3
        '
        Me.txtCosto3.Location = New System.Drawing.Point(101, 84)
        Me.txtCosto3.Name = "txtCosto3"
        Me.txtCosto3.Size = New System.Drawing.Size(100, 22)
        Me.txtCosto3.TabIndex = 6
        Me.txtCosto3.Text = "300"
        '
        'txtCosto2
        '
        Me.txtCosto2.Location = New System.Drawing.Point(101, 57)
        Me.txtCosto2.Name = "txtCosto2"
        Me.txtCosto2.Size = New System.Drawing.Size(100, 22)
        Me.txtCosto2.TabIndex = 5
        Me.txtCosto2.Text = "280"
        '
        'txtCosto1
        '
        Me.txtCosto1.Location = New System.Drawing.Point(101, 29)
        Me.txtCosto1.Name = "txtCosto1"
        Me.txtCosto1.Size = New System.Drawing.Size(100, 22)
        Me.txtCosto1.TabIndex = 4
        Me.txtCosto1.Text = "200"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "200 o Más"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "101-200"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(21, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "0-100"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(21, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Pedido(decenas):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(21, 61)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 17)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "CA (en pesos)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "CS (en pesos)"
        '
        'txtCantidadPedido
        '
        Me.txtCantidadPedido.Location = New System.Drawing.Point(147, 27)
        Me.txtCantidadPedido.Name = "txtCantidadPedido"
        Me.txtCantidadPedido.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidadPedido.TabIndex = 4
        Me.txtCantidadPedido.Text = "180"
        '
        'txtCA
        '
        Me.txtCA.Location = New System.Drawing.Point(147, 55)
        Me.txtCA.Name = "txtCA"
        Me.txtCA.Size = New System.Drawing.Size(100, 22)
        Me.txtCA.TabIndex = 5
        Me.txtCA.Text = "3"
        '
        'txtCS
        '
        Me.txtCS.Location = New System.Drawing.Point(147, 82)
        Me.txtCS.Name = "txtCS"
        Me.txtCS.Size = New System.Drawing.Size(100, 22)
        Me.txtCS.TabIndex = 6
        Me.txtCS.Text = "4"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCS)
        Me.GroupBox2.Controls.Add(Me.txtCA)
        Me.GroupBox2.Controls.Add(Me.txtCantidadPedido)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Location = New System.Drawing.Point(623, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 119)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores del enunciado (por dia y unidad)"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 878)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSimular)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCantDias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridSimulacion)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_main"
        Me.Text = "frm_main"
        CType(Me.gridSimulacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridSimulacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCantDias As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioB As System.Windows.Forms.RadioButton
    Friend WithEvents radioA As System.Windows.Forms.RadioButton
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSimular As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents groupBox6 As GroupBox
    Private WithEvents txtProbDemora4 As TextBox
    Private WithEvents txtProbDemora3 As TextBox
    Private WithEvents txtProbDemora2 As TextBox
    Private WithEvents txtProbDemora1 As TextBox
    Private WithEvents label16 As Label
    Private WithEvents label17 As Label
    Private WithEvents label18 As Label
    Private WithEvents label19 As Label
    Private WithEvents groupBox5 As GroupBox
    Private WithEvents txtProbDemanda50 As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents txtProbDemanda40 As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents txtProbDemanda30 As TextBox
    Private WithEvents txtProbDemanda20 As TextBox
    Private WithEvents txtProbDemanda10 As TextBox
    Private WithEvents txtProbDemanda0 As TextBox
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents txtCosto3 As TextBox
    Private WithEvents txtCosto2 As TextBox
    Private WithEvents txtCosto1 As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label20 As Label
    Private WithEvents Label22 As Label
    Private WithEvents Label21 As Label
    Private WithEvents Label9 As Label
    Private WithEvents txtCantidadPedido As TextBox
    Private WithEvents txtCA As TextBox
    Private WithEvents txtCS As TextBox
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
End Class
