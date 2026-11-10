Imports Datos
Imports Negocio
Public Class FrmSubfamilias
    Public ReadOnly datosSubfamilias As New SubFamiliasDatos
    Public ReadOnly negocioSubfamilia As New SubfamiliasNegocio
    Public ReadOnly negocioFamilias As New FamiliasNegocio
    Private Property Añadir As Integer
    Private HayCambios As Boolean = False
    Private dtSubfamilias As DataTable
    Private Sub FrmSubfamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtSubfamilias = datosSubfamilias.ObtenerSubfamilias()
        DgvSubFamilias.DataSource = dtSubfamilias

        Me.Height = 420
        Me.TxtBuscar.Visible = False

        DgvSubFamilias.Columns(0).Width = 80
        DgvSubFamilias.Columns(1).Width = 60
        DgvSubFamilias.Columns(2).Width = 250
        DgvSubFamilias.Columns(3).Width = 100
        DgvSubFamilias.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        CargarFamilias()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Añadir = 1 Then
            Dim CodigoFamilia As String = CboFamilia.SelectedValue.ToString
            Try
                negocioSubfamilia.InsertarSubfamilia(TxtCodigo.Text, TxtDescripcion.Text, CodigoFamilia)
                MessageBox.Show("Subfamilia añadida correctamente.")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If

        If Añadir = 0 Then
            Try
                negocioSubfamilia.ModificarSubfamilia(CInt(TxtId.Text), TxtCodigo.Text, TxtDescripcion.Text)
                MessageBox.Show("Subfamilia modificada correctamente.")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
        Añadir = 0
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.Height = 420
        DgvSubFamilias.DataSource = datosSubfamilias.ObtenerSubfamilias()
        Me.DgvSubFamilias.Refresh()
        HayCambios = False

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Añadir = 1
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.Height = 500
        HayCambios = True

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Añadir = 0
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.Height = 420
        HayCambios = False

    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click

        If DgvSubFamilias.CurrentRow Is Nothing OrElse DgvSubFamilias.RowCount = 0 Then
            MsgBox("Debe elegir una sub familia", MsgBoxStyle.Information)
            Exit Sub
        End If

        Me.Height = 500
        Me.TxtCodigo.Text = DgvSubFamilias.CurrentRow.Cells("Codigo").Value.ToString
        Me.TxtDescripcion.Text = DgvSubFamilias.CurrentRow.Cells("Descripcion").Value.ToString
        Me.TxtId.Text = DgvSubFamilias.CurrentRow.Cells("IdSubFamilia").Value
        Me.CboFamilia.Text = DgvSubFamilias.CurrentRow.Cells("CodigoFamilia").Value.ToString
        Me.LblCboFamilia.Visible = False
        Me.CboFamilia.Visible = False
        Añadir = 0
        HayCambios = True
    End Sub
    Private Sub TxtCodigo_TextChanged(sender As Object,
                                  e As EventArgs) Handles TxtCodigo.TextChanged

        TxtCodigo.Text = TxtCodigo.Text.ToUpper

        TxtCodigo.SelectionStart = TxtCodigo.Text.Length

    End Sub

    Private Sub CargarFamilias()

        Dim dt As DataTable

        dt = negocioFamilias.ObtenerFamilias()

        CboFamilia.DataSource = dt

        CboFamilia.DisplayMember = "Descripcion"
        CboFamilia.ValueMember = "Codigo"

    End Sub
    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub

    Private Sub FrmSubfamilias_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 2002)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.TxtBuscar.Visible = True
        Me.TxtBuscar.Focus()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        Dim filtro As New DataView(dtSubfamilias)

        If TxtBuscar.Text <> "" Then
            filtro.RowFilter = $"Codigo LIKE '%{TxtBuscar.Text}%'OR Descripcion LIKE '%{TxtBuscar.Text}%'"
            DgvSubFamilias.DataSource = filtro
        Else
            DgvSubFamilias.DataSource = dtSubfamilias
        End If

    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click

        Me.TxtBuscar.Visible = False
        DgvSubFamilias.DataSource = dtSubfamilias
        DgvSubFamilias.Refresh()

    End Sub
End Class