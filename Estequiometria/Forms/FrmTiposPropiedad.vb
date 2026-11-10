Imports Negocio
Public Class FrmTiposPropiedad
    Private ReadOnly negociotipospropiedad As New TiposPropiedadNegocio

    Private Añadir As Boolean
    Private IdTipoPropiedad As Integer
    Private HayCambios As Boolean = False
    Private dtTiposPropiedad As DataTable
    Private Sub FrmTiposPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtBuscar.Visible = False
        dtTiposPropiedad = negociotipospropiedad.ObtenerTiposPropiedad()
        CargarTiposPropiedad()

        With DgvPropiedades
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .Columns(0).Visible = False
            .Columns(1).Width = 60
            .Columns(2).Width = 200
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        Me.Height = 400

    End Sub

    Private Sub CargarTiposPropiedad()
        Me.DgvPropiedades.DataSource = dtTiposPropiedad
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged

        TxtCodigo.Text = TxtCodigo.Text.ToUpper
        TxtCodigo.SelectionStart = TxtCodigo.Text.Length

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Añadir = True
        ModoEdicion()
        LimpiarControles()

        HayCambios = True


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarControles()
        ModoConsulta()

        HayCambios = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If DgvPropiedades.CurrentRow Is Nothing OrElse DgvPropiedades.RowCount = 0 Then
            MsgBox("Debe elegir una propiedad")
            Exit Sub
        End If

        Añadir = False
        ModoEdicion()

        With DgvPropiedades.CurrentRow
            IdTipoPropiedad = .Cells("IdTipoPropiedad").Value
            Me.TxtCodigo.Text = .Cells("Codigo").Value.ToString
            Me.TxtDescripcion.Text = .Cells("Descripcion").Value.ToString
            If IsDBNull(.Cells("Unidad").Value) Then
                TxtUnidad.Text = ""
            Else
                TxtUnidad.Text = .Cells("Unidad").Value.ToString
            End If
        End With

        HayCambios = True

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim codigo, descripcion, unidad As String

        codigo = Me.TxtCodigo.Text
        descripcion = Me.TxtDescripcion.Text
        unidad = Me.TxtUnidad.Text

        Try
            If Añadir Then
                negociotipospropiedad.InsertarTipoPropiedad(IdTipoPropiedad, codigo, descripcion, unidad)
            Else
                negociotipospropiedad.ModificarTipoPropiedad(IdTipoPropiedad, codigo, descripcion, unidad)
            End If

            dtTiposPropiedad = negociotipospropiedad.ObtenerTiposPropiedad()
            CargarTiposPropiedad()
            LimpiarControles()
            Añadir = False
            ModoConsulta()
            IdTipoPropiedad = 0

        Catch ex As Exception
            MsgBox("Error al guardar tipo de propiedad: " & ex.Message, MsgBoxStyle.Critical, "Guardar datos")
        End Try

        HayCambios = False

    End Sub

    Private Sub LimpiarControles()

        For Each c As Control In Panel1.Controls
            If TypeOf c Is TextBox Then
                c.Text = Nothing
            End If
        Next

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.TxtBuscar.Visible = True
        Me.TxtBuscar.Focus()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim filtro As New DataView(dtTiposPropiedad)

        If TxtBuscar.Text <> "" Then
            filtro.RowFilter = $"Codigo LIKE '%{TxtBuscar.Text}%'OR Descripcion LIKE '%{TxtBuscar.Text}%'"
            DgvPropiedades.DataSource = filtro
        Else
            DgvPropiedades.DataSource = dtTiposPropiedad
        End If

    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click
        Me.TxtBuscar.Visible = False
        DgvPropiedades.DataSource = dtTiposPropiedad
        DgvPropiedades.Refresh()
    End Sub

    Private Sub ModoConsulta()
        Me.Height = 400
        Panel1.Visible = False
    End Sub

    Private Sub ModoEdicion()
        Me.Height = 500
        Panel1.Visible = True
    End Sub

    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub

    Private Sub FrmTiposPropiedad_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 2004)
    End Sub
End Class