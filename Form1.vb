Public Class Methods
    Dim shell_ex = Shell("C:\WINDOWS\System32\notepad.exe", 1)
    Dim hwnd As Integer = Class1.FindWindow(Nothing, "Untitled - Notepad")
    Dim chwnd As Integer = Class1.FindWindowEx(hwnd, Nothing, "Edit", Nothing)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Send.Click
        If (Not hwnd = 0 And Not chwnd = 0) Then
            Class1.SetForegroundWindow(chwnd)
            Class1.SendMessageByString(chwnd, Class1.WM_SETTEXT, 0, TextBox1.Text)
        Else
            MessageBox.Show("Handler not found, check the window caption")
        End If
        TextBox1.ResetText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Not hwnd = 0 And Not chwnd = 0) Then
            Class1.SetForegroundWindow(hwnd)
            Class1.SendMessage(hwnd, Class1.WM_CLOSE, 0, 0)
            Me.Hide()
        End If
    End Sub
End Class
