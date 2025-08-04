Public Class frmGiftTable
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Private Sub FrmGiftTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(2)
        Label2.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(3)
        Label3.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(4)
        Label4.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(5)
        Label5.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(6)
        Label6.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(7)
        Label7.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(8)
        Label8.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(9)
        Label9.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(10)
        Label10.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(11)
        Label11.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(12)
        Label12.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(13)
        Label13.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(14)
        Label14.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(15)
        Label15.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(16)
        Label16.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(17)
        Label17.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(18)
        Label18.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(19)
        Label19.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(20)
        Label20.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(21)
        If Label1.Text <> 0 Then
            imgBox1.ImageLocation = frmMain.strGiftPath & "1.png"
        Else
            imgBox1.ImageLocation = "image\block.png"
        End If
        If Label2.Text <> 0 Then
            imgBox2.ImageLocation = frmMain.strGiftPath & "2.png"
        Else
            imgBox2.ImageLocation = "image\block.png"
        End If
        If Label3.Text <> 0 Then
            imgBox3.ImageLocation = frmMain.strGiftPath & "3.png"
        Else
            imgBox3.ImageLocation = "image\block.png"
        End If
        If Label4.Text <> 0 Then
            imgBox4.ImageLocation = frmMain.strGiftPath & "4.png"
        Else
            imgBox4.ImageLocation = "image\block.png"
        End If
        If Label5.Text <> 0 Then
            imgBox5.ImageLocation = frmMain.strGiftPath & "5.png"
        Else
            imgBox5.ImageLocation = "image\block.png"
        End If
        If Label6.Text <> 0 Then
            imgBox6.ImageLocation = frmMain.strGiftPath & "6.png"
        Else
            imgBox6.ImageLocation = "image\block.png"
        End If
        If Label7.Text <> 0 Then
            imgBox7.ImageLocation = frmMain.strGiftPath & "7.png"
        Else
            imgBox7.ImageLocation = "image\block.png"
        End If
        If Label8.Text <> 0 Then
            imgBox8.ImageLocation = frmMain.strGiftPath & "8.png"
        Else
            imgBox8.ImageLocation = "image\block.png"
        End If
        If Label9.Text <> 0 Then
            imgBox9.ImageLocation = frmMain.strGiftPath & "9.png"
        Else
            imgBox9.ImageLocation = "image\block.png"
        End If
        If Label10.Text <> 0 Then
            imgBox10.ImageLocation = frmMain.strGiftPath & "10.png"
        Else
            imgBox10.ImageLocation = "image\block.png"
        End If
        If Label11.Text <> 0 Then
            imgBox11.ImageLocation = frmMain.strGiftPath & "11.png"
        Else
            imgBox11.ImageLocation = "image\block.png"
        End If
        If Label12.Text <> 0 Then
            imgBox12.ImageLocation = frmMain.strGiftPath & "12.png"
        Else
            imgBox12.ImageLocation = "image\block.png"
        End If
        If Label13.Text <> 0 Then
            imgBox13.ImageLocation = frmMain.strGiftPath & "13.png"
        Else
            imgBox13.ImageLocation = "image\block.png"
        End If
        If Label14.Text <> 0 Then
            imgBox14.ImageLocation = frmMain.strGiftPath & "14.png"
        Else
            imgBox14.ImageLocation = "image\block.png"
        End If
        If Label15.Text <> 0 Then
            imgBox15.ImageLocation = frmMain.strGiftPath & "15.png"
        Else
            imgBox15.ImageLocation = "image\block.png"
        End If
        If Label16.Text <> 0 Then
            imgBox16.ImageLocation = frmMain.strGiftPath & "16.png"
        Else
            imgBox16.ImageLocation = "image\block.png"
        End If
        If Label17.Text <> 0 Then
            imgBox17.ImageLocation = frmMain.strGiftPath & "17.png"
        Else
            imgBox17.ImageLocation = "image\block.png"
        End If
        If Label18.Text <> 0 Then
            imgBox18.ImageLocation = frmMain.strGiftPath & "18.png"
        Else
            imgBox18.ImageLocation = "image\block.png"
        End If
        If Label19.Text <> 0 Then
            imgBox19.ImageLocation = frmMain.strGiftPath & "19.png"
        Else
            imgBox19.ImageLocation = "image\block.png"
        End If
        If Label20.Text <> 0 Then
            imgBox20.ImageLocation = frmMain.strGiftPath & "20.png"
        Else
            imgBox20.ImageLocation = "image\block.png"
        End If
    End Sub

    Private Sub frmGiftTable_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth

        For Each ctrl As Control In Controls
            ctrl.Width += ctrl.Width * RatioWidth
            ctrl.Height += ctrl.Height * RatioHeight
            ctrl.Left += ctrl.Left * RatioWidth
            ctrl.Top += ctrl.Top * RatioHeight
        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width
    End Sub
End Class