Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class TiposFormulaDatos

    Public Function ObtenerTiposFormula()

        Dim Tabla As DataTable = TipoFormulaEntidad.TablaTiposFormula()

        Using cn As SqlConnection = Conexion.ObtenerConexion

            cn.Open()
            Dim Sql As String = "SELECT * FROM TiposFormula ORDER BY Codigo"
            Dim da As New SqlDataAdapter(Sql, cn)
            da.Fill(Tabla)

        End Using
        Return Tabla
    End Function

    Public Function InsertarTipoFormula(Codigo As String, Descripcion As String,
                                        Observaciones As String) As Boolean

        Dim Sql As String = "INSERT INTO TiposFormula " &
                           "(Codigo, Descripcion, Observaciones) " &
                           "VALUES " &
                           "(@Codigo, @Descripcion, @Observaciones)"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@Observaciones", Observaciones)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al añadir Tipo de fórmula: " &
               ex.Message)
        End Try

    End Function

    Public Function ModificarTipoFormula(IdTipoFormula As Integer, Codigo As String, Descripcion As String,
                                         Observaciones As String) As Boolean

        Dim Sql As String = "UPDATE TiposFamilia " &
                         "SET Codigo=@Codigo, " &
                         "Descripcion=@Descripcion " &
                         "Observaciones=@Observaciones" &
                         "WHERE IdTipoFormula=@IdTipoFormula"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdTipoFormula", IdTipoFormula)
                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@Observaciones", Observaciones)
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

    Public Function ExisteCodigoTipoFormula(Codigo As String, IdTipoFormula As Integer) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                           "FROM TiposFormula " &
                           "WHERE Codigo = @Codigo " &
                           "AND IdTipoFormula <> @IdTipoFormula"

        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cmd.Parameters.AddWithValue("@IdTipoFormula", IdTipoFormula)

                cn.Open()
                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

End Class
