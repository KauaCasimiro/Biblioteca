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
    public partial class Livro : Form
    {
        public Livro()
        {
            InitializeComponent();
        }

        private void livroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaBDDataSet);

        }

        private void Livro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaBDDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.bibliotecaBDDataSet.Livro);

        }
    }
}
