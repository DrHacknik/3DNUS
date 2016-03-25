Public Class dev_config_type
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rd_express.Checked = True Then
            dev_express.Show()
            Me.Close()
        End If
        If rd_custom.Checked = True Then
            dev_custom.Show()
            Me.Close()
        End If
    End Sub
End Class