<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCozinha
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDesligar = New System.Windows.Forms.Button()
        Me.btnLigar = New System.Windows.Forms.Button()
        Me.PortSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.gbConectar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbConectar
        '
        Me.gbConectar.Controls.Add(Me.Btn2)
        Me.gbConectar.Controls.Add(Me.Btn1)
        Me.gbConectar.Controls.Add(Me.ListaPortas)
        Me.gbConectar.Location = New System.Drawing.Point(12, 12)
        Me.gbConectar.Name = "gbConectar"
        Me.gbConectar.Size = New System.Drawing.Size(405, 104)
        Me.gbConectar.TabIndex = 0
        Me.gbConectar.TabStop = False
        Me.gbConectar.Text = "Conectar a Porta Serial"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(303, 37)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Alterar Porta"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(177, 37)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Conectar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'ListaPortas
        '
        Me.ListaPortas.FormattingEnabled = True
        Me.ListaPortas.Location = New System.Drawing.Point(7, 37)
        Me.ListaPortas.Name = "ListaPortas"
        Me.ListaPortas.Size = New System.Drawing.Size(121, 21)
        Me.ListaPortas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDesligar)
        Me.GroupBox2.Controls.Add(Me.btnLigar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Iluminação"
        '
        'btnDesligar
        '
        Me.btnDesligar.Location = New System.Drawing.Point(303, 48)
        Me.btnDesligar.Name = "btnDesligar"
        Me.btnDesligar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligar.TabIndex = 1
        Me.btnDesligar.Text = "Desligar"
        Me.btnDesligar.UseVisualStyleBackColor = True
        '
        'btnLigar
        '
        Me.btnLigar.Location = New System.Drawing.Point(7, 48)
        Me.btnLigar.Name = "btnLigar"
        Me.btnLigar.Size = New System.Drawing.Size(75, 23)
        Me.btnLigar.TabIndex = 0
        Me.btnLigar.Text = "Ligar"
        Me.btnLigar.UseVisualStyleBackColor = True
        '
        'frmCozinha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 306)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbConectar)
        Me.Name = "frmCozinha"
        Me.Text = "Cozinha"
        Me.gbConectar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbConectar As System.Windows.Forms.GroupBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents ListaPortas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDesligar As System.Windows.Forms.Button
    Friend WithEvents btnLigar As System.Windows.Forms.Button
    Friend WithEvents PortSerial As System.IO.Ports.SerialPort
End Class
