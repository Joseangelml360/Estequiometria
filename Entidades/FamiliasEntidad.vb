Imports System.Data
Public Class FamiliasEntidad
    Public Shared Function TablaFamilias() As DataTable
        Dim Tabla As DataTable

        Tabla = New DataTable
        Tabla.Columns.Add("IdFamilia", GetType(Integer))
        Tabla.Columns.Add("Codigo", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))

        Return Tabla

    End Function
End Class
