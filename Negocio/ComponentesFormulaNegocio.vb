Imports Datos

Public Class ComponentesFormulaNegocio

    Private ReadOnly datos As New ComponentesFormulaDatos

    Public Function ObtenerComponentesFormula(IdFormula As Integer) As DataTable

        If IdFormula <= 0 Then
            Throw New Exception("Id de fórmula incorrecto.")
        End If

        Return datos.ObtenerComponentesFormula(IdFormula)

    End Function

    Public Function InsertarComponente(IdFormula As Integer,
                                       CodigoMateriaPrima As String,
                                       Cantidad As Decimal) As Boolean

        CodigoMateriaPrima = CodigoMateriaPrima.Trim.ToUpper

        If IdFormula <= 0 Then
            Throw New Exception("Id de fórmula incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(CodigoMateriaPrima) Then
            Throw New Exception("Debe seleccionar una materia prima.")
        End If

        If Cantidad <= 0 Then
            Throw New Exception("La cantidad debe ser mayor que cero.")
        End If

        If datos.ExisteMateriaPrimaFormula(IdFormula, CodigoMateriaPrima) Then
            Throw New Exception("La materia prima ya existe en la fórmula.")
        End If

        Return datos.InsertarComponente(IdFormula, CodigoMateriaPrima, Cantidad)

    End Function

    Public Function ModificarComponente(IdComponente As Integer,
                                        IdFormula As Integer,
                                        CodigoMateriaPrima As String,
                                        Cantidad As Decimal) As Boolean

        CodigoMateriaPrima = CodigoMateriaPrima.Trim.ToUpper

        If IdComponente <= 0 Then
            Throw New Exception("Id de componente incorrecto.")
        End If

        If IdFormula <= 0 Then
            Throw New Exception("Id de fórmula incorrecto.")
        End If

        If String.IsNullOrWhiteSpace(CodigoMateriaPrima) Then
            Throw New Exception("Debe seleccionar una materia prima.")
        End If

        If Cantidad <= 0 Then
            Throw New Exception("La cantidad debe ser mayor que cero.")
        End If

        If datos.ExisteMateriaPrimaFormulaM(IdFormula, CodigoMateriaPrima, IdComponente) Then
            Throw New Exception("La materia prima ya existe en la fórmula.")
        End If

        Return datos.ModificarComponente(IdComponente,
                                         IdFormula,
                                         CodigoMateriaPrima,
                                         Cantidad)

    End Function

    Public Function EliminarComponente(IdComponente As Integer) As Boolean

        If IdComponente <= 0 Then
            Throw New Exception("Id de componente incorrecto.")
        End If

        Return datos.EliminarComponente(IdComponente)

    End Function

    Public Function ObtenerSumaComponentes(IdFormula As Integer) As Decimal

        If IdFormula <= 0 Then
            Throw New Exception("Id de fórmula incorrecto.")
        End If

        Return datos.ObtenerSumaComponentes(IdFormula)

    End Function

    Public Function ObtenerPropiedadesFormula(IdFormula As Integer) As DataTable

        If IdFormula <= 0 Then
            Throw New Exception("Id de fórmula incorrecto.")
        End If

        Return datos.ObtenerPropiedadesFormula(IdFormula)

    End Function

    Public Sub ModificarCantidadComponente(IdComponente As Integer, Cantidad As Decimal)

        datos.ModificarCantidadComponente(IdComponente, Cantidad)

    End Sub

End Class
