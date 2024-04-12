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

        private void enviarBT_Click(object sender, EventArgs e)
        {
            string nome = "DW";
            string senha = "123";

            if (nomeTB.Text != nome || senhaTB.Text != senha)
            {
                MessageBox.Show("Usuario ou senha incorretos");
                nomeTB.Clear();
                senhaTB.Clear();
            }
            else
            {
                MessageBox.Show("Bem-Vindo " + nome + "!");
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
        }

        private void sairBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
