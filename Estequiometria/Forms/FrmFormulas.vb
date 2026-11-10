Imports Negocio
Public Class FrmFormulas
    Private ReadOnly negocio As New FormulasNegocio
    Private ReadOnly negocioTipos As New TiposFormulaNegocio

    Private Añadir As Boolean
    Private IdFormula As Integer
    Private HayCambios As Boolean = False

    Private dtFormulas As DataTable
    Private Sub FrmFormulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 400

        BtnEditar.Enabled = False
        BtnComponentes.Enabled = False


        Me.Panel1.Visible = False

        RecargarFormulas()

        With DgvFormulas
            .Columns("IdFormula").Visible = False
            .Columns("FechaCreacion").Visible = False
            .Columns("Activa").Visible = False
            .Columns("Codigo").Width = 60
            .Columns("Descripcion").Width = 200
            .Columns("TipoFormula").Width = 60
            .Columns("TipoFormula").HeaderText = "Tipo"
            .Columns("Observaciones").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        End With

        CargarTiposFormula()

    End Sub

    Private Sub CargarTiposFormula()

        Try
            CboTipoFormula.DataSource = negocioTipos.ObtenerTiposFormula()
        Catch ex As Exception
            MsgBox("Error en la carga de Tipos de fórmula: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
            Exit Sub
        End Try

        CboTipoFormula.DisplayMember = "Descripcion"
        CboTipoFormula.ValueMember = "Codigo"

    End Sub

    Private Sub RecargarFormulas()

        Try
            dtFormulas = negocio.ObtenerFormulas()
            DgvFormulas.DataSource = dtFormulas
        Catch ex As Exception
            MsgBox("Error en la carga de fórmulas: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try


    End Sub

    Private Sub LimpiarControles()

        TxtCodigo.Clear()
        TxtDescripcion.Clear()
        TxtObservaciones.Clear()
        ChkActiva.Checked = True
        CboTipoFormula.SelectedIndex = -1

    End Sub
    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click

        Añadir = True
        LimpiarControles()
        Me.Height = 500
        Me.Panel1.Visible = True
        HayCambios = True

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If DgvFormulas.CurrentRow Is Nothing OrElse DgvFormulas.RowCount = 0 Then
            MsgBox("Debe elegir una fórmula")
            Exit Sub
        End If

        Añadir = False
        Me.Height = 500
        Me.Panel1.Visible = True

        With DgvFormulas.CurrentRow

            IdFormula = CInt(.Cells("IdFormula").Value)
            TxtCodigo.Text = .Cells("Codigo").Value.ToString
            TxtDescripcion.Text = .Cells("Descripcion").Value.ToString
            CboTipoFormula.SelectedValue = .Cells("TipoFormula").Value.ToString
            ChkActiva.Checked = CBool(.Cells("Activa").Value)

            If IsDBNull(.Cells("Observaciones").Value) Then
                TxtObservaciones.Text = ""
            Else
                TxtObservaciones.Text = .Cells("Observaciones").Value.ToString
            End If

        End With

        HayCambios = True

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Try
            If Añadir Then

                negocio.InsertarFormula(TxtCodigo.Text,
                                        TxtDescripcion.Text,
                                        CboTipoFormula.SelectedValue.ToString,
                                        ChkActiva.Checked,
                                        TxtObservaciones.Text)
            Else

                negocio.ModificarFormula(IdFormula,
                                         TxtCodigo.Text,
                                         TxtDescripcion.Text,
                                         CboTipoFormula.SelectedValue.ToString,
                                         ChkActiva.Checked,
                                         TxtObservaciones.Text)
            End If

            RecargarFormulas()
            LimpiarControles()
            Me.Height = 400
            IdFormula = 0
            Añadir = False
            Me.Panel1.Visible = False
        Catch ex As Exception
            MsgBox("Error al guardar fórmulas: " & ex.Message, MsgBoxStyle.Critical, "Guardar datos")
        End Try

        HayCambios = False

    End Sub

    Private Sub DgvFormulas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFormulas.CellClick

        BtnEditar.Enabled = True
        BtnComponentes.Enabled = True

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        LimpiarControles()
        Me.Panel1.Visible = False
        Me.Height = 400
        HayCambios = False

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim dv As New DataView(dtFormulas) With {
            .RowFilter = $"Codigo LIKE '%{TxtBuscar.Text}%'
                        OR Descripcion LIKE '%{TxtBuscar.Text}%'
                        OR TipoFormula LIKE '%{TxtBuscar.Text}%'"
        }

        Me.DgvFormulas.DataSource = dv

    End Sub

    Private Sub BtnComponentes_Click(sender As Object, e As EventArgs) Handles BtnComponentes.Click

        If DgvFormulas.CurrentRow Is Nothing OrElse DgvFormulas.RowCount = 0 Then
            MsgBox("Debe elegir una fórmula")
            Exit Sub
        End If

        With DgvFormulas.CurrentRow
            IdFormula = CInt(.Cells("IdFormula").Value)
            TxtCodigo.Text = .Cells("Codigo").Value.ToString
            TxtDescripcion.Text = .Cells("Descripcion").Value.ToString
        End With

        If IdFormula <= 0 Then

            MessageBox.Show("Debe seleccionar una fórmula.", "Componentes", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub

        End If

        Dim frm As New FrmComponentes
        With frm
            .IdFormula = IdFormula
            .CodigoFormula = Me.TxtCodigo.Text
            .DescripcionFormula = Me.TxtDescripcion.Text

            .ShowDialog()
        End With
    End Sub

    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub

    Private Sub FrmFormulas_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 3001)
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs)

    End Sub
End Class