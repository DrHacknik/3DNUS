Imports Ionic.Zip

Public Class dev_slot_install_sel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Install.ShowDialog()
    End Sub

    Private Sub Install_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Install.FileOk
        Button2.Enabled = True
        TextBox1.Text = Install.FileName

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = True
        Label2.Text = "Installing, Please wait..."
        Try
            My.Settings.cache_state = "0"
            My.Settings.Save()

            Dim ZipToUnpack As String = Install.FileName
            Dim TargetDir As String = Application.StartupPath + "\\Extensions\\_ext\\" + ComboBox1.Text
            My.Settings.dev_debugger_logged = "Extracting file {0} to {1}" + ZipToUnpack + TargetDir
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim f As ZipEntry
                ' here, we extract every entry, but we could extract    
                ' based on entry name, size, date, etc.   
                For Each f In zip1
                    f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                Next
                Label2.Text = "Install Completed!"
                MessageBox.Show("Extension Installed!", "Install Extension:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Using
        Catch
            Label2.Text = "Install Failed!"
            MessageBox.Show("Extension Failed to Install!", "Install Extension:", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub dev_slot_install_sel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class