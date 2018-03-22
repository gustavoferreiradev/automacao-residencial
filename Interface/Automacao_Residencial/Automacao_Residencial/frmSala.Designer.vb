<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSala
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.ListaPortas = New System.Windows.Forms.ComboBox()
        Me.gbIluminacao = New System.Windows.Forms.GroupBox()
        Me.btnDesligar = New System.Windows.Forms.Button()
        Me.btnLigar = New System.Windows.Forms.Button()
        Me.gbVentilador = New System.Windows.Forms.GroupBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.PortSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gbIluminacao.SuspendLayout()
        Me.gbVentilador.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn2)
        Me.GroupBox1.Controls.Add(Me.Btn1)
        Me.GroupBox1.Controls.Add(Me.ListaPortas)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conectar a Porta Serial"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(267, 37)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Alterar Porta"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(168, 37)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Conectar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'ListaPortas
        '
        Me.ListaPortas.FormattingEnabled = True
        Me.ListaPortas.Location = New System.Drawing.Point(15, 37)
        Me.ListaPortas.Name = "ListaPortas"
        Me.ListaPortas.Size = New System.Drawing.Size(121, 21)
        Me.ListaPortas.TabIndex = 0
        '
        'gbIluminacao
        '
        Me.gbIluminacao.Controls.Add(Me.btnDesligar)
        Me.gbIluminacao.Controls.Add(Me.btnLigar)
        Me.gbIluminacao.Location = New System.Drawing.Point(13, 142)
        Me.gbIluminacao.Name = "gbIluminacao"
        Me.gbIluminacao.Size = New System.Drawing.Size(396, 109)
        Me.gbIluminacao.TabIndex = 1
        Me.gbIluminacao.TabStop = False
        Me.gbIluminacao.Text = "Iluminação"
        '
        'btnDesligar
        '
        Me.btnDesligar.Location = New System.Drawing.Point(299, 48)
        Me.btnDesligar.Name = "btnDesligar"
        Me.btnDesligar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligar.TabIndex = 1
        Me.btnDesligar.Text = "Desligar"
        Me.btnDesligar.UseVisualStyleBackColor = True
        '
        'btnLigar
        '
        Me.btnLigar.Location = New System.Drawing.Point(15, 48)
        Me.btnLigar.Name = "btnLigar"
        Me.btnLigar.Size = New System.Drawing.Size(75, 23)
        Me.btnLigar.TabIndex = 0
        Me.btnLigar.Text = "Ligar"
        Me.btnLigar.UseVisualStyleBackColor = True
        '
        'gbVentilador
        '
        Me.gbVentilador.Controls.Add(Me.TrackBar1)
        Me.gbVentilador.Location = New System.Drawing.Point(13, 272)
        Me.gbVentilador.Name = "gbVentilador"
        Me.gbVentilador.Size = New System.Drawing.Size(396, 106)
        Me.gbVentilador.TabIndex = 2
        Me.gbVentilador.TabStop = False
        Me.gbVentilador.Text = "Ventilador"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(15, 45)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(359, 45)
        Me.TrackBar1.TabIndex = 0
        '
        'frmSala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 400)
        Me.Controls.Add(Me.gbVentilador)
        Me.Controls.Add(Me.gbIluminacao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSala"
        Me.Text = "Sala"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbIluminacao.ResumeLayout(False)
        Me.gbVentilador.ResumeLayout(False)
        Me.gbVentilador.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbIluminacao As System.Windows.Forms.GroupBox
    Friend WithEvents gbVentilador As System.Windows.Forms.GroupBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents ListaPortas As System.Windows.Forms.ComboBox
    Friend WithEvents btnDesligar As System.Windows.Forms.Button
    Friend WithEvents btnLigar As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents PortSerial As System.IO.Ports.SerialPort
End Class
