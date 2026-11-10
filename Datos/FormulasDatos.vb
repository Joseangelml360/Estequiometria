Imports System.Data.SqlClient
Imports Entidades
Public Class FormulasDatos
    Public Function ObtenerFormulas() As DataTable

        Try

            Dim Tabla As DataTable = FormulasEntidad.TablaFormulas()

            Dim Sql As String = "SELECT " &
                                 "f.IdFormula, " &
                                 "f.Codigo, " &
                                 "f.Descripcion, " &
                                 "f.TipoFormula, " &
                                 "f.FechaCreacion, " &
                                 "f.Activa, " &
                                 "f.Observaciones " &
                                 "FROM Formulas f " &
                                 "ORDER BY f.Codigo"


            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using da As New SqlDataAdapter(Sql, cn)

                    da.Fill(Tabla)

                End Using
            End Using

            Return Tabla

        Catch ex As Exception
            Throw New Exception("Error al obtener las fórmulas: " & ex.Message)
        End Try

    End Function

    Public Function ExisteCodigoFormula(Codigo As String) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM Formulas " &
                            "WHERE Codigo = @Codigo"


        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function ExisteCodigoFormulaM(Codigo As String, IdFormula As Integer) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM Formulas " &
                            "WHERE Codigo = @Codigo " &
                            "AND IdFormula <> @IdFormula"


        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cmd.Parameters.AddWithValue("@IdFormula", IdFormula)

                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function InsertarFormula(Codigo As String,
                                    Descripcion As String,
                                    TipoFormula As String,
                                    Activa As Boolean,
                                    Observaciones As String) As Boolean
        Try

            Dim Sql As String = "INSERT INTO Formulas " &
                                "(Codigo, Descripcion, TipoFormula, Activa, Observaciones) " &
                                "VALUES " &
                                "(@Codigo, @Descripcion, @TipoFormula, @Activa, @Observaciones)"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@TipoFormula", TipoFormula)
                    cmd.Parameters.AddWithValue("@Activa", Activa)
                    cmd.Parameters.AddWithValue("@Observaciones", If(String.IsNullOrWhiteSpace(Observaciones),
                                                 DBNull.Value, Observaciones))

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al insertar la fórmula: " & ex.Message)

        End Try

    End Function

    Public Function ModificarFormula(IdFormula As Integer,
                                     Codigo As String,
                                     Descripcion As String,
                                     TipoFormula As String,
                                     Activa As Boolean,
                                     Observaciones As String) As Boolean
        Try

            Dim Sql As String = "UPDATE Formulas " &
                                "SET Codigo = @Codigo, " &
                                "Descripcion = @Descripcion, " &
                                "TipoFormula = @TipoFormula, " &
                                "Activa = @Activa, " &
                                "Observaciones = @Observaciones " &
                                "WHERE IdFormula = @IdFormula"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdFormula", IdFormula)
                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@TipoFormula", TipoFormula)
                    cmd.Parameters.AddWithValue("@Activa", Activa)
                    cmd.Parameters.AddWithValue("@Observaciones", If(String.IsNullOrWhiteSpace(Observaciones),
                                                 DBNull.Value, Observaciones))

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al modificar la fórmula: " & ex.Message)
        End Try

    End Function

    Public Function ObtenerFormulasPorTipo(TipoFormula As String) As DataTable

        Try

            Dim Tabla As New DataTable

            Dim Sql As String = "SELECT IdFormula, Codigo, Descripcion, " &
                                "Codigo + ' - ' + Descripcion AS Formula " &
                                "FROM Formulas " &
                                "WHERE Activa = 1 " &
                                "AND TipoFormula = @TipoFormula " &
                                "ORDER BY Codigo"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@TipoFormula", TipoFormula)

                    Dim da As New SqlDataAdapter(cmd)

                    da.Fill(Tabla)

                End Using
            End Using

            Return Tabla

        Catch ex As Exception

            Throw New Exception("Error al obtener las fórmulas: " & ex.Message)

        End Try

    End Function

End Class
