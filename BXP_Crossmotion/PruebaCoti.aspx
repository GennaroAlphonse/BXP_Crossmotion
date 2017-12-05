<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/BXP_MasterPage/BXP_MasterPage.Master" CodeBehind="PruebaCoti.aspx.vb" Inherits="BXP_Crossmotion.PruebaCoti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.0.min.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" />


    <script type="text/javascript">
        $(function () {
            $("[id$=TxtEmpresa]").autocomplete({
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
            $("[id$=TxtPOL]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=HiddenField2]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TxtPOD]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=HiddenField3]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TextBox10]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=HiddenField1]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TextBox12]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=HiddenField4]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=GridView1_TxtPOLC_0]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=HiddenField11]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=GridView1_TxtPODC_0]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=HiddenField10]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

    </script>

    <script type="text/javascript">
        function AnularEnter(keyCode) {
            if (keyCode == 13) {
                return false;
            }
            return true;
        };
    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod1]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod1]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod2]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod2]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod3]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod3]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod4]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod4]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod5]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod5]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod6]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod6]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod7]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod7]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod8]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod8]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod9]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod9]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pod10]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpod10]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol1]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol1]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol2]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol2]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol3]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol3]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol4]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol4]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol5]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol5]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol6]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol6]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol7]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol7]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol8]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol8]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol9]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol9]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

                $(function () {
                    $("[id$=pol10]").autocomplete({
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

                                },
                                failure: function (response) {

                                }
                            });
                        },
                        select: function (e, i) {
                            $("[id$=hfpol10]").val(i.item.val);
                        },
                        minLength: 1
                    });
                });

    </script>

    <script type="text/javascript">
        function seleccionarServicio() {
            //var selector = document.getElementById("DdlTipoCotizacion").options[document.getElementById("DdlTipoCotizacion").selectedIndex.text];
            var selector = $("#DdlTipoCotizacion option:selected").text();
            document.getElementById("titulomodal").textContent = selector;
            //var valor = document.getElementById("DdlTipoCotizacion").options[document.getElementById("DdlTipoCotizacion").selectedIndex.value];
            var valor = $("#DdlTipoCotizacion").val();
            //var valor = document.getElementById("DdlTipoCotizacion").options[document.getElementById("DdlTipoCotizacion").selectedIndex.value];

            if (valor == 1) {

                //$("#maritimocompleto").show();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "block");
                $("#ltlintermodal").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 2) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").show();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#ltlamericanonacional").css("display", "block");
                $("#maritimocompleto").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 3) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").show();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "block");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 4) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").show();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "block");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 5) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").show();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "block");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 6) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").show();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "block");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 7) {


                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").show();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "block");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 8) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").show();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "block");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 9) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").show();
                //$("#tarifarioarrastres").hide();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "block");
                $("#tarifarioarrastres").css("display", "none");
            }
            else if (valor == 10) {

                //$("#maritimocompleto").hide();
                //$("#ltlintermodal").hide();
                //$("#ltlamericanonacional").hide();
                //$("#maritimolcl").hide();
                //$("#terrestrenacional").hide();
                //$("#addonnobase").hide();
                //$("#tarifariolcl11").hide();
                //$("#arrastrebl").hide();
                //$("#tarifarioamericano").hide();
                //$("#tarifarioarrastres").show();

                $("#maritimocompleto").css("display", "none");
                $("#ltlamericanonacional").css("display", "none");
                $("#ltlintermodal").css("display", "none");
                $("#maritimolcl").css("display", "none");
                $("#terrestrenacional").css("display", "none");
                $("#addonnobase").css("display", "none");
                $("#tarifariolcl11").css("display", "none");
                $("#arrastrebl").css("display", "none");
                $("#tarifarioamericano").css("display", "none");
                $("#tarifarioarrastres").css("display", "block");
            }

        }
    </script>
    <style type="text/css">
        .contenidomodal input {
            margin-left: 60px;
            padding: 5px;
        }

        .contenidomodal label {
            margin-left: 30px;
            padding: 5px;
            width: 150px;
        }

        .contenidomodal .form-control {
            width: 400px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <div class="container">
        <div class="row">
            <div class="col-sm-8">
                <div class="form-group">
                    <label class="control-label col-sm-3 inputsm">Número Cotización:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtFolio" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3 inputsm">Empresa:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtEmpresa" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                        <asp:TextBox ID="TxtEmpresaCodigo" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                        <asp:HiddenField ID="HFEmpresa" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3 inputsm">Contacto:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtContacto" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3 inputsm" for="comment">Descripción:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control input-sm" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3 inputsm">Producto:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="TxtProducto" runat="server" CssClass="form-control input-sm" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3 inputsm">Tipo de Cotización:</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="DdlTipoCotizacion" runat="server" CssClass="form-control" ClientIDMode="Static" ClientID="DdlTipoCotizacion">
                            <asp:ListItem Value="1" Text="TARIFARIO MARÍTIMO COMPLETO" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="TARIFARIO LTL - AMERICANO - NACIONAL"></asp:ListItem>
                            <asp:ListItem Value="3" Text="TARIFARIO LTL INTERMODAL"></asp:ListItem>
                            <asp:ListItem Value="4" Text="TARIFARIO MARITIMO LCL"></asp:ListItem>
                            <asp:ListItem Value="5" Text="TARIFARIO TERRESTRE NACIONAL"></asp:ListItem>
                            <asp:ListItem Value="6" Text="TARIFARIO_ADDON_NO BASE"></asp:ListItem>
                            <asp:ListItem Value="7" Text="AEREO TARIFARIO LCL 1.1"></asp:ListItem>
                            <asp:ListItem Value="8" Text="ARRASTRE DENTRO DE BL"></asp:ListItem>
                            <asp:ListItem Value="9" Text="TARIFARIO AMERICANO"></asp:ListItem>
                            <asp:ListItem Value="10" Text="TARIFARIO ARRASTRES"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>


                <button id="abrirformulario" type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal2" onclick="seleccionarServicio();">Abrir formulario</button>

                <!-- Modal -->
                <div class="modal fade" id="myModal2" role="dialog">
                    <div class="modal-dialog">

                        <!-- Modal content-->
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 id="titulomodal" class="modal-title"></h4>
                            </div>
                            <div class="modal-body">
                                <div class="contenidomodal">

                                    <div id="maritimocompleto" class="col-lg-4">

                                        <label class="control-label" for="carrier1">CARRIER</label>
                                        <asp:TextBox ID="carrier1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="pol1">POL</label>
                                        <asp:TextBox ID="pol1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode1" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol1" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod1">POD</label>
                                        <asp:TextBox ID="pod1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode1" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod1" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="equipment">EQUIPMENT</label>
                                        <asp:TextBox ID="equipment" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="un">UN</label>
                                        <asp:TextBox ID="un" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="class">CLASS</label>
                                        <asp:TextBox ID="class" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity1">COMMODITY</label>
                                        <asp:TextBox ID="commodity1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="remarks1">REMARKS</label>
                                        <asp:TextBox ID="remarks1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="cargoweight">CARGO WEIGHT</label>
                                        <asp:TextBox ID="cargoweight" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="incoterm">INCOTERM</label>
                                        <asp:TextBox ID="incoterm" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="packing1">PACKING</label>
                                        <asp:TextBox ID="packing1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="number">NUMBER</label>
                                        <asp:TextBox ID="number" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="measures1">MEASURES</label>
                                        <asp:TextBox ID="measures1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="stackable1">STACKABLE</label>
                                        <asp:TextBox ID="stackable1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="ltlamericanonacional" class="col-lg-4">

                                        <label class="control-label" for="carrier2">CARRIER</label>
                                        <asp:TextBox ID="carrier2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="origin1">ORIGIN</label>
                                        <asp:TextBox ID="origin1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idorigin1" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hforigin1" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol2">POL</label>
                                        <asp:TextBox ID="pol2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode2" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol2" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry1">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode1" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry1" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol_zipcode1">POL_ZIPCODE</label>
                                        <asp:TextBox ID="polzipcode1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="destination1">DESTINATION</label>
                                        <asp:TextBox ID="destination1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="iddestination1" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfdestination1" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod2">POD</label>
                                        <asp:TextBox ID="pod2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode2" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod2" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry1">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcodecountry1" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry1" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod_zipcode1">POD_ZIPCODE</label>
                                        <asp:TextBox ID="pod_zipcode1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="type">TYPE</label>
                                        <asp:TextBox ID="type" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity2">COMMODITY</label>
                                        <asp:TextBox ID="commodity2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="remarks">REMARKS</label>
                                        <asp:TextBox ID="remarks2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight">WEIGHT</label>
                                        <asp:TextBox ID="weigth" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="measures">MEASURES</label>
                                        <asp:TextBox ID="measures" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="volume">VOLUME</label>
                                        <asp:TextBox ID="volume" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="stackable">STACKABLE</label>
                                        <asp:TextBox ID="stackable" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency">CURRENCY</label>
                                        <asp:TextBox ID="currency" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="packing">PACKING</label>
                                        <asp:TextBox ID="packing" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="quantity">QUANTITY</label>
                                        <asp:TextBox ID="quantity" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="stops">STOPS</label>
                                        <asp:TextBox ID="stops" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="ltlintermodal" class="col-lg-4">

                                        <label class="control-label" for="carrier3">CARRIER</label>
                                        <asp:TextBox ID="carrier3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="origin2">ORIGIN</label>
                                        <asp:TextBox ID="origin2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idorigin2" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hforigin2" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="originramp">ORIGIN RAMP</label>
                                        <asp:TextBox ID="originramp" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idoriginramp" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hforiginramp" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol3">POL</label>
                                        <asp:TextBox ID="pol3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode3" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol3" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry3">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode3" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry3" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol_zipcode">POL_ZIPCODE</label>
                                        <asp:TextBox ID="pol_zipcode2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="destination2">DESTINATION</label>
                                        <asp:TextBox ID="destination2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="iddestination2" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfdestination2" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="destinationramp">DESTINATION RAMP</label>
                                        <asp:TextBox ID="destinationramp" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="iddestinationramp" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfdestinationramp" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod3">POD</label>
                                        <asp:TextBox ID="pod3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode3" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod3" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry2">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcodecountry2" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry2" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod_zipcode2">POD_ZIPCODE</label>
                                        <asp:TextBox ID="pod_zipcode2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency">CURRENCY</label>
                                        <asp:TextBox ID="TextBox7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="un1">UN</label>
                                        <asp:TextBox ID="un1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="class1">CLASS</label>
                                        <asp:TextBox ID="class1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="equipment1">EQUIPMENT</label>
                                        <asp:TextBox ID="equipment1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idequipment1" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfequipment1" ClientIDMode="Static" runat="server" />
                                        <label class="control-label" for="commodity3">COMMODITY</label>
                                        <asp:TextBox ID="commodity3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="remarks3">REMARKS</label>
                                        <asp:TextBox ID="remarks3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight2">WEIGHT</label>
                                        <asp:TextBox ID="weight2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="measures">MEASURES</label>
                                        <asp:TextBox ID="TextBox30" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="stackable">STACKABLE</label>
                                        <asp:TextBox ID="TextBox32" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency">CURRENCY</label>
                                        <asp:TextBox ID="TextBox33" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="packing">PACKING</label>
                                        <asp:TextBox ID="TextBox34" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="maritimolcl" class="col-lg-4">
                                        <label for="coloader">CO-LOADER</label>
                                        <asp:TextBox ID="coloader" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="pol4">POL</label>
                                        <asp:TextBox ID="pol4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode4" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol4" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry4">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode4" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry4" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod4">POD</label>
                                        <asp:TextBox ID="pod4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode4" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod4" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry4">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcountrycode4" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry4" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="via1">VIA 1</label>
                                        <asp:TextBox ID="via1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="via2">VIA 2</label>
                                        <asp:TextBox ID="via2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="via3">VIA 3</label>
                                        <asp:TextBox ID="via3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="currency2">CURRENCY</label>
                                        <asp:TextBox ID="currency2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="cost">COST</label>
                                        <asp:TextBox ID="cost" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="minimumcost">MINIMUM COST</label>
                                        <asp:TextBox ID="minimumcost" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="equipment2">EQUIPMENT</label>
                                        <asp:TextBox ID="equipment2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idequipment2" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfequipment2" ClientIDMode="Static" runat="server" />
                                        <label class="control-label" for="commodity4">COMMODITY</label>
                                        <asp:TextBox ID="commodity4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="un2">UN</label>
                                        <asp:TextBox ID="un2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="class2">CLASS</label>
                                        <asp:TextBox ID="class2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="bl">BL</label>
                                        <asp:TextBox ID="bl" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="remarks4">REMARKS</label>
                                        <asp:TextBox ID="remarks4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight3">CARGO WEIGHT</label>
                                        <asp:TextBox ID="weight3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="incoterm1">INCOTERM</label>
                                        <asp:TextBox ID="incoterm1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="packing2">PACKING</label>
                                        <asp:TextBox ID="packing2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="number2">NUMBER</label>
                                        <asp:TextBox ID="number2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="measures2">MEASURES</label>
                                        <asp:TextBox ID="measures2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="stackable2">STACKABLE</label>
                                        <asp:TextBox ID="stackable2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="terrestrenacional" class="col-lg-4">

                                        <label class="control-label" for="carrier4">CARRIER</label>
                                        <asp:TextBox ID="carrier4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="origin3">ORIGIN</label>
                                        <asp:TextBox ID="origin3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idorigin3" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hforigin3" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol5">POL</label>
                                        <asp:TextBox ID="pol5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol5" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry5">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry5" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol_zipcode3">POL_ZIPCODE</label>
                                        <asp:TextBox ID="pol_zipcode3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="destination3">DESTINATION</label>
                                        <asp:TextBox ID="destination3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="iddestination3" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfdestination3" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod5">POD</label>
                                        <asp:TextBox ID="pod5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod5" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry5">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcountrycode5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry5" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod_zipcode3">POD_ZIPCODE</label>
                                        <asp:TextBox ID="pod_zipcode3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="via1">STOP 1</label>
                                        <asp:TextBox ID="stop1" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="via2">STOP 2</label>
                                        <asp:TextBox ID="stop2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="via3">STOP 3</label>
                                        <asp:TextBox ID="stop3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="un3">UN</label>
                                        <asp:TextBox ID="un3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="class3">CLASS</label>
                                        <asp:TextBox ID="class3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="equipment3">EQUIPMENT</label>
                                        <asp:TextBox ID="equipment3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idequipment3" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfequipment3" ClientIDMode="Static" runat="server" />
                                        <label class="control-label" for="remarks5">REMARKS</label>
                                        <asp:TextBox ID="remarks5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight4">WEIGHT</label>
                                        <asp:TextBox ID="weight4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="measures3">MEASURES</label>
                                        <asp:TextBox ID="measures3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="stackable3">STACKABLE</label>
                                        <asp:TextBox ID="stackable3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency3">CURRENCY</label>
                                        <asp:TextBox ID="currency3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="packing3">PACKING</label>
                                        <asp:TextBox ID="packing3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity5">COMMODITY</label>
                                        <asp:TextBox ID="commodity5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="addonnobase" class="col-lg-4">

                                        <label class="control-label" for="carrier5">CARRIER</label>
                                        <asp:TextBox ID="carrier5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="polcountry6">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode6" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry6" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol6">POL</label>
                                        <asp:TextBox ID="pol6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode6" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol6" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry6">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcountrycode6" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry6" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod6">POD</label>
                                        <asp:TextBox ID="pod6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode6" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod6" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="veinte">20</label>
                                        <asp:TextBox ID="veinte" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="cuarenta">40</label>
                                        <asp:TextBox ID="cuarenta" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="cuarentahq">40HQ</label>
                                        <asp:TextBox ID="cuarentahq" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="remarks6">REMARKS</label>
                                        <asp:TextBox ID="remarks6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency4">CURRENCY</label>
                                        <asp:TextBox ID="currency4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity6">COMMODITY</label>
                                        <asp:TextBox ID="commodity6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="tarifariolcl11" class="col-lg-4">

                                        <label class="control-label" for="pol7">POL</label>
                                        <asp:TextBox ID="pol7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode7" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol7" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry7">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode7" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry7" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod7">POD</label>
                                        <asp:TextBox ID="pod7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode7" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod7" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry7">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcountrycode7" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry7" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="un4">UN</label>
                                        <asp:TextBox ID="un4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="class4">CLASS</label>
                                        <asp:TextBox ID="class4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="remarks7">REMARKS</label>
                                        <asp:TextBox ID="remarks7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity7">COMMODITY</label>
                                        <asp:TextBox ID="commodity7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="packing4">PACKING</label>
                                        <asp:TextBox ID="packing4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="number3">NUMBER PKG</label>
                                        <asp:TextBox ID="number3" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight5">WEIGHT PKG</label>
                                        <asp:TextBox ID="weight5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="measures4">MEASURES PKG</label>
                                        <asp:TextBox ID="measures4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="stackable4">STACKABLE</label>
                                        <asp:TextBox ID="stackable4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="incoterm2">INCOTERM</label>
                                        <asp:TextBox ID="incoterm2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="urgent">URGENT</label>
                                        <asp:TextBox ID="urgent" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="arrastrebl" class="col-lg-4">

                                        <label class="control-label" for="pol8">POL</label>
                                        <asp:TextBox ID="pol8" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode8" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol8" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry8">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry8" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode8" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry8" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol_zipcode4">POL_ZIPCODE</label>
                                        <asp:TextBox ID="pol_zipcode4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="pod8">POD</label>
                                        <asp:TextBox ID="pod8" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode8" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod8" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry8">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry8" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcountrycode8" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry8" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod_zipcode4">POD_ZIPCODE</label>
                                        <asp:TextBox ID="pod_zipcode4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="veintegp">20'GP</label>
                                        <asp:TextBox ID="veintegp" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="cuarentagp">40'GP</label>
                                        <asp:TextBox ID="cuarentagp" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="cuarentahq2">40'HQ</label>
                                        <asp:TextBox ID="cuarentahq2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="equipment4">EQUIPMENT</label>
                                        <asp:TextBox ID="equipment4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idequipment4" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfequipment4" ClientIDMode="Static" runat="server" />
                                        <label class="control-label" for="mode">MODE</label>
                                        <asp:TextBox ID="mode" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="mode">SINGLE/FULL</label>
                                        <asp:TextBox ID="singlefull" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="un5">UN</label>
                                        <asp:TextBox ID="un5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="class5">CLASS</label>
                                        <asp:TextBox ID="class5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="remarks8">REMARKS</label>
                                        <asp:TextBox ID="remarks8" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity8">COMMODITY</label>
                                        <asp:TextBox ID="commodity8" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency5">CURRENCY</label>
                                        <asp:TextBox ID="currency5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight6">WEIGHT</label>
                                        <asp:TextBox ID="weight6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="tarifarioamericano" class="col-lg-4">

                                        <label class="control-label" for="carrier6">CARRIER</label>
                                        <asp:TextBox ID="carrier6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="origin4">ORIGIN</label>
                                        <asp:TextBox ID="origin4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idorigin4" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hforigin4" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol9">POL</label>
                                        <asp:TextBox ID="pol9" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode9" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol9" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry9">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry9" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode9" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry9" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol_zipcode5">POL_ZIPCODE</label>
                                        <asp:TextBox ID="pol_zipcode5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="destination4">DESTINATION</label>
                                        <asp:TextBox ID="destination4" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="iddestination4" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfdestination4" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod9">POD</label>
                                        <asp:TextBox ID="pod9" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode9" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod9" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry9">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry9" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcountrycode9" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry9" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod_zipcode5">POD_ZIPCODE</label>
                                        <asp:TextBox ID="pod_zipcode5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="equipment5">EQUIPMENT</label>
                                        <asp:TextBox ID="equipment5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idequipment5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfequipment5" ClientIDMode="Static" runat="server" />
                                        <label class="control-label" for="directtranshipment">DIRECT/TRANSHIPMENT</label>
                                        <asp:TextBox ID="directtranshipment" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="un6">UN</label>
                                        <asp:TextBox ID="un6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="class6">CLASS</label>
                                        <asp:TextBox ID="class6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="remarks9">REMARKS</label>
                                        <asp:TextBox ID="remarks9" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency6">CURRENCY</label>
                                        <asp:TextBox ID="currency6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight7">TOTAL WEIGHT</label>
                                        <asp:TextBox ID="weight7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity9">COMMODITY</label>
                                        <asp:TextBox ID="commodity9" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />

                                    </div>

                                    <div id="tarifarioarrastres" class="col-lg-4">

                                        <label class="control-label" for="carrier7">CARRIER</label>
                                        <asp:TextBox ID="carrier7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <br />
                                        <label class="control-label" for="origin5">ORIGIN</label>
                                        <asp:TextBox ID="origin5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idorigin5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hforigin5" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol10">POL</label>
                                        <asp:TextBox ID="pol10" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcode10" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol10" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="polcountry10">POL_COUNTRY</label>
                                        <asp:TextBox ID="polcountry10" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="polcountrycode10" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpolcountry10" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pol_zipcode6">POL_ZIPCODE</label>
                                        <asp:TextBox ID="pol_zipcode6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <label class="control-label" for="destination5">DESTINATION</label>
                                        <asp:TextBox ID="destination5" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="iddestination5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfdestination5" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod10">POD</label>
                                        <asp:TextBox ID="pod10" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcode10" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod10" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="podcountry10">POD_COUNTRY</label>
                                        <asp:TextBox ID="podcountry10" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="podcountrycode10" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpodcountry10" ClientIDMode="Static" runat="server" />
                                        <br />
                                        <label class="control-label" for="pod_zipcode6">POD_ZIPCODE</label>
                                        <asp:TextBox ID="pod_zipcode6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="service">SERVICE</label>
                                        <asp:TextBox ID="service" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="equipment6">EQUIPMENT</label>
                                        <asp:TextBox ID="equipment6" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:TextBox ID="idequipment6" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfequipment6" ClientIDMode="Static" runat="server" />
                                        <label class="control-label" for="remarks10">REMARKS</label>
                                        <asp:TextBox ID="remarks10" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="currency7">CURRENCY</label>
                                        <asp:TextBox ID="currency7" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="volume2">VOLUME</label>
                                        <asp:TextBox ID="volume2" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="commodity10">COMMODITY</label>
                                        <asp:TextBox ID="commodity10" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                        <label class="control-label" for="weight8">TOTAL WEIGHT</label>
                                        <asp:TextBox ID="weight8" ClientIDMode="Static" runat="server" CssClass="form-control"></asp:TextBox><br />
                                    </div>

                                </div>
                            </div>
                            <div class="modal-footer">
                                <!--button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</!--button-->
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="form-group">
                    <label class="control-label col-sm-5 inputsm">Vigencia Del:</label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="TxtFechaDesde" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                        <asp:Calendar ID="CalendarDesde" runat="server"></asp:Calendar>
                    </div>
                    <div class="col-sm-1">
                        <asp:Button ID="BtnFechaDesde" runat="server" Text="" CssClass="Css_Calendario" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5" for="inputsm">Al:</label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="TxtFechaAl" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                        <asp:Calendar ID="CalendarAl" runat="server" Font-Size="11px"></asp:Calendar>
                    </div>
                    <div class="col-sm-1">
                        <asp:Button ID="BtnFechaAl" runat="server" Text="" CssClass="Css_Calendario" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5 inputsm">Sociedad:</label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control input-sm">
                            <asp:ListItem Value="1">Multienlaces</asp:ListItem>
                            <asp:ListItem Value="2">MTI Forwarding</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5 inputsm">Tipo de moneda:</label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="DdlCur" runat="server" CssClass="form-control input-sm">
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5 inputsm">Incoterm: </label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="DdlIncoterm" runat="server" CssClass="form-control input-sm">
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5 inputsm">KIND: </label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="DdlKind" runat="server" CssClass="form-control input-sm">
                            <asp:ListItem Value="RE">REPETITIVE</asp:ListItem>
                            <asp:ListItem Value="OS">ONE SHOT</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5">Service: </label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="DdlServ" runat="server" CssClass="form-control input-sm">
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5 inputsm">Nac / Inte:</label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="LblInterNacion" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5" for="inputsm">Impo / Expo:</label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="LblTipo" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
            </div>
        </div>
    </div>



    <div id="PNLGVSerArr" runat="server" class="Asignar">
        <asp:GridView ID="GVSerArr" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="Id" FooterText="Id" HeaderText="Id">
                    <ItemTemplate>
                        <asp:Label ID="LblId" runat="server" Text='<%# Bind("id_num")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="CARRIER" FooterText="CARRIER" HeaderText="CARRIER">
                    <ItemTemplate>
                        <asp:Label ID="LblCARRIER" runat="server" Text='<%# Bind("CARRIER")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_SIN" FooterText="TOTAL_RATE_SIN" HeaderText="TOTAL_RATE_SIN">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL_RATE_SIN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOTAL_RATE_SIN]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_SIN" FooterText="TOTAL_RATE_SIN" HeaderText="Sencillo">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio1]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio1]"))%>' TextMode="Number" Visible="false" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_TAN" FooterText="TOTAL_RATE_TAN" HeaderText="TOTAL_RATE_TAN">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL_RATE_TAN1" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOTAL_RATE_TAN]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_TAN" FooterText="TOTAL_RATE_TAN" HeaderText="Sensillo-Pistas">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio2]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio2]"))%>' TextMode="Number" Visible="false" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SINGLE" FooterText="SINGLE" HeaderText="SINGLE">
                    <ItemTemplate>
                        <asp:Label ID="LblSINGLE1" runat="server" Text='<%# String.Format("{0:N2}", Eval("[SINGLE]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SINGLE" FooterText="SINGLE" HeaderText="Full">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio3]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio3]"))%>' TextMode="Number" Visible="false" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="REMARKS" FooterText="REMARKS" HeaderText="REMARKS">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtREMARKS" runat="server" Text='<%# Bind("REMARKS")%>'></asp:TextBox>
                        <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("REMARKS")%>' Visible="false"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="ORIGIN" FooterText="ORIGIN" HeaderText="ORIGIN">
                    <ItemTemplate>
                        <asp:Label ID="LblORIGIN" runat="server" Text='<%# Bind("ORIGIN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POL_CODE" FooterText="POL_CODE" HeaderText="POL_CODE">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_CODE" runat="server" Text='<%# Bind("POL_CODE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POL" FooterText="POL" HeaderText="POL">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL" runat="server" Text='<%# Bind("POL")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POL_CODE_COUNTRY" FooterText="POL_CODE_COUNTRY" HeaderText="POL_CODE_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_CODE_COUNTRY" runat="server" Text='<%# Bind("POL_CODE_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POL_ZIPCODE" FooterText="POL_ZIPCODE" HeaderText="POL_ZIPCODE">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_ZIPCODE" runat="server" Text='<%# Bind("POL_ZIPCODE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="DESTINATION" FooterText="DESTINATION" HeaderText="DESTINATION">
                    <ItemTemplate>
                        <asp:Label ID="LblDESTINATION" runat="server" Text='<%# Bind("DESTINATION")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POD_CODE" FooterText="POD_CODE" HeaderText="POD_CODE">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD_CODE" runat="server" Text='<%# Bind("POD_CODE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POD" FooterText="POD" HeaderText="POD">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD" runat="server" Text='<%# Bind("POD")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POD_CODE_COUNTRY" FooterText="POD_CODE_COUNTRY" HeaderText="POD_CODE_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD_CODE_COUNTRY" runat="server" Text='<%# Bind("POD_CODE_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POD_COUNTRY" FooterText="POD_COUNTRY" HeaderText="POD_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD_COUNTRY" runat="server" Text='<%# Bind("POD_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POD_ZIPCODE" FooterText="POD_ZIPCODE" HeaderText="POD_ZIPCODE">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD_ZIPCODE" runat="server" Text='<%# Bind("POD_ZIPCODE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SERVICE" FooterText="SERVICE" HeaderText="SERVICE">
                    <ItemTemplate>
                        <asp:Label ID="LblSERVICE" runat="server" Text='<%# Bind("SERVICE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_TAN" FooterText="TOTAL_RATE_TAN" HeaderText="TOTAL_RATE_TAN">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL_RATE_TAN" runat="server" Text='<%# Bind("TOTAL_RATE_TAN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SINGLE" FooterText="SINGLE" HeaderText="SINGLE">
                    <ItemTemplate>
                        <asp:Label ID="LblSINGLE" runat="server" Text='<%# Bind("SINGLE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TANDEM" FooterText="TANDEM" HeaderText="TANDEM">
                    <ItemTemplate>
                        <asp:Label ID="LblTANDEM" runat="server" Text='<%# Bind("TANDEM")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOLLS_TAN" FooterText="TOLLS_TAN" HeaderText="TOLLS_TAN">
                    <ItemTemplate>
                        <asp:Label ID="LblTOLLS_TAN" runat="server" Text='<%# Bind("TOLLS_TAN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="EQUIPMENT" FooterText="EQUIPMENT" HeaderText="EQUIPMENT">
                    <ItemTemplate>
                        <asp:Label ID="LblEQUIPMENT" runat="server" Text='<%# Bind("EQUIPMENT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VALIDITY_FROM" FooterText="VALIDITY_FROM" HeaderText="VALIDITY_FROM">
                    <ItemTemplate>
                        <asp:Label ID="LblVALIDITY_FROM" runat="server" Text='<%# Bind("VALIDITY_FROM")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VALIDITY_TO" FooterText="VALIDITY_TO" HeaderText="VALIDITY_TO">
                    <ItemTemplate>
                        <asp:Label ID="LblVALIDITY_TO" runat="server" Text='<%# Bind("VALIDITY_TO")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TT" FooterText="TT" HeaderText="TT">
                    <ItemTemplate>
                        <asp:Label ID="LblTT" runat="server" Text='<%# Bind("TT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="WEIGHT_SIN" FooterText="WEIGHT_SIN" HeaderText="WEIGHT_SIN">
                    <ItemTemplate>
                        <asp:Label ID="LblWEIGHT_SIN" runat="server" Text='<%# Bind("WEIGHT_SIN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="WEIGHT_TAN" FooterText="WEIGHT_TAN" HeaderText="WEIGHT_TAN">
                    <ItemTemplate>
                        <asp:Label ID="LblWEIGHT_TAN" runat="server" Text='<%# Bind("WEIGHT_TAN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="FREE_HOURS" FooterText="FREE_HOURS" HeaderText="FREE_HOURS">
                    <ItemTemplate>
                        <asp:Label ID="LblFREE_HOURS" runat="server" Text='<%# Bind("FREE_HOURS")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                    <ItemTemplate>
                        <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VOLUMEN" FooterText="VOLUMEN" HeaderText="VOLUMEN">
                    <ItemTemplate>
                        <asp:Label ID="LblVOLUMEN" runat="server" Text='<%# Bind("VOLUMEN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SUBJECT" FooterText="SUBJECT" HeaderText="SUBJECT">
                    <ItemTemplate>
                        <asp:Label ID="LblSUBJECT" runat="server" Text='<%# Bind("SUBJECT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="NOT_SUBJECT" FooterText="NOT_SUBJECT" HeaderText="NOT_SUBJECT">
                    <ItemTemplate>
                        <asp:Label ID="LblNOT_SUBJECT" runat="server" Text='<%# Bind("NOT_SUBJECT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <HeaderStyle BackColor="#01236A" ForeColor="White" />
            <PagerSettings Mode="NextPreviousFirstLast" />

        </asp:GridView>
    </div>


    <div>
        <h2>
            <asp:Label ID="LblTitulo" runat="server" class="control-label col-sm-12"></asp:Label>
        </h2>
    </div>


    <div id="PNLBTSerArr" runat="server" class="container">
        <div class="row">
            <div class="col-sm-12 form-horizontal">
                <asp:Button ID="BtnAgregarPartida" runat="server" Text="Agregar partida(s)" class="btn btn-default btn-sm Button" />
                <asp:Button ID="BtnEliminarPartida" runat="server" Text="Eliminar partida(s)" class="btn btn-default btn-sm Button" />
                <asp:Button ID="BtnEliminarTodo" runat="server" Text="Eliminar todo" class="btn btn-default btn-sm Button" />
                <button type="button" class="btn btn-default btn-sm Button" data-toggle="modal" data-target="#myModal">Solicitar a pricing</button>
            </div>
        </div>
    </div>
    <br />
    <div id="PNLCotizacion" runat="server" class="container">
        <div class="row">
            <div class="col-sm-12 form-horizontal">
                <asp:Button ID="BtnGuardarCot" runat="server" Text="Guardar cotización" class="btn btn-default btn-sm Button" />
                <asp:Button ID="BtnEnviarCot" runat="server" Text="Enviar cotización" class="btn btn-default btn-sm Button" />
            </div>
        </div>
    </div>

    <div class="container">
        <div class="modal" id="myModal">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">
                            <asp:Label ID="LblAddTitulo" runat="server" Text="Label"></asp:Label>
                        </h4>
                    </div>
                    <div class="modal-body">
                        <div class="container">
                            <div class="row">
                                <div class="col-sm-8">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="control-label col-sm-5" for="inputsm">Service details:</label>
                                            <div class="col-sm-7">
                                                <asp:DropDownList ID="DdlServiceDetails" runat="server" CssClass="form-control inputsm" AutoPostBack="True">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="control-label col-sm-5" for="inputsm">Service:</label>
                                            <div class="col-sm-7">
                                                <asp:DropDownList ID="DdlServicio" runat="server" AutoPostBack="True" CssClass="form-control inputsm" TabIndex="1">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="control-label col-sm-5" for="inputsm">Origin</label>
                                            <div class="col-sm-7">
                                                <asp:TextBox ID="TxtPOL" runat="server" CssClass="form-control inputsm" onkeypress="return AnularEnter(event.keyCode);" TabIndex="2" AutoPostBack="True"></asp:TextBox>
                                                <asp:TextBox ID="TxtCodePOL" runat="server" CssClass="form-control inputsm" Visible="False" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                                                <asp:HiddenField ID="HiddenField2" runat="server" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="control-label col-sm-5" for="inputsm">Destination</label>
                                            <div class="col-sm-7">
                                                <asp:TextBox ID="TxtPOD" runat="server" CssClass="form-control inputsm" onkeypress="return AnularEnter(event.keyCode);" TabIndex="3" AutoPostBack="True"></asp:TextBox>
                                                <asp:TextBox ID="TxtCodePOD" runat="server" CssClass="form-control inputsm" Visible="False" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                                                <asp:HiddenField ID="HiddenField3" runat="server" />
                                            </div>
                                        </div>
                                    </div>




                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="control-label col-sm-5">POL:</label>
                                            <div class="col-sm-7">
                                                <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control" TabIndex="4" AutoPostBack="True"></asp:TextBox>
                                                <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control" Visible="False"></asp:TextBox>
                                                <asp:HiddenField ID="HiddenField1" runat="server" />
                                            </div>

                                        </div>
                                    </div>

                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="control-label col-sm-5">POD:</label>
                                            <div class="col-sm-7">
                                                <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control" TabIndex="5" AutoPostBack="True"></asp:TextBox>
                                                <asp:TextBox ID="TextBox13" runat="server" CssClass="form-control" Visible="False"></asp:TextBox>
                                                <asp:HiddenField ID="HiddenField4" runat="server" />
                                            </div>
                                        </div>
                                    </div>



                                </div>
                            </div>
                        </div>

                        <div class="Asignar">
                            <asp:GridView ID="GvBusArr" runat="server" AutoGenerateColumns="False" class="table table-hover" Font-Size="12px">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="Id" FooterText="Id" HeaderText="Id">
                                        <ItemTemplate>
                                            <asp:Label ID="LblId" runat="server" Text='<%# Bind("id_num")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CARRIER" FooterText="CARRIER" HeaderText="CARRIER">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCARRIER" runat="server" Text='<%# Bind("CARRIER")%>'></asp:Label>
                                        </ItemTemplate>
                                        <ControlStyle CssClass="table-responsive" />
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="ORIGIN" FooterText="ORIGIN" HeaderText="ORIGIN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblORIGIN" runat="server" Text='<%# Bind("ORIGIN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_CODE" FooterText="POL_CODE" HeaderText="POL CODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_CODE" runat="server" Text='<%# Bind("POL_CODE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL" FooterText="POL" HeaderText="POL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL" runat="server" Text='<%# Bind("POL")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_CODE_COUNTRY" FooterText="POL_CODE_COUNTRY" HeaderText="POL CODE COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_CODE_COUNTRY" runat="server" Text='<%# Bind("POL_CODE_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_ZIPCODE" FooterText="POL_ZIPCODE" HeaderText="POL ZIPCODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_ZIPCODE" runat="server" Text='<%# Bind("POL_ZIPCODE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="DESTINATION" FooterText="DESTINATION" HeaderText="DESTINATION">
                                        <ItemTemplate>
                                            <asp:Label ID="LblDESTINATION" runat="server" Text='<%# Bind("DESTINATION")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD_CODE" FooterText="POD_CODE" HeaderText="POD CODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_CODE" runat="server" Text='<%# Bind("POD_CODE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD" FooterText="POD" HeaderText="POD">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD" runat="server" Text='<%# Bind("POD")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD_CODE_COUNTRY" FooterText="POD_CODE_COUNTRY" HeaderText="POD CODE COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_CODE_COUNTRY" runat="server" Text='<%# Bind("POD_CODE_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD_COUNTRY" FooterText="POD_COUNTRY" HeaderText="POD COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_COUNTRY" runat="server" Text='<%# Bind("POD_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POD_ZIPCODE" FooterText="POD_ZIPCODE" HeaderText="POD ZIPCODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_ZIPCODE" runat="server" Text='<%# Bind("POD_ZIPCODE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="SERVICE" FooterText="SERVICE" HeaderText="SERVICE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSERVICE" runat="server" Text='<%# Bind("SERVICE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_SIN" FooterText="TOTAL_RATE_SIN" HeaderText="TOTAL_RATE_SIN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOTAL_RATE_SIN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOTAL_RATE_SIN]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_TAN" FooterText="TOTAL_RATE_TAN" HeaderText="TOTAL_RATE_TAN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOTAL_RATE_TAN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOTAL_RATE_TAN]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="SINGLE" FooterText="SINGLE" HeaderText="SINGLE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSINGLE" runat="server" Text='<%# String.Format("{0:N2}", Eval("[SINGLE]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOLLS_SIN" FooterText="TOLLS_SIN" HeaderText="TOLLS_SIN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOLLS_SIN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOLLS_SIN]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TANDEM" FooterText="TANDEM" HeaderText="TANDEM">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTANDEM" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TANDEM]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOLLS_TAN" FooterText="TOLLS_TAN" HeaderText="TOLLS_TAN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOLLS_TAN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOLLS_TAN]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="EQUIPMENT" FooterText="EQUIPMENT" HeaderText="EQUIPMENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblEQUIPMENT" runat="server" Text='<%# Bind("EQUIPMENT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VALIDITY_FROM" FooterText="VALIDITY_FROM" HeaderText="VALIDITY_FROM">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVALIDITY_FROM" runat="server" Text='<%# String.Format("{0:d}", Eval("[VALIDITY_FROM]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VALIDITY_TO" FooterText="VALIDITY_TO" HeaderText="VALIDITY_TO">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVALIDITY_TO" runat="server" Text='<%# String.Format("{0:d}", Eval("[VALIDITY_TO]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TT" FooterText="TT" HeaderText="TT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTT" runat="server" Text='<%# Bind("TT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="WEIGHT_SIN" FooterText="WEIGHT_SIN" HeaderText="WEIGHT_SIN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblWEIGHT_SIN" runat="server" Text='<%# Bind("WEIGHT_SIN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="WEIGHT_TAN" FooterText="WEIGHT_TAN" HeaderText="WEIGHT_TAN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblWEIGHT_TAN" runat="server" Text='<%# Bind("WEIGHT_TAN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FREE_HOURS" FooterText="FREE_HOURS" HeaderText="FREE_HOURS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREE_HOURS" runat="server" Text='<%# Bind("FREE_HOURS")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VOLUMEN" FooterText="VOLUMEN" HeaderText="VOLUMEN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVOLUMEN" runat="server" Text='<%# Bind("VOLUMEN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="SUBJECT" FooterText="SUBJECT" HeaderText="SUBJECT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSUBJECT" runat="server" Text='<%# Bind("SUBJECT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="NOT_SUBJECT" FooterText="NOT_SUBJECT" HeaderText="NOT_SUBJECT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNOT_SUBJECT" runat="server" Text='<%# Bind("NOT_SUBJECT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="REMARKS" FooterText="REMARKS" HeaderText="REMARKS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("REMARKS")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <HeaderStyle BackColor="#01236A" Font-Size="9pt" ForeColor="White" />
                                <PagerSettings Mode="NextPreviousFirstLast" />

                            </asp:GridView>
                        </div>

                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="Button1" runat="server" Text="Agregar partida" CssClass="btn btn-default" />
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $('div.Asignar').children('div').addClass('table-responsive');
        });
    </script>

    <asp:Panel ID="PnlControl" runat="server">
        <a>Panel de variables de control esto va a desaparecer</a>
        <br />
        <a>Tipo de cotizacion: </a>
        <asp:Label ID="LblVTipo" runat="server"></asp:Label>
        <br />
        <a>Agrega Servicio: </a>
        <asp:Label ID="LblAddSer" runat="server"></asp:Label>
        <br />
        <a>Tipo de Cargo: </a>
        <asp:Label ID="LblCargoT" runat="server" Text="Label"></asp:Label>
        <br />
        <a>Id Maritimo</a>
        <asp:Label ID="LblIdMatitimo" runat="server"></asp:Label>
        <br />
        <a>Id Aereo</a>
        <asp:Label ID="LblIdAereo" runat="server"></asp:Label>
        <br />
        <a>Id Arrastre</a>
        <asp:Label ID="LblIdArrastre" runat="server"></asp:Label>
        <br />
        <a>Id Arrastre con BL</a>
        <asp:Label ID="LblIdArrastreBL" runat="server"></asp:Label>
        <br />
        <a>Id Terrestre</a>
        <asp:Label ID="LblIdTerrestre" runat="server"></asp:Label>
        <br />
        <a>Finalizar Coti</a>
        <asp:Label ID="LblFin" runat="server"></asp:Label>
        <br />
        <a>Autorizacion</a>
        <asp:Label ID="LblAuto" runat="server"></asp:Label>
        <br />
        <a>Cambios</a>
        <asp:Label ID="LblCambios" runat="server"></asp:Label>
        <br />
        <a>Correo</a>
        <asp:Label ID="LblCorreo" runat="server"></asp:Label>
    </asp:Panel>

    <script type="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }

        function openModal2() {
            $('#myModal2').modal('show');
        }
    </script>



</asp:Content>


