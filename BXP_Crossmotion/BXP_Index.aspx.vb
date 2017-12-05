Public Class BXP_Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            Pnl_Background.Visible = False
            Pnl_Message.Visible = False

            Btn_Ok.Focus()
        End If
    End Sub

    Protected Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        Try
            If String.IsNullOrEmpty(Txt_User.Text) Then
                Throw New Exception("Introduzca por favor un usuario")
            End If
            If String.IsNullOrEmpty(Txt_Pass.Text) Then
                Throw New Exception("Introduzca por favor un password")
            End If
            If Existe() = False Then
                Throw New Exception("Usuario y contraseña incorrectos")
            End If

            IngresarSesion()


            WriteCookie("Session", "Session", "True")
            WriteCookie("Usuario", "Usuario", Txt_User.Text)

            WriteCookie("Rol", "Rol", Rol)

            Response.Redirect("BXP_Inicio.aspx")

        Catch ex As Exception
            MessageError("", ex.Message)
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al ingresar - " + ex.Message)
        End Try
    End Sub

    Private Sub IngresarSesion()
        Try

            Dim Ws As New BXP_WebServiceSQL

            Dim QueryUpdate As String = "UPDATE BXP_Polimeros.dbo.BXP_Sesion SET Activa = 'False' WHERE Usuario = '" + Txt_User.Text + "' "

            Ws.Query3(QueryUpdate)

            Dim QueryUltimoId As String = "Select Max(Id) From BXP_Polimeros.dbo.BXP_Sesion "

            Dim UltimoId As Integer = Ws.Query2(QueryUltimoId)

            Dim Query As String = "INSERT INTO BXP_Polimeros.dbo.BXP_Sesion (Id, Sesion, Activa, Usuario) VALUES ('" + CStr(UltimoId + 1) + "', '" + CStr(UltimoId + 1) + "', 'True', '" + Txt_User.Text + "')"

            Ws.Query3(Query)

            WriteCookie("IdS", "IdS", CStr(UltimoId + 1))

            'BXP_Sesion
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error IngresarSesion - " + ex.Message)
        End Try
    End Sub

    Private Function Existe() As Boolean
        Try
            Dim Query As String = "Select count(*) From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + Txt_User.Text + "' and U_clave = '" + Txt_Pass.Text + "' and Active = 'Y' "

            Dim Log As New BXP_Log
            Log.EventLog("Query Existe - " + Query)

            Dim Ws As New BXP_WebServiceSQL

            If Ws.Query2(Query) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al revisar si exitse usuario - " + ex.Message)
            Return False
        End Try
    End Function

    Private Function Rol() As String
        Try
            Dim Query As String = "Select max(U_Rol) From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + Txt_User.Text + "' and U_clave = '" + Txt_Pass.Text + "' and Active = 'Y' "

            Dim Log As New BXP_Log
            Log.EventLog("Query Rol - " + Query)

            Dim Ws As New BXP_WebServiceSQL

            Return Ws.Query2(Query)

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al revisar si exitse usuario - " + ex.Message)
            Return Nothing
        End Try
    End Function

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
            Dim Log As New BXP_Log
            Log.ErrorLog("Error en WriteCookie " + Nombre + " - " + ex.Message)
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
            Dim Log As New BXP_Log
            Log.ErrorLog("Error en ExistCookie " + Nombre + " - " + ex.Message)
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
            Dim Log As New BXP_Log
            Log.ErrorLog("Error en ReadCookie " + Nombre + " - " + ex.Message)
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
            Dim Log As New BXP_Log
            Log.ErrorLog("Error en DeleteCookie " + Nombre + " - " + ex.Message)
            Return False
        End Try
    End Function

#End Region

#Region "Error"

    Private Sub MessageError(ByVal Title As String, ByVal Message As String)
        Lbl_TitleError.Text = Title
        Lbl_MessageError.Text = Message
        Pnl_Background.Visible = True
        Pnl_Message.Visible = True
    End Sub

    Protected Sub Btn_AcceptError_Click(sender As Object, e As EventArgs) Handles Btn_AcceptError.Click
        Lbl_TitleError.Text = ""
        Lbl_MessageError.Text = ""
        Pnl_Background.Visible = False
        Pnl_Message.Visible = False
    End Sub

#End Region

End Class