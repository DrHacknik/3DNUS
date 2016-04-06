Imports System.IO
Public Class dev_market

    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs)

    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

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
            My.Computer.Network.DownloadFile(
 "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/html/banner/featured/icon_banner_featured.png",
 cd + "\featured.png")
            My.Computer.Network.DownloadFile(
 "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/html/banner/featured/icon_banner_featured.png",
 cd + "\featured.png")
            banner.Image = Image.FromFile(cd + "\featured.png")
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

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs)

    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click

    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click

    End Sub

    Private Sub downloads_Click(sender As Object, e As EventArgs) Handles downloads.Click
        dev_download_manager.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_2(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub WebBrowser1_ProgressChanged_1(sender As Object, e As WebBrowserProgressChangedEventArgs)
        dl_progress.Width += 1
        If dl_progress.Width = 42 Then
            dl_progress.Width = 1
        End If
    End Sub

    Private Sub WebBrowser1_Navigating_2(sender As Object, e As WebBrowserNavigatingEventArgs)

    End Sub

    Private Sub WebBrowser1_Navigated_2(sender As Object, e As WebBrowserNavigatedEventArgs)

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        My.Computer.Network.DownloadFile(
   "https://github.com/zoltx23/3DNUS/blob/master/ext_market/packages/tools/@dr_hacknik/citra_emu/citra.zip?raw=true",
   cd + "\Downloads\citra.zip")
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        My.Computer.Network.DownloadFile(
"https://github.com/zoltx23/3DNUS/blob/master/ext_market/packages/tools/@dr_hacknik/devkit/devkit.zip?raw=true",
cd + "\Downloads\devkit.zip")
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        My.Computer.Network.DownloadFile(
"https://github.com/zoltx23/3DNUS/blob/master/ext_market/packages/tools/@dr_hacknik/nandify/nandify.zip?raw=true",
cd + "\Downloads\nandify.zip")
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        My.Computer.Network.DownloadFile(
"https://github.com/zoltx23/3DNUS/blob/master/ext_market/packages/tools/@dr_hacknik/nand_tool/nand_tool.zip?raw=true",
cd + "\Downloads\nand_tool.zip")

    End Sub
End Class