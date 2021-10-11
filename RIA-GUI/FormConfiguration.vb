
Public Class FormConfiguration

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        Dim FilePath As String = Application.StartupPath & "\config.ini"
        Dim time_count_ini As String = readini(FilePath, "Setting Config", "time_count_ini", "60")
        Dim lld_ini As String = readini(FilePath, "Setting Config", "lld_ini", "80")
        Dim de_ini As String = readini(FilePath, "Setting Config", "de_ini", "50")
        value_time_count.Value = CInt(time_count_ini)
        value_lld.Value = CInt(lld_ini)
        value_de.Value = CInt(de_ini)
        checkbox_duplo.Checked = duplo
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn_setconfig_Click(sender As Object, e As EventArgs) Handles btn_setconfig.Click
        time_count = value_time_count.Value
        lld = value_lld.Value
        de = value_de.Value
        duplo = checkbox_duplo.Checked

        Dim data_send As String
        data_send = "*write_lld_de," & lld & "," & de & "#"
        'Form_Main.SerialPort.Write(data_send)
        MessageBox.Show("Parameter Telah Di Set Untuk Time Count = " & time_count.ToString & "," & " LLD = " & lld.ToString & "," & " DE = " & de.ToString)
        Dim FilePath As String = Application.StartupPath & "\config.ini"
        writeini(FilePath, "Setting Config", "time_count_ini", time_count.ToString)
        writeini(FilePath, "Setting Config", "lld_ini", lld.ToString)
        writeini(FilePath, "Setting Config", "de_ini", de.ToString)
    End Sub



    Private Sub btn_setdefault_Click(sender As Object, e As EventArgs) Handles btn_setdefault.Click
        Dim FilePath As String = Application.StartupPath & "\config.ini"
        Dim time_count_ini As String = readini(FilePath, "Default", "time_count_ini", "60")
        Dim lld_ini As String = readini(FilePath, "Default", "lld_ini", "80")
        Dim de_ini As String = readini(FilePath, "Default", "de_ini", "50")
        value_time_count.Value = CInt(time_count_ini)
        value_lld.Value = CInt(lld_ini)
        value_de.Value = CInt(de_ini)
        checkbox_duplo.Checked = duplo

        Dim data_send As String
        data_send = "*write_lld_de," & lld & "," & de & "#"
        'Form_Main.SerialPort.Write(data_send)
        Dim replymsgbox = MessageBox.Show("Parameter Telah Di Set Untuk Time Count = " & time_count.ToString & "," & " LLD = " & lld.ToString & "," & " DE = " & de.ToString)



    End Sub
End Class