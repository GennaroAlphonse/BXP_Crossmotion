Public Class BXP_MasterPage2
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If SesionActiva() = True Then

        Else
            Response.Redirect("BXP_Index.aspx")
        End If

        If Not Page.IsPostBack Then
            Pnl_Background.Visible = False
            Pnl_Message.Visible = False

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

    Public Function WriteCookie(ByVal Nombre As String,
                                ByVal sTipo As String, ByVal sValor As String
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

    Protected Sub Btn_Inicio_Click(sender As Object, e As EventArgs) Handles Btn_Inicio.Click
        Try
            If ExistCookie("Cambios") Then
                If ReadCookie("Cambios", "Cambios") = "True" Then
                    MessageError("", "Ya se ingresó información a la cotización desea:")
                Else
                    DeleteCookie("Cambios")
                    Response.Redirect("BXP_Inicio.aspx")
                End If
            Else
                Session("Cambios") = Nothing
                Response.Redirect("BXP_Inicio.aspx")
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al cambiar a inicio" + ex.Message)
        End Try



    End Sub

    Protected Sub Btn_Cotizacion_Click(sender As Object, e As EventArgs) Handles Btn_Cotizacion.Click

        Try
            If ExistCookie("Cambios") Then
                If ReadCookie("Cambios", "Cambios") = "True" Then
                    MessageError("", "Ya se ingresó información a la cotización desea:")
                Else
                    DeleteCookie("Cambios")
                    Response.Redirect("BXP_Cotizacion.aspx")
                End If
            Else
                Session("Cambios") = Nothing
                Response.Redirect("BXP_Cotizacion.aspx")
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al cambiar a inicio" + ex.Message)
        End Try


        'Response.Redirect("BXP_Cotizacion.aspx")
    End Sub

    Protected Sub Btn_Delivery_Click(sender As Object, e As EventArgs) Handles Btn_Delivery.Click

        Try
            If ExistCookie("Cambios") Then
                If ReadCookie("Cambios", "Cambios") = "True" Then
                    MessageError("", "Ya se ingresó información a la cotización desea:")
                Else
                    DeleteCookie("Cambios")
                    Response.Redirect("BXP_Delivery.aspx")
                End If
            Else
                Session("Cambios") = Nothing
                Response.Redirect("BXP_Delivery.aspx")
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al cambiar a inicio" + ex.Message)
        End Try

        'Response.Redirect("BXP_Delivery.aspx")
    End Sub

    Protected Sub BtnResumen_Click(sender As Object, e As EventArgs) Handles BtnResumen.Click

        Try
            If ExistCookie("Cambios") Then
                If ReadCookie("Cambios", "Cambios") = "True" Then
                    MessageError("", "Ya se ingresó información a la cotización desea:")
                Else
                    DeleteCookie("Cambios")
                    Response.Redirect("BXP_Resumen.aspx")
                End If
            Else
                Session("Cambios") = Nothing
                Response.Redirect("BXP_Resumen.aspx")
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al cambiar a inicio" + ex.Message)
        End Try

        'Response.Redirect("BXP_Resumen.aspx")
    End Sub

    Protected Sub Btn_ExpedientesHistoricos_Click(sender As Object, e As EventArgs) Handles Btn_ExpedientesHistoricos.Click

        Try
            If ExistCookie("Cambios") Then
                If ReadCookie("Cambios", "Cambios") = "True" Then
                    MessageError("", "Ya se ingresó información a la cotización desea:")
                Else
                    DeleteCookie("Cambios")
                    Response.Redirect("BXP_ExpedientesHistoricos.aspx")
                End If
            Else
                Session("Cambios") = Nothing
                Response.Redirect("BXP_ExpedientesHistoricos.aspx")
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al cambiar a inicio" + ex.Message)
        End Try

        'Response.Redirect("BXP_ExpedientesHistoricos.aspx")
    End Sub

    Protected Sub Btn_Tracking_Click(sender As Object, e As EventArgs) Handles Btn_Tracking.Click

        Try
            If ExistCookie("Cambios") Then
                If ReadCookie("Cambios", "Cambios") = "True" Then
                    MessageError("", "Ya se ingresó información a la cotización desea:")
                Else
                    DeleteCookie("Cambios")
                    Response.Redirect("BXP_Tracking.aspx")
                End If
            Else
                Session("Cambios") = Nothing
                Response.Redirect("BXP_Tracking.aspx")
            End If
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al cambiar a inicio" + ex.Message)
        End Try

        'Response.Redirect("BXP_Tracking.aspx")
    End Sub

    Protected Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        If ExistCookie("Session") = True Then
            DeleteCookie("Session")
            DeleteCookie("Cambios")
        End If

        IngresarSesion()

        Response.Redirect("BXP_Index.aspx")

    End Sub

    Private Sub IngresarSesion()
        Try

            Dim Ws As New BXP_WebServiceSQL

            Dim QueryUpdate As String = "UPDATE BXP_Polimeros.dbo.BXP_Sesion SET Activa = 'False' WHERE Usuario = '" + ReadCookie("Usuario", "Usuario") + "' "

            Ws.Query3(QueryUpdate)

        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error IngresarSesion - " + ex.Message)
        End Try
    End Sub

    Private Function SesionActiva() As Boolean
        Try

            Dim Ws As New BXP_WebServiceSQL

            Dim Query As String = "SELECT count(*) From BXP_Polimeros.dbo.BXP_Sesion WHERE Usuario = '" + ReadCookie("Usuario", "Usuario") + "' and Id = '" + ReadCookie("IdS", "IdS") + "' and Activa = 'True' "

            'Dim Log As New BXP_Log
            'Log.EventLog("SesionActiva - " + Query)

            Dim Sesion As Integer = Ws.Query2(Query)

            If Sesion > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error IngresarSesion - " + ex.Message)
            Return False
        End Try
    End Function


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("BXP_Autorizacion.aspx")
    End Sub

#Region "Error"

    Private Sub MessageError(ByVal Title As String, ByVal Message As String)
        Lbl_TitleError.Text = Title
        Lbl_MessageError.Text = Message
        Pnl_Background.Visible = True
        Pnl_Message.Visible = True
    End Sub

    Protected Sub Btn_AcceptError_Click(sender As Object, e As EventArgs) Handles Btn_AcceptError.Click

        'Response.Redirect("BXP_Cotizacion.aspx")
        Lbl_TitleError.Text = ""
        Lbl_MessageError.Text = ""
        Pnl_Background.Visible = False
        Pnl_Message.Visible = False

    End Sub


#End Region


    Protected Sub BtnNo__Click(sender As Object, e As EventArgs) Handles BtnNo_.Click
        DeleteCookie("Cambios")
        Response.Redirect("BXP_Inicio.aspx")
    End Sub
End Class