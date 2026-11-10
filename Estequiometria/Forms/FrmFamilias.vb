Imports Datos
Imports Negocio
Public Class FrmFamilias
    Public ReadOnly datosFamilias As New FamiliasDatos
    Public ReadOnly negociofamilia As New FamiliasNegocio
    Public ReadOnly negociosubfamilia As New SubfamiliasNegocio
    Public Property Añadir As Boolean
    Private HayCambios As Boolean = False
    Private dtFamilias As DataTable
    Private daSubfamilia As DataTable

    Private Sub FrmFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFamilias = datosFamilias.ObtenerFamilias()
        DgvFamilias.DataSource = dtFamilias

        Me.Height = 420

        DgvFamilias.Columns(0).Width = 80
        DgvFamilias.Columns(1).Width = 80
        DgvFamilias.Columns(2).Width = 250
        DgvFamilias.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvFamilias.Height = 280

        Me.TxtBuscar.Visible = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Añadir Then
            Try
                negociofamilia.InsertarFamilia(TxtCodigo.Text, TxtDescripcion.Text)
                MessageBox.Show("Familia añadida correctamente.")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If

        If Añadir = False Then
            Try
                negociofamilia.ModificarFamilia(CInt(TxtId.Text), TxtCodigo.Text, TxtDescripcion.Text)
                MessageBox.Show("Familia modificada correctamente.")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
        Añadir = False
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.Height = 420
        DgvFamilias.DataSource = datosFamilias.ObtenerFamilias()
        Me.DgvFamilias.Refresh()
        HayCambios = False

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Añadir = True
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.Height = 500
        HayCambios = True

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Añadir = False
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.Height = 420
        HayCambios = False

    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click

        If DgvFamilias.RowCount = 0 OrElse DgvFamilias.CurrentRow Is Nothing Then

            MsgBox("Debes seleccionar una familia", MsgBoxStyle.Information)
            Exit Sub

        End If

        Me.Height = 500
        Me.TxtCodigo.Text = DgvFamilias.CurrentRow.Cells("Codigo").Value.ToString
        Me.TxtDescripcion.Text = DgvFamilias.CurrentRow.Cells("Descripcion").Value.ToString
        Me.TxtId.Text = DgvFamilias.CurrentRow.Cells("IdFamilia").Value
        Añadir = False
        HayCambios = True

    End Sub
    Private Sub TxtCodigo_TextChanged(sender As Object,
                                  e As EventArgs) Handles TxtCodigo.TextChanged

        TxtCodigo.Text = TxtCodigo.Text.ToUpper

        TxtCodigo.SelectionStart = TxtCodigo.Text.Length

    End Sub
    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub

    Private Sub FrmFamilias_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 2001)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.TxtBuscar.Visible = True
        Me.TxtBuscar.Focus()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim filtro As New DataView(dtFamilias)

        If TxtBuscar.Text <> "" Then
            filtro.RowFilter = $"Codigo LIKE '%{TxtBuscar.Text}%'OR Descripcion LIKE '%{TxtBuscar.Text}%'"
            DgvFamilias.DataSource = filtro
        Else
            DgvFamilias.DataSource = dtFamilias
        End If
    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click

        Me.TxtBuscar.Visible = False
        DgvFamilias.DataSource = dtFamilias
        DgvFamilias.Refresh()

    End Sub

    Private Sub BtnVerSubFam_Click(sender As Object, e As EventArgs) Handles BtnVerSubFam.Click

        If DgvFamilias.RowCount = 0 OrElse DgvFamilias.CurrentRow Is Nothing Then

            MsgBox("Debes seleccionar una familia", MsgBoxStyle.Information)
            Exit Sub

        End If


        Dim fam As String = DgvFamilias.CurrentRow.Cells("Codigo").Value.ToString
        daSubfamilia = negociosubfamilia.ObtenerSubfamiliasPorFamilia(fam)

        DgvSubFamilias.DataSource = daSubfamilia
        DgvSubFamilias.Refresh()
        DgvSubFamilias.Select()

        Me.DgvFamilias.Height = 160


    End Sub

    Private Sub DgvSubFamilias_Leave(sender As Object, e As EventArgs) Handles DgvSubFamilias.Leave
        DgvFamilias.Height = 280
    End Sub
End Class