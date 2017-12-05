<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/BXP_MasterPage/BXP_MasterPage.Master" CodeBehind="BXP_Cotizacion.aspx.vb" Inherits="BXP_Crossmotion.BXP_Cotizacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Bootstrap/bootstrap.css" rel="stylesheet" />
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.0.min.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" />

    <script src="BXP_JS/BXP_JS_COT.js"></script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TxtEmpresa]").autocomplete({
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
                    $("[id$=HFEmpresa]").val(i.item.val);
                },
                minLength: 1
            });
        });
    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TxtPOL_Country]").autocomplete({
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
            $("[id$=polcountry10]").autocomplete({
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
                    $("[id$=hfpolcountry10]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>


    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry10]").autocomplete({
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
                    $("[id$=hfpolcountry10]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

        <script type="text/javascript">
            $(function () {
                $("[id$=podcountry10]").autocomplete({
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
                        $("[id$=hfpodcountry10]").val(i.item.val);
                    },
                    minLength: 1
                });
            });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=TxtPOD_Country]").autocomplete({
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
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po4")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('TxtCodePOL_Country').value + "', 'tipobusqueda': '" + document.getElementById('DdlTipoCotizacion').value + "'}",
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
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po4")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('TxtCodePOD_Country').value + "', 'tipobusqueda': '" + document.getElementById('DdlTipoCotizacion').value + "'}",
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
        $(function () {
            $("[id$=pol10]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode10').value + "'}",
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
        $(function () {
            $("[id$=pod10]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcountrycode10').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pol7]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po3")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode7').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(document).ready(function () {
            $(function () {
                $("[id$=pod7]").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po3")%>',
                            data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcountrycode7').value + "'}",
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
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pol1]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "','paisbusqueda': ''}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod1]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "','paisbusqueda': ''}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pol2]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode1').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod2]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcodecountry1').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pol3]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode3').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod3]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcodecountry2').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pol4]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode4').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod4]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcountrycode4').value + "'}",
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

    </script>
    
    <script type="text/javascript">
        $(function () {
            $("[id$=pol5]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode5').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod5]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcountrycode5').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pol8]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode8').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod8]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcountrycode8').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pol9]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('polcountrycode9').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=pod9]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/BXP_Cotizacion.aspx/Po2")%>',
                        data: "{ 'prefix': '" + request.term + "', 'paisbusqueda': '" + document.getElementById('podcountrycode9').value + "'}",
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

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry9]").autocomplete({
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
                    $("[id$=hfpolcountry9]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=podcountry9]").autocomplete({
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
                    $("[id$=hfpodcountry9]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry5]").autocomplete({
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
                    $("[id$=hfpolcountry5]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=podcountry8]").autocomplete({
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
                    $("[id$=hfpodcountry8]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry8]").autocomplete({
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
                    $("[id$=hfpolcountry8]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=podcountry5]").autocomplete({
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
                    $("[id$=hfpodcountry5]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry5]").autocomplete({
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
                    $("[id$=hfpolcountry5]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=podcountry4]").autocomplete({
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
                    $("[id$=hfpodcountry4]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry4]").autocomplete({
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
                    $("[id$=hfpolcountry4]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=podcountry7]").autocomplete({
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
                    $("[id$=hfpodcountry7]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry7]").autocomplete({
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
                    $("[id$=hfpolcountry7]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry1").autocomplete({
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
                    $("[id$=hfpolcountry1]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=podcountry1").autocomplete({
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
                    $("[id$=hfpodcountry1]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=polcountry3").autocomplete({
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
                    $("[id$=hfpolcountry3]").val(i.item.val);
                },
                minLength: 1
            });
        });

    </script>

    <script type="text/javascript">
        $(function () {
            $("[id$=podcountry2").autocomplete({
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
                    $("[id$=hfpodcountry2]").val(i.item.val);
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
        function validarServicio() {
            var valor = $("#DdlTipoCotizacion").val();

            var error = "Falta agregar datos: ";
            var contador = 0;

            if (valor == "FCL") {

                if ($("input[id$=carrier1]").val() == "") {
                    contador = contador + 1;
                    error += "'CARRIER' ";
                }
                if ($("input[id$=pol1]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=pod1]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=equipment]").val() == "") {
                    contador = contador + 1;
                    error += "'EQUIPMENT' ";
                }
                if ($("input[id$=commodity1]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }
            }
            else if (valor == "LTL") {

                if ($("input[id$=carrier2]").val() == "") {
                    contador = contador + 1;
                    error += "'CARRIER' ";
                }
                if ($("input[id$=origin1]").val() == "") {
                    contador = contador + 1;
                    error += "'ORIGIN' ";
                }
                if ($("input[id$=pol2]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry1]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=destination1]").val() == "") {
                    contador = contador + 1;
                    error += "'DESTINATION' ";
                }
                if ($("input[id$=pod2]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry1]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=type]").val() == "") {
                    contador = contador + 1;
                    error += "'TYPE' ";
                }
                if ($("input[id$=commodity2]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }
                if ($("input[id$=quantity]").val() == "") {
                    contador = contador + 1;
                    error += "'QUANTITY' ";
                }
                if ($("input[id$=stops]").val() == "") {
                    contador = contador + 1;
                    error += "'STOPS' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }

            }
            else if (valor == "INTERMODAL") {

                if ($("input[id$=carrier3]").val() == "") {
                    contador = contador + 1;
                    error += "'CARRIER' ";
                }
                if ($("input[id$=origin2]").val() == "") {
                    contador = contador + 1;
                    error += "'ORIGIN' ";
                }
                if ($("input[id$=originramp]").val() == "") {
                    contador = contador + 1;
                    error += "'ORIGIN RAMP' ";
                }
                if ($("input[id$=pol3]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry3]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=destination2]").val() == "") {
                    contador = contador + 1;
                    error += "'DESTINATION' ";
                }
                if ($("input[id$=destinationramp]").val() == "") {
                    contador = contador + 1;
                    error += "'DESTINATION RAMP' ";
                }
                if ($("input[id$=pod3]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry2]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=currency1]").val() == "") {
                    contador = contador + 1;
                    error += "'CURRENCY' ";
                }
                if ($("input[id$=equipment1]").val() == "") {
                    contador = contador + 1;
                    error += "'EQUIPMENT' ";
                }
                if ($("input[id$=commodity3]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }

            }
            else if (valor == "LCL") {

                if ($("input[id$=pol4]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry4]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=pod4]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry4]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=currency2]").val() == "") {
                    contador = contador + 1;
                    error += "'CURRENCY' ";
                }
                if ($("input[id$=cost]").val() == "") {
                    contador = contador + 1;
                    error += "'COST' ";
                }
                if ($("input[id$=minimumcost]").val() == "") {
                    contador = contador + 1;
                    error += "'MINIMUM COST' ";
                }
                if ($("input[id$=equipment2]").val() == "") {
                    contador = contador + 1;
                    error += "'EQUIPMENT' ";
                }
                if ($("input[id$=commodity4]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }
            }
            else if (valor == "TLM") {

                if ($("input[id$=carrier4]").val() == "") {
                    contador = contador + 1;
                    error += "'CARRIER' ";
                }
                if ($("input[id$=origin3]").val() == "") {
                    contador = contador + 1;
                    error += "'ORIGIN' ";
                }
                if ($("input[id$=pol5]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry5]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=destination3]").val() == "") {
                    contador = contador + 1;
                    error += "'DESTINATION' ";
                }
                if ($("input[id$=pod5]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry5]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=equipment3]").val() == "") {
                    contador = contador + 1;
                    error += "'EQUIPMENT' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }

            }
            else if (valor == "AIR") {
                if ($("input[id$=pol7]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry7]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=pod7]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry7]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=commodity7]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }

            }
            else if (valor == "CC") {

                if ($("input[id$=pol8]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry8]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=pod8]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry8]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=veintegp]").val() == "") {
                    contador = contador + 1;
                    error += "'20'GP' ";
                }
                if ($("input[id$=cuarentagp]").val() == "") {
                    contador = contador + 1;
                    error += "'40'GP' ";
                }
                if ($("input[id$=cuarentahq2]").val() == "") {
                    contador = contador + 1;
                    error += "'40'HQ' ";
                }
                if ($("input[id$=equipment4]").val() == "") {
                    contador = contador + 1;
                    error += "'EQUIPMENT' ";
                }
                if ($("input[id$=commodity8]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }
                if ($("input[id$=currency5]").val() == "") {
                    contador = contador + 1;
                    error += "'CURRENCY' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }

            }
            else if (valor == "TLU") {

                if ($("input[id$=carrier6]").val() == "") {
                    contador = contador + 1;
                    error += "'CARRIER' ";
                }
                if ($("input[id$=origin4]").val() == "") {
                    contador = contador + 1;
                    error += "'ORIGIN' ";
                }
                if ($("input[id$=pol9]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry9]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=pol_zipcode5]").val() == "") {
                    contador = contador + 1;
                    error += "'POL ZIPCODE' ";
                }
                if ($("input[id$=destination4]").val() == "") {
                    contador = contador + 1;
                    error += "'DESTINATION' ";
                }
                if ($("input[id$=pod9]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry9]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=equipment5]").val() == "") {
                    contador = contador + 1;
                    error += "'EQUIPMENT' ";
                }
                if ($("input[id$=currency6]").val() == "") {
                    contador = contador + 1;
                    error += "'CURRENCY' ";
                }
                if ($("input[id$=commodity9]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }
            }
            else if (valor == "CH") {

                if ($("input[id$=carrier7]").val() == "") {
                    contador = contador + 1;
                    error += "'CARRIER' ";
                }
                if ($("input[id$=origin5]").val() == "") {
                    contador = contador + 1;
                    error += "'ORIGIN' ";
                }
                if ($("input[id$=pol10]").val() == "") {
                    contador = contador + 1;
                    error += "'POL' ";
                }
                if ($("input[id$=polcountry10]").val() == "") {
                    contador = contador + 1;
                    error += "'POL COUNTRY' ";
                }
                if ($("input[id$=destination5]").val() == "") {
                    contador = contador + 1;
                    error += "'DESTINATION' ";
                }
                if ($("input[id$=pod10]").val() == "") {
                    contador = contador + 1;
                    error += "'POD' ";
                }
                if ($("input[id$=podcountry10]").val() == "") {
                    contador = contador + 1;
                    error += "'POD COUNTRY' ";
                }
                if ($("input[id$=service]").val() == "") {
                    contador = contador + 1;
                    error += "'SERVICE' ";
                }
                if ($("input[id$=equipment6]").val() == "") {
                    contador = contador + 1;
                    error += "'EQUIPMENT' ";
                }
                if ($("input[id$=currency7]").val() == "") {
                    contador = contador + 1;
                    error += "'CURRENCY' ";
                }
                if ($("input[id$=commodity10]").val() == "") {
                    contador = contador + 1;
                    error += "'COMMODITY' ";
                }

                if (contador > 0) {
                    alert(error);
                    return false;
                }
                else {
                    return true;
                }
            }
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div>
            <div class="col-md-8">
                <div class="form-group">
                    <label class="control-label col-md-3 inputsm">Número Cotización:</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TxtFolio" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 inputsm">Empresa:</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TxtEmpresa" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                        <asp:TextBox ID="TxtEmpresaCodigo" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                        <asp:HiddenField ID="HFEmpresa" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 inputsm">Contacto:</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TxtContacto" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 inputsm" for="comment">Descripción:</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control input-sm" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 inputsm">Producto:</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TxtProducto" runat="server" CssClass="form-control input-sm" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 inputsm">Tipo de Cotización:</label>
                    <div class="col-md-9">
                        <asp:DropDownList ID="DdlTipoCotizacion" runat="server" CssClass="form-control input-sm" AutoPostBack="True" ClientIDMode="Static"></asp:DropDownList>
                    </div>
                </div>
                
            <div class="col-md-12">
                <div ID="DivAlertSuccess" runat="server" class="alert alert-success alert-dismissable">
                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                    <strong>Success!</strong> 
                    <asp:Label ID="LblSuccess" runat="server" ></asp:Label>
                </div>
                <div ID="DivAlertInfo" runat="server" class="alert alert-info alert-dismissable">
                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                    <strong>Info!</strong>
                    <asp:Label ID="LblInfo" runat="server" ></asp:Label>
                </div>
                <div ID="DivAlertWarning" runat="server" class="alert alert-danger alert-dismissable">
                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                    <strong>Warning!</strong>
                    <asp:Label ID="LblWarning" runat="server" ></asp:Label>
                </div>
            </div>

                
            </div>


            <div class="col-md-4">
                <div class="form-group">
                    <label class="control-label col-md-5 inputsm">Vigencia Del:</label>
                    <div class="col-md-5">
                        <asp:TextBox ID="TxtFechaDesde" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                        <asp:Calendar ID="CalendarDesde" runat="server" Font-Size="11px"></asp:Calendar>
                    </div>
                    <div class="col-md-1">
                        <asp:Button ID="BtnFechaDesde" runat="server" Text="" CssClass="Css_Calendario" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5" for="inputsm">Al:</label>
                    <div class="col-md-5">
                        <asp:TextBox ID="TxtFechaAl" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                        <asp:Calendar ID="CalendarAl" runat="server" Font-Size="11px"></asp:Calendar>
                    </div>
                    <div class="col-md-1">
                        <asp:Button ID="BtnFechaAl" runat="server" Text="" CssClass="Css_Calendario" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5 inputsm">Sociedad:</label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control input-sm">
                            <asp:ListItem Value="1">Multienlaces</asp:ListItem>
                            <asp:ListItem Value="2">MTI Forwarding</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5 inputsm">Moneda:</label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="DdlCur" runat="server" CssClass="form-control input-sm">
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5 inputsm">Incoterm: </label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="DdlIncoterm" runat="server" CssClass="form-control input-sm">
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5 inputsm">KIND: </label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="DdlKind" runat="server" CssClass="form-control input-sm">
                            <asp:ListItem Value="OS">ONE SHOT</asp:ListItem>
                            <asp:ListItem Value="RE">REPETITIVE</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5">Service: </label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="DdlServ" runat="server" CssClass="form-control input-sm">
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5 inputsm">Nac / Inte:</label>
                    <div class="col-md-5">
                        <asp:TextBox ID="LblInterNacion" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-5" for="inputsm">Impo / Expo:</label>
                    <div class="col-md-5">
                        <asp:TextBox ID="LblTipo" runat="server" CssClass="form-control input-sm" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div>
        <h2>
            <asp:Label ID="LblTitulo" runat="server" class="control-label col-sm-12"></asp:Label>
        </h2>
    </div>

    <div id="PNLGVSerAer" runat="server" class="Asignar">
        <asp:GridView ID="GVSerAer" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                    <ItemTemplate>
                        <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="AEROLINEA" FooterText="AEROLINEA" HeaderText="AEROLINEA">
                    <ItemTemplate>
                        <asp:Label ID="LblAEROLINEA" runat="server" Text='<%# Bind("AEROLINEA")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="Peso" FooterText="Peso" HeaderText="Peso">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtPeso" runat="server" AutoPostBack="True" OnTextChanged="TxtPeso_TextChanged" onkeydown="return ( event.ctrlKey || event.altKey || (47<event.keyCode && event.keyCode<58 && event.shiftKey==false) || (95<event.keyCode && event.keyCode<106) || (event.keyCode==8) || (event.keyCode==9)  || (event.keyCode>34 && event.keyCode<40) || (event.keyCode==46) )"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="Precio" FooterText="Precio" HeaderText="Precio">
                    <ItemTemplate>

                        <asp:TextBox ID="TxtPrecio" Text='<%# String.Format("{0:N2}", Eval("[Precio]"))%>' runat="server" onkeydown="return ( event.ctrlKey || event.altKey || (47<event.keyCode && event.keyCode<58 && event.shiftKey==false) || (95<event.keyCode && event.keyCode<106) || (event.keyCode==8) || (event.keyCode==9)  || (event.keyCode>34 && event.keyCode<40) || (event.keyCode==46) )"></asp:TextBox>
                        <asp:TextBox ID="TxtPrecioSuge" Text='<%# String.Format("{0:N2}", Eval("[Precio]"))%>' runat="server" onkeydown="return ( event.ctrlKey || event.altKey || (47<event.keyCode && event.keyCode<58 && event.shiftKey==false) || (95<event.keyCode && event.keyCode<106) || (event.keyCode==8) || (event.keyCode==9)  || (event.keyCode>34 && event.keyCode<40) || (event.keyCode==46) )" Visible="false"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MIN" FooterText="MIN" HeaderText="MIN">
                    <ItemTemplate>
                        <asp:Label ID="LblMIN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MIN]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MEN45KG" FooterText="MEN45KG" HeaderText="MEN45KG">
                    <ItemTemplate>
                        <asp:Label ID="LblMEN45KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MEN45KG]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MAY45KG" FooterText="MAY45KG" HeaderText="MAY45KG">
                    <ItemTemplate>
                        <asp:Label ID="LblMAY45KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY45KG]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MAY100KG" FooterText="MAY100KG" HeaderText="MAY100KG">
                    <ItemTemplate>
                        <asp:Label ID="LblMAY100KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY100KG]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MAY300KG" FooterText="MAY300KG" HeaderText="MAY300KG">
                    <ItemTemplate>
                        <asp:Label ID="LblMAY300KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY300KG]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MAY500KG" FooterText="MAY500KG" HeaderText="MAY500KG">
                    <ItemTemplate>

                        <asp:Label ID="LblMAY500KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY500KG]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MAY1000KG" FooterText="MAY1000KG" HeaderText="MAY1000KG">
                    <ItemTemplate>
                        <asp:Label ID="LblMAY1000KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY1000KG]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="REMARKS" FooterText="REMARKS" HeaderText="REMARKS">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtREMARKS" runat="server" Text='<%# Bind("REMARKS")%>'></asp:TextBox>
                        <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("REMARKS")%>' Visible="false"></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="POL_CODE_COUNTRY" FooterText="POL_CODE_COUNTRY" HeaderText="POL CODE COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_CODE_COUNTRY" runat="server" Text='<%# Bind("POL_CODE_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="POD_COUNTRY" FooterText="POD_COUNTRY" HeaderText="POD_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD_COUNTRY" runat="server" Text='<%# Bind("POD_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA1" FooterText="VIA1" HeaderText="VIA1">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA1" runat="server" Text='<%# Bind("VIA1")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA2" FooterText="VIA2" HeaderText="VIA2">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA2" runat="server" Text='<%# Bind("VIA2")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA3" FooterText="VIA3" HeaderText="VIA3">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA3" runat="server" Text='<%# Bind("VIA3")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA4" FooterText="VIA4" HeaderText="VIA4">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA4" runat="server" Text='<%# Bind("VIA4")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA5" FooterText="VIA5" HeaderText="VIA5">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA5" runat="server" Text='<%# Bind("VIA5")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="FSCKG" FooterText="FSCKG" HeaderText="FSCKG">
                    <ItemTemplate>
                        <asp:Label ID="LblFSCKG" runat="server" Text='<%# Bind("FSCKG")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SSCKG" FooterText="SSCKG" HeaderText="SSCKG">
                    <ItemTemplate>
                        <asp:Label ID="LblSSCKG" runat="server" Text='<%# Bind("SSCKG")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TAX" FooterText="TAX" HeaderText="TAX">
                    <ItemTemplate>
                        <asp:Label ID="LblTAX" runat="server" Text='<%# Bind("TAX")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="HAWB" FooterText="HAWB" HeaderText="HAWB">
                    <ItemTemplate>
                        <asp:Label ID="LblHAWB" runat="server" Text='<%# Bind("HAWB")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="HANDLING" FooterText="HANDLING" HeaderText="HANDLING">
                    <ItemTemplate>
                        <asp:Label ID="LblHANDLING" runat="server" Text='<%# Bind("HANDLING")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="ROUNTING" FooterText="ROUNTING" HeaderText="ROUNTING">
                    <ItemTemplate>
                        <asp:Label ID="LblROUNTING" runat="server" Text='<%# Bind("ROUNTING")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="FREQUENCY" FooterText="FREQUENCY" HeaderText="FREQUENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblFREQUENCY" runat="server" Text='<%# Bind("FREQUENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="AIRCRAFT" FooterText="AIRCRAFT" HeaderText="AIRCRAFT">
                    <ItemTemplate>
                        <asp:Label ID="LblAIRCRAFT" runat="server" Text='<%# Bind("AIRCRAFT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MAXDimXPZA" FooterText="MAXDimXPZA" HeaderText="MAXDimXPZA">
                    <ItemTemplate>
                        <asp:Label ID="LblMAXDimXPZA" runat="server" Text='<%# Bind("MAXDimXPZA")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MAXWeigthXPZA" FooterText="MAXWeigthXPZA" HeaderText="MAXWeigthXPZA">
                    <ItemTemplate>
                        <asp:Label ID="LblMAXWeigthXPZA" runat="server" Text='<%# Bind("MAXWeigthXPZA")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                    <ItemTemplate>
                        <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                    <ItemTemplate>
                        <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="COMMITMENT_VOL" FooterText="COMMITMENT_VOL" HeaderText="COMMITMENT VOL">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMITMENT_VOL" runat="server" Text='<%# Bind("COMMITMENT_VOL")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_SIN" FooterText="TOTAL_RATE_SIN" HeaderText="TOTAL RATE SIN">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL_RATE_SIN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOTAL_RATE_SIN]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_SIN" FooterText="TOTAL_RATE_SIN" HeaderText="Sencillo">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio1]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);" CssClass="form-control"></asp:TextBox>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio1]"))%>' TextMode="Number" Visible="false" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_TAN" FooterText="TOTAL_RATE_TAN" HeaderText="TOTAL RATE TAN">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL_RATE_TAN1" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOTAL_RATE_TAN]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_RATE_TAN" FooterText="TOTAL_RATE_TAN" HeaderText="Sensillo Pistas">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio2]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);" CssClass="form-control"></asp:TextBox>
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
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio3]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);" CssClass="form-control"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio3]"))%>' TextMode="Number" Visible="false" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="REMARKS" FooterText="REMARKS" HeaderText="REMARKS">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtREMARKS" runat="server" Text='<%# Bind("REMARKS")%>' CssClass="form-control" Width="100%"></asp:TextBox>
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
    <div id="PNLGVSerMar" runat="server" class="Asignar">
        <asp:GridView ID="GVSerMar" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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

                <asp:TemplateField AccessibleHeaderText="POL" FooterText="POL" HeaderText="POL">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL" runat="server" Text='<%# Bind("POL")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POD" FooterText="POD" HeaderText="POD">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD" runat="server" Text='<%# Bind("POD")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                    <ItemTemplate>
                        <asp:Label ID="Lbl20GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[20GP]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtPrecio" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio1]"))%>' onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                        <asp:TextBox ID="TxtPrecioSug" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio1]"))%>' onkeypress="return AnularEnter(event.keyCode);" Visible="false"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                    <ItemTemplate>
                        <asp:Label ID="Lbl40GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40GP]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtPrecio2" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio2]"))%>' onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                        <asp:TextBox ID="TxtPrecio2Sug" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio2]"))%>' onkeypress="return AnularEnter(event.keyCode);" Visible="false"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                    <ItemTemplate>
                        <asp:Label ID="Lbl40HQ" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40HQ]"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtPrecio3" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio3]"))%>' onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                        <asp:TextBox ID="TxtPrecio3Sug" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio3]"))%>' onkeypress="return AnularEnter(event.keyCode);" Visible="false"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="REMARKS" FooterText="REMARKS" HeaderText="REMARKS">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtREMARKS" runat="server" Text='<%# Bind("REMARKS")%>'></asp:TextBox>
                        <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("REMARKS")%>' Visible="True"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                    <ItemTemplate>
                        <asp:TextBox ID="LblFREE_DAYS" runat="server" Text='<%# Bind("FREE_DAYS")%>' onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>

                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField AccessibleHeaderText="TT" FooterText="TT" HeaderText="TT">
                    <ItemTemplate>
                        <asp:Label ID="LblTT" runat="server" Text='<%# Bind("TT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="CARRIER" FooterText="CARRIER" HeaderText="CARRIER">
                    <ItemTemplate>
                        <asp:Label ID="LblCARRIER" runat="server" Text='<%# Bind("CARRIER")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                    <ItemTemplate>
                        <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField AccessibleHeaderText="POL_CODE" FooterText="POL_CODE" HeaderText="POL CODE">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_CODE" runat="server" Text='<%# Bind("POL_CODE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="POL_CODE_COUNTRY" FooterText="POL_CODE_COUNTRY" HeaderText="POL CODE COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_CODE_COUNTRY" runat="server" Text='<%# Bind("POL_CODE_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="POD_CODE" FooterText="POD_CODE" HeaderText="POD_CODE">
                    <ItemTemplate>
                        <asp:Label ID="LblPOD_CODE" runat="server" Text='<%# Bind("POD_CODE")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="VIA1" FooterText="VIA1" HeaderText="VIA1">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA1" runat="server" Text='<%# Bind("VIA1")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA2" FooterText="VIA2" HeaderText="VIA2">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA2" runat="server" Text='<%# Bind("VIA2")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA3" FooterText="VIA3" HeaderText="VIA3">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA3" runat="server" Text='<%# Bind("VIA3")%>'></asp:Label>
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


                <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                    <ItemTemplate>
                        <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="UN" FooterText="UN" HeaderText="UN">
                    <ItemTemplate>
                        <asp:Label ID="LblUN" runat="server" Text='<%# Bind("UN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="IMO_SUB" FooterText="IMO_SUB" HeaderText="IMO_SUB">
                    <ItemTemplate>
                        <asp:Label ID="LblIMO_SUB" runat="server" Text='<%# Bind("IMO_SUB")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                    <ItemTemplate>
                        <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="COMMITMENT_TES" FooterText="COMMITMENT_TES" HeaderText="COMMITMENT_TES">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMITMENT_TES" runat="server" Text='<%# Bind("COMMITMENT_TES")%>'></asp:Label>
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
    <div id="PNLGVSerArB" runat="server" class="Asignar">
        <asp:GridView ID="GVSerArB" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                    <ItemTemplate>
                        <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                    <ItemTemplate>
                        <asp:Label ID="Lbl20GP" runat="server" Text='<%# Bind("[20GP]")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio1]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                    <ItemTemplate>
                        <asp:Label ID="Lbl40GP" runat="server" Text='<%# Bind("[40GP]")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio2]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                    <ItemTemplate>
                        <asp:Label ID="Lbl40HQ" runat="server" Text='<%# Bind("[40HQ]")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio3]"))%>' TextMode="Number" onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="REMARKS" FooterText="REMARKS" HeaderText="REMARKS">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtREMARKS" runat="server" Text='<%# Bind("REMARKS")%>'></asp:TextBox>
                        <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("REMARKS")%>' Visible="false"></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                    <ItemTemplate>
                        <asp:Label ID="Lbl20GP1" runat="server" Text='<%# Bind("[20GP]")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                    <ItemTemplate>
                        <asp:Label ID="Lbl40GP1" runat="server" Text='<%# Bind("[40GP]")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                    <ItemTemplate>
                        <asp:Label ID="Lbl40HQ1" runat="server" Text='<%# Bind("[40HQ]")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="EQUIPMENT" FooterText="EQUIPMENT" HeaderText="EQUIPMENT">
                    <ItemTemplate>
                        <asp:Label ID="LblEQUIPMENT" runat="server" Text='<%# Bind("EQUIPMENT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MODE" FooterText="MODE" HeaderText="MODE">
                    <ItemTemplate>
                        <asp:Label ID="LblMODE" runat="server" Text='<%# Bind("MODE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SINGLE" FooterText="SINGLE" HeaderText="SINGLE">
                    <ItemTemplate>
                        <asp:Label ID="LblSINGLE" runat="server" Text='<%# Bind("SINGLE")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                    <ItemTemplate>
                        <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="UN" FooterText="UN" HeaderText="UN">
                    <ItemTemplate>
                        <asp:Label ID="LblUN" runat="server" Text='<%# Bind("UN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                    <ItemTemplate>
                        <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
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
    <div id="PNLGVSerMarLCL" runat="server" class="Asignar">
        <asp:GridView ID="GVSerMarLCL" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                <asp:TemplateField AccessibleHeaderText="CO_LOADER" FooterText="CO_LOADER" HeaderText="CO_LOADER">
                    <ItemTemplate>
                        <asp:Label ID="LblCO_LOADER" runat="server" Text='<%# Bind("CO_LOADER")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                    <ItemTemplate>
                        <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                    <ItemTemplate>
                        <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="VIA1" FooterText="VIA1" HeaderText="VIA1">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA1" runat="server" Text='<%# Bind("VIA1")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA2" FooterText="VIA2" HeaderText="VIA2">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA2" runat="server" Text='<%# Bind("VIA2")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="VIA3" FooterText="VIA3" HeaderText="VIA3">
                    <ItemTemplate>
                        <asp:Label ID="LblVIA3" runat="server" Text='<%# Bind("VIA3")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="COST" FooterText="COST" HeaderText="COST">
                    <ItemTemplate>
                        <asp:Label ID="LblCOST" runat="server" Text='<%# Bind("COST")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="MIN_COST" FooterText="MIN_COST" HeaderText="MIN_COST">
                    <ItemTemplate>
                        <asp:Label ID="LblMIN_COST" runat="server" Text='<%# Bind("MIN_COST")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="FREQUENCY" FooterText="FREQUENCY" HeaderText="FREQUENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblFREQUENCY" runat="server" Text='<%# Bind("FREQUENCY")%>'></asp:Label>
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

                <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                    <ItemTemplate>
                        <asp:TextBox ID="LblFREE_DAYS" runat="server" Text='<%# Bind("FREE_DAYS")%>' onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>

                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                    <ItemTemplate>
                        <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                    <ItemTemplate>
                        <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>



                <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>





                <asp:TemplateField AccessibleHeaderText="ADDMON_FEE" FooterText="ADDMON_FEE" HeaderText="ADDMON_FEE">
                    <ItemTemplate>
                        <asp:Label ID="LblADDMON_FEE" runat="server" Text='<%# Bind("ADDMON_FEE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="BL" FooterText="BL" HeaderText="BL">
                    <ItemTemplate>
                        <asp:Label ID="LblBL" runat="server" Text='<%# Bind("BL")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="PORT_TRANSFER" FooterText="PORT_TRANSFER" HeaderText="PORT_TRANSFER">
                    <ItemTemplate>
                        <asp:Label ID="LblPORT_TRANSFER" runat="server" Text='<%# Bind("PORT_TRANSFER")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="STUFFINNG" FooterText="STUFFINNG" HeaderText="STUFFINNG">
                    <ItemTemplate>
                        <asp:Label ID="LblSTUFFINNG" runat="server" Text='<%# Bind("STUFFINNG")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="VGM_SOLAS" FooterText="VGM_SOLAS" HeaderText="VGM_SOLAS">
                    <ItemTemplate>
                        <asp:Label ID="LblVGM_SOLAS" runat="server" Text='<%# Bind("VGM_SOLAS")%>'></asp:Label>
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
                        <asp:TextBox ID="TxtREMARKS" runat="server" Text='<%# Bind("REMARKS")%>'></asp:TextBox>
                        <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("REMARKS")%>' Visible="True"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <HeaderStyle BackColor="#01236A" ForeColor="White" />
            <PagerSettings Mode="NextPreviousFirstLast" />

        </asp:GridView>

    </div>

    <div id="PNLGVSerInt" runat="server" class="Asignar">
        <asp:GridView ID="GVSerInt" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                <asp:TemplateField AccessibleHeaderText="ORIGIN" FooterText="ORIGIN" HeaderText="ORIGIN">
                    <ItemTemplate>
                        <asp:Label ID="LblORIGIN" runat="server" Text='<%# Bind("ORIGIN")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="ORIGIN_RAMP" FooterText="ORIGIN_RAMP" HeaderText="ORIGIN_RAMP">
                    <ItemTemplate>
                        <asp:Label ID="LblORIGIN_RAMP" runat="server" Text='<%# Bind("ORIGIN_RAMP")%>'></asp:Label>
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


                <asp:TemplateField AccessibleHeaderText="ROUTE" FooterText="ROUTE" HeaderText="ROUTE">
                    <ItemTemplate>
                        <asp:Label ID="LblROUTE" runat="server" Text='<%# Bind("ROUTE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="MODE_CODE" FooterText="MODE_CODE" HeaderText="MODE_CODE">
                    <ItemTemplate>
                        <asp:Label ID="LblMODE_CODE" runat="server" Text='<%# Bind("MODE_CODE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="DESTINATION" FooterText="DESTINATION" HeaderText="DESTINATION">
                    <ItemTemplate>
                        <asp:Label ID="LblDESTINATION" runat="server" Text='<%# Bind("DESTINATION")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="DESTINATION_RAMP" FooterText="DESTINATION_RAMP" HeaderText="DESTINATION_RAMP">
                    <ItemTemplate>
                        <asp:Label ID="LblDESTINATION_RAMP" runat="server" Text='<%# Bind("DESTINATION_RAMP")%>'></asp:Label>
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
                <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="SUBTOTAL" FooterText="SUBTOTAL" HeaderText="SUBTOTAL">
                    <ItemTemplate>
                        <asp:Label ID="LblSUBTOTAL" runat="server" Text='<%# Bind("SUBTOTAL")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="FSC" FooterText="FSC" HeaderText="FSC">
                    <ItemTemplate>
                        <asp:Label ID="LblFSC" runat="server" Text='<%# Bind("FSC")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="FSC_TOTAL" FooterText="FSC_TOTAL" HeaderText="FSC_TOTAL">
                    <ItemTemplate>
                        <asp:Label ID="LblFSC_TOTAL" runat="server" Text='<%# Bind("FSC_TOTAL")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_US" FooterText="TOTAL_US" HeaderText="TOTAL_US">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL_US" runat="server" Text='<%# Bind("TOTAL_US")%>'></asp:Label>
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

    <div id="PNLGVSerLTL" runat="server" class="Asignar">
        <asp:GridView ID="GVSerLTL" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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


                <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                    <ItemTemplate>
                        <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="QUANTITY" FooterText="QUANTITY" HeaderText="QUANTITY">
                    <ItemTemplate>
                        <asp:Label ID="LblQUANTITY" runat="server" Text='<%# Bind("QUANTITY")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TYPE" FooterText="TYPE" HeaderText="TYPE">
                    <ItemTemplate>
                        <asp:Label ID="LblTYPE" runat="server" Text='<%# Bind("TYPE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="TOTAL_WEIGHT" FooterText="TOTAL_WEIGHT" HeaderText="TOTAL_WEIGHT">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL_WEIGHT" runat="server" Text='<%# Bind("TOTAL_WEIGHT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="WEIGHT" FooterText="WEIGHT" HeaderText="WEIGHT">
                    <ItemTemplate>
                        <asp:Label ID="LblWEIGHT" runat="server" Text='<%# Bind("WEIGHT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="LARGE" FooterText="LARGE" HeaderText="LARGE">
                    <ItemTemplate>
                        <asp:Label ID="LblLARGE" runat="server" Text='<%# Bind("LARGE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="WIDTH" FooterText="WIDTH" HeaderText="WIDTH">
                    <ItemTemplate>
                        <asp:Label ID="LblWIDTH" runat="server" Text='<%# Bind("WIDTH")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="HEIGHT" FooterText="HEIGHT" HeaderText="HEIGHT">
                    <ItemTemplate>
                        <asp:Label ID="LblHEIGHT" runat="server" Text='<%# Bind("HEIGHT")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="STACKABLE" FooterText="STACKABLE" HeaderText="STACKABLE">
                    <ItemTemplate>
                        <asp:Label ID="LblSTACKABLE" runat="server" Text='<%# Bind("STACKABLE")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField AccessibleHeaderText="TOTAL" FooterText="TOTAL" HeaderText="TOTAL">
                    <ItemTemplate>
                        <asp:Label ID="LblTOTAL" runat="server" Text='<%# Bind("TOTAL")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="CROSSBORDER" FooterText="CROSSBORDER" HeaderText="CROSSBORDER">
                    <ItemTemplate>
                        <asp:Label ID="LblCROSSBORDER" runat="server" Text='<%# Bind("CROSSBORDER")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                    <ItemTemplate>
                        <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
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

    <div id="PNLGVSerTLM" runat="server" class="Asignar">

    </div>

    <div id="PNLGVSerTLU" runat="server" class="Asignar">

    </div>

    <div id="PNLBT" runat="server" class="container">
        <div class="row">
            <div class="col-sm-12 form-horizontal">
                <asp:Button ID="BtnAgregarPartida" runat="server" Text="Agregar partida(s)" class="btn btn-default btn-sm Button" />
                <asp:Button ID="BtnEliminarPartida" runat="server" Text="Eliminar partida(s)" class="btn btn-default btn-sm Button" />
                <asp:Button ID="BtnEliminarTodo" runat="server" Text="Eliminar todo" class="btn btn-default btn-sm Button" />
                <asp:Button ID="BtnAgregarServicio" runat="server" Text="Agregar otro servicio" class="btn btn-default btn-sm Button" />
                <asp:Button ID="Button3" runat="server" Text="Solicitar a pricing" class="btn btn-default btn-sm Button" />
            </div>
        </div>
    </div>

    <br />

    <div id="DivCargos" runat="server">
        <div class="row">
            <div id="DivCargosOrigen" runat="server" class="col-sm-6 form-horizontal">
                <div class="col-sm-12">
                    <h3>
                        <asp:Label ID="LblCarO" runat="server" Text="Label"></asp:Label>
                    </h3>
                </div>
                <div class="col-sm-12">
                    <div class="Asignar">
                        <asp:GridView ID="GvCarOri" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Código" FooterText="Codigo" HeaderText="Item No" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="LblCodigo" runat="server" Text='<%# Bind("Codigo")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Nombre" FooterText="Nombre" HeaderText="Descripción">
                                    <ItemTemplate>
                                        <asp:Label ID="LblNombre" runat="server" Text='<%# Bind("Nombre")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Moneda" FooterText="Moneda" HeaderText="Moneda">
                                    <ItemTemplate>
                                        <asp:Label ID="LblMoneda" runat="server" Text='<%# Bind("Moneda") %>' Visible="False"></asp:Label>
                                        <asp:DropDownList ID="DdlMoneda" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DdlMoneda_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Precio" FooterText="Precio" HeaderText="Monto">
                                    <ItemTemplate>
                                        <asp:Label ID="LblPrecio" runat="server" Text='<%# Bind("Precio")%>' Visible="false"></asp:Label>
                                        <asp:TextBox ID="TxtPrecio" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio]"))%>'></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Right" />
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle BackColor="#01236A" Font-Size="9pt" ForeColor="White" />
                            <PagerSettings Mode="NextPreviousFirstLast" />
                        </asp:GridView>
                    </div>
                </div>
                <div class="col-sm-12">
                    <asp:Button ID="BtnCarOAdd" runat="server" Text="Agregar" CssClass="btn btn-default Button" />
                    <asp:Button ID="BtnCarODel" runat="server" Text="Eliminar" CssClass="btn btn-default Button" />
                </div>
            </div>
            <div id="DivCargosDestino" runat="server" class="col-sm-6 form-horizontal">
                <div class="col-sm-12">
                    <h3>
                        <asp:Label ID="LblCarD" runat="server" Text="Label"></asp:Label>
                    </h3>
                </div>
                <div class="col-sm-12">
                    <div class="Asignar">
                        <asp:GridView ID="GvCarDes" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Código" FooterText="Codigo" HeaderText="Item No" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="LblCodigo" runat="server" Text='<%# Bind("Codigo")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Nombre" FooterText="Nombre" HeaderText="Descripción">
                                    <ItemTemplate>
                                        <asp:Label ID="LblNombre" runat="server" Text='<%# Bind("Nombre")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Moneda" FooterText="Moneda" HeaderText="Moneda">
                                    <ItemTemplate>
                                        <asp:Label ID="LblMoneda" runat="server" Text='<%# Bind("Moneda") %>' Visible="False"></asp:Label>
                                        <asp:DropDownList ID="DdlMoneda" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DdlMoneda_SelectedIndexChanged1">
                                        </asp:DropDownList>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField AccessibleHeaderText="Precio" FooterText="Precio" HeaderText="Monto">
                                    <ItemTemplate>
                                        <asp:Label ID="LblPrecio" runat="server" Text='<%# Bind("Precio")%>' Visible="false"></asp:Label>
                                        <asp:TextBox ID="TxtPrecio" runat="server" Text='<%# String.Format("{0:N2}", Eval("[Precio]"))%>'></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Right" />
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle BackColor="#01236A" Font-Size="9pt" ForeColor="White" />
                            <PagerSettings Mode="NextPreviousFirstLast" />
                        </asp:GridView>
                    </div>
                </div>
                <div class="col-sm-12">
                    <asp:Button ID="BtnCarDAdd" runat="server" Text="Agregar" CssClass="btn btn-default Button" />
                    <asp:Button ID="BtnCarDDel" runat="server" Text="Eliminar" CssClass="btn btn-default Button" />
                </div>
            </div>
        </div>
    </div>

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
                        <div>
                            <div>
                                <div class="col-lg-12">

                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-4" for="inputsm"></label>
                                            <div class="col-md-8">
                                                <asp:DropDownList ID="DdlServicio" runat="server" AutoPostBack="True" CssClass="form-control inputsm" TabIndex="1" Visible="false">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-4" for="inputsm"></label>
                                            <div class="col-md-8">
                                                <asp:DropDownList ID="DdlServiceDetails" runat="server" CssClass="form-control inputsm" AutoPostBack="True" Visible="false">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-4" for="inputsm">POL COUNTRY</label>
                                            <div class="col-md-8">
                                                <asp:TextBox ID="TxtPOL_Country" runat="server" CssClass="form-control inputsm" onkeypress="return AnularEnter(event.keyCode);" TabIndex="2" AutoPostBack="True" ClientIDMode="Static"></asp:TextBox>
                                                <asp:HiddenField ID="TxtCodePOL_Country" runat="server" ClientIDMode="Static"/>
                                                <asp:HiddenField ID="HiddenField2" runat="server" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-4" for="inputsm">POD COUNTRY</label>
                                            <div class="col-md-8">
                                                <asp:TextBox ID="TxtPOD_Country" runat="server" CssClass="form-control inputsm" onkeypress="return AnularEnter(event.keyCode);" TabIndex="4" AutoPostBack="True" ClientIDMode="Static"></asp:TextBox>
                                                <asp:HiddenField ID="TxtCodePOD_Country" runat="server" ClientIDMode="Static"/>
                                                <asp:HiddenField ID="HiddenField3" runat="server" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-4">POL:</label>
                                            <div class="col-md-8">
                                                <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control" TabIndex="3" AutoPostBack="True" ClientIDMode="Static"></asp:TextBox>
                                                <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control" Visible="False" ClientIDMode="Static"></asp:TextBox>
                                                <asp:HiddenField ID="HiddenField1" runat="server" />
                                            </div>

                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-4">POD:</label>
                                            <div class="col-md-8">
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

                            <asp:GridView ID="GvBusAer" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="AEROLINEA" FooterText="AEROLINEA" HeaderText="AEROLINEA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAEROLINEA" runat="server" Text='<%# Bind("AEROLINEA")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="POL_CODE_COUNTRY" FooterText="POL_CODE_COUNTRY" HeaderText="POL CODE COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_CODE_COUNTRY" runat="server" Text='<%# Bind("POL_CODE_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="POD_COUNTRY" FooterText="POD_COUNTRY" HeaderText="POD_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOD_COUNTRY" runat="server" Text='<%# Bind("POD_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA1" FooterText="VIA1" HeaderText="VIA1">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA1" runat="server" Text='<%# Bind("VIA1")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA2" FooterText="VIA2" HeaderText="VIA2">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA2" runat="server" Text='<%# Bind("VIA2")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA3" FooterText="VIA3" HeaderText="VIA3">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA3" runat="server" Text='<%# Bind("VIA3")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA4" FooterText="VIA4" HeaderText="VIA4">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA4" runat="server" Text='<%# Bind("VIA4")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA5" FooterText="VIA5" HeaderText="VIA5">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA5" runat="server" Text='<%# Bind("VIA5")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MIN" FooterText="MIN" HeaderText="MIN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMIN" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MIN]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MEN45KG" FooterText="MEN45KG" HeaderText="MEN45KG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMEN45KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MEN45KG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MAY45KG" FooterText="MAY45KG" HeaderText="MAY45KG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMAY45KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY45KG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MAY100KG" FooterText="MAY100KG" HeaderText="MAY100KG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMAY100KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY100KG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MAY300KG" FooterText="MAY300KG" HeaderText="MAY300KG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMAY300KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY300KG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MAY500KG" FooterText="MAY500KG" HeaderText="MAY500KG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMAY500KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY500KG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MAY1000KG" FooterText="MAY1000KG" HeaderText="MAY1000KG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMAY1000KG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[MAY1000KG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FSCKG" FooterText="FSCKG" HeaderText="FSCKG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFSCKG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[FSCKG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="SSCKG" FooterText="SSCKG" HeaderText="SSCKG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSSCKG" runat="server" Text='<%# String.Format("{0:N2}", Eval("[SSCKG]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TAX" FooterText="TAX" HeaderText="TAX">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTAX" runat="server" Text='<%# Bind("TAX")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="HAWB" FooterText="HAWB" HeaderText="HAWB">
                                        <ItemTemplate>
                                            <asp:Label ID="LblHAWB" runat="server" Text='<%# Bind("HAWB")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="HANDLING" FooterText="HANDLING" HeaderText="HANDLING">
                                        <ItemTemplate>
                                            <asp:Label ID="LblHANDLING" runat="server" Text='<%# Bind("HANDLING")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="ROUNTING" FooterText="ROUNTING" HeaderText="ROUNTING">
                                        <ItemTemplate>
                                            <asp:Label ID="LblROUNTING" runat="server" Text='<%# Bind("ROUNTING")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FREQUENCY" FooterText="FREQUENCY" HeaderText="FREQUENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREQUENCY" runat="server" Text='<%# Bind("FREQUENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="AIRCRAFT" FooterText="AIRCRAFT" HeaderText="AIRCRAFT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAIRCRAFT" runat="server" Text='<%# Bind("AIRCRAFT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MAXDimXPZA" FooterText="MAXDimXPZA" HeaderText="MAXDimXPZA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMAXDimXPZA" runat="server" Text='<%# Bind("MAXDimXPZA")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MAXWeigthXPZA" FooterText="MAXWeigthXPZA" HeaderText="MAXWeigthXPZA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMAXWeigthXPZA" runat="server" Text='<%# Bind("MAXWeigthXPZA")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMITMENT_VOL" FooterText="COMMITMENT_VOL" HeaderText="COMMITMENT VOL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMITMENT_VOL" runat="server" Text='<%# Bind("COMMITMENT_VOL")%>'></asp:Label>
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
                            <asp:GridView ID="GvBusArr" runat="server" AutoGenerateColumns="False" class="table table-hover" Font-Size="11px">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox1" runat="server" CssClass="input-sm" />
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
                                <HeaderStyle BackColor="#01236A" ForeColor="White" />
                                <PagerSettings Mode="NextPreviousFirstLast" />

                            </asp:GridView>
                            <asp:GridView ID="GvBusArB" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl20GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[20GP]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40GP]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40HQ" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40HQ]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="EQUIPMENT" FooterText="EQUIPMENT" HeaderText="EQUIPMENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblEQUIPMENT" runat="server" Text='<%# Bind("EQUIPMENT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MODE" FooterText="MODE" HeaderText="MODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMODE" runat="server" Text='<%# Bind("MODE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="SINGLE" FooterText="SINGLE" HeaderText="SINGLE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSINGLE" runat="server" Text='<%# Bind("SINGLE")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="UN" FooterText="UN" HeaderText="UN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblUN" runat="server" Text='<%# Bind("UN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
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
                            <asp:GridView ID="GvBusInt" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="ORIGIN" FooterText="ORIGIN" HeaderText="ORIGIN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblORIGIN" runat="server" Text='<%# Bind("ORIGIN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="ORIGIN_RAMP" FooterText="ORIGIN_RAMP" HeaderText="ORIGIN_RAMP">
                                        <ItemTemplate>
                                            <asp:Label ID="LblORIGIN_RAMP" runat="server" Text='<%# Bind("ORIGIN_RAMP")%>'></asp:Label>
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


                                    <asp:TemplateField AccessibleHeaderText="ROUTE" FooterText="ROUTE" HeaderText="ROUTE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblROUTE" runat="server" Text='<%# Bind("ROUTE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MODE_CODE" FooterText="MODE_CODE" HeaderText="MODE_CODE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMODE_CODE" runat="server" Text='<%# Bind("MODE_CODE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="DESTINATION" FooterText="DESTINATION" HeaderText="DESTINATION">
                                        <ItemTemplate>
                                            <asp:Label ID="LblDESTINATION" runat="server" Text='<%# Bind("DESTINATION")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="DESTINATION_RAMP" FooterText="DESTINATION_RAMP" HeaderText="DESTINATION_RAMP">
                                        <ItemTemplate>
                                            <asp:Label ID="LblDESTINATION_RAMP" runat="server" Text='<%# Bind("DESTINATION_RAMP")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="SUBTOTAL" FooterText="SUBTOTAL" HeaderText="SUBTOTAL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSUBTOTAL" runat="server" Text='<%# Bind("SUBTOTAL")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FSC" FooterText="FSC" HeaderText="FSC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFSC" runat="server" Text='<%# Bind("FSC")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FSC_TOTAL" FooterText="FSC_TOTAL" HeaderText="FSC_TOTAL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFSC_TOTAL" runat="server" Text='<%# Bind("FSC_TOTAL")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOTAL_US" FooterText="TOTAL_US" HeaderText="TOTAL_US">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOTAL_US" runat="server" Text='<%# Bind("TOTAL_US")%>'></asp:Label>
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
                            <asp:GridView ID="GvBusMar" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CARRIER" FooterText="CARRIER" HeaderText="CARRIER">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCARRIER" runat="server" Text='<%# Bind("CARRIER")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="POL_CODE_COUNTRY" FooterText="POL_CODE_COUNTRY" HeaderText="POL CODE COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_CODE_COUNTRY" runat="server" Text='<%# Bind("POL_CODE_COUNTRY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="VIA1" FooterText="VIA1" HeaderText="VIA1">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA1" runat="server" Text='<%# Bind("VIA1")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA2" FooterText="VIA2" HeaderText="VIA2">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA2" runat="server" Text='<%# Bind("VIA2")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA3" FooterText="VIA3" HeaderText="VIA3">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA3" runat="server" Text='<%# Bind("VIA3")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl20GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[20GP]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40GP]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40HQ" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40HQ]"))%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREE_DAYS" runat="server" Text='<%# Bind("FREE_DAYS")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="UN" FooterText="UN" HeaderText="UN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblUN" runat="server" Text='<%# Bind("UN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="IMO_SUB" FooterText="IMO_SUB" HeaderText="IMO_SUB">
                                        <ItemTemplate>
                                            <asp:Label ID="LblIMO_SUB" runat="server" Text='<%# Bind("IMO_SUB")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMITMENT_TES" FooterText="COMMITMENT_TES" HeaderText="COMMITMENT_TES">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMITMENT_TES" runat="server" Text='<%# Bind("COMMITMENT_TES")%>'></asp:Label>
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
                            <asp:GridView ID="GvBusMul" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CARRIER" FooterText="CARRIER" HeaderText="CARRIER">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCARRIER" runat="server" Text='<%# Bind("CARRIER")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="VIA1" FooterText="VIA1" HeaderText="VIA1">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA1" runat="server" Text='<%# Bind("VIA1")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA2" FooterText="VIA2" HeaderText="VIA2">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA2" runat="server" Text='<%# Bind("VIA2")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA3" FooterText="VIA3" HeaderText="VIA3">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA3" runat="server" Text='<%# Bind("VIA3")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="20GP" FooterText="20GP" HeaderText="20GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl20GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[20GP]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40GP" FooterText="40GP" HeaderText="40GP">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40GP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40GP]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="40HQ" FooterText="40HQ" HeaderText="40HQ">
                                        <ItemTemplate>
                                            <asp:Label ID="Lbl40HQ" runat="server" Text='<%# String.Format("{0:N2}", Eval("[40HQ]"))%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREE_DAYS" runat="server" Text='<%# Bind("FREE_DAYS")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="UN" FooterText="UN" HeaderText="UN">
                                        <ItemTemplate>
                                            <asp:Label ID="LblUN" runat="server" Text='<%# Bind("UN")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="IMO_SUB" FooterText="IMO_SUB" HeaderText="IMO_SUB">
                                        <ItemTemplate>
                                            <asp:Label ID="LblIMO_SUB" runat="server" Text='<%# String.Format("{0:N2}", Eval("[IMO_SUB]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMITMENT_TES" FooterText="COMMITMENT_TES" HeaderText="COMMITMENT_TES">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMITMENT_TES" runat="server" Text='<%# String.Format("{0:N2}", Eval("[COMMITMENT_TES]"))%>'></asp:Label>
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
                            <asp:GridView ID="GvBusTer" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="STOP" FooterText="STOP" HeaderText="STOP">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSTOP" runat="server" Text='<%# String.Format("{0:N2}", Eval("[STOP]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="STOP2" FooterText="STOP2" HeaderText="STOP2">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSTOP2" runat="server" Text='<%# String.Format("{0:N2}", Eval("[STOP2]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="STOP3" FooterText="STOP3" HeaderText="STOP3">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSTOP3" runat="server" Text='<%# String.Format("{0:N2}", Eval("[STOP3]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOTALRATE" FooterText="TOTALRATE" HeaderText="TOTALRATE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOTALRATE" runat="server" Text='<%# String.Format("{0:N2}", Eval("[TOTALRATE]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="KM" FooterText="KM" HeaderText="KM">
                                        <ItemTemplate>
                                            <asp:Label ID="LblKM" runat="server" Text='<%# String.Format("{0:N2}", Eval("[KM]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FSC" FooterText="FSC" HeaderText="FSC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFSC" runat="server" Text='<%# String.Format("{0:N2}", Eval("[FSC]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FSC_TOTAL" FooterText="FSC_TOTAL" HeaderText="FSC_TOTAL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFSC_TOTAL" runat="server" Text='<%# String.Format("{0:N2}", Eval("[FSC_TOTAL]"))%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREE_DAYS" runat="server" Text='<%# Bind("FREE_DAYS")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="FREE_HRS_LOA_UNLOA" FooterText="FREE_HRS_LOA_UNLOA" HeaderText="FREE_HRS_LOA_UNLOA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREE_HRS_LOA_UNLOA" runat="server" Text='<%# Bind("FREE_HRS_LOA_UNLOA")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>










                                </Columns>
                                <HeaderStyle BackColor="#01236A" Font-Size="9pt" ForeColor="White" />
                                <PagerSettings Mode="NextPreviousFirstLast" />

                            </asp:GridView>
                            <asp:GridView ID="GvBusTerA" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("[CURRENCY]")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="MILES" FooterText="MILES" HeaderText="MILES">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMILES" runat="server" Text='<%# Bind("[MILES]")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>



                                    <asp:TemplateField AccessibleHeaderText="RPM" FooterText="RPM" HeaderText="RPM">
                                        <ItemTemplate>
                                            <asp:Label ID="LblRPM" runat="server" Text='<%# Bind("[RPM]")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="SUBTOTAL" FooterText="SUBTOTAL" HeaderText="SUBTOTAL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSUBTOTAL" runat="server" Text='<%# Bind("[SUBTOTAL]")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="FSC" FooterText="FSC" HeaderText="FSC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFSC" runat="server" Text='<%# String.Format("{0:N2}", Eval("[FSC]"))%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOTAL_US" FooterText="TOTAL_US" HeaderText="TOTAL_US">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOTAL_US" runat="server" Text='<%# Bind("[TOTAL_US]")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREE_DAYS" runat="server" Text='<%# Bind("FREE_DAYS")%>'></asp:Label>
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
                            <asp:GridView ID="GvBusMarLCL" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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
                                    <asp:TemplateField AccessibleHeaderText="CO_LOADER" FooterText="CO_LOADER" HeaderText="CO_LOADER">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCO_LOADER" runat="server" Text='<%# Bind("CO_LOADER")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="AGENT" FooterText="AGENT" HeaderText="AGENT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAGENT" runat="server" Text='<%# Bind("AGENT")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="POL_COUNTRY" FooterText="POL_COUNTRY" HeaderText="POL_COUNTRY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPOL_COUNTRY" runat="server" Text='<%# Bind("POL_COUNTRY")%>'></asp:Label>
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
                                    <asp:TemplateField AccessibleHeaderText="VIA1" FooterText="VIA1" HeaderText="VIA1">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA1" runat="server" Text='<%# Bind("VIA1")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA2" FooterText="VIA2" HeaderText="VIA2">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA2" runat="server" Text='<%# Bind("VIA2")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="VIA3" FooterText="VIA3" HeaderText="VIA3">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVIA3" runat="server" Text='<%# Bind("VIA3")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="COST" FooterText="COST" HeaderText="COST">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOST" runat="server" Text='<%# Bind("COST")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="MIN_COST" FooterText="MIN_COST" HeaderText="MIN_COST">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMIN_COST" runat="server" Text='<%# Bind("MIN_COST")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="FREQUENCY" FooterText="FREQUENCY" HeaderText="FREQUENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFREQUENCY" runat="server" Text='<%# Bind("FREQUENCY")%>'></asp:Label>
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

                                    <asp:TemplateField AccessibleHeaderText="FREE_DAYS" FooterText="FREE_DAYS" HeaderText="FREE_DAYS">
                                        <ItemTemplate>
                                            <asp:TextBox ID="LblFREE_DAYS" runat="server" Text='<%# Bind("FREE_DAYS")%>' onkeypress="return AnularEnter(event.keyCode);"></asp:TextBox>

                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="NAC" FooterText="NAC" HeaderText="NAC">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNAC" runat="server" Text='<%# Bind("NAC")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="RA" FooterText="RA" HeaderText="RA">
                                        <ItemTemplate>
                                            <asp:Label ID="LblRA" runat="server" Text='<%# Bind("RA")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>



                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>





                                    <asp:TemplateField AccessibleHeaderText="ADDMON_FEE" FooterText="ADDMON_FEE" HeaderText="ADDMON_FEE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblADDMON_FEE" runat="server" Text='<%# Bind("ADDMON_FEE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="BL" FooterText="BL" HeaderText="BL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblBL" runat="server" Text='<%# Bind("BL")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="PORT_TRANSFER" FooterText="PORT_TRANSFER" HeaderText="PORT_TRANSFER">
                                        <ItemTemplate>
                                            <asp:Label ID="LblPORT_TRANSFER" runat="server" Text='<%# Bind("PORT_TRANSFER")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="STUFFINNG" FooterText="STUFFINNG" HeaderText="STUFFINNG">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSTUFFINNG" runat="server" Text='<%# Bind("STUFFINNG")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="VGM_SOLAS" FooterText="VGM_SOLAS" HeaderText="VGM_SOLAS">
                                        <ItemTemplate>
                                            <asp:Label ID="LblVGM_SOLAS" runat="server" Text='<%# Bind("VGM_SOLAS")%>'></asp:Label>
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
                                            <asp:TextBox ID="TxtREMARKS" runat="server" Text='<%# Bind("REMARKS")%>'></asp:TextBox>
                                            <asp:Label ID="LblREMARKS" runat="server" Text='<%# Bind("REMARKS")%>' Visible="True"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                                <HeaderStyle BackColor="#01236A" ForeColor="White" />
                                <PagerSettings Mode="NextPreviousFirstLast" />

                            </asp:GridView>
                            <asp:GridView ID="GvBusLTL" runat="server" AutoGenerateColumns="False" class="table" Font-Size="12px">
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


                                    <asp:TemplateField AccessibleHeaderText="CURRENCY" FooterText="CURRENCY" HeaderText="CURRENCY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCURRENCY" runat="server" Text='<%# Bind("CURRENCY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="QUANTITY" FooterText="QUANTITY" HeaderText="QUANTITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblQUANTITY" runat="server" Text='<%# Bind("QUANTITY")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TYPE" FooterText="TYPE" HeaderText="TYPE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTYPE" runat="server" Text='<%# Bind("TYPE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="TOTAL_WEIGHT" FooterText="TOTAL_WEIGHT" HeaderText="TOTAL_WEIGHT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOTAL_WEIGHT" runat="server" Text='<%# Bind("TOTAL_WEIGHT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="WEIGHT" FooterText="WEIGHT" HeaderText="WEIGHT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblWEIGHT" runat="server"  Text='<%# Bind("WEIGHT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="LARGE" FooterText="LARGE" HeaderText="LARGE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblLARGE" runat="server" Text='<%# Bind("LARGE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="WIDTH" FooterText="WIDTH" HeaderText="WIDTH">
                                        <ItemTemplate>
                                            <asp:Label ID="LblWIDTH" runat="server" Text='<%# Bind("WIDTH")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="HEIGHT" FooterText="HEIGHT" HeaderText="HEIGHT">
                                        <ItemTemplate>
                                            <asp:Label ID="LblHEIGHT" runat="server" Text='<%# Bind("HEIGHT")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="STACKABLE" FooterText="STACKABLE" HeaderText="STACKABLE">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSTACKABLE" runat="server" Text='<%# Bind("STACKABLE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField AccessibleHeaderText="TOTAL" FooterText="TOTAL" HeaderText="TOTAL">
                                        <ItemTemplate>
                                            <asp:Label ID="LblTOTAL" runat="server" Text='<%# Bind("TOTAL")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="CROSSBORDER" FooterText="CROSSBORDER" HeaderText="CROSSBORDER">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCROSSBORDER" runat="server" Text='<%# Bind("CROSSBORDER")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField AccessibleHeaderText="COMMODITY" FooterText="COMMODITY" HeaderText="COMMODITY">
                                        <ItemTemplate>
                                            <asp:Label ID="LblCOMMODITY" runat="server" Text='<%# Bind("COMMODITY")%>'></asp:Label>
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
                        <asp:Label ID="Lbl_Error_AddSer" runat="server"></asp:Label>
                        <asp:Button ID="Button1" runat="server" Text="Agregar partida" CssClass="btn btn-default" />
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="modal" id="myModal2">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">
                            <asp:Label ID="LblTituloSolicitud" runat="server" Text="Label"></asp:Label>
                        </h4>
                    </div>
                    <div class="modal-body">

                        <div id="tarifarioarrastres" runat="server" class="col-lg-12">
                            <div class="col-md-6">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*CARRIER:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="carrier7" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*ORIGIN:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="origin5" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <asp:TextBox ID="idorigin5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hforigin5" ClientIDMode="Static" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*POL_COUNTRY:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="polcountry10" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                        <asp:HiddenField ID="polcountrycode10" ClientIDMode="Static" runat="server" />
                                        <asp:HiddenField ID="hfpolcountry10" ClientIDMode="Static" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*POL:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="pol10" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                        <asp:TextBox ID="polcode10" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpol10" ClientIDMode="Static" runat="server" />

                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">POL_ZIPCODE:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="pol_zipcode6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*DESTINATION:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="destination5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <asp:TextBox ID="iddestination5" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfdestination5" ClientIDMode="Static" runat="server" />

                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*POD_COUNTRY:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="podcountry10" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:HiddenField ID="podcountrycode10" ClientIDMode="Static" runat="server" />                                       
                                        <asp:HiddenField ID="hfpodcountry10" ClientIDMode="Static" runat="server" />

                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*POD:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="pod10" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                        <asp:TextBox ID="idpod10" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfpod10" ClientIDMode="Static" runat="server" />

                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">POD_ZIPCODE:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="pod_zipcode6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                                </div>
                            <div class="col-md-6">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*SERVICE:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="service" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*EQUIPMENT:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="equipment6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <asp:TextBox ID="idequipment6" ClientIDMode="Static" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                                        <asp:HiddenField ID="hfequipment6" ClientIDMode="Static" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">REMARKS:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="remarks10" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*CURRENCY:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="currency7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">VOLUME:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="volume2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">*COMMODITY:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="commodity10" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">SINGLE WEIGHT:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="singleweight" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label col-md-4 inputsm">TANDEM WEIGHT:</label>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="tandemweight" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                                </div>
                        </div>

                        <div id="tarifarioAir" runat="server" class="col-lg-12">

                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="polcountry7">*POL_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="polcountry7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:HiddenField ID="polcountrycode7" ClientIDMode="Static" runat="server" />
                                            <asp:HiddenField ID="hfpolcountry7" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol7">*POL</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="polcode7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpol7" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="podcountry7">*POD_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="podcountry7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:HiddenField ID="podcountrycode7" ClientIDMode="Static" runat="server" />                                            
                                            <asp:HiddenField ID="hfpodcountry7" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod7">*POD</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="podcode7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpod7" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="un4">UN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="un4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="class4">CLASS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="class4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="remarks7">REMARKS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="remarks7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="commodity7">*COMMODITY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="commodity7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="packing4">PACKING</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="packing4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="number3">NUMBER PKG</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="number3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="weight5">WEIGHT PKG</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="weight5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="measures4">MEASURES PKG</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="measures4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="stackable4">STACKABLE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stackable4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="incoterm2">INCOTERM</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="incoterm2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="urgent">URGENT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="urgent" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="maritimocompleto" runat="server" class="col-lg-12" ClientIDMode="static">

                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="carrier1">*CARRIER</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="carrier1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol1">*POL</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="polcode1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:TextBox ID="namepolcountry" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpol1" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod1">*POD</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="podcode1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:TextBox ID="namepodcountry" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpod1" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="equipment">*EQUIPMENT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="equipment" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="un">UN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="un" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="class7">CLASS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="class7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="commodity1">*COMMODITY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="commodity1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="remarks1">REMARKS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="remarks1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="cargoweight">CARGO WEIGHT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="cargoweight" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="incoterm">INCOTERM</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="incoterm" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="packing1">PACKING</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="packing1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="number">NUMBER</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="number" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="measures1">MEASURES</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="measures1" ClientIDMode="Static" runat="server" CssClass="form-control  input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="stackable1">STACKABLE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stackable1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="ltlamericanonacional" runat="server" class="col-lg-12" ClientIDMode="static">
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="carrier2">*CARRIER</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="carrier2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="origin1">*ORIGIN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="origin1" ClientIDMode="Static" runat="server" CssClass="form-control  input-sm"></asp:TextBox>
                                            <asp:TextBox ID="idorigin1" ClientIDMode="Static" runat="server" CssClass="form-control  input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hforigin1" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol2">*POL</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="polcode2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpol2" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="polcountry1">*POL_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="polcountry1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:HiddenField ID="polcountrycode1" ClientIDMode="Static" runat="server" />                                            
                                            <asp:HiddenField ID="hfpolcountry1" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol_zipcode1">POL_ZIPCODE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="polzipcode1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="destination1">*DESTINATION</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="destination1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="iddestination1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfdestination1" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod2">*POD</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="podcode2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpod2" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="podcountry1">*POD_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="podcountry1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:HiddenField ID="podcodecountry1" ClientIDMode="Static" runat="server" />                                             
                                            <asp:HiddenField ID="hfpodcountry1" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>

                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod_zipcode1">POD_ZIPCODE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod_zipcode1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="type">*TYPE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="type" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="commodity2">*COMMODITY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="commodity2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="remarks2">REMARKS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="remarks2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="weight">WEIGHT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="weight" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="measures">MEASURES</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="measures" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="volume">VOLUME</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="volume" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="stackable">STACKABLE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stackable" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="currency">CURRENCY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="currency" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="packing">PACKING</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="packing" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="quantity">*QUANTITY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="quantity" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="stops">*STOPS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stops" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="ltlintermodal" runat="server" class="col-lg-12" ClientIDMode="static">

                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="carrier3">*CARRIER</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="carrier3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="origin2">*ORIGIN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="origin2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="idorigin2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hforigin2" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="originramp">*ORIGIN RAMP</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="originramp" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="idoriginramp" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hforiginramp" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="polcountry3">*POL_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="polcountry3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                              <asp:HiddenField ID="polcountrycode3" ClientIDMode="Static" runat="server" />
                                            <asp:HiddenField ID="hfpolcountry3" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol3">*POL</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="polcode3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpol3" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol_zipcode">POL_ZIPCODE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol_zipcode2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="destination2">*DESTINATION</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="destination2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="iddestination2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfdestination2" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="destinationramp">*DESTINATION RAMP</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="destinationramp" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="iddestinationramp" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfdestinationramp" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="podcountry2">*POD_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="podcountry2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:HiddenField ID="podcodecountry2" ClientIDMode="Static" runat="server" />                                            
                                            <asp:HiddenField ID="hfpodcountry2" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod3">*POD</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="podcode3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpod3" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod_zipcode2">POD_ZIPCODE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod_zipcode2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="currency1">*CURRENCY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="currency1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="un1">UN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="un1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="class1">CLASS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="class1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="equipment1">*EQUIPMENT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="equipment1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="idequipment1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfequipment1" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="commodity3">*COMMODITY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="commodity3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="remarks3">REMARKS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="remarks3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="weight2">WEIGHT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="weight2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="measures5">MEASURES</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="measures5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="stackable5">STACKABLE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stackable5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="packing5">PACKING</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="packing5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="maritimolcl" runat="server" class="col-lg-12" ClientIDMode="static">
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="coloader">CO-LOADER</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="coloader" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="polcountry4">*POL_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="polcountry4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:HiddenField ID="polcountrycode4" ClientIDMode="Static" runat="server" />
                                            <asp:HiddenField ID="hfpolcountry4" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol4">*POL</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="polcode4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpol4" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="podcountry4">*POD_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="podcountry4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:HiddenField ID="podcountrycode4" ClientIDMode="Static" runat="server" />
                                            <asp:HiddenField ID="hfpodcountry4" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod4">*POD</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="podcode4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpod4" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="via1">VIA 1</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="via1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="via2">VIA 2</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="via2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="via3">VIA 3</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="via3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="currency2">*CURRENCY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="currency2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="cost">*COST</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="cost" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="minimumcost">*MINIMUM COST</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="minimumcost" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="equipment2">*EQUIPMENT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="equipment2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="idequipment2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfequipment2" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="commodity4">*COMMODITY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="commodity4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="un2">UN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="un2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="class2">CLASS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="class2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="bl">BL</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="bl" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="remarks4">REMARKS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="remarks4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="weight3">CARGO WEIGHT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="weight3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="incoterm1">INCOTERM</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="incoterm1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="packing2">PACKING</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="packing2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="number2">NUMBER</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="number2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="measures2">MEASURES</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="measures2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="stackable2">STACKABLE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stackable2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="terrestrenacional" runat="server" class="col-lg-12" clientidmode="static">

                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="carrier4">*CARRIER</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="carrier4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="origin3">*ORIGIN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="origin3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="idorigin3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hforigin3" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol5">*POL</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="polcode5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpol5" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="polcountry5">*POL_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="polcountry5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                             <asp:HiddenField ID="polcountrycode5" ClientIDMode="Static" runat="server" />
                                            <asp:HiddenField ID="hfpolcountry5" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pol_zipcode3">POL_ZIPCODE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pol_zipcode3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="destination3">*DESTINATION</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="destination3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="iddestination3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfdestination3" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod5">*POD</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:TextBox ID="podcode5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfpod5" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="podcountry5">*POD_COUNTRY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="podcountry5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                            <asp:HiddenField ID="podcountrycode5" ClientIDMode="Static" runat="server" />                                       
                                            <asp:HiddenField ID="hfpodcountry5" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="pod_zipcode3">POD_ZIPCODE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="pod_zipcode3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="via1">STOP 1</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stop1" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="via2">STOP 2</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stop2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="via3">STOP 3</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stop3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="un3">UN</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="un3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="class3">CLASS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="class3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="equipment3">*EQUIPMENT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="equipment3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <asp:TextBox ID="idequipment3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                            <asp:HiddenField ID="hfequipment3" ClientIDMode="Static" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="remarks5">REMARKS</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="remarks5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="weight4">WEIGHT</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="weight4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="measures3">MEASURES</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="measures3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="stackable3">STACKABLE</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="stackable3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="currency3">CURRENCY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="currency3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="packing3">PACKING</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="packing3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="control-label col-md-4 inputsm" for="commodity5">COMMODITY</label>
                                        <div class="col-md-8">
                                            <asp:TextBox ID="commodity5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="arrastrebl" runat="server" class="col-lg-12" ClientIDMode="static">

                                        <div class="col-md-6">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="polcountry8">*POL_COUNTRY</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="polcountry8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                                         <asp:HiddenField ID="polcountrycode8" ClientIDMode="Static" runat="server" />
                                                        <asp:HiddenField ID="hfpolcountry8" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="pol8">*POL</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="pol8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                                        <asp:TextBox ID="polcode8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                        <asp:HiddenField ID="hfpol8" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="pol_zipcode4">POL_ZIPCODE</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="pol_zipcode4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="podcountry8">*POD_COUNTRY</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="podcountry8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                                        <asp:HiddenField ID="podcountrycode8" ClientIDMode="Static" runat="server" /> 
                                                        <asp:HiddenField ID="hfpodcountry8" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="pod8">*POD</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="pod8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" AutoPostBack="True"></asp:TextBox>
                                                        <asp:TextBox ID="podcode8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                        <asp:HiddenField ID="hfpod8" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="pod_zipcode4">POD_ZIPCODE</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="pod_zipcode4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="veintegp">*20'GP</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="veintegp" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="cuarentagp">*40'GP</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="cuarentagp" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="cuarentahq2">*40'HQ</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="cuarentahq2" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="equipment4">*EQUIPMENT</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="equipment4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <asp:TextBox ID="idequipment4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                        <asp:HiddenField ID="hfequipment4" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="mode">MODE</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="mode" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="mode">SINGLE / FULL</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="singlefull" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="un5">UN</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="un5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="class5">CLASS</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="class5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="remarks8">REMARKS</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="remarks8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="commodity8">*COMMODITY</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="commodity8" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="currency5">*CURRENCY</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="currency5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="weight6">WEIGHT</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="weight6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                        <div id="tarifarioamericano" runat="server" class="col-lg-12" ClientIDMode="static">

                                        <div class="col-md-6">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="carrier6">*CARRIER</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="carrier6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="origin4">*ORIGIN</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="origin4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <asp:TextBox ID="idorigin4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                        <asp:HiddenField ID="hforigin4" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="pol9">*POL</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="pol9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <asp:TextBox ID="polcode9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                        <asp:HiddenField ID="hfpol9" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="polcountry9">*POL_COUNTRY</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="polcountry9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <asp:HiddenField ID="polcountrycode9" ClientIDMode="Static" runat="server" />
                                                        <asp:HiddenField ID="hfpolcountry9" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="pol_zipcode5">*POL_ZIPCODE</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="pol_zipcode5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="control-label col-md-4 inputsm" for="destination4">*DESTINATION</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="destination4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <asp:TextBox ID="iddestination4" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                        <asp:HiddenField ID="hfdestination4" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="pod9">*POD</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="pod9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    <asp:TextBox ID="podcode9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                    <asp:HiddenField ID="hfpod9" ClientIDMode="Static" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="podcountry9">*POD_COUNTRY</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="podcountry9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    <asp:HiddenField ID="podcountrycode9" ClientIDMode="Static" runat="server" /> 
                                                    <asp:HiddenField ID="hfpodcountry9" ClientIDMode="Static" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="pod_zipcode5">POD_ZIPCODE</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="pod_zipcode5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="equipment5">*EQUIPMENT</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="equipment5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                    <asp:TextBox ID="idequipment5" ClientIDMode="Static" runat="server" CssClass="form-control input-sm" Visible="false"></asp:TextBox>
                                                    <asp:HiddenField ID="hfequipment5" ClientIDMode="Static" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="directtranshipment">DIRECT / TRANSHIPMENT</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="directtranshipment" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="un6">UN</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="un6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="class6">CLASS</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="class6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="remarks9">REMARKS</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="remarks9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="currency6">*CURRENCY</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="currency6" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="volume3">VOLUME</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="volume3" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="weight7">TOTAL WEIGHT</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="weight7" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-4 inputsm" for="commodity9">*COMMODITY</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="commodity9" ClientIDMode="Static" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                    </div>

                    <div class="modal-footer">

                        <div class="col-md-6">
                            <div id="DivSuccessPricing" runat="server" class="alert alert-success alert-dismissable">
                                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                <strong>Success!</strong>
                                <asp:Label ID="LblSuccessPricing" runat="server"></asp:Label>
                            </div>
                            <div id="DivInfoPricing" runat="server" class="alert alert-info alert-dismissable">
                                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                <strong>Info!</strong>
                                <asp:Label ID="LblInfoPricing" runat="server"></asp:Label>
                            </div>
                            <div id="DivWarningPricing" runat="server" class="alert alert-danger alert-dismissable">
                                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                <strong>Warning!</strong>
                                <asp:Label ID="LblWarningPricing" runat="server" T></asp:Label>
                            </div>
                        </div>


                        <asp:Button ID="Button2" runat="server" Text="Enviar a pricing" CssClass="btn btn-default" OnClientClick="return validarServicio()" />
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>

                </div>
            </div>
        </div>
    </div>



    <div class="container">
        <div class="modal" id="myModal3">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        </h4>
                    </div>
                    <div class="modal-body">    
                                <div class="col-lg-12">

                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <label class="control-label col-lg-4" for="inputsm">Correo:</label>
                                            <div class="col-lg-8">
                                                <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <label class="control-label col-lg-4" for="inputsm">Asunto:</label>
                                            <div class="col-lg-8">
                                                <asp:TextBox ID="TxtAsunto" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <label class="control-label col-lg-4" for="inputsm">Cuerpo:</label>
                                            <div class="col-lg-8">
                                                <asp:TextBox ID="TxtCuerpo" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                </div>


                    </div>

                    <div class="modal-footer">
                        <asp:Button ID="Button4" runat="server" Text="Enviar correo" CssClass="btn btn-default" />
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="modal" id="myModal4">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">
                            <asp:Label ID="Label2" runat="server" Text="Mensaje"></asp:Label>
                        </h4>
                    </div>
                    <div class="modal-body">
                        <div class="col-lg-12">

                            <div class="col-md-12">
                                <div class="form-group">
                                    <div class="col-md-8">
                                        <asp:Label ID="Label3" runat="server" Text="Mensaje"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="modal" id="myModal5">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Agregar cargo
                        </h4>
                    </div>
                    <div class="modal-body">
                        <div class="col-sm-6 form-horizontal">
                            <div class="form-group">
                                <label class="control-label col-sm-3">Item Code:</label>
                                <div class="col-sm-7">
                                    <asp:TextBox ID="TxtArtCodigo" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                                </div>
                                <div class="col-sm-2">
                                    <asp:Button ID="BtnArtBuscarCodigo" runat="server" CssClass="btn btn-default Button" Text="Find Code" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label col-sm-3">Item Name:</label>
                                <div class="col-sm-7">
                                    <asp:TextBox ID="TxtArtNombre" runat="server" CssClass="form-control" onkeypress="return BtnBuscarNombre(event.keyCode);" AutoPostBack="True"></asp:TextBox>
                                </div>
                                <div class="col-sm-2">
                                    <asp:Button ID="BtnArtBuscarNombre" runat="server" Text="Find Name" CssClass="btn btn-default Button" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label col-sm-3"></label>
                                <div class="col-sm-7">
                                </div>
                                <div class="col-sm-2">
                                    <asp:Button ID="BtnArtMostrarTodo" runat="server" CssClass="btn btn-default Button" Text="show everything" />
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="Asignar">
                                <asp:GridView ID="GvArticulos" runat="server" AllowPaging="True" AutoGenerateColumns="False" BorderColor="#01236A" BorderStyle="Groove" BorderWidth="3px" CssClass="GridView1" Font-Size="9pt" PageSize="20">
                                    <Columns>
                                        <asp:TemplateField AccessibleHeaderText="" FooterText="" HeaderText="">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField AccessibleHeaderText="Codigo" FooterText="Codigo" HeaderText="Item Code">
                                            <ItemTemplate>
                                                <asp:Label ID="LblCodigo" runat="server" Text='<%# Bind("ItemCode")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField AccessibleHeaderText="Nombre" FooterText="Nombre" HeaderText="Item Name">
                                            <ItemTemplate>
                                                <asp:Label ID="LblNombre" runat="server" Text='<%# Bind("ItemName")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField AccessibleHeaderText="UM" FooterText="UM" HeaderText="UM">
                                            <ItemTemplate>
                                                <asp:Label ID="LblUM" runat="server" Text='<%# Bind("SalUnitMsr")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField AccessibleHeaderText="Precio" FooterText="Precio" HeaderText="Price">
                                            <ItemTemplate>
                                                <asp:Label ID="LblPRECIO" runat="server" Text='<%# String.Format("{0:f2}", Eval("Price"))%>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                        <asp:TemplateField AccessibleHeaderText="MON" FooterText="MON" HeaderText="Currency">
                                            <ItemTemplate>
                                                <asp:Label ID="LblMON" runat="server" Text='<%# Bind("Currency")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                    <HeaderStyle BackColor="#01236A" Font-Size="9pt" ForeColor="White" />
                                    <PagerSettings Mode="NextPreviousFirstLast" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="BtnArtAceptar" runat="server" CssClass="btn btn-default Button" Text="Ok" />
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>

                </div>
            </div>
        </div>
    </div>









    <div class="container">
        <div class="modal" id="myModal7">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">
                            Otro Servicio
                        </h4>
                    </div>
                    <div class="modal-body">
                        <div class="col-lg-12">
                            <div class="col-md-12">
                                <asp:Button ID="BtnOAir" runat="server" Text="Air" class="btn btn-default" />
                                <asp:Button ID="BtnOArr" runat="server" Text="Container haulage" class="btn btn-default" />
                                <asp:Button ID="BtnOArB" runat="server" Text="Container carriage" class="btn btn-default" />
                                <asp:Button ID="BtnOFCL" runat="server" Text="Full container load" class="btn btn-default" />
                                <asp:Button ID="BtnOInt" runat="server" Text="Intermodal" class="btn btn-default" />
                                <asp:Button ID="BtnOLCL" runat="server" Text="Less container load" class="btn btn-default" />
                                <asp:Button ID="BtnOLTL" runat="server" Text="Less truck load" class="btn btn-default" />
                                <asp:Button ID="BtnOTLM" runat="server" Text="Less load México" class="btn btn-default" />
                                <asp:Button ID="BtnOTLU" runat="server" Text="Less load USA" class="btn btn-default" />
                            </div>
                        </div>
                    </div>

                    <div class="modal-footer">
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

    <asp:Panel ID="PnlControl" runat="server" Visible="True">
        <a>Panel de variables de control esto va a desaparecer</a>
        <br />
        <a>Tipo de cotizacion: </a>
        <asp:Label ID="LblVTipo" runat="server"></asp:Label>
        <a> Tipo de cotizacion Secundario: </a>
        <asp:Label ID="LblVTipoS" runat="server"></asp:Label>
        <br />
        <a>Agrega Servicio:</a>
        <asp:Label ID="LblId" runat="server"></asp:Label>
        <br />
        <a>Tipo de Cargo: </a>
        <asp:Label ID="LblCargoT" runat="server" Text="Label"></asp:Label>
        <br />
        <a>Id Maritimo</a>
        <asp:Label ID="LblIdMatitimo" runat="server"></asp:Label>
        <br />
        <a>Id Aereo</a>
        
        <br />
        <a>Id Arrastre</a>
        
        <br />
        <a>Id Arrastre con BL</a>
        
        <br />
        <a>Id Terrestre</a>
        
        <br />
        <a>Finalizar Coti</a>
        
        <asp:Label ID="LblIdPricing" runat="server"></asp:Label>
        
        <br />
        <a>Autorizacion</a>
        
        <br />
        <a>Cambios</a>
        
        <br />
        <a>Correo</a>
        <asp:Label ID="LblCorreo" runat="server"></asp:Label>
        <br />
        <a>Correo</a>
        <asp:Label ID="LblAddBan" runat="server"></asp:Label>
    </asp:Panel>

    <script type="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }
    </script>

    <script type="text/javascript">
        function openModal2() {
            $('#myModal2').modal('show');
        }
    </script>

    <script type="text/javascript">
        function openModal3() {
            $('#myModal3').modal('show');
        }
    </script>

    <script type="text/javascript">
            function openModal5() {
                $('#myModal5').modal('show');
            }
    </script>

    <script type="text/javascript">
        function openModal4() {
            $('#myModal4').modal('show');
        }
    </script>

    <script type="text/javascript">
        function openModal7() {
            $('#myModal7').modal('show');
        }
    </script>


    <script type="text/javascript">
        $('[data-dismiss=modal]').on('click', function (e) {
            var $t = $(this),
                target = $t[0].href || $t.data("target") || $t.parents('.modal') || [];

            $(target)
                .find("input,textarea,select")
                .val('')
                .end()
                .find("input[type=checkbox], input[type=radio]")
                .prop("checked", "")
                .end();
            document.getElementsByClassName("modal").style.display = "none";
            document.location.href = document.location.href; 
        })
    </script>


</asp:Content>
