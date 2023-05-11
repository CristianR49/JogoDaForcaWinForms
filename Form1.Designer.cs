namespace JogoDaForcaWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtbInputLetra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtbPalavraMisteriosa = new TextBox();
            label3 = new Label();
            picDesenhoForca = new PictureBox();
            txtLetrasJaEscolhidas = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDesenhoForca).BeginInit();
            SuspendLayout();
            // 
            // txtbInputLetra
            // 
            txtbInputLetra.Location = new Point(273, 266);
            txtbInputLetra.Name = "txtbInputLetra";
            txtbInputLetra.Size = new Size(58, 31);
            txtbInputLetra.TabIndex = 0;
            txtbInputLetra.KeyDown += txtbInputLetra_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 238);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 3;
            label1.Text = "Digite uma letra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 318);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 5;
            label2.Text = "Letras já escolhidas:";
            // 
            // txtbPalavraMisteriosa
            // 
            txtbPalavraMisteriosa.Location = new Point(273, 188);
            txtbPalavraMisteriosa.Name = "txtbPalavraMisteriosa";
            txtbPalavraMisteriosa.Size = new Size(157, 31);
            txtbPalavraMisteriosa.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 160);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 7;
            label3.Text = "Palavra misteriosa:";
            // 
            // picDesenhoForca
            // 
            picDesenhoForca.Image = Properties.Resources.Forca0;
            picDesenhoForca.Location = new Point(-10, -9);
            picDesenhoForca.Name = "picDesenhoForca";
            picDesenhoForca.Size = new Size(580, 485);
            picDesenhoForca.TabIndex = 8;
            picDesenhoForca.TabStop = false;
            // 
            // txtLetrasJaEscolhidas
            // 
            txtLetrasJaEscolhidas.Location = new Point(273, 346);
            txtLetrasJaEscolhidas.Multiline = true;
            txtLetrasJaEscolhidas.Name = "txtLetrasJaEscolhidas";
            txtLetrasJaEscolhidas.Size = new Size(167, 114);
            txtLetrasJaEscolhidas.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Cyan;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(273, 48);
            label4.Name = "label4";
            label4.Size = new Size(272, 54);
            label4.TabIndex = 10;
            label4.Text = "Jogo Da Forca";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 472);
            Controls.Add(label4);
            Controls.Add(txtLetrasJaEscolhidas);
            Controls.Add(label3);
            Controls.Add(txtbPalavraMisteriosa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbInputLetra);
            Controls.Add(picDesenhoForca);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDesenhoForca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbInputLetra;
        private Label label1;
        private Label label2;
        private TextBox txtbPalavraMisteriosa;
        private Label label3;
        private PictureBox picDesenhoForca;
        private TextBox txtLetrasJaEscolhidas;
        private Label label4;
    }
}