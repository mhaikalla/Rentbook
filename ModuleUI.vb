Module ModuleUI
    Dim i As Integer = 1


    ''Function Untuk membuat hint text pada suatu textbox
    Private Declare Function GetWindow Lib "user32.dll" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
    Private Declare Auto Function SendMessageString Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
    Const GW_CHILD = 5
    Const EM_SETCUEBANNER = &H1501

    Sub SetHintText(ByVal Ctl As TextBox, ByVal Txt As String)
        SendMessageString(Ctl.Handle, EM_SETCUEBANNER, 1, Txt)
    End Sub

    Sub SetHintText(ByVal Ctl As ComboBox, ByVal Txt As String)
        Dim i As Integer
        i = GetWindow(Ctl.Handle, GW_CHILD)
        SendMessageString(i, EM_SETCUEBANNER, 1, Txt)
    End Sub
    ''===========================================================================================
    Public Sub setNotification(notifText As String, Optional ByVal ikon As Image = Nothing)
        MainForm.Panel_Notif.Show()
        MainForm.NotifText.Text = notifText
        MainForm.Ikon_Notif.Image = ikon
        MainForm.Timer1.Start()
    End Sub


End Module
