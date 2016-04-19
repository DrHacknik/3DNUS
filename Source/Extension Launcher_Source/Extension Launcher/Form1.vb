Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Process.Start(Application.StartupPath + "\_bin\citra-qt.exe")
            End
        Catch
            Return
        End Try

    End Sub
End Class
