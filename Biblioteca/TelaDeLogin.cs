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
    public partial class telaDeLogin : Form
    {
        public telaDeLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nome = "DW";
            string senha = "123";

            if (nameTB.Text != nome && senhaTB.Text != senha)
            {
                MessageBox.Show("Usuario ou senha incorreto");
                nameTB.Clear();
                senhaTB.Clear();
            }
            else
            {
                this.Hide();
                MessageBox.Show("Bem-Vindo " + nome + "!");
                MDIParent1 form = new MDIParent1();
                form.Show();
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
