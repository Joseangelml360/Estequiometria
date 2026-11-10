Imports Datos
Imports Entidades
Public Class CalculosEpoxiNegocio
    Private ReadOnly negocioComponentes As New ComponentesFormulaNegocio

    Public Function CalcularEquivalentesEpoxi(IdFormula As Integer) As Decimal

        Dim dt As DataTable

        Dim EqEpoxi As Decimal = 0D

        dt = negocioComponentes.ObtenerPropiedadesFormula(IdFormula)

        For Each fila As DataRow In dt.Rows

            Dim Cantidad As Decimal = CDec(fila("Cantidad"))

            Dim CodigoPropiedad As String = fila("CodigoPropiedad").ToString

            Dim Valor As Decimal = CDec(fila("Valor"))

            If CodigoPropiedad = "EEW" Then
                EqEpoxi += Cantidad / Valor
            End If

        Next

        Return EqEpoxi

    End Function

    Public Function CalcularEquivalentesAmina(IdFormula As Integer) As Decimal

        Dim dt As DataTable

        Dim EqAmina As Decimal = 0D

        dt = negocioComponentes.ObtenerPropiedadesFormula(IdFormula)

        For Each fila As DataRow In dt.Rows

            Dim Cantidad As Decimal = CDec(fila("Cantidad"))

            Dim CodigoPropiedad As String = fila("CodigoPropiedad").ToString

            Dim Valor As Decimal = CDec(fila("Valor"))

            If CodigoPropiedad = "AHEW" Then

                EqAmina += Cantidad / Valor

            End If

        Next

        Return EqAmina

    End Function

    Public Function ObtenerDetalleCalculoEstequiometrico(IdFormula As Integer, Parte As String) As DataTable

        Dim dtPropiedades As DataTable
        Dim dtDetalle As DataTable

        dtPropiedades = negocioComponentes.ObtenerPropiedadesFormula(IdFormula)

        dtDetalle = CalculosEntidad.TablaDetalleCalculoEstequiometrico()

        For Each fila As DataRow In dtPropiedades.Rows

            Dim Cantidad As Decimal = CDec(fila("Cantidad"))

            Dim CodigoPropiedad As String = fila("CodigoPropiedad").ToString

            Dim Valor As Decimal = CDec(fila("Valor"))

            Dim Equivalentes As Decimal = 0D

            Select Case CodigoPropiedad

                Case "EEW"

                    Equivalentes = Cantidad / Valor

                Case "AHEW"

                    Equivalentes = Cantidad / Valor

                Case Else

                    Continue For

            End Select

            dtDetalle.Rows.Add(Parte,
                               fila("MateriaPrima"),
                               Cantidad,
                               CodigoPropiedad,
                               Valor,
                               Equivalentes)

        Next

        Return dtDetalle

    End Function
End Class
