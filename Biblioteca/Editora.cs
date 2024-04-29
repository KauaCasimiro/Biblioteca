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
    public partial class Editora : Form
    {
        public Editora()
        {
            InitializeComponent();
        }

        private void editoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.editoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaBDDataSet);

        }

        private void Editora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaBDDataSet.Editora'. Você pode movê-la ou removê-la conforme necessário.
            this.editoraTableAdapter.Fill(this.bibliotecaBDDataSet.Editora);

        }

        private void cidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cNPJLabel_Click(object sender, EventArgs e)
        {

        }

        private void cNPJTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cEPLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
