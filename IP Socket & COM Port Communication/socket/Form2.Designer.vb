<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.portn = New System.Windows.Forms.TextBox()
        Me.com = New System.Windows.Forms.TextBox()
        Me.baud = New System.Windows.Forms.TextBox()
        Me.ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 65)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TCP Port" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Serial Port" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Baud Rate"
        '
        'portn
        '
        Me.portn.Location = New System.Drawing.Point(164, 101)
        Me.portn.Name = "portn"
        Me.portn.Size = New System.Drawing.Size(100, 20)
        Me.portn.TabIndex = 1
        '
        'com
        '
        Me.com.Location = New System.Drawing.Point(164, 127)
        Me.com.Name = "com"
        Me.com.Size = New System.Drawing.Size(100, 20)
        Me.com.TabIndex = 2
        '
        'baud
        '
        Me.baud.Location = New System.Drawing.Point(164, 153)
        Me.baud.Name = "baud"
        Me.baud.Size = New System.Drawing.Size(100, 20)
        Me.baud.TabIndex = 3
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(129, 222)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 0
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 268)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.baud)
        Me.Controls.Add(Me.com)
        Me.Controls.Add(Me.portn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Serial Port"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents portn As System.Windows.Forms.TextBox
    Friend WithEvents com As System.Windows.Forms.TextBox
    Friend WithEvents baud As System.Windows.Forms.TextBox
    Friend WithEvents ok As System.Windows.Forms.Button
End Class
