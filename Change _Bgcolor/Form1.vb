Public Class Form1

    Dim r, g, b As Single



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      

        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) Then
            r = TextBox1.Text
            g = TextBox2.Text
            b = TextBox3.Text

            Me.BackColor = Color.FromArgb(r Mod 255, g Mod 255, b Mod 255)
        Else
            MsgBox("Invalid input", MsgBoxStyle.Critical)
        End If




    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        r = 250
        g = 250
        b = 250

        TextBox1.Text = r
        TextBox2.Text = g
        TextBox3.Text = b

        Me.BackColor = Color.FromArgb(250, 250, 250)
    End Sub
End Class
