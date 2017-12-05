Imports System.Web.Services

Public Class BXP_PageWebService
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

#Region "WebMethod"


    <WebMethod()>
    Public Shared Function GetCustomers(prefix As String) As String()

        Try
            Dim resultado As New List(Of String)()
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Common As New BXP_Common

            If prefix = "*" Then
                Query = "SELECT DISTINCT TOP 20 A.CardName + ' / ' + B.CardFName CardName FROM Prototipo_Desarrollos.dbo.OCRD A INNER JOIN (SELECT CASE WHEN CardFName IS NULL THEN ' ' ELSE CardFName END CardFName, CardCode FROM Prototipo_Desarrollos.dbo.OCRD) B ON A.CardCode = B.CardCode WHERE A.CardType = 'C' and (A.validFor = 'Y' OR A.frozenFor = 'N') "
            Else
                Query = "SELECT DISTINCT TOP 20 A.CardName + ' / ' + B.CardFName CardName FROM Prototipo_Desarrollos.dbo.OCRD A INNER JOIN (SELECT CASE WHEN CardFName IS NULL THEN ' ' ELSE CardFName END CardFName, CardCode FROM Prototipo_Desarrollos.dbo.OCRD) B ON A.CardCode = B.CardCode WHERE A.CardType = 'C' and (A.validFor = 'Y' OR A.frozenFor = 'N') and (A.CardName Like '%" + Common.Sanea(prefix) + "%' or A.CardFName Like '%" + Common.Sanea(prefix) + "%') "
            End If

            Using sdr As DataSet = Ws.Query1(Query)
                For Each row As DataRow In sdr.Tables(0).Rows
                    resultado.Add(String.Format("{0}", row("CardName")))
                Next
            End Using
            Return resultado.ToArray()
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("GetCustomers - " + ex.Message)
            Return Nothing
        End Try

    End Function

    <WebMethod()>
    Public Shared Function Po(prefix As String) As String()

        Try
            Dim resultado As New List(Of String)()
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Common As New BXP_Common

            If prefix = "*" Then
                Query = "Select distinct TOP 10 Code + ' / ' + Name Name From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] "
            Else
                Query = "Select distinct TOP 10 Code + ' / ' + Name Name From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
            End If

            Using sdr As DataSet = Ws.Query1(Query)
                For Each row As DataRow In sdr.Tables(0).Rows
                    resultado.Add(String.Format("{0}", row("Name")))
                Next
            End Using
            Return resultado.ToArray()
        Catch ex As Exception

            Return Nothing
        End Try

    End Function

    <WebMethod()>
    Public Shared Function Po2(prefix As String) As String()

        Try
            Dim resultado As New List(Of String)()
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""


            Dim Common As New BXP_Common

            If prefix = "*" Then
                Query = "Select TOP 10 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL]  "
            Else
                Query = "Select TOP 10 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_POL_NAME Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
            End If

            Using sdr As DataSet = Ws.Query1(Query)
                For Each row As DataRow In sdr.Tables(0).Rows
                    resultado.Add(String.Format("{0}", row("U_POL_NAME")))
                Next
            End Using
            Return resultado.ToArray()
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Po2 - " + ex.Message)
            Return Nothing
        End Try

    End Function

    <WebMethod()>
    Public Shared Function Po3(prefix As String) As String()

        Try
            Dim resultado As New List(Of String)()
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""


            Dim Common As New BXP_Common

            If prefix = "*" Then
                Query = "Select TOP 10 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE]  "
            Else
                Query = "Select TOP 10 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE] WHERE U_POL_NAME Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
            End If

            Using sdr As DataSet = Ws.Query1(Query)
                For Each row As DataRow In sdr.Tables(0).Rows
                    resultado.Add(String.Format("{0}", row("U_POL_NAME")))
                Next
            End Using
            Return resultado.ToArray()
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Po2 - " + ex.Message)
            Return Nothing
        End Try

    End Function



#End Region

End Class