<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/BXP_MasterPage/BXP_MasterPage.Master" CodeBehind="ResumenDetallesCotizacion.aspx.vb" Inherits="BXP_Crossmotion.ResumenDetallesCotizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Bootstrap/bootstrap.css" rel="stylesheet" />
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.0.min.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" />

<script type="text/javascript">
    $(document).ready(function () {

    function AnularEnter(keyCode) {
        if (keyCode == 13) {
            return false;
        }
        return true;
        };

        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
            //you need to re-bind your jquery events here
            autocompletarCliente();
        });

    function autocompletarCliente () {
        $("[id$=TxtNombreCliente]").autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: '<%=ResolveUrl("~/BXP_PageWebService.aspx/GetCustomers")%>',
                      data: "{ 'prefix': '" + request.term + "'}",
                      dataType: "json",
                      type: "POST",
                      contentType: "application/json; charset=utf-8",
                      success: function (data) {
                          response($.map(data.d, function (item) {
                              return {
                                  label: item.split('-')[0],
                                  val: item.split('-')[1]
                              }
                          }))
                      },
                      error: function (response) {
                          alert(response.responseText);
                      },
                      failure: function (response) {
                          alert(response.responseText);
                      }
                  });
              },
              select: function (e, i) {
                  $("[id$=HFCliente]").val(i.item.val);
              },
              minLength: 1
        });

    }

    //$('#TxtNombreCliente').autocomplete({ disabled: true });
    //$('#TxtNombreCliente').autocomplete('disable');
    //document.getElementById('TxtNombreCliente').autocomplete('disable');
    //document.getElementById("TxtNombreCliente").setAttribute("onkeydown", "return false;");
    //$('TxtNombreCliente').autocomplete({ disabled: true });

    });

