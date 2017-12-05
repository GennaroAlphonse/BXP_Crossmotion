Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Imports System.Web.Services
Imports System.Configuration
Imports System.Data.SqlClient

Imports System.IO
Imports OfficeOpenXml
Imports System.Drawing

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.JsonToken
Imports Newtonsoft.Json.JsonSerializer


Public Class BXP_Cotizacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not Page.IsPostBack Then

            CalendarDesde.Visible = False
            CalendarAl.Visible = False
            TxtFechaDesde.Text = Now.ToShortDateString
            TxtFechaAl.Text = CDate(Now.ToShortDateString).AddDays(30)

            GetDdlService()
            GetDdlCurrency()
            GetDdlIncoterm()
            GetDdlTypeService()

            PNLGVSerAer.Visible = False
            PNLGVSerArB.Visible = False
            PNLGVSerArr.Visible = False
            PNLGVSerMar.Visible = False
            PNLGVSerMarLCL.Visible = False
            PNLGVSerInt.Visible = False
            PNLGVSerLTL.Visible = False
            PNLGVSerTLM.Visible = False
            PNLGVSerTLU.Visible = False

            PNLBT.Visible = False

            DivAlertInfo.Visible = False
            DivAlertSuccess.Visible = False
            DivAlertWarning.Visible = False

            DivCargos.Visible = False
            DivCargosOrigen.Visible = False
            DivCargosDestino.Visible = False

            LblCarO.Text = ""
            LblCarD.Text = ""

        End If

        If GVSerAer.Rows.Count > 0 Then
            DdlTipoCotizacion.Enabled = False
            GetFolioCross()
        End If

        If GVSerArr.Rows.Count > 0 Then
            DdlTipoCotizacion.Enabled = False
            GetFolioCross()
        End If

        'If GVSerArB.Rows.Count > 0 Then
        'DdlTipoCotizacion.Enabled = False
        'End If

        'If GVSerInt.Rows.Count > 0 Then
        'DdlTipoCotizacion.Enabled = False
        'End If

        If GVSerMar.Rows.Count > 0 Then
            DdlTipoCotizacion.Enabled = False
            GetFolioCross()
        End If

        'If GVSerMul.Rows.Count > 0 Then
        'DdlTipoCotizacion.Enabled = False
        'End If

        'If GVSerTer.Rows.Count > 0 Then
        'DdlTipoCotizacion.Enabled = False
        'End If

        LblTipo.Text = GetImpoExpo()

    End Sub


    Protected Sub DdlTipoCotizacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlTipoCotizacion.SelectedIndexChanged

        PNLGVSerAer.Visible = False
        PNLGVSerArB.Visible = False
        PNLGVSerArr.Visible = False
        PNLGVSerMar.Visible = False
        PNLGVSerMarLCL.Visible = False

        PNLBT.Visible = False



        If DdlTipoCotizacion.SelectedItem.Value = "AIR" Then

                PNLGVSerAer.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "1"

                LblTitulo.Text = "Cotización AIR"
                LblAddTitulo.Text = "Agregar servicio de AIR"

                DivCargos.Visible = True
                DivCargosOrigen.Visible = True
                DivCargosDestino.Visible = True

                LblCarO.Text = "Cargos en origen"
                LblCarD.Text = "Cargos en destino"

            End If
            If DdlTipoCotizacion.SelectedItem.Value = "CH" Then

                PNLGVSerArr.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "2"

                LblTitulo.Text = "Cotización CONTAINER HAULAGE"
                LblAddTitulo.Text = "Agregar servicio de CONTAINER HAULAGE"

                DivCargos.Visible = True
                DivCargosOrigen.Visible = True
                DivCargosDestino.Visible = False

                LblCarO.Text = "Otros cargos"
                LblCarD.Text = ""

            End If
            If DdlTipoCotizacion.SelectedItem.Value = "CC" Then

                PNLGVSerArr.Visible = True
                PNLGVSerArB.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "3"

                LblTitulo.Text = "Cotización Arrastre en BL"
                LblAddTitulo.Text = "Agregar servicio de arrastre en BL"

                DivCargos.Visible = True
                DivCargosOrigen.Visible = True
                DivCargosDestino.Visible = False

                LblCarO.Text = "Otros cargos"
                LblCarD.Text = ""

            End If
            If DdlTipoCotizacion.SelectedItem.Value = "INTERMODAL" Then

                'PNLGVSerArr.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "4"

                LblTitulo.Text = "Cotización Intermodal"
                LblAddTitulo.Text = "Agregar servicio de Intermodal"

                DivCargos.Visible = True
                DivCargosOrigen.Visible = True
                DivCargosDestino.Visible = True

                LblCarO.Text = "Cargos en origen"
                LblCarD.Text = "Cargos en destino"

            End If
            If DdlTipoCotizacion.SelectedItem.Value = "FCL" Then

                PNLGVSerMar.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "5"

                LblTitulo.Text = "Cotización FULL CONTAINER LOAD"
                LblAddTitulo.Text = "Agregar servicio de FULL CONTAINER LOAD"

                DivCargos.Visible = True
                DivCargosOrigen.Visible = True
                DivCargosDestino.Visible = True

                LblCarO.Text = "Cargos en origen"
                LblCarD.Text = "Cargos en destino"

            End If
            If DdlTipoCotizacion.SelectedItem.Value = "Multimodal" Then

                'PNLGVSerArr.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "6"

                LblTitulo.Text = "Cotización Multimodal"
                LblAddTitulo.Text = "Agregar servicio de Multimodal"

            End If
            If DdlTipoCotizacion.SelectedItem.Value = "TLU" Then

                'PNLGVSerArr.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "7"

                LblTitulo.Text = "Cotización TRUCK LOAD USA"
                LblAddTitulo.Text = "Agregar servicio de TRUCK LOAD USA"

            End If
            If DdlTipoCotizacion.SelectedItem.Value = "TLM" Then

                'PNLGVSerArr.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "8"

                LblTitulo.Text = "Cotización TRUCK LOAD MEXICO"
                LblAddTitulo.Text = "Agregar servicio de TRUCK LOAD MEXICO"

            End If

            If DdlTipoCotizacion.SelectedItem.Value = "LCL" Then

                PNLGVSerMarLCL.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "9"

                LblTitulo.Text = "Cotización LESS CONTAINER LOAD"
                LblAddTitulo.Text = "Agregar servicio de LESS CONTAINER LOAD"

            End If

            If DdlTipoCotizacion.SelectedItem.Value = "LTL" Then

                'PNLGVSerArr.Visible = True
                PNLBT.Visible = True

                LblVTipo.Text = "10"

                LblTitulo.Text = "Cotización LESS TRUCK LOAD"
                LblAddTitulo.Text = "Agregar servicio de LESS TRUCK LOAD"

            End If



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
                Query = "Select distinct TOP 15 Code + ' / ' + Name Name From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] "
            Else
                Query = "Select distinct TOP 15 Code + ' / ' + Name Name From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
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
    Public Shared Function Po2(prefix As String, paisbusqueda As String) As String()

        Try
            Dim resultado As New List(Of String)()
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""


            Dim Common As New BXP_Common

            If prefix = "*" Then
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL]  "
            ElseIf Not String.IsNullOrEmpty(paisbusqueda) Then
                Query = "Select TOP 15 C.CODE + ' / ' + C.U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND ((P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.U_POL_NAME Like '%" + Common.Sanea(prefix) + "%') OR (P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.Code Like '%" + Common.Sanea(prefix) + "%') )"
            Else
                'Query = "Select TOP 10 U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_MAR = 'Y' and U_POL_NAME Like '%" + prefix + "%' or Code Like '%" + prefix + "%' "
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_POL_NAME Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
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

    <WebMethod()>
    Public Shared Function Po3(prefix As String, paisbusqueda As String) As String()

        Try
            Dim resultado As New List(Of String)()
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Common As New BXP_Common

            If prefix = "*" Then
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE]  "
            ElseIf Not String.IsNullOrEmpty(paisbusqueda) Then
                Query = "Select TOP 15 C.CODE + ' / ' + C.U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND ((P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.U_POL_NAME Like '%" + Common.Sanea(prefix) + "%') OR (P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.Code Like '%" + Common.Sanea(prefix) + "%') )"
            Else
                'Query = "Select TOP 10 U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_MAR = 'Y' and U_POL_NAME Like '%" + prefix + "%' or Code Like '%" + prefix + "%' "
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE] WHERE U_POL_NAME Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
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


    <WebMethod()>
    Public Shared Function Po4(prefix As String, paisbusqueda As String, tipobusqueda As String) As String()

        Try
            Dim resultado As New List(Of String)()
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Common As New BXP_Common

            If prefix = "*" And tipobusqueda = "AIR" Then
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE]  "
            ElseIf Not String.IsNullOrEmpty(paisbusqueda) And tipobusqueda = "AIR" Then
                Query = "Select TOP 15 C.CODE + ' / ' + C.U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND ((P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.U_POL_NAME Like '%" + Common.Sanea(prefix) + "%') OR (P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.Code Like '%" + Common.Sanea(prefix) + "%') )"
            ElseIf tipobusqueda = "AIR" Then
                'Query = "Select TOP 10 U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_MAR = 'Y' and U_POL_NAME Like '%" + prefix + "%' or Code Like '%" + prefix + "%' "
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL_AE] WHERE U_POL_NAME Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
            ElseIf prefix = "*" Then
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL]  "
            ElseIf Not String.IsNullOrEmpty(paisbusqueda) Then
                Query = "Select TOP 15 C.CODE + ' / ' + C.U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND ((P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.U_POL_NAME Like '%" + Common.Sanea(prefix) + "%') OR (P.Code='" + Common.Sanea(paisbusqueda) + "' AND C.Code Like '%" + Common.Sanea(prefix) + "%') )"
            Else
                'Query = "Select TOP 10 U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_MAR = 'Y' and U_POL_NAME Like '%" + prefix + "%' or Code Like '%" + prefix + "%' "
                Query = "Select TOP 15 CODE + ' / ' + U_POL_NAME U_POL_NAME From Prototipo_Desarrollos.dbo.[@POL] WHERE U_POL_NAME Like '%" + Common.Sanea(prefix) + "%' or Code Like '%" + Common.Sanea(prefix) + "%' "
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
            Dim Log As New BXP_Log
            Log.ErrorLog("TxtNombreCliente_TextChanged - " + ex.Message)
        End Try
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

    Protected Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

        If String.IsNullOrEmpty(TextBox10.Text) Or TextBox10.Text = "*" Then
            TextBox11.Text = ""
        End If

        CodigoPol3()

        GetService()

        Dim Codigo As String = TextBox11.Text

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)

        Try
            Dim Ws As New BXP_WebServiceSQL

            Dim Query As String = ""

            If DdlTipoCotizacion.SelectedItem.Value = "AIR" Then
                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "
            Else
                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

            End If

            Using sdr As DataSet = Ws.Query1(Query)

                For Each row As DataRow In sdr.Tables(0).Rows
                    TxtPOL_Country.Text = row("Name").ToString
                    TxtCodePOL_Country.Value = row("U_POL_CODE_COUNTRY").ToString
                Next
            End Using

        Catch ex As Exception
            'Dim Log As New BXP_Log

        End Try

        TxtPOD_Country.Focus()
    End Sub

    Protected Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

        If String.IsNullOrEmpty(TextBox12.Text) Or TextBox12.Text = "*" Then
            TextBox13.Text = ""
        End If

        CodigoPoD3()

        GetService()

        Dim Codigo As String = TextBox13.Text

        Try
            Dim Ws As New BXP_WebServiceSQL

            Dim Query As String = ""

            If DdlTipoCotizacion.SelectedItem.Value = "AIR" Then
                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "
            Else
                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

            End If

            Using sdr As DataSet = Ws.Query1(Query)

                For Each row As DataRow In sdr.Tables(0).Rows
                    TxtPOD_Country.Text = row("Name").ToString
                    TxtCodePOD_Country.Value = row("U_POL_CODE_COUNTRY").ToString
                Next
            End Using

        Catch ex As Exception
            'Dim Log As New BXP_Log

        End Try

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Private Sub CodigoPol()

        Try
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Len As Integer = TxtPOL_Country.Text.Length

            Dim Texto As String = TxtPOL_Country.Text.Substring(5, Len - 5).Trim

            TxtPOL_Country.Text = Texto

            Query = "Select max(Code) From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name = '" + TxtPOL_Country.Text + "' or Code = '" + TxtPOL_Country.Text + "' "

            Dim Log As New BXP_Log
            Log.EventLog("query - " + Query)

            TxtCodePOL_Country.Value = Ws.Query2(Query)

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar CodigoPol - " + ex.Message)
        End Try

    End Sub

    Private Sub CodigoPoD()

        Try
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""

            Dim Len As Integer = TxtPOD_Country.Text.Length

            Dim Texto As String = TxtPOD_Country.Text.Substring(5, Len - 5).Trim

            TxtPOD_Country.Text = Texto


            Query = "Select max(Code) From [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] where Name = '" + TxtPOD_Country.Text + "' or Code = '" + TxtPOD_Country.Text + "' "

            Dim Log As New BXP_Log
            Log.EventLog("query - " + Query)

            TxtCodePOD_Country.Value = Ws.Query2(Query)

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

        TxtPOD_Country.Text = ""
        TxtPOL_Country.Text = ""

        TxtCodePOD_Country.Value = ""
        TxtCodePOL_Country.Value = ""

        TextBox10.Text = ""
        TextBox11.Text = ""

        TextBox12.Text = ""
        TextBox13.Text = ""

        GvBusAer.DataSource = Nothing
        GvBusAer.DataBind()

        GvBusArr.DataSource = Nothing
        GvBusArr.DataBind()

        GvBusArB.DataSource = Nothing
        GvBusArB.DataBind()

        GvBusInt.DataSource = Nothing
        GvBusInt.DataBind()

        GvBusMar.DataSource = Nothing
        GvBusMar.DataBind()

        GvBusMarLCL.DataSource = Nothing
        GvBusMarLCL.DataBind()

        GvBusMul.DataSource = Nothing
        GvBusMul.DataBind()

        GvBusTer.DataSource = Nothing
        GvBusTer.DataBind()

        GvBusTerA.DataSource = Nothing
        GvBusTerA.DataBind()

        GvBusLTL.DataSource = Nothing
        GvBusLTL.DataBind()

        'ServicioDetalle()
        'Servicio()

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)

        LblAddBan.Text = "1"

    End Sub

    Private Sub Servicio()
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select ItemCode, ItemName From [Prototipo_Desarrollos].[dbo].[OITM] Where U_TIPO_SERVICIO = '" + DdlTipoCotizacion.SelectedItem.Value + "' "
        Dim servicios As DataSet = Ws.Query1(Query)

        'Dim Log As New BXP_Log
        'Log.EventLog("Servicio - " + Query)

        DdlServicio.DataSource = Nothing

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

            DdlServiceDetails.DataSource = Nothing

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
        'TextBox10.Focus()
    End Sub

    Protected Sub DdlServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlServicio.SelectedIndexChanged
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
        'TxtPOL.Focus()
    End Sub


