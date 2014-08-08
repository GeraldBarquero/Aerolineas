Imports System.Data

Namespace OBJETOS
    Public Class ObjRespuesta
#Region "Variables"

        Private _mResponseCode As Integer
        Private _mResponseMessage As String
        Private _mDsResponse As DataSet
        Private _mByteResponseObject As [Byte]()

#End Region

        Public Property ResponseCode() As Integer
            Get
                Return _mResponseCode
            End Get
            Set(ByVal value As Integer)
                _mResponseCode = value
            End Set
        End Property

        Public Property ResponseMessage() As String
            Get
                Return _mResponseMessage
            End Get
            Set(ByVal value As String)
                _mResponseMessage = value
            End Set
        End Property

        Public Property DsResponse() As DataSet
            Get
                Return _mDsResponse
            End Get
            Set(ByVal value As DataSet)
                _mDsResponse = value
            End Set
        End Property

        Public Property ByteResponseObject() As [Byte]()
            Get
                Return _mByteResponseObject
            End Get
            Set(ByVal value As [Byte]())
                _mByteResponseObject = value
            End Set
        End Property


    End Class

End Namespace
