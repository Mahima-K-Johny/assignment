Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
        ElseIf PictureBox2.Visible = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        ElseIf PictureBox3.Visible = True Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = 3000
        Timer1.Start()
        Button1.Enabled = False

    End Sub
End Class
