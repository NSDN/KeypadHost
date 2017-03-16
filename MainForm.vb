Imports System.IO.Ports
Imports System.Threading

Public Class MainForm

    Protected Const TheRate As Integer = 9600
    Protected ThePort As SerialPort = New SerialPort()
    Protected TheThread As Thread = New Thread(AddressOf TheThread_Work)

    Private Sub TheThread_Work()
        While True
            If ThePort.IsOpen Then
                Dim tmp As Byte = ThePort.ReadByte()
                If tmp >= 128 Then
                    SendKeys.SendWait("^{" & Chr(tmp - 128) & "}")
                Else
                    Select Case tmp
                        Case 8      'Backspace
                            SendKeys.SendWait("{BACKSPACE}")
                        Case 10     'Enter
                            SendKeys.SendWait("{ENTER}")
                        Case 27     'ESC
                            SendKeys.SendWait("{ESC}")
                        Case 32     'Space
                            SendKeys.SendWait(" ")
                        Case Else
                            SendKeys.SendWait("{" & Chr(tmp) & "}")
                    End Select
                End If
            End If
            Thread.Sleep(1)
        End While
    End Sub

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        If ThePort.IsOpen Then ThePort.Close()
        ThePort.Dispose()
        End
    End Sub

    Private Sub MenuAbout_Click(sender As Object, e As EventArgs) Handles MenuAbout.Click
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub

    Private Sub MenuPort_MouseEnter(sender As Object, e As EventArgs) Handles MenuPort.MouseEnter
        Dim ports = SerialPort.GetPortNames()
        PortsList.Items.Clear()
        If ports.Length > 0 Then
            For Each i In ports
                Dim tmp = New ToolStripMenuItem(i, Nothing, New EventHandler(AddressOf PortItem_Click))
                If tmp.Text = ThePort.PortName Then tmp.Checked = True
                PortsList.Items.Add(tmp)
            Next i
        Else
            PortsList.Items.Add(New ToolStripMenuItem())
        End If
    End Sub

    Private Sub PortItem_Click(sender As Object, e As EventArgs)
        Dim port As ToolStripMenuItem = sender
        port.Checked = True
        If TheThread.IsAlive Then TheThread.Abort()
        TheThread.IsBackground = True
        If ThePort.IsOpen Then ThePort.Close()
        ThePort.Dispose()
        ThePort = New SerialPort(port.Text, TheRate)
        ThePort.Open()
        TheThread.Start()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Notify.ShowBalloonTip(1000)
    End Sub

    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Hide()
    End Sub
End Class
