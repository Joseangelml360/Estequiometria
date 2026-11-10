Imports Negocio
Public Class FrmComponentes

    Public IdFormula As Integer
    Public CodigoFormula As String
    Public DescripcionFormula As String

    Private ReadOnly negocioComponentes As New ComponentesFormulaNegocio
    Private ReadOnly negocioMateriasPrimas As New MateriasPrimasNegocio

    Private Añadir As Boolean
    Private IdComponente As Integer
    Private HayCambios As Boolean = False

    Private dtMateriasPrimas As DataTable

    Private Sub FrmComponentesFormula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtCodigo.Text = CodigoFormula
        TxtDescripcion.Text = DescripcionFormula

        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        Me.Height = 400

        CargarMateriasPrimas()
        RecargarComponentes()
        ActualizarSuma()
        OcultarPanel()

    End Sub

    Private Sub CargarMateriasPrimas()

        Try
            dtMateriasPrimas = negocioMateriasPrimas.ObtenerMateriasPrimasCombo()
        Catch ex As Exception
            MsgBox("Error en la carga de componentes: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try



        CboMateriaprima.DataSource = dtMateriasPrimas

        CboMateriaprima.DisplayMember = "Descripcion"

        CboMateriaprima.ValueMember = "Codigo"

        CboMateriaprima.SelectedIndex = -1

    End Sub

    Private Sub RecargarComponentes()

        Try
            DgvComponentes.DataSource = negocioComponentes.ObtenerComponentesFormula(IdFormula)
        Catch ex As Exception
            MsgBox("Error en la carga de componentes: " & ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try

    End Sub

    Private Sub ActualizarSuma()
        Try
            TxtSumaComponentes.Text = negocioComponentes.ObtenerSumaComponentes(IdFormula).ToString("N3")
        Catch ex As Exception
            MsgBox("Error en la suma de componentes: " & ex.Message, MsgBoxStyle.Critical, "Calcular suma")
        End Try


    End Sub

    Private Sub MostrarPanel()

        Panel1.Visible = True

    End Sub

    Private Sub OcultarPanel()

        Panel1.Visible = False

    End Sub

    Private Sub LimpiarControles()

        TxtBuscarMP.Clear()
        TxtMateriaPrima.Clear()
        CboMateriaprima.SelectedIndex = -1
        NumCantidad.Value = 0
        IdComponente = 0

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click

        Añadir = True
        LimpiarControles()
        MostrarPanel()
        TxtBuscarMP.Focus()
        HayCambios = True
        Me.Height = 500

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If Añadir Then

                negocioComponentes.InsertarComponente(IdFormula,
                                                      CboMateriaprima.SelectedValue.ToString,
                                                      NumCantidad.Value)
            Else

                negocioComponentes.ModificarComponente(IdComponente,
                                                       IdFormula,
                                                       CboMateriaprima.SelectedValue.ToString,
                                                       NumCantidad.Value)
                Me.Panel1.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Error al guardar componentes: " & ex.Message, MsgBoxStyle.Critical, "Guardar datos")
        End Try


        RecargarComponentes()
        ActualizarSuma()
        LimpiarControles()
        TxtBuscarMP.Focus()
        HayCambios = False
        Me.Height = 400

    End Sub

    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles BtnTerminar.Click

        LimpiarControles()
        OcultarPanel()
        HayCambios = False
        Me.Height = 400

    End Sub

    Private Sub CboMateriaPrima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMateriaprima.SelectedIndexChanged

        If CboMateriaprima.SelectedValue Is Nothing Then Exit Sub

        TxtMateriaPrima.Text = CboMateriaprima.SelectedValue.ToString & " - " & CboMateriaprima.Text

    End Sub

    Private Sub TxtBuscarMP_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarMP.TextChanged

        Dim dv As New DataView(dtMateriasPrimas)

        If TxtBuscarMP.Text.Trim <> "" Then

            dv.RowFilter = $"Codigo LIKE '%{TxtBuscarMP.Text}%'OR Descripcion LIKE '%{TxtBuscarMP.Text}%'"

            CboMateriaprima.DataSource = dv
        Else
            CboMateriaprima.DataSource = dtMateriasPrimas
        End If

        CboMateriaprima.DisplayMember = "Descripcion"
        CboMateriaprima.ValueMember = "Codigo"

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmFormulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = Not ConfirmarCierre(HayCambios)

    End Sub


    Private Sub BtnCompletar100_Click(sender As Object, e As EventArgs) Handles BtnCompletar100.Click

        Dim SumaActual As Decimal
        Dim CtdadActual As Decimal = CDec(Me.NumCantidad.Value)

        SumaActual = negocioComponentes.ObtenerSumaComponentes(IdFormula)

        Dim Cantidad As Decimal = 100D - SumaActual

        If CtdadActual > 0 Then

            Cantidad += CtdadActual

        End If

        If Cantidad < 0 Then

            MessageBox.Show("La suma de componentes ya supera 100.", "Completar 100",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        NumCantidad.Value = Cantidad

    End Sub

    Private Sub DgvComponentes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvComponentes.CellClick

        If e.RowIndex < 0 Then Exit Sub

        BtnEditar.Enabled = True
        BtnEliminar.Enabled = True

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If DgvComponentes.CurrentRow Is Nothing OrElse DgvComponentes.RowCount = 0 Then
            MsgBox("Debe elegir un componente")
            Exit Sub
        End If

        Añadir = False

        Panel1.Visible = True

        Me.Height = 500

        With DgvComponentes.CurrentRow

            IdComponente = CInt(.Cells("IdComponente").Value)


            CboMateriaprima.SelectedValue = .Cells("CodigoMateriaPrima").Value.ToString


            TxtMateriaPrima.Text =
                .Cells("CodigoMateriaPrima").Value.ToString & " - " & .Cells("Descripcion").Value.ToString

            NumCantidad.Value = CDec(.Cells("Cantidad").Value)

        End With

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click


        Try

            If DgvComponentes.Rows.Count = 0 Then

                MessageBox.Show(
                    "No hay componentes para eliminar.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Exit Sub

            End If

            If DgvComponentes.CurrentRow Is Nothing Then

                MessageBox.Show(
                    "Debe seleccionar un componente.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Exit Sub

            End If

            If MessageBox.Show(
                "¿Desea eliminar el componente seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) = DialogResult.No Then

                Exit Sub

            End If

            Dim IdComponente As Integer =
                CInt(DgvComponentes.CurrentRow.Cells("IdComponente").Value)

            negocioComponentes.EliminarComponente(IdComponente)

            RecargarComponentes()

            ActualizarSuma()

            BtnEditar.Enabled = False
            BtnEliminar.Enabled = False

            LimpiarControles()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Eliminar componente", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub FrmComponentes_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 3006)
    End Sub

    Private Sub BtnAjustarA100_Click(sender As Object, e As EventArgs) Handles BtnAjustarA100.Click

        If MessageBox.Show("¿Desea ajustar la fórmula a 100?", "Confirmación",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub

        End If

        Try
            Dim sumaTotal As Decimal = 0D

            For Each fila As DataGridViewRow In DgvComponentes.Rows

                If Not fila.IsNewRow Then

                    sumaTotal += CDec(fila.Cells("Cantidad").Value)

                End If

            Next

            If sumaTotal = 0 Then Exit Sub

            Dim factor As Decimal = 100D / sumaTotal

            For Each fila As DataGridViewRow In DgvComponentes.Rows

                If Not fila.IsNewRow Then

                    Dim idComponente As Integer = CInt(fila.Cells("IdComponente").Value)

                    Dim cantidadActual As Decimal = CDec(fila.Cells("Cantidad").Value)

                    Dim nuevaCantidad As Decimal =
                        Math.Round(cantidadActual * factor, 3)

                    negocioComponentes.ModificarCantidadComponente(idComponente, nuevaCantidad)

                End If

            Next

            RecargarComponentes()
            ActualizarSuma()

            MessageBox.Show("La fórmula ha sido ajustada a 100.", "Ajustar a 100",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ajustar a 100", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class