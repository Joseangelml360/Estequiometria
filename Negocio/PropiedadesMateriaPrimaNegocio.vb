Imports Datos
Public Class PropiedadesMateriaPrimaNegocio

    Private ReadOnly datos As New PropiedadesMateriaPrimaDatos

    Public Function ObtenerPropiedadesMateriaPrima(CodigoMateriaPrima As String) As DataTable
        Return datos.ObtenerPropiedadesMateriaPrima(CodigoMateriaPrima)
    End Function

    Public Function InsertarPropiedadMateriaPrima(CodigoMateriaPrima As String, CodigoPropiedad As String,
                                                  Valor As Decimal) As Boolean

        If String.IsNullOrWhiteSpace(CodigoMateriaPrima) Then
            Throw New Exception("Debe seleccionar una materia prima.")
        End If

        If String.IsNullOrWhiteSpace(CodigoPropiedad) Then
            Throw New Exception("Debe seleccionar una propiedad.")
        End If

        If Valor <= 0 Then
            Throw New Exception("El valor debe ser mayor que cero.")
        End If

        If datos.ExistePropiedadMateriaPrima(CodigoMateriaPrima, CodigoPropiedad) Then
            Throw New Exception("La propiedad ya existe para esta materia prima.")
        End If

        Return datos.InsertarPropiedadMateriaPrima(CodigoMateriaPrima, CodigoPropiedad, Valor)

    End Function

    Public Function ModificarPropiedadMateriaPrima(IdPropiedad As Integer, CodigoMateriaPrima As String,
                                                   CodigoPropiedad As String, Valor As Decimal) As Boolean

        If IdPropiedad <= 0 Then
            Throw New Exception("Id de propiedad incorrecto.")
        End If

        If Valor <= 0 Then
            Throw New Exception("El valor debe ser mayor que cero.")
        End If

        If String.IsNullOrWhiteSpace(CodigoMateriaPrima) Then
            Throw New Exception("Debe seleccionar una materia prima.")
        End If

        If String.IsNullOrWhiteSpace(CodigoPropiedad) Then
            Throw New Exception("Debe seleccionar una propiedad.")
        End If

        If datos.ExistePropiedadMateriaPrima(CodigoMateriaPrima, CodigoPropiedad, IdPropiedad) Then
            Throw New Exception("La propiedad ya existe para esta materia prima.")
        End If

        Return datos.ModificarPropiedadMateriaPrima(IdPropiedad, CodigoMateriaPrima, CodigoPropiedad, Valor)

    End Function

    Public Function EliminarPropiedadMateriaPrima(IdPropiedad As Integer) As Boolean

        If IdPropiedad <= 0 Then
            Throw New Exception("Id de propiedad incorrecto.")
        End If

        Return datos.EliminarPropiedadMateriaPrima(IdPropiedad)

    End Function

End Class

