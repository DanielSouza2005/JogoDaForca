using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace JogoDaForca_1CD
{
    public partial class Form1 : Form
    {
        //VARIÁVEIS
        public static string endereço = @"palavras\", palavra_sorteada;
        Int32 total_palavras_cadastradas, número_de_letras;
        Int32 arquivo_sorteado;
        Int32 contador_de_erros = 0, contador_de_letras_certas = 0;
        char[] letras_acertas = new char[50];
        
        //MÉTODOS
        Int32 sortear_arquivo()
        {
            Random palavra = new Random();
            //abaixo tem 1 a mais porque a função de sorteio
            //sorteia um a menos que o limite superior
            return palavra.Next(1, total_palavras_cadastradas + 1);
        }

        private void Frm2_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btJogoar_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            btTentar.Visible = true;
            tbLetra.Visible = true;
            btJogoar.Visible = false;
            btCadastrar.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            tbLetra.Focus();
            MessageBox.Show("UTILIZAE APENAS MAIÚSCULAS");
        }

        private void btJogarNovamente_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btTentar_Click(object sender, EventArgs e)
        {
            tbLetra.Text = tbLetra.Text.ToUpper();
            if(tbLetra.Text != "" & tbLetra.Text.Length == 1)
            {
                label2.Text = "";
                char[] letras = new char[50];
                Int32 contador = 0;
                bool estado_do_contador_de_erros = true;

                while(contador < número_de_letras)
                {
                    letras[contador] = palavra_sorteada[contador];
                    if(Convert.ToChar(tbLetra.Text) == letras[contador])
                    {
                        letras_acertas[contador] = letras[contador];
                        contador_de_letras_certas++;
                        estado_do_contador_de_erros = false;
                    }

                    if (letras_acertas[contador] == Convert.ToChar("-"))
                    {
                        label2.Text = label2.Text + "- ";
                    }
                    else
                        label2.Text = label2.Text +
                            Convert.ToString(letras_acertas[contador])
                            + " ";
                    contador++;
                }
                if(estado_do_contador_de_erros == true)
                {
                    contador_de_erros++;
                    label3.Visible = true;
                    label4.Visible = true;
                    label3.Text = "ERROS: " +
                        Convert.ToString(contador_de_erros);
                    label4.Text = label4.Text + tbLetra.Text + " ";
                }
                if(contador_de_erros == 3)
                {
                    MessageBox.Show("GAME OVER"
                        + Environment.NewLine +
                        "RESP: " + palavra_sorteada);
                    btTentar.Enabled = false;
                    btJogarNovamente.Visible = true;
                }
                if(contador_de_letras_certas == número_de_letras)
                {
                    MessageBox.Show("PARABÉNS");
                    btTentar.Enabled = false;
                    btJogarNovamente.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("DIGITE UMA LETRA");
                tbLetra.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NECESSÁRIO PARA TRANSFORMAR EM PALAVRA NO BOTÃO TENTAR
            Int32 c = 0;
            while (c < 50)
            {
                letras_acertas[c] = Convert.ToChar("-");
                c++;
            }

            label3.Visible = true;
            label4.Visible = true;
            label3.Text = "";
            label4.Text = "";
            label5.Visible = false;
            btTentar.Visible = false;
            btJogarNovamente.Visible = false;
            tbLetra.Visible = false;
                     

            total_palavras_cadastradas = Convert.ToInt32(
            System.IO.File.ReadAllText("palavras\\total.txt"));

            arquivo_sorteado = sortear_arquivo();

            //LE A PALAVRA DA FORCA
            palavra_sorteada = System.IO.File.ReadAllText("palavras\\" +
                Convert.ToString(arquivo_sorteado) + ".txt");

            //LE A DICA DA FORCA
            label1.Text = System.IO.File.ReadAllText("palavras\\" +
                Convert.ToString(arquivo_sorteado) + "_Dica.txt");
            label2.Text = "";
            número_de_letras = palavra_sorteada.Length;
            Int32 contador = 1;
            while (contador <= número_de_letras)
            {
                label2.Text = label2.Text + "- ";
                contador++;
            }
            label1.Visible = false;
            label2.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lbSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advinhe a Palavra" +
                Environment.NewLine +
                "Versão 0.1");
        }

        //BOTÃO CADASTRAR
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            frm2.FormClosing += Frm2_Closing;
        }
    }
}
