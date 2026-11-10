Imports System.Data
Public Class TiposPropiedadEntidad

    Public Shared Function TablaTiposPropiedad() As DataTable
        Dim Tabla As DataTable

        Tabla = New DataTable
        Tabla.Columns.Add("IdTipoPropiedad", GetType(Integer))
        Tabla.Columns.Add("Codigo", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("Unidad", GetType(String))

        Return Tabla

    End Function

End Class