#Region "Add Servicios"

    Private Sub AddAereo()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select MIN * 1.15 As Precio, * From [Prototipo_Desarrollos].[dbo].BXP_Aereo WHERE id_num in ("



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusAer.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusAer.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusAer.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusAer.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GVSerAer.DataSource = Ws.Query1(Query)
        GVSerAer.DataBind()
    End Sub

    Private Sub AddArrastre()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select TOTAL_RATE_SIN * 1.15 As Precio1, TOTAL_RATE_TAN * 1.15 As Precio2, SINGLE * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_Arrastres WHERE id_num in ("



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusArr.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusArr.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusArr.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusArr.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusArr.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusArr.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GVSerArr.DataSource = Ws.Query1(Query)
        GVSerArr.DataBind()
    End Sub

    Private Sub AddArrastreBL()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select [20GP] * 1.15 As Precio1, [40GP] * 1.15 As Precio2, [40HQ] * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_ArrastresBL WHERE id_num in ("



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusArB.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusArB.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusArB.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusArB.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusArB.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusArB.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GVSerArB.DataSource = Ws.Query1(Query)
        GVSerArB.DataBind()
    End Sub

    Private Sub AddMaritimo()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select [20GP] * 1.15 As Precio1, [40GP] * 1.15 As Precio2, [40HQ] * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_Maritimo WHERE id_num in ( "



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusMar.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusMar.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusMar.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusMar.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusMar.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusMar.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GVSerMar.DataSource = Ws.Query1(Query)
        GVSerMar.DataBind()
    End Sub

    Private Sub AddLCL()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select * From [Prototipo_Desarrollos].[dbo].BXP_MaritimoLCL WHERE id_num in ( "



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusMarLCL.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusMarLCL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusMarLCL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusMarLCL.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusMarLCL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusMarLCL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GVSerMarLCL.DataSource = Ws.Query1(Query)
        GVSerMarLCL.DataBind()
    End Sub

#End Region






    Private Sub AddIntermodal()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select * From [Prototipo_Desarrollos].[dbo].BXP_LTL_INTER WHERE id_num in ("



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GVSerInt.DataSource = Ws.Query1(Query)
        GVSerInt.DataBind()
    End Sub



    Private Sub AddLTL()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select TOTAL_RATE_SIN * 1.15 As Precio1, TOTAL_RATE_TAN * 1.15 As Precio2, SINGLE * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_LTL_AM_NA WHERE id_num in ("



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GVSerLTL.DataSource = Ws.Query1(Query)
        GVSerLTL.DataBind()
    End Sub

    Private Sub AddTLM()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select * From [Prototipo_Desarrollos].[dbo].BXP_Terrestre WHERE id_num in ("



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GvBusTer.DataSource = Ws.Query1(Query)
        GvBusTer.DataBind()
    End Sub

    Private Sub AddTLU()
        Dim Ds As DataTable = Nothing
        Dim Cont As Integer = 0
        Dim BanA As Boolean = False
        Dim Ws As New BXP_WebServiceSQL
        Dim Query As String = "Select * From [Prototipo_Desarrollos].[dbo].BXP_TerrAmericano WHERE id_num in ("



        If String.IsNullOrEmpty(LblId.Text) Then
        Else
            Query += "" + LblId.Text + ", "
            LblId.Text += ", "
        End If


        For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
            Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
            Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
            If Revisar = True Then
                BanA = True
            End If
        Next
        If BanA = True Then
            For contador As Integer = 0 To GvBusInt.Rows.Count - 1 Step contador + 1
                Dim Id As String = CType(GvBusInt.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                Dim Revisar As Boolean = CType(GvBusInt.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    If Cont = 0 Then
                        LblId.Text += "'"
                        Query += "'"
                    Else
                        Query += "', '"
                        LblId.Text += "', '"
                    End If
                    Cont += 1
                    Query += Id
                    LblId.Text += Id
                End If
            Next
            Query += "' "
            LblId.Text += "' "
        End If
        Query += ") "
        GvBusTerA.DataSource = Ws.Query1(Query)
        GvBusTerA.DataBind()
    End Sub









    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If LblAddBan.Text = "1" Then
            If LblVTipo.Text = "1" Then
                AddAereo()                          'Listo              'Air
            ElseIf LblVTipo.Text = "2" Then
                AddArrastre()                       'Listo              'CH
            ElseIf LblVTipo.Text = "3" Then
                AddArrastreBL()                     'Listo              'CC
            ElseIf LblVTipo.Text = "4" Then
                AddIntermodal()                     'Pendiente          'Intermodal
            ElseIf LblVTipo.Text = "5" Then
                AddMaritimo()                       'Listo              'FCL
            ElseIf LblVTipo.Text = "6" Then

            ElseIf LblVTipo.Text = "7" Then
                AddTLU()
            ElseIf LblVTipo.Text = "8" Then
                AddTLM()
            ElseIf LblVTipo.Text = "9" Then
                AddLCL()
            ElseIf LblVTipo.Text = "10" Then
                AddLTL()
            End If

        Else
            If LblVTipoS.Text = "1" Then
                AddAereo()                          'Listo              'Air
            ElseIf LblVTipoS.Text = "2" Then
                AddArrastre()                       'Listo              'CH
            ElseIf LblVTipoS.Text = "3" Then
                AddArrastreBL()                     'Listo              'CC
            ElseIf LblVTipoS.Text = "4" Then
                AddIntermodal()                     'Pendiente          'Intermodal
            ElseIf LblVTipoS.Text = "5" Then
                AddMaritimo()                       'Listo              'FCL
            ElseIf LblVTipoS.Text = "6" Then

            ElseIf LblVTipoS.Text = "7" Then
                AddTLU()
            ElseIf LblVTipoS.Text = "8" Then
                AddTLM()
            ElseIf LblVTipoS.Text = "9" Then
                AddLCL()
            ElseIf LblVTipoS.Text = "10" Then
                AddLTL()
            End If

        End If



    End Sub

    Protected Sub BtnEliminarTodo_Click(sender As Object, e As EventArgs) Handles BtnEliminarTodo.Click
        Try
            GVSerArr.DataSource = Nothing
            GVSerArr.DataBind()

            GVSerMar.DataSource = Nothing
            GVSerMar.DataBind()

            GVSerAer.DataSource = Nothing
            GVSerAer.DataBind()
            LblId.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub BtnEliminarPartida_Click(sender As Object, e As EventArgs) Handles BtnEliminarPartida.Click
        Try
            If LblVTipo.Text = "1" Then
                Dim Ds As DataTable = Nothing

                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = "Select MIN * 1.15 As Precio, * From [Prototipo_Desarrollos].[dbo].BXP_Aereo WHERE id_num in ('"
                'Dim Query As String = "Select MIN * 1.15 As Precio, * From [Prototipo_Desarrollos].[dbo].BXP_Aereo WHERE id_num in ("
                Dim Cont As Integer = 0

                LblId.Text = "'"

                For contador As Integer = 0 To GVSerAer.Rows.Count - 1 Step contador + 1
                    Dim Id As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Dim Revisar As Boolean = CType(GVSerAer.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    If Revisar = False Then
                        If Cont = 0 Then
                            LblId.Text += ""
                        Else
                            Query += "', '"
                            LblId.Text += "', '"
                        End If
                        Cont += 1
                        Query += Id
                        LblId.Text += Id
                    End If

                Next
                LblId.Text += "' "
                Query += "') "

                Dim Dt As DataTable = Ws.Query1(Query).Tables(0)

                GVSerAer.DataSource = Dt
                GVSerAer.DataBind()


            ElseIf LblVTipo.Text = "2" Then
                Dim Ds As DataTable = Nothing

                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = "Select TOTAL_RATE_SIN * 1.15 As Precio1, TOTAL_RATE_TAN * 1.15 As Precio2, SINGLE * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_Arrastres WHERE id_num in ('"

                Dim Cont As Integer = 0

                LblId.Text = "'"

                For contador As Integer = 0 To GVSerArr.Rows.Count - 1 Step contador + 1
                    Dim Id As String = CType(GVSerArr.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Dim Revisar As Boolean = CType(GVSerArr.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    If Revisar = False Then
                        If Cont = 0 Then
                            LblId.Text += ""
                        Else
                            Query += "', '"
                            LblId.Text += "', '"
                        End If
                        Cont += 1
                        Query += Id
                        LblId.Text += Id
                    End If

                Next
                LblId.Text += "' "
                Query += "') "

                GVSerArr.DataSource = Ws.Query1(Query)
                GVSerArr.DataBind()

            ElseIf LblVTipo.Text = "3" Then
                Dim Ds As DataTable = Nothing

                Dim Ws As New BXP_WebServiceSQL

                'Dim Query As String = "Select TOTAL_RATE_SIN * 1.15 As Precio1, TOTAL_RATE_TAN * 1.15 As Precio2, SINGLE * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_Arrastres WHERE id_num in ('"
                Dim Query As String = "Select [20GP] * 1.15 As Precio1, [40GP] * 1.15 As Precio2, [40HQ] * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_ArrastresBL WHERE id_num in ('"

                Dim Cont As Integer = 0

                LblId.Text = "'"

                For contador As Integer = 0 To GVSerArB.Rows.Count - 1 Step contador + 1
                    Dim Id As String = CType(GVSerArB.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Dim Revisar As Boolean = CType(GVSerArB.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    If Revisar = False Then
                        If Cont = 0 Then
                            LblId.Text += ""
                        Else
                            Query += "', '"
                            LblId.Text += "', '"
                        End If
                        Cont += 1
                        Query += Id
                        LblId.Text += Id
                    End If

                Next
                LblId.Text += "' "
                Query += "') "

                GVSerArB.DataSource = Ws.Query1(Query)
                GVSerArB.DataBind()

            ElseIf LblVTipo.Text = "5" Then

                Dim Ds As DataTable = Nothing

                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = "Select [20GP] * 1.15 As Precio1, [40GP] * 1.15 As Precio2, [40HQ] * 1.15 As Precio3, * From [Prototipo_Desarrollos].[dbo].BXP_Maritimo WHERE id_num in ('"

                Dim Cont As Integer = 0

                LblId.Text = "'"

                For contador As Integer = 0 To GVSerMar.Rows.Count - 1 Step contador + 1
                    Dim Id As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Dim Revisar As Boolean = CType(GVSerMar.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    If Revisar = False Then



                        If Cont = 0 Then

                            LblId.Text += ""
                        Else
                            Query += "', '"
                            LblId.Text += "', '"
                        End If
                        Cont += 1
                        Query += Id
                        LblId.Text += Id
                    End If

                Next
                LblId.Text += "' "
                Query += "') "

                GVSerMar.DataSource = Ws.Query1(Query)
                GVSerMar.DataBind()


            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al incluir " + ex.Message)
        End Try
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

        tarifarioarrastres.Visible = False
        tarifarioAir.Visible = False
        maritimocompleto.Visible = False
        ltlamericanonacional.Visible = False
        ltlintermodal.Visible = False
        maritimolcl.Visible = False
        terrestrenacional.Visible = False
        arrastrebl.Visible = False
        tarifarioamericano.Visible = False

        If LblVTipo.Text = "1" Then
            LblTituloSolicitud.Text = "AIR"
            tarifarioAir.Visible = True
        ElseIf LblVTipo.Text = "2" Then
            LblTituloSolicitud.Text = "CONTAINER HAULAGE"
            tarifarioarrastres.Visible = True
        ElseIf LblVTipo.Text = "3" Then
            LblTituloSolicitud.Text = "CONTAINER CARRIAGE"
            arrastrebl.Visible = True
        ElseIf LblVTipo.Text = "4" Then
            LblTituloSolicitud.Text = "INTERMODAL"
            ltlintermodal.Visible = True
        ElseIf LblVTipo.Text = "5" Then
            LblTituloSolicitud.Text = "FULL CONTAINER LOAD"
            maritimocompleto.Visible = True
        ElseIf LblVTipo.Text = "6" Then
            LblTituloSolicitud.Text = ""
        ElseIf LblVTipo.Text = "7" Then
            LblTituloSolicitud.Text = "TRUCK LOAD USA"
            tarifarioamericano.Visible = True
        ElseIf LblVTipo.Text = "8" Then
            LblTituloSolicitud.Text = "TRUCK LOAD MEXICO"
            terrestrenacional.Visible = True
        ElseIf LblVTipo.Text = "9" Then
            LblTituloSolicitud.Text = "LESS CONTAINER LOAD"
            maritimolcl.Visible = True
        ElseIf LblVTipo.Text = "10" Then
            LblTituloSolicitud.Text = "LESS TRUCK LOAD"
            ltlamericanonacional.Visible = True
        End If

        DivInfoPricing.Visible = False
        DivSuccessPricing.Visible = False
        DivWarningPricing.Visible = False

    End Sub



    Private Sub GenerateExcel(ByVal Dt As DataTable, ByVal NomHoja As String, ByVal Folio As String, ByVal NameTarifario As String)
        Dim excelPackage = New ExcelPackage(New FileInfo("C:/Doc/" + Folio + "^" + NameTarifario + ".xlsx"))

        Dim excelWorksheet = excelPackage.Workbook.Worksheets.Add(NomHoja)

        excelWorksheet.Cells("A9").LoadFromDataTable(Dt, True)

        excelWorksheet.Row(9).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
        excelWorksheet.Row(9).Style.Fill.BackgroundColor.SetColor(Color.FromArgb("203764"))
        excelWorksheet.Row(9).Style.Font.Color.SetColor(Color.White)
        excelWorksheet.Row(9).Style.Font.Bold = True

        excelPackage.Save()


        'Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        'Response.AddHeader("content-disposition", "attachment;  filename=" + Folio + "^" + NameTarifario + ".xlsx")

    End Sub

    Public Function NombreHojaExcel(ByVal Tipo As String) As String
        Try
            Select Case Tipo
                Case "1"    'FCL
                    Return "AIR"
                Case "2"    'LCL
                    Return "CH"
                Case "3"    'TLM
                    Return "CC"
                Case "4"    'TLU
                    Return "INTERMODAL"
                Case "5"    'CH
                    Return "FCL"
                Case "7"    'LTL
                    Return "TLU"
                Case "8"    'INTERMODAL
                    Return "TLM"
                Case "9"    'AIR
                    Return "LCL"
                Case "10"   'NO BASE
                    Return "LTL"
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Protected Sub BtnFechaDesde_Click(sender As Object, e As EventArgs) Handles BtnFechaDesde.Click
        If String.IsNullOrEmpty(TxtFechaDesde.Text) Then
        Else
            CalendarDesde.SelectedDate = CDate(TxtFechaDesde.Text)
        End If
        If CalendarDesde.Visible = False Then
            CalendarDesde.Visible = True
        Else
            CalendarDesde.Visible = False
        End If
    End Sub


    Protected Sub CalendarDesde_SelectionChanged(sender As Object, e As EventArgs) Handles CalendarDesde.SelectionChanged
        If CalendarDesde.SelectedDate.Date >= Now.ToShortDateString Then

            If CDate(CalendarDesde.SelectedDate.Date) < CDate(TxtFechaAl.Text) Then
                TxtFechaDesde.Text = CalendarDesde.SelectedDate.Date
                CalendarDesde.Visible = False
            Else
                'MessageError("", "Ingrese una fecha valida")
            End If
        Else
            'MessageError("", "Ingrese una fecha valida2")
        End If
    End Sub



    Protected Sub BtnFechaAl_Click(sender As Object, e As EventArgs) Handles BtnFechaAl.Click
        If String.IsNullOrEmpty(TxtFechaAl.Text) Then
        Else
            CalendarAl.SelectedDate = CDate(TxtFechaAl.Text)
        End If
        If CalendarAl.Visible = False Then
            CalendarAl.Visible = True
        Else
            CalendarAl.Visible = False
        End If
    End Sub



    Protected Sub CalendarAl_SelectionChanged(sender As Object, e As EventArgs) Handles CalendarAl.SelectionChanged
        If CalendarAl.SelectedDate.Date > Now.ToShortDateString Then

            If CalendarAl.SelectedDate.Date > CalendarDesde.SelectedDate.Date Then
                TxtFechaAl.Text = CalendarAl.SelectedDate.Date
                CalendarAl.Visible = False
            Else
                'MessageError("", "Ingrese una fecha valida")
            End If

        Else
            'MessageError("", "Ingrese una fecha valida")
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            'Prueba("CotizacionMaritima", "Prueba", "ReporteTarifario")
            'Dim Correo As New BXP_SendMail("hsenties1@gmail.com", "jazmin", "smtp.gmail.com", "587", True)
            'Correo.SendMail("hsentiel@bexap.com, claudia@crossmotion.com.mx", "Crossmotion Proposal A PONZANELLI SA DE CV 8", "Dear Customer A PONZANELLI SA DE CV 8 " + vbCrLf + vbNewLine + "Please find the attachment of quotation based on your requirement. " + vbCrLf + "We hope to be pleased with your trust and help you with this shipment, please feel free to confirm to your Executive. " + vbCrLf + "Best Regrads ", "C:\Doc\ReporteTarifario.pdf")

            ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
            Label3.Text = "Se envio correctamente el correo"

            Dim QueryCorreo As String = "Select email, U_PassCorreo From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + ReadCookie("Usuario", "Usuario") + "' "

            Dim WebSer As New BXP_WebServiceSQL

            Dim Ds As DataTable = WebSer.Query1(QueryCorreo).Tables(0)

            GuardarMaritimo(TxtCorreo.Text, TxtCuerpo.Text, Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), TxtAsunto.Text)

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al enviar correo " + ex.Message)
        End Try
    End Sub

    Private Sub Prueba(ByVal Reporte As String, ByVal Folio As String, ByVal Nombre As String)
        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table

            cryRpt.Load(Server.MapPath("Reportes/" + Reporte + ".rpt"))

            cryRpt.SetParameterValue("DocKey@", Folio)

            With crConnectionInfo
                .ServerName = "SERVER"
                .DatabaseName = "Prototipo_Desarrollos"
                .UserID = "sa"
                .Password = "p@$w0rdSQL"
            End With

            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            'cryRpt.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, False, "E:\Desarrollos\" + Nombre + ".pdf")
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\Doc\" + Nombre + ".pdf")

            'VisorCReport.ReportSource = cryRpt
            'VisorCReport.RefreshReport()

        Catch ex As Exception
            Label1.Text = ex.Message
        End Try
    End Sub




    Protected Sub BtnEnviarCot_Click(sender As Object, e As EventArgs) Handles BtnEnviarCot.Click
        Dim Ban As Boolean = False
        Dim BanSug As Boolean = False

        Try
            If Not String.IsNullOrEmpty(TxtEmpresaCodigo.Text) Then

                If Not String.IsNullOrEmpty(TxtDescripcion.Text) Then
                    If Not String.IsNullOrEmpty(TxtFechaDesde.Text) Then
                        If Not String.IsNullOrEmpty(TxtFechaAl.Text) Then
                            If Not String.IsNullOrEmpty(TxtProducto.Text) Then

                                If Not DdlIncoterm.SelectedItem.Value = "NA" Then




                                    If GVSerMar.Rows.Count > 0 Or GVSerAer.Rows.Count > 0 Or GVSerArr.Rows.Count > 0 Or GVSerArB.Rows.Count > 0 Then


                                        If BanSug = False Then

                                            'GuardarMaritimo()

                                            Dim WebSer As New BXP_WebServiceSQL

                                            DeleteCookie("Cambios")

                                            WebSer.Query3("Insert Into [BXP_Polimeros].dbo.BXP_Estatus (Id, Estatus) values ('" + TxtFolio.Text + "','Incomplete')")
                                            ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal3();", True)

                                            Dim Correos As String = ObtenerCorreos()

                                            Dim Texto As String = ""
                                            Dim Asunto As String = ""

                                            If String.IsNullOrEmpty(Correos) Then
                                                TxtCorreo.Text = LblCorreo.Text
                                            Else
                                                TxtCorreo.Text = Correos
                                            End If

                                            If LblInterNacion.Text = "Nacional" Then

                                                Asunto = "Propuesta Crossmotion " + TxtEmpresa.Text + " " + TxtFolio.Text

                                                Texto += "Estimado Cliente " + vbCrLf
                                                Texto += "" + vbCrLf
                                                Texto += "Con el objetivo de ser más ágiles y dando seguimiento a su actual requerimiento, a continuación encontrará la propuesta generada a través de nuestro sistema. " + vbCrLf
                                                Texto += "" + vbCrLf
                                                Texto += "En caso de vernos favorecidos con su confianza, le pedimos le notifique a su Ejecutivo." + vbCrLf
                                                Texto += "" + vbCrLf
                                                Texto += "Gracias" + vbCrLf
                                            Else

                                                Asunto = "Crossmotion Proposal " + TxtEmpresa.Text + " " + TxtFolio.Text

                                                Texto += "Dear Customer " + vbCrLf
                                                Texto += "" + vbNewLine
                                                Texto += "Please find the attachment of quotation based on your requirement. " + vbCrLf
                                                Texto += "" + vbCrLf
                                                Texto += "We hope to be pleased with your trust and help you with this shipment, please feel free to confirm to your Executive. " + vbCrLf
                                                Texto += "" + vbCrLf
                                                Texto += "Best Regrads " + vbCrLf
                                            End If

                                            TxtAsunto.Text = Asunto

                                            TxtCuerpo.Text = Texto


                                            DeleteCookie("Cambios")

                                        Else

                                        End If


                                    Else
                                        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                        Label3.Text = "Ingrese por favor por lo menos un servicio"

                                    End If
                                Else
                                    ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                    Label3.Text = "Especifique Incoterm"

                                End If
                            Else
                                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                Label3.Text = "Falta ingresar el producto"

                            End If
                        Else
                            ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                            Label3.Text = "Falta fecha Al"

                        End If
                    Else
                        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                        Label3.Text = "Falta fecha Desde"

                    End If
                Else
                    ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                    Label3.Text = "Falta ingresar descripcion"

                End If
            Else
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                Label3.Text = "Falta ingresar el cliente"

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Function ObtenerCorreos() As String
        'Select E_MailL From Prototipo_Desarrollos.dbo.OCPR where CardCode = ''
        Dim Correos As String = ""
        Try
            Dim Query As String = "Select E_MailL From Prototipo_Desarrollos.dbo.OCPR where CardCode = '" + TxtEmpresaCodigo.Text + "' "

            Dim WebSer As New BXP_WebServiceSQL

            Dim Dt As DataTable = WebSer.Query1(Query).Tables(0)

            'Dim Correos As String = ""

            For contador As Integer = 0 To Dt.Rows.Count - 1 Step contador + 1

                If contador = 0 Then
                    Correos += Dt.Rows(contador).Item(0)
                Else
                    Correos += ", " + Dt.Rows(contador).Item(0)
                End If

            Next


        Catch ex As Exception
        End Try

        Return Correos
    End Function



    Protected Sub BtnGuardarCot_Click(sender As Object, e As EventArgs) Handles BtnGuardarCot.Click

        Dim Ban As Boolean = False
        Dim BanSug As Boolean = False

        Try
            If Not String.IsNullOrEmpty(TxtEmpresaCodigo.Text) Then

                If Not String.IsNullOrEmpty(TxtDescripcion.Text) Then
                    If Not String.IsNullOrEmpty(TxtFechaDesde.Text) Then
                        If Not String.IsNullOrEmpty(TxtFechaAl.Text) Then
                            If Not String.IsNullOrEmpty(TxtProducto.Text) Then

                                If Not DdlIncoterm.SelectedItem.Value = "NA" Then

                                    If GVSerMar.Rows.Count > 0 Or GVSerAer.Rows.Count > 0 Or GVSerArr.Rows.Count > 0 Or GVSerArB.Rows.Count > 0 Then


                                        If BanSug = False Then

                                            GuardarMaritimo()

                                            Dim WebSer As New BXP_WebServiceSQL

                                            DeleteCookie("Cambios")

                                            WebSer.Query3("Insert Into [BXP_Polimeros].dbo.BXP_Estatus (Id, Estatus) values ('" + TxtFolio.Text + "','Incomplete')")
                                            'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                            AlertSuccess("Se guardó correctamente con folio " + TxtFolio.Text)
                                            'Label3.Text = "Se guardo correctamente"
                                        Else
                                            'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                            AlertSuccess("Se guardó correctamente")
                                            'Label3.Text = "Se guardo correrctamente"

                                        End If

                                    Else
                                        'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                        AlertWarning("Ingrese por favor por lo menos un servicio")
                                        'Label3.Text = "Ingrese por favor por lo menos un servicio"

                                    End If
                                Else
                                    'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                    AlertWarning("Especifique Incoterm")
                                    'Label3.Text = "Especifique Incoterm"

                                End If
                            Else
                                'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                                AlertWarning("Falta ingresar el producto")
                                'Label3.Text = "Falta ingresar el producto"

                            End If
                        Else
                            'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                            AlertWarning("Falta fecha Al")
                            'Label3.Text = "Falta fecha Al"

                        End If
                    Else
                        'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                        AlertWarning("Falta fecha Desde")
                        'Label3.Text = "Falta fecha Desde"

                    End If
                Else
                    'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                    AlertWarning("Falta ingresar descripcion")
                    'Label3.Text = "Falta ingresar descripcion"

                End If
            Else
                'ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal4();", True)
                AlertWarning("Falta ingresar el cliente")
                'Label3.Text = "Falta ingresar el cliente"

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub GuardarPricing()
        Try

            Dim WsSql As New BXP_WebServiceSQL

            Dim Resultado As String = "1"

            Dim Rol As String = ReadCookie("Rol", "Rol")


            Dim UltimoId As String = CStr(WsSql.Query2("Select max(id) From BXP_Polimeros.dbo.Pedido") + 1)
            Dim Empresa As String = ""
            Dim TipoDoc As String = ""
            Dim Serie As String = ""

            If DropDownList1.SelectedItem.Value = "1" Then
                Empresa = "Prototipo_Desarrollos"
            Else
                Empresa = "MTI_Prototipo_Desarrollo"
            End If

            Dim QuerysPedidos As String = "Insert into BXP_Polimeros.dbo.Pedido (Id, CardCode, Fecha, Comments, PedidoVenta, PedidoCompra, CentroCostos, Error, U_DESCRIPCION, U_PRODUCTO, FolioWeb, Empresa, Serie, Tipo, Alerta1, Alerta2, Auto, CodeI, Type, Kind, Ban) "
            QuerysPedidos += "Values('" + UltimoId + "','" + TxtEmpresaCodigo.Text + "','" + CStr(CDate(Now).ToString("yyyy/MM/dd")) + "','" + "','False','False','','False','" + TxtDescripcion.Text + "','" + TxtProducto.Text + "','" + TxtFolio.Text + "', '" + Empresa + "', '" + Serie + "', '" + TipoDoc + "', '" + CStr("True") + "', 'False', '" + CStr("True") + "', '" + CStr(DdlIncoterm.SelectedItem.Value) + "', '" + CStr(DdlTipoCotizacion.SelectedItem.Value) + "', '" + DdlKind.SelectedItem.Value + "', 'False') "

            LblIdPricing.Text = UltimoId

            WsSql.Query3(QuerysPedidos)



        Catch ex As Exception

        End Try

    End Sub





    Protected Sub BtnAgregarServicio_Click(sender As Object, e As EventArgs) Handles BtnAgregarServicio.Click

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal7();", True)

        LblAddBan.Text = "2"

    End Sub

    Private Sub AlertSuccess(ByVal Texto As String)
        DivAlertInfo.Visible = False
        DivAlertSuccess.Visible = True
        DivAlertWarning.Visible = False
        LblSuccess.Text = Texto
        LblInfo.Text = ""
        LblWarning.Text = ""
    End Sub

    Private Sub AlertInfo(ByVal Texto As String)
        DivAlertInfo.Visible = True
        DivAlertSuccess.Visible = False
        DivAlertWarning.Visible = False
        LblSuccess.Text = ""
        LblInfo.Text = Texto
        LblWarning.Text = ""
    End Sub

    Private Sub AlertWarning(ByVal Texto As String)
        DivAlertInfo.Visible = False
        DivAlertSuccess.Visible = False
        DivAlertWarning.Visible = True
        LblSuccess.Text = ""
        LblInfo.Text = ""
        LblWarning.Text = Texto
    End Sub


    Protected Sub TxtPeso_TextChanged(sender As Object, e As EventArgs)
        CalcularAereo()
    End Sub


    Private Sub CalcularAereo()
        Try
            DivAlertInfo.Visible = False
            DivAlertSuccess.Visible = False
            DivAlertWarning.Visible = False
            For contador As Integer = 0 To GVSerAer.Rows.Count - 1 Step contador + 1
                Dim Peso As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPeso"), TextBox).Text

                If String.IsNullOrEmpty(Peso) Then
                    AlertWarning("Ingrese el peso correcto de los articulos")
                Else
                    Dim Factor As String = ""

                    If CDbl(Peso) < 45 Then
                        Factor = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMEN45KG"), Label).Text
                    ElseIf CDbl(Peso) >= 45 And CDbl(Peso) < 100 Then
                        Factor = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY45KG"), Label).Text
                    ElseIf CDbl(Peso) >= 100 And CDbl(Peso) < 300 Then
                        Factor = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY100KG"), Label).Text
                    ElseIf CDbl(Peso) >= 300 And CDbl(Peso) < 500 Then
                        Factor = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY300KG"), Label).Text
                    ElseIf CDbl(Peso) >= 500 And CDbl(Peso) < 1000 Then
                        Factor = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY500KG"), Label).Text
                    Else
                        Factor = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY1000KG"), Label).Text
                    End If

                    Dim CostoKG As String = CDbl(Peso) * CDbl(Factor)

                    Dim FSCKG As String = CDbl(Peso) * CDbl(CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblFSCKG"), Label).Text)

                    Dim SSCKG As String = CDbl(Peso) * CDbl(CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblSSCKG"), Label).Text)

                    Dim SUBTOTAL As String = CDbl(CostoKG) + CDbl(FSCKG) + CDbl(SSCKG)

                    Dim TaxKG As String = CDbl(SUBTOTAL) * (CDbl(CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblTAX"), Label).Text))

                    Dim Total As String = CDbl(TaxKG) + CDbl(SUBTOTAL)

                    Dim GTotal As String = CDbl(Total) * 1.15

                    Dim HAWB As String = CDbl(CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblHAWB"), Label).Text)

                    Dim HANDLING As String = CDbl(CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblHANDLING"), Label).Text)


                    If CDbl(CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMIN"), Label).Text) + 75 <= CDbl(GTotal) Then
                        CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text = CStr(FormatNumber(CDbl(GTotal) + CDbl(HAWB) + CDbl(HANDLING), 2)).Replace(",", "")
                    Else
                        CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text = CStr(CDbl(CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMIN"), Label).Text) + 75 + CDbl(HAWB) + CDbl(HANDLING))
                    End If


                End If



            Next
        Catch ex As Exception
            AlertWarning("Alerta alerta " + ex.Message)
        End Try
    End Sub


















    Protected Sub LblMIN_TextChanged(sender As Object, e As EventArgs)
        CalcularAereo()
    End Sub

    Private Function GuardarMaritimo()

        Dim BanSug As Boolean = False

        Try

            Dim WsSql As New BXP_WebServiceSQL

            Dim Resultado As String = "1"

            Dim UltimoId As String = CStr(WsSql.Query2("Select max(id) From BXP_Polimeros.dbo.Pedido") + 1)
            Dim Empresa As String = ""
            Dim TipoDoc As String = ""
            Dim Serie As String = ""

            If DropDownList1.SelectedItem.Value = "1" Then
                Empresa = "Prototipo_Desarrollos"
            Else
                Empresa = "MTI_Prototipo_Desarrollo"
            End If

            If ReadCookie("Rol", "Rol") = "1" Then
                TipoDoc = "True"
            ElseIf ReadCookie("Rol", "Rol") = "2" Then
                TipoDoc = "False"
            Else
                TipoDoc = "False"
            End If

            TipoDoc = "True"

            If ReadCookie("Rol", "Rol") = "1" Then
                Serie = "71"
            ElseIf ReadCookie("Rol", "Rol") = "2" Then
                Serie = "74"
            Else
                Serie = "74"
            End If

            Dim QuerysPedidos As String = "Insert into BXP_Polimeros.dbo.Pedido (Id, CardCode, Fecha, Comments, PedidoVenta, PedidoCompra, CentroCostos, Error, U_DESCRIPCION, U_PRODUCTO, FolioWeb, Empresa, Serie, Tipo, Alerta1, Alerta2, Auto, CodeI, Type, Kind, Ban, TypeService) "
            QuerysPedidos += "Values('" + UltimoId + "','" + TxtEmpresaCodigo.Text + "','" + CStr(CDate("2017/06/19").ToString("yyyy/MM/dd")) + "','" + "','False','False','','False','" + TxtDescripcion.Text + "','" + TxtProducto.Text + "','" + TxtFolio.Text + "', '" + Empresa + "', '" + Serie + "', '" + TipoDoc + "', '" + CStr("True") + "', 'False', '" + CStr("False") + "', '" + CStr(DdlIncoterm.SelectedItem.Value) + "', '" + CStr(DdlTipoCotizacion.SelectedItem.Value) + "', '" + DdlKind.SelectedItem.Value + "', 'True', '" + DdlTipoCotizacion.SelectedItem.Value + "') "

            WsSql.Query3(QuerysPedidos)

            For contador As Integer = 0 To GVSerAer.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "FF-AIR-SALES"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"

                Dim AGENT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text

                Dim POL_CODE As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim CURRENCY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim NAC As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim SUBJECT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim TT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim RA As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                Dim VIA1 As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                Dim VIA2 As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                Dim VIA3 As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text



                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "
                QuerysDetalles += "Values('" + CStr(UltimoId) + "','" + CStr(Codigo) + "','" + CStr(Cantidad) + "','','','" + CStr(AGENT) + "','','" + CStr(POL_CODE) + "','" + CStr(POL) + "','" + CStr(POL_CODE_COUNTRY) + "','" + CStr(POL_COUNTRY) + "','" + CStr(POD_CODE) + "','" + CStr(POD) + "','" + CStr(POD_CODE_COUNTRY) + "','" + CStr(POD_COUNTRY) + "','" + CStr(VIA1) + "','" + CStr(VIA2) + "','" + CStr(VIA3) + "','" + CStr(CURRENCY) + "','','','','','','','','" + CStr(VALIDITY_FROM) + "','" + CStr(VALIDITY_TO) + "','" + CStr(TT) + "','','" + CStr(NAC) + "','" + COMMODITY + "','','','" + RA + "','','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)

            Next

            For contador As Integer = 0 To GVSerArr.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "FRE_IN_CH"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"


                Dim CARRIER As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                Dim POL_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim CURRENCY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim EQUIPMENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim TT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim FREE_DAYS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), TextBox).Text
                Dim NAC As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                'Dim UN As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                'Dim IMO_SUB As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblIMO_SUB"), Label).Text
                'Dim RA As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                'Dim COMMITMENT_TES As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_TES"), Label).Text
                Dim SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim Precio As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                Dim Precio2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2"), TextBox).Text
                Dim Precio3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3"), TextBox).Text
                Dim PrecioSug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecioSug"), TextBox).Text
                Dim Precio2Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2Sug"), TextBox).Text
                Dim Precio3Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3Sug"), TextBox).Text

                Dim DD As String = ""

                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "         '[], [], [], , , , , , , , , , , , , , 
                QuerysDetalles += "Values('" + UltimoId + "','" + Codigo + "','" + Cantidad + "','" + CStr(CDbl(Precio)) + "','','','" + CARRIER + "','" + POL_CODE + "','" + POL + "','" + POL_CODE_COUNTRY + "','" + POL_COUNTRY + "','" + POD_CODE + "','" + POD + "','" + POD_CODE_COUNTRY + "','" + POD_COUNTRY + "','','','','" + CURRENCY + "','" + CStr(CDbl(Precio2)) + "','" + CStr(CDbl(Precio3)) + "','" + DD + "','','','','" + EQUIPMENT + "','" + VALIDITY_FROM + "','" + VALIDITY_TO + "','" + TT + "','" + FREE_DAYS + "','" + NAC + "','" + COMMODITY + "','','','','','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)


            Next

            For contador As Integer = 0 To GVSerArB.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "OCEAN-FREIGHT"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"

                Dim AGENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                Dim CARRIER As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                Dim POL_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim VIA1 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                Dim VIA2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                Dim VIA3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text
                Dim CURRENCY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim L20GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl20GP"), Label).Text
                Dim L40GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40GP"), Label).Text
                Dim L40HQ As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40HQ"), Label).Text
                Dim EQUIPMENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim TT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim FREE_DAYS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), TextBox).Text
                Dim NAC As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                Dim UN As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                Dim IMO_SUB As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblIMO_SUB"), Label).Text
                Dim RA As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                Dim COMMITMENT_TES As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_TES"), Label).Text
                Dim SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim Precio As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                Dim Precio2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2"), TextBox).Text
                Dim Precio3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3"), TextBox).Text
                Dim PrecioSug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecioSug"), TextBox).Text
                Dim Precio2Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2Sug"), TextBox).Text
                Dim Precio3Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3Sug"), TextBox).Text

                Dim DD As String = ""

                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "         '[], [], [], , , , , , , , , , , , , , 
                QuerysDetalles += "Values('" + UltimoId + "','" + Codigo + "','" + Cantidad + "','" + CStr(CDbl(Precio)) + "','','" + AGENT + "','" + CARRIER + "','" + POL_CODE + "','" + POL + "','" + POL_CODE_COUNTRY + "','" + POL_COUNTRY + "','" + POD_CODE + "','" + POD + "','" + POD_CODE_COUNTRY + "','" + POD_COUNTRY + "','" + VIA1 + "','" + VIA2 + "','" + VIA3 + "','" + CURRENCY + "','" + CStr(CDbl(Precio2)) + "','" + CStr(CDbl(Precio3)) + "','" + DD + "','" + CStr(CDbl(L20GP)) + "','" + CStr(CDbl(L40GP)) + "','" + CStr(CDbl(L40HQ)) + "','" + EQUIPMENT + "','" + VALIDITY_FROM + "','" + VALIDITY_TO + "','" + TT + "','" + FREE_DAYS + "','" + NAC + "','" + COMMODITY + "','" + UN + "','" + IMO_SUB + "','" + RA + "','" + COMMITMENT_TES + "','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)


            Next

            For contador As Integer = 0 To GVSerMar.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "OCEAN-FREIGHT"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"

                Dim AGENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                Dim CARRIER As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                Dim POL_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim VIA1 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                Dim VIA2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                Dim VIA3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text
                Dim CURRENCY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim L20GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl20GP"), Label).Text
                Dim L40GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40GP"), Label).Text
                Dim L40HQ As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40HQ"), Label).Text
                Dim EQUIPMENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim TT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim FREE_DAYS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), TextBox).Text
                Dim NAC As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                Dim UN As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                Dim IMO_SUB As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblIMO_SUB"), Label).Text
                Dim RA As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                Dim COMMITMENT_TES As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_TES"), Label).Text
                Dim SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim Precio As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                Dim Precio2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2"), TextBox).Text
                Dim Precio3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3"), TextBox).Text
                Dim PrecioSug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecioSug"), TextBox).Text
                Dim Precio2Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2Sug"), TextBox).Text
                Dim Precio3Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3Sug"), TextBox).Text

                Dim DD As String = ""

                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "         '[], [], [], , , , , , , , , , , , , , 
                QuerysDetalles += "Values('" + UltimoId + "','" + Codigo + "','" + Cantidad + "','" + CStr(CDbl(Precio)) + "','','" + AGENT + "','" + CARRIER + "','" + POL_CODE + "','" + POL + "','" + POL_CODE_COUNTRY + "','" + POL_COUNTRY + "','" + POD_CODE + "','" + POD + "','" + POD_CODE_COUNTRY + "','" + POD_COUNTRY + "','" + VIA1 + "','" + VIA2 + "','" + VIA3 + "','" + CURRENCY + "','" + CStr(CDbl(Precio2)) + "','" + CStr(CDbl(Precio3)) + "','" + DD + "','" + CStr(CDbl(L20GP)) + "','" + CStr(CDbl(L40GP)) + "','" + CStr(CDbl(L40HQ)) + "','" + EQUIPMENT + "','" + VALIDITY_FROM + "','" + VALIDITY_TO + "','" + TT + "','" + FREE_DAYS + "','" + NAC + "','" + COMMODITY + "','" + UN + "','" + IMO_SUB + "','" + RA + "','" + COMMITMENT_TES + "','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)
            Next



        Catch ex As Exception

            Dim Log As New BXP_Log

            Log.ErrorLog("Error al llenar Terrestre - " + ex.Message)
        End Try

        Return True
    End Function

    Private Function GuardarMaritimo(ByVal Correos As String, ByVal Cuerpo As String, ByVal Correo As String, ByVal Pass As String, ByVal Asunto As String)

        Dim BanSug As Boolean = False

        Try

            Dim WsSql As New BXP_WebServiceSQL

            Dim Resultado As String = "1"

            Dim UltimoId As String = CStr(WsSql.Query2("Select max(id) From BXP_Polimeros.dbo.Pedido") + 1)
            Dim Empresa As String = ""
            Dim TipoDoc As String = ""
            Dim Serie As String = ""

            If DropDownList1.SelectedItem.Value = "1" Then
                Empresa = "Prototipo_Desarrollos"
            Else
                Empresa = "MTI_Prototipo_Desarrollo"
            End If

            If ReadCookie("Rol", "Rol") = "1" Then
                TipoDoc = "True"
            ElseIf ReadCookie("Rol", "Rol") = "2" Then
                TipoDoc = "False"
            Else
                TipoDoc = "False"
            End If

            TipoDoc = "True"

            If ReadCookie("Rol", "Rol") = "1" Then
                Serie = "71"
            ElseIf ReadCookie("Rol", "Rol") = "2" Then
                Serie = "74"
            Else
                Serie = "74"
            End If

            Dim QuerysPedidos As String = "Insert into BXP_Polimeros.dbo.Pedido (Id, CardCode, Fecha, Comments, PedidoVenta, PedidoCompra, CentroCostos, Error, U_DESCRIPCION, U_PRODUCTO, FolioWeb, Empresa, Serie, Tipo, Alerta1, Alerta2, Auto, CodeI, Type, Kind, Ban, TypeService, Correos, Cuerpo, Correo, Pass, Asunto) "
            QuerysPedidos += "Values('" + UltimoId + "','" + TxtEmpresaCodigo.Text + "','" + CStr(CDate("2017/06/19").ToString("yyyy/MM/dd")) + "','" + "','False','False','','False','" + TxtDescripcion.Text + "','" + TxtProducto.Text + "','" + TxtFolio.Text + "', '" + Empresa + "', '" + Serie + "', '" + TipoDoc + "', '" + CStr("True") + "', 'False', '" + CStr("False") + "', '" + CStr(DdlIncoterm.SelectedItem.Value) + "', '" + CStr(DdlTipoCotizacion.SelectedItem.Value) + "', '" + DdlKind.SelectedItem.Value + "', 'True', '" + DdlTipoCotizacion.SelectedItem.Value + "', '" + Correos + "', '" + Cuerpo + "', '" + Correo + "', '" + Pass + "', '" + Asunto + "') "

            WsSql.Query3(QuerysPedidos)

            For contador As Integer = 0 To GVSerAer.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "FF-AIR-SALES"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"

                Dim AGENT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text

                Dim POL_CODE As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim CURRENCY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim NAC As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim SUBJECT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim TT As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim RA As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                Dim VIA1 As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                Dim VIA2 As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                Dim VIA3 As String = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text



                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "
                QuerysDetalles += "Values('" + CStr(UltimoId) + "','" + CStr(Codigo) + "','" + CStr(Cantidad) + "','','','" + CStr(AGENT) + "','','" + CStr(POL_CODE) + "','" + CStr(POL) + "','" + CStr(POL_CODE_COUNTRY) + "','" + CStr(POL_COUNTRY) + "','" + CStr(POD_CODE) + "','" + CStr(POD) + "','" + CStr(POD_CODE_COUNTRY) + "','" + CStr(POD_COUNTRY) + "','" + CStr(VIA1) + "','" + CStr(VIA2) + "','" + CStr(VIA3) + "','" + CStr(CURRENCY) + "','','','','','','','','" + CStr(VALIDITY_FROM) + "','" + CStr(VALIDITY_TO) + "','" + CStr(TT) + "','','" + CStr(NAC) + "','" + COMMODITY + "','','','" + RA + "','','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)

            Next

            For contador As Integer = 0 To GVSerArr.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "FRE_IN_CH"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"


                Dim CARRIER As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                Dim POL_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim CURRENCY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim EQUIPMENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim TT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim FREE_DAYS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), TextBox).Text
                Dim NAC As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                'Dim UN As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                'Dim IMO_SUB As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblIMO_SUB"), Label).Text
                'Dim RA As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                'Dim COMMITMENT_TES As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_TES"), Label).Text
                Dim SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim Precio As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                Dim Precio2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2"), TextBox).Text
                Dim Precio3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3"), TextBox).Text
                Dim PrecioSug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecioSug"), TextBox).Text
                Dim Precio2Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2Sug"), TextBox).Text
                Dim Precio3Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3Sug"), TextBox).Text

                Dim DD As String = ""

                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "         '[], [], [], , , , , , , , , , , , , , 
                QuerysDetalles += "Values('" + UltimoId + "','" + Codigo + "','" + Cantidad + "','" + CStr(CDbl(Precio)) + "','','','" + CARRIER + "','" + POL_CODE + "','" + POL + "','" + POL_CODE_COUNTRY + "','" + POL_COUNTRY + "','" + POD_CODE + "','" + POD + "','" + POD_CODE_COUNTRY + "','" + POD_COUNTRY + "','','','','" + CURRENCY + "','" + CStr(CDbl(Precio2)) + "','" + CStr(CDbl(Precio3)) + "','" + DD + "','','','','" + EQUIPMENT + "','" + VALIDITY_FROM + "','" + VALIDITY_TO + "','" + TT + "','" + FREE_DAYS + "','" + NAC + "','" + COMMODITY + "','','','','','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)


            Next

            For contador As Integer = 0 To GVSerArB.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "OCEAN-FREIGHT"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"

                Dim AGENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                Dim CARRIER As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                Dim POL_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim VIA1 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                Dim VIA2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                Dim VIA3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text
                Dim CURRENCY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim L20GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl20GP"), Label).Text
                Dim L40GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40GP"), Label).Text
                Dim L40HQ As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40HQ"), Label).Text
                Dim EQUIPMENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim TT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim FREE_DAYS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), TextBox).Text
                Dim NAC As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                Dim UN As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                Dim IMO_SUB As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblIMO_SUB"), Label).Text
                Dim RA As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                Dim COMMITMENT_TES As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_TES"), Label).Text
                Dim SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim Precio As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                Dim Precio2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2"), TextBox).Text
                Dim Precio3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3"), TextBox).Text
                Dim PrecioSug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecioSug"), TextBox).Text
                Dim Precio2Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2Sug"), TextBox).Text
                Dim Precio3Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3Sug"), TextBox).Text

                Dim DD As String = ""

                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "         '[], [], [], , , , , , , , , , , , , , 
                QuerysDetalles += "Values('" + UltimoId + "','" + Codigo + "','" + Cantidad + "','" + CStr(CDbl(Precio)) + "','','" + AGENT + "','" + CARRIER + "','" + POL_CODE + "','" + POL + "','" + POL_CODE_COUNTRY + "','" + POL_COUNTRY + "','" + POD_CODE + "','" + POD + "','" + POD_CODE_COUNTRY + "','" + POD_COUNTRY + "','" + VIA1 + "','" + VIA2 + "','" + VIA3 + "','" + CURRENCY + "','" + CStr(CDbl(Precio2)) + "','" + CStr(CDbl(Precio3)) + "','" + DD + "','" + CStr(CDbl(L20GP)) + "','" + CStr(CDbl(L40GP)) + "','" + CStr(CDbl(L40HQ)) + "','" + EQUIPMENT + "','" + VALIDITY_FROM + "','" + VALIDITY_TO + "','" + TT + "','" + FREE_DAYS + "','" + NAC + "','" + COMMODITY + "','" + UN + "','" + IMO_SUB + "','" + RA + "','" + COMMITMENT_TES + "','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)


            Next

            For contador As Integer = 0 To GVSerMar.Rows.Count - 1 Step contador + 1

                Dim Codigo As String = "OCEAN-FREIGHT"
                Dim Nombre As String = ""

                Dim Cantidad As String = "1"

                Dim AGENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                Dim CARRIER As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                Dim POL_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                Dim POL As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                Dim POL_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Dim POL_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                Dim POD_CODE As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                Dim POD As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                Dim POD_CODE_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                Dim POD_COUNTRY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                Dim VIA1 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                Dim VIA2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                Dim VIA3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text
                Dim CURRENCY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                Dim L20GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl20GP"), Label).Text
                Dim L40GP As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40GP"), Label).Text
                Dim L40HQ As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("Lbl40HQ"), Label).Text
                Dim EQUIPMENT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                Dim VALIDITY_FROM As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                Dim VALIDITY_TO As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                Dim TT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                Dim FREE_DAYS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), TextBox).Text
                Dim NAC As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                Dim COMMODITY As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                Dim UN As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                Dim IMO_SUB As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblIMO_SUB"), Label).Text
                Dim RA As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                Dim COMMITMENT_TES As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_TES"), Label).Text
                Dim SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                Dim NOT_SUBJECT As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                Dim REMARKS As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                Dim Precio As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                Dim Precio2 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2"), TextBox).Text
                Dim Precio3 As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3"), TextBox).Text
                Dim PrecioSug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecioSug"), TextBox).Text
                Dim Precio2Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio2Sug"), TextBox).Text
                Dim Precio3Sug As String = CType(GVSerMar.Rows(contador).Cells(0).FindControl("TxtPrecio3Sug"), TextBox).Text

                Dim DD As String = ""

                Dim QuerysDetalles As String = ""
                QuerysDetalles = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, Cantidad, Precio, Total, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, VIA1, VIA2, VIA3, CURRENCY, Precio2, Precio3, DD, [20GP], [40GP], [40HQ], EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, IMO_SUB, RA, COMMITMENT_TES, SUBJECT, NOT_SUBJECT, REMARKS) "         '[], [], [], , , , , , , , , , , , , , 
                QuerysDetalles += "Values('" + UltimoId + "','" + Codigo + "','" + Cantidad + "','" + CStr(CDbl(Precio)) + "','','" + AGENT + "','" + CARRIER + "','" + POL_CODE + "','" + POL + "','" + POL_CODE_COUNTRY + "','" + POL_COUNTRY + "','" + POD_CODE + "','" + POD + "','" + POD_CODE_COUNTRY + "','" + POD_COUNTRY + "','" + VIA1 + "','" + VIA2 + "','" + VIA3 + "','" + CURRENCY + "','" + CStr(CDbl(Precio2)) + "','" + CStr(CDbl(Precio3)) + "','" + DD + "','" + CStr(CDbl(L20GP)) + "','" + CStr(CDbl(L40GP)) + "','" + CStr(CDbl(L40HQ)) + "','" + EQUIPMENT + "','" + VALIDITY_FROM + "','" + VALIDITY_TO + "','" + TT + "','" + FREE_DAYS + "','" + NAC + "','" + COMMODITY + "','" + UN + "','" + IMO_SUB + "','" + RA + "','" + COMMITMENT_TES + "','" + SUBJECT + "','" + NOT_SUBJECT + "','" + REMARKS + "')"

                Resultado = WsSql.Query3(QuerysDetalles)
            Next



        Catch ex As Exception

            Dim Log As New BXP_Log

            Log.ErrorLog("Error al llenar Terrestre - " + ex.Message)
        End Try

        Return True
    End Function
































    Protected Sub BtnCarOAdd_Click(sender As Object, e As EventArgs) Handles BtnCarOAdd.Click
        LblCargoT.Text = "CO"

        'PnlBusCar.Visible = True
        LlenarGvArticulos()
        'PnlVisCar.Enabled = False

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal5();", True)

    End Sub

    Protected Sub BtnCarODel_Click(sender As Object, e As EventArgs) Handles BtnCarODel.Click
        Dim GranTotal As Double = 0
        Dim Ds As DataTable
        Ds = New DataTable

        Ds.Columns.Add("Codigo")
        Ds.Columns.Add("Nombre")
        Ds.Columns.Add("UM")
        Ds.Columns.Add("Cantidad")
        Ds.Columns.Add("Precio")
        Ds.Columns.Add("Total")
        Ds.Columns.Add("Moneda")

        If Not GvCarOri.Rows.Count = 0 Then
            For contador As Integer = 0 To GvCarOri.Rows.Count - 1 Step contador + 1

                Dim Bandera As Boolean = CType(GvCarOri.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                If Bandera = False Then
                    Dim Renglon As DataRow = Ds.NewRow()
                    Renglon = Ds.NewRow()
                    Dim Codigo As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text
                    Dim Nombre As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("LblNombre"), Label).Text
                    Dim UM As String = ""
                    Dim Cantidad As String = "1"
                    Dim Precio As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                    Dim Total As String
                    If IsNumeric(Cantidad) Then
                        Total = CStr(CDbl(Cantidad) * CDbl(Precio))
                    Else
                        Total = "0.00"
                    End If


                    GranTotal += Total

                    Renglon("Codigo") = Codigo
                    Renglon("Nombre") = Nombre
                    Renglon("UM") = UM
                    Renglon("Cantidad") = Cantidad
                    Renglon("Precio") = FormatNumber(Precio, 2)
                    Renglon("Total") = FormatNumber(Total, 2)
                    Ds.Rows.Add(Renglon)
                End If


            Next
        End If

        GvCarOri.DataSource = Ds
        GvCarOri.DataBind()

        'Return Ds
    End Sub

    Protected Sub BtnCarDAdd_Click(sender As Object, e As EventArgs) Handles BtnCarDAdd.Click
        LblCargoT.Text = "CD"

        'PnlBusCar.Visible = True
        LlenarGvArticulos()
        'PnlVisCar.Enabled = False

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal5();", True)
    End Sub

    Protected Sub BtnCarDDel_Click(sender As Object, e As EventArgs) Handles BtnCarDDel.Click
        Dim GranTotal As Double = 0
        Dim Ds As DataTable
        Ds = New DataTable

        Ds.Columns.Add("Codigo")
        Ds.Columns.Add("Nombre")
        Ds.Columns.Add("UM")
        Ds.Columns.Add("Cantidad")
        Ds.Columns.Add("Precio")
        Ds.Columns.Add("Total")
        Ds.Columns.Add("Moneda")

        If Not GvCarDes.Rows.Count = 0 Then
            For contador As Integer = 0 To GvCarDes.Rows.Count - 1 Step contador + 1

                Dim Bandera As Boolean = CType(GvCarDes.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                If Bandera = False Then
                    Dim Renglon As DataRow = Ds.NewRow()
                    Renglon = Ds.NewRow()
                    Dim Codigo As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text
                    Dim Nombre As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("LblNombre"), Label).Text
                    Dim UM As String = ""
                    Dim Cantidad As String = "1"
                    Dim Precio As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                    Dim Total As String
                    If IsNumeric(Cantidad) Then
                        Total = CStr(CDbl(Cantidad) * CDbl(Precio))
                    Else
                        Total = "0.00"
                    End If


                    GranTotal += Total

                    Renglon("Codigo") = Codigo
                    Renglon("Nombre") = Nombre
                    Renglon("UM") = UM
                    Renglon("Cantidad") = Cantidad
                    Renglon("Precio") = FormatNumber(Precio, 2)
                    Renglon("Total") = FormatNumber(Total, 2)
                    Ds.Rows.Add(Renglon)
                End If


            Next
        End If

        GvCarDes.DataSource = Ds
        GvCarDes.DataBind()

    End Sub

    Private Sub LlenarGvArticulos()

        Try
            Dim Ws As New BXP_WebServiceSQL

            Dim NumLista As String = "1"

            Dim Query As String = "SELECT a.ItemCode, a.ItemName, b.Price, b.Currency, a.OnHand, a.SalUnitMsr "
            Query += "FROM [Prototipo_Desarrollos].[dbo].OITM AS a left JOIN [Prototipo_Desarrollos].[dbo].ITM1 AS b ON a.ItemCode = b.ItemCode "
            Query += "WHERE b.PriceList = '" + CStr(NumLista) + "' "

            If Not String.IsNullOrEmpty(TxtArtCodigo.Text) Then
                Query += "And a.ItemCode like '%" + TxtArtCodigo.Text + "%' "
            ElseIf Not String.IsNullOrEmpty(TxtArtNombre.Text) Then
                Query += "And a.ItemName like '%" + TxtArtNombre.Text + "%' "
            End If

            Query += " " + EliminarPartidas()

            Query += "and a.validFor = 'Y' and a.FrozenFor = 'N' and a.QryGroup11 = 'Y' "

            Query += "Order by a.ItemCode"

            'Dim Log As New BXP_Log
            'Log.EventLog("LlenarGvArticulos Query - " + Query)

            Dim Ds As DataSet = Ws.Query1(Query)

            GvArticulos.DataSource = Nothing
            GvArticulos.DataSource = Ds
            GvArticulos.PageIndex = 0
            GvArticulos.DataBind()
        Catch ex As Exception
            'MessageError("LlenarGvArticulos - ", ex.Message)
        End Try


    End Sub

    Private Function EliminarPartidas() As String

        Dim Query As String = "And not a.ItemCode in (''"

        If LblCargoT.Text = "CO" Then
            If GvCarOri.Rows.Count > 0 Then
                Query += ","
            End If
            For contador As Integer = 0 To GvCarOri.Rows.Count - 1 Step contador + 1
                Dim Codigo As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text

                Query += "'" + Codigo + "'"

                If contador < (GvCarOri.Rows.Count - 1) Then
                    Query += ","
                End If

            Next
        Else
            If GvCarDes.Rows.Count > 0 Then
                Query += ","
            End If
            For contador As Integer = 0 To GvCarDes.Rows.Count - 1 Step contador + 1
                Dim Codigo As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text

                Query += "'" + Codigo + "'"

                If contador < (GvCarDes.Rows.Count - 1) Then
                    Query += ","
                End If

            Next
        End If

        Query += ")"

        Return Query

    End Function

    Protected Sub DdlMoneda_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim Ws As New BXP_WebServiceSQL
        Try
            For contador As Integer = 0 To GvCarOri.Rows.Count - 1 Step contador + 1
                Dim Combo As DropDownList = GvCarOri.Rows(contador).FindControl("DdlMoneda")

                Dim Precio1 As Label = GvCarOri.Rows(contador).FindControl("LblPrecio")
                Dim Precio2 As TextBox = GvCarOri.Rows(contador).FindControl("TxtPrecio")

                Dim Query As String = "SELECT MAX(NAME) FROM Prototipo_Desarrollos.dbo.[@TC_COMERCIAL] WHERE Code = 'Compra' "

                If Combo.SelectedItem.Value = "MXP" Or Combo.SelectedItem.Value = "MXN" Then
                    Precio2.Text = FormatNumber(CDbl(Precio1.Text), 2)
                Else
                    Dim Aux As Double = CDbl(Ws.Query2(Query))
                    If Aux > 0 Then
                        Precio2.Text = FormatNumber(CDbl(Precio1.Text) / Aux, 2)
                    Else
                        'MessageError("", "Capturar tipo de cambio en SAP")
                    End If

                End If



            Next
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error - " + ex.Message)
        End Try
    End Sub

    Protected Sub DdlMoneda_SelectedIndexChanged1(sender As Object, e As EventArgs)
        Dim Ws As New BXP_WebServiceSQL
        Try
            For contador As Integer = 0 To GvCarDes.Rows.Count - 1 Step contador + 1
                Dim Combo As DropDownList = GvCarDes.Rows(contador).FindControl("DdlMoneda")

                Dim Precio1 As Label = GvCarDes.Rows(contador).FindControl("LblPrecio")
                Dim Precio2 As TextBox = GvCarDes.Rows(contador).FindControl("TxtPrecio")

                'Dim Query As String = "SELECT MAX(RATE) FROM Prototipo_Desarrollos.dbo.ORTT WHERE CAST(RateDate AS DATE) = CAST(GETDATE() AS DATE) and Currency = '" + Combo.SelectedItem.Value + "' "

                Dim Query As String = "SELECT MAX(NAME) FROM Prototipo_Desarrollos.dbo.[@TC_COMERCIAL] WHERE Code = 'Compra' "

                If Combo.SelectedItem.Value = "MXP" Or Combo.SelectedItem.Value = "MXN" Then
                    Precio2.Text = FormatNumber(CDbl(Precio1.Text), 2)
                Else
                    Dim Aux As Double = CDbl(Ws.Query2(Query))
                    If Aux > 0 Then
                        Precio2.Text = FormatNumber(CDbl(Precio1.Text) / Aux, 2)
                    Else
                        'MessageError("", "Capturar tipo de cambio en SAP")
                    End If

                End If



            Next
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error - " + ex.Message)
        End Try
    End Sub

    Protected Sub BtnArtAceptar_Click(sender As Object, e As EventArgs) Handles BtnArtAceptar.Click
        Try

            Dim GranTotal As Double = 0
            Dim Ds As DataTable

            If LblCargoT.Text = "CO" Then
                Ds = LeerGvTabla2()
            Else
                Ds = LeerGvTabla3()
            End If

            For contador As Integer = 0 To GvArticulos.Rows.Count - 1 Step contador + 1
                Dim Revisar As Boolean = CType(GvArticulos.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                If Revisar = True Then
                    Dim Renglon As DataRow = Ds.NewRow()
                    Renglon = Ds.NewRow()

                    Dim Codigo As String = CType(GvArticulos.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text
                    Dim Nombre As String = CType(GvArticulos.Rows(contador).Cells(0).FindControl("LblNombre"), Label).Text
                    Dim UM As String = CType(GvArticulos.Rows(contador).Cells(0).FindControl("LblUM"), Label).Text
                    Dim Cantidad As Double = 1
                    Dim sPrecio As String = CType(GvArticulos.Rows(contador).Cells(0).FindControl("LblPrecio"), Label).Text
                    Dim Moneda As String = CType(GvArticulos.Rows(contador).Cells(0).FindControl("LblMON"), Label).Text

                    Dim Precio As Double

                    If Not (String.IsNullOrEmpty(sPrecio) = True) Then
                        Precio = CDbl(sPrecio)
                    Else
                        Precio = 0
                    End If

                    Dim Total As Double = Cantidad * Precio


                    Renglon("Codigo") = Codigo
                    Renglon("Nombre") = Nombre
                    Renglon("UM") = UM
                    Renglon("Cantidad") = Cantidad
                    Renglon("Precio") = FormatCurrency(Precio)
                    Renglon("Total") = FormatCurrency(Total)
                    Renglon("Moneda") = ""
                    If LblCargoT.Text = "CO" And BuscarCarO(Codigo) = False Then
                        Ds.Rows.Add(Renglon)
                    ElseIf LblCargoT.Text = "CD" And BuscarCarD(Codigo) = False Then
                        Ds.Rows.Add(Renglon)
                    End If

                End If
            Next

            If LblCargoT.Text = "CO" Then
                GvCarOri.DataSource = Ds
                GvCarOri.DataBind()
            Else
                GvCarDes.DataSource = Ds
                GvCarDes.DataBind()
            End If

            'PnlBusCar.Visible = False

            'PnlBusCar.Visible = False

            LlenarComboMoneda()

        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog(ex.Message)
        End Try

        'PnlVisCar.Enabled = True

    End Sub

    Private Sub LlenarComboMoneda()
        Dim Ws As New BXP_WebServiceSQL
        Try
            For contador As Integer = 0 To GvCarOri.Rows.Count - 1 Step contador + 1
                Dim Combo As DropDownList = GvCarOri.Rows(contador).FindControl("DdlMoneda")
                Dim Ds As DataSet = Ws.Query1("Select * From [Prototipo_Desarrollos].[dbo].OCRN order by CurrCode desc")

                Combo.DataSource = Ds
                Combo.DataTextField = "CurrCode"
                Combo.DataBind()

                Dim Precio1 As Label = GvCarOri.Rows(contador).FindControl("LblPrecio")
                Dim Precio2 As TextBox = GvCarOri.Rows(contador).FindControl("TxtPrecio")

                Dim Query As String = "SELECT MAX(NAME) FROM Prototipo_Desarrollos.dbo.[@TC_COMERCIAL] WHERE Code = 'Compra' "

                Precio2.Text = FormatNumber(CDbl(Precio1.Text) / CDbl(Ws.Query2(Query)), 2)

            Next
        Catch ex As Exception

        End Try
        Try
            For contador As Integer = 0 To GvCarDes.Rows.Count - 1 Step contador + 1
                Dim Combo As DropDownList = GvCarDes.Rows(contador).FindControl("DdlMoneda")
                Dim Ds As DataSet = Ws.Query1("Select * From [Prototipo_Desarrollos].[dbo].OCRN order by CurrCode desc")

                Combo.DataSource = Ds
                Combo.DataTextField = "CurrCode"
                Combo.DataBind()

                Dim Precio1 As Label = GvCarDes.Rows(contador).FindControl("LblPrecio")
                Dim Precio2 As TextBox = GvCarDes.Rows(contador).FindControl("TxtPrecio")

                Dim Query As String = "SELECT MAX(NAME) FROM Prototipo_Desarrollos.dbo.[@TC_COMERCIAL] WHERE Code = 'Compra' "

                Precio2.Text = FormatNumber(CDbl(Precio1.Text) / CDbl(Ws.Query2(Query)), 2)

            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Function BuscarCarO(ByVal ItemCode As String) As Boolean
        Dim Ban As Boolean = False
        For contador As Integer = 0 To GvCarOri.Rows.Count - 1 Step contador + 1
            Dim Codigo As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text
            If ItemCode = Codigo Then
                Ban = True
            End If
        Next

        Return Ban

    End Function

    Private Function BuscarCarD(ByVal ItemCode As String) As Boolean
        Dim Ban As Boolean = False
        For contador As Integer = 0 To GvCarDes.Rows.Count - 1 Step contador + 1
            Dim Codigo As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text
            If ItemCode = Codigo Then
                Ban = True
            End If
        Next

        Return Ban

    End Function

    Private Function LeerGvTabla2() As DataTable

        Dim GranTotal As Double = 0
        Dim Ds As DataTable
        Ds = New DataTable

        Ds.Columns.Add("Codigo")
        Ds.Columns.Add("Nombre")
        Ds.Columns.Add("UM")
        Ds.Columns.Add("Cantidad")
        Ds.Columns.Add("Precio")
        Ds.Columns.Add("Total")
        Ds.Columns.Add("Moneda")

        If Not GvCarOri.Rows.Count = 0 Then
            For contador As Integer = 0 To GvCarOri.Rows.Count - 1 Step contador + 1




                Dim Renglon As DataRow = Ds.NewRow()
                Renglon = Ds.NewRow()
                Dim Codigo As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text
                Dim Nombre As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("LblNombre"), Label).Text
                Dim UM As String = ""
                Dim Cantidad As String = "1"
                Dim Precio As String = CType(GvCarOri.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text


                Dim Total As String
                If IsNumeric(Cantidad) Then
                    Total = CStr(CDbl(Cantidad) * CDbl(Precio))
                Else
                    Total = "0.00"
                End If


                GranTotal += Total

                Renglon("Codigo") = Codigo
                Renglon("Nombre") = Nombre
                Renglon("UM") = UM
                Renglon("Cantidad") = Cantidad
                Renglon("Precio") = FormatNumber(Precio, 2)
                Renglon("Total") = FormatNumber(Total, 2)

                'If Bandera = False Then
                Ds.Rows.Add(Renglon)
                'End If


            Next
        End If

        Return Ds

    End Function




    Private Function LeerGvTabla3() As DataTable

        Dim GranTotal As Double = 0
        Dim Ds As DataTable
        Ds = New DataTable

        Ds.Columns.Add("Codigo")
        Ds.Columns.Add("Nombre")
        Ds.Columns.Add("UM")
        Ds.Columns.Add("Cantidad")
        Ds.Columns.Add("Precio")
        Ds.Columns.Add("Total")
        Ds.Columns.Add("Moneda")

        If Not GvCarDes.Rows.Count = 0 Then
            For contador As Integer = 0 To GvCarDes.Rows.Count - 1 Step contador + 1
                Dim Renglon As DataRow = Ds.NewRow()
                Renglon = Ds.NewRow()
                Dim Codigo As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("LblCodigo"), Label).Text
                Dim Nombre As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("LblNombre"), Label).Text
                Dim UM As String = "" 'CType(GvCargosDestino.Rows(contador).Cells(0).FindControl("LblUM"), Label).Text
                Dim Cantidad As String = "1" 'CType(GvCargosDestino.Rows(contador).Cells(0).FindControl("TxtCantidad"), TextBox).Text
                Dim Precio As String = CType(GvCarDes.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                Dim Total As String
                If IsNumeric(Cantidad) Then
                    Total = CStr(CDbl(Cantidad) * CDbl(Precio))
                Else
                    Total = "0.00"
                End If


                GranTotal += Total

                Renglon("Codigo") = Codigo
                Renglon("Nombre") = Nombre
                Renglon("UM") = UM
                Renglon("Cantidad") = Cantidad
                Renglon("Precio") = FormatNumber(Precio, 2)
                Renglon("Total") = FormatNumber(Total, 2)
                Ds.Rows.Add(Renglon)
            Next
        End If

        Return Ds

    End Function



    Private Sub GetCodeNamePol(ByVal sText As String, ByRef sCode As String, ByRef sName As String, ByRef sError As String)

    End Sub

#Region "Catalogos"

    Public Sub GetDdlService()

        Dim Catalogos As New BXP_Catalogos

        Try
            DdlTipoCotizacion.DataSource = Catalogos.GetService
            DdlTipoCotizacion.DataValueField = "Code"
            DdlTipoCotizacion.DataTextField = "Name"
            DdlTipoCotizacion.DataBind()
            DdlTipoCotizacion.Items.Insert(0, "--Seleccione--")
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error GetService - " + ex.Message)
        End Try

    End Sub

    Private Sub GetDdlCurrency()

        Dim Catalogos As New BXP_Catalogos

        Try
            DdlCur.DataSource = Catalogos.GetCurrency
            DdlCur.DataValueField = "CurrCode"
            DdlCur.DataTextField = "CurrCode"
            DdlCur.DataBind()
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error GetService - " + ex.Message)
        End Try

    End Sub

    Private Sub GetDdlIncoterm()

        Dim Catalogos As New BXP_Catalogos

        Try
            DdlIncoterm.DataSource = Catalogos.GetIncoterm
            DdlIncoterm.DataValueField = "Code"
            DdlIncoterm.DataTextField = "Name"
            DdlIncoterm.DataBind()
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error GetService - " + ex.Message)
        End Try

    End Sub

    Private Sub GetDdlTypeService()

        Dim Catalogos As New BXP_Catalogos

        Try
            DdlServ.DataSource = Catalogos.GetTypeService
            DdlServ.DataValueField = "Code"
            DdlServ.DataTextField = "Name"
            DdlServ.DataBind()
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error Get Type Service - " + ex.Message)
        End Try

    End Sub

#End Region

#Region "Catalogos Servicios"

    Private Function GetServiciosBus(ByVal Tabla As String) As DataTable
        Dim Dt As DataTable = Nothing
        Try
            Dim Query As String = "SELECT TOP 10 * FROM Prototipo_Desarrollos.dbo." + Tabla + " WHERE '1'='1' "
            If Not String.IsNullOrEmpty(TxtCodePOL_Country.Value) And Not TxtCodePOL_Country.Value = "*" Then
                Query += "and POL_CODE_COUNTRY = '" + TxtCodePOL_Country.Value + "' "
            End If
            If Not String.IsNullOrEmpty(TxtCodePOD_Country.Value) And Not TxtCodePOD_Country.Value = "*" Then
                Query += "and POD_CODE_COUNTRY = '" + TxtCodePOD_Country.Value + "' "
            End If

            If Not String.IsNullOrEmpty(TextBox11.Text) And Not TextBox11.Text = "*" Then
                Query += "and POL_CODE = '" + TextBox11.Text + "' "
            End If
            If Not String.IsNullOrEmpty(TextBox13.Text) And Not TextBox13.Text = "*" Then
                Query += "and POD_CODE = '" + TextBox13.Text + "' "
            End If
            If Not String.IsNullOrEmpty(TxtFechaDesde.Text) And Not TxtFechaDesde.Text = "*" Then
                Dim FechaDesde As String = CalendarDesde.SelectedDate.ToString("yyyy-MM-dd")
                Query += "and U_Validity_From >= '" + FechaDesde + "' "
            End If
            If Not String.IsNullOrEmpty(TxtFechaAl.Text) And Not TxtFechaAl.Text = "*" Then
                Dim FechaHasta As String = CalendarAl.SelectedDate.ToString("yyyy-MM-dd")
                Query += "and U_Validity_To <= '" + FechaHasta + "' "
            End If

            Dim Log As New BXP_Log
            Log.EventLog("query - " + Query)

            Dim WebSer As New BXP_WebServiceSQL
            Dt = WebSer.Query1(Query).Tables(0)

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar LlenarMaritimo - " + ex.Message)
        End Try
        Return Dt
    End Function

#End Region


#Region "Buscadores de servicios"

    Private Sub GetService()

        If LblAddBan.Text = "1" Then
            If LblVTipo.Text = "1" Then             'AEREO                                      'AIR
                GetAir()
            ElseIf LblVTipo.Text = "2" Then         'ARRASTRE                                   'CONTAINER HAULAGE
                GetCH()
            ElseIf LblVTipo.Text = "3" Then         'ARRASTRE BL                                'CONTAINER CARRIAGE
                GetCC()
            ElseIf LblVTipo.Text = "4" Then         'INTERMODAL                                 'INTERMODAL
                GetIntermodal()
            ElseIf LblVTipo.Text = "5" Then         'MARITIMO COMPLETO                          'FULL CONTAINER LOAD
                GetFCL()
            ElseIf LblVTipo.Text = "6" Then         'NO EXISTE
                'AddArrastre()
            ElseIf LblVTipo.Text = "7" Then         'TERRESTRE AMERICANO                        'TRUCK LOAD USA
                GetTLU()
            ElseIf LblVTipo.Text = "8" Then         'TERRESTRE NACIONAL                         'TRUCK LOAD MEXICO
                GetTLM()
            ElseIf LblVTipo.Text = "9" Then         'MARITIMO LCL                               'LESS CONTAINER LOAD
                GetLCL()
            ElseIf LblVTipo.Text = "10" Then        'TERRESTRE AMERICANO O NACIONAL LTL         'LESS TRUCK LOAD
                GetLTL()
            End If

        Else
            If LblVTipoS.Text = "1" Then             'AEREO                                      'AIR
                GetAir()
            ElseIf LblVTipoS.Text = "2" Then         'ARRASTRE                                   'CONTAINER HAULAGE
                GetCH()
            ElseIf LblVTipoS.Text = "3" Then         'ARRASTRE BL                                'CONTAINER CARRIAGE
                GetCC()
            ElseIf LblVTipoS.Text = "4" Then         'INTERMODAL                                 'INTERMODAL
                GetIntermodal()
            ElseIf LblVTipoS.Text = "5" Then         'MARITIMO COMPLETO                          'FULL CONTAINER LOAD
                GetFCL()
            ElseIf LblVTipoS.Text = "6" Then         'NO EXISTE
                'AddArrastre()
            ElseIf LblVTipoS.Text = "7" Then         'TERRESTRE AMERICANO                        'TRUCK LOAD USA
                GetTLU()
            ElseIf LblVTipoS.Text = "8" Then         'TERRESTRE NACIONAL                         'TRUCK LOAD MEXICO
                GetTLM()
            ElseIf LblVTipoS.Text = "9" Then         'MARITIMO LCL                               'LESS CONTAINER LOAD
                GetLCL()
            ElseIf LblVTipoS.Text = "10" Then        'TERRESTRE AMERICANO O NACIONAL LTL         'LESS TRUCK LOAD
                GetLTL()
            End If

        End If

    End Sub

    Private Sub GetAir()
        Try
            Lbl_Error_AddSer.Text = ""
            Dim Dt As DataTable = GetServiciosBus("BXP_Aereo")

            If Dt.Rows.Count > 0 Then
                GvBusAer.DataSource = Dt
                GvBusAer.DataBind()
            Else
                GvBusAer.DataSource = Nothing
                GvBusAer.DataBind()
                Lbl_Error_AddSer.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Aereo - " + ex.Message)
        End Try
    End Sub

    Private Sub GetCH()
        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_Arrastres")

            If Dt.Rows.Count > 0 Then
                GvBusArr.DataSource = Dt
                GvBusArr.DataBind()
            Else
                GvBusArr.DataSource = Nothing
                GvBusArr.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Arrastre - " + ex.Message)
        End Try
    End Sub

    Private Sub GetCC()
        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_ArrastresBL")

            If Dt.Rows.Count > 0 Then
                GvBusArB.DataSource = Dt
                GvBusArB.DataBind()
            Else
                GvBusArB.DataSource = Nothing
                GvBusArB.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Arrastre BL - " + ex.Message)
        End Try
    End Sub

    Private Sub GetFCL()
        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_Maritimo")

            If Dt.Rows.Count > 0 Then
                GvBusMar.DataSource = Dt
                GvBusMar.DataBind()
            Else
                GvBusMar.DataSource = Nothing
                GvBusMar.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Maritimo completo - " + ex.Message)
        End Try
    End Sub

    Private Sub GetIntermodal()
        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_LTL_INTER")

            If Dt.Rows.Count > 0 Then
                GvBusInt.DataSource = Dt
                GvBusInt.DataBind()
            Else
                GvBusInt.DataSource = Nothing
                GvBusInt.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Intermodal - " + ex.Message)
        End Try
    End Sub

    Private Sub GetLCL()

        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_MaritimoLCL")

            If Dt.Rows.Count > 0 Then
                GvBusMarLCL.DataSource = Dt
                GvBusMarLCL.DataBind()
            Else
                GvBusMarLCL.DataSource = Nothing
                GvBusMarLCL.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Maritimo LCL - " + ex.Message)
        End Try

    End Sub

    Private Sub GetLTL()

        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_LTL_AM_NA")

            If Dt.Rows.Count > 0 Then
                GvBusLTL.DataSource = Dt
                GvBusLTL.DataBind()
            Else
                GvBusLTL.DataSource = Nothing
                GvBusLTL.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Maritimo LCL - " + ex.Message)
        End Try

    End Sub

    Private Sub GetTLM()
        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_LTL_AM_NA")

            If Dt.Rows.Count > 0 Then
                GvBusTer.DataSource = Dt
                GvBusTer.DataBind()
            Else
                GvBusTer.DataSource = Nothing
                GvBusTer.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Maritimo LTL - " + ex.Message)
        End Try

    End Sub

    Private Sub GetTLU()
        Try
            Dim Dt As DataTable = GetServiciosBus("BXP_TerrAmericano")

            If Dt.Rows.Count > 0 Then
                GvBusTerA.DataSource = Dt
                GvBusTerA.DataBind()
            Else
                GvBusTerA.DataSource = Nothing
                GvBusTerA.DataBind()
                LblAddTitulo.Text = "No hay tarifas disponibles"
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar Maritimo TLML - " + ex.Message)
        End Try
    End Sub

#End Region

#Region "GetTable Solicitud a Prising"

    Function GetTableTarifarioLTLAmericanoNacional() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("CARRIER", GetType(String))
        table.Columns.Add("ORIGIN", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POL_ZIPCODE", GetType(String))
        table.Columns.Add("DESTINATION", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("POD_ZIPCODE", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("QUANTITY", GetType(String))
        table.Columns.Add("TYPE", GetType(String))
        table.Columns.Add("FREIGHT INFO", GetType(String))
        table.Columns.Add("WEIGHT", GetType(String))
        table.Columns.Add("LARGE", GetType(String))
        table.Columns.Add("WIDTH", GetType(String))
        table.Columns.Add("HEIGHT", GetType(String))
        table.Columns.Add("STACKABLE", GetType(String))
        table.Columns.Add("TOTAL", GetType(String))
        table.Columns.Add("CROSSBORDER", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("VOLUME", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NO SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))

        Dim comentarios As String
        comentarios = remarks2.Text

        If measures.Text <> "" Then
            comentarios &= vbLf & "MEASURES: " & measures.Text
        End If
        If packing.Text <> "" Then
            comentarios &= vbLf & "PACKING: " & packing.Text
        End If
        If stops.Text <> "" Then
            comentarios &= vbLf & "STOPS: " & stops.Text
        End If

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(carrier2.Text, origin1.Text, polcode2.Text, pol2.Text, polcountrycode1.Value, polcountry1.Text, polzipcode1.Text, destination1.Text, podcode2.Text, pod2.Text, podcodecountry1.Value, podcountry1.Text, pod_zipcode1.Text,
                       currency.Text, quantity.Text, type.Text, "", weight.Text, "", "", "", stackable.Text, "", "", commodity2.Text, "", "", "", "", volume.Text, "", "", comentarios)
        Return table
    End Function

    Function GetTableTarifarioLTLIntermodal() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("CARRIER", GetType(String))
        table.Columns.Add("ORIGIN", GetType(String))
        table.Columns.Add("ORIGIN RAMP", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POL_ZIPCODE", GetType(String))
        table.Columns.Add("ROUTE", GetType(String))
        table.Columns.Add("MODE CODE", GetType(String))
        table.Columns.Add("DESTINATION", GetType(String))
        table.Columns.Add("DESTINATION RAMP", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("POD_ZIPCODE", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("SUB TOTAL", GetType(String))
        table.Columns.Add("FSC", GetType(String))
        table.Columns.Add("FSC total", GetType(String))
        table.Columns.Add("TOTAL US", GetType(String))
        table.Columns.Add("EQUIPMENT", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("VOLUME", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NO SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))

        Dim comentarios As String
        comentarios = remarks3.Text

        If un1.Text <> "" Then
            comentarios &= vbLf & "UN: " & un1.Text
        End If
        If class1.Text <> "" Then
            comentarios &= vbLf & "CLASS: " & class1.Text
        End If
        If weight2.Text <> "" Then
            comentarios &= vbLf & "WEIGHT: " & weight2.Text
        End If
        If measures5.Text <> "" Then
            comentarios &= vbLf & "MEASURES: " & measures5.Text
        End If
        If stackable5.Text <> "" Then
            comentarios &= vbLf & "STACKABLE: " & stackable5.Text
        End If
        If packing5.Text <> "" Then
            comentarios &= vbLf & "PACKING: " & packing5.Text
        End If

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(carrier3.Text, origin2.Text, originramp.Text, polcode3.Text, pol3.Text, polcountrycode3.Value, polcountry3.Text, pol_zipcode2.Text, "", "", destination2.Text, destinationramp.Text,
                       podcode3.Text, pod3.Text, podcodecountry2.Value, podcountry2.Text, pod_zipcode2.Text, currency1.Text, "", "", "", "", equipment1.Text, "", "", "", commodity3.Text, "", "", "", "",
                       comentarios)

        Return table
    End Function

    Function GetTableTarifarioMaritimoCompleto() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("AGENT", GetType(String))
        table.Columns.Add("CARRIER", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("VÍA 1", GetType(String))
        table.Columns.Add("VÍA 2", GetType(String))
        table.Columns.Add("VIA 3", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("20'GP", GetType(String))
        table.Columns.Add("40'GP", GetType(String))
        table.Columns.Add("40'HQ", GetType(String))
        table.Columns.Add("EQUIPMENT", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("FREE DAYS AT POD", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("UN", GetType(String))
        table.Columns.Add("IMO SURCHARGE", GetType(String))
        table.Columns.Add("RA", GetType(String))
        table.Columns.Add("COMMITMENT TEUS", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NOT SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))

        Dim comentarios As String
        comentarios = remarks1.Text

        If un.Text <> "" Then
            comentarios &= vbLf & "UN: " & un.Text
        End If
        If class7.Text <> "" Then
            comentarios &= vbLf & "CLASS: " & class7.Text
        End If
        If cargoweight.Text <> "" Then
            comentarios &= vbLf & "WEIGHT: " & cargoweight.Text
        End If
        If incoterm.Text <> "" Then
            comentarios &= vbLf & "INCOTERM: " & incoterm.Text
        End If
        If packing1.Text <> "" Then
            comentarios &= vbLf & "PACKING: " & packing1.Text
        End If
        If number.Text <> "" Then
            comentarios &= vbLf & "NUMBER: " & number.Text
        End If
        If measures1.Text <> "" Then
            comentarios &= vbLf & "MEASURES: " & measures1.Text
        End If
        If stackable1.Text <> "" Then
            comentarios &= vbLf & "STACKABLE: " & stackable1.Text
        End If

        table.Rows.Add("", carrier1.Text, polcode1.Text, pol1.Text, polcode1.Text.Substring(0, 3), namepolcountry.Text, podcode1.Text, pod1.Text, podcode1.Text.Substring(0, 3), namepodcountry.Text, "", "", "", "", "", "", "",
                       equipment.Text, "", "", "", "", "", commodity1.Text, un.Text, "", "", "", "", "", comentarios)

        ' Add five rows with those columns filled in the DataTable.

        Return table
    End Function

    Function GetTableTarifarioMaritimoLCL() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("CO-LOADER", GetType(String))
        table.Columns.Add("AGENT", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("VÍA 1", GetType(String))
        table.Columns.Add("VÍA 2", GetType(String))
        table.Columns.Add("VIA 3", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("COST", GetType(String))
        table.Columns.Add("MINIMUM COST", GetType(String))
        table.Columns.Add("FREQUENCY", GetType(String))
        table.Columns.Add("EQUIPMENT", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_TO", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("FREE STORAGES DAYS", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("RA", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("ADMON FEE", GetType(String))
        table.Columns.Add("BL", GetType(String))
        table.Columns.Add("PORT TRANSFER FEE W/M", GetType(String))
        table.Columns.Add("STUFFING W/M", GetType(String))
        table.Columns.Add("VGM/SOLAS", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NOT SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))

        Dim comentarios As String
        comentarios = remarks4.Text

        If un2.Text <> "" Then
            comentarios &= vbLf & "UN: " & un2.Text
        End If
        If class2.Text <> "" Then
            comentarios &= vbLf & "CLASS: " & class2.Text
        End If
        If weight3.Text <> "" Then
            comentarios &= vbLf & "WEIGHT: " & weight3.Text
        End If
        If incoterm1.Text <> "" Then
            comentarios &= vbLf & "INCOTERM: " & incoterm1.Text
        End If
        If packing2.Text <> "" Then
            comentarios &= vbLf & "PACKING: " & packing2.Text
        End If
        If number2.Text <> "" Then
            comentarios &= vbLf & "NUMBER: " & number2.Text
        End If
        If measures2.Text <> "" Then
            comentarios &= vbLf & "MEASURES: " & measures2.Text
        End If
        If stackable2.Text <> "" Then
            comentarios &= vbLf & "STACKABLE: " & stackable2.Text
        End If

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(coloader.Text, "", polcode4.Text, pol4.Text, polcountrycode4.Value, polcountry4.Text, podcode4.Text, pod4.Text, podcountrycode4.Value, podcountry4.Text, via1.Text, via2.Text, via3.Text, currency2.Text, cost.Text,
                               minimumcost.Text, "", equipment2.Text, "", "", "", "", "", "", commodity4.Text, "", bl.Text, "", "", "", "", "", comentarios)

        Return table
    End Function

    Function GetTableTerrestreNacional() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("CARRIER", GetType(String))
        table.Columns.Add("ORIGIN", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POL_ZIPCODE", GetType(String))
        table.Columns.Add("DESTINATION", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("POD_ZIPCODE", GetType(String))
        table.Columns.Add("STOP 1", GetType(String))
        table.Columns.Add("STOP 2", GetType(String))
        table.Columns.Add("STOP 3", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("TOTAL RATE", GetType(String))
        table.Columns.Add("KM", GetType(String))
        table.Columns.Add("FSC", GetType(String))
        table.Columns.Add("FSC TOTAL", GetType(String))
        table.Columns.Add("EQUIPMENT", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("FREE DAYS AT THE BORDER", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("VOLUME", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NO SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))
        table.Columns.Add("FREE HOUS LOADING AND UNLOADING", GetType(String))

        Dim comentarios As String
        comentarios = remarks5.Text

        If un3.Text <> "" Then
            comentarios &= vbLf & "UN: " & un3.Text
        End If
        If class3.Text <> "" Then
            comentarios &= vbLf & "CLASS: " & class3.Text
        End If
        If weight4.Text <> "" Then
            comentarios &= vbLf & "WEIGHT: " & weight4.Text
        End If
        If measures3.Text <> "" Then
            comentarios &= vbLf & "MEASURES: " & measures3.Text
        End If
        If stackable3.Text <> "" Then
            comentarios &= vbLf & "STACKABLE: " & stackable3.Text
        End If
        If packing3.Text <> "" Then
            comentarios &= vbLf & "PACKING: " & packing3.Text
        End If


        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(carrier4.Text, origin3.Text, polcode5.Text, pol5.Text, polcountrycode5.Value, polcountry5.Text, pol_zipcode3.Text, destination3.Text, podcode5.Text, pod5.Text, podcountrycode5.Value, podcountry5.Text,
                       pod_zipcode3.Text, stop1.Text, stop2.Text, stop3.Text, currency3.Text, "", "", "", "", equipment3.Text, "", "", "", "", commodity5.Text, "", "", "", "", comentarios, "")

        Return table
    End Function




    Function GetTableTarifarioAereoLCL11() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("AGENT", GetType(String))
        table.Columns.Add("AEROLINEA", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("VíA 1", GetType(String))
        table.Columns.Add("VíA 2", GetType(String))
        table.Columns.Add("VIA 3", GetType(String))
        table.Columns.Add("VIA 4", GetType(String))
        table.Columns.Add("VIA 5", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("MIN", GetType(String))
        table.Columns.Add("<45KG", GetType(String))
        table.Columns.Add(">45KG", GetType(String))
        table.Columns.Add(">100KG", GetType(String))
        table.Columns.Add(">300KG", GetType(String))
        table.Columns.Add(">500KG", GetType(String))
        table.Columns.Add(">1000KG", GetType(String))
        table.Columns.Add("FSC/KG", GetType(String))
        table.Columns.Add("SSC/KG", GetType(String))
        table.Columns.Add("TAX_KG", GetType(String))
        table.Columns.Add("HAWB", GetType(String))
        table.Columns.Add("AIRLINE_HANDLING_KG", GetType(String))
        table.Columns.Add("ROUTING MODE", GetType(String))
        table.Columns.Add("FREQUENCY", GetType(String))
        table.Columns.Add("AIRCRAFT", GetType(String))
        table.Columns.Add("MAXDimensionsXPZA", GetType(String))
        table.Columns.Add("MAXWeightXPZA", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("RA", GetType(String))
        table.Columns.Add("COMMITMENT VOLUME", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NOT SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))

        Dim comentarios As String
        comentarios = remarks7.Text

        If un4.Text <> "" Then
            comentarios &= vbLf & "UN: " & un4.Text
        End If
        If class4.Text <> "" Then
            comentarios &= vbLf & "CLASS: " & class4.Text
        End If
        If packing4.Text <> "" Then
            comentarios &= vbLf & "PACKING: " & packing4.Text
        End If
        If number3.Text <> "" Then
            comentarios &= vbLf & "NUMBER PKG: " & number3.Text
        End If
        If weight5.Text <> "" Then
            comentarios &= vbLf & "WEIGHT PKG: " & weight5.Text
        End If
        If measures4.Text <> "" Then
            comentarios &= vbLf & "MEASURES PKG: " & measures4.Text
        End If
        If stackable4.Text <> "" Then
            comentarios &= vbLf & "STACKABLE: " & stackable4.Text
        End If
        If incoterm2.Text <> "" Then
            comentarios &= vbLf & "INCOTERM: " & incoterm2.Text
        End If
        If urgent.Text <> "" Then
            comentarios &= vbLf & "URGENT: " & urgent.Text
        End If


        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add("", "", polcode7.Text, pol7.Text, polcountrycode7.Value, polcountry7.Text, podcode7.Text, pod7.Text, podcountrycode7.Value, podcountry7.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                       "", "", "", "", "", "", "", "", "", "", commodity7.Text, "", "", "", "", comentarios)

        Return table
    End Function


    Function GetTableTarifarioArrastreBL() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("AGENT", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POL_ZIPCODE", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("POD_ZIPCODE", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("20'GP", GetType(String))
        table.Columns.Add("40'GP", GetType(String))
        table.Columns.Add("40'HQ", GetType(String))
        table.Columns.Add("EQUIPMENT", GetType(String))
        table.Columns.Add("MODE", GetType(String))
        table.Columns.Add("SINGLE", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("UN", GetType(String))
        table.Columns.Add("RA", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NOT SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))

        Dim comentarios As String
        comentarios = remarks8.Text

        If un5.Text <> "" Then
            comentarios &= vbLf & "UN: " & un5.Text
        End If
        If class5.Text <> "" Then
            comentarios &= vbLf & "CLASS: " & class5.Text
        End If
        If weight6.Text <> "" Then
            comentarios &= vbLf & "WEIGHT: " & weight6.Text
        End If

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add("", polcode8.Text, pol8.Text, polcountrycode8.Value, polcountry8.Text, pol_zipcode4.Text, podcode8.Text, pod8.Text, podcountrycode8.Value, podcountry8.Text, pod_zipcode4.Text, currency5.Text, veintegp.Text, cuarentagp.Text,
                       cuarentahq2.Text, equipment4.Text, mode.Text, singlefull.Text, "", "", "", commodity8.Text, un5.Text, "", "", "", comentarios)

        Return table
    End Function

    Function GetTableTarifarioAmericano() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("CARRIER", GetType(String))
        table.Columns.Add("ORIGIN", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POL_ZIPCODE", GetType(String))
        table.Columns.Add("DESTINATION", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("POD_ZIPCODE", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("MILES", GetType(String))
        table.Columns.Add("RPM", GetType(String))
        table.Columns.Add("SUB TOTAL", GetType(String))
        table.Columns.Add("FSC", GetType(String))
        table.Columns.Add("TOTAL US", GetType(String))
        table.Columns.Add("EQUIPMENT", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("FREE DAY AT THE BORDER", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("VOLUME", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NO SUBJECT TO", GetType(String))
        table.Columns.Add("REMARKS", GetType(String))

        Dim comentarios As String
        comentarios = remarks9.Text

        If directtranshipment.Text <> "" Then
            comentarios &= vbLf & "DIRECT/TRANSHIPMENT: " & directtranshipment.Text
        End If
        If un6.Text <> "" Then
            comentarios &= vbLf & "UN: " & un6.Text
        End If
        If class6.Text <> "" Then
            comentarios &= vbLf & "CLASS: " & class6.Text
        End If
        If weight7.Text <> "" Then
            comentarios &= vbLf & "TOTAL WEIGHT: " & weight7.Text
        End If

        ' Add five rows with those columns filled in the DataTable.
        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(carrier6.Text, origin4.Text, polcode9.Text, pol9.Text, polcountrycode9.Value, polcountry9.Text, pol_zipcode5.Text, destination4.Text, podcode9.Text, pod9.Text, podcountrycode9.Value, podcountry9.Text,
                       pod_zipcode5.Text, currency6.Text, "", "", "", "", "", equipment5.Text, "", "", "", "", commodity9.Text, "", volume3.Text, "", "", comentarios)

        Return table
    End Function

    Function GetTableTarifarioArrastres() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("CARRIER", GetType(String))
        table.Columns.Add("ORIGIN", GetType(String))
        table.Columns.Add("POL_CODE", GetType(String))
        table.Columns.Add("POL", GetType(String))
        table.Columns.Add("POL_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POL_COUNTRY", GetType(String))
        table.Columns.Add("POL_ZIPCODE", GetType(String))
        table.Columns.Add("DESTINATION", GetType(String))
        table.Columns.Add("POD_CODE", GetType(String))
        table.Columns.Add("POD", GetType(String))
        table.Columns.Add("POD_CODE_COUNTRY", GetType(String))
        table.Columns.Add("POD_COUNTRY", GetType(String))
        table.Columns.Add("POD_ZIPCODE", GetType(String))
        table.Columns.Add("SERVICE", GetType(String))
        table.Columns.Add("CURRENCY", GetType(String))
        table.Columns.Add("TOTAL RATE SINGLE", GetType(String))
        table.Columns.Add("TOTAL RATE TANDEM", GetType(String))
        table.Columns.Add("SINGLE", GetType(String))
        table.Columns.Add("TOLLS SINGLE", GetType(String))
        table.Columns.Add("TANDEM", GetType(String))
        table.Columns.Add("TOLLS TANDEM", GetType(String))
        table.Columns.Add("EQUIPMENT", GetType(String))
        table.Columns.Add("Validity_From", GetType(String))
        table.Columns.Add("Validity_To", GetType(String))
        table.Columns.Add("TT", GetType(String))
        table.Columns.Add("SINGLE WEIGHT", GetType(String))
        table.Columns.Add("TANDEM WEIGHT", GetType(String))
        table.Columns.Add("FREE HOURS TO UNLOAD", GetType(String))
        table.Columns.Add("COMMODITY", GetType(String))
        table.Columns.Add("NAC", GetType(String))
        table.Columns.Add("VOLUME", GetType(String))
        table.Columns.Add("SUBJECT TO", GetType(String))
        table.Columns.Add("NO SUBJECT TO", GetType(String))
        table.Columns.Add("REMARS", GetType(String))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(carrier7.Text, origin5.Text, polcode10.Text, pol10.Text, polcountrycode10.Value, polcountry10.Text, pol_zipcode6.Text, destination5.Text, idpod10.Text, pod10.Text, podcountrycode10.Value, podcountry10.Text,
                       pod_zipcode6.Text, service.Text, currency7.Text, "", "", "", "", "", "", equipment6.Text, "", "", "", singleweight.Text, tandemweight.Text, "",
                       commodity10.Text, "", volume2.Text, "", "", remarks10.Text)

        Return table
    End Function

#End Region

    Protected Sub TxtPOL_Country_TextChanged(sender As Object, e As EventArgs) Handles TxtPOL_Country.TextChanged
        If String.IsNullOrEmpty(TxtPOL_Country.Text) Or TxtPOL_Country.Text = "*" Then
            TxtCodePOL_Country.Value = ""
        End If

        CodigoPol()

        GetService()

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)

        If TextBox10.Text <> "" Then
            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                If DdlTipoCotizacion.SelectedItem.Value = "AIR" Then
                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + TextBox11.Text.ToString + "' "
                Else
                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + TextBox11.Text.ToString + "' "
                End If

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        If TxtPOL_Country.Text <> row("Name").ToString Then
                            TextBox10.Text = ""
                        End If
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log
            End Try

        End If

        TextBox10.Focus()
    End Sub


    Protected Sub TxtPOD_Country_TextChanged(sender As Object, e As EventArgs) Handles TxtPOD_Country.TextChanged
        If String.IsNullOrEmpty(TxtPOD_Country.Text) Or TxtPOD_Country.Text = "*" Then
            TxtCodePOD_Country.Value = ""
        End If

        CodigoPoD()

        GetService()

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)

        If TextBox12.Text <> "" Then
            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                If DdlTipoCotizacion.SelectedItem.Value = "AIR" Then
                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + TextBox13.Text.ToString + "' "
                Else
                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + TextBox13.Text.ToString + "' "
                End If

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        If TxtPOD_Country.Text <> row("Name").ToString Then
                            TextBox12.Text = ""
                        End If
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log
            End Try

        End If

        TextBox12.Focus()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim QueryCorreo As String = "Select email, U_PassCorreo From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + ReadCookie("Usuario", "Usuario") + "' "

        Dim WebSer As New BXP_WebServiceSQL

        Dim Ds As DataTable = WebSer.Query1(QueryCorreo).Tables(0)

        'Dim valtipotarifario As String

        'valtipotarifario = tipotarifario.Value

        Try
            If LblVTipo.Text = "5" Then

                GuardarPricing()

                GenerateExcel(GetTableTarifarioMaritimoCompleto, NombreHojaExcel("5"), LblIdPricing.Text, "FULLCONTAINERLOAD")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^FULLCONTAINERLOAD.xlsx", "C:/Doc/" + LblIdPricing.Text + "^FULLCONTAINERLOAD.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^FULLCONTAINERLOAD.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "10" Then

                GuardarPricing()

                GenerateExcel(GetTableTarifarioLTLAmericanoNacional, NombreHojaExcel("10"), LblIdPricing.Text, "LESSTRUCKLOAD")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^LESSTRUCKLOAD.xlsx", "C:/Doc/" + LblIdPricing.Text + "^LESSTRUCKLOAD.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^LESSTRUCKLOAD.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "4" Then

                GuardarPricing()

                GenerateExcel(GetTableTarifarioLTLIntermodal, NombreHojaExcel("4"), LblIdPricing.Text, "INTERMODAL")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^INTERMODAL.xlsx", "C:/Doc/" + LblIdPricing.Text + "^INTERMODAL.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^INTERMODAL.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "9" Then

                GuardarPricing()

                GenerateExcel(GetTableTarifarioMaritimoLCL, NombreHojaExcel("9"), LblIdPricing.Text, "LESSCONTAINERLOAD")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^LESSCONTAINERLOAD.xlsx", "C:/Doc/" + LblIdPricing.Text + "^LESSCONTAINERLOAD.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^LESSCONTAINERLOAD.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "8" Then

                GuardarPricing()

                GenerateExcel(GetTableTerrestreNacional, NombreHojaExcel("8"), LblIdPricing.Text, "TRUCKLOADMEXICO")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^TRUCKLOADMEXICO.xlsx", "C:/Doc/" + LblIdPricing.Text + "^TRUCKLOADMEXICO.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^TRUCKLOADMEXICO.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "1" Then

                GuardarPricing()

                'Dim QueryCorreo As String = "Select email, U_PassCorreo From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + ReadCookie("Usuario", "Usuario") + "' "

                'Dim WebSer As New BXP_WebServiceSQL

                'Dim Ds As DataTable = WebSer.Query1(QueryCorreo).Tables(0)

                GenerateExcel(GetTableTarifarioAereoLCL11(), NombreHojaExcel("1"), LblIdPricing.Text, "AIR")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                'Dim Correo As New BXP_SendMail("hsenties1@gmail.com", "jazmin", "smtp.gmail.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^AIR.xlsx", "C:/Doc/" + LblIdPricing.Text + "^AIR.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^AIR.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "3" Then

                GuardarPricing()

                GenerateExcel(GetTableTarifarioArrastreBL(), NombreHojaExcel("3"), LblIdPricing.Text, "CONTAINERCARRIAGE")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^CONTAINERCARRIAGE.xlsx", "C:/Doc/" + LblIdPricing.Text + "^CONTAINERCARRIAGE.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^CONTAINERCARRIAGE.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "7" Then

                GuardarPricing()

                GenerateExcel(GetTableTarifarioAmericano, NombreHojaExcel("7"), LblIdPricing.Text, "TRUCKLOADUSA")

                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^TRUCKLOADUSA.xlsx", "C:/Doc/" + LblIdPricing.Text + "^TRUCKLOADUSA.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^TRUCKLOADUSA.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"
                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            ElseIf LblVTipo.Text = "2" Then

                GuardarPricing()

                GenerateExcel(GetTableTarifarioArrastres(), NombreHojaExcel("2"), LblIdPricing.Text, "CONTAINERHAULAGE")


                Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
                Correo.SendMail2("gramon@bexap.com, hsentiel@bexap.com, cpernet@crossmotion.com.mx", "Pruebas ", "Prueba", LblIdPricing.Text + "^CONTAINERHAULAGE.xlsx", "C:/Doc/" + LblIdPricing.Text + "^CONTAINERHAULAGE.xlsx")
                Dim Common As New BXP_Common
                Common.DeleteFile("C:/Doc/" + LblIdPricing.Text + "^CONTAINERHAULAGE.xlsx")

                DivSuccessPricing.Visible = True
                LblSuccessPricing.Text = "Se envió la solicitud a pricing"

                Dim script As String = "alert('Se envió la solicitud a pricing'); window.location.href='BXP_Cotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            Else

                Dim script As String = "Mensaje();"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "aviso", script, True)

            End If

        Catch ex As Exception

        End Try



    End Sub


    Protected Sub BtnOAir_Click(sender As Object, e As EventArgs) Handles BtnOAir.Click
        LblVTipoS.Text = "1"

        PNLGVSerAer.Visible = True
        GVSerAer.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOArr_Click(sender As Object, e As EventArgs) Handles BtnOArr.Click
        LblVTipoS.Text = "2"

        PNLGVSerArr.Visible = True
        GVSerArr.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOArB_Click(sender As Object, e As EventArgs) Handles BtnOArB.Click
        LblVTipoS.Text = "3"

        PNLGVSerArB.Visible = True
        GVSerArB.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOFCL_Click(sender As Object, e As EventArgs) Handles BtnOFCL.Click
        LblVTipoS.Text = "5"

        PNLGVSerMar.Visible = True
        GVSerMar.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOInt_Click(sender As Object, e As EventArgs) Handles BtnOInt.Click
        LblVTipoS.Text = "4"

        PNLGVSerMar.Visible = True
        GVSerMar.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOLCL_Click(sender As Object, e As EventArgs) Handles BtnOLCL.Click
        LblVTipoS.Text = "9"

        PNLGVSerMar.Visible = True
        GVSerMar.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOLTL_Click(sender As Object, e As EventArgs) Handles BtnOLTL.Click
        LblVTipoS.Text = "10"

        PNLGVSerMar.Visible = True
        GVSerMar.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOTLM_Click(sender As Object, e As EventArgs) Handles BtnOTLM.Click
        LblVTipoS.Text = "8"

        PNLGVSerMar.Visible = True
        GVSerMar.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub

    Protected Sub BtnOTLU_Click(sender As Object, e As EventArgs) Handles BtnOTLU.Click
        LblVTipoS.Text = "7"

        PNLGVSerMar.Visible = True
        GVSerMar.Visible = True

        LblId.Text = ""
        LimpiarBuscarServicios()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal();", True)
    End Sub


    Private Sub LimpiarBuscarServicios()
        TxtPOD_Country.Text = ""
        TxtPOL_Country.Text = ""

        TxtCodePOD_Country.Value = ""
        TxtCodePOL_Country.Value = ""

        TextBox10.Text = ""
        TextBox11.Text = ""

        TextBox12.Text = ""
        TextBox13.Text = ""

        GvBusAer.DataSource = Nothing
        GvBusAer.DataBind()

        GvBusArr.DataSource = Nothing
        GvBusArr.DataBind()

        GvBusArB.DataSource = Nothing
        GvBusArB.DataBind()

        GvBusInt.DataSource = Nothing
        GvBusInt.DataBind()

        GvBusMar.DataSource = Nothing
        GvBusMar.DataBind()

        GvBusMarLCL.DataSource = Nothing
        GvBusMarLCL.DataBind()

        GvBusMul.DataSource = Nothing
        GvBusMul.DataBind()

        GvBusTer.DataSource = Nothing
        GvBusTer.DataBind()

        GvBusTerA.DataSource = Nothing
        GvBusTerA.DataBind()

        GvBusLTL.DataSource = Nothing
        GvBusLTL.DataBind()
    End Sub

    Private Function GetFolioCross() As String
        Dim Ws As New BXP_WebServiceSQL
        Dim FechaCod As String = Now.ToShortDateString
        Dim DsDatos As DataTable = Nothing
        Dim Origen As String = ""
        Dim Destino As String = ""

        Try

            If LblVTipo.Text = "1" Then
                If GVSerAer.Rows.Count > 0 Then
                    Origen = CType(GvBusAer.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusAer.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "2" Then
                If GVSerArr.Rows.Count > 0 Then
                    Origen = CType(GvBusArr.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusArr.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "3" Then
                If GVSerArB.Rows.Count > 0 Then
                    Origen = CType(GvBusArB.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusArB.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "4" Then
                If GVSerMar.Rows.Count > 0 Then
                    Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "5" Then
                If GVSerAer.Rows.Count > 0 Then
                    Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "6" Then
                If GVSerAer.Rows.Count > 0 Then
                    Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "7" Then
                If GVSerAer.Rows.Count > 0 Then
                    Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "8" Then
                If GVSerAer.Rows.Count > 0 Then
                    Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "9" Then
                If GVSerAer.Rows.Count > 0 Then
                    Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            ElseIf LblVTipo.Text = "10" Then
                If GVSerAer.Rows.Count > 0 Then
                    Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                End If
            End If

            Dim MT As String = DdlTipoCotizacion.SelectedItem.Value

            DsDatos = Ws.Query1(QuerySucursal).Tables(0)

            Dim Requesitor As String = DsDatos.Rows(0).Item(0)
            Dim Oficina As String = DsDatos.Rows(0).Item(1)

            TxtFolio.Text = MT + Origen + Destino + Replace(FechaCod, "/", "") + Requesitor + Oficina

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al generar FolioCross - " + ex.Message)
        End Try

        Return TxtFolio.Text

    End Function

    Private Function QuerySucursal() As String
        Dim QueryDatos As String = "SELECT SUBSTRING(T0.firstName,1,1) + SUBSTRING(T0.lastName,1,1) As Nombre, case when T0.branch is null then ' ' else T1.Name end U_CLAVE_SUCURSAL "
        QueryDatos += "FROM Prototipo_Desarrollos.dbo.OHEM T0 LEFT JOIN Prototipo_Desarrollos.dbo.OUBR T1 ON T0.branch = t1.Code "
        QueryDatos += "WHERE T0.U_usuario = '" + ReadCookie("Usuario", "Usuario") + "' "

        'QueryDatos = "SELECT 'LLL' Nombre, 'BJI' U_CLAVE_SUCURSAL"

        Return QueryDatos

    End Function

    Private Function GetImpoExpo() As String
        Dim Origen As String = ""
        Dim Destino As String = ""

        Dim ImpoExpo As String = ""

        If LblVTipo.Text = "1" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusAer.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusAer.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "2" Then
            If GVSerArr.Rows.Count > 0 Then
                Origen = CType(GvBusArr.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusArr.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "3" Then
            If GVSerArB.Rows.Count > 0 Then
                Origen = CType(GvBusArB.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusArB.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "4" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "5" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "6" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "7" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "8" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "9" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        ElseIf LblVTipo.Text = "10" Then
            If GVSerAer.Rows.Count > 0 Then
                Origen = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                Destino = CType(GvBusTerA.Rows(0).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
            End If
        End If

        If Origen = "MEX" And Destino = "MEX" Then
            ImpoExpo = "Domestico"
        ElseIf Origen = "MEX" And Not Destino = "MEX" Then
            ImpoExpo = "Exportación"
        ElseIf Not Origen = "MEX" And Destino = "MEX" Then
            ImpoExpo = "Importación"
        Else
            ImpoExpo = "Triangle Business"
        End If

        Return ImpoExpo

    End Function

#Region "Dividir"

    Protected Sub podcountry7_TextChanged(sender As Object, e As EventArgs) Handles podcountry7.TextChanged
        If podcountry7.Text.Length < 6 Then
            podcountry7.Focus()
        Else
            Dim Len As Integer = podcountry7.Text.Length

            Dim Texto As String = podcountry7.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry7.Text.Substring(0, 3).Trim

            podcountry7.Text = Texto
            podcountrycode7.Value = Codigo

            If pod7.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + podcode7.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod7.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pod7.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

    End Sub

    Protected Sub pod7_TextChanged(sender As Object, e As EventArgs) Handles pod7.TextChanged
        If pod7.Text.Length < 6 Then
            pod7.Focus()
        Else
            Dim Len As Integer = pod7.Text.Length

            Dim Texto As String = pod7.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod7.Text.Substring(0, 6).Trim

            pod7.Text = Texto

            podcode7.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry7.Text = row("Name").ToString
                        podcountrycode7.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            un4.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

    End Sub

    Protected Sub polcountry7_TextChanged(sender As Object, e As EventArgs) Handles polcountry7.TextChanged
        If polcountry7.Text.Length < 8 Then
            polcountry7.Focus()
        Else
            Dim Len As Integer = polcountry7.Text.Length

            Dim Texto As String = polcountry7.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry7.Text.Substring(0, 3).Trim

            polcountry7.Text = Texto
            polcountrycode7.Value = Codigo

            If pol7.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode7.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol7.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pol7.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

    End Sub

    Protected Sub pol7_TextChanged(sender As Object, e As EventArgs) Handles pol7.TextChanged
        If pol7.Text.Length < 6 Then
            pol7.Focus()
        Else
            Dim Len As Integer = pol7.Text.Length

            Dim Texto As String = pol7.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol7.Text.Substring(0, 6).Trim

            pol7.Text = Texto

            polcode7.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        polcountry7.Text = row("Name").ToString
                        polcountrycode7.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            podcountry7.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

    End Sub

    Protected Sub polcountry8_TextChanged(sender As Object, e As EventArgs) Handles polcountry8.TextChanged
        If polcountry8.Text.Length < 6 Then
            polcountry8.Focus()
        Else
            Dim Len As Integer = polcountry8.Text.Length

            Dim Texto As String = polcountry8.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry8.Text.Substring(0, 3).Trim

            polcountry8.Text = Texto

            polcountrycode8.Value = Codigo

            If pol8.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode8.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol8.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pol8.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pol8_TextChanged(sender As Object, e As EventArgs) Handles pol8.TextChanged
        If pol8.Text.Length < 8 Then
            pol8.Focus()
        Else
            Dim Len As Integer = pol8.Text.Length

            Dim Texto As String = pol8.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol8.Text.Substring(0, 3).Trim

            pol8.Text = Texto

            polcode8.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        polcountry8.Text = row("Name").ToString
                        polcountrycode8.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            pol_zipcode4.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub podcountry8_TextChanged(sender As Object, e As EventArgs) Handles podcountry8.TextChanged
        If podcountry8.Text.Length < 6 Then
            podcountry8.Focus()
        Else
            Dim Len As Integer = podcountry8.Text.Length

            Dim Texto As String = podcountry8.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry8.Text.Substring(0, 3).Trim

            podcountry8.Text = Texto

            podcountrycode8.Value = Codigo

            If pod8.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + podcode8.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod8.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pod8.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pod8_TextChanged(sender As Object, e As EventArgs) Handles pod8.TextChanged
        If pod8.Text.Length < 8 Then
            pod8.Focus()
        Else
            Dim Len As Integer = pod8.Text.Length

            Dim Texto As String = pod8.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod8.Text.Substring(0, 6).Trim

            pod8.Text = Texto

            podcode8.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry8.Text = row("Name").ToString
                        podcountrycode8.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            pod_zipcode4.Focus()
        End If
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

    End Sub

    Protected Sub polcountry10_TextChanged(sender As Object, e As EventArgs) Handles polcountry10.TextChanged
        If polcountry10.Text.Length < 8 Then
            polcountry10.Focus()
        Else
            Dim Len As Integer = polcountry10.Text.Length

            Dim Texto As String = polcountry10.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry10.Text.Substring(0, 3).Trim

            polcountry10.Text = Texto

            polcountrycode10.Value = Codigo

            If pol10.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode10.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol10.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pol10.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

    End Sub

    Protected Sub pol10_TextChanged(sender As Object, e As EventArgs) Handles pol10.TextChanged
        Try
            If pol10.Text.Length < 8 Then
                pol10.Focus()
            Else
                Dim Len As Integer = pol10.Text.Length

                Dim Texto As String = pol10.Text.Substring(8, Len - 8).Trim

                Dim Codigo As String = pol10.Text.Substring(0, 6).Trim

                pol10.Text = Texto

                polcode10.Text = Codigo

                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            polcountry10.Text = row("Name").ToString
                            polcountrycode10.Value = row("U_POL_CODE_COUNTRY").ToString
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log

                End Try

                pol_zipcode6.Focus()
            End If

            ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub podcountry10_TextChanged(sender As Object, e As EventArgs) Handles podcountry10.TextChanged
        If podcountry10.Text.Length < 8 Then
            podcountry10.Focus()
        Else
            Dim Len As Integer = podcountry10.Text.Length

            Dim Texto As String = podcountry10.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry10.Text.Substring(0, 3).Trim

            podcountry10.Text = Texto

            podcountrycode10.Value = Codigo

            If pod10.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + idpod10.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod10.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If
            pod10.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Private Sub pod10_TextChanged(sender As Object, e As EventArgs) Handles pod10.TextChanged
        If pod10.Text.Length < 8 Then
            pod10.Focus()
        Else
            Dim Len As Integer = pod10.Text.Length

            Dim Texto As String = pod10.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod10.Text.Substring(0, 6).Trim

            pod10.Text = Texto

            idpod10.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry10.Text = row("Name").ToString
                        podcountrycode10.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            pod_zipcode6.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pol1_TextChanged(sender As Object, e As EventArgs) Handles pol1.TextChanged
        If pol1.Text.Length < 8 Then
            pol1.Focus()
        Else
            Dim Len As Integer = pol1.Text.Length

            Dim Texto As String = pol1.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol1.Text.Substring(0, 6).Trim

            pol1.Text = Texto

            polcode1.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        namepolcountry.Text = row("Name").ToString
                        'hfpodcountry10.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            pod1.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pod1_TextChanged(sender As Object, e As EventArgs) Handles pod1.TextChanged
        If pod1.Text.Length < 8 Then
            pod1.Focus()
        Else
            Dim Len As Integer = pod1.Text.Length

            Dim Texto As String = pod1.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod1.Text.Substring(0, 6).Trim

            pod1.Text = Texto

            podcode1.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        namepodcountry.Text = row("Name").ToString
                        'hfpodcountry10.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            equipment.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pol3_TextChanged(sender As Object, e As EventArgs) Handles pol3.TextChanged
        If pol3.Text.Length < 8 Then
            pol3.Focus()
        Else
            Dim Len As Integer = pol3.Text.Length

            Dim Texto As String = pol3.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol3.Text.Substring(0, 6).Trim

            pol3.Text = Texto

            polcode3.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        polcountry3.Text = row("Name").ToString
                        polcountrycode3.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            pol_zipcode2.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub polcountry3_TextChanged(sender As Object, e As EventArgs) Handles polcountry3.TextChanged
        If polcountry3.Text.Length < 8 Then
            polcountry3.Focus()
        Else
            Dim Len As Integer = polcountry3.Text.Length

            Dim Texto As String = polcountry3.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry3.Text.Substring(0, 3).Trim

            polcountry3.Text = Texto

            polcountrycode3.Value = Codigo

            If pol3.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode3.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol3.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pol3.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pod3_TextChanged(sender As Object, e As EventArgs) Handles pod3.TextChanged
        If pod3.Text.Length < 8 Then
            pod3.Focus()
        Else
            Dim Len As Integer = pod3.Text.Length

            Dim Texto As String = pod3.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod3.Text.Substring(0, 6).Trim

            pod3.Text = Texto

            podcode3.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry2.Text = row("Name").ToString
                        podcodecountry2.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            pod_zipcode2.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub podcountry2_TextChanged(sender As Object, e As EventArgs) Handles podcountry2.TextChanged
        If podcountry2.Text.Length < 8 Then
            podcountry2.Focus()
        Else
            Dim Len As Integer = podcountry2.Text.Length

            Dim Texto As String = podcountry2.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry2.Text.Substring(0, 3).Trim

            podcountry2.Text = Texto

            podcodecountry2.Value = Codigo

            If pod3.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + podcode3.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod3.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pod3.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub polcountry4_TextChanged(sender As Object, e As EventArgs) Handles polcountry4.TextChanged
        If polcountry4.Text.Length < 8 Then
            polcountry4.Focus()
        Else
            Dim Len As Integer = polcountry4.Text.Length

            Dim Texto As String = polcountry4.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry4.Text.Substring(0, 3).Trim

            polcountry4.Text = Texto

            polcountrycode4.Value = Codigo

            If pol4.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode4.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol4.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pol4.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pol4_TextChanged(sender As Object, e As EventArgs) Handles pol4.TextChanged
        If pol4.Text.Length < 8 Then
            pol4.Focus()
        Else
            Dim Len As Integer = pol4.Text.Length

            Dim Texto As String = pol4.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol4.Text.Substring(0, 6).Trim

            pol4.Text = Texto

            polcode4.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        polcountry4.Text = row("Name").ToString
                        polcountrycode4.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            podcountry4.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub podcountry4_TextChanged(sender As Object, e As EventArgs) Handles podcountry4.TextChanged
        If podcountry4.Text.Length < 8 Then
            podcountry4.Focus()
        Else
            Dim Len As Integer = podcountry4.Text.Length

            Dim Texto As String = podcountry4.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry4.Text.Substring(0, 3).Trim

            podcountry4.Text = Texto

            podcountrycode4.Value = Codigo

            If pod4.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + podcode4.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod4.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pod4.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pod4_TextChanged(sender As Object, e As EventArgs) Handles pod4.TextChanged
        If pod4.Text.Length < 8 Then
            pod4.Focus()
        Else
            Dim Len As Integer = pod4.Text.Length

            Dim Texto As String = pod4.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod4.Text.Substring(0, 6).Trim

            pod4.Text = Texto

            podcode4.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry4.Text = row("Name").ToString
                        podcountrycode4.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            via1.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub pol2_TextChanged(sender As Object, e As EventArgs) Handles pol2.TextChanged
        If pol2.Text.Length < 8 Then
            pol2.Focus()
        Else
            Dim Len As Integer = pol2.Text.Length

            Dim Texto As String = pol2.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol2.Text.Substring(0, 6).Trim

            pol2.Text = Texto

            polcode2.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        polcountry1.Text = row("Name").ToString
                        polcountrycode1.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            polcountry1.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub polcountry1_TextChanged(sender As Object, e As EventArgs) Handles polcountry1.TextChanged
        If polcountry1.Text.Length < 8 Then
            polcountry1.Focus()
        Else
            Dim Len As Integer = polcountry1.Text.Length

            Dim Texto As String = polcountry1.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry1.Text.Substring(0, 3).Trim

            polcountry1.Text = Texto

            polcountrycode1.Value = Codigo

            If pol2.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode2.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol2.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            polzipcode1.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub


    Protected Sub pod2_TextChanged(sender As Object, e As EventArgs) Handles pod2.TextChanged
        If pod2.Text.Length < 8 Then
            pod2.Focus()
        Else
            Dim Len As Integer = pod2.Text.Length

            Dim Texto As String = pod2.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod2.Text.Substring(0, 6).Trim

            pod2.Text = Texto

            podcode2.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry1.Text = row("Name").ToString
                        podcodecountry1.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            podcountry1.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub podcountry1_TextChanged(sender As Object, e As EventArgs) Handles podcountry1.TextChanged
        If podcountry1.Text.Length < 8 Then
            podcountry1.Focus()
        Else
            Dim Len As Integer = podcountry1.Text.Length

            Dim Texto As String = podcountry1.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry1.Text.Substring(0, 3).Trim

            podcountry1.Text = Texto

            podcodecountry1.Value = Codigo

            If pod2.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + podcode2.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod2.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pod_zipcode1.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub


    Protected Sub pol9_TextChanged(sender As Object, e As EventArgs) Handles pol9.TextChanged
        If pol9.Text.Length < 8 Then
            pol9.Focus()
        Else
            Dim Len As Integer = pol9.Text.Length

            Dim Texto As String = pol9.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol9.Text.Substring(0, 6).Trim

            pol9.Text = Texto

            polcode9.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        polcountry9.Text = row("Name").ToString
                        polcountrycode9.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            polcountry9.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub polcountry9_TextChanged(sender As Object, e As EventArgs) Handles polcountry9.TextChanged
        If polcountry9.Text.Length < 8 Then
            polcountry9.Focus()
        Else
            Dim Len As Integer = polcountry9.Text.Length

            Dim Texto As String = polcountry9.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry9.Text.Substring(0, 3).Trim

            polcountry9.Text = Texto

            polcountrycode9.Value = Codigo

            If pol9.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode9.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol9.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pol_zipcode5.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub


    Protected Sub pod9_TextChanged(sender As Object, e As EventArgs) Handles pod9.TextChanged
        If pod9.Text.Length < 8 Then
            pod9.Focus()
        Else
            Dim Len As Integer = pod9.Text.Length

            Dim Texto As String = pod9.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod9.Text.Substring(0, 6).Trim

            pod9.Text = Texto

            podcode9.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry9.Text = row("Name").ToString
                        podcountrycode9.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            podcountry9.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub podcountry9_TextChanged(sender As Object, e As EventArgs) Handles podcountry9.TextChanged
        If podcountry9.Text.Length < 8 Then
            podcountry9.Focus()
        Else
            Dim Len As Integer = podcountry9.Text.Length

            Dim Texto As String = podcountry9.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry9.Text.Substring(0, 3).Trim

            podcountry9.Text = Texto

            podcountrycode9.Value = Codigo

            If pod9.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + podcode9.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod9.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pod_zipcode5.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub



    Protected Sub pol5_TextChanged(sender As Object, e As EventArgs) Handles pol5.TextChanged
        If pol5.Text.Length < 8 Then
            pol5.Focus()
        Else
            Dim Len As Integer = pol5.Text.Length

            Dim Texto As String = pol5.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pol5.Text.Substring(0, 6).Trim

            pol5.Text = Texto

            polcode5.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        polcountry5.Text = row("Name").ToString
                        polcountrycode5.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            polcountry5.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub polcountry5_TextChanged(sender As Object, e As EventArgs) Handles polcountry5.TextChanged
        If polcountry5.Text.Length < 8 Then
            polcountry5.Focus()
        Else
            Dim Len As Integer = polcountry5.Text.Length

            Dim Texto As String = polcountry5.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = polcountry5.Text.Substring(0, 3).Trim

            polcountry5.Text = Texto

            polcountrycode5.Value = Codigo

            If pol5.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + polcode5.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pol5.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pol_zipcode3.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub


    Protected Sub pod5_TextChanged(sender As Object, e As EventArgs) Handles pod5.TextChanged
        If pod5.Text.Length < 8 Then
            pod5.Focus()
        Else
            Dim Len As Integer = pod5.Text.Length

            Dim Texto As String = pod5.Text.Substring(8, Len - 8).Trim

            Dim Codigo As String = pod5.Text.Substring(0, 6).Trim

            pod5.Text = Texto

            podcode5.Text = Codigo

            Try
                Dim Ws As New BXP_WebServiceSQL

                Dim Query As String = ""

                Query = "Select C.U_POL_CODE_COUNTRY, P.Name From Prototipo_Desarrollos.dbo.[@POL] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + Codigo.ToString + "' "

                Using sdr As DataSet = Ws.Query1(Query)

                    For Each row As DataRow In sdr.Tables(0).Rows
                        podcountry5.Text = row("Name").ToString
                        podcountrycode5.Value = row("U_POL_CODE_COUNTRY").ToString
                    Next
                End Using

            Catch ex As Exception
                'Dim Log As New BXP_Log

            End Try

            podcountry5.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub

    Protected Sub podcountry5_TextChanged(sender As Object, e As EventArgs) Handles podcountry5.TextChanged
        If podcountry5.Text.Length < 8 Then
            podcountry5.Focus()
        Else
            Dim Len As Integer = podcountry5.Text.Length

            Dim Texto As String = podcountry5.Text.Substring(5, Len - 5).Trim

            Dim Codigo As String = podcountry5.Text.Substring(0, 3).Trim

            podcountry5.Text = Texto

            podcountrycode5.Value = Codigo

            If pod5.Text <> "" Then
                Try
                    Dim Ws As New BXP_WebServiceSQL

                    Dim Query As String = ""

                    Query = "Select P.Name From Prototipo_Desarrollos.dbo.[@POL_AE] C, [Prototipo_Desarrollos].[dbo].[@PAIS_LOGISTICA] P WHERE P.Code=C.U_POL_CODE_COUNTRY AND C.Code = '" + podcode5.Text.ToString + "' "

                    Using sdr As DataSet = Ws.Query1(Query)

                        For Each row As DataRow In sdr.Tables(0).Rows
                            If Texto <> row("Name").ToString Then
                                pod5.Text = ""
                            End If
                        Next
                    End Using

                Catch ex As Exception
                    'Dim Log As New BXP_Log
                End Try

            End If

            pod_zipcode3.Focus()
        End If

        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModal2();", True)
    End Sub



#End Region

    Private Function Obj_AirB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("AGENT")
            Dt.Columns.Add("AEROLINEA")
            Dt.Columns.Add("Peso")
            Dt.Columns.Add("Precio")

            Dt.Columns.Add("PrecioSuge")

            Dt.Columns.Add("MIN")
            Dt.Columns.Add("MEN45KG")
            Dt.Columns.Add("MAY45KG")
            Dt.Columns.Add("MAY100KG")
            Dt.Columns.Add("MAY300KG")
            '10
            Dt.Columns.Add("MAY500KG")
            Dt.Columns.Add("MAY1000KG")
            Dt.Columns.Add("REMARKS")
            Dt.Columns.Add("POL_CODE")
            Dt.Columns.Add("POL")

            Dt.Columns.Add("POL_CODE_COUNTRY")
            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("POD_CODE_COUNTRY")
            '20
            Dt.Columns.Add("POD_COUNTRY")
            Dt.Columns.Add("VIA1")
            Dt.Columns.Add("VIA2")
            Dt.Columns.Add("VIA3")
            Dt.Columns.Add("VIA4")

            Dt.Columns.Add("VIA5")
            Dt.Columns.Add("CURRENCY")
            Dt.Columns.Add("FSCKG")
            Dt.Columns.Add("SSCKG")
            Dt.Columns.Add("TAX")
            '30
            Dt.Columns.Add("HAWB")
            Dt.Columns.Add("HANDLING")
            Dt.Columns.Add("ROUNTING")
            Dt.Columns.Add("FREQUENCY")
            Dt.Columns.Add("AIRCRAFT")

            Dt.Columns.Add("MAXDimXPZA")
            Dt.Columns.Add("MAXWeigthXPZA")
            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")
            Dt.Columns.Add("TT")
            '40
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("RA")
            Dt.Columns.Add("COMMODITY")
            Dt.Columns.Add("COMMITMENT_VOL")
            Dt.Columns.Add("SUBJECT")

            Dt.Columns.Add("NOT_SUBJECT")
            '46
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Obj_FCLB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("POL")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("20GP")
            Dt.Columns.Add("Precio1")

            Dt.Columns.Add("40GP")

            Dt.Columns.Add("Precio2")
            Dt.Columns.Add("40HQ")
            Dt.Columns.Add("Precio3")
            Dt.Columns.Add("REMARKS")
            Dt.Columns.Add("CURRENCY")
            '10
            Dt.Columns.Add("FREE_DAYS")
            Dt.Columns.Add("TT")
            Dt.Columns.Add("CARRIER")
            Dt.Columns.Add("AGENT")
            Dt.Columns.Add("POL_CODE")

            Dt.Columns.Add("POL_CODE_COUNTRY")
            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD_CODE_COUNTRY")
            Dt.Columns.Add("POD_COUNTRY")
            '20
            Dt.Columns.Add("VIA1")
            Dt.Columns.Add("VIA2")
            Dt.Columns.Add("VIA3")
            Dt.Columns.Add("EQUIPMENT")
            Dt.Columns.Add("VALIDITY_FROM")

            Dt.Columns.Add("VALIDITY_TO")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("COMMODITY")
            Dt.Columns.Add("UN")
            Dt.Columns.Add("IMO_SUB")
            '30
            Dt.Columns.Add("RA")
            Dt.Columns.Add("COMMITMENT_TES")
            Dt.Columns.Add("SUBJECT")
            Dt.Columns.Add("NOT_SUBJECT")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Obj_CCB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("AGENT")
            Dt.Columns.Add("20GP")
            Dt.Columns.Add("Precio1")
            Dt.Columns.Add("40GP")

            Dt.Columns.Add("Precio2")

            Dt.Columns.Add("40HQ")
            Dt.Columns.Add("Precio3")
            Dt.Columns.Add("REMARKS")
            Dt.Columns.Add("POL_CODE")
            Dt.Columns.Add("POL")
            '10
            Dt.Columns.Add("POL_CODE_COUNTRY")
            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POL_ZIPCODE")
            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")

            Dt.Columns.Add("POD_CODE_COUNTRY")
            Dt.Columns.Add("POD_COUNTRY")
            Dt.Columns.Add("POD_ZIPCODE")
            Dt.Columns.Add("CURRENCY")
            Dt.Columns.Add("20GP")
            '20
            Dt.Columns.Add("40GP")
            Dt.Columns.Add("40HQ")
            Dt.Columns.Add("EQUIPMENT")
            Dt.Columns.Add("MODE")
            Dt.Columns.Add("SINGLE")

            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("COMMODITY")
            Dt.Columns.Add("UN")
            '30
            Dt.Columns.Add("RA")
            Dt.Columns.Add("SUBJECT")
            Dt.Columns.Add("NOT_SUBJECT")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function


    Private Function Obj_CHB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("CARRIER")
            Dt.Columns.Add("TOTAL_RATE_SIN")
            Dt.Columns.Add("TOTAL_RATE_SIN")

            Dt.Columns.Add("TOTAL_RATE_TAN")

            Dt.Columns.Add("TOTAL_RATE_TAN")

            Dt.Columns.Add("SINGLE")
            Dt.Columns.Add("SINGLE")
            Dt.Columns.Add("TOLLS_SIN")
            Dt.Columns.Add("TOLLS_SIN")
            Dt.Columns.Add("TANDEM")
            Dt.Columns.Add("TANDEM")
            Dt.Columns.Add("TOLLS_TAN")
            Dt.Columns.Add("TOLLS_TAN")

            Dt.Columns.Add("REMARKS")
            Dt.Columns.Add("ORIGIN")
            Dt.Columns.Add("POL_CODE")
            '10
            Dt.Columns.Add("POL")
            Dt.Columns.Add("POL_CODE_COUNTRY")
            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POL_ZIPCODE")
            Dt.Columns.Add("DESTINATION")

            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("POD_CODE_COUNTRY")
            Dt.Columns.Add("POD_COUNTRY")
            Dt.Columns.Add("POD_ZIPCODE")
            '20
            Dt.Columns.Add("SERVICE")
            Dt.Columns.Add("CURRENCY")
            Dt.Columns.Add("EQUIPMENT")

            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")
            Dt.Columns.Add("TT")
            '30
            Dt.Columns.Add("WEIGHT_SIN")
            Dt.Columns.Add("WEIGHT_TAN")
            Dt.Columns.Add("FREE_HOURS")

            Dt.Columns.Add("COMMODITY")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("VOLUMEN")
            '30
            Dt.Columns.Add("SUBJECT")
            Dt.Columns.Add("NOT_SUBJECT")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Obj_INTERMODALB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("CARRIER")
            Dt.Columns.Add("ORIGIN")
            Dt.Columns.Add("ORIGIN_RAMP")
            Dt.Columns.Add("POL_CODE")

            Dt.Columns.Add("POL")

            Dt.Columns.Add("POL_CODE_COUNTRY")
            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POL_ZIPCODE")
            Dt.Columns.Add("ROUTE")
            Dt.Columns.Add("MODE_CODE")
            '10
            Dt.Columns.Add("DESTINATION")
            Dt.Columns.Add("DESTINATION_RAMP")
            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("POD_CODE_COUNTRY")

            Dt.Columns.Add("POD_COUNTRY")
            Dt.Columns.Add("POD_ZIPCODE")
            Dt.Columns.Add("CURRENCY")
            Dt.Columns.Add("SUBTOTAL")
            Dt.Columns.Add("FSC")
            '20
            Dt.Columns.Add("FSC_TOTAL")
            Dt.Columns.Add("TOTAL_US")
            Dt.Columns.Add("EQUIPMENT")
            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")

            Dt.Columns.Add("TT")
            Dt.Columns.Add("COMMODITY")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("VOLUMEN")
            Dt.Columns.Add("SUBJECT")
            '30
            Dt.Columns.Add("NOT_SUBJECT")
            Dt.Columns.Add("REMARKS")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Obj_LCLB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("CO_LOADER")
            Dt.Columns.Add("AGENT")
            Dt.Columns.Add("COST")
            Dt.Columns.Add("COST2")
            Dt.Columns.Add("MIN_COST")
            Dt.Columns.Add("POL_CODE")
            Dt.Columns.Add("POL")

            Dt.Columns.Add("POL_CODE_COUNTRY")

            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("POD_CODE_COUNTRY")
            Dt.Columns.Add("POD_COUNTRY")
            '10
            Dt.Columns.Add("VIA1")
            Dt.Columns.Add("VIA2")
            Dt.Columns.Add("VIA3")
            Dt.Columns.Add("CURRENCY")

            Dt.Columns.Add("FREQUENCY")
            Dt.Columns.Add("EQUIPMENT")
            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")
            '20
            Dt.Columns.Add("TT")
            Dt.Columns.Add("FREE_DAYS")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("RA")
            Dt.Columns.Add("COMMODITY")

            Dt.Columns.Add("ADDMON_FEE")
            Dt.Columns.Add("BL")
            Dt.Columns.Add("PORT_TRANSFER")
            Dt.Columns.Add("STUFFINNG")
            Dt.Columns.Add("VGM_SOLAS")
            '30
            Dt.Columns.Add("SUBJECT")
            Dt.Columns.Add("NOT_SUBJECT")
            Dt.Columns.Add("REMARKS")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Obj_LTLB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("CARRIER")
            Dt.Columns.Add("ORIGIN")
            Dt.Columns.Add("POL_CODE")
            Dt.Columns.Add("POL")

            Dt.Columns.Add("POL_CODE_COUNTRY")

            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POL_ZIPCODE")

            Dt.Columns.Add("DESTINATION")

            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("POD_CODE_COUNTRY")
            Dt.Columns.Add("POD_COUNTRY")
            Dt.Columns.Add("POD_ZIPCODE")
            '10

            Dt.Columns.Add("CURRENCY")
            Dt.Columns.Add("QUANTITY")

            Dt.Columns.Add("TYPE")
            Dt.Columns.Add("TOTAL_WEIGHT")
            Dt.Columns.Add("WEIGHT")
            Dt.Columns.Add("LARGE")
            Dt.Columns.Add("WIDTH")
            '20
            Dt.Columns.Add("HEIGHT")
            Dt.Columns.Add("STACKABLE")
            Dt.Columns.Add("TOTAL")
            Dt.Columns.Add("TOTAL")
            Dt.Columns.Add("CROSSBORDER")
            Dt.Columns.Add("COMMODITY")

            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")
            Dt.Columns.Add("TT")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("VOLUMEN")
            '30
            Dt.Columns.Add("SUBJECT")
            Dt.Columns.Add("NOT_SUBJECT")
            Dt.Columns.Add("REMARKS")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Obj_TLMB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("CARRIER")
            Dt.Columns.Add("ORIGIN")
            Dt.Columns.Add("POL_CODE")
            Dt.Columns.Add("POL")

            Dt.Columns.Add("POL_CODE_COUNTRY")

            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POL_ZIPCODE")

            Dt.Columns.Add("DESTINATION")

            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("POD_CODE_COUNTRY")
            Dt.Columns.Add("POD_COUNTRY")
            Dt.Columns.Add("POD_ZIPCODE")
            '10

            Dt.Columns.Add("STOP")
            Dt.Columns.Add("STOP2")
            Dt.Columns.Add("STOP3")
            Dt.Columns.Add("CURRENCY")
            Dt.Columns.Add("TOTALRATE")
            Dt.Columns.Add("TOTALRATE")
            Dt.Columns.Add("KM")
            Dt.Columns.Add("FSC")
            Dt.Columns.Add("FSC_TOTAL")
            Dt.Columns.Add("EQUIPMENT")
            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")
            Dt.Columns.Add("TT")
            '20
            Dt.Columns.Add("FREE_DAYS")
            Dt.Columns.Add("COMMODITY")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("VOLUMEN")
            '30
            Dt.Columns.Add("SUBJECT")
            Dt.Columns.Add("NOT_SUBJECT")
            Dt.Columns.Add("REMARKS")
            Dt.Columns.Add("FREE_HRS_LOA_UNLOA")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function


    Private Function Obj_TLUB() As DataTable
        Dim Dt As DataTable
        Dt = New DataTable

        Try
            Dt.Columns.Add("id_num")
            Dt.Columns.Add("CARRIER")
            Dt.Columns.Add("ORIGIN")
            Dt.Columns.Add("POL_CODE")
            Dt.Columns.Add("POL")

            Dt.Columns.Add("POL_CODE_COUNTRY")

            Dt.Columns.Add("POL_COUNTRY")
            Dt.Columns.Add("POL_ZIPCODE")

            Dt.Columns.Add("DESTINATION")

            Dt.Columns.Add("POD_CODE")
            Dt.Columns.Add("POD")
            Dt.Columns.Add("POD_CODE_COUNTRY")
            Dt.Columns.Add("POD_COUNTRY")
            Dt.Columns.Add("POD_ZIPCODE")
            '10

            Dt.Columns.Add("CURRENCY")
            Dt.Columns.Add("MILES")
            Dt.Columns.Add("RPM")
            Dt.Columns.Add("SUBTOTAL")
            Dt.Columns.Add("FSC")
            Dt.Columns.Add("TOTAL_US")
            Dt.Columns.Add("EQUIPMENT")
            Dt.Columns.Add("VALIDITY_FROM")
            Dt.Columns.Add("VALIDITY_TO")
            Dt.Columns.Add("TT")
            '20
            Dt.Columns.Add("FREE_DAYS")
            Dt.Columns.Add("COMMODITY")
            Dt.Columns.Add("NAC")
            Dt.Columns.Add("VOLUMEN")
            '30
            Dt.Columns.Add("SUBJECT")
            Dt.Columns.Add("NOT_SUBJECT")
            Dt.Columns.Add("REMARKS")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function


    Public Function Obj_Air(ByVal GVSerAer As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_AirB()
        Try
            If Not GVSerAer.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerAer.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("AGENT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                    Renglon("AEROLINEA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAEROLINEA"), Label).Text
                    Renglon("Peso") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPeso"), TextBox).Text
                    Renglon("Precio") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                    Renglon("PrecioSuge") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPrecioSuge"), TextBox).Text
                    Renglon("MIN") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMIN"), Label).Text
                    Renglon("MEN45KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMEN45KG"), Label).Text
                    Renglon("MAY45KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY45KG"), Label).Text
                    Renglon("MAY100KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY100KG"), Label).Text
                    Renglon("MAY300KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY300KG"), Label).Text
                    Renglon("MAY500KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY500KG"), Label).Text
                    Renglon("MAY1000KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY1000KG"), Label).Text
                    Renglon("REMARKS") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("POL_CODE") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("VIA1") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                    Renglon("VIA2") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                    Renglon("VIA3") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text
                    Renglon("VIA4") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA4"), Label).Text
                    Renglon("VIA5") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA5"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("FSCKG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblFSCKG"), Label).Text
                    Renglon("SSCKG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblSSCKG"), Label).Text
                    Renglon("TAX") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblTAX"), Label).Text
                    Renglon("HAWB") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblHAWB"), Label).Text
                    Renglon("HANDLING") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblHANDLING"), Label).Text
                    Renglon("ROUNTING") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblROUNTING"), Label).Text
                    Renglon("FREQUENCY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblFREQUENCY"), Label).Text
                    Renglon("AIRCRAFT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAIRCRAFT"), Label).Text
                    Renglon("MAXDimXPZA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAXDimXPZA"), Label).Text
                    Renglon("MAXWeigthXPZA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAXWeigthXPZA"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("NAC") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("RA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("COMMITMENT_VOL") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_VOL"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_Air(ByVal GVSerAer As GridView, ByVal GvBusAer As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_Air(GVSerAer)

        Try
            If Not GvBusAer.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusAer.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusAer.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()

                        Renglon("id_num") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("AGENT") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                        Renglon("AEROLINEA") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblAEROLINEA"), Label).Text
                        Renglon("Peso") = 1
                        Renglon("Precio") = 1
                        Renglon("PrecioSuge") = 1
                        Renglon("MIN") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMIN"), Label).Text
                        Renglon("MEN45KG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMEN45KG"), Label).Text
                        Renglon("MAY45KG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMAY45KG"), Label).Text
                        Renglon("MAY100KG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMAY100KG"), Label).Text
                        Renglon("MAY300KG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMAY300KG"), Label).Text
                        Renglon("MAY500KG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMAY500KG"), Label).Text
                        Renglon("MAY1000KG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMAY1000KG"), Label).Text
                        Renglon("REMARKS") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                        Renglon("VIA1") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                        Renglon("VIA2") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                        Renglon("VIA3") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text
                        Renglon("VIA4") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblVIA4"), Label).Text
                        Renglon("VIA5") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblVIA5"), Label).Text
                        Renglon("CURRENCY") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                        Renglon("FSCKG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblFSCKG"), Label).Text
                        Renglon("SSCKG") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblSSCKG"), Label).Text
                        Renglon("TAX") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblTAX"), Label).Text
                        Renglon("HAWB") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblHAWB"), Label).Text
                        Renglon("HANDLING") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblHANDLING"), Label).Text
                        Renglon("ROUNTING") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblROUNTING"), Label).Text
                        Renglon("FREQUENCY") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblFREQUENCY"), Label).Text
                        Renglon("AIRCRAFT") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblAIRCRAFT"), Label).Text
                        Renglon("MAXDimXPZA") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMAXDimXPZA"), Label).Text
                        Renglon("MAXWeigthXPZA") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblMAXWeigthXPZA"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("TT") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                        Renglon("NAC") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("RA") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("COMMITMENT_VOL") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_VOL"), Label).Text
                        Renglon("SUBJECT") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusAer.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_Air(ByVal GVSerAer As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_AirB()

        Try
            If Not GVSerAer.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerAer.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerAer.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("AGENT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                    Renglon("AEROLINEA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAEROLINEA"), Label).Text
                    Renglon("Peso") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPeso"), TextBox).Text
                    Renglon("Precio") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                    Renglon("PrecioSuge") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtPrecioSuge"), TextBox).Text
                    Renglon("MIN") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMIN"), Label).Text
                    Renglon("MEN45KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMEN45KG"), Label).Text
                    Renglon("MAY45KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY45KG"), Label).Text
                    Renglon("MAY100KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY100KG"), Label).Text
                    Renglon("MAY300KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY300KG"), Label).Text
                    Renglon("MAY500KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY500KG"), Label).Text
                    Renglon("MAY1000KG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAY1000KG"), Label).Text
                    Renglon("REMARKS") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("POL_CODE") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("VIA1") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                    Renglon("VIA2") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                    Renglon("VIA3") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text
                    Renglon("VIA4") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA4"), Label).Text
                    Renglon("VIA5") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVIA5"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("FSCKG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblFSCKG"), Label).Text
                    Renglon("SSCKG") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblSSCKG"), Label).Text
                    Renglon("TAX") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblTAX"), Label).Text
                    Renglon("HAWB") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblHAWB"), Label).Text
                    Renglon("HANDLING") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblHANDLING"), Label).Text
                    Renglon("ROUNTING") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblROUNTING"), Label).Text
                    Renglon("FREQUENCY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblFREQUENCY"), Label).Text
                    Renglon("AIRCRAFT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblAIRCRAFT"), Label).Text
                    Renglon("MAXDimXPZA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAXDimXPZA"), Label).Text
                    Renglon("MAXWeigthXPZA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblMAXWeigthXPZA"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("NAC") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("RA") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("COMMITMENT_VOL") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblCOMMITMENT_VOL"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerAer.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt


    End Function


    Public Function Obj_CC(ByVal GVSerCC As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_CCB()
        Try
            If Not GVSerCC.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerCC.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("AGENT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                    Renglon("20GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl20GP"), Label).Text
                    Renglon("Precio1") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TextBox7"), TextBox).Text
                    Renglon("40GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40GP"), Label).Text
                    Renglon("Precio2") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TextBox8"), TextBox).Text
                    Renglon("40HQ") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40HQ"), Label).Text
                    Renglon("Precio3") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TextBox9"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("20GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl20GP1"), Label).Text
                    Renglon("40GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40GP1"), Label).Text
                    Renglon("40HQ") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40HQ1"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("MODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblMODE"), Label).Text
                    Renglon("SINGLE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblSINGLE"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("NAC") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("UN") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                    Renglon("RA") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_CC(ByVal GVSerCC As GridView, ByVal GvBusCC As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_CC(GVSerCC)

        Try
            If Not GvBusCC.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusCC.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusCC.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()


                        Renglon("id_num") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("AGENT") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                        Renglon("20GP") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("Lbl20GP"), Label).Text
                        Renglon("Precio1") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("TextBox7"), TextBox).Text
                        Renglon("40GP") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("Lbl40GP"), Label).Text
                        Renglon("Precio2") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("TextBox8"), TextBox).Text
                        Renglon("40HQ") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("Lbl40HQ"), Label).Text
                        Renglon("Precio3") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("TextBox9"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POL_ZIPCODE") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                        Renglon("POD_ZIPCODE") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                        Renglon("CURRENCY") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                        Renglon("20GP") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("Lbl20GP1"), Label).Text
                        Renglon("40GP") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("Lbl40GP1"), Label).Text
                        Renglon("40HQ") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("Lbl40HQ1"), Label).Text
                        Renglon("EQUIPMENT") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                        Renglon("MODE") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblMODE"), Label).Text
                        Renglon("SINGLE") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblSINGLE"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("NAC") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("UN") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                        Renglon("RA") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                        Renglon("SUBJECT") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusCC.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_CC(ByVal GVSerCC As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_CCB()

        Try
            If Not GVSerCC.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerCC.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerCC.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("AGENT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                    Renglon("20GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl20GP"), Label).Text
                    Renglon("Precio1") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TextBox7"), TextBox).Text
                    Renglon("40GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40GP"), Label).Text
                    Renglon("Precio2") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TextBox8"), TextBox).Text
                    Renglon("40HQ") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40HQ"), Label).Text
                    Renglon("Precio3") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TextBox9"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("20GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl20GP1"), Label).Text
                    Renglon("40GP") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40GP1"), Label).Text
                    Renglon("40HQ") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("Lbl40HQ1"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("MODE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblMODE"), Label).Text
                    Renglon("SINGLE") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblSINGLE"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("NAC") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("UN") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                    Renglon("RA") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerCC.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt


    End Function

    Public Function Obj_CH(ByVal GVSerCH As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_CHB()
        Try
            If Not GVSerCH.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerCH.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("TOTAL_RATE_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOTAL_RATE_SIN"), Label).Text
                    Renglon("TOTAL_RATE_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOTAL_RATE_SIN"), TextBox).Text
                    Renglon("TOTAL_RATE_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOTAL_RATE_TAN"), Label).Text
                    Renglon("TOTAL_RATE_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOTAL_RATE_TAN"), TextBox).Text
                    Renglon("SINGLE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblSINGLE"), Label).Text
                    Renglon("SINGLE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtSINGLE"), TextBox).Text
                    Renglon("TOLLS_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOLLS_SIN"), Label).Text
                    Renglon("TOLLS_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOLLS_SIN"), TextBox).Text
                    Renglon("TANDEM") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTANDEM"), Label).Text
                    Renglon("TANDEM") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTANDEM"), TextBox).Text
                    Renglon("TOLLS_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOLLS_TAN"), Label).Text
                    Renglon("TOLLS_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOLLS_TAN"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("SERVICE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblSERVICE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("WEIGHT_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblWEIGHT_SIN"), Label).Text
                    Renglon("WEIGHT_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblWEIGHT_TAN"), Label).Text
                    Renglon("FREE_HOURS") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblFREE_HOURS"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_CH(ByVal GVSerCH As GridView, ByVal GvBusCH As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_CH(GVSerCH)

        Try
            If Not GvBusCH.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusCH.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusCH.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()

                        Renglon("id_num") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("CARRIER") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                        Renglon("TOTAL_RATE_SIN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblTOTAL_RATE_SIN"), Label).Text
                        Renglon("TOTAL_RATE_SIN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("TxtTOTAL_RATE_SIN"), TextBox).Text
                        Renglon("TOTAL_RATE_TAN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblTOTAL_RATE_TAN"), Label).Text
                        Renglon("TOTAL_RATE_TAN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("TxtTOTAL_RATE_TAN"), TextBox).Text
                        Renglon("SINGLE") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblSINGLE"), Label).Text
                        Renglon("SINGLE") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("TxtSINGLE"), TextBox).Text
                        Renglon("TOLLS_SIN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblTOLLS_SIN"), Label).Text
                        Renglon("TOLLS_SIN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("TxtTOLLS_SIN"), TextBox).Text
                        Renglon("TANDEM") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblTANDEM"), Label).Text
                        Renglon("TANDEM") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("TxtTANDEM"), TextBox).Text
                        Renglon("TOLLS_TAN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblTOLLS_TAN"), Label).Text
                        Renglon("TOLLS_TAN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("TxtTOLLS_TAN"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                        Renglon("ORIGIN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POL_ZIPCODE") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                        Renglon("DESTINATION") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                        Renglon("POD_ZIPCODE") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                        Renglon("SERVICE") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblSERVICE"), Label).Text
                        Renglon("CURRENCY") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                        Renglon("EQUIPMENT") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("TT") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                        Renglon("WEIGHT_SIN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblWEIGHT_SIN"), Label).Text
                        Renglon("WEIGHT_TAN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblWEIGHT_TAN"), Label).Text
                        Renglon("FREE_HOURS") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblFREE_HOURS"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("NAC") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("VOLUMEN") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                        Renglon("SUBJECT") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusCH.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_CH(ByVal GVSerCH As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_CHB()

        Try
            If Not GVSerCH.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerCH.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerCH.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("TOTAL_RATE_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOTAL_RATE_SIN"), Label).Text
                    Renglon("TOTAL_RATE_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOTAL_RATE_SIN"), TextBox).Text
                    Renglon("TOTAL_RATE_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOTAL_RATE_TAN"), Label).Text
                    Renglon("TOTAL_RATE_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOTAL_RATE_TAN"), TextBox).Text
                    Renglon("SINGLE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblSINGLE"), Label).Text
                    Renglon("SINGLE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtSINGLE"), TextBox).Text
                    Renglon("TOLLS_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOLLS_SIN"), Label).Text
                    Renglon("TOLLS_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOLLS_SIN"), TextBox).Text
                    Renglon("TANDEM") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTANDEM"), Label).Text
                    Renglon("TANDEM") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTANDEM"), TextBox).Text
                    Renglon("TOLLS_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTOLLS_TAN"), Label).Text
                    Renglon("TOLLS_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtTOLLS_TAN"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("SERVICE") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblSERVICE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("WEIGHT_SIN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblWEIGHT_SIN"), Label).Text
                    Renglon("WEIGHT_TAN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblWEIGHT_TAN"), Label).Text
                    Renglon("FREE_HOURS") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblFREE_HOURS"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerCH.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt


    End Function


    Public Function Obj_INTERMODAL(ByVal GVSerINTERMODAL As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_INTERMODALB()
        Try
            If Not GVSerINTERMODAL.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerINTERMODAL.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("ORIGIN_RAMP") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblORIGIN_RAMP"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text

                    Renglon("ROUTE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblROUTE"), Label).Text
                    Renglon("MODE_CODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblMODE_CODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("DESTINATION_RAMP") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblDESTINATION_RAMP"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text

                    Renglon("CURRENCY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("SUBTOTAL") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblSUBTOTAL"), Label).Text
                    Renglon("FSC") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                    Renglon("FSC_TOTAL") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblFSC_TOTAL"), Label).Text
                    Renglon("TOTAL_US") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LbLTOTAL_US"), Label).Text
                    Renglon("TOTAL_US") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("TxtTOTAL_US"), TextBox).Text

                    Renglon("EQUIPMENT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_INTERMODAL(ByVal GVSerINTERMODAL As GridView, ByVal GvBusINTERMODAL As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_INTERMODAL(GVSerINTERMODAL)

        Try
            If Not GvBusINTERMODAL.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusINTERMODAL.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()

                        Renglon("id_num") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("CARRIER") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                        Renglon("ORIGIN") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                        Renglon("ORIGIN_RAMP") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblORIGIN_RAMP"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POL_ZIPCODE") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text

                        Renglon("ROUTE") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblROUTE"), Label).Text
                        Renglon("MODE_CODE") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblMODE_CODE"), Label).Text
                        Renglon("DESTINATION") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                        Renglon("DESTINATION_RAMP") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblDESTINATION_RAMP"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                        Renglon("POD_ZIPCODE") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text

                        Renglon("CURRENCY") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                        Renglon("SUBTOTAL") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblSUBTOTAL"), Label).Text
                        Renglon("FSC") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                        Renglon("FSC_TOTAL") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblFSC_TOTAL"), Label).Text
                        Renglon("TOTAL_US") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LbLTOTAL_US"), Label).Text
                        Renglon("TOTAL_US") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("TxtTOTAL_US"), TextBox).Text

                        Renglon("EQUIPMENT") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("TT") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("NAC") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("VOLUMEN") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                        Renglon("SUBJECT") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                        Renglon("REMARKS") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusINTERMODAL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_INTERMODAL(ByVal GVSerINTERMODAL As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_INTERMODALB()

        Try
            If Not GVSerINTERMODAL.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerINTERMODAL.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("ORIGIN_RAMP") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblORIGIN_RAMP"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("ROUTE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblROUTE"), Label).Text
                    Renglon("MODE_CODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblMODE_CODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("DESTINATION_RAMP") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblDESTINATION_RAMP"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("SUBTOTAL") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblSUBTOTAL"), Label).Text
                    Renglon("FSC") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                    Renglon("FSC_TOTAL") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblFSC_TOTAL"), Label).Text
                    Renglon("TOTAL_US") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LbLTOTAL_US"), Label).Text
                    Renglon("TOTAL_US") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("TxtTOTAL_US"), TextBox).Text
                    Renglon("EQUIPMENT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerINTERMODAL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function


    Public Function Obj_LCL(ByVal GVSerLCL As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_LCLB()
        Try
            If Not GVSerLCL.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerLCL.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CO_LOADER") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCO_LOADER"), Label).Text

                    Renglon("AGENT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                    Renglon("COST") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCOST"), Label).Text
                    Renglon("COST2") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("TxtCOST"), TextBox).Text
                    Renglon("MIN_COST") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblMIN_COST"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text

                    Renglon("VIA1") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                    Renglon("VIA2") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                    Renglon("VIA3") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text

                    Renglon("CURRENCY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("FREQUENCY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblFREQUENCY"), Label).Text

                    Renglon("EQUIPMENT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("FREE_DAYS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                    Renglon("NAC") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("RA") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("ADDMON_FEE") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblADDMON_FEE"), Label).Text
                    Renglon("BL") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblBL"), Label).Text
                    Renglon("PORT_TRANSFER") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPORT_TRANSFER"), Label).Text
                    Renglon("STUFFINNG") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblSTUFFINNG"), Label).Text
                    Renglon("VGM_SOLAS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVGM_SOLAS"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_LCL(ByVal GVSerLCL As GridView, ByVal GvBusLCL As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_LCL(GVSerLCL)

        Try
            If Not GvBusLCL.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusLCL.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()

                        Renglon("id_num") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("CO_LOADER") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblCO_LOADER"), Label).Text

                        Renglon("AGENT") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                        Renglon("COST") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblCOST"), Label).Text
                        Renglon("COST2") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("TxtCOST"), TextBox).Text
                        Renglon("MIN_COST") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblMIN_COST"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text

                        Renglon("VIA1") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                        Renglon("VIA2") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                        Renglon("VIA3") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text

                        Renglon("CURRENCY") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                        Renglon("FREQUENCY") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblFREQUENCY"), Label).Text

                        Renglon("EQUIPMENT") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("TT") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                        Renglon("FREE_DAYS") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                        Renglon("NAC") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("RA") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("ADDMON_FEE") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblADDMON_FEE"), Label).Text
                        Renglon("BL") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblBL"), Label).Text
                        Renglon("PORT_TRANSFER") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblPORT_TRANSFER"), Label).Text
                        Renglon("STUFFINNG") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblSTUFFINNG"), Label).Text
                        Renglon("VGM_SOLAS") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblVGM_SOLAS"), Label).Text
                        Renglon("SUBJECT") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                        Renglon("REMARKS") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusLCL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_LCL(ByVal GVSerLCL As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_LCLB()

        Try
            If Not GVSerLCL.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerLCL.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CO_LOADER") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCO_LOADER"), Label).Text
                    Renglon("AGENT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblAGENT"), Label).Text
                    Renglon("COST") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCOST"), Label).Text
                    Renglon("COST2") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("TxtCOST"), TextBox).Text
                    Renglon("MIN_COST") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblMIN_COST"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text

                    Renglon("VIA1") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVIA1"), Label).Text
                    Renglon("VIA2") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVIA2"), Label).Text
                    Renglon("VIA3") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVIA3"), Label).Text

                    Renglon("CURRENCY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("FREQUENCY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblFREQUENCY"), Label).Text

                    Renglon("EQUIPMENT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("FREE_DAYS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                    Renglon("NAC") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("RA") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("ADDMON_FEE") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblADDMON_FEE"), Label).Text
                    Renglon("BL") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblBL"), Label).Text
                    Renglon("PORT_TRANSFER") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblPORT_TRANSFER"), Label).Text
                    Renglon("STUFFINNG") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblSTUFFINNG"), Label).Text
                    Renglon("VGM_SOLAS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblVGM_SOLAS"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerLCL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function


    Public Function Obj_LTL(ByVal GVSerLTL As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_LTLB()
        Try
            If Not GVSerLTL.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerLTL.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text

                    Renglon("QUANTITY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblQUANTITY"), Label).Text
                    Renglon("TYPE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTYPE"), Label).Text
                    Renglon("TOTAL_WEIGHT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTOTAL_WEIGHT"), Label).Text
                    Renglon("WEIGHT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblWEIGHT"), Label).Text
                    Renglon("LARGE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblLARGE"), Label).Text


                    Renglon("WIDTH") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblWIDTH"), Label).Text
                    Renglon("HEIGHT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblHEIGHT"), Label).Text
                    Renglon("STACKABLE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblSTACKABLE"), Label).Text

                    Renglon("TOTAL") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTOTAL"), Label).Text
                    Renglon("TOTAL") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("TxtTOTAL"), TextBox).Text

                    Renglon("CROSSBORDER") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCROSSBORDER"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("NAC") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text

                    Renglon("SUBJECT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_LTL(ByVal GVSerLTL As GridView, ByVal GvBusLTL As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_LTL(GVSerLTL)

        Try
            If Not GvBusLTL.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusLTL.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()

                        Renglon("id_num") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("CARRIER") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                        Renglon("ORIGIN") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POL_ZIPCODE") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                        Renglon("DESTINATION") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                        Renglon("POD_ZIPCODE") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                        Renglon("CURRENCY") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text

                        Renglon("QUANTITY") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblQUANTITY"), Label).Text
                        Renglon("TYPE") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblTYPE"), Label).Text
                        Renglon("TOTAL_WEIGHT") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblTOTAL_WEIGHT"), Label).Text
                        Renglon("WEIGHT") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblWEIGHT"), Label).Text
                        Renglon("LARGE") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblLARGE"), Label).Text


                        Renglon("WIDTH") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblWIDTH"), Label).Text
                        Renglon("HEIGHT") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblHEIGHT"), Label).Text
                        Renglon("STACKABLE") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblSTACKABLE"), Label).Text

                        Renglon("TOTAL") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblTOTAL"), Label).Text
                        Renglon("TOTAL") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("TxtTOTAL"), TextBox).Text

                        Renglon("CROSSBORDER") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblCROSSBORDER"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("TT") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                        Renglon("NAC") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("VOLUMEN") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text

                        Renglon("SUBJECT") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                        Renglon("REMARKS") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusLTL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_LTL(ByVal GVSerLTL As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_LTLB()

        Try
            If Not GVSerLTL.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerLTL.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text

                    Renglon("QUANTITY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblQUANTITY"), Label).Text
                    Renglon("TYPE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTYPE"), Label).Text
                    Renglon("TOTAL_WEIGHT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTOTAL_WEIGHT"), Label).Text
                    Renglon("WEIGHT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblWEIGHT"), Label).Text
                    Renglon("LARGE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblLARGE"), Label).Text


                    Renglon("WIDTH") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblWIDTH"), Label).Text
                    Renglon("HEIGHT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblHEIGHT"), Label).Text
                    Renglon("STACKABLE") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblSTACKABLE"), Label).Text

                    Renglon("TOTAL") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTOTAL"), Label).Text
                    Renglon("TOTAL") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("TxtTOTAL"), TextBox).Text

                    Renglon("CROSSBORDER") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCROSSBORDER"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("NAC") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text

                    Renglon("SUBJECT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerLTL.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function


    Public Function Obj_TLM(ByVal GVSerTLM As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_TLMB()
        Try
            If Not GVSerTLM.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerTLM.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("STOP") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSTOP"), Label).Text
                    Renglon("STOP2") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSTOP2"), Label).Text
                    Renglon("STOP3") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSTOP3"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("TOTAL_RATE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblTOTALRATE"), Label).Text
                    Renglon("TOTAL_RATE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("TxtTOTALRATE"), TextBox).Text

                    Renglon("KM") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblKM"), Label).Text
                    Renglon("FSC") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                    Renglon("FSC_TOTAL") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFSC_TOTAL"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("FREE_DAYS") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text

                    Renglon("SUBJECT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    Renglon("FREE_HRS_LOA_UNLOA") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFREE_HRS_LOA_UNLOA"), Label).Text
                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_TLM(ByVal GVSerTLM As GridView, ByVal GvBusTLM As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_TLM(GVSerTLM)

        Try
            If Not GvBusTLM.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusTLM.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()

                        Renglon("id_num") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("CARRIER") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                        Renglon("ORIGIN") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POL_ZIPCODE") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                        Renglon("DESTINATION") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                        Renglon("POD_ZIPCODE") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                        Renglon("STOP") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblSTOP"), Label).Text
                        Renglon("STOP2") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblSTOP2"), Label).Text
                        Renglon("STOP3") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblSTOP3"), Label).Text
                        Renglon("CURRENCY") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                        Renglon("TOTAL_RATE") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblTOTALRATE"), Label).Text
                        Renglon("TOTAL_RATE") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("TxtTOTALRATE"), TextBox).Text

                        Renglon("KM") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblKM"), Label).Text
                        Renglon("FSC") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                        Renglon("FSC_TOTAL") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblFSC_TOTAL"), Label).Text
                        Renglon("EQUIPMENT") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("TT") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                        Renglon("FREE_DAYS") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("NAC") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("VOLUMEN") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text

                        Renglon("SUBJECT") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                        Renglon("REMARKS") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                        Renglon("REMARKS") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                        Renglon("FREE_HRS_LOA_UNLOA") = CType(GvBusTLM.Rows(contador).Cells(0).FindControl("LblFREE_HRS_LOA_UNLOA"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_TLM(ByVal GVSerTLM As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_TLMB()

        Try
            If Not GVSerTLM.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerTLM.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()


                    Renglon("id_num") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("STOP") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSTOP"), Label).Text
                    Renglon("STOP2") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSTOP2"), Label).Text
                    Renglon("STOP3") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSTOP3"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("TOTAL_RATE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblTOTALRATE"), Label).Text
                    Renglon("TOTAL_RATE") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("TxtTOTALRATE"), TextBox).Text

                    Renglon("KM") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblKM"), Label).Text
                    Renglon("FSC") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                    Renglon("FSC_TOTAL") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFSC_TOTAL"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("FREE_DAYS") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text

                    Renglon("SUBJECT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("TxtREMARKS"), TextBox).Text
                    Renglon("REMARKS") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    Renglon("FREE_HRS_LOA_UNLOA") = CType(GVSerTLM.Rows(contador).Cells(0).FindControl("LblFREE_HRS_LOA_UNLOA"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function


    Public Function Obj_TLU(ByVal GVSerTLU As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_TLUB()
        Try
            If Not GVSerTLU.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerTLU.Rows.Count - 1 Step contador + 1
                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("MILES") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblMILES"), Label).Text
                    Renglon("RPM") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblRPM"), Label).Text
                    Renglon("SUBTOTAL") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblSUBTOTAL"), Label).Text
                    Renglon("FSC") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                    Renglon("TOTAL_US") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblTOTAL_US"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("FREE_DAYS") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    Dt.Rows.Add(Renglon)

                Next
            End If
        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Add_Par_TLU(ByVal GVSerTLU As GridView, ByVal GvBusTLU As GridView) As DataTable
        Dim Dt As DataTable

        Dt = Obj_TLU(GVSerTLU)

        Try
            If Not GvBusTLU.Rows.Count = 0 Then
                For contador As Integer = 0 To GvBusTLU.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked
                    If Revisar = True Then
                        Dim Renglon As DataRow = Dt.NewRow()
                        Renglon = Dt.NewRow()

                        Renglon("id_num") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                        Renglon("CARRIER") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                        Renglon("ORIGIN") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                        Renglon("POL_CODE") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                        Renglon("POL") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                        Renglon("POL_CODE_COUNTRY") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                        Renglon("POL_COUNTRY") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                        Renglon("POL_ZIPCODE") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                        Renglon("DESTINATION") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                        Renglon("POD_CODE") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                        Renglon("POD") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                        Renglon("POD_CODE_COUNTRY") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                        Renglon("POD_COUNTRY") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                        Renglon("POD_ZIPCODE") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                        Renglon("CURRENCY") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                        Renglon("MILES") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblMILES"), Label).Text
                        Renglon("RPM") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblRPM"), Label).Text
                        Renglon("SUBTOTAL") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblSUBTOTAL"), Label).Text
                        Renglon("FSC") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                        Renglon("TOTAL_US") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblTOTAL_US"), Label).Text
                        Renglon("EQUIPMENT") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                        Renglon("VALIDITY_FROM") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                        Renglon("VALIDITY_TO") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                        Renglon("TT") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                        Renglon("FREE_DAYS") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                        Renglon("COMMODITY") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                        Renglon("NAC") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                        Renglon("VOLUMEN") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                        Renglon("SUBJECT") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                        Renglon("NOT_SUBJECT") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                        Renglon("REMARKS") = CType(GvBusTLU.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                        Dt.Rows.Add(Renglon)

                    End If
                Next
            End If


        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function

    Private Function Delete_Par_TLU(ByVal GVSerTLU As GridView) As DataTable
        Dim Dt As DataTable
        Dt = Obj_TLUB()

        Try
            If Not GVSerTLU.Rows.Count = 0 Then
                For contador As Integer = 0 To GVSerTLU.Rows.Count - 1 Step contador + 1
                    Dim Revisar As Boolean = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("CheckBox1"), CheckBox).Checked

                    Dim Renglon As DataRow = Dt.NewRow()
                    Renglon = Dt.NewRow()

                    Renglon("id_num") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblId"), Label).Text
                    Renglon("CARRIER") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblCARRIER"), Label).Text
                    Renglon("ORIGIN") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblORIGIN"), Label).Text
                    Renglon("POL_CODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_CODE"), Label).Text
                    Renglon("POL") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL"), Label).Text
                    Renglon("POL_CODE_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY"), Label).Text
                    Renglon("POL_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY"), Label).Text
                    Renglon("POL_ZIPCODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOL_ZIPCODE"), Label).Text
                    Renglon("DESTINATION") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblDESTINATION"), Label).Text
                    Renglon("POD_CODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_CODE"), Label).Text
                    Renglon("POD") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD"), Label).Text
                    Renglon("POD_CODE_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY"), Label).Text
                    Renglon("POD_COUNTRY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY"), Label).Text
                    Renglon("POD_ZIPCODE") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblPOD_ZIPCODE"), Label).Text
                    Renglon("CURRENCY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblCURRENCY"), Label).Text
                    Renglon("MILES") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblMILES"), Label).Text
                    Renglon("RPM") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblRPM"), Label).Text
                    Renglon("SUBTOTAL") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblSUBTOTAL"), Label).Text
                    Renglon("FSC") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblFSC"), Label).Text
                    Renglon("TOTAL_US") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblTOTAL_US"), Label).Text
                    Renglon("EQUIPMENT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Renglon("VALIDITY_FROM") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Renglon("VALIDITY_TO") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text
                    Renglon("TT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Renglon("FREE_DAYS") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblFREE_DAYS"), Label).Text
                    Renglon("COMMODITY") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text
                    Renglon("NAC") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Renglon("VOLUMEN") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblVOLUMEN"), Label).Text
                    Renglon("SUBJECT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Renglon("NOT_SUBJECT") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Renglon("REMARKS") = CType(GVSerTLU.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    If Revisar = True Then
                    Else
                        Dt.Rows.Add(Renglon)
                    End If
                Next
            End If

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Horrror - " + ex.Message)
        End Try

        Return Dt

    End Function
End Class