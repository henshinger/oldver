<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditUser
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
        Me.txtNat = New System.Windows.Forms.TextBox
        Me.dtpBir = New System.Windows.Forms.DateTimePicker
        Me.txtFir = New System.Windows.Forms.TextBox
        Me.txtGen = New System.Windows.Forms.TextBox
        Me.txtPas = New System.Windows.Forms.TextBox
        Me.txtLas = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtNat
        '
        Me.txtNat.Location = New System.Drawing.Point(135, 232)
        Me.txtNat.Name = "txtNat"
        Me.txtNat.Size = New System.Drawing.Size(152, 26)
        Me.txtNat.TabIndex = 24
        '
        'dtpBir
        '
        Me.dtpBir.Location = New System.Drawing.Point(135, 160)
        Me.dtpBir.Name = "dtpBir"
        Me.dtpBir.Size = New System.Drawing.Size(152, 26)
        Me.dtpBir.TabIndex = 23
        '
        'txtFir
        '
        Me.txtFir.Location = New System.Drawing.Point(135, 86)
        Me.txtFir.Name = "txtFir"
        Me.txtFir.Size = New System.Drawing.Size(152, 26)
        Me.txtFir.TabIndex = 22
        '
        'txtGen
        '
        Me.txtGen.Location = New System.Drawing.Point(135, 123)
        Me.txtGen.Name = "txtGen"
        Me.txtGen.Size = New System.Drawing.Size(152, 26)
        Me.txtGen.TabIndex = 21
        '
        'txtPas
        '
        Me.txtPas.Location = New System.Drawing.Point(135, 196)
        Me.txtPas.Name = "txtPas"
        Me.txtPas.Size = New System.Drawing.Size(152, 26)
        Me.txtPas.TabIndex = 20
        '
        'txtLas
        '
        Me.txtLas.Location = New System.Drawing.Point(135, 49)
        Me.txtLas.Name = "txtLas"
        Me.txtLas.Size = New System.Drawing.Size(152, 26)
        Me.txtLas.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Birthday:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Passport No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nationality:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Last Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Seats:"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(135, 274)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(152, 109)
        Me.CheckedListBox1.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(285, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(189, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 430)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNat)
        Me.Controls.Add(Me.dtpBir)
        Me.Controls.Add(Me.txtFir)
        Me.Controls.Add(Me.txtGen)
        Me.Controls.Add(Me.txtPas)
        Me.Controls.Add(Me.txtLas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditUser"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNat As System.Windows.Forms.TextBox
    Friend WithEvents dtpBir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFir As System.Windows.Forms.TextBox
    Friend WithEvents txtGen As System.Windows.Forms.TextBox
    Friend WithEvents txtPas As System.Windows.Forms.TextBox
    Friend WithEvents txtLas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
