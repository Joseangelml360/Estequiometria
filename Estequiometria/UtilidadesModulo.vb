Imports System.IO
Module UtilidadesModulo
    Public Function ConfirmarCierre(HayCambios As Boolean) As Boolean

        If Not HayCambios Then Return True

        Return MessageBox.Show(
        "Existen cambios sin guardar." &
        vbCrLf &
        "¿Desea cerrar el formulario?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) = DialogResult.Yes

    End Function

    Public Sub MostrarAyuda(Ventana As Form,
                            ContextID As Integer)

        Dim rutaCompletaChm As String =
            Application.StartupPath &
            "\Ayuda\ManualEstequiometria.chm"

        If File.Exists(rutaCompletaChm) Then

            Help.ShowHelp(Ventana,
                          rutaCompletaChm,
                          HelpNavigator.TopicId,
                          ContextID.ToString)

        Else

            MessageBox.Show(
                "No se encuentra el archivo de ayuda:" &
                vbCrLf &
                rutaCompletaChm,
                "Ayuda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

        End If

    End Sub

End Module

