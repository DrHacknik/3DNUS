Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
        'You can change the "\_bin\citra-qt.exe" path to a different file name. This launcher helps alot 
        'if the app your using, updates itself. But, the Description files must be Changed manually. 
            Process.Start(Application.StartupPath + "\_bin\citra-qt.exe")
            End
        Catch
            Return
        End Try

    End Sub
End Class
