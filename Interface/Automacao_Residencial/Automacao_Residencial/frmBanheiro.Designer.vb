﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanheiro
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
        Me.gbConectar = New System.Windows.Forms.GroupBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.ListaPortas = New System.Windows.Forms.ComboBox()
        Me.gbIluminacao = New System.Windows.Forms.GroupBox()
        Me.btnDesligar = New System.Windows.Forms.Button()
        Me.btnLigar = New System.Windows.Forms.Button()
        Me.PortSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.gbConectar.SuspendLayout()
        Me.gbIluminacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbConectar
        '
        Me.gbConectar.Controls.Add(Me.Btn2)
        Me.gbConectar.Controls.Add(Me.Btn1)
        Me.gbConectar.Controls.Add(Me.ListaPortas)
        Me.gbConectar.Location = New System.Drawing.Point(13, 13)
        Me.gbConectar.Name = "gbConectar"
        Me.gbConectar.Size = New System.Drawing.Size(423, 115)
        Me.gbConectar.TabIndex = 0
        Me.gbConectar.TabStop = False
        Me.gbConectar.Text = "Conectar a Porta Serial"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(315, 38)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(92, 23)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Alterar Portas"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(212, 38)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Conectar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'ListaPortas
        '
        Me.ListaPortas.FormattingEnabled = True
        Me.ListaPortas.Location = New System.Drawing.Point(7, 38)
        Me.ListaPortas.Name = "ListaPortas"
        Me.ListaPortas.Size = New System.Drawing.Size(121, 21)
        Me.ListaPortas.TabIndex = 0
        '
        'gbIluminacao
        '
        Me.gbIluminacao.Controls.Add(Me.btnDesligar)
        Me.gbIluminacao.Controls.Add(Me.btnLigar)
        Me.gbIluminacao.Location = New System.Drawing.Point(13, 149)
        Me.gbIluminacao.Name = "gbIluminacao"
        Me.gbIluminacao.Size = New System.Drawing.Size(423, 119)
        Me.gbIluminacao.TabIndex = 1
        Me.gbIluminacao.TabStop = False
        Me.gbIluminacao.Text = "Iluminação"
        '
        'btnDesligar
        '
        Me.btnDesligar.Location = New System.Drawing.Point(332, 59)
        Me.btnDesligar.Name = "btnDesligar"
        Me.btnDesligar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligar.TabIndex = 1
        Me.btnDesligar.Text = "Desligar"
        Me.btnDesligar.UseVisualStyleBackColor = True
        '
        'btnLigar
        '
        Me.btnLigar.Location = New System.Drawing.Point(7, 59)
        Me.btnLigar.Name = "btnLigar"
        Me.btnLigar.Size = New System.Drawing.Size(75, 23)
        Me.btnLigar.TabIndex = 0
        Me.btnLigar.Text = "Ligar"
        Me.btnLigar.UseVisualStyleBackColor = True
        '
        'frmBanheiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 290)
        Me.Controls.Add(Me.gbIluminacao)
        Me.Controls.Add(Me.gbConectar)
        Me.Name = "frmBanheiro"
        Me.Text = "Banheiro"
        Me.gbConectar.ResumeLayout(False)
        Me.gbIluminacao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbConectar As System.Windows.Forms.GroupBox
    Friend WithEvents gbIluminacao As System.Windows.Forms.GroupBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents ListaPortas As System.Windows.Forms.ComboBox
    Friend WithEvents btnDesligar As System.Windows.Forms.Button
    Friend WithEvents btnLigar As System.Windows.Forms.Button
    Friend WithEvents PortSerial As System.IO.Ports.SerialPort
End Class
