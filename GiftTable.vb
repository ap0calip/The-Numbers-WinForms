Public Class frmGiftTable
    'Variables para agrandar componentes segun tamaño de la ventana
    Dim CuRHeight As Integer = Me.Height
    Dim CuRWidth As Integer = Me.Width

    Private Sub FrmGiftTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataBaseDataSet.UserTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.UserDataBaseDataSet.UserTable)
        UserTableBindingSource.Position = FrmLogin.inc
        If frmMain.strGender = "Boy" Then
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(2) <> 0 Then
                imgBox1.Image = TheNumbers.My.Resources.boy1
            Else
                imgBox1.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(3) <> 0 Then
                imgBox2.Image = TheNumbers.My.Resources.boy2
            Else
                imgBox2.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(4) <> 0 Then
                imgBox3.Image = TheNumbers.My.Resources.boy3
            Else
                imgBox3.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(5) <> 0 Then
                imgBox4.Image = TheNumbers.My.Resources.boy4
            Else
                imgBox4.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(6) <> 0 Then
                imgBox5.Image = TheNumbers.My.Resources.boy5
            Else
                imgBox5.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(7) <> 0 Then
                imgBox6.Image = TheNumbers.My.Resources.boy6
            Else
                imgBox6.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(8) <> 0 Then
                imgBox7.Image = TheNumbers.My.Resources.boy7
            Else
                imgBox7.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(9) <> 0 Then
                imgBox8.Image = TheNumbers.My.Resources.boy8
            Else
                imgBox8.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(10) <> 0 Then
                imgBox9.Image = TheNumbers.My.Resources.boy9
            Else
                imgBox9.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(11) <> 0 Then
                imgBox10.Image = TheNumbers.My.Resources.boy10
            Else
                imgBox10.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(12) <> 0 Then
                imgBox11.Image = TheNumbers.My.Resources.boy11
            Else
                imgBox11.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(13) <> 0 Then
                imgBox12.Image = TheNumbers.My.Resources.boy12
            Else
                imgBox12.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(14) <> 0 Then
                imgBox13.Image = TheNumbers.My.Resources.boy13
            Else
                imgBox13.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(15) <> 0 Then
                imgBox14.Image = TheNumbers.My.Resources.boy14
            Else
                imgBox14.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(16) <> 0 Then
                imgBox15.Image = TheNumbers.My.Resources.boy15
            Else
                imgBox15.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(17) <> 0 Then
                imgBox16.Image = TheNumbers.My.Resources.boy16
            Else
                imgBox16.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(18) <> 0 Then
                imgBox17.Image = TheNumbers.My.Resources.boy17
            Else
                imgBox17.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(19) <> 0 Then
                imgBox18.Image = TheNumbers.My.Resources.boy18
            Else
                imgBox18.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(20) <> 0 Then
                imgBox19.Image = TheNumbers.My.Resources.boy19
            Else
                imgBox19.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(21) <> 0 Then
                imgBox20.Image = TheNumbers.My.Resources.boy20
            Else
                imgBox20.Image = TheNumbers.My.Resources.block
            End If
        Else
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(2) <> 0 Then
                imgBox1.Image = TheNumbers.My.Resources.girl1
            Else
                imgBox1.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(3) <> 0 Then
                imgBox2.Image = TheNumbers.My.Resources.girl2
            Else
                imgBox2.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(4) <> 0 Then
                imgBox3.Image = TheNumbers.My.Resources.girl3
            Else
                imgBox3.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(5) <> 0 Then
                imgBox4.Image = TheNumbers.My.Resources.girl4
            Else
                imgBox4.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(6) <> 0 Then
                imgBox5.Image = TheNumbers.My.Resources.girl5
            Else
                imgBox5.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(7) <> 0 Then
                imgBox6.Image = TheNumbers.My.Resources.girl6
            Else
                imgBox6.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(8) <> 0 Then
                imgBox7.Image = TheNumbers.My.Resources.girl7
            Else
                imgBox7.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(9) <> 0 Then
                imgBox8.Image = TheNumbers.My.Resources.girl8
            Else
                imgBox8.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(10) <> 0 Then
                imgBox9.Image = TheNumbers.My.Resources.girl9
            Else
                imgBox9.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(11) <> 0 Then
                imgBox10.Image = TheNumbers.My.Resources.girl10
            Else
                imgBox10.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(12) <> 0 Then
                imgBox11.Image = TheNumbers.My.Resources.girl11
            Else
                imgBox11.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(13) <> 0 Then
                imgBox12.Image = TheNumbers.My.Resources.girl12
            Else
                imgBox12.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(14) <> 0 Then
                imgBox13.Image = TheNumbers.My.Resources.girl13
            Else
                imgBox13.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(15) <> 0 Then
                imgBox14.Image = TheNumbers.My.Resources.girl14
            Else
                imgBox14.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(16) <> 0 Then
                imgBox15.Image = TheNumbers.My.Resources.girl15
            Else
                imgBox15.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(17) <> 0 Then
                imgBox16.Image = TheNumbers.My.Resources.girl16
            Else
                imgBox16.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(18) <> 0 Then
                imgBox17.Image = TheNumbers.My.Resources.girl17
            Else
                imgBox17.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(19) <> 0 Then
                imgBox18.Image = TheNumbers.My.Resources.girl18
            Else
                imgBox18.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(20) <> 0 Then
                imgBox19.Image = TheNumbers.My.Resources.girl19
            Else
                imgBox19.Image = TheNumbers.My.Resources.block
            End If
            If UserDataBaseDataSet.Tables("UserTable").Rows(FrmLogin.inc).Item(21) <> 0 Then
                imgBox20.Image = TheNumbers.My.Resources.girl20
            Else
                imgBox20.Image = TheNumbers.My.Resources.block
            End If
        End If
    End Sub

    Private Sub FrmGiftTable_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    Private Sub FrmGiftTable_Click(sender As Object, e As EventArgs) Handles MyBase.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label19.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click, imgBox9.Click, imgBox8.Click, imgBox7.Click, imgBox6.Click, imgBox5.Click, imgBox4.Click, imgBox3.Click, imgBox2.Click, imgBox19.Click, imgBox18.Click, imgBox17.Click, imgBox16.Click, imgBox15.Click, imgBox14.Click, imgBox13.Click, imgBox12.Click, imgBox11.Click, imgBox10.Click, imgBox1.Click
        Close()
    End Sub
End Class