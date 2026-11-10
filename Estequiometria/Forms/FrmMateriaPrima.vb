Imports Datos
Imports Negocio
Public Class FrmMateriaPrima
    Private ReadOnly negociomateriasprimas As New MateriasPrimasNegocio()
    Private ReadOnly negociofamilias As New FamiliasNegocio
    Private ReadOnly negociosubfamilias As New SubfamiliasNegocio

    Private Añadir As Boolean
    Private IdMateriaPrima As Integer
    Private HayCambios As Boolean = False
    Private dtMateriasPrimas As DataTable
    Private Sub FrmMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtBuscar.Visible = False

        dtMateriasPrimas = negociomateriasprimas.ObtenerMateriasPrimas()
        CargarMateriasPrimas()

        Me.CboFamilia.DropDownWidth = 250
        Me.CboSubFamilia.DropDownWidth = 250

        With DgvMateriasPrimas
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .Columns(0).Visible = False
            .Columns(1).Width = 60
            .Columns(2).Width = 200
            .Columns(3).Width = 40
            .Columns(4).Width = 40
            .Columns(5).Width = 100
            .Columns(6).Width = 50
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(0).HeaderText = "Id"
            .Columns(3).HeaderText = "Fam"
            .Columns(4).HeaderText = "SFam"
        End With
        Me.Height = 380

        CargarFamilias()
    End Sub

    Private Sub CargarMateriasPrimas()

        Try
            DgvMateriasPrimas.DataSource = dtMateriasPrimas
        Catch ex As Exception
            MsgBox("Error en la carga de Materias primas: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CargarFamilias()

        Dim dt As DataTable
        Try
            dt = negociofamilias.ObtenerFamilias()

            CboFamilia.DataSource = dt

            CboFamilia.DisplayMember = "Descripcion"
            CboFamilia.ValueMember = "Codigo"
        Catch ex As Exception
            MsgBox("Error en la carga de familias: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try

    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object,
                                  e As EventArgs) Handles TxtCodigo.TextChanged

        TxtCodigo.Text = TxtCodigo.Text.ToUpper

        TxtCodigo.SelectionStart = TxtCodigo.Text.Length

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

    Private Sub CboFamilias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFamilia.SelectedIndexChanged

        CargarSubfamilias()

    End Sub

    Private Sub CargarSubfamilias()

        If CboFamilia.SelectedValue Is Nothing Then Exit Sub

        Dim negocio As New SubfamiliasNegocio

        Dim dt As DataTable
        Try
            dt = negocio.ObtenerSubfamiliasPorFamilia(
                            CboFamilia.SelectedValue.ToString)

            CboSubFamilia.DataSource = dt
            CboSubFamilia.DisplayMember = "Descripcion"
            CboSubFamilia.ValueMember = "Codigo"
        Catch ex As Exception
            MsgBox("Error en la carga de sub familias: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If DgvMateriasPrimas.RowCount = 0 OrElse DgvMateriasPrimas.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar una materia prima", MsgBoxStyle.Information)
            Exit Sub
        End If

        Añadir = False
        ModoEdicion()

        With DgvMateriasPrimas.CurrentRow
            IdMateriaPrima = .Cells("IdMateriaPrima").Value
            Me.TxtCodigo.Text = .Cells("Codigo").Value.ToString
            Me.TxtDescripcion.Text = .Cells("Descripcion").Value.ToString
            If IsDBNull(.Cells("Proveedor").Value) Then
                TxtProveedor.Text = ""
            Else
                TxtProveedor.Text = .Cells("Proveedor").Value.ToString
            End If
            If IsDBNull(.Cells("Precio").Value) Then
                TxtPrecio.Text = ""
            Else
                TxtPrecio.Text = .Cells("Precio").Value.ToString
            End If
            If IsDBNull(.Cells("Observaciones").Value) Then
                TxtObservaciones.Text = ""
            Else
                TxtObservaciones.Text = .Cells("Observaciones").Value.ToString
            End If
            Me.CboFamilia.SelectedValue = .Cells("CodigoFamilia").Value.ToString
            Me.CboSubFamilia.SelectedValue = .Cells("CodigoSubfamilia").Value.ToString
        End With

        HayCambios = True

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim codigo, descripcion, familia, subfamilia, proveedor, observaciones As String
        Dim precio As Decimal?

        codigo = Me.TxtCodigo.Text
        descripcion = Me.TxtDescripcion.Text
        If CboFamilia.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar una familia.")
            CboFamilia.Focus()
            Exit Sub
        Else
            familia = CboFamilia.SelectedValue.ToString
        End If

        If CboSubFamilia.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar una subfamilia.")
            CboSubFamilia.Focus()
            Exit Sub
        Else
            subfamilia = CboSubFamilia.SelectedValue.ToString
        End If

        proveedor = Me.TxtProveedor.Text
        precio = If(TxtPrecio.Text = "", CType(Nothing, Decimal?), CDec(TxtPrecio.Text))
        observaciones = Me.TxtObservaciones.Text

        Try
            If Añadir Then
                negociomateriasprimas.InsertarMateriaPrima(codigo, descripcion, familia, subfamilia,
                                                            proveedor, precio, observaciones)
            Else
                negociomateriasprimas.ModificarMateriaPrima(IdMateriaPrima, codigo, descripcion, familia, subfamilia,
                                                            proveedor, precio, observaciones)
            End If

            dtMateriasPrimas = negociomateriasprimas.ObtenerMateriasPrimas()
            CargarMateriasPrimas()
            LimpiarControles()
            Añadir = False
            ModoConsulta()
            IdMateriaPrima = 0
        Catch ex As Exception
            MsgBox("Error al guardar materia prima: " & ex.Message, MsgBoxStyle.Critical, "Guardar datos")
        End Try

        HayCambios = False

    End Sub

    Private Sub LimpiarControles()

        For Each c As Control In Panel1.Controls
            If TypeOf c Is TextBox Then
                c.Text = Nothing
            End If
        Next
        Me.CboFamilia.SelectedIndex = -1
        Me.CboSubFamilia.DataSource = Nothing

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.TxtBuscar.Visible = True
        Me.TxtBuscar.Focus()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim filtro As New DataView(dtMateriasPrimas)

        If TxtBuscar.Text <> "" Then
            filtro.RowFilter = $"Codigo LIKE '%{TxtBuscar.Text}%'OR Descripcion LIKE '%{TxtBuscar.Text}%'"
            DgvMateriasPrimas.DataSource = filtro
        Else
            DgvMateriasPrimas.DataSource = dtMateriasPrimas
        End If

    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click
        Me.TxtBuscar.Visible = False
        DgvMateriasPrimas.DataSource = dtMateriasPrimas
        DgvMateriasPrimas.Refresh()
    End Sub

    Private Sub ModoConsulta()
        Me.Height = 380
        Panel1.Visible = False
    End Sub

    Private Sub ModoEdicion()
        Me.Height = 500
        Panel1.Visible = True
    End Sub
    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub

    Private Sub FrmMateriaPrima_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 2003)
    End Sub

    Private Sub BtnPropiedades_Click(sender As Object, e As EventArgs) Handles BtnPropiedades.Click

        If DgvMateriasPrimas.RowCount = 0 OrElse DgvMateriasPrimas.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar una materia prima", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim codigo As String = Me.DgvMateriasPrimas.CurrentRow.Cells("Codigo").Value.ToString
        Dim descripcion As String = Me.DgvMateriasPrimas.CurrentRow.Cells("Descripcion").Value.ToString

        Dim frm As New FrmPropiedadesMP2
        With frm
            .LblCodigo.Text = codigo
            .LblDescripcion.Text = descripcion
            .TxtCodigoMateriaPrima.Text = codigo
            .TxtMateriaPrima.Text = descripcion
            .ShowDialog()
        End With
    End Sub

End Class