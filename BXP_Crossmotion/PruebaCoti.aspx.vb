Imports System.Web.Services
Imports System.Configuration
Imports System.Data.SqlClient

Public Class PruebaCoti
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            CalendarDesde.Visible = False
            CalendarAl.Visible = False
            TxtFechaDesde.Text = Now.ToShortDateString
            TxtFechaAl.Text = CDate(Now.ToShortDateString).AddDays(30)

            'CargarServicios()

            PNLGVSerArr.Visible = False
            PNLBTSerArr.Visible = False

            LlenarMoneda()
            LlenarIncoterm()


        End If

    End Sub

    Private Sub LlenarMoneda()
        Dim Ws As New BXP_WebServiceSQL
        Try

            Dim Ds As DataSet = Ws.Query1("Select * From [Prototipo_Desarrollos].[dbo].OCRN order by CurrCode desc")

            DdlCur.DataSource = Ds
            DdlCur.DataTextField = "CurrCode"
            DdlCur.DataBind()

        Catch ex As Exception

        End Try


    End Sub



    Private Sub LlenarIncoterm()
        Dim Ws As New BXP_WebServiceSQL
        Try

            Dim Ds As DataSet = Ws.Query1("Select * From [Prototipo_Desarrollos].[dbo].[@INCOTERM] order by Code desc")

            DdlIncoterm.DataSource = Ds
            DdlIncoterm.DataTextField = "Name"
            DdlIncoterm.DataValueField = "Code"
            DdlIncoterm.DataBind()

            DdlIncoterm.Text = "NA"

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error - " + ex.Message)
        End Try


    End Sub

    Private Sub LlenarTipoServicio()
        Dim Ws As New BXP_WebServiceSQL
        Try

            Dim Ds As DataSet = Ws.Query1("Select Code, Name from Prototipo_Desarrollos.dbo.[@TIPO_SERVICIO] Order By Name")

            DdlServ.DataSource = Ds
            DdlServ.DataTextField = "Name"
            DdlServ.DataValueField = "Code"
            DdlServ.DataBind()

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error - " + ex.Message)
        End Try


    End Sub

    Protected Sub DdlTipoCotizacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlTipoCotizacion.SelectedIndexChanged

        PNLGVSerArr.Visible = False
        PNLBTSerArr.Visible = False

        If DdlTipoCotizacion.SelectedItem.Text = "Aereo" Then

        End If
        If DdlTipoCotizacion.SelectedItem.Text = "Arrastre" Then

            PNLGVSerArr.Visible = True
            PNLBTSerArr.Visible = True

            LblTitulo.Text = "Cotización Arrastre"
            LblAddTitulo.Text = "Agregar servicio de arrastre"

            LblVTipo.Text = "2"

        End If
        If DdlTipoCotizacion.SelectedItem.Text = "Arrastre en BL" Then

        End If
        If DdlTipoCotizacion.SelectedItem.Text = "Intermodal" Then

        End If
        If DdlTipoCotizacion.SelectedItem.Text = "Maritimo" Then

        End If
        If DdlTipoCotizacion.SelectedItem.Text = "Multimodal" Then

        End If

        If DdlTipoCotizacion.SelectedItem.Text = "Terrestre Americano" Then

        End If

        If DdlTipoCotizacion.SelectedItem.Text = "Terrestre Nacional" Then

        End If

    End Sub

    Public Sub CargarServicios()
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select Code, Name From [Prototipo_Desarrollos].[dbo].[@MET_TRANSPORT]"
        Dim servicios As DataSet = Ws.Query1(Query)

        DdlTipoCotizacion.DataSource = servicios
        DdlTipoCotizacion.DataValueField = "Code"
        DdlTipoCotizacion.DataTextField = "Name"
        DdlTipoCotizacion.DataBind()
        DdlTipoCotizacion.Items.Insert(0, "--Seleccione--")
        'DdlTipoCotizacion.Items.Insert(1, "Arrastre")
        'Arrastre
    End Sub

    Protected Sub BtnGuardarCot_Click(sender As Object, e As EventArgs) Handles BtnGuardarCot.Click
        Try

            If String.IsNullOrEmpty(TxtEmpresa.Text) Then

            End If
        Catch ex As Exception

        End Try
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
                'Query = "Select distinct TOP 20 CardName + ' / ' + CardFName CardName From Prototipo_Desarrollos.dbo.OCRD WHERE CardType = 'C' and (validFor = 'Y' OR frozenFor = 'N') "
                Query = "SELECT DISTINCT TOP 20 A.CardName + ' / ' + B.CardFName CardName FROM Prototipo_Desarrollos.dbo.OCRD A INNER JOIN (SELECT CASE WHEN CardFName IS NULL THEN ' ' ELSE CardFName END CardFName, CardCode FROM Prototipo_Desarrollos.dbo.OCRD) B ON A.CardCode = B.CardCode WHERE A.CardType = 'C' and (A.validFor = 'Y' OR A.frozenFor = 'N') "
            Else
                'Query = "Select distinct TOP 20 CardName + ' / ' + CardFName CardName From Prototipo_Desarrollos.dbo.OCRD WHERE CardType = 'C' and (validFor = 'Y' OR frozenFor = 'N') and (CardName Like '%" + prefix + "%' or CardFName Like '%" + prefix + "%') "
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

            'Dim Log As New BXP_Log
            'Log.EventLog("Po2 - " + Query)

            'Query = "Select Pod From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name Like '%" + prefix + "%' or Code Like '%" + prefix + "%'"

            Using sdr As DataSet = Ws.Query1(Query)
                For Each row As DataRow In sdr.Tables(0).Rows
                    resultado.Add(String.Format("{0}", row("Name")))
                Next
            End Using
            Return resultado.ToArray()
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Po - " + ex.Message)
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
                'Query = "Select TOP 10 U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_MAR = 'Y' and U_POL_NAME Like '%" + prefix + "%' or Code Like '%" + prefix + "%' "
                Query = "Select TOP 10 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_POL_NAME Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
            End If


            'Dim Log As New BXP_Log
            'Log.EventLog("Po2 - " + Query)

            'Query = "Select Pod From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name Like '%" + prefix + "%' or Code Like '%" + prefix + "%'"

            Using sdr As DataSet = Ws.Query1(Query)
                For Each row As DataRow In sdr.Tables(0).Rows
                    resultado.Add(String.Format("{0}", row("U_POL_NAME")))
                Next
            End Using
            Return resultado.ToArray()
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Po2 - " + ex.Message)
            Return Nothing
        End Try

    End Function

