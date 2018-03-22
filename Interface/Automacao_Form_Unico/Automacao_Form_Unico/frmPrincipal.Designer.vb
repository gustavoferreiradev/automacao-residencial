<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.gbConectar = New System.Windows.Forms.GroupBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.ListaPortas = New System.Windows.Forms.ComboBox()
        Me.PortSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.gbSala = New System.Windows.Forms.GroupBox()
        Me.btnDesligaVent = New System.Windows.Forms.Button()
        Me.btnLigaVent = New System.Windows.Forms.Button()
        Me.labVentilador = New System.Windows.Forms.Label()
        Me.labIluminacao = New System.Windows.Forms.Label()
        Me.btnDesligarSala = New System.Windows.Forms.Button()
        Me.btnLigarSala = New System.Windows.Forms.Button()
        Me.gbCozinha = New System.Windows.Forms.GroupBox()
        Me.btnDesligaCozinha = New System.Windows.Forms.Button()
        Me.btnLigaCozinha = New System.Windows.Forms.Button()
        Me.labCozinha = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDesligaQuarto1 = New System.Windows.Forms.Button()
        Me.btnLigaQuarto1 = New System.Windows.Forms.Button()
        Me.labIluminacaoQuarto1 = New System.Windows.Forms.Label()
        Me.gbQuarto3 = New System.Windows.Forms.GroupBox()
        Me.btnDesligaQuarto3 = New System.Windows.Forms.Button()
        Me.btnLigaQuarto3 = New System.Windows.Forms.Button()
        Me.labQuarto3 = New System.Windows.Forms.Label()
        Me.gbQuarto2 = New System.Windows.Forms.GroupBox()
        Me.btnDesligaQuarto2 = New System.Windows.Forms.Button()
        Me.btnLigaQuarto2 = New System.Windows.Forms.Button()
        Me.labQuarto2 = New System.Windows.Forms.Label()
        Me.gbBanheiro = New System.Windows.Forms.GroupBox()
        Me.btnDesligaBanheiro = New System.Windows.Forms.Button()
        Me.btnLigaBanheiro = New System.Windows.Forms.Button()
        Me.labIluminaBanheiro = New System.Windows.Forms.Label()
        Me.gbGaragem = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.labAbrePortao = New System.Windows.Forms.Label()
        Me.gbConectar.SuspendLayout()
        Me.gbSala.SuspendLayout()
        Me.gbCozinha.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbQuarto3.SuspendLayout()
        Me.gbQuarto2.SuspendLayout()
        Me.gbBanheiro.SuspendLayout()
        Me.gbGaragem.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbConectar
        '
        Me.gbConectar.Controls.Add(Me.Btn2)
        Me.gbConectar.Controls.Add(Me.Btn1)
        Me.gbConectar.Controls.Add(Me.ListaPortas)
        Me.gbConectar.Location = New System.Drawing.Point(12, 12)
        Me.gbConectar.Name = "gbConectar"
        Me.gbConectar.Size = New System.Drawing.Size(542, 83)
        Me.gbConectar.TabIndex = 0
        Me.gbConectar.TabStop = False
        Me.gbConectar.Text = "Conectar Porta Serial"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(443, 35)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Alterar Porta"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(159, 35)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Conectar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'ListaPortas
        '
        Me.ListaPortas.FormattingEnabled = True
        Me.ListaPortas.Location = New System.Drawing.Point(24, 35)
        Me.ListaPortas.Name = "ListaPortas"
        Me.ListaPortas.Size = New System.Drawing.Size(121, 21)
        Me.ListaPortas.TabIndex = 0
        '
        'PortSerial
        '
        Me.PortSerial.PortName = "COM15"
        '
        'gbSala
        '
        Me.gbSala.Controls.Add(Me.btnDesligaVent)
        Me.gbSala.Controls.Add(Me.btnLigaVent)
        Me.gbSala.Controls.Add(Me.labVentilador)
        Me.gbSala.Controls.Add(Me.labIluminacao)
        Me.gbSala.Controls.Add(Me.btnDesligarSala)
        Me.gbSala.Controls.Add(Me.btnLigarSala)
        Me.gbSala.Location = New System.Drawing.Point(12, 108)
        Me.gbSala.Name = "gbSala"
        Me.gbSala.Size = New System.Drawing.Size(542, 101)
        Me.gbSala.TabIndex = 1
        Me.gbSala.TabStop = False
        Me.gbSala.Text = "Sala"
        '
        'btnDesligaVent
        '
        Me.btnDesligaVent.Location = New System.Drawing.Point(442, 45)
        Me.btnDesligaVent.Name = "btnDesligaVent"
        Me.btnDesligaVent.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligaVent.TabIndex = 6
        Me.btnDesligaVent.Text = "Desligar"
        Me.btnDesligaVent.UseVisualStyleBackColor = True
        '
        'btnLigaVent
        '
        Me.btnLigaVent.Location = New System.Drawing.Point(304, 45)
        Me.btnLigaVent.Name = "btnLigaVent"
        Me.btnLigaVent.Size = New System.Drawing.Size(75, 23)
        Me.btnLigaVent.TabIndex = 5
        Me.btnLigaVent.Text = "Ligar"
        Me.btnLigaVent.UseVisualStyleBackColor = True
        '
        'labVentilador
        '
        Me.labVentilador.AutoSize = True
        Me.labVentilador.Location = New System.Drawing.Point(374, 16)
        Me.labVentilador.Name = "labVentilador"
        Me.labVentilador.Size = New System.Drawing.Size(54, 13)
        Me.labVentilador.TabIndex = 4
        Me.labVentilador.Text = "Ventilador"
        '
        'labIluminacao
        '
        Me.labIluminacao.AutoSize = True
        Me.labIluminacao.Location = New System.Drawing.Point(106, 16)
        Me.labIluminacao.Name = "labIluminacao"
        Me.labIluminacao.Size = New System.Drawing.Size(58, 13)
        Me.labIluminacao.TabIndex = 3
        Me.labIluminacao.Text = "Iluminação"
        '
        'btnDesligarSala
        '
        Me.btnDesligarSala.Location = New System.Drawing.Point(159, 45)
        Me.btnDesligarSala.Name = "btnDesligarSala"
        Me.btnDesligarSala.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligarSala.TabIndex = 1
        Me.btnDesligarSala.Text = "Desligar"
        Me.btnDesligarSala.UseVisualStyleBackColor = True
        '
        'btnLigarSala
        '
        Me.btnLigarSala.Location = New System.Drawing.Point(24, 45)
        Me.btnLigarSala.Name = "btnLigarSala"
        Me.btnLigarSala.Size = New System.Drawing.Size(75, 23)
        Me.btnLigarSala.TabIndex = 0
        Me.btnLigarSala.Text = "Ligar"
        Me.btnLigarSala.UseVisualStyleBackColor = True
        '
        'gbCozinha
        '
        Me.gbCozinha.Controls.Add(Me.btnDesligaCozinha)
        Me.gbCozinha.Controls.Add(Me.btnLigaCozinha)
        Me.gbCozinha.Controls.Add(Me.labCozinha)
        Me.gbCozinha.Location = New System.Drawing.Point(12, 215)
        Me.gbCozinha.Name = "gbCozinha"
        Me.gbCozinha.Size = New System.Drawing.Size(259, 99)
        Me.gbCozinha.TabIndex = 2
        Me.gbCozinha.TabStop = False
        Me.gbCozinha.Text = "Cozinha"
        '
        'btnDesligaCozinha
        '
        Me.btnDesligaCozinha.Location = New System.Drawing.Point(159, 57)
        Me.btnDesligaCozinha.Name = "btnDesligaCozinha"
        Me.btnDesligaCozinha.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligaCozinha.TabIndex = 2
        Me.btnDesligaCozinha.Text = "Desligar"
        Me.btnDesligaCozinha.UseVisualStyleBackColor = True
        '
        'btnLigaCozinha
        '
        Me.btnLigaCozinha.Location = New System.Drawing.Point(19, 57)
        Me.btnLigaCozinha.Name = "btnLigaCozinha"
        Me.btnLigaCozinha.Size = New System.Drawing.Size(75, 23)
        Me.btnLigaCozinha.TabIndex = 1
        Me.btnLigaCozinha.Text = "Ligar"
        Me.btnLigaCozinha.UseVisualStyleBackColor = True
        '
        'labCozinha
        '
        Me.labCozinha.AutoSize = True
        Me.labCozinha.Location = New System.Drawing.Point(106, 16)
        Me.labCozinha.Name = "labCozinha"
        Me.labCozinha.Size = New System.Drawing.Size(58, 13)
        Me.labCozinha.TabIndex = 0
        Me.labCozinha.Text = "Iluminação"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDesligaQuarto1)
        Me.GroupBox1.Controls.Add(Me.btnLigaQuarto1)
        Me.GroupBox1.Controls.Add(Me.labIluminacaoQuarto1)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 99)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quarto 1"
        '
        'btnDesligaQuarto1
        '
        Me.btnDesligaQuarto1.Location = New System.Drawing.Point(159, 60)
        Me.btnDesligaQuarto1.Name = "btnDesligaQuarto1"
        Me.btnDesligaQuarto1.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligaQuarto1.TabIndex = 2
        Me.btnDesligaQuarto1.Text = "Desligar"
        Me.btnDesligaQuarto1.UseVisualStyleBackColor = True
        '
        'btnLigaQuarto1
        '
        Me.btnLigaQuarto1.Location = New System.Drawing.Point(24, 60)
        Me.btnLigaQuarto1.Name = "btnLigaQuarto1"
        Me.btnLigaQuarto1.Size = New System.Drawing.Size(75, 23)
        Me.btnLigaQuarto1.TabIndex = 1
        Me.btnLigaQuarto1.Text = "Ligar"
        Me.btnLigaQuarto1.UseVisualStyleBackColor = True
        '
        'labIluminacaoQuarto1
        '
        Me.labIluminacaoQuarto1.AutoSize = True
        Me.labIluminacaoQuarto1.Location = New System.Drawing.Point(90, 16)
        Me.labIluminacaoQuarto1.Name = "labIluminacaoQuarto1"
        Me.labIluminacaoQuarto1.Size = New System.Drawing.Size(58, 13)
        Me.labIluminacaoQuarto1.TabIndex = 0
        Me.labIluminacaoQuarto1.Text = "Iluminação"
        '
        'gbQuarto3
        '
        Me.gbQuarto3.Controls.Add(Me.btnDesligaQuarto3)
        Me.gbQuarto3.Controls.Add(Me.btnLigaQuarto3)
        Me.gbQuarto3.Controls.Add(Me.labQuarto3)
        Me.gbQuarto3.Location = New System.Drawing.Point(296, 324)
        Me.gbQuarto3.Name = "gbQuarto3"
        Me.gbQuarto3.Size = New System.Drawing.Size(259, 99)
        Me.gbQuarto3.TabIndex = 4
        Me.gbQuarto3.TabStop = False
        Me.gbQuarto3.Text = "Quarto 3"
        '
        'btnDesligaQuarto3
        '
        Me.btnDesligaQuarto3.Location = New System.Drawing.Point(159, 57)
        Me.btnDesligaQuarto3.Name = "btnDesligaQuarto3"
        Me.btnDesligaQuarto3.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligaQuarto3.TabIndex = 2
        Me.btnDesligaQuarto3.Text = "Desligar"
        Me.btnDesligaQuarto3.UseVisualStyleBackColor = True
        '
        'btnLigaQuarto3
        '
        Me.btnLigaQuarto3.Location = New System.Drawing.Point(20, 57)
        Me.btnLigaQuarto3.Name = "btnLigaQuarto3"
        Me.btnLigaQuarto3.Size = New System.Drawing.Size(75, 23)
        Me.btnLigaQuarto3.TabIndex = 1
        Me.btnLigaQuarto3.Text = "Ligar"
        Me.btnLigaQuarto3.UseVisualStyleBackColor = True
        '
        'labQuarto3
        '
        Me.labQuarto3.AutoSize = True
        Me.labQuarto3.Location = New System.Drawing.Point(90, 16)
        Me.labQuarto3.Name = "labQuarto3"
        Me.labQuarto3.Size = New System.Drawing.Size(58, 13)
        Me.labQuarto3.TabIndex = 0
        Me.labQuarto3.Text = "Iluminação"
        '
        'gbQuarto2
        '
        Me.gbQuarto2.Controls.Add(Me.btnDesligaQuarto2)
        Me.gbQuarto2.Controls.Add(Me.btnLigaQuarto2)
        Me.gbQuarto2.Controls.Add(Me.labQuarto2)
        Me.gbQuarto2.Location = New System.Drawing.Point(12, 324)
        Me.gbQuarto2.Name = "gbQuarto2"
        Me.gbQuarto2.Size = New System.Drawing.Size(259, 99)
        Me.gbQuarto2.TabIndex = 5
        Me.gbQuarto2.TabStop = False
        Me.gbQuarto2.Text = "Quarto 2"
        '
        'btnDesligaQuarto2
        '
        Me.btnDesligaQuarto2.Location = New System.Drawing.Point(159, 57)
        Me.btnDesligaQuarto2.Name = "btnDesligaQuarto2"
        Me.btnDesligaQuarto2.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligaQuarto2.TabIndex = 2
        Me.btnDesligaQuarto2.Text = "Desligar"
        Me.btnDesligaQuarto2.UseVisualStyleBackColor = True
        '
        'btnLigaQuarto2
        '
        Me.btnLigaQuarto2.Location = New System.Drawing.Point(19, 57)
        Me.btnLigaQuarto2.Name = "btnLigaQuarto2"
        Me.btnLigaQuarto2.Size = New System.Drawing.Size(75, 23)
        Me.btnLigaQuarto2.TabIndex = 1
        Me.btnLigaQuarto2.Text = "Ligar"
        Me.btnLigaQuarto2.UseVisualStyleBackColor = True
        '
        'labQuarto2
        '
        Me.labQuarto2.AutoSize = True
        Me.labQuarto2.Location = New System.Drawing.Point(106, 16)
        Me.labQuarto2.Name = "labQuarto2"
        Me.labQuarto2.Size = New System.Drawing.Size(58, 13)
        Me.labQuarto2.TabIndex = 0
        Me.labQuarto2.Text = "Iluminação"
        '
        'gbBanheiro
        '
        Me.gbBanheiro.Controls.Add(Me.btnDesligaBanheiro)
        Me.gbBanheiro.Controls.Add(Me.btnLigaBanheiro)
        Me.gbBanheiro.Controls.Add(Me.labIluminaBanheiro)
        Me.gbBanheiro.Location = New System.Drawing.Point(12, 429)
        Me.gbBanheiro.Name = "gbBanheiro"
        Me.gbBanheiro.Size = New System.Drawing.Size(259, 99)
        Me.gbBanheiro.TabIndex = 6
        Me.gbBanheiro.TabStop = False
        Me.gbBanheiro.Text = "Banheiro"
        '
        'btnDesligaBanheiro
        '
        Me.btnDesligaBanheiro.Location = New System.Drawing.Point(159, 54)
        Me.btnDesligaBanheiro.Name = "btnDesligaBanheiro"
        Me.btnDesligaBanheiro.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligaBanheiro.TabIndex = 2
        Me.btnDesligaBanheiro.Text = "Desligar"
        Me.btnDesligaBanheiro.UseVisualStyleBackColor = True
        '
        'btnLigaBanheiro
        '
        Me.btnLigaBanheiro.Location = New System.Drawing.Point(24, 54)
        Me.btnLigaBanheiro.Name = "btnLigaBanheiro"
        Me.btnLigaBanheiro.Size = New System.Drawing.Size(75, 23)
        Me.btnLigaBanheiro.TabIndex = 1
        Me.btnLigaBanheiro.Text = "Ligar"
        Me.btnLigaBanheiro.UseVisualStyleBackColor = True
        '
        'labIluminaBanheiro
        '
        Me.labIluminaBanheiro.AutoSize = True
        Me.labIluminaBanheiro.Location = New System.Drawing.Point(97, 16)
        Me.labIluminaBanheiro.Name = "labIluminaBanheiro"
        Me.labIluminaBanheiro.Size = New System.Drawing.Size(58, 13)
        Me.labIluminaBanheiro.TabIndex = 0
        Me.labIluminaBanheiro.Text = "Iluminação"
        '
        'gbGaragem
        '
        Me.gbGaragem.Controls.Add(Me.btnFechar)
        Me.gbGaragem.Controls.Add(Me.btnAbrir)
        Me.gbGaragem.Controls.Add(Me.labAbrePortao)
        Me.gbGaragem.Location = New System.Drawing.Point(295, 429)
        Me.gbGaragem.Name = "gbGaragem"
        Me.gbGaragem.Size = New System.Drawing.Size(259, 99)
        Me.gbGaragem.TabIndex = 7
        Me.gbGaragem.TabStop = False
        Me.gbGaragem.Text = "Garagem"
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(159, 54)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = "Fecha"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(21, 54)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrir.TabIndex = 1
        Me.btnAbrir.Text = "Abre"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'labAbrePortao
        '
        Me.labAbrePortao.AutoSize = True
        Me.labAbrePortao.Location = New System.Drawing.Point(107, 16)
        Me.labAbrePortao.Name = "labAbrePortao"
        Me.labAbrePortao.Size = New System.Drawing.Size(38, 13)
        Me.labAbrePortao.TabIndex = 0
        Me.labAbrePortao.Text = "Portão"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 538)
        Me.Controls.Add(Me.gbGaragem)
        Me.Controls.Add(Me.gbBanheiro)
        Me.Controls.Add(Me.gbQuarto2)
        Me.Controls.Add(Me.gbQuarto3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbCozinha)
        Me.Controls.Add(Me.gbSala)
        Me.Controls.Add(Me.gbConectar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automação Residencial"
        Me.gbConectar.ResumeLayout(False)
        Me.gbSala.ResumeLayout(False)
        Me.gbSala.PerformLayout()
        Me.gbCozinha.ResumeLayout(False)
        Me.gbCozinha.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbQuarto3.ResumeLayout(False)
        Me.gbQuarto3.PerformLayout()
        Me.gbQuarto2.ResumeLayout(False)
        Me.gbQuarto2.PerformLayout()
        Me.gbBanheiro.ResumeLayout(False)
        Me.gbBanheiro.PerformLayout()
        Me.gbGaragem.ResumeLayout(False)
        Me.gbGaragem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbConectar As System.Windows.Forms.GroupBox
    Friend WithEvents ListaPortas As System.Windows.Forms.ComboBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents PortSerial As System.IO.Ports.SerialPort
    Friend WithEvents gbSala As System.Windows.Forms.GroupBox
    Friend WithEvents labIluminacao As System.Windows.Forms.Label
    Friend WithEvents btnDesligarSala As System.Windows.Forms.Button
    Friend WithEvents btnLigarSala As System.Windows.Forms.Button
    Friend WithEvents gbCozinha As System.Windows.Forms.GroupBox
    Friend WithEvents btnDesligaCozinha As System.Windows.Forms.Button
    Friend WithEvents btnLigaCozinha As System.Windows.Forms.Button
    Friend WithEvents labCozinha As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labIluminacaoQuarto1 As System.Windows.Forms.Label
    Friend WithEvents btnDesligaQuarto1 As System.Windows.Forms.Button
    Friend WithEvents btnLigaQuarto1 As System.Windows.Forms.Button
    Friend WithEvents gbQuarto3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLigaQuarto3 As System.Windows.Forms.Button
    Friend WithEvents labQuarto3 As System.Windows.Forms.Label
    Friend WithEvents btnDesligaQuarto3 As System.Windows.Forms.Button
    Friend WithEvents gbQuarto2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDesligaQuarto2 As System.Windows.Forms.Button
    Friend WithEvents btnLigaQuarto2 As System.Windows.Forms.Button
    Friend WithEvents labQuarto2 As System.Windows.Forms.Label
    Friend WithEvents gbBanheiro As System.Windows.Forms.GroupBox
    Friend WithEvents btnDesligaBanheiro As System.Windows.Forms.Button
    Friend WithEvents btnLigaBanheiro As System.Windows.Forms.Button
    Friend WithEvents labIluminaBanheiro As System.Windows.Forms.Label
    Friend WithEvents gbGaragem As System.Windows.Forms.GroupBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Friend WithEvents labAbrePortao As System.Windows.Forms.Label
    Friend WithEvents btnDesligaVent As System.Windows.Forms.Button
    Friend WithEvents btnLigaVent As System.Windows.Forms.Button
    Friend WithEvents labVentilador As System.Windows.Forms.Label

End Class
