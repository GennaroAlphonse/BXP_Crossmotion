<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/BXP_MasterPage/BXP_MasterPage.Master" CodeBehind="BXP_Resumen.aspx.vb" Inherits="BXP_Crossmotion.BXP_Resumen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.0.min.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" />

       <style type="text/css">   
              .cssPager span { background-color:#4f6b72; font-size:18px; color:white;} 
              .cssPager td
            {
                  padding-left: 5px;     
                  padding-right: 5px;    
              }              
        </style>

    <script type="text/javascript">


        $(function () {
            $("[id$=TxtName]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/GetCustomers")%>',
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
                    $("[id$=HFEmpresa]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TxtORIGIN]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po")%>',
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
                    $("[id$=HFORIGIN]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TxtDESTINATION]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po")%>',
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
                    $("[id$=HFDESTINATION]").val(i.item.val);
                },
                minLength: 1
            });
        });
    </script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-sm-12 form-horizontal">
                <h1>List of quotes</h1>
            </div>
        </div>
    </div>

<div class="formulario" >
    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                <div class="form-group">
                    <h3 class="col-sm-12">Buscador de cotizaciones:</h3>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">FILE:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtFILE" runat="server" CssClass="form-control" AutoPostBack="True" ></asp:TextBox>
                        <asp:HiddenField ID="HFFILE" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">MODALITY:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtMODALITY" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                        <asp:HiddenField ID="HFMODALITY" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">NAME:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtName" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                        <asp:HiddenField ID="HFEmpresa" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">SELLER:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtSELLER" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                        <asp:HiddenField ID="HFSELLER" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">REGION:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtREGION" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                        <asp:HiddenField ID="HFREGION" runat="server" />
                    </div>
                </div>


                <div class="form-group">
                    <label class="control-label col-sm-2">ORIGIN:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtORIGIN" runat="server" CssClass="form-control" AutoPostBack="True" ClientIDMode="Static"></asp:TextBox>
                        <asp:HiddenField ID="HFORIGIN" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">DESTINATION:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtDESTINATION" runat="server" CssClass="form-control" AutoPostBack="True" ClientIDMode="Static"></asp:TextBox>
                        <asp:HiddenField ID="HFDESTINATION" runat="server" />
                    </div>
                </div>


            </div>

            <div class="col-sm-5">
                <div class="form-group">
                    <label class="control-label col-sm-2">FROM:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="TxtFechaDesde" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                        <asp:Calendar ID="CalendarDesde" runat="server" Font-Size="11px"></asp:Calendar>
                    </div>
                    <div class="col-sm-1">
                        <asp:Button ID="BtnFechaDesde" runat="server" Text="" CssClass="Css_Calendario" />
                    </div>
                </div><br />

                <div class="form-group">
                    <label class="control-label col-sm-2">TO:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="TxtFechaAl" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                        <asp:Calendar ID="CalendarAl" runat="server" Font-Size="11px"></asp:Calendar>
                    </div>
                    <div class="col-sm-1">
                        <asp:Button ID="BtnFechaAl" runat="server" Text="" CssClass="Css_Calendario" />
                    </div>
                </div><br />

                <div class="form-group">
                    <label class="control-label col-sm-2">FAK/NAC:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtFAKNAC" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                    </div>
                </div><br />

                <div class="form-group">
                    <label class="control-label col-sm-2">KIND:</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="DdlKind" runat="server" CssClass="form-control">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>REPETITIVE</asp:ListItem>
                            <asp:ListItem>ONE SHOT</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div><br />

                <div class="form-group">
                    <label class="control-label col-sm-2">INCOTERM:</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="DdlIncoterm" runat="server" CssClass="form-control">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>FREE ON BOARD</asp:ListItem>
                            <asp:ListItem>EX WORKS</asp:ListItem>
                            <asp:ListItem>DELIVERED AT TERMINAL</asp:ListItem>
                            <asp:ListItem>DELIVERED AT PLACE</asp:ListItem>
                            <asp:ListItem>CARRIAGE PAID TO</asp:ListItem>
                            <asp:ListItem>CARRIAGE AND INSURANCE</asp:ListItem>
                            <asp:ListItem>COST AND FREIGHT</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div><br />

                <div class="form-group">
                    <label class="control-label col-sm-2">STATUS:</label><br />
                    <div class="col-sm-8">
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-8">
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Incomplete" AutoPostBack="True" />
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2"></label>
                    <div class="col-sm-8">
                        <asp:CheckBox ID="CheckBox5" runat="server" Text="Pending" AutoPostBack="True" />
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2"></label>
                    <div class="col-sm-8">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Delivered" AutoPostBack="True" />
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2"></label>
                    <div class="col-sm-8">
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Not Approved" AutoPostBack="True" />
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2"></label>
                    <div class="col-sm-8">
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="Accepted" AutoPostBack="True" />
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2"></label>
                    <div class="col-sm-8">
                        <asp:CheckBox ID="CheckBox6" runat="server" Text="Cancelled" AutoPostBack="True" />
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
            </div>

        </div>
                <div class="row">
            <div class="col-sm-6">
                <div class="form-group">
                    <asp:Button ID="BtnBuscar" runat="server" CssClass="btn btn-default Button" Text="BUSCAR" ClientIDMode="Static" />
                    <asp:Button ID="BtnMostrarTodo" runat="server" CssClass="btn btn-default Button" Text="MOSTRAR TODO" ClientIDMode="Static" />
                </div>
            </div>
                    </div>
    </div>
