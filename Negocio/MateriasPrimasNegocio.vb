Imports Datos

Public Class MateriasPrimasNegocio

    Private ReadOnly datosMP As New MateriasPrimasDatos

    Public Function ObtenerMateriasPrimas() As DataTable

        Return datosMP.ObtenerMateriasPrimas()

    End Function

    Public Function ObtenerMateriasPrimasCombo() As DataTable

        Return datosMP.GetMateriasPrimasCombo()

    End Function
    Public Function InsertarMateriaPrima(Codigo As String,
                                         Descripcion As String,
                                         CodigoFamilia As String,
                                         CodigoSubfamilia As String,
                                         Proveedor As String,
                                         Precio As Decimal?,
                                         Observaciones As String) As Boolean

        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim
        Proveedor = Proveedor.Trim
        Observaciones = Observaciones.Trim

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código de la materia prima.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción.")
        End If

        If String.IsNullOrWhiteSpace(CodigoFamilia) Then
            Throw New Exception("Debe seleccionar una familia.")
        End If

        If String.IsNullOrWhiteSpace(CodigoSubfamilia) Then
            Throw New Exception("Debe seleccionar una subfamilia.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception(
        "El código solo puede contener letras y números.")
        End If

        If datosMP.ExisteCodigoMateriaPrima(Codigo) Then
            Throw New Exception("Ya existe una Materia Prima con el código '" & Codigo & "'.")
        End If

        Return datosMP.InsertarMateriaPrima(Codigo,
                                            Descripcion,
                                            CodigoFamilia,
                                            CodigoSubfamilia,
                                            Proveedor,
                                            Precio,
                                            Observaciones)

    End Function

    Public Function ModificarMateriaPrima(IdMateriaPrima As Integer,
                                          Codigo As String,
                                          Descripcion As String,
                                          CodigoFamilia As String,
                                          CodigoSubfamilia As String,
                                          Proveedor As String,
                                          Precio As Decimal?,
                                          Observaciones As String) As Boolean

        Codigo = Codigo.Trim.ToUpper
        Descripcion = Descripcion.Trim
        Proveedor = Proveedor.Trim
        Observaciones = Observaciones.Trim

        If IdMateriaPrima <= 0 Then
            Throw New Exception("Id de Materia Prima incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(Codigo) Then
            Throw New Exception("Debe informar el código.")
        End If

        If String.IsNullOrWhiteSpace(Descripcion) Then
            Throw New Exception("Debe informar la descripción.")
        End If

        If String.IsNullOrWhiteSpace(CodigoFamilia) Then
            Throw New Exception("Debe seleccionar una familia.")
        End If

        If String.IsNullOrWhiteSpace(CodigoSubfamilia) Then
            Throw New Exception("Debe seleccionar una subfamilia.")
        End If

        If datosMP.ExisteCodigoMateriaPrima(Codigo, IdMateriaPrima) Then
            Throw New Exception("Ya existe una Materia Prima con el código '" & Codigo & "'.")
        End If

        If Not Codigo.All(Function(c) Char.IsLetterOrDigit(c)) Then
            Throw New Exception(
        "El código solo puede contener letras y números.")
        End If

        Return datosMP.ModificarMateriaPrima(IdMateriaPrima,
                                             Codigo,
                                             Descripcion,
                                             CodigoFamilia,
                                             CodigoSubfamilia,
                                             Proveedor,
                                             Precio,
                                             Observaciones)

    End Function

End Class
