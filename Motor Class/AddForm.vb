Public Class AddForm

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save the data entered on the form

        Dim m As New Motor()
        'Validate the input
        If txtMotorID.Text.Length <> 5 Then
            MessageBox.Show("The motor ID must be 5 characters.", "Error")
            txtMotorID.SelectionStart = 0
            txtMotorID.SelectionStart = txtMotorID.Text.Length
            txtMotorID.Focus()
        ElseIf Val(txtRPMs.Text) < 10 Or Val(txtRPMs.Text) > 10000 Then
            MessageBox.Show("The RPM value must be in the range of 10 - 10000.",
         "Error")
            txtRPMs.SelectionStart = 0
            txtRPMs.SelectionStart = txtRPMs.Text.Length
            txtRPMs.Focus()
        ElseIf Val(txtVoltage.Text) < 1 Or Val(txtVoltage.Text) > 500 Then
            MessageBox.Show("The Voltage value must be in the range of 1 - 500.",
         "Error")
            txtVoltage.SelectionStart = 0
            txtVoltage.SelectionStart = txtVoltage.Text.Length
            txtVoltage.Focus()
        Else
            If MainForm.intMotorCount < 10 Then
                CopyToObject(MainForm.motors(MainForm.intMotorCount))
                MainForm.intMotorCount += 1
                ClearForm()
            Else
                MessageBox.Show("The Array is full.", "Error")
            End If
        End If
    End Sub

    Private Sub CopyToObject(ByVal m As Motor)
        'Copy the data from form to m

        m.MotorId = txtMotorID.Text
        m.Description = txtDesc.Text
        m.RPM = CSng(txtRPMs.Text)
        m.Voltage = CSng(txtVoltage.Text)
        m.Status = GetStatus()
    End Sub

    Private Function GetStatus() As String
        'Return the motor status selected by the user
        Dim stat As String = ""

        If radON.Checked = True Then
            stat = "ON"
        ElseIf radOFF.Checked = True Then
            stat = "OFF"
        ElseIf radMNT.Checked = True Then
            stat = "MNT"
        ElseIf radNA.Checked = True Then
            stat = "NA"
        End If
        Return stat
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the form.
        ClearForm()
    End Sub

    Private Sub ClearForm()
        'Clear the form.
        txtMotorID.Clear()
        txtDesc.Clear()
        txtRPMs.Clear()
        txtVoltage.Clear()
        radON.Checked = True
        txtMotorID.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class