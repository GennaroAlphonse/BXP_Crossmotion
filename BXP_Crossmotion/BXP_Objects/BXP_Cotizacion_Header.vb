Public Class BXP_Cotizacion_Header

    Public Property Id As String
    Public Property Fecha As Date
    Public Property Hora As Date
    Public Property U_FolioCrossmotion As String
    Public Property CardCode As String
    Public Property CardName As String
    Public Property CntctPrsn As String
    Public Property U_DESCRIPCION As String
    Public Property U_PRODUCTO As String
    Public Property U_BXP_MET_TRANSPORT_CODE As String
    Public Property U_BXP_MET_TRANSPORT_NAME As String
    Public Property VALIDITY_FROM As Date
    Public Property VALIDITY_TO As Date
    Public Property CODE_SOCIETY As String
    Public Property NAME_SOCIETY As String
    Public Property CurrCode As String
    Public Property CurrName As String
    Public Property IncotermCode As String
    Public Property IncotermName As String
    Public Property KindCode As String
    Public Property KindName As String
    Public Property ServiceCode As String
    Public Property ServiceName As String
    Public Property NacInte As String
    Public Property ImpoExpo As String
    Public Property TypeService As String
    Public Property bError As Boolean
    Public Property sError As String
    Public Property Serie As Integer
    Public Property bSAPCOT As Boolean

    Public Property oLineas As Collections.Generic.List(Of BXP_Cotizacion_Details)

End Class
