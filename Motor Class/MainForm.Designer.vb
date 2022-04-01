<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstMotorids = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMotorids
        '
        Me.lstMotorids.FormattingEnabled = True
        Me.lstMotorids.ItemHeight = 16
        Me.lstMotorids.Location = New System.Drawing.Point(12, 12)
        Me.lstMotorids.Name = "lstMotorids"
        Me.lstMotorids.Size = New System.Drawing.Size(484, 228)
        Me.lstMotorids.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(87, 256)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 69)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Motor"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 69)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 347)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstMotorids)
        Me.Name = "MainForm"
        Me.Text = "Motor Class Application"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMotorids As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
End Class
