Imports System.Data
Public Class MateriasPrimasEntidad

    Public Shared Function TablaMateriasPrimas() As DataTable
        Dim Tabla As DataTable

        Tabla = New DataTable
        Tabla.Columns.Add("IdMateriaPrima", GetType(Integer))
        Tabla.Columns.Add("Codigo", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("CodigoFamilia", GetType(String))
        Tabla.Columns.Add("CodigoSubFamilia", GetType(String))
        Tabla.Columns.Add("Proveedor", GetType(String))
        Tabla.Columns.Add("Precio", GetType(Decimal))
        Tabla.Columns.Add("Observaciones", GetType(String))

        Return Tabla

    End Function

    Public Shared Function TablaComboMateriasPrimas() As DataTable

        Dim Tabla As DataTable
        Tabla = New DataTable

        Tabla.Columns.Add("Codigo", GetType(String))
        Tabla.Columns.Add("Descripcion", GetType(String))
        Tabla.Columns.Add("MateriaPrima", GetType(String))

        Return Tabla

    End Function

End Class
