using System;
using System.Collections;

namespace JogoDaForcaWinForms
{
    public partial class Form1 : Form
    {
        List<string> frutas;
        string palavraMisteriosa;
        string[] palavraEscondidaArray;
        string letraInputada;
        int chances;

        public Form1()
        {
            InitializeComponent();
            GravarFrutas();
            GravarChances();
            EscolherPalavraMisteriosa();
            MostrarTamanhoPalavraMisteriosa();

        }

        private void Aviso1()
        {
            MessageBox.Show("Aviso1");
        }

        private void Aviso2()
        {
            MessageBox.Show("Aviso2");
        }

        private void GravarChances()
        {
            chances = 6;
        }

        private void EscolherPalavraMisteriosa()
        {
            Random numeroAleatorio = new Random();
            palavraMisteriosa = frutas[numeroAleatorio.Next(0, 28)];
        }

        private void MostrarTamanhoPalavraMisteriosa()
        {
            palavraEscondidaArray = new string[palavraMisteriosa.Length];
            for (int i = 0; i < palavraMisteriosa.Length; i++)
            {
                txtbPalavraMisteriosa.Text += "_";
                palavraEscondidaArray[i] = "_";
            }

        }

        private void VerificarSeOChuteAcertou()
        {
            txtLetrasJaEscolhidas.Text += txtbInputLetra.Text.ToUpper() + " ";
            bool errou = true;
            for (int i = 0; i < palavraMisteriosa.Length; i++)
            {
                errou = Acertou(errou, i);


            }
            string palavraEscondida = string.Join("", palavraEscondidaArray);
            txtbPalavraMisteriosa.Text = palavraEscondida;
            txtbInputLetra.Text = "";
            if (errou == true)
                Errou();
            Ganhou();
        }

        private void Ganhou()
        {
            if (!txtbPalavraMisteriosa.Text.Contains('_'))
            {
                MessageBox.Show("Parabéns! Você ganhou! A palavra era " + palavraMisteriosa);
                Recomecar();
            }
        }

        private bool Acertou(bool errou, int i)
        {
            if (letraInputada == Convert.ToString(palavraMisteriosa[i]))
            {
                palavraEscondidaArray[i] = letraInputada;
                errou = false;
            }

            return errou;
        }

        private void Errou()
        {
            chances--;

            switch (chances)
            {
                case 6:
                    {
                        picDesenhoForca.Image = Properties.Resources.Forca0;
                        break;
                    }
                case 5:
                    {
                        picDesenhoForca.Image = Properties.Resources.Forca1;
                        break;
                    }
                case 4:
                    {
                        picDesenhoForca.Image = Properties.Resources.Forca2;
                        break;
                    }
                case 3:
                    {
                        picDesenhoForca.Image = Properties.Resources.Forca3;
                        break;
                    }
                case 2:
                    {
                        picDesenhoForca.Image = Properties.Resources.Forca4;
                        break;
                    }
                case 1:
                    {
                        picDesenhoForca.Image = Properties.Resources.Forca5;
                        break;
                    }
                case 0:
                    {
                        picDesenhoForca.Image = Properties.Resources.Forca6;
                        break;
                    }

            }

            AcabaramAsChances();

        }

        private void AcabaramAsChances()
        {
            if (chances == 0)
            {
                MessageBox.Show("Acabaram as tentativas! Você perdeu! A palavra era " + palavraMisteriosa);
                Recomecar();
            }
        }

        private void Recomecar()
        {
            GravarChances();
            LimparCampos();
            EscolherPalavraMisteriosa();
            MostrarTamanhoPalavraMisteriosa();
        }

        private void LimparCampos()
        {
            txtbPalavraMisteriosa.Text = "";
            txtLetrasJaEscolhidas.Text = "";
            picDesenhoForca.Image = Properties.Resources.Forca0;

        }

        public void GravarFrutas()
        {
            string[] frutasArray = new string[29] {"ABACAXI", "ACEROLA", "ACAI", "ARACA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJA",
             "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA",
             "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};
            frutas = new List<string>(frutasArray);

        }
        private void txtbInputLetra_KeyDown(object sender, KeyEventArgs e)
        {
            Control controle = (Control)sender;
            controle.Focus();
            if (e.KeyCode == Keys.Enter)
            {
                letraInputada = txtbInputLetra.Text.ToUpper();
                VerificarSeOChuteAcertou();
                e.SuppressKeyPress = true;
            }
        }
    }
}