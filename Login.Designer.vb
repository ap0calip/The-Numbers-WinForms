<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataBaseDataSet = New TheNumbers.UserDataBaseDataSet()
        Me.UserTableTableAdapter = New TheNumbers.UserDataBaseDataSetTableAdapters.UserTableTableAdapter()
        Me.TableAdapterManager = New TheNumbers.UserDataBaseDataSetTableAdapters.TableAdapterManager()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLogin.Location = New System.Drawing.Point(300, 9)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(152, 32)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User name:"
        '
        'cbUser
        '
        Me.cbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbUser.BackColor = System.Drawing.Color.DarkOrange
        Me.cbUser.DataSource = Me.UserTableBindingSource
        Me.cbUser.DisplayMember = "Name"
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(109, 13)
        Me.cbUser.Margin = New System.Windows.Forms.Padding(4)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(183, 26)
        Me.cbUser.TabIndex = 2
        Me.cbUser.ValueMember = "Name"
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "UserTable"
        Me.UserTableBindingSource.DataSource = Me.UserDataBaseDataSet
        '
        'UserDataBaseDataSet
        '
        Me.UserDataBaseDataSet.DataSetName = "UserDataBaseDataSet"
        Me.UserDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LanguageTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TheNumbers.UserDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableTableAdapter = Me.UserTableTableAdapter
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAdmin.Location = New System.Drawing.Point(78, 57)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(152, 32)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "User Management"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnExit.Location = New System.Drawing.Point(238, 57)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(469, 102)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.cbUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbUser As ComboBox
    Public WithEvents UserDataBaseDataSet As UserDataBaseDataSet
    Public WithEvents UserTableBindingSource As BindingSource
    Public WithEvents UserTableTableAdapter As UserDataBaseDataSetTableAdapters.UserTableTableAdapter
    Public WithEvents TableAdapterManager As UserDataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnExit As Button
End Class
