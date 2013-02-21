<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblDisplay = New System.Windows.Forms.Label
        Me.cboReport = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(34, 63)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(153, 29)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "&Display Results"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(231, 63)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(100, 29)
        Me.btnAbout.TabIndex = 1
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(386, 63)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 29)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplay.Location = New System.Drawing.Point(71, 123)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(380, 311)
        Me.lblDisplay.TabIndex = 3
        '
        'cboReport
        '
        Me.cboReport.FormattingEnabled = True
        Me.cboReport.Items.AddRange(New Object() {"Daily Report", "Weekly Report", "Annual Report"})
        Me.cboReport.Location = New System.Drawing.Point(162, 15)
        Me.cboReport.Name = "cboReport"
        Me.cboReport.Size = New System.Drawing.Size(161, 28)
        Me.cboReport.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Type of Report:"
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 455)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboReport)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnDisplay)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmSalesReport"
        Me.Text = "Oriental Vista Airlines Sales Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents cboReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
