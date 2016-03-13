Imports System.IO
Public Class extension_about

    Dim cd = My.Settings.ext_launch
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Launching"
        Timer1.Start()
    End Sub

    Private Sub extension_about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = System.IO.File.ReadAllText(My.Settings.ext_info)
        Label2.Text = System.IO.File.ReadAllText(My.Settings.ext_info)
        Label4.Text = System.IO.File.ReadAllText(My.Settings.ext_short)
        Label3.Text = System.IO.File.ReadAllText(My.Settings.ext_long)
        PictureBox1.BackgroundImage = Image.FromFile(My.Settings.ext_icon)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Try
            Process.Start(My.Settings.ext_launch + "boot_ext.exe")
            My.Settings.dev_debugger_logged = "
loaded: " + My.Settings.ext_launch + "boot_ext.exe

Started: boot_ext.framework
Listening to boot_ext.exe"
            Me.Close()
        Catch ex As Exception
            My.Settings.dev_debugger_logged = "
Error: Unable to Load Extension!
Cannot locate file at " + My.Settings.ext_launch + "
Listening dev_main"
            Button1.Text = "Launch"
            MessageBox.Show("Error: Unable to Find any Extensions in that Slot! 
                Or there is no Executable!", "Extension Manager: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)



        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Directory.Delete(cd + "\_res")
            Directory.Delete(cd + "\_bin")
            Directory.Delete(cd + "\upd")
            File.Delete(cd + "boot_ext.exe")
            My.Computer.FileSystem.WriteAllText(cd + "ext_desc.ini",
"There is No Extension Installed in 
This Slot! 
Version: ?????", True)
            My.Computer.FileSystem.WriteAllText(cd + "ext_desc_long.ini",
"", True)
            My.Computer.FileSystem.WriteAllText(cd + "ext_info.ini",
"No Extension", True)
            File.Copy(Application.StartupPath + "\Extensions\_ext\ext_icon.png", cd + "ext_icon.png")
        Catch
            MessageBox.Show("Error: There were some Problems when trying to Uninstall The Extension!", "Extension Manager: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class