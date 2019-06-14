Imports System.Net.Sockets
Imports System.Net
Imports System.Text.UTF8Encoding



Public Class Form1
    Dim client As TcpClient
    Dim server As TcpListener
    Dim strng As NetworkStream
    Dim cmd As Byte
    Dim tr As Integer
    Public port As Integer = 1111
    Public onn As Boolean = 1


    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        sp.Close()
        server.Stop()
    End Sub

    Public Sub Form1_Load() Handles MyBase.Load
        Me.CenterToScreen()
        If sp.IsOpen = False Then
            Try
                sp.Open()
                rstxt.Text = "Serial port open." + " on " + sp.PortName + " @ " + Str(sp.BaudRate)
            Catch ex As Exception
                MsgBox(ex.Message + vbNewLine + "Check Configuration!")
            End Try

        End If

        server = New TcpListener(IPAddress.Any, port)
        server.Start()
        tcptxt.Text = "Server Started, @#" + Str(port) + vbNewLine
        find.Start()
    End Sub

    Private Sub find_Tick(sender As Object, e As EventArgs) Handles find.Tick
        If server.Pending Then
            find.Stop()
            client = server.AcceptTcpClient
            strng = client.GetStream
            tcptxt.Text += ">>Client CONNECTED" + vbNewLine
            read.Start()
        End If
    End Sub

    Private Sub read_Tick(sender As Object, e As EventArgs) Handles read.Tick
        If Not (Check_Client_connection()) Then
            Call Button1_Click()
        End If
        If client.Available > 1 Then

            Dim x(client.Available - 1) As Byte
            strng.Read(x, 0, x.Length)
            Dim msg As String = UTF8.GetString(x)
            tcptxt.Text += vbTab & ">" & msg
            Try
                cmd = Val(msg)
            Catch ex As Exception
                tcptxt.Text += ex.Message
            End Try

            If 10 < cmd < 19 Then
                Select Case cmd
                    Case 11 : CheckBox1.Checked = Not (CheckBox1.Checked)
                    Case 12 : CheckBox2.Checked = Not (CheckBox2.Checked)
                    Case 13 : CheckBox3.Checked = Not (CheckBox3.Checked)
                    Case 14 : CheckBox4.Checked = Not (CheckBox4.Checked)
                        'Case 15 : CheckBox5.Checked = Not (CheckBox5.Checked)
                        'Case 16 : CheckBox6.Checked = Not (CheckBox6.Checked)
                        'Case 17 : CheckBox7.Checked = Not (CheckBox7.Checked)
                        'Case 18 : CheckBox8.Checked = Not (CheckBox8.Checked)
                End Select
            End If
        End If
    End Sub

    Private Sub sen_Click(sender As Object, e As EventArgs) Handles sen.Click
        Dim x() As Byte = UTF8.GetBytes(ttxt.Text)
        Try
            strng.Write(x, 0, x.Length)
            ttxt.Text = ""
        Catch ex As Exception
            If ex.HResult = -2147467261 Then
                MsgBox("NO Client found.")
            End If
            Call Button1_Click()
        End Try

    End Sub

    Private Sub Button1_Click() Handles clntchk.Click
        If Check_Client_connection() Then
            tcptxt.Text += ">>client is CONNECTED." + vbNewLine
        Else
            tcptxt.Text += ">>NO Client found." + vbNewLine
            read.Stop()
            find.Start()
        End If
    End Sub
    Public Function Check_Client_connection()
        Dim ClientStatus As Boolean
        If client Is Nothing Then
        Else
            If client.Connected Then
                If client.Client.Available = 0 And client.Client.Poll(1000, SelectMode.SelectRead) = True Then
                    ClientStatus = False
                Else
                    ClientStatus = True
                End If
            Else
                ClientStatus = False
            End If
        End If
        Return ClientStatus
    End Function

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        tcptxt.Text = ""
        rstxt.Text = ""
    End Sub

    Private Sub snd(ByVal tmp As Integer)
        If Not (sp.IsOpen) Then
            sp.Open()
        End If
        sp.Write(tmp)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            tr = 1
        Else
            tr = 0
        End If
        snd(tr)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            tr = 3
        Else
            tr = 2
        End If
        snd(tr)
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            tr = 5
        Else
            tr = 4
        End If
        snd(tr)
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            tr = 7
        Else
            tr = 6
        End If
        snd(tr)
    End Sub

    Private Sub sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles sp.DataReceived
        Dim s As String
        CheckForIllegalCrossThreadCalls = 0
        s = sp.ReadExisting
        rstxt.Text &= ">>" & s & vbTab
    End Sub


   

    Private Sub conf_Click(sender As Object, e As EventArgs) Handles conf.Click
        find.Stop()
        read.Stop()
        server.Stop()
        sp.Close()
        tcptxt.Text = "Server Stopped"
        rstxt.Text = "Serial Port Closed"
        onn = 0
        Me.Hide()
        Form2.Show()

    End Sub

    
    Private Sub tst_Click(sender As Object, e As EventArgs) Handles tst.Click
        'sp.Close()

        'sp.PortName = "COM2"
        'sp.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clntchk.Click

    End Sub
End Class
  