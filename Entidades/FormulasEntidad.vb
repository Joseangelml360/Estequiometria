Imports System.Data
Public Class FormulasEntidad

    Public Shared Function TablaFormulas() As DataTable
        Dim Tabla As DataTable

        Tabla = New DataTable
        Tabla.Columns.Add("IdFormula", GetType(Integer))
        Tabla.Columns.Add("Codigo", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("TipoFormula", GetType(String))
        Tabla.Columns.Add("FechaCreacion", GetType(DateTime))
        Tabla.Columns.Add("Activa", GetType(Boolean))
        Tabla.Columns.Add("Observaciones", GetType(String))

        Return Tabla

    End Function

End Class
