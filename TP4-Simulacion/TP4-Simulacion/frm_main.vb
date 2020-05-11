Public Class frm_main

    Dim cantDias, desde, hasta, frecuenciaPedido, diaLlegadaPedido, cantStockPedido, stockDisponible As Integer
    Dim costoAcum As Double
    Dim isA As Boolean
    Dim mostrar As Boolean = False
    Dim rowCount As Integer

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        radioA.Select()
        txtCantDias.Value = 1
        txtDesde.Value = 1
        txtHasta.Value = 1
        Text = "SIM TP4 - Montecarlo - Grupo 7"
    End Sub
 
    Private Sub btnSimular_Click(sender As System.Object, e As System.EventArgs) Handles btnSimular.Click

        If checkValues() Then
            If isA Then
                frecuenciaPedido = 7
            Else
                frecuenciaPedido = 10
            End If
            simular()

        End If
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub gridSimulacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSimulacion.CellContentClick

    End Sub

    Private Sub radioB_CheckedChanged(sender As Object, e As EventArgs) Handles radioB.CheckedChanged
        txtCantidadPedido.Enabled = False
    End Sub

    Private Sub radioA_CheckedChanged(sender As Object, e As EventArgs) Handles radioA.CheckedChanged
        txtCantidadPedido.Enabled = True
    End Sub

    Private Sub simular()
        Dim demanda As Integer
        Dim acumuladorCantDecenasAPedirPoliticaB As Integer = 0
        Dim diaUltimoPedido As Integer = 0
        Dim costoOrdenamiento, costoMantenimiento, costoStockOut, costoTotalDelDia As Double
        Dim cantidadPedido As Integer
        Dim costoStockOutIndvidual As Double = txtCS.Text
        Dim costoAlmacenamientoIndividual As Double = txtCA.Text

        cantDias = txtCantDias.Text
        desde = txtDesde.Text
        hasta = txtHasta.Text

        cantidadPedido = txtCantidadPedido.Text
        costoAcum = 0
        stockDisponible = 20
        gridSimulacion.Rows.Clear()
        rowCount = -1
        mostrar = False
        Dim rndDemanda As Double
        For i = 1 To cantDias

            costoOrdenamiento = 0
            costoMantenimiento = 0
            costoStockOut = 0
            costoTotalDelDia = 0
            If i >= desde And i <= (desde + hasta) Then
                rowCount += 1
                gridSimulacion.Rows.Add(New String() {i, "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-"})
                mostrar = True
            Else
                mostrar = False
            End If

            If i = diaLlegadaPedido Then
                stockDisponible += cantStockPedido
            End If

            rndDemanda = Rnd()
            demanda = getDemanda(rndDemanda)
            acumuladorCantDecenasAPedirPoliticaB += demanda
            If demanda > stockDisponible Then
                costoStockOut = (demanda - stockDisponible) * 10 * costoStockOutIndvidual
                stockDisponible = 0
            Else
                costoMantenimiento = (stockDisponible - demanda) * 10 * costoAlmacenamientoIndividual
                stockDisponible -= demanda
            End If


            If i = 1 Or diaUltimoPedido + frecuenciaPedido = i Then
                If isA Then
                    costoOrdenamiento = realizarPedido(i, cantidadPedido)
                Else
                    costoOrdenamiento = realizarPedido(i, acumuladorCantDecenasAPedirPoliticaB)
                End If

                diaUltimoPedido = i
                acumuladorCantDecenasAPedirPoliticaB = 0
            End If

            costoTotalDelDia = costoMantenimiento + costoOrdenamiento + costoStockOut
            costoAcum += costoTotalDelDia
            If mostrar Then
                gridSimulacion.Rows(rowCount).Cells(1).Value = rndDemanda
                gridSimulacion.Rows(rowCount).Cells(2).Value = demanda
                gridSimulacion.Rows(rowCount).Cells(7).Value = stockDisponible
                gridSimulacion.Rows(rowCount).Cells(8).Value = "$" & costoOrdenamiento
                gridSimulacion.Rows(rowCount).Cells(9).Value = "$" & costoMantenimiento
                gridSimulacion.Rows(rowCount).Cells(10).Value = "$" & costoStockOut
                gridSimulacion.Rows(rowCount).Cells(11).Value = "$" & costoTotalDelDia
                gridSimulacion.Rows(rowCount).Cells(12).Value = "$" & costoAcum
            End If
        Next
        rowCount = rowCount + 1
        gridSimulacion.Rows.Add(New String() {cantDias, "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-"})
        gridSimulacion.Rows(rowCount).Cells(1).Value = rndDemanda
        gridSimulacion.Rows(rowCount).Cells(2).Value = demanda
        gridSimulacion.Rows(rowCount).Cells(7).Value = stockDisponible
        gridSimulacion.Rows(rowCount).Cells(8).Value = "$" & costoOrdenamiento
        gridSimulacion.Rows(rowCount).Cells(9).Value = "$" & costoMantenimiento
        gridSimulacion.Rows(rowCount).Cells(10).Value = "$" & costoStockOut
        gridSimulacion.Rows(rowCount).Cells(11).Value = "$" & costoTotalDelDia
        gridSimulacion.Rows(rowCount).Cells(12).Value = "$" & costoAcum


        txtTotal.Text = costoAcum
    End Sub

    Function realizarPedido(dia As Integer, cantPedir As Integer) As Double
        Dim rndDemora As Double = Rnd()
        Dim demora As Integer = getDemora(rndDemora)
        diaLlegadaPedido = dia + demora

        If mostrar Then
            gridSimulacion.Rows(rowCount).Cells(3).Value = rndDemora
            gridSimulacion.Rows(rowCount).Cells(4).Value = demora
            gridSimulacion.Rows(rowCount).Cells(5).Value = "SI"
            gridSimulacion.Rows(rowCount).Cells(6).Value = diaLlegadaPedido

        End If

        cantStockPedido = cantPedir

        Return getCosto(cantPedir) * cantPedir
    End Function

    Function getDemanda(rndDemanda As Double) As Integer
        Dim demanda As Integer
        Dim probDemanda0 As Double = txtProbDemanda0.Text
        Dim probDemanda10 As Double = txtProbDemanda10.Text + probDemanda0
        Dim probDemanda20 As Double = txtProbDemanda20.Text + probDemanda10
        Dim probDemanda30 As Double = txtProbDemanda30.Text + probDemanda20
        Dim probDemanda40 As Double = txtProbDemanda40.Text + probDemanda30
        Dim probDemanda50 As Double = txtProbDemanda50.Text + probDemanda40

        If rndDemanda < probDemanda0 Then
            demanda = 0
        End If
        If rndDemanda >= probDemanda0 And rndDemanda < probDemanda10 Then
            demanda = 10
        End If
        If rndDemanda >= probDemanda10 And rndDemanda < probDemanda20 Then
            demanda = 20
        End If
        If rndDemanda >= probDemanda20 And rndDemanda < probDemanda30 Then
            demanda = 30
        End If
        If rndDemanda >= probDemanda30 And rndDemanda < probDemanda40 Then
            demanda = 40
        End If
        If rndDemanda >= probDemanda40 And rndDemanda < probDemanda50 Then
            demanda = 50
        End If

        Return demanda
    End Function

    Function getDemora(rndDemora As Double) As Integer
        Dim demora As Integer
        Dim probDemora1 As Double = txtProbDemora1.Text
        Dim probDemora2 As Double = txtProbDemora2.Text + probDemora1
        Dim probDemora3 As Double = txtProbDemora3.Text + probDemora2
        Dim probDemora4 As Double = txtProbDemora4.Text + probDemora3

        If rndDemora < probDemora1 Then
            demora = 1
        End If
        If rndDemora >= probDemora1 And rndDemora < probDemora2 Then
            demora = 2
        End If
        If rndDemora >= probDemora2 And rndDemora < probDemora3 Then
            demora = 3
        End If
        If rndDemora >= probDemora3 And rndDemora < probDemora4 Then
            demora = 4
        End If

        Return demora
    End Function

    Function getCosto(pedido As Integer) As Integer
        Dim costo As Integer
        Dim costo1 As Double = txtCosto1.Text
        Dim costo2 As Double = txtCosto2.Text
        Dim costo3 As Double = txtCosto3.Text

        If pedido <= 100 Then
            costo = 200
        End If
        If pedido > 100 And pedido <= 200 Then
            costo = 280
        End If
        If pedido > 200 Then
            costo = 300
        End If

        Return costo
    End Function

    Function checkValues() As Boolean
        If txtHasta.Value > txtCantDias.Value Then
            MsgBox("Hasta debe ser un número menor o igual a " & txtCantDias.Value, MsgBoxStyle.Critical, AcceptButton)
            txtHasta.Focus()
            Return False
        End If

        If txtDesde.Value > txtHasta.Value Then
            MsgBox("Desde debe ser un número menor o igual a " & txtHasta.Value, MsgBoxStyle.Critical, AcceptButton)
            txtHasta.Focus()
            Return False
        End If

        If Not ValidateProbDemandas() Then
            MsgBox("La sumatoria de probabilidades de Demandas debe ser igual a 1", MsgBoxStyle.Critical, AcceptButton)
            txtProbDemora1.Focus()
            Return False
        End If

        If Not ValidateProbDemoras() Then
            MsgBox("La sumatoria de probabilidades de Demoras debe ser igual a 1", MsgBoxStyle.Critical, AcceptButton)
            txtProbDemora1.Focus()
            Return False
        End If

        If radioA.Checked Then
            isA = True
        Else
            isA = False
        End If

        Return True

    End Function

    Function ValidateProbDemandas() As Boolean
        Dim probTotal As Double = 0

        probTotal += txtProbDemanda0.Value
        probTotal += txtProbDemanda10.Value
        probTotal += txtProbDemanda20.Value
        probTotal += txtProbDemanda30.Value
        probTotal += txtProbDemanda40.Value
        probTotal += txtProbDemanda50.Value

        Return probTotal.Equals(1.0)
    End Function

    Function ValidateProbDemoras() As Boolean
        Dim probTotal As Double = 0

        probTotal += txtProbDemora1.Value
        probTotal += txtProbDemora2.Value
        probTotal += txtProbDemora3.Value
        probTotal += txtProbDemora4.Value

        Return probTotal.Equals(1.0)
    End Function

    Private Sub txtCantDias_ValueChanged(sender As Object, e As EventArgs) Handles txtCantDias.ValueChanged
        txtHasta.Value = txtCantDias.Value
    End Sub

End Class