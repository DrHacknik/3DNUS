Imports System.IO
Public Class dev_market

    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        PictureBox2.Visible = False
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        PictureBox2.Visible = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        PictureBox2.Visible = False
    End Sub

    Private Sub dev_market_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            File.Delete(cd + "\\main.html")
            My.Computer.Network.DownloadFile(
    "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/html/main.html",
    cd + "\main.html")
            WebBrowser1.Navigate(cd + "\main.html")

        Catch
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class