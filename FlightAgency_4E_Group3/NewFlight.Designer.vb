<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewFlight
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
        Me.dtpDat = New System.Windows.Forms.DateTimePicker
        Me.cboTo = New System.Windows.Forms.ComboBox
        Me.cboFro = New System.Windows.Forms.ComboBox
        Me.cboSta = New System.Windows.Forms.ComboBox
        Me.cboTim = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.cboFli = New System.Windows.Forms.ComboBox
        Me.cboNam = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'dtpDat
        '
        Me.dtpDat.Location = New System.Drawing.Point(221, 81)
        Me.dtpDat.Name = "dtpDat"
        Me.dtpDat.Size = New System.Drawing.Size(121, 26)
        Me.dtpDat.TabIndex = 81
        '
        'cboTo
        '
        Me.cboTo.FormattingEnabled = True
        Me.cboTo.Location = New System.Drawing.Point(220, 280)
        Me.cboTo.Name = "cboTo"
        Me.cboTo.Size = New System.Drawing.Size(121, 28)
        Me.cboTo.TabIndex = 80
        '
        'cboFro
        '
        Me.cboFro.FormattingEnabled = True
        Me.cboFro.Location = New System.Drawing.Point(220, 247)
        Me.cboFro.Name = "cboFro"
        Me.cboFro.Size = New System.Drawing.Size(121, 28)
        Me.cboFro.TabIndex = 79
        '
        'cboSta
        '
        Me.cboSta.FormattingEnabled = True
        Me.cboSta.Location = New System.Drawing.Point(221, 150)
        Me.cboSta.Name = "cboSta"
        Me.cboSta.Size = New System.Drawing.Size(121, 28)
        Me.cboSta.TabIndex = 77
        '
        'cboTim
        '
        Me.cboTim.FormattingEnabled = True
        Me.cboTim.Location = New System.Drawing.Point(221, 116)
        Me.cboTim.Name = "cboTim"
        Me.cboTim.Size = New System.Drawing.Size(121, 28)
        Me.cboTim.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(100, 255)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 20)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "From"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(75, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 20)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Destination:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(100, 287)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 20)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "To"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(75, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 20)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Flight Number:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(76, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 20)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Date of Departure:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Time of Departure:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(74, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Name of Airlines:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(240, 329)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 32)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(94, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboFli
        '
        Me.cboFli.FormattingEnabled = True
        Me.cboFli.Location = New System.Drawing.Point(220, 187)
        Me.cboFli.Name = "cboFli"
        Me.cboFli.Size = New System.Drawing.Size(121, 28)
        Me.cboFli.TabIndex = 78
        '
        'cboNam
        '
        Me.cboNam.FormattingEnabled = True
        Me.cboNam.Location = New System.Drawing.Point(221, 47)
        Me.cboNam.Name = "cboNam"
        Me.cboNam.Size = New System.Drawing.Size(121, 28)
        Me.cboNam.TabIndex = 75
        '
        'frmNewFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 409)
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
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmNewFlight"
        Me.Text = "NewFlight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboFro As System.Windows.Forms.ComboBox
    Friend WithEvents cboSta As System.Windows.Forms.ComboBox
    Friend WithEvents cboTim As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboFli As System.Windows.Forms.ComboBox
    Friend WithEvents cboNam As System.Windows.Forms.ComboBox
End Class
