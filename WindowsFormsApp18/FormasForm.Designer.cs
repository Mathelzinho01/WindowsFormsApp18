namespace WindowsFormsApp18
{
    partial class FormasForm
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
            this.cmbFormas = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pnlFormaInputs = new System.Windows.Forms.Panel();
            this.btnCalcularForma = new System.Windows.Forms.Button();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLado4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFormas
            // 
            this.cmbFormas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbFormas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormas.FormattingEnabled = true;
            this.cmbFormas.Items.AddRange(new object[] {
            "Triângulo",
            "Quadrilátero",
            "Círculo"});
            this.cmbFormas.Location = new System.Drawing.Point(403, 106);
            this.cmbFormas.Name = "cmbFormas";
            this.cmbFormas.Size = new System.Drawing.Size(129, 26);
            this.cmbFormas.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(465, 69);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(84, 18);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblFormaResultado_Click);
            // 
            // pnlFormaInputs
            // 
            this.pnlFormaInputs.BackColor = System.Drawing.Color.DarkSalmon;
            this.pnlFormaInputs.Location = new System.Drawing.Point(403, 138);
            this.pnlFormaInputs.Name = "pnlFormaInputs";
            this.pnlFormaInputs.Size = new System.Drawing.Size(206, 126);
            this.pnlFormaInputs.TabIndex = 2;
            // 
            // btnCalcularForma
            // 
            this.btnCalcularForma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcularForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularForma.Location = new System.Drawing.Point(176, 258);
            this.btnCalcularForma.Name = "btnCalcularForma";
            this.btnCalcularForma.Size = new System.Drawing.Size(103, 31);
            this.btnCalcularForma.TabIndex = 3;
            this.btnCalcularForma.Text = "Calcular";
            this.btnCalcularForma.UseVisualStyleBackColor = false;
            this.btnCalcularForma.Click += new System.EventHandler(this.btnCalcularForma_Click);
            // 
            // txtLado2
            // 
            this.txtLado2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLado2.Location = new System.Drawing.Point(163, 180);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(130, 20);
            this.txtLado2.TabIndex = 4;
            // 
            // txtLado3
            // 
            this.txtLado3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLado3.Location = new System.Drawing.Point(163, 206);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(130, 20);
            this.txtLado3.TabIndex = 5;
            // 
            // txtLado1
            // 
            this.txtLado1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLado1.Location = new System.Drawing.Point(163, 154);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(130, 20);
            this.txtLado1.TabIndex = 6;
            // 
            // txtDiametro
            // 
            this.txtDiametro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDiametro.Location = new System.Drawing.Point(163, 90);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(130, 20);
            this.txtDiametro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diametro";
            // 
            // txtLado4
            // 
            this.txtLado4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLado4.Location = new System.Drawing.Point(163, 232);
            this.txtLado4.Name = "txtLado4";
            this.txtLado4.Size = new System.Drawing.Size(130, 20);
            this.txtLado4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lados";
            // 
            // FormasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLado4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.btnCalcularForma);
            this.Controls.Add(this.pnlFormaInputs);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbFormas);
            this.Name = "FormasForm";
            this.Text = "FormasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFormas;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel pnlFormaInputs;
        private System.Windows.Forms.Button btnCalcularForma;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLado4;
        private System.Windows.Forms.Label label2;
    }
}