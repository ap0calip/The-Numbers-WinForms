Public Class FrmLogin
    Public inc As Integer = 0
    Public MaxRows As Integer = 0
    'Buscar usuario en base de datos
    Private Sub FindUser()
        'GET HOW MANY ROWS IS IN THE DATABASE TABLE
        MaxRows = UserDataBaseDataSet.Tables(0).Rows.Count

        inc = 0
        While inc < MaxRows
            If UserDataBaseDataSet.Tables(0).Rows(inc).Item(0) = cbUser.Text Then
                Exit While
            End If
            inc += 1
        End While
    End Sub

    Private Sub UpdateDataBase()
        UserTableBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(UserDataBaseDataSet)
    End Sub

    Private Sub UpdateMain()
        frmLevel1.strName = UserDataBaseDataSet.Tables(0).Rows(inc).Item(0)
        frmLevel1.strGender = UserDataBaseDataSet.Tables(0).Rows(inc).Item(1)
        frmLevel1.ChangedMenu()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataBaseDataSet.UserTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.UserDataBaseDataSet.UserTable)
    End Sub

    Private Sub BtnUse_Click(sender As Object, e As EventArgs) Handles btnUse.Click
        FindUser()
        If inc <> MaxRows Then
            UpdateMain()
            Close()
        Else
            If cbUser.Text <> "" Then
                If cbGender.Text = "Boy" Or cbGender.Text = "Girl" Then
                    'Llenar nuevo row de informacion
                    Dim dr As DataRow
                    dr = UserDataBaseDataSet.Tables(0).NewRow() '0 = "UserTable"
                    dr("Name") = cbUser.Text
                    dr("Gender") = cbGender.Text
                    For i As Integer = 2 To 21
                        dr.Item(i) = 0
                    Next
                    UserDataBaseDataSet.Tables(0).Rows.Add(dr)
                    UpdateDataBase()
                    UpdateMain()
                    Close()
                Else
                    MessageBox.Show("The allowed genders are Boy or Girl.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Enter user name.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        FindUser()
        If inc <> MaxRows Then
            UserDataBaseDataSet.Tables(0).Rows(inc).Delete()
            UpdateDataBase()
        End If
    End Sub

    Private Sub CbUser_TextUpdate(sender As Object, e As EventArgs) Handles cbUser.TextUpdate
        cbGender.Enabled = Enabled
    End Sub

    Private Sub CbUser_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbUser.SelectionChangeCommitted
        FindUser()
        cbGender.Text = UserDataBaseDataSet.Tables(0).Rows(inc).Item(1)
        cbGender.Enabled = False
    End Sub
End Class