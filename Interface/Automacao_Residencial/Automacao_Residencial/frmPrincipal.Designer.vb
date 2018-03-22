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
        Me.btnGaragem = New System.Windows.Forms.Button()
        Me.btnSala = New System.Windows.Forms.Button()
        Me.btnQuarto1 = New System.Windows.Forms.Button()
        Me.btnQuarto2 = New System.Windows.Forms.Button()
        Me.btnQuarto3 = New System.Windows.Forms.Button()
        Me.btnCozinha = New System.Windows.Forms.Button()
        Me.btnBanheiro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGaragem
        '
        Me.btnGaragem.Location = New System.Drawing.Point(31, 23)
        Me.btnGaragem.Name = "btnGaragem"
        Me.btnGaragem.Size = New System.Drawing.Size(75, 23)
        Me.btnGaragem.TabIndex = 0
        Me.btnGaragem.Text = "Garagem"
        Me.btnGaragem.UseVisualStyleBackColor = True
        '
        'btnSala
        '
        Me.btnSala.Location = New System.Drawing.Point(121, 23)
        Me.btnSala.Name = "btnSala"
        Me.btnSala.Size = New System.Drawing.Size(75, 23)
        Me.btnSala.TabIndex = 1
        Me.btnSala.Text = "Sala"
        Me.btnSala.UseVisualStyleBackColor = True
        '
        'btnQuarto1
        '
        Me.btnQuarto1.Location = New System.Drawing.Point(217, 23)
        Me.btnQuarto1.Name = "btnQuarto1"
        Me.btnQuarto1.Size = New System.Drawing.Size(75, 23)
        Me.btnQuarto1.TabIndex = 2
        Me.btnQuarto1.Text = "Quarto 1"
        Me.btnQuarto1.UseVisualStyleBackColor = True
        '
        'btnQuarto2
        '
        Me.btnQuarto2.Location = New System.Drawing.Point(319, 23)
        Me.btnQuarto2.Name = "btnQuarto2"
        Me.btnQuarto2.Size = New System.Drawing.Size(75, 23)
        Me.btnQuarto2.TabIndex = 3
        Me.btnQuarto2.Text = "Quarto 2"
        Me.btnQuarto2.UseVisualStyleBackColor = True
        '
        'btnQuarto3
        '
        Me.btnQuarto3.Location = New System.Drawing.Point(85, 75)
        Me.btnQuarto3.Name = "btnQuarto3"
        Me.btnQuarto3.Size = New System.Drawing.Size(75, 23)
        Me.btnQuarto3.TabIndex = 4
        Me.btnQuarto3.Text = "Quarto 3"
        Me.btnQuarto3.UseVisualStyleBackColor = True
        '
        'btnCozinha
        '
        Me.btnCozinha.Location = New System.Drawing.Point(175, 75)
        Me.btnCozinha.Name = "btnCozinha"
        Me.btnCozinha.Size = New System.Drawing.Size(75, 23)
        Me.btnCozinha.TabIndex = 5
        Me.btnCozinha.Text = "Cozinha"
        Me.btnCozinha.UseVisualStyleBackColor = True
        '
        'btnBanheiro
        '
        Me.btnBanheiro.Location = New System.Drawing.Point(271, 75)
        Me.btnBanheiro.Name = "btnBanheiro"
        Me.btnBanheiro.Size = New System.Drawing.Size(75, 23)
        Me.btnBanheiro.TabIndex = 6
        Me.btnBanheiro.Text = "Banheiro"
        Me.btnBanheiro.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 116)
        Me.Controls.Add(Me.btnBanheiro)
        Me.Controls.Add(Me.btnCozinha)
        Me.Controls.Add(Me.btnQuarto3)
        Me.Controls.Add(Me.btnQuarto2)
        Me.Controls.Add(Me.btnQuarto1)
        Me.Controls.Add(Me.btnSala)
        Me.Controls.Add(Me.btnGaragem)
        Me.Name = "frmPrincipal"
        Me.Text = "Automação Residencial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGaragem As System.Windows.Forms.Button
    Friend WithEvents btnSala As System.Windows.Forms.Button
    Friend WithEvents btnQuarto1 As System.Windows.Forms.Button
    Friend WithEvents btnQuarto2 As System.Windows.Forms.Button
    Friend WithEvents btnQuarto3 As System.Windows.Forms.Button
    Friend WithEvents btnCozinha As System.Windows.Forms.Button
    Friend WithEvents btnBanheiro As System.Windows.Forms.Button

End Class
