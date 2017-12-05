Public Class BXP_Catalogos

    Public Function GetService() As DataTable

        Dim Ws As New BXP_WebServiceSQL
        Dim Common As New BXP_Common
        Dim Dt As DataTable = Nothing
        Dim Query As String = ""

        Try
            Query = "SELECT Code, Name FROM " + Common.NameBDSAP + ".[dbo].[@MET_TRANSPORT] ORDER BY Code ASC "
            Dt = Ws.Query1(Query).Tables(0)
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al generar catalogo de servicios " + ex.Message)
        End Try

        Return Dt

    End Function

    Public Function GetCurrency() As DataTable

        Dim Ws As New BXP_WebServiceSQL
        Dim Common As New BXP_Common
        Dim Dt As DataTable = Nothing
        Dim Query As String = ""

        Try
            Query = "SELECT CurrCode, CurrName FROM " + Common.NameBDSAP + ".[dbo].OCRN ORDER BY CurrCode DESC "
            Dt = Ws.Query1(Query).Tables(0)
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al generar catalogo de monedas " + ex.Message)
        End Try

        Return Dt

    End Function

    Public Function GetIncoterm() As DataTable

        Dim Ws As New BXP_WebServiceSQL
        Dim Common As New BXP_Common
        Dim Dt As DataTable = Nothing
        Dim Query As String = ""

        Try
            Query = "SELECT Name, Code FROM " + Common.NameBDSAP + ".[dbo].[@INCOTERM] ORDER BY Code DESC "
            Dt = Ws.Query1(Query).Tables(0)
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al generar catalogo de incoterm " + ex.Message)
        End Try

        Return Dt

    End Function

    Public Function GetTypeService() As DataTable

        Dim Ws As New BXP_WebServiceSQL
        Dim Common As New BXP_Common
        Dim Dt As DataTable = Nothing
        Dim Query As String = ""

        Try
            Query = "SELECT Name, Code FROM " + Common.NameBDSAP + ".[dbo].[@TIPO_SERVICIO] ORDER BY Name DESC "
            Dt = Ws.Query1(Query).Tables(0)
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al generar catalogo de Tipo de servicio " + ex.Message)
        End Try

        Return Dt

    End Function

End Class