</div>

    <div id="Menu" align="center">

        <asp:Panel ID="PnlSubMenu" runat="server">
            <asp:Label ID="LblError" runat="server" CssClass="LblError"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="PnlTabla" runat="server">

            <asp:GridView ID="GVTabla" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="GV" PageSize="20" Font-Size="11px" ShowFooter="True">
                <Columns>
                    <asp:ButtonField Text="Botón" CommandName="FOLIO" DataTextField="U_FolioCrossmotion" HeaderText="FOLIO" />
                    <asp:ButtonField Text="Botón" CommandName="FOLIO" DataTextField="DocNum" HeaderText="FOLIO SAP">
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>
                    <asp:BoundField AccessibleHeaderText="DocEntry" DataField="DocEntry" HeaderText="">
                        <HeaderStyle Font-Size="1px" ForeColor="White" />
                        <ItemStyle HorizontalAlign="Center" Font-Size="1px" ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField AccessibleHeaderText="MODALITY " DataField="U_BXP_MET_TRANSPORT" HeaderText="MODALITY " />
                    <asp:BoundField AccessibleHeaderText="NAME" DataField="CardName" HeaderText="NAME" />
                    <asp:BoundField AccessibleHeaderText="SELLER" DataField="SlpName" HeaderText="SELLER" />
                    <asp:BoundField AccessibleHeaderText="REGION" DataField="descript" HeaderText="REGION" />
                    <asp:BoundField AccessibleHeaderText="ORIGIN" DataField="U_POL_COUNTRY" HeaderText="ORIGIN" />
                    <asp:BoundField AccessibleHeaderText="DESTINATION" DataField="U_POD_COUNTRY" HeaderText="DESTINATION" />

                    <asp:TemplateField AccessibleHeaderText="FROM" FooterText="FROM" HeaderText="FROM">
                        <ItemTemplate>
                            <asp:Label ID="LblFechaCreacion" runat="server" Text='<%# String.Format("{0:d}", Eval("U_Validity_From"))%>' ></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>

                    <asp:TemplateField AccessibleHeaderText="TO" FooterText="TO" HeaderText="TO">
                        <ItemTemplate>
                            <asp:Label ID="LblFechaCaduca" runat="server" Text='<%# String.Format("{0:d}", Eval("U_Validity_To"))%>' ></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:BoundField AccessibleHeaderText="FAK/NAC" DataField="U_NAC" HeaderText="FAK/NAC" />
                    <asp:BoundField AccessibleHeaderText="KIND" DataField="U_SHOT_REPETITIVE" HeaderText="KIND" />
                    <asp:BoundField AccessibleHeaderText="INCOTERM" DataField="U_BXP_INCOTERM" HeaderText="INCOTERM" />
                    <asp:BoundField AccessibleHeaderText="STATUS" DataField="Estatus" HeaderText="STATUS" />

                </Columns>
                <HeaderStyle BackColor="#01236A" Font-Size="11px" ForeColor="White" />

                <PagerStyle Font-Bold="True" Font-Size="18px" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" ForeColor="#0066FF" Width="10px" Wrap="True" CssClass="cssPager" />

            </asp:GridView>

        </asp:Panel>
    </div>

    <script type="text/javascript">
        $('#BtnMostrarTodo').on('click', function (e) {
            var $t = $(this),
                target = $t[0].href || $t.data("target") || $t.parents('.formulario') || [];

            $(target)
                .find("input,textarea,select")
                .val('')
                .end()
                .find("input[type=checkbox],input[type=radio]")
                .prop("checked", "")
                .end();
        })
    </script>

    <script type="text/javascript">
        $(document).ready(function () {
            $("input, textarea, input[type = checkbox], input[type = radio]").change(function () {
                document.location.href = document.location.href; 
            });
        });

    </script>

</asp:Content>

