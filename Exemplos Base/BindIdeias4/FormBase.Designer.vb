<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBase
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
        Me.PortSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.ListaPortas = New System.Windows.Forms.ComboBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.LogAcoes = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Group.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group
        '
        Me.Group.Controls.Add(Me.ListaPortas)
        Me.Group.Controls.Add(Me.Btn1)
        Me.Group.Controls.Add(Me.Btn2)
        Me.Group.Location = New System.Drawing.Point(6, 2)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(358, 51)
        Me.Group.TabIndex = 9
        Me.Group.TabStop = False
        Me.Group.Text = "Porta"
        '
        'ListaPortas
        '
        Me.ListaPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListaPortas.FormattingEnabled = True
        Me.ListaPortas.Items.AddRange(New Object() {"--"})
        Me.ListaPortas.Location = New System.Drawing.Point(6, 21)
        Me.ListaPortas.Name = "ListaPortas"
        Me.ListaPortas.Size = New System.Drawing.Size(133, 21)
        Me.ListaPortas.TabIndex = 0
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(145, 19)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(100, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Conectar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Enabled = False
        Me.Btn2.Location = New System.Drawing.Point(250, 19)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(100, 23)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Alterar Porta"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'LogAcoes
        '
        Me.LogAcoes.FormattingEnabled = True
        Me.LogAcoes.Location = New System.Drawing.Point(12, 158)
        Me.LogAcoes.Name = "LogAcoes"
        Me.LogAcoes.ScrollAlwaysVisible = True
        Me.LogAcoes.Size = New System.Drawing.Size(344, 173)
        Me.LogAcoes.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 201)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 74)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Intesidade do Led"
        '
        'TrackBar1
        '
        Me.TrackBar1.Enabled = False
        Me.TrackBar1.Location = New System.Drawing.Point(6, 20)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(344, 45)
        Me.TrackBar1.SmallChange = 0
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickFrequency = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 510)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Group)
        Me.Controls.Add(Me.LogAcoes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBase"
        Me.Text = "Automação Residencial"
        Me.Group.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PortSerial As System.IO.Ports.SerialPort
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents ListaPortas As System.Windows.Forms.ComboBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents LogAcoes As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
