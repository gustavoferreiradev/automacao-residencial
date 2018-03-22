Imports System.IO.Ports
Public Class frmBanheiro

    Private Sub frmBanheiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ListaPortas.Enabled = False

        Btn1.Enabled = False
        Btn1.Text = "Conectando..."

        Btn2.Enabled = True



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

            Btn1.Text = "Conectado"

        Catch ex As Exception

            ListaPortas.Enabled = True
            ListaPortas.SelectedIndex = 0

            Btn1.Enabled = True
            Btn1.Text = "Conectar"

            Btn2.Enabled = False

        End Try


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

        PortSerial.Close()
    End Sub

    Private Sub btnLigar_Click(sender As Object, e As EventArgs) Handles btnLigar.Click
        PortSerial.Write("8")


    End Sub

    Private Sub btnDesligar_Click(sender As Object, e As EventArgs) Handles btnDesligar.Click
        PortSerial.Write("9")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLigar.Click

    End Sub
End Class