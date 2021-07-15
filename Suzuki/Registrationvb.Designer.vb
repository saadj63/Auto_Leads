<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrationvb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nmtxt = New System.Windows.Forms.TextBox()
        Me.mbtxt = New System.Windows.Forms.TextBox()
        Me.addtxt = New System.Windows.Forms.TextBox()
        Me.rctxt = New System.Windows.Forms.TextBox()
        Me.mdtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cridtxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(47, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'nmtxt
        '
        Me.nmtxt.Location = New System.Drawing.Point(177, 82)
        Me.nmtxt.Name = "nmtxt"
        Me.nmtxt.Size = New System.Drawing.Size(147, 23)
        Me.nmtxt.TabIndex = 6
        '
        'mbtxt
        '
        Me.mbtxt.Location = New System.Drawing.Point(177, 144)
        Me.mbtxt.Name = "mbtxt"
        Me.mbtxt.Size = New System.Drawing.Size(147, 23)
        Me.mbtxt.TabIndex = 7
        '
        'addtxt
        '
        Me.addtxt.Location = New System.Drawing.Point(177, 192)
        Me.addtxt.Multiline = True
        Me.addtxt.Name = "addtxt"
        Me.addtxt.Size = New System.Drawing.Size(147, 44)
        Me.addtxt.TabIndex = 8
        '
        'rctxt
        '
        Me.rctxt.Location = New System.Drawing.Point(246, 323)
        Me.rctxt.Name = "rctxt"
        Me.rctxt.Size = New System.Drawing.Size(147, 23)
        Me.rctxt.TabIndex = 9
        '
        'mdtxt
        '
        Me.mdtxt.Location = New System.Drawing.Point(177, 268)
        Me.mdtxt.Name = "mdtxt"
        Me.mdtxt.Size = New System.Drawing.Size(147, 23)
        Me.mdtxt.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(389, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 51)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Create Customer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(393, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 32)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "New Card Id"
        '
        'cridtxt
        '
        Me.cridtxt.Location = New System.Drawing.Point(557, 79)
        Me.cridtxt.Name = "cridtxt"
        Me.cridtxt.Size = New System.Drawing.Size(147, 23)
        Me.cridtxt.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(739, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Validate !!"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(47, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 32)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Mobile No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(47, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 32)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(47, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Registration No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(47, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 32)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Model"
        '
        'Registrationvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(891, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cridtxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mdtxt)
        Me.Controls.Add(Me.rctxt)
        Me.Controls.Add(Me.addtxt)
        Me.Controls.Add(Me.mbtxt)
        Me.Controls.Add(Me.nmtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registrationvb"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nmtxt As TextBox
    Friend WithEvents mbtxt As TextBox
    Friend WithEvents addtxt As TextBox
    Friend WithEvents rctxt As TextBox
    Friend WithEvents mdtxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cridtxt As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
