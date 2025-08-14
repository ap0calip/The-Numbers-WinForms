Public Class FrmLogin
    Public inc As Integer = 0
    Public MaxRows As Integer = 0

    Private Sub UpdateMain()
        frmMain.strName = UserDataBaseDataSet.Tables(0).Rows(inc).Item(0)
        frmMain.strGender = UserDataBaseDataSet.Tables(0).Rows(inc).Item(1)
        frmMain.ChangedMenu()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataBaseDataSet.UserTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.UserDataBaseDataSet.UserTable)
        cbUser.Text = ""
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbUser.Text = "" Then
            MessageBox.Show("Select the username or go to User Management", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        MaxRows = UserDataBaseDataSet.Tables("UserTable").Rows.Count
        inc = 0

        'Buscar usuario
        While inc < MaxRows
            If UserDataBaseDataSet.Tables("UserTable").Rows(inc).Item(0) = cbUser.Text Then
                Exit While
            End If
            inc += 1
        End While

        If inc >= MaxRows Then 'No se encontro usuario
            MessageBox.Show("No user found.", "Information")
        Else 'Usuario encontrado
            UpdateMain()
            Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMain.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        FrmLoginAdmin.ShowDialog()
    End Sub

    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cbUser.Text = ""
    End Sub
End Class