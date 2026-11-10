Imports System.Data.SqlClient

Public Class Conexion

    Private Shared ReadOnly CadenaConexion As String =
        "Data Source=.;Initial Catalog=Estequiometria;Integrated Security=True"

    Public Shared Function ObtenerConexion() As SqlConnection

        Return New SqlConnection(CadenaConexion)

    End Function

    Public Shared Function ProbarConexion() As Boolean

        Try

            Using cn As New SqlConnection(CadenaConexion)

                cn.Open()

                Return True

            End Using

        Catch ex As Exception

            Return False

        End Try

    End Function

End Class
