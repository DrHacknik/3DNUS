Imports System.Deployment.Application
Imports System.IO
Imports System.Net
Imports Ionic.Zip

Public Class Form1
    Dim cd = Path.GetDirectoryName(Application.ExecutablePath)
    Dim info As UpdateCheckInfo = Nothing
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        File.Delete(Path.Combine(cd, "Update_Info.txt"))
        File.Delete(Path.Combine(cd, "Update_URI.txt"))
        File.Delete(Path.Combine(cd, "Update_Latest.zip"))
        Try
            My.Computer.Network.DownloadFile(
    "https://raw.githubusercontent.com/zoltx23/3DNUS/master/Update_Info.txt",
    Path.Combine(cd, "Update_Info.txt"))

            File.ReadAllLines(Path.Combine(cd + "Ver_info.txt"))
            My.Computer.Network.DownloadFile(
    "https://raw.githubusercontent.com/zoltx23/3DNUS/master/Update_Package_URI",
    Path.Combine(cd, "Update_URI.txt"))
        Catch
            MessageBox.Show("It seems that we Couldn't get the Latest Update Information Files!
Please try again Later!", "3DNUS Updater - Lite: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Hide()
        Dim ver = File.ReadAllText(Path.Combine(cd, "Ver_info.txt"))
        Label2.Text = ver
        Dim upd = File.ReadAllText(Path.Combine(cd, "Update_info.txt"))
        Dim htp = New WebClient

        Try

            If Label2.Text = upd Then
                NotifyIcon1.BalloonTipText = "There are No Updates Available! Although, the Updater will check every Hour.  "
                NotifyIcon1.ShowBalloonTip(5)
                Timer1.Start()
                Me.WindowState = FormWindowState.Minimized
            Else

                Dim URI = File.ReadAllText(Path.Combine(cd, "Update_URI.txt"))
                Timer1.Start()
                NotifyIcon1.BalloonTipText = "An Update is Available, it will Automatically be Downloaded and Installed. "
                NotifyIcon1.ShowBalloonTip(5)
                My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/3DNUS.Update.zip", "3DNUS.Update.zip")
                Me.WindowState = FormWindowState.Minimized
                Timer2.Start()
            End If
        Catch
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Application.Restart()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        NotifyIcon1.BalloonTipText = "The Update has been Downloaded! You must manually extract the Zip file for Now.  "
        NotifyIcon1.ShowBalloonTip(5)
        Timer2.Stop()
        Process.Start(Path.Combine(cd, "upd_extract.exe"))
        Timer1.Start()
    End Sub

    Private Sub Repair3DNUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Repair3DNUSToolStripMenuItem.Click

        Timer1.Start()
        NotifyIcon1.BalloonTipText = "A Fresh Update Package will be Downloaded, please Wait.... "
        NotifyIcon1.ShowBalloonTip(5)
        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/3DNUS.Update.zip", "3DNUS_Repair_Update.zip")
    End Sub
End Class