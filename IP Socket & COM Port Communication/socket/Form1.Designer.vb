<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.sen = New System.Windows.Forms.Button()
        Me.tcptxt = New System.Windows.Forms.TextBox()
        Me.ttxt = New System.Windows.Forms.TextBox()
        Me.find = New System.Windows.Forms.Timer(Me.components)
        Me.read = New System.Windows.Forms.Timer(Me.components)
        Me.clntchk = New System.Windows.Forms.Button()
        Me.clr = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.tst = New System.Windows.Forms.Button()
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.rstxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.conf = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sen
        '
        Me.sen.Location = New System.Drawing.Point(475, 400)
        Me.sen.Name = "sen"
        Me.sen.Size = New System.Drawing.Size(92, 28)
        Me.sen.TabIndex = 0
        Me.sen.Text = "Send"
        Me.sen.UseVisualStyleBackColor = True
        '
        'tcptxt
        '
        Me.tcptxt.Location = New System.Drawing.Point(28, 46)
        Me.tcptxt.Multiline = True
        Me.tcptxt.Name = "tcptxt"
        Me.tcptxt.Size = New System.Drawing.Size(142, 336)
        Me.tcptxt.TabIndex = 1
        '
        'ttxt
        '
        Me.ttxt.Location = New System.Drawing.Point(462, 46)
        Me.ttxt.Multiline = True
        Me.ttxt.Name = "ttxt"
        Me.ttxt.Size = New System.Drawing.Size(114, 336)
        Me.ttxt.TabIndex = 2
        '
        'find
        '
        '
        'read
        '
        '
        'clntchk
        '
        Me.clntchk.Location = New System.Drawing.Point(28, 400)
        Me.clntchk.Name = "clntchk"
        Me.clntchk.Size = New System.Drawing.Size(68, 28)
        Me.clntchk.TabIndex = 4
        Me.clntchk.Text = "Client_chk"
        Me.clntchk.UseVisualStyleBackColor = True
        '
        'clr
        '
        Me.clr.Location = New System.Drawing.Point(148, 400)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(62, 28)
        Me.clr.TabIndex = 5
        Me.clr.Text = "clear"
        Me.clr.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(374, 141)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Obj 1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(374, 172)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Obj 2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(374, 203)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox3.TabIndex = 9
        Me.CheckBox3.Text = "Obj 3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(374, 234)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox4.TabIndex = 8
        Me.CheckBox4.Text = "Obj 4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'tst
        '
        Me.tst.Location = New System.Drawing.Point(270, 400)
        Me.tst.Name = "tst"
        Me.tst.Size = New System.Drawing.Size(62, 28)
        Me.tst.TabIndex = 14
        Me.tst.Text = "Test btn"
        Me.tst.UseVisualStyleBackColor = True
        '
        'sp
        '
        Me.sp.PortName = "COM5"
        '
        'rstxt
        '
        Me.rstxt.Location = New System.Drawing.Point(192, 46)
        Me.rstxt.Multiline = True
        Me.rstxt.Name = "rstxt"
        Me.rstxt.Size = New System.Drawing.Size(142, 337)
        Me.rstxt.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "TCP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "SERIAL"
        '
        'conf
        '
        Me.conf.Location = New System.Drawing.Point(359, 328)
        Me.conf.Name = "conf"
        Me.conf.Size = New System.Drawing.Size(82, 32)
        Me.conf.TabIndex = 18
        Me.conf.Text = "Configuration"
        Me.conf.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "TCP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 440)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.conf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rstxt)
        Me.Controls.Add(Me.tst)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.clr)
        Me.Controls.Add(Me.clntchk)
        Me.Controls.Add(Me.ttxt)
        Me.Controls.Add(Me.tcptxt)
        Me.Controls.Add(Me.sen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sen As System.Windows.Forms.Button
    Friend WithEvents tcptxt As System.Windows.Forms.TextBox
    Friend WithEvents ttxt As System.Windows.Forms.TextBox
    Friend WithEvents find As System.Windows.Forms.Timer
    Friend WithEvents read As System.Windows.Forms.Timer
    Friend WithEvents clntchk As System.Windows.Forms.Button
    Friend WithEvents clr As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents tst As System.Windows.Forms.Button
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents rstxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents conf As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
