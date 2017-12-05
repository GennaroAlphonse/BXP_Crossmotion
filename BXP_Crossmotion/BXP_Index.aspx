<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BXP_Index.aspx.vb" Inherits="BXP_Crossmotion.BXP_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />
    <title>CROSSMOTION</title>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.0.min.js" type="text/javascript"></script>
    <!--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>-->
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" />

    <link href="BXP_StyleSheet/BXP_SS_General.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <<div align="center">
            <div class="Pnl_Login">
                <br />
                <asp:Image ID="ImgLogo" runat="server" class="img-responsive" ImageUrl="~/BXP_Image/BXP_Empresa/logo.png" />
                <br />
                <div style="padding: 10px;">
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="email">User:</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="Txt_User" runat="server" CssClass="form-control" placeholder="Enter user"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="pwd">Password:</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="Txt_Pass" runat="server" CssClass="form-control" placeholder="Enter password" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <asp:Button ID="Btn_Ok" runat="server" Text="Ok" CssClass="btn btn-default Button" />
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
                <asp:Button ID="Btn_AcceptError" runat="server" Text="Aceptar" CssClass="Css_ButtonError" />
            </p>
        </asp:Panel>

    </form>
</body>
</html>

