Public Class FrmPrincipal

    Private ReadOnly HayCambios As Boolean = False
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Estequiometría de Poliuretanos y Epoxi"
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Dim nResult As Boolean

        nResult = MsgBox("Quieres salir de la aplicación", MsgBoxStyle.OkCancel)

        If nResult Then
            End
        End If

    End Sub

    Private Sub AbrirFormulario(frm As Form)

        For Each f As Form In Me.MdiChildren

            If f.Name = frm.Name Then

                f.WindowState = FormWindowState.Normal

                f.BringToFront()

                f.Activate()

                frm.Dispose()

                Exit Sub

            End If

        Next

        frm.MdiParent = Me

        frm.Show()

    End Sub

    Private Sub FórmulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FórmulasToolStripMenuItem.Click
        AbrirFormulario(New FrmFormulas)
    End Sub

    Private Sub MateriasPrimasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriasPrimasToolStripMenuItem.Click
        AbrirFormulario(New FrmMateriaPrima)
    End Sub

    Private Sub PropiedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropiedadesToolStripMenuItem.Click
        AbrirFormulario(New FrmPropiedadesMateriaPrima)
    End Sub

    Private Sub TiposDePropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDePropiedadToolStripMenuItem.Click
        AbrirFormulario(New FrmTiposPropiedad)
    End Sub

    Private Sub TiposDeFórmulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeFórmulaToolStripMenuItem.Click
        AbrirFormulario(New FrmTiposFormula)
    End Sub

    Private Sub FamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliasToolStripMenuItem.Click
        AbrirFormulario(New FrmFamilias)
    End Sub

    Private Sub SubfamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubfmiliasToolStripMenuItem.Click
        AbrirFormulario(New FrmSubfamilias)
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CerrarVentanaActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActivaToolStripMenuItem.Click

        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Close()
        End If

    End Sub

    Private Sub CerrarTodasLasVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasLasVentanasToolStripMenuItem.Click

        If MessageBox.Show("¿Desea cerrar todas las ventanas abiertas?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub

        End If

        For Each frm As Form In Me.MdiChildren

            frm.Close()

        Next

    End Sub

    Private Sub FrmFormulas_FormClosing(
    sender As Object,
    e As FormClosingEventArgs) _
    Handles Me.FormClosing

        If HayCambios Then

            If MessageBox.Show(
                "Existen cambios sin guardar." &
                vbCrLf &
                "¿Desea cerrar el formulario?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) = DialogResult.No Then

                e.Cancel = True

            End If

        End If

    End Sub

    Private Sub PoliuretanosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliuretanosToolStripMenuItem.Click
        AbrirFormulario(New FrmCalculoPU)
    End Sub

    Private Sub EpoxiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EpoxiToolStripMenuItem.Click
        AbrirFormulario(New FrmCalculoEpoxi)
    End Sub

    Private Sub PoliaspárticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliaspárticosToolStripMenuItem.Click
        AbrirFormulario(New FrmCalculoPoliaspartico)
    End Sub

    Private Sub TodaLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodaLaAyudaToolStripMenuItem.Click
        MostrarAyuda(Me, 1001)
    End Sub

    Private Sub FundamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FundamentosToolStripMenuItem.Click
        MostrarAyuda(Me, 7001)
    End Sub

    Private Sub EjemplosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemplosToolStripMenuItem.Click
        MostrarAyuda(Me, 8001)
    End Sub

    Private Sub AdministraciónYMantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónYMantenimientoToolStripMenuItem.Click
        MostrarAyuda(Me, 9001)
    End Sub

    Private Sub PreguntasFrcuentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntasFrcuentesToolStripMenuItem.Click
        MostrarAyuda(Me, 10001)
    End Sub

    Private Sub FrmPrincipal_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MostrarAyuda(Me, 1001)
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click

        Dim rutaCompletaChm As String = Application.StartupPath & "\Ayuda\ManualEstequiometria.chm"

        Help.ShowHelp(Me, rutaCompletaChm, HelpNavigator.Find, "")

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AbrirFormulario(New AboutBox1)
    End Sub
End Class