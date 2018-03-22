namespace Automacao_Residencial
{
    partial class frmGaragem
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
            this.gbPortao = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPortao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPortao
            // 
            this.gbPortao.Controls.Add(this.button2);
            this.gbPortao.Controls.Add(this.button1);
            this.gbPortao.Location = new System.Drawing.Point(24, 12);
            this.gbPortao.Name = "gbPortao";
            this.gbPortao.Size = new System.Drawing.Size(312, 197);
            this.gbPortao.TabIndex = 0;
            this.gbPortao.TabStop = false;
            this.gbPortao.Text = "Portão";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 328);
            this.Controls.Add(this.gbPortao);
            this.Name = "frmGaragem";
            this.Text = "Garagem";
            this.gbPortao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPortao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}