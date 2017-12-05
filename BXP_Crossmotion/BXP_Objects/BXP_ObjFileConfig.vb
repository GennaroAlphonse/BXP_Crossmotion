Public Class BXP_ObjFileConfig

    Protected oCommon As BXP_Common

#Region "Variables"

    Private sServer As String
    Private sUser As String
    Private sPass As String
    Private sDB As String
    Private bTrusted As Boolean

#End Region

#Region "Propiedades"

    Public Property Server()
        Get
            Server = sServer
        End Get
        Set(value)
            sServer = value
        End Set
    End Property

    Public Property DB
        Get
            DB = sDB
        End Get
        Set(value)
            sDB = value
        End Set
    End Property

    Public Property User
        Get
            User = sUser
        End Get
        Set(value)
            sUser = value
        End Set
    End Property

    Public Property Pass
        Get
            Pass = sPass
        End Get
        Set(value)
            sPass = value
        End Set
    End Property

    Public Property TrustedConection
        Get
            TrustedConection = bTrusted
        End Get
        Set(value)
            bTrusted = value
        End Set
    End Property

#End Region

#Region "New"

    Public Sub New()
        ReadFile()
    End Sub

#End Region

    Private Sub ReadFile()
        oCommon = New BXP_Common
        Server = oCommon.GetConfigValue("Bd_Server")
        DB = oCommon.GetConfigValue("Bd_Master")
        User = oCommon.GetConfigValue("Bd_User")
        Pass = oCommon.GetConfigValue("Bd_Pass")

        TrustedConection = False
    End Sub

End Class
