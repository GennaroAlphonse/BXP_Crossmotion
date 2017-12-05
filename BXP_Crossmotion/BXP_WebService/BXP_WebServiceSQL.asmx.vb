Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class BXP_WebServiceSQL
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function Query1(ByVal Query As String) As DataSet
        Dim oQuery As New BXP_ConnectionSQL
        Return oQuery.Query1(Query)
    End Function

    <WebMethod()> _
    Public Function Query2(ByVal Query As String) As String
        Dim oQuery As New BXP_ConnectionSQL
        Return oQuery.Query2(Query)
    End Function

    <WebMethod()> _
    Public Function Query3(ByVal Query As String) As Boolean
        Dim oQuery As New BXP_ConnectionSQL
        Return oQuery.Query3(Query)
    End Function

End Class