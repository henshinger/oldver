<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnSalesReport = New System.Windows.Forms.Button
        Me.btnNewFlight = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnNewTransaction = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(137, 191)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(152, 38)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Location = New System.Drawing.Point(137, 259)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(152, 38)
        Me.btnSalesReport.TabIndex = 1
        Me.btnSalesReport.Text = "Sales Report"
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnNewFlight
        '
        Me.btnNewFlight.Location = New System.Drawing.Point(137, 124)
        Me.btnNewFlight.Name = "btnNewFlight"
        Me.btnNewFlight.Size = New System.Drawing.Size(152, 38)
        Me.btnNewFlight.TabIndex = 2
        Me.btnNewFlight.Text = "New Flight"
        Me.btnNewFlight.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(137, 351)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 38)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnNewTransaction
        '
        Me.btnNewTransaction.Location = New System.Drawing.Point(137, 52)
        Me.btnNewTransaction.Name = "btnNewTransaction"
        Me.btnNewTransaction.Size = New System.Drawing.Size(152, 38)
        Me.btnNewTransaction.TabIndex = 4
        Me.btnNewTransaction.Text = "New Transaction"
        Me.btnNewTransaction.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 420)
        Me.Controls.Add(Me.btnNewTransaction)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnNewFlight)
        Me.Controls.Add(Me.btnSalesReport)
        Me.Controls.Add(Me.btnSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmHome"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSalesReport As System.Windows.Forms.Button
    Friend WithEvents btnNewFlight As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnNewTransaction As System.Windows.Forms.Button

End Class
