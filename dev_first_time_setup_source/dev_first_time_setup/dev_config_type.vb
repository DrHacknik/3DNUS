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

    Private Sub dev_config_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Button1.Text = "Siguiente"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Button1.Text = "Siguiente"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Button1.Text = "Siguiente"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Tipo config"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Tipo config"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Tipo config"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label2.Text = "¿Qué tipo de configuración debemos utilizar?"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label2.Text = "¿Qué tipo de configuración debemos utilizar?"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label2.Text = "¿Qué tipo de configuración debemos utilizar?"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label5.Text = "Me llegar a 3DNUS lo más rápido posible! 
La configuración recomendada de uso."
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label5.Text = "Me llegar a 3DNUS lo más rápido posible! 
La configuración recomendada de uso."
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label5.Text = "Me llegar a 3DNUS lo más rápido posible! 
La configuración recomendada de uso."
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            rd_express.Text = "Usar configuración rápida"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            rd_express.Text = "Usar configuración rápida"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            rd_express.Text = "Usar configuración rápida"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label4.Text = "Ajustes personalizados:"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label4.Text = "Ajustes personalizados:"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label4.Text = "Ajustes personalizados:"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label6.Text = "Tómese su tiempo , y personalizar la configuraciónA tu gusto. 
Use su mayoría de valores predeterminados"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label6.Text = "Tómese su tiempo , y personalizar la configuraciónA tu gusto. 
Use su mayoría de valores predeterminados."
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label6.Text = "Tómese su tiempo , y personalizar la configuraciónA tu gusto. 
Use su mayoría de valores predeterminados"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            rd_custom.Text = "Usar una configuración personalizada"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            rd_custom.Text = "Usar una configuración personalizada"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            rd_custom.Text = "Usar una configuración personalizada"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label3.Text = "Ajustes express:"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label3.Text = "Ajustes express:"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label3.Text = "Ajustes express:"
        End If
    End Sub
End Class