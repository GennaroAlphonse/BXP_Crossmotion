Public Class ResumenDetallesCotizacion
    Inherits System.Web.UI.Page

    'Public DocEntry As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            Autorizacion()
            LlenarDatos()

            Pnl_Background.Visible = False
            Pnl_Message.Visible = False

            'LblCorreoVendedor.Text = GetCorreo()
            'PnlBuscar.Visible = False
            'PnlTablaArticulos.Visible = False
            'PnlDescripcion.Visible = False

            DivInfo.Visible = False
            DivSuccess.Visible = False
            DivWarning.Visible = False

            DivDangerCorreo.Visible = False
            DivInfoCorreo.Visible = False
            DivSuccessCorreo.Visible = False


            If Session("TiCliente") = 1 Then
                TxtFecha.Enabled = True
                TxtComentarios.Enabled = True

                'TxtComPrecio.Enabled = True
                'TxtComTiempoEntrega.Enabled = True
                'TxtComCondicionesPAgo.Enabled = True
                'TxtComLab.Enabled = True

                BtnGuardar.Visible = True
                BtnCancelar.Visible = True
                'BtnReporte.Visible = False
                'BtnAgregarArticulo.Visible = True

                GridView2.Columns(0).Visible = True
                GridView2.Enabled = True

            ElseIf Session("TiCliente") = 2 Then
                TxtFecha.Enabled = False
                TxtComentarios.Enabled = False

                'TxtComPrecio.Enabled = False
                'TxtComTiempoEntrega.Enabled = False
                'TxtComCondicionesPAgo.Enabled = False
                'TxtComLab.Enabled = False

                BtnGuardar.Visible = False
                BtnCancelar.Visible = True
                'BtnReporte.Visible = True
                'BtnAgregarArticulo.Visible = False

                GridView2.Columns(0).Visible = False
                GridView2.Enabled = False
            End If

            Dim status As String = ""
            Try
                TxtFolio.Text = Session("Folio")

                TxtFolio.Text = ReadCookie("FOLIO", "FOLIO")

                Dim Query As String = "Select B.Estatus From [Prototipo_Desarrollos].[dbo].OQUT A, [BXP_Polimeros].dbo.BXP_Estatus B Where A.DocEntry ='" + CStr(TxtFolio.Text) + "' AND B.Id= A.DocNum COLLATE DATABASE_DEFAULT"

                Dim Ws As New BXP_WebServiceSQL
                Dim Ds As DataSet = Ws.Query1(Query)
                Dim foundRows() As Data.DataRow

                foundRows = Ds.Tables(0).Select("Id = '" + CStr(TxtFolio.Text) + "'")
                If Not IsDBNull(foundRows(0).Item("Estatus")) Then
                    status = foundRows(0).Item("Estatus")
                End If

                Ws.Dispose()
                Ds.Dispose()

            Catch ex As Exception
                'Dim Log As New BXP_Log
                'Log.ErrorLog("Error al cargar Grid " + ex.Message)
            End Try

            If status = "Cancelled" Then
                opcionbotones.Visible = False
            Else
                opcionbotones.Visible = True
            End If

        End If

    End Sub

    Private Sub Autorizacion()

    End Sub



    Protected Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Response.Redirect("BXP_Resumen.aspx")
    End Sub

    Private Sub LlenarDatos()

        Dim DocEntry As String = ""
        Dim IdWeb As String = ""
        Try

            'Dim Log As New BXP_Log
            'Log.EventLog("1")

            TxtFolio.Text = Session("Folio")

            TxtFolio.Text = ReadCookie("FOLIO", "FOLIO")

            'Log.EventLog("2")
            Dim Query As String = "Select * From [Prototipo_Desarrollos].[dbo].OQUT Where DocEntry = '" + CStr(TxtFolio.Text) + "'"
            Dim Ws As New BXP_WebServiceSQL
            Dim Ds As DataSet = Ws.Query1(Query)
            Dim foundRows() As Data.DataRow

            'Log.EventLog("3")

            'Log.EventLog("3")

            foundRows = Ds.Tables(0).Select("DocEntry = '" + CStr(TxtFolio.Text) + "'")

            'Log.EventLog("4")

            If Not IsDBNull(foundRows(0).Item("U_IdWeb")) Then
                IdWeb = foundRows(0).Item("U_IdWeb")
            End If

            If Not IsDBNull(foundRows(0).Item("DocEntry")) Then
                DocEntry = foundRows(0).Item("DocEntry")
            End If

            If Not IsDBNull(foundRows(0).Item("DocNum")) Then
                TxtFolio1.Text = foundRows(0).Item("DocNum")
            End If

            'Log.EventLog("5")

            If Not IsDBNull(foundRows(0).Item("U_FolioCrossmotion")) Then
                TxtFolio0.Text = foundRows(0).Item("U_FolioCrossmotion")
            End If

            'Log.EventLog("6")

            If Not IsDBNull(foundRows(0).Item("DocCur")) Then
                LblMoneda.Text = foundRows(0).Item("DocCur")
            End If

            'Log.EventLog("7")

            If Not IsDBNull(foundRows(0).Item("DocRate")) Then
                LblDolar.Text = FormatNumber(foundRows(0).Item("DocRate"), 2)
            End If

            'Log.EventLog("8")

            If Not IsDBNull(foundRows(0).Item("DocDate")) Then
                TxtFecha.Text = foundRows(0).Item("DocDate")
            Else
                TxtFecha.Text = ""
            End If

            'Log.EventLog("9")

            If Not IsDBNull(foundRows(0).Item("CardCode")) Then
                TxtCodigoCliente.Text = foundRows(0).Item("CardCode")
            Else
                TxtCodigoCliente.Text = ""
            End If

            'Log.EventLog("10")

            If Not IsDBNull(foundRows(0).Item("CardName")) Then
                TxtNombreCliente.Text = foundRows(0).Item("CardName")
            Else
                TxtNombreCliente.Text = ""
            End If

            'Log.EventLog("11")

            If Not IsDBNull(foundRows(0).Item("LicTradNum")) Then
                TxtRfc.Text = foundRows(0).Item("LicTradNum")
            Else
                TxtRfc.Text = ""
            End If

            'Log.EventLog("12")

            If Not IsDBNull(foundRows(0).Item("Comments")) Then
                TxtComentarios.Text = foundRows(0).Item("Comments")
            Else
                TxtComentarios.Text = ""
            End If

            'Log.EventLog("13")

            'If Not IsDBNull(foundRows(0).Item("U_BXP_MET_TRANSPORT")) Then
            '    TxtModality.Text = foundRows(0).Item("U_BXP_MET_TRANSPORT")
            'Else
            '    TxtModality.Text = ""
            'End If

            'Log.EventLog("13")


            If LblMoneda.Text = "$" Then

                'Log.EventLog("14")

                If Not IsDBNull(foundRows(0).Item("DocTotal")) Then
                    TxtTotal.Text = FormatCurrency(foundRows(0).Item("DocTotal"))
                Else
                    TxtTotal.Text = FormatCurrency("0")
                End If

                If Not IsDBNull(foundRows(0).Item("VatSum")) Then
                    TxtIva.Text = FormatCurrency(foundRows(0).Item("VatSum"))
                Else
                    TxtIva.Text = FormatCurrency("0")
                End If

                'Log.EventLog("15")

            Else

                'Log.EventLog("16")

                If Not IsDBNull(foundRows(0).Item("DocTotalFC")) Then
                    TxtTotal.Text = FormatCurrency(foundRows(0).Item("DocTotalFC"))
                Else
                    TxtTotal.Text = FormatCurrency("0")
                End If

                If Not IsDBNull(foundRows(0).Item("VatSumFC")) Then
                    TxtIva.Text = FormatCurrency(foundRows(0).Item("VatSumFC"))
                Else
                    TxtIva.Text = FormatCurrency("0")
                End If

                'Log.EventLog("17")

            End If
            'Log.EventLog("18")

            TxtSubTotal.Text = FormatCurrency(TxtTotal.Text - TxtIva.Text)

            'Log.EventLog("19")

            Dim SlpCode As String

            If Not IsDBNull(foundRows(0).Item("SlpCode")) Then
                SlpCode = foundRows(0).Item("SlpCode")
                SLP.Value = SlpCode
            Else
                SlpCode = ""
                SLP.Value = ""
            End If

            If Not IsDBNull(foundRows(0).Item("U_SHOT_REPETITIVE")) Then
                U_SHOT_REPETITIVE.Value = foundRows(0).Item("U_SHOT_REPETITIVE")
            Else
                U_SHOT_REPETITIVE.Value = ""
            End If

            If Not IsDBNull(foundRows(0).Item("U_BXP_INCOTERM")) Then
                U_BXP_INCOTERM.Value = foundRows(0).Item("U_BXP_INCOTERM")
            Else
                U_BXP_INCOTERM.Value = ""
            End If

            'Log.EventLog("20")

            Dim QueryCliente As String = "Select CardCode, Phone1, E_Mail From [Prototipo_Desarrollos].[dbo].OCRD where CardCode = '" + TxtCodigoCliente.Text + "'"
            Dim DsCliente As DataSet = Ws.Query1(QueryCliente)

            'Log.EventLog("21")

            Dim foundRowsCliente() As Data.DataRow

            foundRowsCliente = DsCliente.Tables(0).Select("CardCode = '" + TxtCodigoCliente.Text + "'")

            'Log.EventLog("22")

            Dim QueryDetalle As String = "Select * "



            QueryDetalle += "From [Prototipo_Desarrollos].[dbo].QUT1 "
            QueryDetalle += "where DocEntry = '" + DocEntry + "'"
            Dim DsDetalle As DataSet = Ws.Query1(QueryDetalle)

            'Log.EventLog("23")
            If Not IsPostBack Then
                GridView2.DataSource = DsDetalle
                GridView2.DataBind()
            End If
            'Log.EventLog("24")

            Ws.Dispose()
            Ds.Dispose()
            DsCliente.Dispose()
            DsDetalle.Dispose()

            'Log.EventLog("25")

            LblIdWeb.Text = IdWeb


            GC.Collect()
        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Error al cargar Grid " + ex.Message)
        End Try

    End Sub


    Protected Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Dim WSSap As New WSSap

        If GridView2.Rows.Count > 0 Then
            Dim Tabla As DataTable = CrearTabla()
            For contador As Integer = 0 To GridView2.Rows.Count - 1 Step contador + 1
                Dim CANT As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCant"), Label).Text
                Dim UM As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblUM"), Label).Text
                Dim CLAVE As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCLAVE"), Label).Text
                Dim CLAVESAP As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCLAVESAP"), Label).Text
                Dim DESCRIPCION As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblDESCRIPCION"), Label).Text
                Dim MEDIDA As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblMEDIDA"), Label).Text
                Dim CONSTRUCCION As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCONSTRUCCION"), Label).Text
                Dim CAPACIDAD As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCAPACIDAD"), Label).Text
                Dim PU As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPU"), Label).Text
                Dim IMPORTE As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblIMPORTE"), Label).Text
                Dim COMENTARIOS As String = CType(GridView2.Rows(contador).Cells(0).FindControl("TxtCOMENTARIOS"), TextBox).Text

                Dim DESCUENTO As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblDESCUENTO"), Label).Text
                Dim PUCAT As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPUCAT"), Label).Text
                Dim MONEDA As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblMONEDA"), Label).Text
                Dim MONEDACAT As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblMONEDACAT"), Label).Text

                Tabla.Rows.Add(FormatNumber(CANT, 4), UM, CLAVE, CLAVESAP, DESCRIPCION, MEDIDA, CONSTRUCCION, CAPACIDAD, PU, IMPORTE, COMENTARIOS, DESCUENTO, PUCAT, MONEDA, MONEDACAT)

            Next

            Dim Resultado As String = "1"
            'Resultado = WSSap.ActualizarCotizacionSap(TxtFolio.Text, TxtFecha.Text, TxtComentarios.Text, TxtComPrecio.Text, TxtComTiempoEntrega.Text, TxtComCondicionesPAgo.Text, TxtComLab.Text, Tabla)

            If Resultado = "1" Then
                'Resultado = WSSap.ActualizarCotizacionLineasSap(TxtFolio.Text, TxtFecha.Text, TxtComentarios.Text, TxtComPrecio.Text, TxtComTiempoEntrega.Text, TxtComCondicionesPAgo.Text, TxtComLab.Text, Tabla)
                If Resultado = "1" Then
                    BtnGuardar.Visible = False
                    'BtnReporte.Visible = True
                    'BtnCancelar.Text = "NUEVO"
                    'BtnAgregarArticulo.Visible = False
                    'PnlPie.Enabled = False
                    GridView2.Enabled = False

                    TxtFecha.Enabled = False
                    BtnGuardar.Enabled = False

                    Dim WebSer As New BXP_WebServiceSQL

                    Dim QueryPedido As String = "UPDATE BXP_Polimeros.dbo.Pedido SET CardCode = '" + TxtCodigoCliente.Text.ToString + "', Comments = '" + TxtComentarios.Text.ToString + "' WHERE Id = '" + CStr(TxtFolio.Text) + "' "
                    WebSer.Query3(QueryPedido)


                    'GridView2.Columns(0).Visible = True
                    'GridView2.Enabled = True
                    'Try


                    'If GridView2.EditIndex = -1 Then
                    '    ' Not in edit mode so look for label control defined in ItemTemplate of grid view
                    '    ' Put logic here for label control
                    'Else

                    '                For i = 0 To GridView2.Rows.Count

                    '                    TextBox TxtItemCode = (TextBox)GridView2.Rows[i].Cells[0].FindControl("TxtItemCode")
                    '                    Label lblname = (Label)GridView2.Rows[i].Cells[0].FindControl("lblname");
                    '  Label lblPickUpPoint = (Label)GridView2.Rows[i].Cells[0].FindControl("lblPickUpPoint");

                    'Next i

                    'For Each gvr As GridViewRow In (GridView2.Rows - 1)

                    '    Dim campoItem As String = CType(gvr.Cells(0).Controls(0), TextBox).Text
                    '    Dim campoPrecio As String = CType(gvr.Cells(2).Controls(0), TextBox).Text
                    '    Dim campoPrecio2 As String = CType(gvr.Cells(3).Controls(0), TextBox).Text
                    '    Dim campoPrecio3 As String = CType(gvr.Cells(4).Controls(0), TextBox).Text
                    '    Dim campoDD As String = CType(gvr.Cells(5).Controls(0), TextBox).Text
                    '    Dim campoAgente As String = CType(gvr.Cells(6).Controls(0), TextBox).Text
                    '    Dim campoCarrier As String = CType(gvr.Cells(7).Controls(0), TextBox).Text
                    '    Dim campoPolCode As String = CType(gvr.Cells(8).Controls(0), TextBox).Text
                    '    Dim campoPol As String = CType(gvr.Cells(9).Controls(0), TextBox).Text
                    '    Dim campoPolCodeCountry As String = CType(gvr.Cells(10).Controls(0), TextBox).Text
                    '    Dim campoPolCountry As String = CType(gvr.Cells(11).Controls(0), TextBox).Text
                    '    Dim campoPodCode As String = CType(gvr.Cells(12).Controls(0), TextBox).Text
                    '    Dim campoPod As String = CType(gvr.Cells(13).Controls(0), TextBox).Text
                    '    Dim campoPodCodeCountry As String = CType(gvr.Cells(14).Controls(0), TextBox).Text
                    '    Dim campoPodCountry As String = CType(gvr.Cells(15).Controls(0), TextBox).Text
                    '    Dim campoCurrency As String = CType(gvr.Cells(16).Controls(0), TextBox).Text
                    '    Dim campoEquipment As String = CType(gvr.Cells(20).Controls(0), TextBox).Text
                    '    Dim campoValidityFrom As String = CType(gvr.Cells(21).Controls(0), TextBox).Text
                    '    Dim campoValidityTo As String = CType(gvr.Cells(22).Controls(0), TextBox).Text
                    '    Dim campoTT As String = CType(gvr.Cells(23).Controls(0), TextBox).Text
                    '    Dim campoFreeDays As String = CType(gvr.Cells(24).Controls(0), TextBox).Text
                    '    Dim campoNAC As String = CType(gvr.Cells(25).Controls(0), TextBox).Text
                    '    Dim campoCommodity As String = CType(gvr.Cells(26).Controls(0), TextBox).Text
                    '    Dim campoUN As String = CType(gvr.Cells(27).Controls(0), TextBox).Text
                    '    Dim campoRA As String = CType(gvr.Cells(28).Controls(0), TextBox).Text
                    '    Dim campoSUBJECT As String = CType(gvr.Cells(29).Controls(0), TextBox).Text
                    '    Dim campoNOTSUBJECT As String = CType(gvr.Cells(30).Controls(0), TextBox).Text
                    '    Dim campoREMARKS As String = CType(gvr.Cells(31).Controls(0), TextBox).Text
                    'Next

                    'For Each row As GridViewRow In Me.GridView2.Rows
                    '    Dim ItemCode = DirectCast(row.FindControl("TxtItemCode"), TextBox)
                    '    Dim campoItem As String = ItemCode.Text
                    '    'Dim campoItem As String = TryCast(row.FindControl("TxtItemCode"), TextBox).Text
                    '    Dim Precio = DirectCast(row.FindControl("TxtPrecio"), TextBox)
                    '    Dim campoPrecio As String = String.Format("{0:C2}", Precio.Text)
                    '    'Dim campoPrecio As String = String.Format("{0:C2}", TryCast(row.FindControl("TxtPrecio"), TextBox).Text)
                    '    Dim Precio2 = DirectCast(row.FindControl("TxtPrecio2"), TextBox)
                    '    Dim campoPrecio2 As String = String.Format("{0:C2}", Precio2.Text)
                    '    'Dim campoPrecio2 As String = String.Format("{0:C2}", TryCast(row.FindControl("TxtPrecio2"), TextBox).Text)
                    '    Dim Precio3 = DirectCast(row.FindControl("TxtPrecio3"), TextBox)
                    '    Dim campoPrecio3 As String = String.Format("{0:C2}", Precio3.Text)
                    '    'Dim campoPrecio3 As String = String.Format("{0:C2}", TryCast(row.FindControl("TxtPrecio3"), TextBox).Text)
                    '    Dim DD = DirectCast(row.FindControl("TxtDD"), TextBox)
                    '    Dim campoDD As String = DD.Text
                    '    'Dim campoDD As String = TryCast(row.FindControl("TxtDD"), TextBox).Text
                    '    Dim Agente = DirectCast(row.FindControl("LblAGENT0"), Label)
                    '    Dim campoAgente As String = Agente.Text
                    '    'Dim campoAgente As String = TryCast(row.FindControl("LblAGENT0"), Label).Text
                    '    Dim Carrier = DirectCast(row.FindControl("LblCARRIER0"), Label)
                    '    Dim campoCarrier As String = Carrier.Text
                    '    'Dim campoCarrier As String = TryCast(row.FindControl("LblCARRIER0"), Label).Text
                    '    Dim PolCode = DirectCast(row.FindControl("LblPOL_CODE0"), Label)
                    '    Dim campoPolCode As String = PolCode.Text
                    '    'Dim campoPolCode As String = TryCast(row.FindControl("LblPOL_CODE0"), Label).Text
                    '    Dim Pol = DirectCast(row.FindControl("LblPOL0"), Label)
                    '    Dim campoPol As String = Pol.Text
                    '    'Dim campoPol As String = TryCast(row.FindControl("LblPOL0"), Label).Text
                    '    Dim PolCodeCountry = DirectCast(row.FindControl("LblPOL_CODE_COUNTRY0"), Label)
                    '    Dim campoPolCodeCountry As String = PolCodeCountry.Text
                    '    'Dim campoPolCodeCountry As String = TryCast(row.FindControl("LblPOL_CODE_COUNTRY0"), Label).Text
                    '    Dim PodCode = DirectCast(row.FindControl("LblPOD_CODE0"), Label)
                    '    Dim campoPodCode As String = PodCode.Text
                    '    'Dim campoPodCode As String = TryCast(row.FindControl("LblPOD_CODE0"), Label).Text
                    '    Dim PolCountry = DirectCast(row.FindControl("LblPOL_COUNTRY0"), Label)
                    '    Dim campoPolCountry As String = PolCountry.Text
                    '    'Dim campoPolCountry As String = TryCast(row.FindControl("LblPOL_COUNTRY0"), Label).Text
                    '    Dim Pod = DirectCast(row.FindControl("LblPOD"), Label)
                    '    Dim campoPod As String = Pod.Text
                    '    'Dim campoPod As String = TryCast(row.FindControl("LblPOD"), Label).Text
                    '    Dim PodCodeCountry = DirectCast(row.FindControl("LblPOD_CODE_COUNTRY0"), Label)
                    '    Dim campoPodCodeCountry As String = PodCodeCountry.Text
                    '    'Dim campoPodCodeCountry As String = TryCast(row.FindControl("LblPOD_CODE_COUNTRY0"), Label).Text
                    '    Dim PodCountry = DirectCast(row.FindControl("LblPOD_COUNTRY0"), Label)
                    '    Dim campoPodCountry As String = PodCountry.Text
                    '    'Dim campoPodCountry As String = TryCast(row.FindControl("LblPOD_COUNTRY0"), Label).Text
                    '    Dim Currency = DirectCast(row.FindControl("LblCURRENCY0"), Label)
                    '    Dim campoCurrency As String = Currency.Text
                    '    'Dim campoCurrency As String = TryCast(row.FindControl("LblCURRENCY0"), Label).Text
                    '    Dim Equipment = DirectCast(row.FindControl("LblEQUIPMENT"), Label)
                    '    Dim campoEquipment As String = Equipment.Text
                    '    'Dim campoEquipment As String = TryCast(row.FindControl("LblEQUIPMENT"), Label).Text
                    '    Dim ValidityFrom = DirectCast(row.FindControl("LblVALIDITY_FROM"), Label)
                    '    Dim campoValidityFrom As String = ValidityFrom.Text
                    '    'Dim campoValidityFrom As String = TryCast(row.FindControl("LblVALIDITY_FROM"), Label).Text
                    '    Dim ValidityTo = DirectCast(row.FindControl("LblVALIDITY_TO"), Label)
                    '    Dim campoValidityTo As String = ValidityTo.Text
                    '    'Dim campoValidityTo As String = TryCast(row.FindControl("LblVALIDITY_TO"), Label).Text
                    '    Dim TT = DirectCast(row.FindControl("LblTT"), Label)
                    '    Dim campoTT As String = TT.Text
                    '    'Dim campoTT As String = TryCast(row.FindControl("LblTT"), Label).Text
                    '    Dim FreeDays = DirectCast(row.FindControl("LblFREE_DAYS"), Label)
                    '    Dim campoFreeDays As String = FreeDays.Text
                    '    'Dim campoFreeDays As String = TryCast(row.FindControl("LblFREE_DAYS"), Label).Text
                    '    Dim NAC = DirectCast(row.FindControl("LblNAC"), Label)
                    '    Dim campoNAC As String = NAC.Text
                    '    'Dim campoNAC As String = TryCast(row.FindControl("LblNAC"), Label).Text
                    '    Dim Commodity = DirectCast(row.FindControl("LblCOMMODITY"), Label)
                    '    Dim campoCommodity As String = Commodity.Text
                    '    'Dim campoCommodity As String = TryCast(row.FindControl("LblCOMMODITY"), Label).Text
                    '    Dim UN = DirectCast(row.FindControl("LblUN"), Label)
                    '    Dim campoUN As String = UN.Text
                    '    'Dim campoUN As String = TryCast(row.FindControl("LblUN"), Label).Text
                    '    Dim RA = DirectCast(row.FindControl("LblRA"), Label)
                    '    Dim campoRA As String = RA.Text
                    '    'Dim campoRA As String = TryCast(row.FindControl("LblRA"), Label).Text
                    '    Dim SUBJECT = DirectCast(row.FindControl("LblSUBJECT"), Label)
                    '    Dim campoSUBJECT As String = SUBJECT.Text
                    '    'Dim campoSUBJECT As String = TryCast(row.FindControl("LblSUBJECT"), Label).Text
                    '    Dim NOTSUBJECT = DirectCast(row.FindControl("LblNOT_SUBJECT"), Label)
                    '    Dim campoNOTSUBJECT As String = NOTSUBJECT.Text
                    '    'Dim campoNOTSUBJECT As String = TryCast(row.FindControl("LblNOT_SUBJECT"), Label).Text
                    '    Dim REMARKS = DirectCast(row.FindControl("LblREMARKS"), Label)
                    '    Dim campoREMARKS As String = REMARKS.Text
                    '    'Dim campoREMARKS As String = TryCast(row.FindControl("LblREMARKS"), Label).Text
                    '    Dim Query3 As String = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, [20GP], [40GP], [40HQ], DD, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, CURRENCY, EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, RA, SUBJECT, NOT_SUBJECT, REMARKS) VALUES ('" + FolioPedido.Trim + "' ,'" + campoItem + "', '" + campoPrecio + "', '" + campoPrecio2 + "','" + campoPrecio3 + "','" + campoDD + "','" + campoAgente + "','" + campoCarrier + "','" + campoPolCode + "','" + campoPol + "','" + campoPolCodeCountry + "','" + campoPolCountry + "','" + campoPodCode + "', '" + campoPod + "', '" + campoPodCodeCountry + "','" + campoPodCountry + "', '" + campoCurrency + "', '" + campoEquipment + "', '" + campoValidityFrom + "', '" + campoValidityTo + "', '" + campoTT + "', '" + campoFreeDays + "', '" + campoNAC + "', '" + campoCommodity + "', '" + campoUN + "', '" + campoRA + "', '" + campoSUBJECT + "', '" + campoNOTSUBJECT + "', '" + campoREMARKS + "') "
                    '    WebSer.Query3(Query3)
                    'Next


                    'End If

                    'Catch ex As Exception
                    '    Dim scriptaviso As String = "alert('Error:" + ex.Message + "');"
                    '    ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", scriptaviso, True)
                    'End Try

                    'WebSer.Dispose()
                    'Ds.Dispose()

                    Dim script As String = "alert('Se guardaron las modificaciones de la cotización con éxito'); window.location.href='ResumenDetallesCotizacion.aspx';"

                    ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

                    'LblError.Text = "SE GUARDO CON EXITO LA COTIZACION"
                Else
                    'LblError.Text = Resultado
                End If
            Else
                'LblError.Text = Resultado
            End If

        Else
            'LblError.Text = "AGREGUE UN ARTÍCULO POR LO MENOS"
        End If

    End Sub

    Private Function CrearTabla() As DataTable
        Dim Tabla As DataTable = New DataTable("Productos")

        Tabla.Columns.Add("CANT")
        Tabla.Columns.Add("UM")
        Tabla.Columns.Add("CLAVE")
        Tabla.Columns.Add("CLAVESAP")
        Tabla.Columns.Add("DESCRIPCION")
        Tabla.Columns.Add("MEDIDA")
        Tabla.Columns.Add("CONSTRUCCION")
        Tabla.Columns.Add("CAPACIDAD")
        Tabla.Columns.Add("PU")
        Tabla.Columns.Add("IMPORTE")

        Tabla.Columns.Add("COMENTARIOS")
        Tabla.Columns.Add("DESCUENTO")
        Tabla.Columns.Add("PUCAT")
        Tabla.Columns.Add("MONEDA")
        Tabla.Columns.Add("MONEDACAT")

        'Tabla.Columns.Add("Quantity")
        'Tabla.Columns.Add("unitMsr")
        'Tabla.Columns.Add("ItemCode")
        'Tabla.Columns.Add("U_DCLAVE_ALT")
        'Tabla.Columns.Add("Dscription")
        'Tabla.Columns.Add("U_DMEDIDA")
        'Tabla.Columns.Add("U_DCONSTRUCCION")
        'Tabla.Columns.Add("U_DCAPACIDAD")
        'Tabla.Columns.Add("Precio")
        'Tabla.Columns.Add("Total")

        'Tabla.Columns.Add("FreeTxt")
        'Tabla.Columns.Add("DiscPrcnt")
        'Tabla.Columns.Add("PUCAT")
        'Tabla.Columns.Add("Currency")
        'Tabla.Columns.Add("MONEDACAT")
        Return Tabla
    End Function

    Private Sub GVTabla_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView2.RowCommand

        If e.CommandName = "EDITAR" Then
            Dim index As Integer
            index = Convert.ToInt32(e.CommandArgument)

            'TxtIndex.Text = index

            'TxtArtCantidad.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblCANT"), Label).Text
            'TxtArtCapacidad.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblCAPACIDAD"), Label).Text
            'TxtArtClave.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblCLAVESAP"), Label).Text
            'TxtArtClaveAlt.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblCLAVE"), Label).Text
            'TxtArtConstruccion.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblCONSTRUCCION"), Label).Text
            'TxtArtDescripcion.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblDESCRIPCION"), Label).Text

            'TxtArtMedida.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblMEDIDA"), Label).Text
            'TxtArtPU.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblPU"), Label).Text
            'TxtArtUm.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblUM"), Label).Text

            'TxtArtMoneda.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblMONEDA"), Label).Text
            'TxtArtMonedaCat.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblMONEDACAT"), Label).Text
            'TxtArtPUCat.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblPUCAT"), Label).Text
            'TxtArtDescuento.Text = CType(GridView2.Rows(index).Cells(0).FindControl("LblDESCUENTO"), Label).Text
            'TxtArtComentario.Text = CType(GridView2.Rows(index).Cells(0).FindControl("TxtCOMENTARIOS"), TextBox).Text

            'PnlBuscar.Visible = False
            'PnlTablaArticulos.Visible = False
            'PnlDescripcion.Visible = True

            'PnlEncabezado.Visible = False
            'PnlTabla.Visible = False
            'PnlPie.Visible = False

            'BtnArtAgregar.Visible = False
            'BtnArtEditar.Visible = True
        ElseIf e.CommandName = "ELIMINAR" Then
            Dim index As Integer
            index = Convert.ToInt32(e.CommandArgument)

            'Dim WsSap As New WSSap
            Dim Resultados As String = "1"

            'Resultados = WsSap.EliminarPartida(TxtFolio.Text, index)
            If Resultados = "1" Then
                LlenarDatos()

                'PnlBuscar.Visible = False
                'PnlTablaArticulos.Visible = False
                'PnlDescripcion.Visible = False

                'PnlEncabezado.Visible = True
                'PnlTabla.Visible = True
                'PnlPie.Visible = True
            Else
                'LblArtError.Text = "ERROR AL INGRESAR UNA PARTIDA"
            End If

        End If

    End Sub

    Private Sub GVTabla_RowDeleted(sender As Object, e As GridViewDeletedEventArgs) Handles GridView2.RowDeleted

    End Sub

    Protected Sub GVTabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged

    End Sub

    'Protected Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click

    '    WriteCookie("FoloCR", "FoloCR", TxtFolio.Text)

    '    Response.Redirect("VisorInforme2.aspx")
    'End Sub

    Private Function GetCorreo() As String
        Dim WS As New BXP_WebServiceSQL
        Dim Query As String = "Select max(Correo) From BXP_SUser Where Nombre = '" + LblRealizo.Text + "'"
        Dim Correo As String = WS.Query2(Query)
        WS.Dispose()
        GC.Collect()
        Return Correo
    End Function


    'Protected Sub BtnReporte0_Click(sender As Object, e As EventArgs) Handles BtnReporte0.Click
    '    'Editar

    '    'TxtCodigoCliente.Enabled = True
    '    'TxtNombreCliente.ReadOnly = False
    '    'TxtComentarios.ReadOnly = False


    'End Sub

    Protected Sub BtnReporte1_Click(sender As Object, e As EventArgs) Handles BtnReporte1.Click
        'Duplicar
        Try

            Dim WebSer As New BXP_WebServiceSQL

            Dim nuevoFolio As String

            Dim TextoFolio As String = TxtFolio0.Text.Substring(0, 9).Trim
            Dim resto As String = TxtFolio0.Text.Substring(17).Trim

            nuevoFolio = TextoFolio + DateTime.Now.ToString("ddMMyyyy") + resto

            Dim Query As String = "Insert into BXP_Polimeros.dbo.BXP_Duplicar (Id, Folio, Comentarios, Ban, FolioCrossmotion) VALUES ('0','" + CStr(TxtFolio1.Text) + "','', 'False', '" + nuevoFolio + "')"
            Dim Query2 As String = "Insert into BXP_Polimeros.dbo.Pedido (Id, CardCode, Fecha, Comments, FolioWeb, Empresa, CodeI, Type, Kind, Ban, TypeService) SELECT MAX(Id) + 1 ,'" + CStr(TxtCodigoCliente.Text) + "', '" + DateTime.Now.ToString("MM-dd-yyyy") + "', '" + CStr(TxtComentarios.Text) + "','" + nuevoFolio + "','Prototipo_Desarrollos','" + CStr(U_BXP_INCOTERM.Value) + "','" + CStr(TxtFolio0.Text.Substring(0, 3).Trim) + "','" + CStr(U_SHOT_REPETITIVE.Value) + "', 'True', '" + CStr(TxtFolio0.Text.Substring(0, 3).Trim) + "' FROM BXP_Polimeros.dbo.Pedido"

            WebSer.Query3(Query)
            WebSer.Query3(Query2)

            Dim QueryMAX As String = "Select Id FROM BXP_Polimeros.dbo.Pedido WHERE Id = (SELECT (MAX(Id)) FROM BXP_Polimeros.dbo.Pedido)"

            Dim FolioPedido As String = ""
            Dim Ds As DataSet = WebSer.Query1(QueryMAX)

            Using sdr As DataSet = WebSer.Query1(QueryMAX)
                For Each row As DataRow In sdr.Tables(0).Rows
                    If Not IsDBNull(row("Id")) Then
                        FolioPedido = row("Id")
                    End If
                Next
            End Using

            'Dim campoItem As String = ""
            'Dim campoPrecio As String = ""
            'Dim campoPrecio2 As String = ""
            'Dim campoPrecio3 As String = ""
            'Dim campoAgente As String = ""
            'Dim campoCarrier As String = ""
            'Dim campoPolCode As String = ""
            'Dim campoPol As String = ""
            'Dim campoPolCodeCountry As String = ""
            'Dim campoPolCountry As String = ""
            'Dim campoCurrency As String = ""
            'Dim campoDD As String = ""
            'Dim campoPod As String = ""
            'Dim campoPodCode As String = ""
            'Dim campoPodCodeCountry As String = ""
            'Dim campoPodCountry As String = ""
            'Dim campoValidityFrom As String = ""
            'Dim campoValidityTo As String = ""
            'Dim campoTT As String = ""
            'Dim campoFreeDays As String = ""
            'Dim campoCommodity As String = ""
            'Dim campoUN As String = ""
            'Dim campoRA As String = ""
            'Dim campoSUBJECT As String = ""
            'Dim campoNOTSUBJECT As String = ""
            'Dim campoREMARKS As String = ""
            'Dim campoEquipment As String = ""
            'Dim campoNAC As String = ""

            'Dim QueryDetalle As String = "Select * From [Prototipo_Desarrollos].[dbo].QUT1 where DocEntry = '" + CStr(TxtFolio.Text) + "'"
            ''Dim DsDetalle As DataSet = Ws.Query1(QueryDetalle)

            'Dim QueryDocentry As String = "Select * From [Prototipo_Desarrollos].[dbo].OQUT Where DocEntry = '" + CStr(TxtFolio.Text) + "'"

            'Dim DocEntry As String = ""

            'Using sdr As DataSet = WebSer.Query1(QueryDocentry)
            '    For Each row As DataRow In sdr.Tables(0).Rows
            '        If Not IsDBNull(row("DocEntry")) Then
            '            DocEntry = row("DocEntry")
            '        End If
            '    Next
            'End Using

            'Dim QueryDetalle As String = "Select * "
            'QueryDetalle += "From [Prototipo_Desarrollos].[dbo].QUT1 "
            'QueryDetalle += "where DocEntry = '" + DocEntry + "'"

            'Using sdr As DataSet = WebSer.Query1(QueryDetalle)
            '    For Each row As DataRow In sdr.Tables(0).Rows
            '        'If Not IsDBNull(row("ItemCode")) Then
            '        campoItem = row("ItemCode").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("[20GP]")) Then
            '        campoPrecio = String.Format("{0:C2}", row("[20GP]").ToString.Trim)
            '        'End If

            '        'If Not IsDBNull(row("[40GP]")) Then
            '        campoPrecio2 = String.Format("{0:C2}", row("[40GP]").ToString.Trim)
            '        'End If

            '        'If Not IsDBNull(row("[40HQ]")) Then
            '        campoPrecio3 = String.Format("{0:C2}", row("[40HQ]").ToString.Trim)
            '        'End If

            '        'If Not IsDBNull(row("AGENT")) Then
            '        campoAgente = row("AGENT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("CARRIER")) Then
            '        campoCarrier = row("CARRIER").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL_CODE")) Then
            '        campoPolCode = row("POL_CODE").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL")) Then
            '        campoPol = row("POL").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL_CODE_COUNTRY")) Then
            '        campoPolCodeCountry = row("POL_CODE_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL_COUNTRY")) Then
            '        campoPolCountry = row("POL_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD_CODE")) Then
            '        campoPodCode = row("POD_CODE").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD")) Then
            '        campoPod = row("POD").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD_COUNTRY")) Then
            '        campoPodCountry = row("POD_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD_CODE_COUNTRY")) Then
            '        campoPodCodeCountry = row("POD_CODE_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("CURRENCY")) Then
            '        campoCurrency = row("CURRENCY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("DD")) Then
            '        campoDD = row("DD").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("VALIDITY_FROM")) Then
            '        campoValidityFrom = row("VALIDITY_FROM").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("VALIDITY_TO")) Then
            '        campoValidityTo = row("VALIDITY_TO").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("VALIDITY_TO")) Then
            '        campoValidityTo = row("VALIDITY_TO").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("TT")) Then
            '        campoTT = row("TT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("FREE_DAYS")) Then
            '        campoFreeDays = row("FREE_DAYS").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("NAC")) Then
            '        campoNAC = row("NAC").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("EQUIPMENT")) Then
            '        campoEquipment = row("EQUIPMENT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("COMMODITY")) Then
            '        campoCommodity = row("COMMODITY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("UN")) Then
            '        campoUN = row("UN").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("RA")) Then
            '        campoRA = row("RA").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("SUBJECT")) Then
            '        campoSUBJECT = row("SUBJECT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("NOT_SUBJECT")) Then
            '        campoNOTSUBJECT = row("NOT_SUBJECT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("REMARKS")) Then
            '        campoREMARKS = row("REMARKS").ToString.Trim
            '        'End If

            '        Dim Query3 As String = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, [20GP], [40GP], [40HQ], DD, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, CURRENCY, EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, RA, SUBJECT, NOT_SUBJECT, REMARKS) VALUES ('" + FolioPedido.Trim + "' ,'" + campoItem + "', '" + campoPrecio + "', '" + campoPrecio2 + "','" + campoPrecio3 + "','" + campoDD + "','" + campoAgente + "','" + campoCarrier + "','" + campoPolCode + "','" + campoPol + "','" + campoPolCodeCountry + "','" + campoPolCountry + "','" + campoPodCode + "', '" + campoPod + "', '" + campoPodCodeCountry + "','" + campoPodCountry + "', '" + campoCurrency + "', '" + campoEquipment + "', '" + campoValidityFrom + "', '" + campoValidityTo + "', '" + campoTT + "', '" + campoFreeDays + "', '" + campoNAC + "', '" + campoCommodity + "', '" + campoUN + "', '" + campoRA + "', '" + campoSUBJECT + "', '" + campoNOTSUBJECT + "', '" + campoREMARKS + "') "
            '        WebSer.Query3(Query3)
            '    Next
            'End Using
            Try
                For contador As Integer = 0 To GridView2.Rows.Count - 1 Step contador + 1
                    Dim campoItem As String = CType(GridView2.Rows(contador).Cells(0).FindControl("TxtItemCode"), TextBox).Text
                    Dim campoPrecio As String = CType(GridView2.Rows(contador).Cells(0).FindControl("TxtPrecio"), TextBox).Text
                    Dim campoPrecio2 As String = CType(GridView2.Rows(contador).Cells(0).FindControl("TxtPrecio2"), TextBox).Text
                    Dim campoPrecio3 As String = CType(GridView2.Rows(contador).Cells(0).FindControl("TxtPrecio3"), TextBox).Text
                    Dim campoDD As String = CType(GridView2.Rows(contador).Cells(0).FindControl("TxtDD"), TextBox).Text
                    Dim campoAgente As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblAGENT0"), Label).Text
                    Dim campoCarrier As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCARRIER0"), Label).Text
                    Dim campoPolCode As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOL_CODE0"), Label).Text
                    Dim campoPol As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOL0"), Label).Text
                    Dim campoPolCodeCountry As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOL_CODE_COUNTRY0"), Label).Text
                    Dim campoPolCountry As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOL_COUNTRY0"), TextBox).Text
                    Dim campoPodCode As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOD_CODE0"), Label).Text
                    Dim campoPod As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOD0"), Label).Text
                    Dim campoPodCodeCountry As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOD_CODE_COUNTRY0"), Label).Text
                    Dim campoPodCountry As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblPOD_COUNTRY0"), TextBox).Text

                    Dim campoCurrency As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCURRENCY0"), Label).Text
                    Dim campoEquipment As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblEQUIPMENT"), Label).Text
                    Dim campoValidityFrom As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblVALIDITY_FROM"), Label).Text
                    Dim campoValidityTo As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblVALIDITY_TO"), Label).Text

                    Dim campoTT As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblTT"), Label).Text
                    Dim campoFreeDays As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblFREEDAYS"), Label).Text
                    Dim campoNAC As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblNAC"), Label).Text
                    Dim campoCommodity As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblCOMMODITY"), Label).Text

                    Dim campoUN As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblUN"), Label).Text
                    Dim campoRA As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblRA"), Label).Text
                    Dim campoSUBJECT As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblSUBJECT"), Label).Text
                    Dim campoNOTSUBJECT As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblNOT_SUBJECT"), Label).Text
                    Dim campoREMARKS As String = CType(GridView2.Rows(contador).Cells(0).FindControl("LblREMARKS"), Label).Text

                    Dim Query3 As String = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, [20GP], [40GP], [40HQ], DD, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, CURRENCY, EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, RA, SUBJECT, NOT_SUBJECT, REMARKS) VALUES ('" + FolioPedido.Trim + "' ,'" + campoItem + "', '" + campoPrecio + "', '" + campoPrecio2 + "','" + campoPrecio3 + "','" + campoDD + "','" + campoAgente + "','" + campoCarrier + "','" + campoPolCode + "','" + campoPol + "','" + campoPolCodeCountry + "','" + campoPolCountry + "','" + campoPodCode + "', '" + campoPod + "', '" + campoPodCodeCountry + "','" + campoPodCountry + "', '" + campoCurrency + "', '" + campoEquipment + "', '" + campoValidityFrom + "', '" + campoValidityTo + "', '" + campoTT + "', '" + campoFreeDays + "', '" + campoNAC + "', '" + campoCommodity + "', '" + campoUN + "', '" + campoRA + "', '" + campoSUBJECT + "', '" + campoNOTSUBJECT + "', '" + campoREMARKS + "') "
                    WebSer.Query3(Query3)
                Next
            Catch ex As Exception
                Dim scriptaviso As String = "alert('Error:" + ex.Message + "');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", scriptaviso, True)
            End Try


            'GridView2.Columns(0).Visible = True
            'GridView2.Enabled = True
            'Try


            'If GridView2.EditIndex = -1 Then
            '    ' Not in edit mode so look for label control defined in ItemTemplate of grid view
            '    ' Put logic here for label control
            'Else

            '                For i = 0 To GridView2.Rows.Count-1

            '                    TextBox TxtItemCode = (TextBox)GridView2.Rows[i].Cells[0].FindControl("TxtItemCode")
            '                    Label lblname = (Label)GridView2.Rows[i].Cells[0].FindControl("lblname");
            '  Label lblPickUpPoint = (Label)GridView2.Rows[i].Cells[0].FindControl("lblPickUpPoint");

            'Next i

            'For Each gvr As GridViewRow In GridView2.Rows-1

            '    Dim campoItem As String = CType(gvr.Cells(0).Controls(0), TextBox).Text
            '    Dim campoPrecio As String = CType(gvr.Cells(2).Controls(0), TextBox).Text
            '    Dim campoPrecio2 As String = CType(gvr.Cells(3).Controls(0), TextBox).Text
            '    Dim campoPrecio3 As String = CType(gvr.Cells(4).Controls(0), TextBox).Text
            '    Dim campoDD As String = CType(gvr.Cells(5).Controls(0), TextBox).Text
            '    Dim campoAgente As String = CType(gvr.Cells(6).Controls(0), TextBox).Text
            '    Dim campoCarrier As String = CType(gvr.Cells(7).Controls(0), TextBox).Text
            '    Dim campoPolCode As String = CType(gvr.Cells(8).Controls(0), TextBox).Text
            '    Dim campoPol As String = CType(gvr.Cells(9).Controls(0), TextBox).Text
            '    Dim campoPolCodeCountry As String = CType(gvr.Cells(10).Controls(0), TextBox).Text
            '    Dim campoPolCountry As String = CType(gvr.Cells(11).Controls(0), TextBox).Text
            '    Dim campoPodCode As String = CType(gvr.Cells(12).Controls(0), TextBox).Text
            '    Dim campoPod As String = CType(gvr.Cells(13).Controls(0), TextBox).Text
            '    Dim campoPodCodeCountry As String = CType(gvr.Cells(14).Controls(0), TextBox).Text
            '    Dim campoPodCountry As String = CType(gvr.Cells(15).Controls(0), TextBox).Text
            '    Dim campoCurrency As String = CType(gvr.Cells(16).Controls(0), TextBox).Text
            '    Dim campoEquipment As String = CType(gvr.Cells(20).Controls(0), TextBox).Text
            '    Dim campoValidityFrom As String = CType(gvr.Cells(21).Controls(0), TextBox).Text
            '    Dim campoValidityTo As String = CType(gvr.Cells(22).Controls(0), TextBox).Text
            '    Dim campoTT As String = CType(gvr.Cells(23).Controls(0), TextBox).Text
            '    Dim campoFreeDays As String = CType(gvr.Cells(24).Controls(0), TextBox).Text
            '    Dim campoNAC As String = CType(gvr.Cells(25).Controls(0), TextBox).Text
            '    Dim campoCommodity As String = CType(gvr.Cells(26).Controls(0), TextBox).Text
            '    Dim campoUN As String = CType(gvr.Cells(27).Controls(0), TextBox).Text
            '    Dim campoRA As String = CType(gvr.Cells(28).Controls(0), TextBox).Text
            '    Dim campoSUBJECT As String = CType(gvr.Cells(29).Controls(0), TextBox).Text
            '    Dim campoNOTSUBJECT As String = CType(gvr.Cells(30).Controls(0), TextBox).Text
            '    Dim campoREMARKS As String = CType(gvr.Cells(31).Controls(0), TextBox).Text
            '    Dim Query3 As String = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, [20GP], [40GP], [40HQ], DD, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, CURRENCY, EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, RA, SUBJECT, NOT_SUBJECT, REMARKS) VALUES ('" + FolioPedido.Trim + "' ,'" + campoItem + "', '" + campoPrecio + "', '" + campoPrecio2 + "','" + campoPrecio3 + "','" + campoDD + "','" + campoAgente + "','" + campoCarrier + "','" + campoPolCode + "','" + campoPol + "','" + campoPolCodeCountry + "','" + campoPolCountry + "','" + campoPodCode + "', '" + campoPod + "', '" + campoPodCodeCountry + "','" + campoPodCountry + "', '" + campoCurrency + "', '" + campoEquipment + "', '" + campoValidityFrom + "', '" + campoValidityTo + "', '" + campoTT + "', '" + campoFreeDays + "', '" + campoNAC + "', '" + campoCommodity + "', '" + campoUN + "', '" + campoRA + "', '" + campoSUBJECT + "', '" + campoNOTSUBJECT + "', '" + campoREMARKS + "') "
            '    Try
            '        WebSer.Query3(Query3)
            '    Catch ex As Exception
            '        Dim scriptaviso As String = "alert('Error:" + ex.Message + "');"
            '        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", scriptaviso, True)
            '    End Try
            'Next

            'For Each row As GridViewRow In Me.GridView2.Rows
            '    Dim ItemCode = DirectCast(row.FindControl("TxtItemCode"), TextBox)
            '    Dim campoItem As String = ItemCode.Text
            '    'Dim campoItem As String = TryCast(row.FindControl("TxtItemCode"), TextBox).Text
            '    Dim Precio = DirectCast(row.FindControl("TxtPrecio"), TextBox)
            '    Dim campoPrecio As String = String.Format("{0:C2}", Precio.Text)
            '    'Dim campoPrecio As String = String.Format("{0:C2}", TryCast(row.FindControl("TxtPrecio"), TextBox).Text)
            '    Dim Precio2 = DirectCast(row.FindControl("TxtPrecio2"), TextBox)
            '    Dim campoPrecio2 As String = String.Format("{0:C2}", Precio2.Text)
            '    'Dim campoPrecio2 As String = String.Format("{0:C2}", TryCast(row.FindControl("TxtPrecio2"), TextBox).Text)
            '    Dim Precio3 = DirectCast(row.FindControl("TxtPrecio3"), TextBox)
            '    Dim campoPrecio3 As String = String.Format("{0:C2}", Precio3.Text)
            '    'Dim campoPrecio3 As String = String.Format("{0:C2}", TryCast(row.FindControl("TxtPrecio3"), TextBox).Text)
            '    Dim DD = DirectCast(row.FindControl("TxtDD"), TextBox)
            '    Dim campoDD As String = DD.Text
            '    'Dim campoDD As String = TryCast(row.FindControl("TxtDD"), TextBox).Text
            '    Dim Agente = DirectCast(row.FindControl("LblAGENT0"), Label)
            '    Dim campoAgente As String = Agente.Text
            '    'Dim campoAgente As String = TryCast(row.FindControl("LblAGENT0"), Label).Text
            '    Dim Carrier = DirectCast(row.FindControl("LblCARRIER0"), Label)
            '    Dim campoCarrier As String = Carrier.Text
            '    'Dim campoCarrier As String = TryCast(row.FindControl("LblCARRIER0"), Label).Text
            '    Dim PolCode = DirectCast(row.FindControl("LblPOL_CODE0"), Label)
            '    Dim campoPolCode As String = PolCode.Text
            '    'Dim campoPolCode As String = TryCast(row.FindControl("LblPOL_CODE0"), Label).Text
            '    Dim Pol = DirectCast(row.FindControl("LblPOL0"), Label)
            '    Dim campoPol As String = Pol.Text
            '    'Dim campoPol As String = TryCast(row.FindControl("LblPOL0"), Label).Text
            '    Dim PolCodeCountry = DirectCast(row.FindControl("LblPOL_CODE_COUNTRY0"), Label)
            '    Dim campoPolCodeCountry As String = PolCodeCountry.Text
            '    'Dim campoPolCodeCountry As String = TryCast(row.FindControl("LblPOL_CODE_COUNTRY0"), Label).Text
            '    Dim PodCode = DirectCast(row.FindControl("LblPOD_CODE0"), Label)
            '    Dim campoPodCode As String = PodCode.Text
            '    'Dim campoPodCode As String = TryCast(row.FindControl("LblPOD_CODE0"), Label).Text
            '    Dim PolCountry = DirectCast(row.FindControl("LblPOL_COUNTRY0"), Label)
            '    Dim campoPolCountry As String = PolCountry.Text
            '    'Dim campoPolCountry As String = TryCast(row.FindControl("LblPOL_COUNTRY0"), Label).Text
            '    Dim Pod = DirectCast(row.FindControl("LblPOD"), Label)
            '    Dim campoPod As String = Pod.Text
            '    'Dim campoPod As String = TryCast(row.FindControl("LblPOD"), Label).Text
            '    Dim PodCodeCountry = DirectCast(row.FindControl("LblPOD_CODE_COUNTRY0"), Label)
            '    Dim campoPodCodeCountry As String = PodCodeCountry.Text
            '    'Dim campoPodCodeCountry As String = TryCast(row.FindControl("LblPOD_CODE_COUNTRY0"), Label).Text
            '    Dim PodCountry = DirectCast(row.FindControl("LblPOD_COUNTRY0"), Label)
            '    Dim campoPodCountry As String = PodCountry.Text
            '    'Dim campoPodCountry As String = TryCast(row.FindControl("LblPOD_COUNTRY0"), Label).Text
            '    Dim Currency = DirectCast(row.FindControl("LblCURRENCY0"), Label)
            '    Dim campoCurrency As String = Currency.Text
            '    'Dim campoCurrency As String = TryCast(row.FindControl("LblCURRENCY0"), Label).Text
            '    Dim Equipment = DirectCast(row.FindControl("LblEQUIPMENT"), Label)
            '    Dim campoEquipment As String = Equipment.Text
            '    'Dim campoEquipment As String = TryCast(row.FindControl("LblEQUIPMENT"), Label).Text
            '    Dim ValidityFrom = DirectCast(row.FindControl("LblVALIDITY_FROM"), Label)
            '    Dim campoValidityFrom As String = ValidityFrom.Text
            '    'Dim campoValidityFrom As String = TryCast(row.FindControl("LblVALIDITY_FROM"), Label).Text
            '    Dim ValidityTo = DirectCast(row.FindControl("LblVALIDITY_TO"), Label)
            '    Dim campoValidityTo As String = ValidityTo.Text
            '    'Dim campoValidityTo As String = TryCast(row.FindControl("LblVALIDITY_TO"), Label).Text
            '    Dim TT = DirectCast(row.FindControl("LblTT"), Label)
            '    Dim campoTT As String = TT.Text
            '    'Dim campoTT As String = TryCast(row.FindControl("LblTT"), Label).Text
            '    Dim FreeDays = DirectCast(row.FindControl("LblFREE_DAYS"), Label)
            '    Dim campoFreeDays As String = FreeDays.Text
            '    'Dim campoFreeDays As String = TryCast(row.FindControl("LblFREE_DAYS"), Label).Text
            '    Dim NAC = DirectCast(row.FindControl("LblNAC"), Label)
            '    Dim campoNAC As String = NAC.Text
            '    'Dim campoNAC As String = TryCast(row.FindControl("LblNAC"), Label).Text
            '    Dim Commodity = DirectCast(row.FindControl("LblCOMMODITY"), Label)
            '    Dim campoCommodity As String = Commodity.Text
            '    'Dim campoCommodity As String = TryCast(row.FindControl("LblCOMMODITY"), Label).Text
            '    Dim UN = DirectCast(row.FindControl("LblUN"), Label)
            '    Dim campoUN As String = UN.Text
            '    'Dim campoUN As String = TryCast(row.FindControl("LblUN"), Label).Text
            '    Dim RA = DirectCast(row.FindControl("LblRA"), Label)
            '    Dim campoRA As String = RA.Text
            '    'Dim campoRA As String = TryCast(row.FindControl("LblRA"), Label).Text
            '    Dim SUBJECT = DirectCast(row.FindControl("LblSUBJECT"), Label)
            '    Dim campoSUBJECT As String = SUBJECT.Text
            '    'Dim campoSUBJECT As String = TryCast(row.FindControl("LblSUBJECT"), Label).Text
            '    Dim NOTSUBJECT = DirectCast(row.FindControl("LblNOT_SUBJECT"), Label)
            '    Dim campoNOTSUBJECT As String = NOTSUBJECT.Text
            '    'Dim campoNOTSUBJECT As String = TryCast(row.FindControl("LblNOT_SUBJECT"), Label).Text
            '    Dim REMARKS = DirectCast(row.FindControl("LblREMARKS"), Label)
            '    Dim campoREMARKS As String = REMARKS.Text
            '    'Dim campoREMARKS As String = TryCast(row.FindControl("LblREMARKS"), Label).Text
            '    Dim Query3 As String = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, [20GP], [40GP], [40HQ], DD, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, CURRENCY, EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, RA, SUBJECT, NOT_SUBJECT, REMARKS) VALUES ('" + FolioPedido.Trim + "' ,'" + campoItem + "', '" + campoPrecio + "', '" + campoPrecio2 + "','" + campoPrecio3 + "','" + campoDD + "','" + campoAgente + "','" + campoCarrier + "','" + campoPolCode + "','" + campoPol + "','" + campoPolCodeCountry + "','" + campoPolCountry + "','" + campoPodCode + "', '" + campoPod + "', '" + campoPodCodeCountry + "','" + campoPodCountry + "', '" + campoCurrency + "', '" + campoEquipment + "', '" + campoValidityFrom + "', '" + campoValidityTo + "', '" + campoTT + "', '" + campoFreeDays + "', '" + campoNAC + "', '" + campoCommodity + "', '" + campoUN + "', '" + campoRA + "', '" + campoSUBJECT + "', '" + campoNOTSUBJECT + "', '" + campoREMARKS + "') "
            '    WebSer.Query3(Query3)
            'Next



            'Using sdr As DataSet = WebSer.Query1(QueryDetalle)
            '    For Each row As DataRow In sdr.Tables(0).Rows
            '        'If Not IsDBNull(row("ItemCode")) Then
            '        campoItem = row("ItemCode").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("[20GP]")) Then
            '        campoPrecio = String.Format("{0:C2}", row("[20GP]").ToString.Trim)
            '        'End If

            '        'If Not IsDBNull(row("[40GP]")) Then
            '        campoPrecio2 = String.Format("{0:C2}", row("[40GP]").ToString.Trim)
            '        'End If

            '        'If Not IsDBNull(row("[40HQ]")) Then
            '        campoPrecio3 = String.Format("{0:C2}", row("[40HQ]").ToString.Trim)
            '        'End If

            '        'If Not IsDBNull(row("AGENT")) Then
            '        campoAgente = row("AGENT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("CARRIER")) Then
            '        campoCarrier = row("CARRIER").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL_CODE")) Then
            '        campoPolCode = row("POL_CODE").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL")) Then
            '        campoPol = row("POL").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL_CODE_COUNTRY")) Then
            '        campoPolCodeCountry = row("POL_CODE_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POL_COUNTRY")) Then
            '        campoPolCountry = row("POL_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD_CODE")) Then
            '        campoPodCode = row("POD_CODE").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD")) Then
            '        campoPod = row("POD").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD_COUNTRY")) Then
            '        campoPodCountry = row("POD_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("POD_CODE_COUNTRY")) Then
            '        campoPodCodeCountry = row("POD_CODE_COUNTRY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("CURRENCY")) Then
            '        campoCurrency = row("CURRENCY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("DD")) Then
            '        campoDD = row("DD").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("VALIDITY_FROM")) Then
            '        campoValidityFrom = row("VALIDITY_FROM").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("VALIDITY_TO")) Then
            '        campoValidityTo = row("VALIDITY_TO").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("VALIDITY_TO")) Then
            '        campoValidityTo = row("VALIDITY_TO").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("TT")) Then
            '        campoTT = row("TT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("FREE_DAYS")) Then
            '        campoFreeDays = row("FREE_DAYS").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("NAC")) Then
            '        campoNAC = row("NAC").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("EQUIPMENT")) Then
            '        campoEquipment = row("EQUIPMENT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("COMMODITY")) Then
            '        campoCommodity = row("COMMODITY").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("UN")) Then
            '        campoUN = row("UN").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("RA")) Then
            '        campoRA = row("RA").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("SUBJECT")) Then
            '        campoSUBJECT = row("SUBJECT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("NOT_SUBJECT")) Then
            '        campoNOTSUBJECT = row("NOT_SUBJECT").ToString.Trim
            '        'End If

            '        'If Not IsDBNull(row("REMARKS")) Then
            '        campoREMARKS = row("REMARKS").ToString.Trim
            '        'End If

            '        Dim Query3 As String = "Insert into BXP_Polimeros.dbo.DetallesPedido (IdPedido, ItemCode, [20GP], [40GP], [40HQ], DD, AGENT, CARRIER, POL_CODE, POL, POL_CODE_COUNTRY, POL_COUNTRY, POD_CODE, POD, POD_CODE_COUNTRY, POD_COUNTRY, CURRENCY, EQUIPMENT, VALIDITY_FROM, VALIDITY_TO, TT, FREE_DAYS, NAC, COMMODITY, UN, RA, SUBJECT, NOT_SUBJECT, REMARKS) VALUES ('" + FolioPedido.Trim + "' ,'" + campoItem + "', '" + campoPrecio + "', '" + campoPrecio2 + "','" + campoPrecio3 + "','" + campoDD + "','" + campoAgente + "','" + campoCarrier + "','" + campoPolCode + "','" + campoPol + "','" + campoPolCodeCountry + "','" + campoPolCountry + "','" + campoPodCode + "', '" + campoPod + "', '" + campoPodCodeCountry + "','" + campoPodCountry + "', '" + campoCurrency + "', '" + campoEquipment + "', '" + campoValidityFrom + "', '" + campoValidityTo + "', '" + campoTT + "', '" + campoFreeDays + "', '" + campoNAC + "', '" + campoCommodity + "', '" + campoUN + "', '" + campoRA + "', '" + campoSUBJECT + "', '" + campoNOTSUBJECT + "', '" + campoREMARKS + "') "
            '        Try
            '            WebSer.Query3(Query3)
            '        Catch ex As Exception
            '            Dim scriptaviso As String = "alert('Error:" + ex.Message + "');"
            '            ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", scriptaviso, True)
            '        End Try
            '    Next
            'End Using
            'End If

            'Catch ex As Exception
            '    Dim scriptaviso As String = "alert('Error:" + ex.Message + "');"
            '    ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", scriptaviso, True)
            'End Try

            WebSer.Dispose()
                Ds.Dispose()

                Dim script As String = "alert('Se duplicó exitosamente la cotización con el Folio " + nuevoFolio + "'); window.location.href='ResumenDetallesCotizacion.aspx';"
                ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

            Catch ex As Exception
                'Dim Log As New BXP_Log
                'Log.ErrorLog("BtnCanGuardar" + ex.Message)
            End Try
    End Sub

    Protected Sub BtnReporte2_Click(sender As Object, e As EventArgs) Handles BtnReporte2.Click
        'Enviar
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModalCorreo();", True)

        Dim Texto As String = ""
        Dim Asunto As String = ""

        Asunto = "Propuesta Crossmotion " + " " + TxtFolio0.Text

        Texto += "Estimado Cliente " + vbCrLf
        Texto += "" + vbCrLf
        Texto += "Con el objetivo de ser más ágiles y dando seguimiento a su actual requerimiento, a continuación encontrará la propuesta generada a través de nuestro sistema. " + vbCrLf
        Texto += "" + vbCrLf
        Texto += "En caso de vernos favorecidos con su confianza, le pedimos le notifique a su ejecutivo." + vbCrLf
        Texto += "" + vbCrLf
        Texto += "Gracias" + vbCrLf

        TextAsunto.Text = Asunto

        TxtCuerpo.Text = Texto

        TxtCorCorreo.Text = ObtenerCorreos()

    End Sub

    Protected Sub BtnReporte3_Click(sender As Object, e As EventArgs) Handles BtnReporte3.Click
        'Cancelar

        TxtCanFolio.Text = TxtFolio1.Text
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "Pop", "openModalCancelacion();", True)
    End Sub


    Protected Sub BtnCanGuardar_Click(sender As Object, e As EventArgs) Handles BtnCanGuardar.Click
        'Cancelar Cotizacion
        Try
            Dim WebSer As New BXP_WebServiceSQL
            Dim Query As String = "Insert into BXP_Polimeros.dbo.BXP_Cancelar (Id, Folio, Comentarios, Ban) VALUES ('0','" + CStr(TxtCanFolio.Text) + "','" + CStr(TxtCanDescripcion.Text) + "', 'False')"
            WebSer.Query3(Query)

            Dim script As String = "alert('La cancelación se realizó de manera exitosa'); window.location.href='ResumenDetallesCotizacion.aspx';"

            ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("BtnCanGuardar" + ex.Message)
        End Try
    End Sub

    Protected Sub BtnCorEnviar_Click(sender As Object, e As EventArgs) Handles BtnCorEnviar.Click
        'Envio de correo
        Try

            Dim IdWeb As String = LblIdWeb.Text

            Dim QueryCorreo As String = "Select email, U_PassCorreo From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + ReadCookie("Usuario", "Usuario") + "' "
            'Dim Query As String = "Select count(*) From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + Txt_User.Text + "' and U_clave = '" + Txt_Pass.Text + "' and Active = 'Y' "

            Dim WebSer As New BXP_WebServiceSQL
            Dim Common As New BXP_Common
            Dim Ds As DataTable = WebSer.Query1(QueryCorreo).Tables(0)

            Dim QueryActualizar As String = "UPDATE BXP_Polimeros.dbo.Pedido SET PedidoCompra = 0, Correos = '" + Common.Sanea(TxtCorCorreo.Text) + "', Cuerpo = '" + Common.Sanea(TxtCuerpo.Text) + "', Correo = '" + Common.Sanea(Ds.Rows(0).Item(0)) + "', Pass = '" + Common.Sanea(Ds.Rows(0).Item(1)) + "', Asunto = '" + Common.Sanea(TextAsunto.Text) + "' WHERE Id = '" + Common.Sanea(IdWeb) + "' "
            'Dim Query As String = "Select count(*) From Prototipo_Desarrollos.dbo.OHEM Where U_usuario = '" + Txt_User.Text + "' and U_clave = '" + Txt_Pass.Text + "' and Active = 'Y' "

            Dim WebSer2 As New BXP_WebServiceSQL

            WebSer2.Query1(QueryActualizar)

            Dim Correo As New BXP_SendMail(Ds.Rows(0).Item(0), Ds.Rows(0).Item(1), "smtp.office365.com", "587", True)
            Correo.SendMail(TxtCorCorreo.Text, TextAsunto.Text, TxtCuerpo.Text)

            Dim script As String = "alert('Se envió el correo con éxito'); window.location.href='ResumenDetallesCotizacion.aspx';"

            ScriptManager.RegisterStartupScript(Me, Me.GetType, "Aviso", script, True)

        Catch ex As Exception
            'Dim Log As New BXP_Log
            'Log.ErrorLog("Enviar cotizacion error - " + ex.Message)
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

    Protected Sub BtnReporte4_Click(sender As Object, e As EventArgs) Handles BtnReporte4.Click
        Response.Redirect("BXP_Delivery.aspx")
    End Sub

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

    Protected Sub TxtNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreCliente.TextChanged
        Try
            Dim Ws As New BXP_WebServiceSQL
            Dim Query As String = ""
            Dim St As String()

            St = TxtNombreCliente.Text.Split("/")
            TxtNombreCliente.Text = St(0)

            Query = "Select Max(CardCode) From Prototipo_Desarrollos.dbo.OCRD where CardName = '" + TxtNombreCliente.Text + "' "
            Dim CardCode As String = Ws.Query2(Query)

            TxtCodigoCliente.Text = CardCode

            Query = "Select Max(E_Mail) From Prototipo_Desarrollos.dbo.OCRD where CardName = '" + TxtNombreCliente.Text + "' "
            Dim Correo As String = Ws.Query2(Query)

            TxtCorreo.Text = Correo

            'Session("Cambios") = "True"
            WriteCookie("Cambios", "Cambios", "True")

        Catch ex As Exception
            Dim Log As New BXP_Log
            Log.ErrorLog("TxtNombreCliente_TextChanged - " + ex.Message)
        End Try
    End Sub

    Private Function ObtenerCorreos() As String
        'Select E_MailL From Prototipo_Desarrollos.dbo.OCPR where CardCode = ''
        Dim Correos As String = ""
        Try
            Dim Query As String = "Select E_MailL From Prototipo_Desarrollos.dbo.OCPR where CardCode = '" + TxtCodigoCliente.Text + "' "

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
            Dim Log As New BXP_Log
            Log.ErrorLog("Error al crear la cadena de correos " + ex.Message)
        End Try

        Return Correos
    End Function

End Class