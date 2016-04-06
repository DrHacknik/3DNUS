Imports System.IO
Public Class dev_market

    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs)
        PictureBox2.Visible = False
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)
        PictureBox2.Visible = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        PictureBox2.Visible = False
    End Sub

    Private Sub dev_market_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Download the HTML Files & Save them. 
        Try
            File.Delete(cd + "\\main.html")
            File.Delete(cd + "\\404_Not_Found.html")
            My.Computer.Network.DownloadFile(
    "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/html/main.html",
    cd + "\main.html")
            My.Computer.Network.DownloadFile(
    "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/html/404_Not_Found.html",
    cd + "\404_Not_Found.html")
            WebBrowser1.Navigate(cd + "/main.html")


        Catch
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebView1_DownloadCompleted(sender As Object, e As EO.WebBrowser.DownloadEventArgs)

    End Sub

    Private Sub WebView1_LoadCompleted(sender As Object, e As EO.WebBrowser.LoadCompletedEventArgs)

    End Sub

    Private Sub WebView1_UrlChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebView1_IsLoadingChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        dl_progress.Width += 1
        If dl_progress.Width = 42 Then
            dl_progress.Width = 1
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        PictureBox2.Visible = False
    End Sub

    Private Sub WebBrowser1_Navigated_1(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        PictureBox2.Visible = False
    End Sub

    Private Sub WebBrowser1_Navigating_1(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        PictureBox2.Visible = True
    End Sub
End Class