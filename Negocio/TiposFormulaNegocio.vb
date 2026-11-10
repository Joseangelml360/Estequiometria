Imports Entidades
Imports Datos
Imports System.Data
Public Class TiposFormulaNegocio
    Public ReadOnly datos As New TiposFormulaDatos

    Public Function ObtenerTiposFormula() As DataTable
        Return datos.ObtenerTiposFormula()
    End Function

    Public Function InsertarTipoFormula(id As Integer, codigo As String, descripcion As String,
                                        observaciones As String) As Boolean
        codigo = codigo.Trim.ToUpper
        descripcion = descripcion.Trim

        If String.IsNullOrWhiteSpace(codigo) Then
            Throw New Exception("Debe informar el código de tipo de fórmula.")
        End If

        If String.IsNullOrWhiteSpace(descripcion) Then
            Throw New Exception("Debe informar la descripción de tipo de fórmula.")
        End If

        If codigo.Length > 3 Then
            Throw New Exception("El código no puede tener más de 3 caracteres.")
        End If

        If Not codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception("El código solo puede contener letras y números.")
        End If

        If datos.ExisteCodigoTipoFormula(codigo, id) Then
            Throw New Exception("Ya existe una familia con el código '" & codigo & "'.")
        End If

        Return datos.InsertarTipoFormula(codigo, descripcion, observaciones)
    End Function

    Public Function ModificarTipoFormula(id As Integer, codigo As String, descripcion As String,
                                         observaciones As String) As Boolean

        codigo = codigo.Trim.ToUpper
        descripcion = descripcion.Trim

        If id <= 0 Then
            Throw New Exception("Id de tipo fórmula incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(codigo) Then
            Throw New Exception("Debe informar el tipo de fórmula.")
        End If

        If String.IsNullOrWhiteSpace(descripcion) Then
            Throw New Exception("Debe informar del tipo de fórmula.")
        End If

        If codigo.Length > 3 Then
            Throw New Exception("El código no puede tener más de 3 caracteres.")
        End If

        If Not codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception("El código solo puede contener letras y números.")
        End If

        If datos.ExisteCodigoTipoFormula(codigo, id) Then
            Throw New Exception("Ya existe una familia con el código '" & codigo & "'.")
        End If

        Return datos.ModificarTipoFormula(id, codigo, descripcion, observaciones)

    End Function

End Class