</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>


            <div class="container">
                <div class="row">
                    <div class="col-sm-12 form-horizontal">
                        <h1>COTIZACION</h1>
                    </div>
                </div>
            </div>



            <div class="">
                <div class="row">
                    <div class="col-sm-6 form-horizontal">
                        <div class="form-group">
                            <label class="control-label col-sm-2">FOLIO SAP:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtFolio" runat="server" CssClass="form-control input-sm" Enabled="False" Visible="false"></asp:TextBox>
                                <asp:TextBox ID="TxtFolio1" runat="server" CssClass="form-control input-sm" Enabled="False"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">FOLIO:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtOrigen" runat="server" Enabled="False" CssClass="form-control input-sm" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TxtFolio0" runat="server" Enabled="False" CssClass="form-control input-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">FECHA:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtFecha" runat="server" CssClass="form-control input-sm" Enabled="False"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">CODIGO CLIENTE:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtCodigoCliente" runat="server" Enabled="False" CssClass="form-control input-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">CLIENTE:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtNombreCliente" runat="server" CssClass="form-control input-sm" AutoPostBack="true" clientidmode="Static"></asp:TextBox>
                                <asp:HiddenField ID="HFCliente" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">COMENTARIOS:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtComentarios" runat="server" TextMode="MultiLine" CssClass="form-control input-sm" ClientIDMode="Static"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6 form-horizontal">
                        <div class="form-group">
                            <label class="control-label col-sm-2">MONEDA:</label>
                            <div class="col-sm-9">
                                <asp:Label ID="LblMoneda" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">TC:</label>
                            <div class="col-sm-9">
                                <asp:Label ID="LblDolar" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">RFC:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtRfc" runat="server" CssClass="form-control input-sm" Enabled="False"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">TELEFONO:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control input-sm" Enabled="False"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">CORREO:</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control input-sm" Enabled="False"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">REALIZO:</label>
                            <div class="col-sm-9">
                                <asp:Label ID="LblRealizo" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-2">CORREO VENDEDOR:</label>
                            <div class="col-sm-9">
                                <asp:Label ID="LblCorreoVendedor" runat="server"></asp:Label>
                                <asp:HiddenField ID="SLP" runat="server" />
                                <asp:HiddenField ID="U_SHOT_REPETITIVE" runat="server"/>
                                <asp:HiddenField ID="U_BXP_INCOTERM" runat="server"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="container">
                <div class="row">
                    <div class="col-sm-4 form-horizontal">
                        <div class="form-group">
                            <label class="control-label col-sm-3"></label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtSubTotal" runat="server" Enabled="False" CssClass="form-control" Visible="false"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="control-label col-sm-3"></label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtIva" runat="server" Enabled="False" CssClass="form-control" Visible="false"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="control-label col-sm-3"></label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TxtTotal" runat="server" Enabled="False" CssClass="form-control" Visible="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <asp:TextBox ID="TxtDirigida" runat="server" Enabled="False" Width="150px" Visible="False"></asp:TextBox>
            <asp:TextBox ID="TxtExtension" runat="server" Enabled="False" Visible="False" Width="150px"></asp:TextBox>

            <div class="">
                <div class="row">
                    <div class="col-sm-12 form-horizontal">
                        <asp:Panel ID="PnlAerP" runat="server" CssClass="form-control" Height="100%" ScrollBars="Both">
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" class="table" ClientIDMode="Static">
                                <Columns>

                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="ItemCode" FooterText="ItemCode" HeaderText="ItemCode">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TxtItemCode" runat="server" BorderStyle="None" Text='<%# Bind("ItemCode")%>'></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle/>
                                        <FooterStyle/>
                                        <HeaderStyle/>
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="Dscription" FooterText="Dscription" HeaderText="Dscription">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TxtDscription" runat="server" BorderStyle="None" Text='<%# Bind("Dscription")%>'></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle/>
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>

                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox2" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="PRECIO1" FooterText="PRECIO1" HeaderText="20GP Tarifario">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TxtPrecio" runat="server" BorderStyle="None" Text='<%# String.Format("{0:N2}", Eval("[Price]"))%>'></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle/>
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox3" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="PRECIO2" FooterText="PRECIO2" HeaderText="40GP">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TxtPrecio2" runat="server" Text='<%# String.Format("{0:N2}", Eval("[U_Price_40]"))%>'></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox4" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="PRECIO3" FooterText="PRECIO3" HeaderText="40HQ">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TxtPrecio3" runat="server" Text='<%# String.Format("{0:N2}", Eval("[U_Price_40HQ]"))%>'></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="DD" FooterText="DD" HeaderText="DD">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TxtDD" runat="server" Text='<%# Bind("U_DD")%>'></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAGENT0" runat="server" Text='<%# Bind("U_AGENT")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CARRIER" FooterText="CARRIER" HeaderText="CARRIER">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCARRIER0" runat="server" Text='<%# Bind("U_CARRIER")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_CODE" FooterText="POL_CODE" HeaderText="POL_CODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_CODE0" runat="server" Text='<%# Bind("U_POL_CODE")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL" FooterText="POL" HeaderText="POL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL0" runat="server" Text='<%# Bind("U_POL")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_CODE_COUNTRY" FooterText="POL_CODE_COUNTRY" HeaderText="POL_CODE_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_CODE_COUNTRY0" runat="server" Text='<%# Bind("U_POL_CODE_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle/>
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_COUNTRY0" runat="server" Text='<%# Bind("U_POL_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD_CODE" FooterText="POD_CODE" HeaderText="POD_CODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_CODE0" runat="server" Text='<%# Bind("U_POD_CODE")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD" FooterText="POD" HeaderText="POD">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD0" runat="server" Text='<%# Bind("U_POD")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle/>
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD_CODE_COUNTRY" FooterText="POD_CODE_COUNTRY" HeaderText="POD_CODE_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_CODE_COUNTRY0" runat="server" Text='<%# Bind("U_POD_CODE_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle  />
                                        <FooterStyle  />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD_COUNTRY" FooterText="POD_COUNTRY" HeaderText="POD_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_COUNTRY0" runat="server" Text='<%# Bind("U_POD_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY0" runat="server" Text='<%# Bind("U_CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle Font-Size="12px" HorizontalAlign="left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl20GP" runat="server" Text='<%# Bind("U_20GP")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle/>
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40GP" runat="server" Text='<%# Bind("U_40GP")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40HQ" runat="server" Text='<%# Bind("U_40HQ")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="EQUIPMENT" FooterText="EQUIPMENT" HeaderText="EQUIPMENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblEQUIPMENT" runat="server" Text='<%# Bind("U_EQUIPMENT")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VALIDITY_FROM" FooterText="VALIDITY_FROM" HeaderText="VALIDITY_FROM">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVALIDITY_FROM" runat="server" Text='<%# Bind("U_VALIDITY_FROM")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VALIDITY_TO" FooterText="VALIDITY_TO" HeaderText="VALIDITY_TO">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVALIDITY_TO" runat="server" Text='<%# Bind("U_VALIDITY_TO")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TT" FooterText="TT" HeaderText="TT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTT" runat="server" Text='<%# Bind("U_TT")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREE_DAYS" runat="server" Text='<%# Bind("U_FREE_DAYS_POD")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("U_NAC")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("U_COMMODITY")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="UN" FooterText="UN" HeaderText="UN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblUN" runat="server" Text='<%# Bind("U_UN")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblRA" runat="server" Text='<%# Bind("U_RA")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="SUBJECT" FooterText="SUBJECT" HeaderText="SUBJECT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSUBJECT" runat="server" Text='<%# Bind("U_SUBJECT_TO")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="NOT_SUBJECT" FooterText="NOT_SUBJECT" HeaderText="NOT_SUBJECT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNOT_SUBJECT" runat="server" Text='<%# Bind("U_NOT_SUBJECT_TO")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="REMARKS" FooterText="REMARKS" HeaderText="REMARKS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("U_REMARKS")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle />
                                        <FooterStyle />
                                        <HeaderStyle />
                                        <ItemStyle HorizontalAlign="left" Font-Size="12px" />
                                    </asp:TemplateField>





                                </Columns>
                                <HeaderStyle BackColor="#01236A" Font-Names="Tahoma" Font-Size="9pt" ForeColor="White" />
                                <PagerSettings Mode="NextPreviousFirstLast" />
                            </asp:GridView>
                        </asp:Panel>
                    </div>


                </div>
            </div>

            <div class="container">
                <div class="modal" id="myModalCancelacion">
                    <div class="modal-dialog modal-lg">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title">
                                    <asp:Label ID="LblTituloSolicitud" runat="server" Text="Label">CANCELACION</asp:Label>
                                </h4>
                            </div>
                            <div class="modal-body">

                                <div id="formcancel" runat="server" class="col-lg-12">
                                    <div class="col-md-6">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-sm-4">No. FOLIO:</label>
                                                <div class="col-sm-8">
                                                    <asp:TextBox ID="TxtCanFolio" runat="server" Enabled="False" CssClass="form-control"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-sm-4">MOTIVO</label>
                                                <div class="col-sm-8">
                                                    <asp:DropDownList ID="DdlMotivos" runat="server">
                                                        <asp:ListItem></asp:ListItem>
                                                        <asp:ListItem></asp:ListItem>
                                                        <asp:ListItem></asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        </div>
                                        <div class="col-md-6">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-sm-4">DESCRIPCION</label>
                                                <div class="col-sm-8">
                                                    <asp:TextBox ID="TxtCanDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control" Height="320px" Visible="True"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>


                            <div class="modal-footer">

                                <div class="col-md-6">
                                    <div id="DivSuccess" runat="server" class="alert alert-success alert-dismissable">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Success!</strong>
                                        <asp:Label ID="LblSuccess" runat="server"></asp:Label>
                                    </div>
                                    <div id="DivInfo" runat="server" class="alert alert-info alert-dismissable">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Info!</strong>
                                        <asp:Label ID="LblInfo" runat="server"></asp:Label>
                                    </div>
                                    <div id="DivWarning" runat="server" class="alert alert-danger alert-dismissable">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Warning!</strong>
                                        <asp:Label ID="LblWarning" runat="server"></asp:Label>
                                    </div>
                                </div>

                                <asp:Button ID="BtnCanGuardar" runat="server" Text="GUARDAR" CssClass="btn btn-default" />
                                <button type="button" class="btn btn-default" data-dismiss="modal">CANCELAR</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="container">
                <div class="row">
                    <div class="col-sm-12 form-horizontal">
                        <div class="form-group">
                            <asp:Button ID="BtnCancelar" runat="server" CssClass="btn btn-default Button" Text="REGRESAR" />
                            <div id="opcionbotones" runat="server">
                            <asp:Button ID="BtnGuardar" runat="server" CssClass="btn btn-default Button" Text="GUARDAR CAMBIOS" />
                            <asp:Button ID="BtnReporte0" runat="server" CssClass="btn btn-default Button" Text="EDITAR" ClientIDMode="Static" />
                            <asp:Button ID="BtnReporte1" runat="server" CssClass="btn btn-default Button" Text="DUPLICAR" />
                            <asp:Button ID="BtnReporte2" runat="server" CssClass="btn btn-default Button" Text="ENVIAR" />
                            <asp:Button ID="BtnReporte3" runat="server" CssClass="btn btn-default Button" Text="CANCELAR" />
                            <asp:Button ID="BtnReporte4" runat="server" CssClass="btn btn-default Button" Text="REALIZAR ORDEN" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <div class="container">
                <div class="modal" id="myModalCorreo">
                    <div class="modal-dialog modal-lg">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title">
                                    <asp:Label ID="Label1" runat="server" Text="Label">ENVIAR CORREO</asp:Label>
                                </h4>
                            </div>
                            <div class="modal-body">

                                <div id="formcorreo" runat="server" class="col-lg-12">
                                    <div class="col-md-6">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-sm-4">CORREO:</label>
                                                <div class="col-sm-8">
                                                    <asp:TextBox ID="TxtCorCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                                           
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-sm-4">ASUNTO:</label>
                                                <div class="col-sm-8">
                                                    <asp:TextBox ID="TextAsunto" runat="server" CssClass="form-control"></asp:TextBox>
                                           
                                                </div>
                                            </div>
                                        </div>
                                        </div>
                                        </div>
                                        <div class="col-md-6">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-sm-4">CUERPO:</label>
                                                <div class="col-sm-8">
                                                    <asp:TextBox ID="TxtCuerpo" runat="server" TextMode="MultiLine" CssClass="form-control" Visible="True" Height="320px"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                          </div>

                            <div class="modal-footer">

                                <div class="col-md-6">
                                    <div id="DivSuccessCorreo" runat="server" class="alert alert-success alert-dismissable">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Success!</strong>
                                        <asp:Label ID="Label2" runat="server"></asp:Label>
                                    </div>
                                    <div id="DivInfoCorreo" runat="server" class="alert alert-info alert-dismissable">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Info!</strong>
                                        <asp:Label ID="Label3" runat="server"></asp:Label>
                                    </div>
                                    <div id="DivDangerCorreo" runat="server" class="alert alert-danger alert-dismissable">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Warning!</strong>
                                        <asp:Label ID="Label4" runat="server"></asp:Label>
                                    </div>
                                </div>

                                <asp:Button ID="BtnCorEnviar" runat="server" Text="ENVIAR" CssClass="btn btn-default" />
                                <button type="button" class="btn btn-default" data-dismiss="modal">CANCELAR</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

           <asp:Panel ID="Pnl_Background" runat="server" CssClass="Css_Background"></asp:Panel>

            <asp:Panel ID="Pnl_Message" runat="server" CssClass="Css_PnlMessage">
                <p>
                    <asp:Label ID="Lbl_TitleError" runat="server" CssClass="Css_TitleError"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="Lbl_MessageError" runat="server" CssClass="Css_MessageError"></asp:Label>
                </p>
                <p>
                    <asp:Button ID="Btn_AcceptError" runat="server" Text="Aceptar" CssClass="btn btn-default Button" />
                </p>

            </asp:Panel>
                    <asp:Label ID="LblIdWeb" runat="server" Text="Label" ClientIDMode="Static" Visible="false"> </asp:Label>



  <script type="text/javascript">

        function openModalCancelacion() {
            $('#myModalCancelacion').modal('show');
        }
    </script>

  <script type="text/javascript">
      function openModalCorreo() {
          $('#myModalCorreo').modal('show');
        }

      $(document).ready(function () {
          $('table.aspNetDisabled').addClass('table');
      });


      //function habilitar() {
          //document.getElementById('TxtNombreCliente').onkeydown = "javascript:return true"; 
          //document.getElementById('TxtComentarios').onkeydown = "javascript:return true";
          //$('#TxtNombreCliente').onfocus = null;
          //$('#TxtNombreCliente').focus();
          //$('#TxtComentarios').onfocus = null;
          //document.getElementById('TxtNombreCliente').onfocus = null;
          //document.getElementById('TxtNombreCliente').focus();
          //document.getElementById('TxtComentarios').onfocus = null;
          //$('#TxtNombreCliente').on('keydown');
          //$('#TxtComentarios').on('keydown');
          //$('#TxtNombreCliente').disabled = false;
          //document.getElementById("TxtNombreCliente").setAttribute("onkeydown", "");
          //document.getElementById('TxtNombreCliente').autocomplete('enable');
          //$('#TxtNombreCliente').autocomplete('enable');
          //$('#TxtNombreCliente').autocomplete({ disabled: false });
  
      //}

      //document.getElementById('BtnReporte0').click(function () {
      //    document.getElementById('TxtNombreCliente').addEventListener('keydown');
      //});
      $('#BtnReporte0').on('click', function (e) {
          document.getElementById("TxtNombreCliente").setAttribute("readonly", false);
 

          Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
              //you need to re-bind your jquery events here
              tab = document.getElementById("GridView2");
              for (i = 0; ele = tab.getElementsByTagName("input")[i]; i++) {
                  ele.disabled = false;
              }
          });
          //document.getElementById("TxtNombreCliente").autocomplete('enable');
          //$("#TxtNombreCliente").autocomplete("search", "");
          //$('#TxtNombreCliente').autocomplete("option", "minLength", "0");

      });

      //document.getElementById("TxtNombreCliente").autocomplete("disable");
      document.getElementById("TxtNombreCliente").setAttribute("readonly", true);

    </script>
        </ContentTemplate>
  <Triggers>
     <asp:AsyncPostBackTrigger ControlID="BtnReporte0" EventName="Click" />
    </Triggers>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress" runat="server">
        <ProgressTemplate>
            <asp:Panel ID="PnlCargando" runat="server" Enabled="true" CssClass="PnlCargando">
                <asp:Image ID="ImageCargando" runat="server" src="Image/Cargando.gif" class="ImageCargando" />
            </asp:Panel>
        </ProgressTemplate>
     </asp:UpdateProgress>
</asp:Content>
