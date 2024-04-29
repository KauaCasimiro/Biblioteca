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
    public partial class BarraDeProgresso : Form
    {
        public BarraDeProgresso()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barra.Value < 100)
            {
                barra.Value++;

                if (barra.Value == 100)
                {
                    TelaDeLogin login = new TelaDeLogin();
                    this.Hide();
                    MessageBox.Show("Bem-Vindo!");
                    login.Show();
                }
            }
        }
    }
}
