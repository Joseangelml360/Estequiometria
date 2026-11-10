Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class ComponentesFormulaDatos
    Public Function ObtenerComponentesFormula(IdFormula As Integer) As DataTable

        Try

            Dim Tabla As DataTable = ComponentesFormulaEntidad.TablaComponentesFormula()

            Dim Sql As String = "SELECT cf.IdComponente, " &
                                "cf.IdFormula, " &
                                "cf.CodigoMateriaPrima, " &
                                "mp.Descripcion, " &
                                "cf.Cantidad " &
                                "FROM ComponentesFormula cf " &
                                "INNER JOIN MateriasPrimas mp " &
                                "ON cf.CodigoMateriaPrima = mp.Codigo " &
                                "WHERE cf.IdFormula = @IdFormula " &
                                "ORDER BY mp.Descripcion"


            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdFormula", IdFormula)

                    Dim da As New SqlDataAdapter(cmd)

                    da.Fill(Tabla)

                End Using
            End Using

            Return Tabla

        Catch ex As Exception
            Throw New Exception("Error al obtener los componentes: " & ex.Message)
        End Try

    End Function

    Public Function ExisteMateriaPrimaFormula(IdFormula As Integer, CodigoMateriaPrima As String) As Boolean


        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM ComponentesFormula " &
                            "WHERE IdFormula = @IdFormula " &
                            "AND CodigoMateriaPrima = @CodigoMateriaPrima"

        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@IdFormula", IdFormula)
                cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)

                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function ExisteMateriaPrimaFormulaM(IdFormula As Integer, CodigoMateriaPrima As String,
                                               IdComponente As Integer) As Boolean



        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM ComponentesFormula " &
                            "WHERE IdFormula = @IdFormula " &
                            "AND CodigoMateriaPrima = @CodigoMateriaPrima " &
                            "AND IdComponente <> @IdComponente"


        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@IdFormula", IdFormula)
                cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)
                cmd.Parameters.AddWithValue("@IdComponente", IdComponente)

                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function InsertarComponente(IdFormula As Integer, CodigoMateriaPrima As String,
                                       Cantidad As Decimal) As Boolean



        Try

            Dim Sql As String = "INSERT INTO ComponentesFormula " &
                                "(IdFormula, CodigoMateriaPrima, Cantidad) " &
                                "VALUES " &
                                "(@IdFormula, @CodigoMateriaPrima, @Cantidad)"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdFormula", IdFormula)
                    cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad)

                    cn.Open()

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al insertar el componente: " & ex.Message)
        End Try

    End Function

    Public Function ModificarComponente(IdComponente As Integer, IdFormula As Integer,
                                        CodigoMateriaPrima As String, Cantidad As Decimal) As Boolean
        Try

            Dim Sql As String = "UPDATE ComponentesFormula " &
                                "SET CodigoMateriaPrima = @CodigoMateriaPrima, " &
                                "Cantidad = @Cantidad " &
                                "WHERE IdComponente = @IdComponente"


            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdComponente", IdComponente)
                    cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al modificar el componente: " & ex.Message)
        End Try

    End Function

    Public Function EliminarComponente(IdComponente As Integer) As Boolean

        Try
            Dim Sql As String = "DELETE FROM ComponentesFormula " & "WHERE IdComponente = @IdComponente"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdComponente", IdComponente)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al eliminar el componente: " & ex.Message)
        End Try

    End Function

    Public Function ObtenerSumaComponentes(IdFormula As Integer) As Decimal

        Try
            Dim Sql As String = "SELECT ISNULL(SUM(Cantidad),0) " &
                                "FROM ComponentesFormula " &
                                "WHERE IdFormula = @IdFormula"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdFormula", IdFormula)
                    cn.Open()

                    Return CDec(cmd.ExecuteScalar())

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error al obtener la suma de componentes: " & ex.Message)

        End Try

    End Function

    Public Function ObtenerPropiedadesFormula(IdFormula As Integer) As DataTable


        Try
            Dim Tabla As New DataTable
            Dim Sql As String = "SELECT " &
                                "cf.IdFormula, " &
                                "cf.CodigoMateriaPrima, " &
                                "mp.Descripcion AS MateriaPrima, " &
                                "cf.Cantidad, " &
                                "ppm.CodigoPropiedad, " &
                                "tp.Descripcion AS Propiedad, " &
                                "ppm.Valor " &
                                "FROM ComponentesFormula cf " &
                                "INNER JOIN MateriasPrimas mp " &
                                "ON cf.CodigoMateriaPrima = mp.Codigo " &
                                "INNER JOIN PropiedadesMateriaPrima ppm " &
                                "ON cf.CodigoMateriaPrima = ppm.CodigoMateriaPrima " &
                                "INNER JOIN TiposPropiedad tp " &
                                "ON ppm.CodigoPropiedad = tp.Codigo " &
                                "WHERE cf.IdFormula = @IdFormula " &
                                "ORDER BY cf.CodigoMateriaPrima, ppm.CodigoPropiedad"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdFormula", IdFormula)

                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(Tabla)

                End Using
            End Using

            Return Tabla

        Catch ex As Exception
            Throw New Exception("Error al obtener las propiedades de la fórmula: " & ex.Message)
        End Try

    End Function

    Public Sub ModificarCantidadComponente(IdComponente As Integer, Cantidad As Decimal)

        Dim sql As String = "UPDATE ComponentesFormula SET Cantidad = @Cantidad WHERE IdComponente = @IdComponente"

        Using cn As SqlConnection =
            Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@Cantidad", Cantidad)
                cmd.Parameters.AddWithValue("@IdComponente", IdComponente)

                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using

    End Sub

End Class
