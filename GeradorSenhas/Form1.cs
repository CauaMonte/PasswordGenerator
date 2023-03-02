using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorSenhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string charPos = "";

        private void btGerar_Click(object sender, EventArgs e)
        {
            string validate = boxQtd.Text;
            int qtd;

            while (!int.TryParse(validate, out qtd))
            {
                MessageBox.Show("Digite a quantidade de caracteres!");
                return; 
            }
            

            Random sorteio = new Random();
            int numSorteio = 0;

            StringBuilder senha = new StringBuilder();

            while (charPos == "")
            {
                MessageBox.Show("Selecione ao menos 1 campo!");
                return;
            }

            for (int i = 0; i < qtd; i++)
            {

                numSorteio = sorteio.Next(0, charPos.Length -1);

                senha.Append(charPos[numSorteio]);
            }

            textSenha.Text = senha.ToString();
            password = senha.ToString();

        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            string copia = textSenha.Text;
            if (textSenha == null | string.IsNullOrEmpty(textSenha.Text))
            {
                MessageBox.Show("Não há nada a ser copiado!");
            }
            else
            {
                Clipboard.SetText(copia);
                MessageBox.Show("Senha copiada para a área de transferência");
            }
        }

        List<string> saveList = new List<string>();
        public string password;

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string newPassword = textSenha.Text;
            saveList.Add(newPassword); 

            textSave.Clear();

            foreach (string senha in saveList)
            {
                textSave.AppendText(senha + Environment.NewLine);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            textSave.Clear();
            saveList.Clear();
        }

        private void btCopiarTudo_Click(object sender, EventArgs e)
        {
            string copia = textSave.Text;
            if (textSave == null | string.IsNullOrEmpty(textSave.Text))
            {
                MessageBox.Show("Não há nada a ser copiado!");
            }
            else
            {
                Clipboard.SetText(copia);
                MessageBox.Show("Senhas copiadas para a área de transferência");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boxQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!=(char)8) 
            {
                e.Handled = true;
            }
        }

        private void cbEspec_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbEspec.Checked)
            {
                charPos += "@#$%&";
            }
            if (!cbEspec.Checked)
            {
                charPos = charPos.Replace("@#$%&","");
            }
        }

        private void cbNum_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbNum.Checked)
            {
                charPos +="123456789012345678901234567890";
            }
            else
            {
                charPos = charPos.Replace("123456789012345678901234567890", "");
            }
        }

        private void cbLower_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbLower.Checked)
            {
                charPos += "QWERTYUIOPASDFGHJKLZXCVBNM".ToLower();
            }
            else 
            {
                charPos = charPos.Replace("QWERTYUIOPASDFGHJKLZXCVBNM".ToLower(), "");
            }
        }

        private void cbUpper_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbUpper.Checked)
            {
                charPos += "QWERTYUIOPASDFGHJKLZXCVBNM";
            }
            else
            {
                charPos = charPos.Replace("QWERTYUIOPASDFGHJKLZXCVBNM","");
            }
        }
    }
}
