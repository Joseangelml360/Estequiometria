Imports System.Data
Public Class PropiedadesMateriaPrimaEntidad

    Public Shared Function TablaPropiedadesMateriaPrima() As DataTable
        Dim Tabla As DataTable

        Tabla = New DataTable
        Tabla.Columns.Add("IdPropiedad", GetType(Integer))
        Tabla.Columns.Add("CodigoMateriaPrima", GetType(String))
        Tabla.Columns.Add("CodigoPropiedad", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("Valor", GetType(Decimal))
        Tabla.Columns.Add("Unidad", GetType(String))

        Return Tabla

    End Function
End Class
