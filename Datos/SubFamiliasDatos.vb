Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class SubFamiliasDatos
    Public Function ObtenerSubfamilias() As DataTable

        Dim Tabla As DataTable = SubfamiliasEntidad.TablaSubfamilias()

        Using cn As SqlConnection = Conexion.ObtenerConexion

            cn.Open()

            Dim Sql As String = "SELECT IdSubFamilia, Codigo, Descripcion, CodigoFamilia " &
                                "FROM Subfamilias " &
                                "ORDER BY Codigo"

            Dim da As New SqlDataAdapter(Sql, cn)

            da.Fill(Tabla)

        End Using

        Return Tabla

    End Function

    Public Function InsertarSubfamilia(Codigo As String, Descripcion As String, CodigoFamilia As String) As Boolean

        Dim Sql As String = "INSERT INTO Subfamilias " &
                            "(Codigo, Descripcion, CodigoFamilia) " &
                            "VALUES " &
                            "(@Codigo, @Descripcion, @CodigoFamilia)"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@CodigoFamilia", CodigoFamilia)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al insertar la familia: " & ex.Message)
        End Try

    End Function

    Public Function ModificarSubfamilia(IdSubfamilia As Integer, Codigo As String,
                                        Descripcion As String) As Boolean

        Dim Sql As String = "UPDATE Subfamilias " &
                            "SET Codigo=@Codigo, " &
                            "Descripcion=@Descripcion " &
                            "WHERE IdSubfamilia=@IdSubfamilia"
        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdSubfamilia", IdSubfamilia)
                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al modificar la Subfamilia: " &
                ex.Message)
        End Try

    End Function

    Public Function EliminarSubfamilia(IdSubfamilia As Integer) As Boolean

        Dim Sql As String =
            "DELETE FROM SubFamilias " &
            "WHERE IdSubfamilia=@IdSubfamilia"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdSubfamilia", IdSubfamilia)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al eliminar la familia: " &
                ex.Message)
        End Try

    End Function

    Public Function ExisteCodigoSubfamilia(Codigo As String, IdSubfamilia As Integer) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                           "FROM Subfamilias " &
                           "WHERE Codigo = @Codigo " &
                           "AND IdSubfamilia <> @IdSubfamilia"

        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cmd.Parameters.AddWithValue("@IdSubfamilia", IdSubfamilia)

                cn.Open()
                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function ObtenerSubfamiliasPorFamilia(CodigoFamilia As String) As DataTable

        Dim Tabla As DataTable = SubfamiliasEntidad.TablaSubfamilias()

        Dim Sql As String = "SELECT IdSubfamilia, Codigo, Descripcion, CodigoFamilia " &
                           "FROM Subfamilias " &
                           "WHERE CodigoFamilia=@CodigoFamilia " &
                           "ORDER BY Codigo"

        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@CodigoFamilia", CodigoFamilia)
                Using da As New SqlDataAdapter(cmd)

                    da.Fill(Tabla)

                End Using
            End Using
        End Using

        Return Tabla

    End Function

End Class
