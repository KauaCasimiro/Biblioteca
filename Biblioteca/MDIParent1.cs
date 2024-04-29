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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.MdiParent = this;
            livro.Show();

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void locatárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locatario locatario = new Locatario();
            locatario.MdiParent = this;
            locatario.Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editora editora = new Editora();
            editora.MdiParent = this;
            editora.Show();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locação locacao = new Locação();
            locacao.MdiParent = this;
            locacao.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }

                    System.IO.File.Copy(Application.StartupPath.ToString() + "\\bibliotecaBD.accdb", saveFileDialog1.FileName);
                    MessageBox.Show("Backup realizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Operação Cancelada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception error)
            {
                MessageBox.Show("Erro ao realizar essa operação " + error);
            }
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\bibliotecaBD.accdb"))
                    {
                        System.IO.File.Delete(Application.StartupPath.ToString() + "\\bibliotecaBD.accdb");
                    }

                    System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\bibliotecaBD.accdb");
                    MessageBox.Show("Restauração realizada com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operação Cancelada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro" + error);
            }
        }
    }
}
