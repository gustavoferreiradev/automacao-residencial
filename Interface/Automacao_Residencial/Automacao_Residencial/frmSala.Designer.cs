namespace Automacao_Residencial
{
    partial class frmSala
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
            this.gbIluminacao = new System.Windows.Forms.GroupBox();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.gbVentilador = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gbIluminacao.SuspendLayout();
            this.gbVentilador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIluminacao
            // 
            this.gbIluminacao.Controls.Add(this.btnDesligar);
            this.gbIluminacao.Controls.Add(this.btnLigar);
            this.gbIluminacao.Location = new System.Drawing.Point(304, 34);
            this.gbIluminacao.Name = "gbIluminacao";
            this.gbIluminacao.Size = new System.Drawing.Size(269, 106);
            this.gbIluminacao.TabIndex = 0;
            this.gbIluminacao.TabStop = false;
            this.gbIluminacao.Text = "Iluminação";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(142, 50);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(75, 23);
            this.btnDesligar.TabIndex = 1;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(36, 50);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(75, 23);
            this.btnLigar.TabIndex = 0;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // gbVentilador
            // 
            this.gbVentilador.Controls.Add(this.trackBar1);
            this.gbVentilador.Location = new System.Drawing.Point(27, 172);
            this.gbVentilador.Name = "gbVentilador";
            this.gbVentilador.Size = new System.Drawing.Size(847, 103);
            this.gbVentilador.TabIndex = 1;
            this.gbVentilador.TabStop = false;
            this.gbVentilador.Text = "Ventilador";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(17, 29);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(824, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // frmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 344);
            this.Controls.Add(this.gbVentilador);
            this.Controls.Add(this.gbIluminacao);
            this.Name = "frmSala";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.frmSala_Load);
            this.gbIluminacao.ResumeLayout(false);
            this.gbVentilador.ResumeLayout(false);
            this.gbVentilador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIluminacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.GroupBox gbVentilador;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}