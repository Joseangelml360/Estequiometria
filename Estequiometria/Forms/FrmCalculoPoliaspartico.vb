Imports Negocio
Imports Entidades

Public Class FrmCalculoPoliaspartico
    Private ReadOnly negocioFormulas As New FormulasNegocio
    Private ReadOnly calculos As New CalculosPoliasparticoNegocio
    Private EqNHFormulaA As Decimal
    Private EqNCOFormulaB As Decimal

    Private Sub FrmCalculoPoliaspartico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BtnVolver.Visible = False
        Me.Height = 600
        CargarFormulas()

    End Sub

    Private Sub CargarFormulas()

        CboFormulaA.DataSource = negocioFormulas.ObtenerFormulasPorTipo("ASP")


        CboFormulaA.DisplayMember = "Formula"
        CboFormulaA.ValueMember = "IdFormula"

        CboFormulaB.DataSource =
            negocioFormulas.ObtenerFormulasPorTipo("EPU")

        CboFormulaB.DisplayMember = "Formula"
        CboFormulaB.ValueMember = "IdFormula"

        CboFormulaA.SelectedIndex = -1
        CboFormulaB.SelectedIndex = -1

    End Sub

    Private Sub CboFormulaA_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles CboFormulaA.SelectionChangeCommitted

        Dim IdFormulaA As Integer = CInt(CboFormulaA.SelectedValue)

        EqNHFormulaA = calculos.CalcularEquivalentesNH(IdFormulaA).ToString("N4")

        TxtEqNH.Text = EqNHFormulaA.ToString("N4")

    End Sub

    Private Sub CboFormulaB_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles CboFormulaB.SelectionChangeCommitted

        Dim IdFormulaB As Integer = CInt(CboFormulaB.SelectedValue)

        EqNCOFormulaB = calculos.CalcularEquivalentesNCO(IdFormulaB).ToString("N4")

        TxtEqNCO.Text = EqNCOFormulaB.ToString("N4")

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim EqNHTotal As Decimal
        Dim EqNCOTotal As Decimal
        Dim Relacion As Decimal
        Dim ExcesoNCO As Decimal
        Dim IndiceNCO As Decimal

        If Me.TxtEqNH.ReadOnly Then
            If CboFormulaA.SelectedValue Is Nothing Then Exit Sub
            If CboFormulaB.SelectedValue Is Nothing Then Exit Sub

        End If

        If Me.TxtEqNH.ReadOnly = False Then
            If Me.TxtEqNH.Text Is Nothing Then Exit Sub
            If Me.TxtEqNCO.Text Is Nothing Then Exit Sub
        End If

        EqNHTotal = EqNHFormulaA * NumParteA.Value / 100D

        EqNCOTotal = EqNCOFormulaB * NumParteB.Value / 100D

        If EqNHTotal = 0 OrElse EqNCOTotal = 0 Then Exit Sub

        Relacion = EqNCOTotal / EqNHTotal

        IndiceNCO = Relacion * 100D

        ExcesoNCO = IndiceNCO - 100D

        TxtEqNHTotal.Text = EqNHTotal.ToString("N4")

        TxtEqNCOTotal.Text = EqNCOTotal.ToString("N4")

        TxtIndiceNCO.Text = IndiceNCO.ToString("N2") & " %"

        TxtExcesoNCO.Text = ExcesoNCO.ToString("N2") & " %"

        If TxtEqNH.ReadOnly Then

            Dim dtDetalle As DataTable = CalculosEntidad.TablaDetalleCalculoEstequiometrico()

            Dim dtA As DataTable = calculos.ObtenerDetalleCalculoEstequiometrico(CInt(CboFormulaA.SelectedValue), "A")

            Dim dtB As DataTable = calculos.ObtenerDetalleCalculoEstequiometrico(CInt(CboFormulaB.SelectedValue), "B")

            For Each fila As DataRow In dtA.Rows
                dtDetalle.ImportRow(fila)
            Next

            For Each fila As DataRow In dtB.Rows
                dtDetalle.ImportRow(fila)
            Next

            DgvCalculo.DataSource = Nothing
            DgvCalculo.DataSource = dtDetalle

            With DgvCalculo

                .Columns("MateriaPrima").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                .Columns("Cantidad").DefaultCellStyle.Format = "N3"

                .Columns("Valor").DefaultCellStyle.Format = "N3"

                .Columns("Equivalentes").DefaultCellStyle.Format = "N5"

            End With

        End If



    End Sub

    Private Sub BtnAutomatico_Click(sender As Object, e As EventArgs) Handles BtnAutomatico.Click

        If TxtEqNH.ReadOnly Then
            If EqNHFormulaA = 0 Then Exit Sub
            If EqNCOFormulaB = 0 Then Exit Sub
        End If

        If Me.TxtEqNH.ReadOnly = False Then
            If Me.TxtEqNH.Text Is Nothing Then Exit Sub
            If Me.TxtEqNCO.Text Is Nothing Then Exit Sub
        End If

        NumParteA.Value = 100D

        NumParteB.Value = Math.Round((EqNHFormulaA / EqNCOFormulaB) * 100D, 3)

        BtnCalcular.PerformClick()

    End Sub

    Private Sub FrmCalculoPoliaspartico_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 5001)
    End Sub

    Private Sub CboFormulaA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFormulaA.SelectedIndexChanged
        Me.TxtDescripcionA.Text = CboFormulaA.Text
    End Sub

    Private Sub CboFormulaB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFormulaB.SelectedIndexChanged
        Me.TxtDescripcionB.Text = CboFormulaB.Text
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Me.BtnVolver.Visible = True
        Me.BtnLimpiar.Visible = False
        Me.DgvCalculo.Visible = False
        Me.Height = 400
        Me.TxtEqNCO.ReadOnly = False
        Me.TxtEqNH.ReadOnly = False
        Me.CboFormulaA.SelectedIndex = -1
        Me.CboFormulaA.Enabled = False
        Me.CboFormulaB.SelectedIndex = -1
        Me.CboFormulaB.Enabled = False
        Me.TxtDescripcionA.Clear()
        Me.TxtDescripcionB.Clear()
        Me.TxtEqNH.Clear()
        Me.TxtEqNCO.Clear()
        Me.TxtEqNHTotal.Clear()
        Me.TxtEqNCOTotal.Clear()
        Me.TxtIndiceNCO.Clear()
        Me.TxtExcesoNCO.Clear()

    End Sub

    Private Sub TxtEqOH_TextChanged(sender As Object, e As EventArgs) Handles TxtEqNH.TextChanged
        EqNHFormulaA = CDec(Val(Me.TxtEqNH.Text))
    End Sub

    Private Sub TxtEqNCO_TextChanged(sender As Object, e As EventArgs) Handles TxtEqNCO.TextChanged
        EqNCOFormulaB = CDec(Val(Me.TxtEqNCO.Text))
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click

        Me.BtnVolver.Visible = False
        Me.BtnLimpiar.Visible = True
        Me.DgvCalculo.Visible = True
        Me.Height = 600
        Me.TxtEqNCO.ReadOnly = True
        Me.TxtEqNH.ReadOnly = True
        Me.CboFormulaA.Enabled = True
        Me.CboFormulaB.Enabled = True
        Me.TxtDescripcionA.Clear()
        Me.TxtDescripcionB.Clear()
        Me.TxtEqNH.Clear()
        Me.TxtEqNCO.Clear()
        Me.TxtEqNHTotal.Clear()
        Me.TxtEqNCOTotal.Clear()
        Me.TxtIndiceNCO.Clear()
        Me.TxtExcesoNCO.Clear()

    End Sub


End Class