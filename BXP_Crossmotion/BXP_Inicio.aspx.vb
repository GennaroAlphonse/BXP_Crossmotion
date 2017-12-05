Public Class BXP_Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If ExistCookie("Session") = True Then
                If ReadCookie("Session", "Session") = "True" Then

                Else
                    Response.Redirect("BXP_Index.aspx")
                End If
            Else
                Response.Redirect("BXP_Index.aspx")
            End If
        End If
    End Sub

#Region "Common"

    Public Function WriteCookie(ByVal Nombre As String, _
                                ByVal sTipo As String, ByVal sValor As String _
                                ) As Boolean
        Try
            Dim myCookie As HttpCookie = New HttpCookie(Nombre)
            myCookie(sTipo) = sValor
            'myCookie.Expires = Now.AddMinutes(30)
            myCookie.Expires = Now.AddHours(1)
            Response.Cookies.Add(myCookie)
            Return True
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error en WriteCookie " + Nombre + " - " + ex.Message)
            Return False
        End Try
    End Function

    Public Function ExistCookie(ByVal Nombre As String) As Boolean
        Try
            If (Request.Cookies(Nombre) IsNot Nothing) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error en ExistCookie " + Nombre + " - " + ex.Message)
            Return False
        End Try
    End Function

    Public Function ReadCookie(ByVal Nombre As String, ByVal Tipo As String) As String
        Dim Res As String = Nothing
        Try
            If (Request.Cookies(Nombre)(Tipo) IsNot Nothing) Then
                Res = Request.Cookies(Nombre)(Tipo)
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error en ReadCookie " + Nombre + " - " + ex.Message)
        End Try
        Return Res
    End Function

    Public Function DeleteCookie(ByVal Nombre As String) As Boolean
        Try
            If (Not Request.Cookies(Nombre) Is Nothing) Then
                Dim myCookie As HttpCookie = New HttpCookie(Nombre)
                myCookie.Expires = DateTime.Now.AddDays(-5)
                Response.Cookies.Add(myCookie)
            End If
            Return True
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error en DeleteCookie " + Nombre + " - " + ex.Message)
            Return False
        End Try
    End Function

#End Region

End Class