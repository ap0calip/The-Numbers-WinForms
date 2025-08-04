Public Class FrmWrongNumber
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub FrmWrongNumber_Click(sender As Object, e As EventArgs) Handles Me.Click
        Close()
    End Sub

    Private Sub FrmWrongNumber_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLevel1.picBk1.Visible = False
        frmLevel1.picBk2.Visible = False
        frmLevel1.picBkTotal.Visible = False
    End Sub
End Class