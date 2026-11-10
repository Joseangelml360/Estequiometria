Imports Negocio
Imports Datos
Imports Entidades
Public Class FrmCalculoEpoxi
    Private ReadOnly calculos As New CalculosEpoxiNegocio
    Private ReadOnly negocioFormulas As New FormulasNegocio

    Private EqEpoxiFormulaA As Decimal
    Private EqAminaFormulaB As Decimal
    Private Sub FrmCalculoEpoxi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFormulas()
    End Sub

    Private Sub CargarFormulas()

        CboFormulaA.DataSource = negocioFormulas.ObtenerFormulasPorTipo("POX")

        CboFormulaA.DisplayMember = "Formula"
        CboFormulaA.ValueMember = "IdFormula"

        CboFormulaB.DataSource =
            negocioFormulas.ObtenerFormulasPorTipo("EAM")

        CboFormulaB.DisplayMember = "Formula"
        CboFormulaB.ValueMember = "IdFormula"

        CboFormulaA.SelectedIndex = -1
        CboFormulaB.SelectedIndex = -1

    End Sub

    Private Sub CboFormulaA_SelectionChangeCommitted(sender As Object, e As EventArgs) _
       Handles CboFormulaA.SelectionChangeCommitted

        Dim IdFormulaA As Integer = CInt(CboFormulaA.SelectedValue)

        EqEpoxiFormulaA = calculos.CalcularEquivalentesEpoxi(IdFormulaA).ToString("N4")

        TxtEqEpoxi.Text = EqEpoxiFormulaA.ToString("N4")

    End Sub

    Private Sub CboFormulaB_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles CboFormulaB.SelectionChangeCommitted

        Dim IdFormulaB As Integer = CInt(CboFormulaB.SelectedValue)

        EqAminaFormulaB = calculos.CalcularEquivalentesAmina(IdFormulaB).ToString("N4")

        TxtEqAmina.Text = EqAminaFormulaB.ToString("N4")

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim EqEpoxiTotal As Decimal
        Dim EqAminaTotal As Decimal
        Dim Relacion As Decimal
        Dim ExcesoNCO As Decimal
        Dim IndiceNCO As Decimal

        If CboFormulaA.SelectedValue Is Nothing Then Exit Sub
        If CboFormulaB.SelectedValue Is Nothing Then Exit Sub

        EqEpoxiTotal = EqEpoxiFormulaA * NumParteA.Value / 100D

        EqAminaTotal = EqAminaFormulaB * NumParteB.Value / 100D

        If EqEpoxiTotal = 0 OrElse EqAminaTotal = 0 Then Exit Sub

        Relacion = EqAminaTotal / EqEpoxiTotal

        IndiceNCO = Relacion * 100D

        ExcesoNCO = IndiceNCO - 100D

        TxtEqEpoxiTotal.Text = EqEpoxiTotal.ToString("N4")

        TxtEqAminaTotal.Text = EqAminaTotal.ToString("N4")

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
        If EqEpoxiFormulaA = 0 Then Exit Sub
        If EqAminaFormulaB = 0 Then Exit Sub

        NumParteA.Value = 100D

        NumParteB.Value = Math.Round((EqEpoxiFormulaA / EqAminaFormulaB) * 100D, 3)

        BtnCalcular.PerformClick()

    End Sub

    Private Sub FrmCalculoEpoxi_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 6001)
    End Sub

    Private Sub CboFormulaA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFormulaA.SelectedIndexChanged
        TxtDescripcionA.Text = CboFormulaA.Text
    End Sub

    Private Sub CboFormulaB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFormulaB.SelectedIndexChanged
        TxtDescripcionB.Text = CboFormulaB.Text
    End Sub
End Class