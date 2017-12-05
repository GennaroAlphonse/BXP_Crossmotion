'------------------------------------------------------------------------------
' <generado automáticamente>
'     Este código fue generado por una herramienta.
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código. 
' </generado automáticamente>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class BXP_Cotizacion
    
    '''<summary>
    '''Control TxtFolio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFolio As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtEmpresa.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresa As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtEmpresaCodigo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresaCodigo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control HFEmpresa.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents HFEmpresa As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control TxtContacto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtContacto As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtDescripcion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtDescripcion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtProducto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtProducto As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control DdlTipoCotizacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DdlTipoCotizacion As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control DivAlertSuccess.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivAlertSuccess As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblSuccess.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblSuccess As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control DivAlertInfo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivAlertInfo As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblInfo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblInfo As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control DivAlertWarning.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivAlertWarning As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblWarning.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblWarning As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control TxtFechaDesde.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFechaDesde As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control CalendarDesde.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CalendarDesde As Global.System.Web.UI.WebControls.Calendar
    
    '''<summary>
    '''Control BtnFechaDesde.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnFechaDesde As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control TxtFechaAl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFechaAl As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control CalendarAl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CalendarAl As Global.System.Web.UI.WebControls.Calendar
    
    '''<summary>
    '''Control BtnFechaAl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnFechaAl As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control DropDownList1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DropDownList1 As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control DdlCur.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DdlCur As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control DdlIncoterm.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DdlIncoterm As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control DdlKind.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DdlKind As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control DdlServ.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DdlServ As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control LblInterNacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblInterNacion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control LblTipo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblTipo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control LblTitulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblTitulo As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control PNLGVSerAer.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerAer As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control GVSerAer.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GVSerAer As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PNLGVSerArr.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerArr As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control GVSerArr.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GVSerArr As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PNLGVSerMar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerMar As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control GVSerMar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GVSerMar As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PNLGVSerArB.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerArB As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control GVSerArB.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GVSerArB As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PNLGVSerMarLCL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerMarLCL As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control GVSerMarLCL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GVSerMarLCL As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PNLGVSerInt.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerInt As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control GVSerInt.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GVSerInt As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PNLGVSerLTL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerLTL As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control GVSerLTL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GVSerLTL As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PNLGVSerTLM.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerTLM As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control PNLGVSerTLU.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLGVSerTLU As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control PNLBT.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLBT As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control BtnAgregarPartida.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnAgregarPartida As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnEliminarPartida.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnEliminarPartida As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnEliminarTodo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnEliminarTodo As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnAgregarServicio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnAgregarServicio As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control Button3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Button3 As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control DivCargos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivCargos As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control DivCargosOrigen.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivCargosOrigen As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblCarO.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCarO As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control GvCarOri.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvCarOri As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control BtnCarOAdd.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnCarOAdd As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnCarODel.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnCarODel As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control DivCargosDestino.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivCargosDestino As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblCarD.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCarD As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control GvCarDes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvCarDes As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control BtnCarDAdd.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnCarDAdd As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnCarDDel.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnCarDDel As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control PNLCotizacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PNLCotizacion As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control BtnGuardarCot.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarCot As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnEnviarCot.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnEnviarCot As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control LblAddTitulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblAddTitulo As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control DdlServicio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DdlServicio As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control DdlServiceDetails.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DdlServiceDetails As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtPOL_Country.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtPOL_Country As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtCodePOL_Country.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCodePOL_Country As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control HiddenField2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents HiddenField2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control TxtPOD_Country.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtPOD_Country As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtCodePOD_Country.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCodePOD_Country As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control HiddenField3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents HiddenField3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control TextBox10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TextBox10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TextBox11.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TextBox11 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control HiddenField1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents HiddenField1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control TextBox12.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TextBox12 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TextBox13.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TextBox13 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control HiddenField4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents HiddenField4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control GvBusAer.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusAer As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusArr.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusArr As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusArB.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusArB As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusInt.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusInt As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusMar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusMar As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusMul.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusMul As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusTer.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusTer As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusTerA.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusTerA As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusMarLCL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusMarLCL As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control GvBusLTL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvBusLTL As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control Lbl_Error_AddSer.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Lbl_Error_AddSer As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control Button1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Button1 As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control LblTituloSolicitud.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblTituloSolicitud As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control tarifarioarrastres.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents tarifarioarrastres As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control carrier7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents carrier7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control origin5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents origin5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idorigin5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idorigin5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hforigin5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hforigin5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control polcountry10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode10 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry10 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol10 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol_zipcode6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol_zipcode6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control destination5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents destination5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control iddestination5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents iddestination5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfdestination5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfdestination5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control podcountry10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcountrycode10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountrycode10 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry10 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idpod10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idpod10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod10 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod_zipcode6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod_zipcode6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control service.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents service As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control equipment6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents equipment6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idequipment6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idequipment6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfequipment6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfequipment6 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control remarks10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control currency7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents currency7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control volume2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents volume2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control commodity10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity10 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control singleweight.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents singleweight As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control tandemweight.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents tandemweight As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control tarifarioAir.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents tarifarioAir As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control polcountry7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode7 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry7 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol7 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control podcountry7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcountrycode7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountrycode7 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry7 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod7 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control un4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents un4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control class4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents class4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control remarks7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control commodity7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control packing4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents packing4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control number3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents number3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control weight5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents weight5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control measures4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents measures4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stackable4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stackable4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control incoterm2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents incoterm2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control urgent.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents urgent As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control maritimocompleto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents maritimocompleto As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control carrier1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents carrier1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control pol1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control namepolcountry.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents namepolcountry As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control namepodcountry.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents namepodcountry As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control equipment.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents equipment As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control un.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents un As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control class7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents class7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control commodity1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control remarks1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control cargoweight.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cargoweight As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control incoterm.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents incoterm As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control packing1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents packing1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control number.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents number As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control measures1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents measures1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stackable1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stackable1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control ltlamericanonacional.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents ltlamericanonacional As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control carrier2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents carrier2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control origin1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents origin1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idorigin1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idorigin1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hforigin1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hforigin1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control polcountry1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control polzipcode1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polzipcode1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control destination1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents destination1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control iddestination1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents iddestination1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfdestination1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfdestination1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control podcountry1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcodecountry1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcodecountry1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod_zipcode1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod_zipcode1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control type.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents type As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control commodity2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control remarks2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control weight.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents weight As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control measures.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents measures As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control volume.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents volume As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stackable.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stackable As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control currency.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents currency As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control packing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents packing As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control quantity.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents quantity As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stops.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stops As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control ltlintermodal.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents ltlintermodal As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control carrier3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents carrier3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control origin2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents origin2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idorigin2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idorigin2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hforigin2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hforigin2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control originramp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents originramp As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idoriginramp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idoriginramp As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hforiginramp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hforiginramp As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control polcountry3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol_zipcode2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol_zipcode2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control destination2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents destination2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control iddestination2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents iddestination2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfdestination2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfdestination2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control destinationramp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents destinationramp As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control iddestinationramp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents iddestinationramp As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfdestinationramp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfdestinationramp As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control podcountry2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcodecountry2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcodecountry2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod_zipcode2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod_zipcode2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control currency1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents currency1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control un1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents un1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control class1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents class1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control equipment1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents equipment1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idequipment1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idequipment1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfequipment1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfequipment1 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control commodity3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control remarks3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control weight2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents weight2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control measures5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents measures5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stackable5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stackable5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control packing5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents packing5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control maritimolcl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents maritimolcl As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control coloader.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents coloader As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountry4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control podcountry4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcountrycode4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountrycode4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control via1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents via1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control via2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents via2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control via3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents via3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control currency2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents currency2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control cost.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cost As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control minimumcost.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents minimumcost As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control equipment2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents equipment2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idequipment2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idequipment2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfequipment2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfequipment2 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control commodity4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control un2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents un2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control class2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents class2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control bl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents bl As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control remarks4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control weight3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents weight3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control incoterm1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents incoterm1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control packing2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents packing2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control number2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents number2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control measures2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents measures2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stackable2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stackable2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control terrestrenacional.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents terrestrenacional As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control carrier4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents carrier4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control origin3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents origin3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idorigin3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idorigin3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hforigin3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hforigin3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control polcountry5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol_zipcode3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol_zipcode3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control destination3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents destination3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control iddestination3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents iddestination3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfdestination3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfdestination3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control podcountry5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcountrycode5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountrycode5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod_zipcode3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod_zipcode3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stop1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stop1 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stop2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stop2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stop3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stop3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control un3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents un3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control class3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents class3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control equipment3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents equipment3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idequipment3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idequipment3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfequipment3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfequipment3 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control remarks5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control weight4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents weight4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control measures3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents measures3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control stackable3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents stackable3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control currency3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents currency3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control packing3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents packing3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control commodity5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control arrastrebl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents arrastrebl As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control polcountry8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode8 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry8 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol8 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol_zipcode4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol_zipcode4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcountry8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcountrycode8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountrycode8 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry8 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod8 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod_zipcode4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod_zipcode4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control veintegp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents veintegp As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control cuarentagp.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cuarentagp As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control cuarentahq2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cuarentahq2 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control equipment4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents equipment4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idequipment4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idequipment4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfequipment4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfequipment4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control mode.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents mode As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control singlefull.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents singlefull As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control un5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents un5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control class5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents class5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control remarks8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control commodity8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity8 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control currency5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents currency5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control weight6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents weight6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control tarifarioamericano.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents tarifarioamericano As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control carrier6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents carrier6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control origin4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents origin4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idorigin4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idorigin4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hforigin4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hforigin4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcode9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcode9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpol9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpol9 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control polcountry9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountry9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control polcountrycode9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents polcountrycode9 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpolcountry9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpolcountry9 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pol_zipcode5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pol_zipcode5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control destination4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents destination4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control iddestination4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents iddestination4 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfdestination4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfdestination4 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcode9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcode9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfpod9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpod9 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control podcountry9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountry9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control podcountrycode9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents podcountrycode9 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control hfpodcountry9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfpodcountry9 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control pod_zipcode5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pod_zipcode5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control equipment5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents equipment5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control idequipment5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idequipment5 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control hfequipment5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents hfequipment5 As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''Control directtranshipment.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents directtranshipment As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control un6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents un6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control class6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents class6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control remarks9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents remarks9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control currency6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents currency6 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control volume3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents volume3 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control weight7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents weight7 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control commodity9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents commodity9 As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control DivSuccessPricing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivSuccessPricing As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblSuccessPricing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblSuccessPricing As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control DivInfoPricing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivInfoPricing As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblInfoPricing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblInfoPricing As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control DivWarningPricing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DivWarningPricing As Global.System.Web.UI.HtmlControls.HtmlGenericControl
    
    '''<summary>
    '''Control LblWarningPricing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblWarningPricing As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control Button2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Button2 As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control Label1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Label1 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control TxtCorreo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCorreo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtAsunto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtAsunto As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtCuerpo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCuerpo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control Button4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Button4 As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control Label2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Label2 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control Label3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Label3 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control TxtArtCodigo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtArtCodigo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnArtBuscarCodigo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnArtBuscarCodigo As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control TxtArtNombre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtArtNombre As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnArtBuscarNombre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnArtBuscarNombre As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnArtMostrarTodo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnArtMostrarTodo As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control GvArticulos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GvArticulos As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control BtnArtAceptar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnArtAceptar As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOAir.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOAir As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOArr.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOArr As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOArB.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOArB As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOFCL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOFCL As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOInt.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOInt As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOLCL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOLCL As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOLTL.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOLTL As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOTLM.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOTLM As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnOTLU.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnOTLU As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control PnlControl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PnlControl As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control LblVTipo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblVTipo As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LblVTipoS.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblVTipoS As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LblId.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblId As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LblCargoT.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCargoT As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LblIdMatitimo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblIdMatitimo As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LblIdPricing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblIdPricing As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LblCorreo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCorreo As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LblAddBan.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblAddBan As Global.System.Web.UI.WebControls.Label
End Class
