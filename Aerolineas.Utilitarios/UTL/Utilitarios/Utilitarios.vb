Imports System.IO
Imports System.IO.Compression
Imports System.Data



Namespace UTL.Utilitarios
    Public Class Utilitarios
        Public Shared Function ZipDataSet(ByVal ds As DataSet, ByVal bIgnoreSchema As Boolean) As [Byte]()

            Dim bytes As Byte()

            Using memoryStream = New MemoryStream()
                Using zipStream = New GZipStream(memoryStream, CompressionMode.Compress)

                    ds.WriteXml(zipStream, If(bIgnoreSchema, XmlWriteMode.IgnoreSchema, XmlWriteMode.WriteSchema))
                    zipStream.Close()
                End Using
                bytes = memoryStream.GetBuffer()
                memoryStream.Close()
            End Using
            Return bytes
        End Function



        Public Shared Function UnzipDataSet(ByVal bytes As [Byte]()) As DataSet
            Dim dataSet = New DataSet()

            Using memoryStream = New MemoryStream(bytes)
                Using zipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
                    dataSet.ReadXml(zipStream, XmlReadMode.Auto)
                    zipStream.Close()
                End Using
                memoryStream.Close()
            End Using
            Return dataSet
        End Function
    End Class
End Namespace


