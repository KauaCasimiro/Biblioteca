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
    public partial class Locatario : Form
    {
        public Locatario()
        {
            InitializeComponent();
        }

        private void locatarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locatarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaBDDataSet);

        }

        private void Locatario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaBDDataSet.Locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bibliotecaBDDataSet.Locatario);

        }

        private void dataNascimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cPFLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
