Public Class Form2

    Public Sub ok_Click() Handles ok.Click
        If ((0 <= Val(portn.Text)) * (Val(portn.Text) <= 65535)) Then
            Form1.port = Val(portn.Text)
        Else
            MsgBox("portn no. should be between 0 & 65535")
            portn.Text = ""
            Return
        End If
        Try
            Form1.sp.BaudRate = Val(baud.Text)
            Form1.sp.PortName = com.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        
        Form1.Form1_Load()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        portn.Text = Form1.port
        com.Text = Form1.sp.PortName
        baud.Text = Form1.sp.BaudRate
        ok.Select()

    End Sub

    Private Sub portn_KeyDown(sender As Object, e As KeyEventArgs) Handles portn.KeyDown
        If e.KeyCode = Keys.Enter Then
            ok_Click()
        End If
    End Sub

    
    Private Sub com_KeyDown(sender As Object, e As KeyEventArgs) Handles com.KeyDown
        If e.KeyCode = Keys.Enter Then
            ok_Click()
        End If
    End Sub

    Private Sub baud_KeyDown(sender As Object, e As KeyEventArgs) Handles baud.KeyDown
        If e.KeyCode = Keys.Enter Then
            ok_Click()
        End If
    End Sub

    Private Sub baud_TextChanged(sender As Object, e As EventArgs) Handles baud.TextChanged

    End Sub
End Class