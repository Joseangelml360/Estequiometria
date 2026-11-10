Imports Negocio
Public Class FrmPropiedadesMP2
    Private ReadOnly negocioMateriasPrimas As New MateriasPrimasNegocio
    Private ReadOnly negocioTipoPropiedades As New TiposPropiedadNegocio
    Private ReadOnly negocioPropiedadesMateriaPrima As New PropiedadesMateriaPrimaNegocio

    Private IdPropiedad As Integer
    Private Añadir As Boolean
    Private HayCambios As Boolean = False
    Private dt As DataTable
    Private Sub FrmPropiedadesMP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim codigo As String = LblCodigo.Text

        Try
            Me.DgvPropiedades.DataSource = negocioPropiedadesMateriaPrima.ObtenerPropiedadesMateriaPrima(codigo)
            Me.BtnAñadir.Enabled = True
        Catch ex As Exception
            MsgBox("Error en la carga de Propiedades de la materia prima: " & ex.Message,
                   MsgBoxStyle.Critical, "Cargar datos")
        End Try

        Me.Height = 400
        Me.Panel1.Visible = False
        dt = negocioMateriasPrimas.ObtenerMateriasPrimasCombo()

        CargarPropiedades()

        Me.BtnAñadir.Enabled = True
        Me.BtnEditar.Enabled = False
        Me.BtnEliminar.Enabled = False

        With DgvPropiedades
            .Columns("IdPropiedad").Visible = False
            .Columns("CodigoMateriaPrima").Visible = False
            .Columns("Valor").DefaultCellStyle.Format = "N2"
        End With

    End Sub

    Private Sub CargarPropiedades()
        Try
            CboPropiedad.DataSource = negocioTipoPropiedades.ObtenerTiposPropiedad()
            CboPropiedad.DisplayMember = "Propiedad"
            CboPropiedad.ValueMember = "Codigo"
            CboPropiedad.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error en la carga de Propiedades: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try

    End Sub

    Private Sub CboPropiedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPropiedad.SelectedIndexChanged

        If CboPropiedad.SelectedItem Is Nothing Then Exit Sub
        Dim fila As DataRowView = CType(CboPropiedad.SelectedItem, DataRowView)
        TxtUnidad.Text = fila("Unidad").ToString

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub



    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Me.Height = 500
        Me.Panel1.Visible = True
        Añadir = True
        HayCambios = True
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Me.Height = 500
        Me.Panel1.Visible = True
        Añadir = False
        CboPropiedad.SelectedValue = DgvPropiedades.CurrentRow.Cells("CodigoPropiedad").Value.ToString
        Me.TxtValor.Text = CDec(DgvPropiedades.CurrentRow.Cells("Valor").Value).ToString("N2")
        Me.LblIdPropiedad.Text = DgvPropiedades.CurrentRow.Cells("IdPropiedad").Value
        IdPropiedad = CInt(Val(LblIdPropiedad.Text))
        HayCambios = True

    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Añadir = False
        Me.Panel1.Visible = False
        Me.TxtValor.Text = Nothing
        Me.TxtUnidad.Text = Nothing
        Me.CboPropiedad.SelectedIndex = -1
        Me.Height = 400
        HayCambios = False

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim codigoPropiedad, codigoMP As String
        Dim valor As Decimal

        codigoPropiedad = Me.CboPropiedad.SelectedValue.ToString
        codigoMP = Me.TxtCodigoMateriaPrima.Text
        codigoMP = codigoMP.Trim
        codigoPropiedad = codigoPropiedad.Trim.ToUpper
        valor = Val(Me.TxtValor.Text)

        Try
            If Añadir Then
                negocioPropiedadesMateriaPrima.InsertarPropiedadMateriaPrima(codigoMP, codigoPropiedad, valor)
            Else
                negocioPropiedadesMateriaPrima.ModificarPropiedadMateriaPrima(IdPropiedad, codigoMP, codigoPropiedad,
                                                                              valor)
            End If

            DgvPropiedades.DataSource = negocioPropiedadesMateriaPrima.ObtenerPropiedadesMateriaPrima(codigoMP)

            Añadir = False
            Me.Panel1.Visible = False
            Me.TxtValor.Text = Nothing
            Me.TxtUnidad.Text = Nothing
            Me.CboPropiedad.SelectedIndex = -1
            Me.Height = 400
        Catch ex As Exception
            MsgBox("Error al guardar propiedades de materia prima: " & ex.Message,
                   MsgBoxStyle.Critical, "Guardar datos")
        End Try

        HayCambios = False

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If DgvPropiedades.Rows.Count = 0 Then
            MessageBox.Show("No hay propiedades para eliminar.", "Eliminar", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        If DgvPropiedades.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar una propiedad.", "Eliminar", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar la propiedad seleccionada?", "Confirmar eliminación",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            IdPropiedad = CInt(DgvPropiedades.CurrentRow.Cells("IdPropiedad").Value)
            Dim codigoMP As String = DgvPropiedades.CurrentRow.Cells("CodigoMateriaPrima").Value.ToString
            negocioPropiedadesMateriaPrima.EliminarPropiedadMateriaPrima(IdPropiedad)
            DgvPropiedades.DataSource = negocioPropiedadesMateriaPrima.ObtenerPropiedadesMateriaPrima(codigoMP)
        Catch ex As Exception
            MsgBox("Error al eliminar propiedades de materia prima: " & ex.Message,
                   MsgBoxStyle.Critical, "Eliminar datos")
        End Try


    End Sub

    Private Sub DgvPropiedades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPropiedades.CellClick

        Me.BtnEditar.Enabled = True
        Me.BtnEliminar.Enabled = True

    End Sub

    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub

    Private Sub FrmPropiedadesMateriaPrima_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 2005)
    End Sub
End Class