<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuarto2
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PortSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.btnLigar = New System.Windows.Forms.Button()
        Me.btnDesligar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn2)
        Me.GroupBox1.Controls.Add(Me.Btn1)
        Me.GroupBox1.Controls.Add(Me.ListaPortas)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conectar a Porta Serial"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(265, 30)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Alterar Porta"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(171, 30)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Conectar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'ListaPortas
        '
        Me.ListaPortas.FormattingEnabled = True
        Me.ListaPortas.Location = New System.Drawing.Point(18, 32)
        Me.ListaPortas.Name = "ListaPortas"
        Me.ListaPortas.Size = New System.Drawing.Size(121, 21)
        Me.ListaPortas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDesligar)
        Me.GroupBox2.Controls.Add(Me.btnLigar)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Iluminação"
        '
        'btnLigar
        '
        Me.btnLigar.Location = New System.Drawing.Point(18, 47)
        Me.btnLigar.Name = "btnLigar"
        Me.btnLigar.Size = New System.Drawing.Size(75, 23)
        Me.btnLigar.TabIndex = 0
        Me.btnLigar.Text = "Ligar"
        Me.btnLigar.UseVisualStyleBackColor = True
        '
        'btnDesligar
        '
        Me.btnDesligar.Location = New System.Drawing.Point(281, 47)
        Me.btnDesligar.Name = "btnDesligar"
        Me.btnDesligar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligar.TabIndex = 1
        Me.btnDesligar.Text = "Desligar"
        Me.btnDesligar.UseVisualStyleBackColor = True
        '
        'frmQuarto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 320)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQuarto2"
        Me.Text = "Quarto 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents ListaPortas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PortSerial As System.IO.Ports.SerialPort
    Friend WithEvents btnDesligar As System.Windows.Forms.Button
    Friend WithEvents btnLigar As System.Windows.Forms.Button
End Class
