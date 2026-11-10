Imports System.Data
Imports Datos
Imports Entidades
Public Class TiposPropiedadNegocio
    Private ReadOnly datosTipoPropiedad As New TiposPropiedadDatos
    Public Function ObtenerTiposPropiedad() As DataTable

        Return datosTipoPropiedad.ObtenerTiposPropiedad()

    End Function

    Public Function InsertarTipoPropiedad(IdTipoPropiedad As Integer, Codigo As String,
                                          Descripcion As String, Unidad As String) As Boolean
        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código del Tipo de Propiedad.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción del Tipo de Propiedad.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception(
        "El código solo puede contener letras y números.")
        End If

        If datosTipoPropiedad.ExisteCodigoTipoPropiedad(Codigo, IdTipoPropiedad) Then
            Throw New Exception("Ya existe una TipoPropiedad con el código '" & Codigo & "'.")
        End If

        Return datosTipoPropiedad.InsertarTipoPropiedad(Codigo, Descripcion, Unidad)

    End Function

    Public Function ModificarTipoPropiedad(IdTipoPropiedad As Integer, Codigo As String,
                                           Descripcion As String, Unidad As String) As Boolean
        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim
        Unidad = Unidad.Trim

        If IdTipoPropiedad <= 0 Then
            Throw New Exception("Id de TipoPropiedad incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de TipoPropiedad.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción de la TipoPropiedad.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception("El código solo puede contener letras y números.")
        End If

        If datosTipoPropiedad.ExisteCodigoTipoPropiedad(Codigo, IdTipoPropiedad) Then
            Throw New Exception("Ya existe una TipoPropiedad con el código '" & Codigo & "'.")
        End If

        Return datosTipoPropiedad.ModificarTipoPropiedad(IdTipoPropiedad, Codigo, Descripcion, Unidad)

    End Function
End Class
