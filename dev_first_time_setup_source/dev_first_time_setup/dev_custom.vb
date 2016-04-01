Public Class dev_custom
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox5.CheckedChanged, CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Save Configurations & Close, then Start 3DNUS. 

        dev_custom_finish.Show()
        Me.Hide()
    End Sub

    Private Sub dev_custom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Ajustes personalizados"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Ajustes personalizados"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Ajustes personalizados"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label2.Text = "Configuración de dejar que los ajustes 
personalizados ."
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label2.Text = "Configuración de dejar que los ajustes 
personalizados ."
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label2.Text = "Configuración de dejar que los ajustes 
personalizados ."
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label3.Text = "Los basicos:"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label3.Text = "Los basicos:"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label3.Text = "Los basicos:"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Button1.Text = "Terminar"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Button1.Text = "Terminar"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Button1.Text = "Terminar"
        End If
    End Sub
End Class