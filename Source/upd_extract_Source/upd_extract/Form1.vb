Imports System.IO
Imports Ionic.Zip

Public Class Form1
    Dim cd = Application.StartupPath

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("You can't close the Updater when it's Updating!", "3DNUS Updater Lite: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play(cd + "\\sds\\upd_bck_music.wav",
        '  AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = cd + "\\sds\\upd_bck_music.mp3"


        NotifyIcon1.ShowBalloonTip(10)
        Label2.Text = "Installing Updates..."
        Dim proc = Process.GetProcessesByName("3DNUS")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i
        Dim proc2 = Process.GetProcessesByName("3DNUS Updater - Lite")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i
        Try
            Dim ZipToUnpack As String = "3DNUS.Update.zip"
            Dim TargetDir As String = Application.StartupPath + "\\Update_Latest"

            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim f As ZipEntry
                ' here, we extract every entry, but we could extract    
                ' based on entry name, size, date, etc.   
                For Each f In zip1
                    f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)

                Next

            End Using
        Catch
        End Try
        Try
            Try
                Dim ZipToUnpack As String = "3DNUS.Update_x86.zip"
                Dim TargetDir As String = Application.StartupPath + "\\Update_Latest_x86"

                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    Dim f As ZipEntry
                    ' here, we extract every entry, but we could extract    
                    ' based on entry name, size, date, etc.   
                    For Each f In zip1
                        f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)

                    Next

                End Using

            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try

        Dim sourceDirectory As String = Application.StartupPath + "\\Update_Latest\\"
        Dim destinationDirectory As String = Application.StartupPath

        Try
            Directory.Move(sourceDirectory, destinationDirectory)
        Catch g As Exception

        End Try
        Dim sd As String = Application.StartupPath + "\\Update_Latest_x86\\"
        Dim dd As String = Application.StartupPath

        Try
            Directory.Move(sourceDirectory, destinationDirectory)
        Catch g As Exception
            'Label2.Text = "Installing Updates...100%"
        End Try

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            NotifyIcon1.Text = "3DNUS: Playing the Awesome Music!"
            Me.Hide()
        Else
            End
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub
End Class
