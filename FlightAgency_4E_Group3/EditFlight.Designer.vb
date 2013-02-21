<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditFlight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtpDat = New System.Windows.Forms.DateTimePicker
        Me.cboTo = New System.Windows.Forms.ComboBox
        Me.cboFro = New System.Windows.Forms.ComboBox
        Me.cboFli = New System.Windows.Forms.ComboBox
        Me.cboSta = New System.Windows.Forms.ComboBox
        Me.cboTim = New System.Windows.Forms.ComboBox
        Me.cboNam = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(181, 367)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(277, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpDat
        '
        Me.dtpDat.Location = New System.Drawing.Point(209, 119)
        Me.dtpDat.Name = "dtpDat"
        Me.dtpDat.Size = New System.Drawing.Size(121, 26)
        Me.dtpDat.TabIndex = 63
        '
        'cboTo
        '
        Me.cboTo.FormattingEnabled = True
        Me.cboTo.Location = New System.Drawing.Point(208, 318)
        Me.cboTo.Name = "cboTo"
        Me.cboTo.Size = New System.Drawing.Size(121, 28)
        Me.cboTo.TabIndex = 62
        '
        'cboFro
        '
        Me.cboFro.FormattingEnabled = True
        Me.cboFro.Location = New System.Drawing.Point(208, 285)
        Me.cboFro.Name = "cboFro"
        Me.cboFro.Size = New System.Drawing.Size(121, 28)
        Me.cboFro.TabIndex = 61
        '
        'cboFli
        '
        Me.cboFli.FormattingEnabled = True
        Me.cboFli.Location = New System.Drawing.Point(208, 225)
        Me.cboFli.Name = "cboFli"
        Me.cboFli.Size = New System.Drawing.Size(121, 28)
        Me.cboFli.TabIndex = 59
        '
        'cboSta
        '
        Me.cboSta.FormattingEnabled = True
        Me.cboSta.Location = New System.Drawing.Point(209, 188)
        Me.cboSta.Name = "cboSta"
        Me.cboSta.Size = New System.Drawing.Size(121, 28)
        Me.cboSta.TabIndex = 58
        '
        'cboTim
        '
        Me.cboTim.FormattingEnabled = True
        Me.cboTim.Location = New System.Drawing.Point(209, 154)
        Me.cboTim.Name = "cboTim"
        Me.cboTim.Size = New System.Drawing.Size(121, 28)
        Me.cboTim.TabIndex = 57
        '
        'cboNam
        '
        Me.cboNam.FormattingEnabled = True
        Me.cboNam.Location = New System.Drawing.Point(208, 85)
        Me.cboNam.Name = "cboNam"
        Me.cboNam.Size = New System.Drawing.Size(121, 28)
        Me.cboNam.TabIndex = 55
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(88, 293)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 20)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "From"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(63, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 20)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Destination:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(88, 325)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 20)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "To"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(63, 233)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 20)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Flight Number:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(64, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 20)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Date of Departure:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Time of Departure:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Name of Airlines:"
        '
        'frmEditFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 420)
        Me.Controls.Add(Me.dtpDat)
        Me.Controls.Add(Me.cboTo)
        Me.Controls.Add(Me.cboFro)
        Me.Controls.Add(Me.cboFli)
        Me.Controls.Add(Me.cboSta)
        Me.Controls.Add(Me.cboTim)
        Me.Controls.Add(Me.cboNam)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditFlight"
        Me.Text = "EditFlight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboFro As System.Windows.Forms.ComboBox
    Friend WithEvents cboFli As System.Windows.Forms.ComboBox
    Friend WithEvents cboSta As System.Windows.Forms.ComboBox
    Friend WithEvents cboTim As System.Windows.Forms.ComboBox
    Friend WithEvents cboNam As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
