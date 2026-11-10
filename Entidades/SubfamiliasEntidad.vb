Imports System.Data
Public Class SubfamiliasEntidad

    Public Shared Function TablaSubfamilias() As DataTable
        Dim Tabla As DataTable

        Tabla = New DataTable
        Tabla.Columns.Add("IdSubfamilia", GetType(Integer))
        Tabla.Columns.Add("Codigo", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("CodigoFamilia", GetType(String))

        Return Tabla

    End Function

End Class
