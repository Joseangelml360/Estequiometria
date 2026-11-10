Imports Negocio
Imports Datos
Imports Entidades
Public Class FrmCalculoEpoxi
    Private ReadOnly calculos As New CalculosEpoxiNegocio
    Private ReadOnly negocioFormulas As New FormulasNegocio

    Private EqEpoxiFormulaA As Decimal
    Private EqAminaFormulaB As Decimal
    Private Sub FrmCalculoEpoxi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BtnVolver.Visible = False
        Me.Height = 600
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

        If Me.TxtEqEpoxi.ReadOnly Then
            If CboFormulaA.SelectedValue Is Nothing Then Exit Sub
            If CboFormulaB.SelectedValue Is Nothing Then Exit Sub

        End If

        If Me.TxtEqEpoxi.ReadOnly = False Then
            If Me.TxtEqEpoxi.Text Is Nothing Then Exit Sub
            If Me.TxtEqAmina.Text Is Nothing Then Exit Sub
        End If

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

        If Me.TxtEqEpoxi.ReadOnly Then

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

        If Me.TxtEqEpoxi.ReadOnly Then
            If EqEpoxiFormulaA = 0 Then Exit Sub
            If EqAminaFormulaB = 0 Then Exit Sub
        End If

        If Me.TxtEqEpoxi.ReadOnly = False Then
            If Me.TxtEqEpoxi.Text Is Nothing Then Exit Sub
            If Me.TxtEqAmina.Text Is Nothing Then Exit Sub
        End If

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

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Me.BtnVolver.Visible = True
        Me.BtnLimpiar.Visible = False
        Me.DgvCalculo.Visible = False
        Me.Height = 400
        Me.TxtEqEpoxi.ReadOnly = False
        Me.TxtEqAmina.ReadOnly = False
        Me.CboFormulaA.SelectedIndex = -1
        Me.CboFormulaA.Enabled = False
        Me.CboFormulaB.SelectedIndex = -1
        Me.CboFormulaB.Enabled = False
        Me.TxtDescripcionA.Clear()
        Me.TxtDescripcionB.Clear()
        Me.TxtEqEpoxi.Clear()
        Me.TxtEqAmina.Clear()
        Me.TxtEqEpoxiTotal.Clear()
        Me.TxtEqAminaTotal.Clear()
        Me.TxtIndiceNCO.Clear()
        Me.TxtExcesoNCO.Clear()

    End Sub

    Private Sub TxtEqEpoxi_TextChanged(sender As Object, e As EventArgs) Handles TxtEqEpoxi.TextChanged
        EqEpoxiFormulaA = CDec(Val(Me.TxtEqEpoxi.Text))
    End Sub

    Private Sub TxtEqAmina_TextChanged(sender As Object, e As EventArgs) Handles TxtEqAmina.TextChanged
        EqAminaFormulaB = CDec(Val(Me.TxtEqAmina.Text))
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click

        Me.BtnVolver.Visible = False
        Me.BtnLimpiar.Visible = True
        Me.DgvCalculo.Visible = True
        Me.Height = 600
        Me.TxtEqAmina.ReadOnly = True
        Me.TxtEqEpoxi.ReadOnly = True
        Me.CboFormulaA.Enabled = True
        Me.CboFormulaB.Enabled = True
        Me.TxtDescripcionA.Clear()
        Me.TxtDescripcionB.Clear()
        Me.TxtEqEpoxi.Clear()
        Me.TxtEqAmina.Clear()
        Me.TxtEqEpoxiTotal.Clear()
        Me.TxtEqAminaTotal.Clear()
        Me.TxtIndiceNCO.Clear()
        Me.TxtExcesoNCO.Clear()

    End Sub

End Class