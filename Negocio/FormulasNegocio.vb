Imports Datos

Public Class FormulasNegocio

    Private ReadOnly datos As New FormulasDatos

    Public Function ObtenerFormulas() As DataTable

        Return datos.ObtenerFormulas()

    End Function

    Public Function InsertarFormula(Codigo As String,
                                    Descripcion As String,
                                    TipoFormula As String,
                                    Activa As Boolean,
                                    Observaciones As String) As Boolean

        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim
        TipoFormula = TipoFormula.Trim

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de la fórmula.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción de la fórmula.")
        End If

        If String.IsNullOrWhiteSpace(TipoFormula) Then
            Throw New Exception("Debe seleccionar un tipo de fórmula.")
        End If

        If datos.ExisteCodigoFormula(Codigo) Then
            Throw New Exception("Ya existe una fórmula con el código '" & Codigo & "'.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception("El código solo puede contener letras y números.")
        End If

        Return datos.InsertarFormula(Codigo,
                                     Descripcion,
                                     TipoFormula,
                                     Activa,
                                     Observaciones)

    End Function

    Public Function ModificarFormula(IdFormula As Integer,
                                     Codigo As String,
                                     Descripcion As String,
                                     TipoFormula As String,
                                     Activa As Boolean,
                                     Observaciones As String) As Boolean

        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim
        TipoFormula = TipoFormula.Trim

        If IdFormula <= 0 Then
            Throw New Exception("Id de fórmula incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de la fórmula.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción de la fórmula.")
        End If

        If String.IsNullOrWhiteSpace(TipoFormula) Then
            Throw New Exception("Debe seleccionar un tipo de fórmula.")
        End If

        If datos.ExisteCodigoFormulaM(Codigo, IdFormula) Then
            Throw New Exception("Ya existe una fórmula con el código '" & Codigo & "'.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception("El código solo puede contener letras y números.")
        End If

        Return datos.ModificarFormula(IdFormula,
                                      Codigo,
                                      Descripcion,
                                      TipoFormula,
                                      Activa,
                                     Observaciones)
    End Function

    Public Function ObtenerFormulasPorTipo(TipoFormula As String) As DataTable

        Return datos.ObtenerFormulasPorTipo(TipoFormula)

    End Function

End Class
