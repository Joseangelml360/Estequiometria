Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class FamiliasDatos

    Public Function ObtenerFamilias() As DataTable

        Dim Tabla As DataTable = FamiliasEntidad.TablaFamilias()

        Using cn As SqlConnection = Conexion.ObtenerConexion

            cn.Open()

            Dim Sql As String = "SELECT IdFamilia, Codigo, Descripcion " &
                                "FROM Familias " &
                                "ORDER BY Codigo"

            Dim da As New SqlDataAdapter(Sql, cn)
            da.Fill(Tabla)

        End Using

        Return Tabla

    End Function


    Public Function ExisteCodigoFamilia(Codigo As String, IdFamilia As Integer) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                           "FROM Familias " &
                           "WHERE Codigo = @Codigo " &
                           "AND IdFamilia <> @IdFamilia"

        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cmd.Parameters.AddWithValue("@IdFamilia", IdFamilia)

                cn.Open()
                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function InsertarFamilia(Codigo As String, Descripcion As String) As Boolean

        Dim Sql As String = "INSERT INTO Familias " &
                           "(Codigo, Descripcion) " &
                           "VALUES " &
                           "(@Codigo, @Descripcion)"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al insertar la familia: " &
               ex.Message)
        End Try

    End Function

    Public Function ModificarFamilia(IdFamilia As Integer, Codigo As String, Descripcion As String) As Boolean

        Dim Sql As String = "UPDATE Familias " &
                          "SET Codigo=@Codigo, " &
                          "Descripcion=@Descripcion " &
                          "WHERE IdFamilia=@IdFamilia"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdFamilia", IdFamilia)
                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al modificar la familia: " &
                ex.Message)
        End Try

    End Function

    Public Function EliminarFamilia(IdFamilia As Integer) As Boolean

        Dim Sql As String = "DELETE FROM Familias " &
                           "WHERE IdFamilia=@IdFamilia"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdFamilia", IdFamilia)
                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al eliminar la familia: " & ex.Message)
        End Try

    End Function

End Class
