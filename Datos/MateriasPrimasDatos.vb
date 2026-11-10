Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class MateriasPrimasDatos

    Public Function ObtenerMateriasPrimas() As DataTable

        Try
            Dim Tabla As DataTable =
            MateriasPrimasEntidad.TablaMateriasPrimas()

            Dim Sql As String = "SELECT IdMateriaPrima, Codigo, Descripcion, " &
                           "CodigoFamilia, CodigoSubfamilia, " &
                           "Proveedor, Precio, Observaciones " &
                           "FROM MateriasPrimas " &
                           "ORDER BY Codigo"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using da As New SqlDataAdapter(Sql, cn)

                    da.Fill(Tabla)

                End Using
            End Using

            Return Tabla

        Catch ex As Exception
            Throw New Exception("Error al obtener las Materias Primas: " & ex.Message)
        End Try

    End Function

    Public Function GetMateriasPrimasCombo() As DataTable

        Try
            Dim tabla As DataTable = MateriasPrimasEntidad.TablaComboMateriasPrimas()

            Using cn As SqlConnection = Conexion.ObtenerConexion
                cn.Open()
                Dim Sql As String = "SELECT Codigo, Descripcion, " &
                                    "Codigo + ' - ' + Descripcion AS MateriaPrima " &
                                    "From MateriasPrimas Order By Codigo"

                Dim da As New SqlDataAdapter(Sql, cn)
                da.Fill(tabla)

            End Using

            Return tabla

        Catch ex As Exception
            Throw New Exception("Error al obtener las Materias Primas: " & ex.Message)
        End Try


    End Function

    Public Function ExisteCodigoMateriaPrima(Codigo As String) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM MateriasPrimas " &
                            "WHERE Codigo = @Codigo"

        Using cn As SqlConnection =
        Conexion.ObtenerConexion()

            Using cmd As New SqlCommand(Sql, cn)
                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function InsertarMateriaPrima(
    Codigo As String,
    Descripcion As String,
    CodigoFamilia As String,
    CodigoSubfamilia As String,
    Proveedor As String,
    Precio As Decimal?,
    Observaciones As String) As Boolean

        Dim Sql As String = "INSERT INTO MateriasPrimas " &
                           "(Codigo, Descripcion, CodigoFamilia, CodigoSubfamilia, " &
                           "Proveedor, Precio, Observaciones) " &
                           "VALUES " &
                           "(@Codigo, @Descripcion, @CodigoFamilia, @CodigoSubfamilia, " &
                           "@Proveedor, @Precio, @Observaciones)"

        Try
            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@CodigoFamilia", CodigoFamilia)
                    cmd.Parameters.AddWithValue("@CodigoSubfamilia", CodigoSubfamilia)

                    cmd.Parameters.AddWithValue(
                        "@Proveedor",
                        If(String.IsNullOrWhiteSpace(Proveedor),
                           DBNull.Value,
                           Proveedor))

                    cmd.Parameters.AddWithValue(
                        "@Precio",
                        If(Precio.HasValue,
                           CType(Precio.Value, Object),
                           DBNull.Value))

                    cmd.Parameters.AddWithValue(
                        "@Observaciones",
                        If(String.IsNullOrWhiteSpace(Observaciones),
                           DBNull.Value,
                           Observaciones))

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception(
                "Error al insertar la Materia Prima: " &
               ex.Message)
        End Try

    End Function

    Public Function ExisteCodigoMateriaPrima(
    Codigo As String,
    IdMateriaPrima As Integer) As Boolean

        Dim Sql As String = "SELECT COUNT(*) " &
                           "FROM MateriasPrimas " &
                           "WHERE Codigo = @Codigo " &
                           "AND IdMateriaPrima <> @IdMateriaPrima"

        Using cn As SqlConnection = Conexion.ObtenerConexion()

            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@Codigo", Codigo)
                cmd.Parameters.AddWithValue("@IdMateriaPrima", IdMateriaPrima)

                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using

        End Using

    End Function

    Public Function ModificarMateriaPrima(IdMateriaPrima As Integer,
                                          Codigo As String,
                                          Descripcion As String,
                                          CodigoFamilia As String,
                                          CodigoSubfamilia As String,
                                          Proveedor As String,
                                          Precio As Decimal?,
                                          Observaciones As String) As Boolean

        Dim Sql As String = "UPDATE MateriasPrimas " &
                           "SET Codigo=@Codigo, " &
                           "Descripcion=@Descripcion, " &
                           "CodigoFamilia=@CodigoFamilia, " &
                           "CodigoSubfamilia=@CodigoSubfamilia, " &
                           "Proveedor=@Proveedor, " &
                           "Precio=@Precio, " &
                           "Observaciones=@Observaciones " &
                           "WHERE IdMateriaPrima=@IdMateriaPrima"

        Try

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdMateriaPrima", IdMateriaPrima)
                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@CodigoFamilia", CodigoFamilia)
                    cmd.Parameters.AddWithValue("@CodigoSubfamilia", CodigoSubfamilia)

                    cmd.Parameters.AddWithValue(
                        "@Proveedor",
                        If(String.IsNullOrWhiteSpace(Proveedor),
                        DBNull.Value,
                        Proveedor))

                    cmd.Parameters.AddWithValue(
                        "@Precio",
                        If(Precio.HasValue,
                        CType(Precio.Value, Object),
                        DBNull.Value))

                    cmd.Parameters.AddWithValue(
                        "@Observaciones",
                        If(String.IsNullOrWhiteSpace(Observaciones),
                        DBNull.Value,
                        Observaciones))

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception

            Throw New Exception(
                "Error al modificar la Materia Prima: " &
                ex.Message)

        End Try

    End Function

End Class
