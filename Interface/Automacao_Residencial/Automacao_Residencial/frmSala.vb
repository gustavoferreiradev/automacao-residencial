Imports System.IO.Ports

Public Class frmSala

    Private Sub frmSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarPortas()

    End Sub
    Private Sub CarregarPortas()

        ListaPortas.Items.Clear()
        ListaPortas.Items.Add("Selecione")
        ListaPortas.SelectedIndex = 0

        For Each sp As String In My.Computer.Ports.SerialPortNames
            ListaPortas.Items.Add(sp)


        Next

    End Sub

    Private Sub ConectarPorta(Porta)
        ListaPortas.Enabled = False
        Btn1.Enabled = False
        Btn2.Enabled = True
        TrackBar1.Enabled = True

        Try
            If PortSerial.IsOpen Then
                PortSerial.Close()

            End If

            PortSerial.PortName = Porta
            PortSerial.BaudRate = 9600
            PortSerial.Parity = Parity.None
            PortSerial.StopBits = StopBits.One
            PortSerial.DataBits = 8
            PortSerial.Handshake = Handshake.None
            PortSerial.ReadTimeout = 5000
            PortSerial.WriteTimeout = 5000
            PortSerial.Open()
        Catch ex As Exception

            Btn1.Text = "Conectado"

            ListaPortas.Enabled = True
            ListaPortas.SelectedIndex = 0

            Btn1.Enabled = True
            Btn1.Text = "Conectar"

            Btn2.Enabled = False

        End Try


    End Sub
    Private Sub FormBase_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If PortSerial.IsOpen Then

            PortSerial.Close()

        End If
    End Sub





    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim Posicao = TrackBar1.Value.ToString

        If Len(Posicao) = 1 Then

            Posicao = "00" + Posicao

        ElseIf Len(Posicao) = 2 Then

            Posicao = "0" + Posicao

        End If

    End Sub

    Private Sub btnLigar_Click(sender As Object, e As EventArgs) Handles btnLigar.Click
        PortSerial.Write("1")


    End Sub

    Private Sub btnDesligar_Click(sender As Object, e As EventArgs) Handles btnDesligar.Click
        PortSerial.Write("0")


    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If ListaPortas.SelectedIndex = 0 Then

            MessageBox.Show("Selecione uma PORTA!")

        Else

            ConectarPorta(ListaPortas.SelectedItem)

        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        ListaPortas.Enabled = True
        ListaPortas.SelectedIndex = 0

        Btn1.Enabled = True
        Btn1.Text = "Conectar"

        Btn2.Enabled = False

        TrackBar1.Enabled = False

        PortSerial.Close()

    End Sub

End Class