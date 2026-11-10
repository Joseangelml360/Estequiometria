Imports System.Data
Imports Datos
Imports Entidades
Public Class SubfamiliasNegocio
    Private ReadOnly datosSubfamilia As New SubFamiliasDatos
    Public Function ObtenerSubfamilias() As DataTable

        Return datosSubfamilia.ObtenerSubfamilias()

    End Function

    Public Function InsertarSubfamilia(Codigo As String, Descripcion As String, CodigoFamilia As String) As Boolean
        Codigo = Codigo.Trim.ToUpper
        CodigoFamilia = CodigoFamilia.Trim.ToUpper
        Descripcion = Descripcion.Trim

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de Subfamilia.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción de la Subfamilia.")
        End If

        If Codigo.Length > 3 Then
            Throw New Exception("El código no puede tener más de 3 caracteres.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception("El código solo puede contener letras y números.")
        End If

        'If datosSubfamilia.ExisteCodigoSubfamilia(Codigo,) Then
        '    Throw New Exception(
        '    "Ya existe una Subfamilia con el código '" &
        '    Codigo & "'.")

        'End If

        Return datosSubfamilia.InsertarSubfamilia(Codigo, Descripcion, CodigoFamilia)

    End Function

    Public Function ModificarSubfamilia(IdSubfamilia As Integer, Codigo As String, Descripcion As String) As Boolean

        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim

        If IdSubfamilia <= 0 Then
            Throw New Exception("Id de Subfamilia incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de Subfamilia.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción de la Subfamilia.")
        End If

        If Codigo.Length > 3 Then
            Throw New Exception("El código no puede tener más de 3 caracteres.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception(
        "El código solo puede contener letras y números.")
        End If

        If datosSubfamilia.ExisteCodigoSubfamilia(Codigo, IdSubfamilia) Then
            Throw New Exception("Ya existe una Subfamilia con el código '" & Codigo & "'.")

        End If


        Return datosSubfamilia.ModificarSubfamilia(IdSubfamilia, Codigo, Descripcion)

    End Function

    Public Function ObtenerSubfamiliasPorFamilia(CodigoFamilia As String) As DataTable

        Return datosSubfamilia.ObtenerSubfamiliasPorFamilia(CodigoFamilia)

    End Function

End Class
