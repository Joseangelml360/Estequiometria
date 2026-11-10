Imports System.Data
Imports Datos
Imports Entidades

Public Class FamiliasNegocio
    Private ReadOnly datosfamilia As New FamiliasDatos
    Public Function ObtenerFamilias() As DataTable

        Return datosfamilia.ObtenerFamilias()

    End Function

    Public Function InsertarFamilia(Codigo As String, Descripcion As String) As Boolean
        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de familia.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción de la familia.")
        End If

        If Codigo.Length > 3 Then
            Throw New Exception("El código no puede tener más de 3 caracteres.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception(
        "El código solo puede contener letras y números.")
        End If

        'If datosfamilia.ExisteCodigoFamilia(Codigo,) Then
        '    Throw New Exception(
        '    "Ya existe una familia con el código '" &
        '    Codigo & "'.")

        'End If

        Return datosfamilia.InsertarFamilia(Codigo, Descripcion)

    End Function

    Public Function ModificarFamilia(IdFamilia As Integer, Codigo As String, Descripcion As String) As Boolean
        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim

        If IdFamilia <= 0 Then
            Throw New Exception("Id de familia incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de familia.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción de la familia.")
        End If

        If Codigo.Length > 3 Then
            Throw New Exception("El código no puede tener más de 3 caracteres.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception(
        "El código solo puede contener letras y números.")
        End If

        If datosfamilia.ExisteCodigoFamilia(Codigo, IdFamilia) Then
            Throw New Exception(
            "Ya existe una familia con el código '" &
            Codigo & "'.")

        End If


        Return datosfamilia.ModificarFamilia(IdFamilia, Codigo, Descripcion)

    End Function

End Class
