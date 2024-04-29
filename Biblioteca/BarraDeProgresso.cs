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
    public partial class barraDeProgresso : Form
    {
        public barraDeProgresso()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barra.Value < 100)
            {
                barra.Value = barra.Value += 1;
            }

            if (barra.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                MessageBox.Show("Bem-Vindo!");
                telaDeLogin telaDeLogin = new telaDeLogin();
                telaDeLogin.Show();
            }
        }
    }
}
