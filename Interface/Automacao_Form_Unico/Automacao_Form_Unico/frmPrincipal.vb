Imports System.IO.Ports
Public Class frmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnLigarSala_Click(sender As Object, e As EventArgs) Handles btnLigarSala.Click
        PortSerial.Write("1")


    End Sub

    Private Sub btnDesligarSala_Click(sender As Object, e As EventArgs) Handles btnDesligarSala.Click
        PortSerial.Write("0")
    End Sub

    Private Sub btnLigaCozinha_Click(sender As Object, e As EventArgs) Handles btnLigaCozinha.Click
        PortSerial.Write("6")


    End Sub

    Private Sub btnDesligaCozinha_Click(sender As Object, e As EventArgs) Handles btnDesligaCozinha.Click
        PortSerial.Write("7")
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

    Private Sub btnLigaQuarto1_Click(sender As Object, e As EventArgs) Handles btnLigaQuarto1.Click
        PortSerial.Write("2")
    End Sub

    Private Sub btnDesligaQuarto1_Click(sender As Object, e As EventArgs) Handles btnDesligaQuarto1.Click
        PortSerial.Write("3")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLigaQuarto3.Click
        PortSerial.Write("8")
    End Sub

    Private Sub btnLigaQuarto2_Click(sender As Object, e As EventArgs) Handles btnLigaQuarto2.Click
        PortSerial.Write("4")
    End Sub

    Private Sub btnDesligaQuarto2_Click(sender As Object, e As EventArgs) Handles btnDesligaQuarto2.Click
        PortSerial.Write("5")
    End Sub

    Private Sub btnDesligaQuarto3_Click(sender As Object, e As EventArgs) Handles btnDesligaQuarto3.Click
        PortSerial.Write("9")
    End Sub

    Private Sub btnLigaBanheiro_Click(sender As Object, e As EventArgs) Handles btnLigaBanheiro.Click
        PortSerial.Write("q")
    End Sub

    Private Sub btnDesligaBanheiro_Click(sender As Object, e As EventArgs) Handles btnDesligaBanheiro.Click
        PortSerial.Write("w")
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        PortSerial.Write("e")
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        PortSerial.Write("d")
    End Sub

    Private Sub btnLigaVent_Click(sender As Object, e As EventArgs) Handles btnLigaVent.Click
        PortSerial.Write("v")
    End Sub

    Private Sub btnDesligaVent_Click(sender As Object, e As EventArgs) Handles btnDesligaVent.Click
        PortSerial.Write("b")
    End Sub

    Private Sub gbConectar_Enter(sender As Object, e As EventArgs) Handles gbConectar.Enter

    End Sub

    Private Sub ListaPortas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPortas.SelectedIndexChanged

    End Sub
End Class
