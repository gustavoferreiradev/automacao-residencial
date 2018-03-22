Imports System.IO.Ports

Public Class FormBase

    Private Sub FormBase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CarregarPortas()

    End Sub

    Private Sub CarregarPortas()

        ListaPortas.Items.Clear() 'Limpas os registros que existem no Combox
        ListaPortas.Items.Add("-- Selecione --") 'Adicionamos este registro
        ListaPortas.SelectedIndex = 0 'Marcamos o registro anterior como sendo o "Selecionado"

        For Each sp As String In My.Computer.Ports.SerialPortNames 'Efetivamos um looop nas portas do computador
            ListaPortas.Items.Add(sp) 'Adicionamos cada porta ao Combox
        Next

    End Sub


    Private Sub ConectarPorta(Porta)

        LogAcoes.Items.Add("Iniciado conexão com porta: " + Porta)

        ListaPortas.Enabled = False

        Btn1.Enabled = False
        Btn1.Text = "Conectando..."

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

            LogAcoes.Items.Add("Conexão executada com sucesso!")

            Btn1.Text = "Conectado"

        Catch ex As Exception

            LogAcoes.Items.Add("Erro: " + ex.Message)

            ListaPortas.Enabled = True
            ListaPortas.SelectedIndex = 0

            Btn1.Enabled = True
            Btn1.Text = "Conectar"

            Btn2.Enabled = False

            TrackBar1.Enabled = False

        End Try


    End Sub

    Private Sub Btn1_Click(sender As System.Object, e As System.EventArgs) Handles Btn1.Click

        If ListaPortas.SelectedIndex = 0 Then

            MessageBox.Show("Selecione uma PORTA!")

        Else

            ConectarPorta(ListaPortas.SelectedItem)

        End If

    End Sub

    Private Sub Btn2_Click(sender As System.Object, e As System.EventArgs) Handles Btn2.Click

        LogAcoes.Items.Add("Porta Fechada!")

        ListaPortas.Enabled = True
        ListaPortas.SelectedIndex = 0

        Btn1.Enabled = True
        Btn1.Text = "Conectar"

        Btn2.Enabled = False

        TrackBar1.Enabled = False

        PortSerial.Close()

    End Sub

    Private Sub FormBase_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If PortSerial.IsOpen Then

            PortSerial.Close()

        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll

        Dim Posicao = TrackBar1.Value.ToString

        If Len(Posicao) = 1 Then

            Posicao = "00" + Posicao

        ElseIf Len(Posicao) = 2 Then

            Posicao = "0" + Posicao

        End If

        LogAcoes.Items.Add("Enviando Intensidade: " + Posicao)
        PortSerial.WriteLine("-" + Posicao + "/")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PortSerial.Write("1")


    End Sub
End Class
