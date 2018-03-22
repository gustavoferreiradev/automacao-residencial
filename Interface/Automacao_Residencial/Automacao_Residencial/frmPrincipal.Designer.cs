namespace Automacao_Residencial
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSala = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnGaragem = new System.Windows.Forms.Button();
            this.btnQuarto1 = new System.Windows.Forms.Button();
            this.btnQuarto2 = new System.Windows.Forms.Button();
            this.btnQuarto3 = new System.Windows.Forms.Button();
            this.btnBanheiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSala
            // 
            this.btnSala.Location = new System.Drawing.Point(103, 57);
            this.btnSala.Name = "btnSala";
            this.btnSala.Size = new System.Drawing.Size(75, 23);
            this.btnSala.TabIndex = 0;
            this.btnSala.Text = "Sala";
            this.btnSala.UseVisualStyleBackColor = true;
            this.btnSala.Click += new System.EventHandler(this.btnSala_Click);
            // 
            // btnGaragem
            // 
            this.btnGaragem.Location = new System.Drawing.Point(103, 19);
            this.btnGaragem.Name = "btnGaragem";
            this.btnGaragem.Size = new System.Drawing.Size(75, 23);
            this.btnGaragem.TabIndex = 1;
            this.btnGaragem.Text = "Garagem";
            this.btnGaragem.UseVisualStyleBackColor = true;
            // 
            // btnQuarto1
            // 
            this.btnQuarto1.Location = new System.Drawing.Point(103, 96);
            this.btnQuarto1.Name = "btnQuarto1";
            this.btnQuarto1.Size = new System.Drawing.Size(75, 23);
            this.btnQuarto1.TabIndex = 2;
            this.btnQuarto1.Text = "Quarto 1";
            this.btnQuarto1.UseVisualStyleBackColor = true;
            this.btnQuarto1.Click += new System.EventHandler(this.btnQuarto1_Click);
            // 
            // btnQuarto2
            // 
            this.btnQuarto2.Location = new System.Drawing.Point(103, 136);
            this.btnQuarto2.Name = "btnQuarto2";
            this.btnQuarto2.Size = new System.Drawing.Size(75, 23);
            this.btnQuarto2.TabIndex = 3;
            this.btnQuarto2.Text = "Quarto 2";
            this.btnQuarto2.UseVisualStyleBackColor = true;
            // 
            // btnQuarto3
            // 
            this.btnQuarto3.Location = new System.Drawing.Point(103, 176);
            this.btnQuarto3.Name = "btnQuarto3";
            this.btnQuarto3.Size = new System.Drawing.Size(75, 23);
            this.btnQuarto3.TabIndex = 4;
            this.btnQuarto3.Text = "Quarto 3";
            this.btnQuarto3.UseVisualStyleBackColor = true;
            // 
            // btnBanheiro
            // 
            this.btnBanheiro.Location = new System.Drawing.Point(103, 216);
            this.btnBanheiro.Name = "btnBanheiro";
            this.btnBanheiro.Size = new System.Drawing.Size(75, 23);
            this.btnBanheiro.TabIndex = 5;
            this.btnBanheiro.Text = "Banheiro";
            this.btnBanheiro.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 275);
            this.Controls.Add(this.btnBanheiro);
            this.Controls.Add(this.btnQuarto3);
            this.Controls.Add(this.btnQuarto2);
            this.Controls.Add(this.btnQuarto1);
            this.Controls.Add(this.btnGaragem);
            this.Controls.Add(this.btnSala);
            this.Name = "frmPrincipal";
            this.Text = "Selecione o Cômodo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSala;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnGaragem;
        private System.Windows.Forms.Button btnQuarto1;
        private System.Windows.Forms.Button btnQuarto2;
        private System.Windows.Forms.Button btnQuarto3;
        private System.Windows.Forms.Button btnBanheiro;
    }
}

