Imports Negocio
Imports Entidades

Public Class FrmCalculoPoliaspartico
    Private ReadOnly negocioFormulas As New FormulasNegocio
    Private ReadOnly calculos As New CalculosPoliasparticoNegocio
    Private EqNHFormulaA As Decimal
    Private EqNCOFormulaB As Decimal

    Private Sub FrmCalculoPoliaspartico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If CboFormulaA.SelectedValue Is Nothing Then Exit Sub
        If CboFormulaB.SelectedValue Is Nothing Then Exit Sub

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

        Dim dtDetalle As DataTable =
    CalculosEntidad.TablaDetalleCalculoEstequiometrico()

        Dim dtA As DataTable =
    calculos.ObtenerDetalleCalculoEstequiometrico(
        CInt(CboFormulaA.SelectedValue),
        "A")

        Dim dtB As DataTable =
    calculos.ObtenerDetalleCalculoEstequiometrico(
        CInt(CboFormulaB.SelectedValue),
        "B")

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

    End Sub

    Private Sub BtnAutomatico_Click(sender As Object, e As EventArgs) Handles BtnAutomatico.Click
        If EqNHFormulaA = 0 Then Exit Sub
        If EqNCOFormulaB = 0 Then Exit Sub

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
End Class