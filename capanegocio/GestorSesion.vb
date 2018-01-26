Imports System.IO

Public Class GestorSesion
    Shared Property DirArchivoSesion As String = "C:/datossesion.txt"

    Sub InicializarArchivo()
        Try
            Dim NumArchivo As Integer = FreeFile()
            FileOpen(NumArchivo, DirArchivoSesion, OpenMode.Output)
            Print(NumArchivo, "Creado: " & Now.ToString & vbCrLf)
            FileClose(NumArchivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GuardarUsuarioActual(ByVal UsuarioActual As String)
        Try
            Dim NumArchivo As Integer = FreeFile()
            FileOpen(NumArchivo, DirArchivoSesion, OpenMode.Append)
            Print(NumArchivo, "Usuario actual = " & UsuarioActual & vbCrLf)
            FileClose(NumArchivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GuardarHostName(ByVal HostName As String)
        Try
            Dim NumArchivo As Integer = FreeFile()
            FileOpen(NumArchivo, DirArchivoSesion, OpenMode.Append)
            Print(NumArchivo, "Host name = " & HostName & vbCrLf)
            FileClose(NumArchivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Shared Function CargarUsuarioActual() As String
        Try
            Using tfp As New FileIO.TextFieldParser(DirArchivoSesion)
                tfp.Delimiters = New String() {" = "}
                While Not tfp.EndOfData
                    Dim Campos As String() = tfp.ReadFields()

                    If Campos(0) = "Usuario actual" Then
                        Return Campos(1)
                    End If
                End While
                Return ""
            End Using
        Catch ex As Exception
            Throw ex
            Return ""
        End Try
    End Function

    Function CargarHostName() As String
        Try
            Using tfp As New FileIO.TextFieldParser(DirArchivoSesion)
                tfp.Delimiters = New String() {" = "}
                While Not tfp.EndOfData
                    Dim Campos As String() = tfp.ReadFields()

                    If Campos(0) = "Host name" Then
                        Return Campos(1)
                    End If
                End While
                Return ""
            End Using
        Catch ex As Exception
            Throw ex
            Return ""
        End Try
    End Function
End Class
