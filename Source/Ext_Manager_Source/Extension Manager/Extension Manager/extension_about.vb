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
        Try
            Label1.Text = System.IO.File.ReadAllText(My.Settings.ext_info)
            Label2.Text = System.IO.File.ReadAllText(My.Settings.ext_info)
            Label4.Text = System.IO.File.ReadAllText(My.Settings.ext_short)
            Label3.Text = System.IO.File.ReadAllText(My.Settings.ext_long)
            PictureBox1.BackgroundImage = Image.FromFile(My.Settings.ext_icon)
        Catch
            MessageBox.Show("There seems to be No Extension Files within the Slot you Selected.", "Extension Manager: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(
   My.Settings.ext_launch,
    Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")

                My.Computer.FileSystem.DeleteFile(foundFile,
                    Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                    Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently)
            Next

        Catch
            MessageBox.Show("Error: There were some Problems when trying to Uninstall The Extension!", "Extension Manager: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class