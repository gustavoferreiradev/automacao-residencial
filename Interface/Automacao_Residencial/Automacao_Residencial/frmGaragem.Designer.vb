<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGaragem
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
        Me.gbPortao = New System.Windows.Forms.GroupBox()
        Me.btnEsquerda = New System.Windows.Forms.Button()
        Me.btnDireita = New System.Windows.Forms.Button()
        Me.PortSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.gbConectarPorta = New System.Windows.Forms.GroupBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.ListaPortas = New System.Windows.Forms.ComboBox()
        Me.gbPortao.SuspendLayout()
        Me.gbConectarPorta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPortao
        '
        Me.gbPortao.Controls.Add(Me.btnEsquerda)
        Me.gbPortao.Controls.Add(Me.btnDireita)
        Me.gbPortao.Location = New System.Drawing.Point(24, 107)
        Me.gbPortao.Name = "gbPortao"
        Me.gbPortao.Size = New System.Drawing.Size(408, 142)
        Me.gbPortao.TabIndex = 0
        Me.gbPortao.TabStop = False
        Me.gbPortao.Text = "Portão"
        '
        'btnEsquerda
        '
        Me.btnEsquerda.Location = New System.Drawing.Point(27, 63)
        Me.btnEsquerda.Name = "btnEsquerda"
        Me.btnEsquerda.Size = New System.Drawing.Size(75, 23)
        Me.btnEsquerda.TabIndex = 1
        Me.btnEsquerda.Text = "Esquerda"
        Me.btnEsquerda.UseVisualStyleBackColor = True
        '
        'btnDireita
        '
        Me.btnDireita.Location = New System.Drawing.Point(307, 63)
        Me.btnDireita.Name = "btnDireita"
        Me.btnDireita.Size = New System.Drawing.Size(75, 23)
        Me.btnDireita.TabIndex = 0
        Me.btnDireita.Text = "Direita"
        Me.btnDireita.UseVisualStyleBackColor = True
        '
        'PortSerial
        '
        Me.PortSerial.PortName = "COM3"
        '
        'gbConectarPorta
        '
        Me.gbConectarPorta.Controls.Add(Me.Btn2)
        Me.gbConectarPorta.Controls.Add(Me.Btn1)
        Me.gbConectarPorta.Controls.Add(Me.ListaPortas)
        Me.gbConectarPorta.Location = New System.Drawing.Point(24, 13)
        Me.gbConectarPorta.Name = "gbConectarPorta"
        Me.gbConectarPorta.Size = New System.Drawing.Size(408, 71)
        Me.gbConectarPorta.TabIndex = 1
        Me.gbConectarPorta.TabStop = False
        Me.gbConectarPorta.Text = "Conectar com a Porta Serial"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(247, 28)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Alterar Porta"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(149, 28)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Conectar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'ListaPortas
        '
        Me.ListaPortas.FormattingEnabled = True
        Me.ListaPortas.Location = New System.Drawing.Point(6, 28)
        Me.ListaPortas.Name = "ListaPortas"
        Me.ListaPortas.Size = New System.Drawing.Size(121, 21)
        Me.ListaPortas.TabIndex = 0
        '
        'frmGaragem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 262)
        Me.Controls.Add(Me.gbConectarPorta)
        Me.Controls.Add(Me.gbPortao)
        Me.Name = "frmGaragem"
        Me.Text = "Garagem"
        Me.gbPortao.ResumeLayout(False)
        Me.gbConectarPorta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPortao As System.Windows.Forms.GroupBox
    Friend WithEvents PortSerial As System.IO.Ports.SerialPort
    Friend WithEvents btnEsquerda As System.Windows.Forms.Button
    Friend WithEvents btnDireita As System.Windows.Forms.Button
    Friend WithEvents gbConectarPorta As System.Windows.Forms.GroupBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents ListaPortas As System.Windows.Forms.ComboBox
End Class
