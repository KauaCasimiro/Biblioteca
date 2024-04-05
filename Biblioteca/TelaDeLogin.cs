using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            String nome = "DW";
            String senha = "123";

            

            if (nomeTXT.Text != nome && senhaTXT.Text != senha)
            {
                MessageBox.Show("Usuario ou Senha Incorreto!");
            }
            else
            {
                MessageBox.Show("Bem-Vindo " + nome + "!");
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
