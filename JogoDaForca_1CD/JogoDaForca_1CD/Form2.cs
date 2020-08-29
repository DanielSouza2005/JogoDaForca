using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaForca_1CD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("UTILIZE APENAS LETRAS MAIÚSCULAS");
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (tbDica.Text != "" & tbPalavra.Text != "")
            {
                tbPalavra.Text = tbPalavra.Text.ToUpper();
                tbDica.Text = tbDica.Text.ToUpper();
                Int32 qtAtualDePalavras;
                qtAtualDePalavras = Convert.ToInt32(
                    System.IO.File.ReadAllText(@"" + Form1.endereço + "total.txt"));
                qtAtualDePalavras++;
                System.IO.File.WriteAllText(@"" + Form1.endereço + Convert.ToString(
                    qtAtualDePalavras) + ".txt", tbPalavra.Text);
                System.IO.File.WriteAllText(@"" + Form1.endereço + Convert.ToString(
                    qtAtualDePalavras) + "_Dica.txt", tbDica.Text);
                tbPalavra.Text = "";
                tbDica.Text = "";
                System.IO.File.WriteAllText(@"" + Form1.endereço + "total.txt",
                    Convert.ToString(qtAtualDePalavras));
            }
            else
                MessageBox.Show("POR FAVOR:"
                    + Environment.NewLine +
                    "DIGITE UMA PALAVRA E UMA DICA");
        }
    }
}
