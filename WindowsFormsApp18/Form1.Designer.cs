namespace WindowsFormsApp18
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIMC = new System.Windows.Forms.Button();
            this.btnFormas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIMC
            // 
            this.btnIMC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMC.Location = new System.Drawing.Point(106, 118);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(267, 184);
            this.btnIMC.TabIndex = 0;
            this.btnIMC.Text = "Calculadora de IMC";
            this.btnIMC.UseVisualStyleBackColor = false;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // btnFormas
            // 
            this.btnFormas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFormas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormas.Location = new System.Drawing.Point(425, 118);
            this.btnFormas.Name = "btnFormas";
            this.btnFormas.Size = new System.Drawing.Size(282, 184);
            this.btnFormas.TabIndex = 1;
            this.btnFormas.Text = "Formas Geométricas";
            this.btnFormas.UseVisualStyleBackColor = false;
            this.btnFormas.Click += new System.EventHandler(this.btnFormas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormas);
            this.Controls.Add(this.btnIMC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Button btnFormas;
    }
}