#End Region

    Protected Sub TxtPOL_TextChanged(sender As Object, e As EventArgs) Handles TxtPOL.TextChanged

        CodigoPol()

        LlenarArrastre()


        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
        'Label1.Text = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text

    End Sub

    Private Sub LlenarArrastre()
        Try
            Dim Query As String = "SELECT TOP 10 * FROM Prototipo_Desarrollos.dbo.BXP_Arrastres WHERE '1'='1' "
            If Not String.IsNullOrEmpty(TxtCodePOL.Text.Trim) And Not TxtCodePOL.Text.Trim = "*" Then
                Query += "and POL_CODE_COUNTRY = '" + TxtCodePOL.Text.Trim + "' "
            End If
            If Not String.IsNullOrEmpty(TxtCodePOD.Text.Trim) And Not TxtCodePOD.Text.Trim = "*" Then
                Query += "and POD_CODE_COUNTRY = '" + TxtCodePOD.Text.Trim + "' "
            End If

            If Not String.IsNullOrEmpty(TextBox11.Text.Trim) And Not TextBox11.Text.Trim = "*" Then
                Query += "and POL_CODE = '" + TextBox11.Text.Trim + "' "
            End If
            If Not String.IsNullOrEmpty(TextBox13.Text.Trim) And Not TextBox13.Text.Trim = "*" Then
                Query += "and POD_CODE = '" + TextBox13.Text.Trim + "' "
            End If

            Dim Log As New BXP_Log
            Log.EventLog("query - " + Query)

            Dim WebSer As New BXP_WebServiceSQL
            GvBusArr.DataSource = WebSer.Query1(Query)
            GvBusArr.DataBind()
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Aereo - " + ex.Message)
        End Try
    End Sub


    Protected Sub TxtEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpresa.TextChanged
        Try
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""
            Dim St As String()

            St = TxtEmpresa.Text.Split("/")
            TxtEmpresa.Text = St(0)

            Query = "Select Max(CardCode) From Prototipo_Desarrollos.dbo.OCRD where CardName = '" + TxtEmpresa.Text + "' "
            Dim CardCode As String = Ws.Query2(Query)

            TxtEmpresaCodigo.Text = CardCode

            Query = "Select Max(CntctPrsn) From Prototipo_Desarrollos.dbo.OCRD where CardName = '" + TxtEmpresa.Text + "' "
            Dim CntctPrsn As String = Ws.Query2(Query)

            TxtContacto.Text = CntctPrsn

            Query = "Select Max(A.Country) From Prototipo_Desarrollos.dbo.CRD1 A inner join Prototipo_Desarrollos.dbo.OCRD B ON A.CardCode = B.CardCode where B.CardName = '" + TxtEmpresa.Text + "' and A.Address = 'Fiscal' "
            Dim Tipo As String = Ws.Query2(Query)
            If Tipo = "MX" Then
                LblInterNacion.Text = "Nacional"
            Else
                LblInterNacion.Text = "Internacional"
            End If

            Query = "Select Max(E_Mail) From Prototipo_Desarrollos.dbo.OCRD where CardName = '" + TxtEmpresa.Text + "' "
            Dim Correo As String = Ws.Query2(Query)

            LblCorreo.Text = Correo

            'Session("Cambios") = "True"
            WriteCookie("Cambios", "Cambios", "True")

            TxtDescripcion.Focus()

        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("TxtNombreCliente_TextChanged - " + ex.Message)
        End Try
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



    Protected Sub TxtPOD_TextChanged(sender As Object, e As EventArgs) Handles TxtPOD.TextChanged

        CodigoPoD()

        LlenarArrastre()

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

        CodigoPol3()

        LlenarArrastre()

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

        CodigoPoD3()

        LlenarArrastre()

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Private Sub CodigoPol()

        Try
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Len As Integer = TxtPOL.Text.Length

            Dim Texto As String = TxtPOL.Text.Substring(5, Len - 5).Trim

            TxtPOL.Text = Texto

            Query = "Select max(Code) From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name = '" + TxtPOL.Text + "' or Code = '" + TxtPOL.Text + "' "

            Dim Log As New BXP_Log
            Log.EventLog("query - " + Query)

            TxtCodePOL.Text = Ws.Query2(Query)

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar CodigoPol - " + ex.Message)
        End Try

    End Sub

    Private Sub CodigoPoD()

        Try
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Len As Integer = TxtPOD.Text.Length

            Dim Texto As String = TxtPOD.Text.Substring(5, Len - 5).Trim

            TxtPOD.Text = Texto


            Query = "Select max(Code) From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name = '" + TxtPOD.Text + "' or Code = '" + TxtPOD.Text + "' "

            Dim Log As New BXP_Log
            Log.EventLog("query - " + Query)

            TxtCodePOD.Text = Ws.Query2(Query)

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar CodigoPoD - " + ex.Message)
        End Try
    End Sub

    Private Sub CodigoPol3()

        Try
            If String.IsNullOrEmpty(TextBox10.Text) Or TextBox10.Text = "*" Then
                TextBox11.Text = ""

            Else
                Dim Ws As New BXP_WebServiceSQL
                Dim Query As String = ""

                Dim Len As Integer = TextBox10.Text.Length

                Dim Texto As String = TextBox10.Text.Substring(8, Len - 8).Trim

                TextBox10.Text = Texto

                Query = "Select max(Code) From Prototipo_Desarrollos.dbo.[@POL_AE] WHERE U_POL_NAME = '" + TextBox10.Text + "' or Code = '" + TextBox10.Text + "' "

                Dim Log As New BXP_Log
                Log.EventLog("query - " + Query)

                TextBox11.Text = Ws.Query2(Query)

            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar CodigoPol2 - " + ex.Message)
        End Try

    End Sub

    Private Sub CodigoPoD3()

        Try
            If String.IsNullOrEmpty(TextBox12.Text) Or TextBox12.Text = "*" Then
                TextBox13.Text = ""
            Else
                Dim Ws As New BXP_WebServiceSQL
                Dim Query As String = ""

                Dim Len As Integer = TextBox12.Text.Length

                Dim Texto As String = TextBox12.Text.Substring(8, Len - 8).Trim

                Dim Codigo As String = TextBox12.Text.Substring(0, 6).Trim

                TextBox12.Text = Texto


                'Query = "Select max(Code) From Prototipo_Desarrollos.dbo.[@POL] WHERE U_MAR = 'Y' and U_POL_NAME Like '%" + TextBox12.Text + "%' or Code Like '%" + TextBox12.Text + "%' "
                'Query = "Select max(Code) From Prototipo_Desarrollos.dbo.[@POL] WHERE U_POL_NAME = '" + TextBox12.Text + "' or Code = '" + TextBox12.Text + "' "
                'Query = "Select max(Code) From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name = '" + TxtPOD.Text + "' or Code = '" + TxtPOD.Text + "' "

                'Dim Log As New BXP_Log
                'Log.EventLog("query - " + Query)

                TextBox13.Text = Codigo
            End If


        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al llenar CodigoPoD2 - " + ex.Message)
        End Try




    End Sub


    Protected Sub BtnAgregarPartida_Click(sender As Object, e As EventArgs) Handles BtnAgregarPartida.Click

        TxtPOD.Text = ""
        TxtPOL.Text = ""

        TxtCodePOD.Text = ""
        TxtCodePOL.Text = ""

        TextBox10.Text = ""
        TextBox11.Text = ""

        TextBox12.Text = ""
        TextBox13.Text = ""

        GvBusArr.DataSource = Nothing
        GvBusArr.DataBind()

        ServicioDetalle()
        Servicio()

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub



    'Protected Sub abrirformulario_Click(sender As Object, e As EventArgs) Handles abrirformulario.Click

    'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

    'End Sub

    Private Sub Servicio()
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select ItemCode, ItemName From [Prototipo_Desarrollos].[dbo].[OITM] Where U_TIPO_SERVICIO = '" + DdlTipoCotizacion.SelectedItem.Value + "' "
        Dim servicios As DataSet = Ws.Query1(Query)

        'Dim Log As New BXP_Log
        'Log.EventLog("Servicio - " + Query)

        DdlServicio.DataSource = servicios
        DdlServicio.DataValueField = "ItemCode"
        DdlServicio.DataTextField = "ItemName"
        DdlServicio.DataBind()
        DdlServicio.Items.Insert(0, "--Seleccione--")
    End Sub

    Private Sub ServicioDetalle()

        Try
            Dim Ws As New BXP_WebServiceSQL
            'Dim Query As String = "Select Code From [Prototipo_Desarrollos].[dbo].[@TRANSPORTE_DETAIL] Where [U_MET_TRANSPOR] = '" + DdlTipoCotizacion.SelectedItem.Value + "' "
            Dim Query As String = "Select Code From [Prototipo_Desarrollos].[dbo].[@TRANSPORTE_DETAIL] Where "

            If DdlTipoCotizacion.SelectedItem.Value = "AER" Then
                Query += "U_AER = 'Y' "
            End If
            If DdlTipoCotizacion.SelectedItem.Value = "ARR" Then
                Query += "U_ARR = 'Y' "
            End If
            If DdlTipoCotizacion.SelectedItem.Value = "ARR_BL" Then
                Query += "U_ARR = 'Y' "
            End If
            If DdlTipoCotizacion.SelectedItem.Value = "MAR" Then
                Query += "U_MAR = 'Y' "
            End If
            If DdlTipoCotizacion.SelectedItem.Value = "TER" Then
                Query += "U_TER = 'Y' "
            End If

            Dim servicios As DataSet = Ws.Query1(Query)

            'Dim Log As New BXP_Log
            'Log.EventLog("ServicioDetalle - " + Query)

            DdlServiceDetails.DataSource = servicios
            DdlServiceDetails.DataValueField = "Code"
            DdlServiceDetails.DataTextField = "Code"
            DdlServiceDetails.DataBind()
            DdlServiceDetails.Items.Insert(0, "--Seleccione--")
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("ServicioDetalle - " + ex.Message)
        End Try
    End Sub

    Protected Sub DdlServiceDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlServiceDetails.SelectedIndexChanged
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub DdlServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlServicio.SelectedIndexChanged
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

End Class