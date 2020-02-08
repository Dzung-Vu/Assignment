Public Class Class1
#Region "Methods and Functions"
    Public Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Int32
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Public Declare Function FindWindowEx Lib "user32.dll" Alias "FindWindowExA" (ByVal hwnd1 As Int32, ByVal hwnd2 As Int32, ByVal lpszl1 As String, ByVal lpszl2 As String) As Int32
    Public Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32
    Public Declare Function SendMessageByString Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As String) As Int32
    Public Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As System.Text.StringBuilder) As Int32
#End Region
#Region "Message"
    Public Const WM_SETTEXT As Int32 = &HC
    Public Const WM_GETTEXT As Int32 = &HD
    Public Const WM_GETTEXTLENGTH As Int32 = &HE
    Public Const WM_CLOSE = &H10

#End Region
End Class
