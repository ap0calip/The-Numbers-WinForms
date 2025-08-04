Public Class frmLogin

    Private Sub UpdateCB()
        Dim index As Integer = 0
        cbUser.Items.Clear()
        index = 0
        While index < frmMain.MaxRows
            cbUser.Items.Add(frmMain.ds.Tables("Users").Rows(index).Item(1))
            index = index + 1
        End While
    End Sub

    'Buscar usuario en base de datos
    Private Sub FindUser()
        frmMain.inc = 0
        While frmMain.inc < frmMain.MaxRows
            If frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(1) = cbUser.Text Then
                Exit While
            End If
            frmMain.inc = frmMain.inc + 1
        End While
    End Sub

    'Cambia User en statusbar y direccion de Gift
    Private Sub PersonalizeMain()
        frmMain.stbName.Text = "User: " & frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(1)
        frmMain.strGiftPath = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(22) & "Gift\"
    End Sub

    'Colocar ID en la base de datos
    Function FillID() As Integer
        Dim id As Integer = 0
        Dim index As Integer = 0
        While index < frmMain.MaxRows
            If frmMain.ds.Tables("Users").Rows(index).Item(0) >= id Then
                id = frmMain.ds.Tables("Users").Rows(index).Item(0) + 1
            End If
            index = index + 1
        End While
        Return id
    End Function

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbUser.Text <> "" Then
            If cbUser.SelectedIndex = -1 And frmMain.MaxRows > 0 Then
                FindUser()
            End If
            If frmMain.inc > -1 And frmMain.inc < frmMain.MaxRows Then
                PersonalizeMain()
                Close()
            Else
                If MessageBox.Show("User " & cbUser.Text & " not found. Do you like add this user?", "Login", MessageBoxButtons.YesNo) = 6 Then
                    If cbGender.SelectedIndex = -1 Then
                        MessageBox.Show("Select Boy or Girl from combobox.")
                    Else
                        Dim cb As New OleDb.OleDbCommandBuilder(frmMain.da)
                        Dim dsNewRow As DataRow
                        dsNewRow = frmMain.ds.Tables("Users").NewRow()

                        'LLenar el nuevo row de informacion
                        dsNewRow.Item(0) = FillID()
                        dsNewRow.Item(1) = cbUser.Text
                        dsNewRow.Item(22) = cbGender.Text
                        For i As Integer = 2 To 21
                            dsNewRow.Item(i) = 0
                        Next

                        frmMain.ds.Tables("users").Rows.Add(dsNewRow)
                        frmMain.da.Update(frmMain.ds, "Users")
                        frmMain.MaxRows = frmMain.MaxRows + 1
                        FindUser()
                        PersonalizeMain()
                        Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCB()
    End Sub

    Private Sub CbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUser.SelectedIndexChanged
        frmMain.inc = 0
        While frmMain.inc < frmMain.MaxRows
            If frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(1) = cbUser.Text Then
                cbGender.Text = frmMain.ds.Tables("Users").Rows(frmMain.inc).Item(22)
                cbGender.Enabled = False
                Exit While
            End If
            frmMain.inc = frmMain.inc + 1
        End While
    End Sub

    Private Sub cbUser_TextUpdate(sender As Object, e As EventArgs) Handles cbUser.TextUpdate
        cbGender.Enabled = True
    End Sub
End Class