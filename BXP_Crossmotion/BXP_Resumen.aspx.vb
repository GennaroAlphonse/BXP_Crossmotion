Public Class BXP_Resumen
    Inherits System.Web.UI.Page

    Public Shared sehizocambio1 As Boolean = False
    Public Shared sehizocambio2 As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            CalendarDesde.Visible = False
            CalendarAl.Visible = False
            'TxtFechaDesde.Text = Now.ToShortDateString
            'TxtFechaAl.Text = CDate(Now.ToShortDateString).AddDays(30)
            Autorizacion()
            'PnlCancelar.Visible = False
            'PnlCorreo.Visible = False
            CheckBox3.Checked = True
            CheckBox5.Checked = True
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox4.Checked = True
            CheckBox6.Checked = True

            LlenarTabla()
            'BtnCotizaciones.Enabled = False

            'TxtORIGIN.Attributes.Add("onKeyPress", "doClick('" + BtnBuscar2.ClientID + "',event)")
            'TxtDESTINATION.Attributes.Add("onKeyPress", "doClick('" + BtnBuscar2.ClientID + "',event)")

            'TxtORIGIN.Attributes.Add("onkeypress", "javascript:return clickButton(event,'" + BtnBuscar2.ClientID + "');")
            'TxtDESTINATION.Attributes.Add("onkeypress", "javascript:return clickButton(event,'" + BtnBuscar2.ClientID + "');")

            'Master.FindControl("Panel1")

        End If

    End Sub


    Private Sub Autorizacion()

    End Sub
    Private Sub LlenarTabla()
        Try

            Dim Ws As New BXP_WebServiceSQL
            Dim Ds As DataSet = Ws.Query1(Query)

            GVTabla.DataSource = Ds
            'GVTabla.PageIndex = 0
            GVTabla.DataBind()

            Colorear2()

            Colorear()

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar tabla Resumen - " + ex.Message)
        End Try


    End Sub

    Private Sub LlenarTabla2()
        Try

            Dim Ws As New BXP_WebServiceSQL
            Dim Ds As DataSet = Ws.Query1(Query2)

            GVTabla.DataSource = Ds
            'GVTabla.PageIndex = 0
            GVTabla.DataBind()

            Colorear2()

            Colorear()



        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al llenar tabla Resumen - " + ex.Message)
        End Try


    End Sub


    Private Sub Colorear()
        For contador As Integer = 0 To GVTabla.Rows.Count - 1 Step contador + 1
            Dim LabelEstatus As Label = GVTabla.Rows(contador).FindControl("LblEstatus")
            'Dim Ds As DataSet = WebSer.Query01("Select * From [" + Session("Empresa") + "].dbo.OCRN")

            If LabelEstatus.Text = "Incomplete" Then
                LabelEstatus.ForeColor = Drawing.Color.Red
            ElseIf LabelEstatus.Text = "Pending" Then
                LabelEstatus.ForeColor = Drawing.Color.Aqua
            ElseIf LabelEstatus.Text = "Delivered" Then
                LabelEstatus.ForeColor = Drawing.Color.Blue
            ElseIf LabelEstatus.Text = "Accepted" Then
                LabelEstatus.ForeColor = Drawing.Color.Yellow
            ElseIf LabelEstatus.Text = "Rejected" Then
                LabelEstatus.ForeColor = Drawing.Color.Violet
                'GVTabla.Rows(contador).BackColor = Drawing.Color.Red
            End If

            'LabelEstatus.BackColor = Drawing.Color.Red

            'Combo.DataSource = Ds
            'Combo.DataTextField = "CurrCode"
            'Combo.DataBind()
        Next
    End Sub

    Private Sub Colorear2()
        For contador As Integer = 0 To GVTabla.Rows.Count - 1 Step contador + 1
            Dim LabelEstatus As Label = GVTabla.Rows(contador).FindControl("LblFechaCaduca")
            'Dim Ds As DataSet = WebSer.Query01("Select * From [" + Session("Empresa") + "].dbo.OCRN")

            If CDate(LabelEstatus.Text) < Now.ToShortDateString Then
                LabelEstatus.ForeColor = Drawing.Color.Red
            ElseIf CDate(LabelEstatus.Text) < CDate(Now.ToShortDateString).AddDays(10) Then
                LabelEstatus.ForeColor = Drawing.Color.Yellow
            Else
                'GVTabla.Rows(contador).BackColor = Drawing.Color.Red
            End If

            'LabelEstatus.BackColor = Drawing.Color.Red

            'Combo.DataSource = Ds
            'Combo.DataTextField = "CurrCode"
            'Combo.DataBind()
        Next
    End Sub


    Private Function BuscarIdEmpleado() As String
        Dim SlpCode As String = "5"
        Try
            Dim Ws As New BXP_WebServiceSQL
            Dim Usuario As String = ReadCookie("Usuario", "Usuario")
            Dim sQuery As String = "SELECT MAX(salesPrson) FROM [Prototipo_Desarrollos].[dbo].OHEM WHERE U_usuario = '" + Usuario + "' "

            'Dim Log As New BXP_Log
            'Log.EventLog("Query BuscarIdEmpleado- " + sQuery)



            SlpCode = Ws.Query2(sQuery)

            If SlpCode = "15" Then
                SlpCode = "8"
            End If

        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al buscar id empleado - " + ex.Message)
        End Try

        Return SlpCode
    End Function

    Private Function Query() As String

        Dim TextoOrigin As String
        Dim TextoDestination As String

        'Dim LenOrigin As Integer = TxtORIGIN.Text.Length
        'If Regex.Matches(TxtORIGIN.Text.Substring(3, LenOrigin - 3).Trim, "[A-Z]{3}") Then


        'End If

        If TxtORIGIN.Text <> "" And TxtORIGIN.Text.Contains("/") Then
            Dim LenOrigin As Integer = TxtORIGIN.Text.Length
            TextoOrigin = TxtORIGIN.Text.Substring(8, LenOrigin - 8).Trim
        ElseIf TxtORIGIN.Text <> "" Then
            TextoOrigin = TxtORIGIN.Text.Trim
        Else
            TextoOrigin = ""
        End If

        If TxtDESTINATION.Text <> "" And TxtDESTINATION.Text.Contains("/") Then
            Dim LenDestination As Integer = TxtDESTINATION.Text.Length
            TextoDestination = TxtDESTINATION.Text.Substring(8, LenDestination - 8).Trim
        ElseIf TxtDESTINATION.Text <> "" Then
            TextoDestination = TxtDESTINATION.Text.Trim
        Else
            TextoDestination = ""
        End If

        Dim Status As String = ""
        Dim contador As Integer = 0

        If CheckBox3.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Incomplete'"
            contador = contador + 1
        Else
            If Status.Contains(",'Incomplete'") Then
                Status = Status.Replace(",'Incomplete'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Incomplete'") Then
                Status = Status.Replace("'Incomplete'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox5.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Pending'"
            contador = contador + 1
        Else
            If Status.Contains(",'Pending'") Then
                Status = Status.Replace(",'Pending'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Pending'") Then
                Status = Status.Replace("'Pending'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox1.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Delivered'"
            contador = contador + 1
        Else
            If Status.Contains(",'Delivered'") Then
                Status = Status.Replace(",'Delivered'", "")
                contador = contador + 1
            ElseIf Status.Contains("'Delivered'") Then
                Status = Status.Replace("'Delivered'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox2.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Not Approved'"
            contador = contador + 1
        Else
            If Status.Contains(",'Not Approved'") Then
                Status = Status.Replace(",'Not Approved'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Not Approved'") Then
                Status = Status.Replace("'Not Approved'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox4.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Accepted'"
            contador = contador + 1
        Else
            If Status.Contains(",'Accepted'") Then
                Status = Status.Replace(",'Accepted'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Accepted'") Then
                Status = Status.Replace("'Accepted'", "")
                contador = contador - 1
            End If

        End If

        If CheckBox6.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Cancelled'"
            contador = contador + 1
        Else
            If Status.Contains(",Cancelled'") Then
                Status = Status.Replace(",'Cancelled'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Cancelled'") Then
                Status = Status.Replace("'Cancelled'", "")
                contador = contador - 1
            End If

        End If

        Dim valorIncoterm As String
        Dim valorKind As String

        If DdlIncoterm.Text = "FREE ON BOARD" Then
            valorIncoterm = "FOB"
        ElseIf DdlIncoterm.Text = "EX WORKS" Then
            valorIncoterm = "EW"
        ElseIf DdlIncoterm.Text = "DELIVERED AT TERMINAL" Then
            valorIncoterm = "DAT"
        ElseIf DdlIncoterm.Text = "DELIVERED AT PLACE" Then
            valorIncoterm = "DAP"
        ElseIf DdlIncoterm.Text = "CARRIAGE PAID TO" Then
            valorIncoterm = "CPT"
        ElseIf DdlIncoterm.Text = "CARRIAGE AND INSURANCE" Then
            valorIncoterm = "CAI"
        ElseIf DdlIncoterm.Text = "COST AND FREIGHT" Then
            valorIncoterm = "CAF"
        Else
            valorIncoterm = ""
        End If

        If DdlKind.Text = "REPETITIVE" Then
            valorKind = "RE"
        ElseIf DdlKind.Text = "ONE SHOT" Then
            valorKind = "OS"
        Else
            valorKind = ""
        End If

        Dim FechaDesde As String
        Dim FechaHasta As String


        FechaDesde = CalendarDesde.SelectedDate.ToString("yyyy-MM-dd")
        FechaHasta = CalendarAl.SelectedDate.ToString("yyyy-MM-dd")


        Dim sQuery As String = "SELECT A.U_FolioCrossmotion, A.DocNum, A.DocEntry, A.U_BXP_MET_TRANSPORT, A.CardCode, A.CardName, A.SlpCode, B.SlpName, C.U_POL_COUNTRY, C.U_POD_COUNTRY, CAST(C.U_Validity_From AS DATE) U_Validity_From, CAST(C.U_Validity_To As DATE) U_Validity_To, A.U_SHOT_REPETITIVE, A.U_BXP_INCOTERM, D.Estatus, C.U_NAC, T2.descript "

        sQuery += "FROM [Prototipo_Desarrollos].[dbo].OQUT A LEFT JOIN [Prototipo_Desarrollos].[dbo].OSLP B ON A.SlpCode = B.SlpCode "
        sQuery += "LEFT JOIN (SELECT * FROM [Prototipo_Desarrollos].[dbo].QUT1 WHERE VisOrder = '0') C ON C.DocEntry = A.DocEntry "
        sQuery += "left join [BXP_Polimeros].dbo.BXP_Estatus As D On A.U_IdWeb COLLATE SQL_Latin1_General_CP1_CI_AS = D.Id INNER Join [Prototipo_Desarrollos].[dbo].OCRD T1 ON A.CardCode = T1.CardCode "
        sQuery += "left OUTER JOIN [Prototipo_Desarrollos].[dbo].OTER T2 ON T1.Territory = T2.territryID WHERE T1.CardType = 'C' "

        If Not String.IsNullOrEmpty(TxtFILE.Text) Then
            sQuery += "AND A.U_FolioCrossmotion Like '%" + TxtFILE.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtMODALITY.Text) Then
            sQuery += "AND A.U_BXP_MET_TRANSPORT like '%" + TxtMODALITY.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtName.Text) Then
            sQuery += "AND A.CardName like '%" + TxtName.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtSELLER.Text) Then
            sQuery += "AND B.SlpName like '%" + TxtSELLER.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtREGION.Text) Then
            sQuery += "AND T2.descript like '%" + TxtREGION.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TextoOrigin) Then
            sQuery += "AND C.U_POL_COUNTRY like '%" + TextoOrigin.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TextoDestination) Then
            sQuery += "AND C.U_POD_COUNTRY like '%" + TextoDestination.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtFechaDesde.Text) Then
            sQuery += "AND C.U_Validity_From >= '" + FechaDesde + "' "
        End If

        If Not String.IsNullOrEmpty(TxtFechaAl.Text) Then
            sQuery += "AND C.U_Validity_To <= '" + FechaHasta + "' "
        End If

        If Not String.IsNullOrEmpty(TxtFAKNAC.Text) Then
            sQuery += "AND C.U_NAC like '%" + TxtFAKNAC.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(valorKind) Then
            sQuery += "AND A.U_SHOT_REPETITIVE like '%" + valorKind + "%' "
        End If

        If Not String.IsNullOrEmpty(valorIncoterm) Then
            sQuery += " And A.U_BXP_INCOTERM Like '%" + valorIncoterm + "%'  "
        End If

        If Not String.IsNullOrEmpty(Status) Then
            sQuery += "AND D.Estatus IN (" + Status + ") "
        End If

        sQuery += "ORDER BY A.DocNum DESC"

        Dim Log As New BXP_Log
        Log.EventLog("Query tabla Resumen - " + sQuery)


        Return sQuery


        'sQuery += "SELECT U_FolioCrossmotion, DocNum, LicTradNum, CardName, SlpName, DocCur, DocTotal, DocTotalFC, DocDate, DocDueDate, C.Estatus As Estatus, DocEntry "
        'sQuery += "from [Prototipo_Desarrollos].[dbo].OQUT As a left join [Prototipo_Desarrollos].[dbo].OSLP as b on a.SlpCode = b.SlpCode  "
        'sQuery += "left join [BXP_Polimeros].dbo.BXP_Estatus As C On A.DocNum = C.Id "
        'sQuery += "where ( 1 = 1 "


        'If ReadCookie("Usuario", "Usuario") = "Rodrigo" Or ReadCookie("Usuario", "Usuario") = "rodrigo" Then
        'If Not String.IsNullOrEmpty(TxtVendedor.Text) Then
        'sQuery += " and b.SlpName like '%" + TxtVendedor.Text + "%' "
        'End If
        'Else
        'sQuery += " and a.SlpCode = '" + BuscarIdEmpleado() + "' "
        'End If


        'If Not String.IsNullOrEmpty(TxtRFC.Text) Then
        'sQuery += " and a.LicTradNum like '%" + TxtRFC.Text + "%' "
        'End If



        'If Not String.IsNullOrEmpty(TxtRazonSocial.Text) Then
        'sQuery += " and a.CardName like '%" + TxtRazonSocial.Text + "%' "
        'End If

        'sQuery += "a.CardName like '%" + TxtBuscar.Text + "%' or "

        'sQuery += "a.DocCur like '%" + TxtBuscar.Text + "%') "

        'sQuery += ") "

        'If Not String.IsNullOrEmpty(TxtFechaDesde.Text) Then
        'sQuery += "and a.DocDate >= '" + TxtFechaDesde.Text + "' "
        'End If

        'If Not String.IsNullOrEmpty(TxtFechaAl.Text) Then
        'sQuery += "and a.DocDate <= '" + TxtFechaAl.Text + "' "
        'End If

        'If ChBAbiertos.Checked = True Then
        'sQuery += "and a.DocStatus = 'O' "
        'Else
        'sQuery += "and a.DocStatus = 'C' "
        'End If

        'If ChBCancelado.Checked = True Then
        'sQuery += "and a.CANCELED = 'Y' "
        'Else
        'sQuery += "and a.CANCELED = 'N' "
        'End If

        'If ReadCookie("Usuario", "Usuario") = "Rodrigo" Or ReadCookie("Usuario", "Usuario") = "rodrigo" Then



        'sQuery += "UNION ALL "
        'sQuery += "SELECT U_FolioCrossmotion COLLATE SQL_Latin1_General_CP1_CI_AS, DocNum, 'AME9703121Z6' As LicTradNum, 'ACABADOS MEXICANOS SA DE CV' As CardName, 'JAQUELINE CORTES' As SlpName, 'MXP' As DocCur, 0 As DocTotal, 0 As DocTotalFC, ' ' As DocDate, ' ' As DocDueDate, 'Pending' As Estatus, DocNum As DocEntry "
        'sQuery += "FROM (SELECT FolioWeb As U_FolioCrossmotion, Id As DocNum "
        'sQuery += "FROM BXP_Polimeros.dbo.Pedido  "
        'sQuery += "WHERE Auto = 'False') As T0 "

        'End If

        'sQuery += "Order By DocNum desc "

        'Return sQuery

        'ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "alert('" + sQuery + "');", True)
        'Response.Write("<script>window.alert('" + sQuery + "');</script>")
        'Response.Write("<script>console.log('" + sQuery + "')</script>")
        'Response.Write("<script language=""javascript"">alert('" + sQuery + "');</script>")
        'MsgBox(sQuery)

        'Dim sb As New System.Text.StringBuilder()
        'sb.Append("<script type = 'text/javascript'>")
        'sb.Append("window.onload=function(){")
        'sb.Append("alert('")
        'sb.Append(sQuery)
        'sb.Append("')};")
        'sb.Append("</script>")
        'ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())

    End Function

    Private Function Query2() As String

        Dim Status As String = ""
        Dim contador As Integer = 0

        If CheckBox3.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Incomplete'"
            contador = contador + 1
        Else
            If Status.Contains(",'Incomplete'") Then
                Status = Status.Replace(",'Incomplete'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Incomplete'") Then
                Status = Status.Replace("'Incomplete'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox5.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Pending'"
            contador = contador + 1
        Else
            If Status.Contains(",'Pending'") Then
                Status = Status.Replace(",'Pending'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Pending'") Then
                Status = Status.Replace("'Pending'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox1.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Delivered'"
            contador = contador + 1
        Else
            If Status.Contains(",'Delivered'") Then
                Status = Status.Replace(",'Delivered'", "")
                contador = contador + 1
            ElseIf Status.Contains("'Delivered'") Then
                Status = Status.Replace("'Delivered'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox2.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Not Approved'"
            contador = contador + 1
        Else
            If Status.Contains(",'Not Approved'") Then
                Status = Status.Replace(",'Not Approved'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Not Approved'") Then
                Status = Status.Replace("'Not Approved'", "")
                contador = contador - 1
            End If
        End If

        If CheckBox4.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Accepted'"
            contador = contador + 1
        Else
            If Status.Contains(",'Accepted'") Then
                Status = Status.Replace(",'Accepted'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Accepted'") Then
                Status = Status.Replace("'Accepted'", "")
                contador = contador - 1
            End If

        End If

        If CheckBox6.Checked = True Then
            If contador > 0 Then
                Status &= ","
            End If
            Status &= "'Cancelled'"
            contador = contador + 1
        Else
            If Status.Contains(",Cancelled'") Then
                Status = Status.Replace(",'Cancelled'", "")
                contador = contador - 1
            ElseIf Status.Contains("'Cancelled'") Then
                Status = Status.Replace("'Cancelled'", "")
                contador = contador - 1
            End If

        End If

        Dim valorIncoterm As String
        Dim valorKind As String

        If DdlIncoterm.Text = "FREE ON BOARD" Then
            valorIncoterm = "FOB"
        ElseIf DdlIncoterm.Text = "EX WORKS" Then
            valorIncoterm = "EW"
        ElseIf DdlIncoterm.Text = "DELIVERED AT TERMINAL" Then
            valorIncoterm = "DAT"
        ElseIf DdlIncoterm.Text = "DELIVERED AT PLACE" Then
            valorIncoterm = "DAP"
        ElseIf DdlIncoterm.Text = "CARRIAGE PAID TO" Then
            valorIncoterm = "CPT"
        ElseIf DdlIncoterm.Text = "CARRIAGE AND INSURANCE" Then
            valorIncoterm = "CAI"
        ElseIf DdlIncoterm.Text = "COST AND FREIGHT" Then
            valorIncoterm = "CAF"
        Else
            valorIncoterm = ""
        End If

        If DdlKind.Text = "REPETITIVE" Then
            valorKind = "RE"
        ElseIf DdlKind.Text = "ONE SHOT" Then
            valorKind = "OS"
        Else
            valorKind = ""
        End If

        Dim FechaDesde As String
        Dim FechaHasta As String


        FechaDesde = CalendarDesde.SelectedDate.ToString("yyyy-MM-dd")
        FechaHasta = CalendarAl.SelectedDate.ToString("yyyy-MM-dd")


        Dim sQuery As String = "SELECT A.U_FolioCrossmotion, A.DocNum, A.DocEntry, A.U_BXP_MET_TRANSPORT, A.CardCode, A.CardName, A.SlpCode, B.SlpName, C.U_POL_COUNTRY, C.U_POD_COUNTRY, CAST(C.U_Validity_From AS DATE) U_Validity_From, CAST(C.U_Validity_To As DATE) U_Validity_To, A.U_SHOT_REPETITIVE, A.U_BXP_INCOTERM, D.Estatus, C.U_NAC, T2.descript "

        sQuery += "FROM [Prototipo_Desarrollos].[dbo].OQUT A LEFT JOIN [Prototipo_Desarrollos].[dbo].OSLP B ON A.SlpCode = B.SlpCode "
        sQuery += "LEFT JOIN (SELECT * FROM [Prototipo_Desarrollos].[dbo].QUT1 WHERE VisOrder = '0') C ON C.DocEntry = A.DocEntry "
        sQuery += "left join [BXP_Polimeros].dbo.BXP_Estatus As D On A.U_IdWeb COLLATE SQL_Latin1_General_CP1_CI_AS = D.Id INNER Join [Prototipo_Desarrollos].[dbo].OCRD T1 ON A.CardCode = T1.CardCode "
        sQuery += "left OUTER JOIN [Prototipo_Desarrollos].[dbo].OTER T2 ON T1.Territory = T2.territryID WHERE T1.CardType = 'C' "

        If Not String.IsNullOrEmpty(TxtFILE.Text) Then
            sQuery += "AND A.U_FolioCrossmotion Like '%" + TxtFILE.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtMODALITY.Text) Then
            sQuery += "AND A.U_BXP_MET_TRANSPORT like '%" + TxtMODALITY.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtName.Text) Then
            sQuery += "AND A.CardName like '%" + TxtName.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtSELLER.Text) Then
            sQuery += "AND B.SlpName like '%" + TxtSELLER.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtREGION.Text) Then
            sQuery += "AND T2.descript like '%" + TxtREGION.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtORIGIN.Text) Then
            sQuery += "AND C.U_POL_COUNTRY like '%" + TxtORIGIN.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtDESTINATION.Text) Then
            sQuery += "AND C.U_POD_COUNTRY like '%" + TxtDESTINATION.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(TxtFechaDesde.Text) Then
            sQuery += "AND C.U_Validity_From >= '" + FechaDesde + "' "
        End If

        If Not String.IsNullOrEmpty(TxtFechaAl.Text) Then
            sQuery += "AND C.U_Validity_To <= '" + FechaHasta + "' "
        End If

        If Not String.IsNullOrEmpty(TxtFAKNAC.Text) Then
            sQuery += "AND C.U_NAC like '%" + TxtFAKNAC.Text.Trim + "%' "
        End If

        If Not String.IsNullOrEmpty(valorKind) Then
            sQuery += "AND A.U_SHOT_REPETITIVE like '%" + valorKind + "%' "
        End If

        If Not String.IsNullOrEmpty(valorIncoterm) Then
            sQuery += " And A.U_BXP_INCOTERM Like '%" + valorIncoterm + "%'  "
        End If

        If Not String.IsNullOrEmpty(Status) Then
            sQuery += "AND D.Estatus IN (" + Status + ") "
        End If

        sQuery += "ORDER BY A.DocNum DESC"

        Dim Log As New BXP_Log
        Log.EventLog("Query tabla Resumen - " + sQuery)


        Return sQuery

    End Function


    Protected Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        LlenarTabla()

    End Sub

    'Protected Sub BtnBuscar2_Click(sender As Object, e As EventArgs) Handles BtnBuscar2.Click

    '    LlenarTabla2()

    'End Sub

    Protected Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'If ChBAbiertos.Checked = True Then
        '    ChBCancelado.Checked = False
        '    'GVTabla.Columns(11).Visible = False
        '    'GVTabla.Columns(13).Visible = False
        '    'GVTabla.Columns(14).Visible = False
        '    'GVTabla.Columns(11).Visible = True
        '    'GVTabla.Columns(13).Visible = True
        '    'GVTabla.Columns(14).Visible = True
        'Else
        '    'GVTabla.Columns(11).Visible = False
        '    'GVTabla.Columns(13).Visible = False
        '    'GVTabla.Columns(14).Visible = False
        '    'GVTabla.Columns(11).Visible = False
        '    'GVTabla.Columns(13).Visible = False
        '    'GVTabla.Columns(14).Visible = False
        'End If
        LlenarTabla()
    End Sub

    Protected Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        'If ChBCancelado.Checked = True Then
        '    ChBAbiertos.Checked = False
        '    'GVTabla.Columns(11).Visible = False
        '    'GVTabla.Columns(13).Visible = False
        '    'GVTabla.Columns(14).Visible = False
        'Else
        '    If ChBAbiertos.Checked = True Then
        '        'GVTabla.Columns(11).Visible = False
        '        'GVTabla.Columns(13).Visible = False
        '        'GVTabla.Columns(14).Visible = False
        '        'GVTabla.Columns(11).Visible = True
        '        'GVTabla.Columns(13).Visible = True
        '        'GVTabla.Columns(14).Visible = True
        '    Else
        '        'GVTabla.Columns(11).Visible = False
        '        'GVTabla.Columns(13).Visible = False
        '        'GVTabla.Columns(14).Visible = False
        '    End If
        'End If
        LlenarTabla()
    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        LlenarTabla()
    End Sub

    Protected Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        LlenarTabla()
    End Sub

    Protected Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

        LlenarTabla()
    End Sub

    Protected Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

        LlenarTabla()
    End Sub

    Private Sub GVTabla_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GVTabla.PageIndexChanging
        Try
            LlenarTabla()
            GVTabla.PageIndex = e.NewPageIndex
            GVTabla.DataBind()
            Colorear()
            Colorear2()
        Catch ex As Exception
            'TxtRFC.Text = ex.Message
        End Try

    End Sub

    Private Sub GVTabla_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GVTabla.RowCommand
        Dim index As Integer
        index = Convert.ToInt32(e.CommandArgument)
        If e.CommandName = "FOLIO" Then

            WriteCookie("FOLIO", "FOLIO", DatosTabla(index, 2))

            Session("Folio") = DatosTabla(index, 2)

            'Dim LabelEstatus As Label = GVTabla.Rows(index).FindControl("LblEstatus")

            Session("TiCliente") = 2

            Response.Redirect("ResumenDetallesCotizacion.aspx")

            'If LabelEstatus.Text = "Pending" Then
            'Response.Redirect("BXP_AutoResumen.aspx")
            'Else

            'End If

        End If
    End Sub

    Private Function GetCorreo(ByVal DocNum As String) As String
        Dim WsSQL As New BXP_WebServiceSQL

        Dim Query As String = "Select Max(CardCode) from [Prototipo_Desarrollos].[dbo].OQUT Where DocNum = '" & DocNum & "'"

        Dim CardCode As String = WsSQL.Query2(Query)

        Query = "Select Max(E_Mail) from [Prototipo_Desarrollos].[dbo].OCRD Where CardCode = '" & CardCode & "'"

        Return WsSQL.Query2(Query)

    End Function

    Private Function DatosTabla(ByVal index As Integer, ByVal celda As Integer) As String
        Dim selectedRow As GridViewRow
        Dim contactCell As TableCell
        selectedRow = GVTabla.Rows(index)
        contactCell = selectedRow.Cells(celda)
        Return contactCell.Text
    End Function

    Protected Sub GVTabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GVTabla.SelectedIndexChanged

    End Sub

    Protected Sub BtnMostrarTodo_Click(sender As Object, e As EventArgs) Handles BtnMostrarTodo.Click
        'TxtBuscar.Text = ""
        CheckBox3.Checked = True
        CheckBox5.Checked = True
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox4.Checked = True
        CheckBox6.Checked = True
        TxtFechaAl.Text = ""
        TxtFechaDesde.Text = ""
        BtnMostrarTodo.Text = "MOSTRAR TODO"
        BtnBuscar.Text = "BUSCAR"

        LlenarTabla()
    End Sub


    Private Function GetCorreoVendedor(ByVal sVendedor As String) As String
        Dim WS As New BXP_WebServiceSQL
        Dim Query As String = "Select max(Correo) From BXP_SUser Where Nombre = '" + sVendedor + "'"
        Dim Correo As String = WS.Query2(Query)
        WS.Dispose()
        GC.Collect()
        Return Correo
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

        TxtFechaDesde.Text = CalendarDesde.SelectedDate.Date
        CalendarDesde.Visible = False

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
        If CalendarAl.SelectedDate.Date > CalendarDesde.SelectedDate.Date Then
            TxtFechaAl.Text = CalendarAl.SelectedDate.Date
            CalendarAl.Visible = False
        Else
            'MessageError("", "Ingrese una fecha valida")
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


    'Protected Sub TxtRFC_TextChanged(sender As Object, e As EventArgs) Handles TxtRFC.TextChanged
    'LlenarTabla()
    'End Sub

    'Protected Sub TxtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles TxtRazonSocial.TextChanged
    'LlenarTabla()
    'End Sub

    'Protected Sub TxtVendedor_TextChanged(sender As Object, e As EventArgs) Handles TxtVendedor.TextChanged
    'LlenarTabla()
    'End Sub

    Protected Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        Dim St As String()

        St = TxtName.Text.Split("/")
        TxtName.Text = St(0)

        LlenarTabla()

    End Sub

    Protected Sub TxtFILE_TextChanged(sender As Object, e As EventArgs) Handles TxtFILE.TextChanged

        LlenarTabla()

    End Sub

    Protected Sub TxtMODALITY_TextChanged(sender As Object, e As EventArgs) Handles TxtMODALITY.TextChanged

        LlenarTabla()

    End Sub

    Protected Sub TxtSELLER_TextChanged(sender As Object, e As EventArgs) Handles TxtSELLER.TextChanged

        LlenarTabla()

    End Sub

    Protected Sub TxtREGION_TextChanged(sender As Object, e As EventArgs) Handles TxtREGION.TextChanged

        LlenarTabla()

    End Sub

    Protected Sub TxtORIGIN_TextChanged(sender As Object, e As EventArgs) Handles TxtORIGIN.TextChanged

        sehizocambio1 = True

        LlenarTabla()

    End Sub


    Protected Sub TxtDESTINATION_TextChanged(sender As Object, e As EventArgs) Handles TxtDESTINATION.TextChanged

        sehizocambio2 = True
        LlenarTabla()

    End Sub

    Protected Sub TxtFAKNAC_TextChanged(sender As Object, e As EventArgs) Handles TxtFAKNAC.TextChanged

        LlenarTabla()

    End Sub

    Protected Sub DdlIncoterm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlIncoterm.SelectedIndexChanged

        LlenarTabla()

    End Sub

    Protected Sub DdlKind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlKind.SelectedIndexChanged

        LlenarTabla()

    End Sub

    Protected Sub TxtFechaDesde_TextChanged(sender As Object, e As EventArgs) Handles TxtFechaDesde.TextChanged

        LlenarTabla()

    End Sub

    Protected Sub TxtFechaAl_TextChanged(sender As Object, e As EventArgs) Handles TxtFechaAl.TextChanged

        LlenarTabla()

    End Sub

    Protected Sub GVTabla_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GVTabla.RowDataBound
        If e.Row.RowType = DataControlRowType.Footer Then
            e.Row.Cells(0).Text = "Página " & (GVTabla.PageIndex + 1) & " de " & GVTabla.PageCount
        End If
    End Sub

    'Private Sub TxtORIGIN_KeyPress(sender As System.Object, e As System.EventArgs) Handles TxtORIGIN.KeyPress
    '    Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
    '    If tmp.KeyChar = ChrW(Keys.Enter) Then
    '        BtnBuscar2_Click(Me, EventArgs.Empty)
    '    End If

    'End Sub

    'Private Sub TxtORIGIN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtORIGIN.KeyPress
    '    If Asc(e.KeyChar) = 13 Then
    '        BtnBuscar2_Click(Me, EventArgs.Empty)
    '    End If
    'End Sub


End Class