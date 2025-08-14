Public Class FrmLoginAdmin
    Public index As Integer = 0
    Public MaxRows As Integer = 0
    Public userName As String = ""

    'Buscar usuario en base de datos
    Private Sub FindUser()
        'GET HOW MANY ROWS IS IN THE DATABASE TABLE
        MaxRows = UserDataBaseDataSet.Tables("UserTable").Rows.Count
        index = 0

        'CHECK IF THE USER IS IN THE DATABASE
        While index < MaxRows
            If UserDataBaseDataSet.Tables("UserTable").Rows(index).Item(0) = cbUser.Text Then
                Exit While
            End If
            index += 1
        End While
    End Sub

    Private Sub UpdateDataBase()
        UserTableBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(UserDataBaseDataSet)
    End Sub

    Private Sub FrmLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UserTableTableAdapter.Fill(Me.UserDataBaseDataSet.UserTable)
        cbUser.Text = ""
        cbGender.Text = ""
        cbGender.Enabled = False
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        userName = cbUser.Text
        FindUser()
        If index <> MaxRows Then
            MessageBox.Show("User already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    MessageBox.Show("User " & userName & " inserted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbUser.Text = ""
                    cbGender.Text = ""
                    cbGender.Enabled = False
                Else
                    MessageBox.Show("The allowed genders are Boy or Girl.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        FindUser()
        userName = cbUser.Text
        If index <> MaxRows Then
            UserDataBaseDataSet.Tables(0).Rows(index).Delete()
            UpdateDataBase()
            MessageBox.Show("User " & userName & " deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("User not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        cbUser.Text = ""
        cbGender.Text = ""
    End Sub

    Private Sub CbUser_TextUpdate(sender As Object, e As EventArgs) Handles cbUser.TextUpdate
        cbGender.Enabled = True
    End Sub

    Private Sub CbUser_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbUser.SelectionChangeCommitted
        index = cbUser.SelectedIndex
        cbGender.Text = UserDataBaseDataSet.Tables("UserTable").Rows(index).Item("Gender")
        cbGender.Enabled = False
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    Private Sub FrmLoginAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmLogin.UserTableTableAdapter.Fill(FrmLogin.UserDataBaseDataSet.UserTable)
    End Sub
End Class