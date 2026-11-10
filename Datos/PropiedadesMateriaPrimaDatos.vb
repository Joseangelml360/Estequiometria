Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class PropiedadesMateriaPrimaDatos

    Public Function ObtenerPropiedadesMateriaPrima(CodigoMateriaPrima As String) As DataTable

        Try
            Dim tabla As DataTable = PropiedadesMateriaPrimaEntidad.TablaPropiedadesMateriaPrima()

            Using cn As SqlConnection = Conexion.ObtenerConexion()

                Dim Sql As String = "SELECT p.IdPropiedad, " &
                                   "p.CodigoMateriaPrima, " &
                                   "p.CodigoPropiedad, " &
                                   "tp.Descripcion, " &
                                   "p.Valor, " &
                                   "tp.Unidad " &
                                   "FROM PropiedadesMateriaPrima p " &
                                   "INNER JOIN TiposPropiedad tp " &
                                   "ON p.CodigoPropiedad = tp.Codigo " &
                                   "WHERE p.CodigoMateriaPrima = @CodigoMateriaPrima " &
                                   "ORDER BY tp.Codigo"

                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)

                    Dim da As New SqlDataAdapter(cmd)

                    da.Fill(tabla)

                End Using
            End Using

            Return tabla

        Catch ex As Exception
            Throw New Exception("Error al obtener las propiedades: " & ex.Message)

        End Try

    End Function

    Public Function ExistePropiedadMateriaPrima(CodigoMateriaPrima As String, CodigoPropiedad As String) As Boolean

        'Esta función se llama para evitar duplicados en el modo Insertar

        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM PropiedadesMateriaPrima " &
                            "WHERE CodigoMateriaPrima = @CodigoMateriaPrima " &
                            "AND CodigoPropiedad = @CodigoPropiedad"


        Using cn As SqlConnection = Conexion.ObtenerConexion()

            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)
                cmd.Parameters.AddWithValue("@CodigoPropiedad", CodigoPropiedad)

                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function ExistePropiedadMateriaPrima(CodigoMateriaPrima As String, CodigoPropiedad As String,
                                                IdPropiedad As Integer) As Boolean

        'Esta función se llama para evitar duplicados en el modo Modificar

        Dim Sql As String = "SELECT COUNT(*) " &
                            "FROM PropiedadesMateriaPrima " &
                            "WHERE CodigoMateriaPrima = @CodigoMateriaPrima " &
                            "AND CodigoPropiedad = @CodigoPropiedad " &
                            "AND IdPropiedad <> @IdPropiedad"

        Using cn As SqlConnection = Conexion.ObtenerConexion()
            Using cmd As New SqlCommand(Sql, cn)

                cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)
                cmd.Parameters.AddWithValue("@CodigoPropiedad", CodigoPropiedad)
                cmd.Parameters.AddWithValue("@IdPropiedad", IdPropiedad)

                cn.Open()

                Return CInt(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function

    Public Function InsertarPropiedadMateriaPrima(CodigoMateriaPrima As String, CodigoPropiedad As String,
                                                  Valor As Decimal) As Boolean
        Try

            Dim Sql As String = "INSERT INTO PropiedadesMateriaPrima " &
                                "(CodigoMateriaPrima, CodigoPropiedad, Valor) " &
                                "VALUES " &
                                "(@CodigoMateriaPrima, @CodigoPropiedad, @Valor)"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)
                    cmd.Parameters.AddWithValue("@CodigoPropiedad", CodigoPropiedad)
                    cmd.Parameters.AddWithValue("@Valor", Valor)

                    cn.Open()

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception

            Throw New Exception("Error al insertar la propiedad: " & ex.Message)

        End Try

    End Function

    Public Function ModificarPropiedadMateriaPrima(IdPropiedad As Integer, CodigoMateriaPrima As String,
                                                   CodigoPropiedad As String, Valor As Decimal) As Boolean

        Try
            Dim Sql As String = "UPDATE PropiedadesMateriaPrima " &
                               "SET CodigoMateriaPrima = @CodigoMateriaPrima, " &
                               "CodigoPropiedad = @CodigoPropiedad, " &
                               "Valor = @Valor " &
                               "WHERE IdPropiedad = @IdPropiedad"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdPropiedad", IdPropiedad)
                    cmd.Parameters.AddWithValue("@CodigoMateriaPrima", CodigoMateriaPrima)
                    cmd.Parameters.AddWithValue("@CodigoPropiedad", CodigoPropiedad)
                    cmd.Parameters.AddWithValue("@Valor", Valor)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al modificar la propiedad: " & ex.Message)
        End Try

    End Function

    Public Function EliminarPropiedadMateriaPrima(IdPropiedad As Integer) As Boolean

        Try
            Dim Sql As String = "DELETE FROM PropiedadesMateriaPrima " &
                                "WHERE IdPropiedad = @IdPropiedad"

            Using cn As SqlConnection = Conexion.ObtenerConexion()
                Using cmd As New SqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@IdPropiedad", IdPropiedad)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True

        Catch ex As Exception
            Throw New Exception("Error al eliminar la propiedad: " & ex.Message)
        End Try

    End Function

End Class
