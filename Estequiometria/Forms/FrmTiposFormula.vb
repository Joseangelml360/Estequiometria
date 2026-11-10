Imports Datos
Imports Negocio

Public Class FrmTiposFormula
    Private ReadOnly negocioTiposFormulas As New TiposFormulaNegocio
    Private Property Añadir As Boolean
    Private HayCambios As Boolean = False
    Private dtTiposFormula As DataTable
    Public Property IdTipoFormula As Integer
    Private Sub FrmTiposFormula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 410
        Me.TxtBuscar.Visible = False

        Me.BtnEditar.Enabled = False
        Me.Panel1.Visible = False

        dtTiposFormula = negocioTiposFormulas.ObtenerTiposFormula()
        Me.DgvTiposFormula.DataSource = dtTiposFormula

        With DgvTiposFormula
            .Columns("IdTipoFormula").Visible = False
            .Columns("Codigo").Width = 50
            .Columns("Descripcion").Width = 280
            .Columns("Observaciones").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

    End Sub

    Private Sub DgvTiposFormula_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTiposFormula.CellClick
        If DgvTiposFormula.Rows.Count < 1 Then Exit Sub

        Me.BtnEditar.Enabled = True
        Me.TxtCodigo.Text = DgvTiposFormula.CurrentRow.Cells("Codigo").Value.ToString
        Me.TxtDescripcion.Text = DgvTiposFormula.CurrentRow.Cells("Descripcion").Value.ToString
        Me.TxtObservaciones.Text = DgvTiposFormula.CurrentRow.Cells("Observaciones").Value.ToString
        Me.TxtId.Text = DgvTiposFormula.CurrentRow.Cells("IdTipoFormula").Value.ToString

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Añadir = True
        Me.Height = 520
        Me.Panel1.Visible = True
        Limpiar()

        HayCambios = True

    End Sub

    Private Sub Limpiar()
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.TxtObservaciones.Text = ""
        Me.TxtId.Text = ""
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
        Me.Panel1.Visible = False
        Me.Height = 420
        Añadir = 0

        HayCambios = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If DgvTiposFormula.CurrentRow Is Nothing OrElse DgvTiposFormula.RowCount = 0 Then
            MsgBox("Debe elegir un tipo de fórmula", MsgBoxStyle.MsgBoxSetForeground.Information)
            Exit Sub
        End If

        Añadir = True
        Me.Height = 520
        Me.Panel1.Visible = True
        If DgvTiposFormula.Rows.Count > 0 Then
            With DgvTiposFormula.CurrentRow
                Me.TxtId.Text = .Cells("IdTipoFormula").Value.ToString
                Me.TxtCodigo.Text = .Cells("Codigo").Value.ToString
                Me.TxtDescripcion.Text = .Cells("Descripcion").Value.ToString
                Me.TxtObservaciones.Text = .Cells("Observaciones").Value.ToString
            End With
        End If

        HayCambios = True

    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Codigo, Descripcion, Observaciones As String

        IdTipoFormula = CInt(Val(Me.TxtId.Text))
        Codigo = Me.TxtCodigo.Text
        Descripcion = Me.TxtDescripcion.Text
        Observaciones = Me.TxtObservaciones.Text

        Try
            If Añadir Then
                negocioTiposFormulas.InsertarTipoFormula(IdTipoFormula, Codigo, Descripcion, Observaciones)
            Else
                negocioTiposFormulas.ModificarTipoFormula(IdTipoFormula, Codigo, Descripcion, Observaciones)
            End If

            Limpiar()
            Añadir = False
            Me.Height = 420
            Me.DgvTiposFormula.DataSource = negocioTiposFormulas.ObtenerTiposFormula()
            Me.DgvTiposFormula.Refresh()

        Catch ex As Exception
            MsgBox("Error al guardar Tipo de formula: " & ex.Message,
                   MsgBoxStyle.Critical, "Guardar datos")
        End Try

        HayCambios = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub

    Private Sub FrmTiposFormula_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 3002)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.TxtBuscar.Visible = True
        Me.TxtBuscar.Focus()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        Dim filtro As New DataView(dtTiposFormula)

        If TxtBuscar.Text <> "" Then
            filtro.RowFilter = $"Codigo LIKE '%{TxtBuscar.Text}%'OR Descripcion LIKE '%{TxtBuscar.Text}%'"
            DgvTiposFormula.DataSource = filtro
        Else
            DgvTiposFormula.DataSource = dtTiposFormula
        End If

    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click

        Me.TxtBuscar.Visible = False
        DgvTiposFormula.DataSource = dtTiposFormula
        DgvTiposFormula.Refresh()

    End Sub

End Class