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
        Me.btnUse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataBaseDataSet = New TheNumbers.UserDataBaseDataSet()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.UserTableTableAdapter = New TheNumbers.UserDataBaseDataSetTableAdapters.UserTableTableAdapter()
        Me.TableAdapterManager = New TheNumbers.UserDataBaseDataSetTableAdapters.TableAdapterManager()
        Me.cbLanguage = New System.Windows.Forms.ComboBox()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUse
        '
        Me.btnUse.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUse.Location = New System.Drawing.Point(568, 9)
        Me.btnUse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(152, 32)
        Me.btnUse.TabIndex = 0
        Me.btnUse.Text = "Use"
        Me.btnUse.UseVisualStyleBackColor = False
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
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.Color.DarkOrange
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Boy", "Girl"})
        Me.cbGender.Location = New System.Drawing.Point(300, 13)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(126, 26)
        Me.cbGender.TabIndex = 3
        Me.cbGender.Text = "Boy"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkOrange
        Me.btnDelete.Location = New System.Drawing.Point(728, 9)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(152, 32)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
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
        'cbLanguage
        '
        Me.cbLanguage.BackColor = System.Drawing.Color.DarkOrange
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.Items.AddRange(New Object() {"English", "Español"})
        Me.cbLanguage.Location = New System.Drawing.Point(434, 13)
        Me.cbLanguage.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(126, 26)
        Me.cbLanguage.TabIndex = 9
        Me.cbLanguage.Text = "English"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnUse
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(895, 56)
        Me.Controls.Add(Me.cbLanguage)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.cbUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUse)
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

    Friend WithEvents btnUse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbUser As ComboBox
    Friend WithEvents cbGender As ComboBox
    Public WithEvents UserDataBaseDataSet As UserDataBaseDataSet
    Public WithEvents UserTableBindingSource As BindingSource
    Public WithEvents UserTableTableAdapter As UserDataBaseDataSetTableAdapters.UserTableTableAdapter
    Public WithEvents TableAdapterManager As UserDataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnDelete As Button
    Friend WithEvents cbLanguage As ComboBox
End Class
