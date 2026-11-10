Imports System.Data
Public Class CalculosEntidad
    Public Shared Function TablaDetalleCalculoEstequiometrico() As DataTable

        Dim Tabla As New DataTable

        Tabla.Columns.Add("Parte", GetType(String))
        Tabla.Columns.Add("MateriaPrima", GetType(String))
        Tabla.Columns.Add("Cantidad", GetType(Decimal))
        Tabla.Columns.Add("Propiedad", GetType(String))
        Tabla.Columns.Add("Valor", GetType(Decimal))
        Tabla.Columns.Add("Equivalentes", GetType(Decimal))

        Return Tabla

    End Function
End Class
