Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class TiposPropiedadDatos
    Public Function ObtenerTiposPropiedad() As DataTable

        Dim Tabla As DataTable = TiposPropiedadEntidad.TablaTiposPropiedad()

        Using cn As SqlConnection = Conexion.ObtenerConexion

            cn.Open()

            Dim Sql As String = "SELECT IdTipoPropiedad, Codigo, " &
                                "Codigo + ' - ' + Descripcion AS Propiedad, " &
                                "Descripcion, Unidad " &
                                "FROM TiposPropiedad " &
                                "ORDER BY Codigo"

            Dim da As New SqlDataAdapter(Sql, cn)
            da.Fill(Tabla)

        End Using

        Return Tabla

    End Function


    Public Function ExisteCodigoTipoPropiedad(Codigo As String, IdTipoPropiedad As Integer) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM TiposPropiedad " &
                            "WHERE Codigo = @Codigo " &
                            "AND IdTipoPropiedad <> @IdTipoPropiedad"

        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cmd.Parameters.AddWithValue("@IdTipoPropiedad", IdTipoPropiedad)

                cn.Open()
                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function InsertarTipoPropiedad(Codigo As String, Descripcion As String, Unidad As String) As Boolean

        Dim Sql As String = "INSERT INTO TiposPropiedad " &
                           "(Codigo, Descripcion, Unidad) " &
                           "VALUES " &
                           "(@Codigo, @Descripcion, @Unidad)"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@Unidad", Unidad)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al insertar el  Tipo de Propiedad: " &
               ex.Message)
        End Try

    End Function

    Public Function ModificarTipoPropiedad(IdTipoPropiedad As Integer, Codigo As String, Descripcion As String,
                                           Unidad As String) As Boolean

        Dim Sql As String = "UPDATE TiposPropiedad " &
                          "SET Codigo=@Codigo, " &
                          "Descripcion=@Descripcion, " &
                          "Unidad=@Unidad " &
                          "WHERE IdTipoPropiedad=@IdTipoPropiedad"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdTipoPropiedad", IdTipoPropiedad)
                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@Unidad", Unidad)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al modificar el Tipo de Propiedad: " &
                ex.Message)
        End Try

    End Function

    Public Function EliminarTipoPropiedad(IdTipoPropiedad As Integer) As Boolean

        Dim Sql As String = "DELETE FROM TiposPropiedad " &
                           "WHERE IdTipoPropiedad=@IdTipoPropiedad"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdTipoPropiedad", IdTipoPropiedad)
                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al eliminar el Tipo de Propiedad: " & ex.Message)
        End Try

    End Function
End Class
