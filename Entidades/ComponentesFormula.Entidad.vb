Imports System.Data

Public Class ComponentesFormulaEntidad

    Public Shared Function TablaComponentesFormula() As DataTable

        Dim Tabla As New DataTable

        Tabla.Columns.Add("IdComponente", GetType(Integer))
        Tabla.Columns.Add("IdFormula", GetType(Integer))
        Tabla.Columns.Add("CodigoMateriaPrima", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("Cantidad", GetType(Decimal))

        Return Tabla

    End Function

End Class
