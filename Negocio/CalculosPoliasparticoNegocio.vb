Imports Entidades
Imports Datos
Public Class CalculosPoliasparticoNegocio
    Private ReadOnly negocioComponentes As New ComponentesFormulaNegocio
    Public Function CalcularEquivalentesNH(IdFormula As Integer) As Decimal

        Dim dt As DataTable

        Dim EqNH As Decimal = 0D

        dt = negocioComponentes.ObtenerPropiedadesFormula(IdFormula)


        For Each fila As DataRow In dt.Rows

            Dim Cantidad As Decimal = CDec(fila("Cantidad"))

            Dim CodigoPropiedad As String = fila("CodigoPropiedad").ToString

            Dim Valor As Decimal = CDec(fila("Valor"))

            If CodigoPropiedad = "AHEW" Then
                EqNH += (Cantidad * Valor) / 56100D
            End If

        Next

        Return EqNH

    End Function

    Public Function CalcularEquivalentesNCO(IdFormula As Integer) As Decimal

        Dim dt As DataTable

        Dim EqNCO As Decimal = 0D

        dt = negocioComponentes.ObtenerPropiedadesFormula(IdFormula)

        For Each fila As DataRow In dt.Rows

            Dim Cantidad As Decimal = CDec(fila("Cantidad"))

            Dim CodigoPropiedad As String = fila("CodigoPropiedad").ToString

            Dim Valor As Decimal = CDec(fila("Valor"))

            If CodigoPropiedad = "NCO" Then

                EqNCO += (Cantidad * Valor / 100D) / 42D

            End If

        Next

        Return EqNCO

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

                Case "AHEW"

                    Equivalentes = (Cantidad * Valor) / 56100D

                Case "NCO"

                    Equivalentes = (Cantidad * Valor / 100D) / 42D

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
