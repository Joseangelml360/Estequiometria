Imports System.Data
Public Class TipoFormulaEntidad

    Public Shared Function TablaTiposFormula() As DataTable

        Dim Tabla As DataTable

        Tabla = New DataTable

        Tabla.Columns.Add("IdTipoFormula", GetType(Integer))
        Tabla.Columns.Add("Codigo", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("Observaciones", GetType(String))

        Return Tabla

    End Function
End Class
