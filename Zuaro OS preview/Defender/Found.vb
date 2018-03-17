Public Class Found

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainEmergency.Show()
        MainEmergency.Threats.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BringToFront()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MessageBox.Show("Are you sure? IF THESE ARE ACTIVE, IT CAN LEAD TO ANYTHING FROM UNATHOURIZED APP INSTILLATION, E-MAILING OF VIRUSES WITHOUT YOUR CONSENT, ETC. CHOOSE WISELY...", "Zuaro Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class