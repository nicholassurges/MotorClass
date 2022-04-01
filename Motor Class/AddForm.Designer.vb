<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVoltage = New System.Windows.Forms.TextBox()
        Me.txtRPMs = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtMotorID = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.lblMotorRpm = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblMotorId = New System.Windows.Forms.Label()
        Me.radNA = New System.Windows.Forms.RadioButton()
        Me.radMNT = New System.Windows.Forms.RadioButton()
        Me.radOFF = New System.Windows.Forms.RadioButton()
        Me.radON = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVoltage)
        Me.GroupBox1.Controls.Add(Me.txtRPMs)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.txtMotorID)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblVoltage)
        Me.GroupBox1.Controls.Add(Me.lblMotorRpm)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblMotorId)
        Me.GroupBox1.Controls.Add(Me.radNA)
        Me.GroupBox1.Controls.Add(Me.radMNT)
        Me.GroupBox1.Controls.Add(Me.radOFF)
        Me.GroupBox1.Controls.Add(Me.radON)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Record"
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(119, 160)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.Size = New System.Drawing.Size(100, 22)
        Me.txtVoltage.TabIndex = 12
        '
        'txtRPMs
        '
        Me.txtRPMs.Location = New System.Drawing.Point(119, 122)
        Me.txtRPMs.Name = "txtRPMs"
        Me.txtRPMs.Size = New System.Drawing.Size(100, 22)
        Me.txtRPMs.TabIndex = 11
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(119, 84)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(100, 22)
        Me.txtDesc.TabIndex = 10
        '
        'txtMotorID
        '
        Me.txtMotorID.Location = New System.Drawing.Point(119, 46)
        Me.txtMotorID.Name = "txtMotorID"
        Me.txtMotorID.Size = New System.Drawing.Size(100, 22)
        Me.txtMotorID.TabIndex = 9
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(258, 18)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(88, 17)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Motor Status"
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(35, 163)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(56, 17)
        Me.lblVoltage.TabIndex = 7
        Me.lblVoltage.Text = "Voltage"
        '
        'lblMotorRpm
        '
        Me.lblMotorRpm.AutoSize = True
        Me.lblMotorRpm.Location = New System.Drawing.Point(6, 124)
        Me.lblMotorRpm.Name = "lblMotorRpm"
        Me.lblMotorRpm.Size = New System.Drawing.Size(85, 17)
        Me.lblMotorRpm.TabIndex = 6
        Me.lblMotorRpm.Text = "Motor RPMs"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 85)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description"
        '
        'lblMotorId
        '
        Me.lblMotorId.AutoSize = True
        Me.lblMotorId.Location = New System.Drawing.Point(30, 46)
        Me.lblMotorId.Name = "lblMotorId"
        Me.lblMotorId.Size = New System.Drawing.Size(61, 17)
        Me.lblMotorId.TabIndex = 4
        Me.lblMotorId.Text = "Motor ID"
        '
        'radNA
        '
        Me.radNA.AutoSize = True
        Me.radNA.Location = New System.Drawing.Point(261, 149)
        Me.radNA.Name = "radNA"
        Me.radNA.Size = New System.Drawing.Size(48, 21)
        Me.radNA.TabIndex = 3
        Me.radNA.TabStop = True
        Me.radNA.Text = "NA"
        Me.radNA.UseVisualStyleBackColor = True
        '
        'radMNT
        '
        Me.radMNT.AutoSize = True
        Me.radMNT.Location = New System.Drawing.Point(261, 115)
        Me.radMNT.Name = "radMNT"
        Me.radMNT.Size = New System.Drawing.Size(59, 21)
        Me.radMNT.TabIndex = 2
        Me.radMNT.TabStop = True
        Me.radMNT.Text = "MNT"
        Me.radMNT.UseVisualStyleBackColor = True
        '
        'radOFF
        '
        Me.radOFF.AutoSize = True
        Me.radOFF.Location = New System.Drawing.Point(261, 81)
        Me.radOFF.Name = "radOFF"
        Me.radOFF.Size = New System.Drawing.Size(56, 21)
        Me.radOFF.TabIndex = 1
        Me.radOFF.TabStop = True
        Me.radOFF.Text = "OFF"
        Me.radOFF.UseVisualStyleBackColor = True
        '
        'radON
        '
        Me.radON.AutoSize = True
        Me.radON.Location = New System.Drawing.Point(261, 47)
        Me.radON.Name = "radON"
        Me.radON.Size = New System.Drawing.Size(50, 21)
        Me.radON.TabIndex = 0
        Me.radON.TabStop = True
        Me.radON.Text = "ON"
        Me.radON.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(27, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 52)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(163, 234)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 52)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(299, 234)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 52)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 298)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddForm"
        Me.Text = "Add New Motor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtVoltage As TextBox
    Friend WithEvents txtRPMs As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtMotorID As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblVoltage As Label
    Friend WithEvents lblMotorRpm As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblMotorId As Label
    Friend WithEvents radNA As RadioButton
    Friend WithEvents radMNT As RadioButton
    Friend WithEvents radOFF As RadioButton
    Friend WithEvents radON As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
