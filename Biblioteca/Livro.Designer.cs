
namespace Biblioteca
{
    partial class Livro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livro));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iD_EditoraLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label edicaoLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label localizacaoLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label classificacaoLabel;
            System.Windows.Forms.Label colecaoLabel;
            System.Windows.Forms.Label tomboLabel;
            System.Windows.Forms.Label capaLabel;
            System.Windows.Forms.Label resenhaLabel;
            System.Windows.Forms.Label autoresLabel;
            System.Windows.Forms.Label comentariosLabel;
            this.bibliotecaBDDataSet = new Biblioteca.bibliotecaBDDataSet();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroTableAdapter = new Biblioteca.bibliotecaBDDataSetTableAdapters.LivroTableAdapter();
            this.tableAdapterManager = new Biblioteca.bibliotecaBDDataSetTableAdapters.TableAdapterManager();
            this.livroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.livroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.livroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.iD_EditoraTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.edicaoTextBox = new System.Windows.Forms.TextBox();
            this.anoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.localizacaoTextBox = new System.Windows.Forms.TextBox();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.classificacaoTextBox = new System.Windows.Forms.TextBox();
            this.colecaoTextBox = new System.Windows.Forms.TextBox();
            this.tomboCheckBox = new System.Windows.Forms.CheckBox();
            this.capaTextBox = new System.Windows.Forms.TextBox();
            this.resenhaTextBox = new System.Windows.Forms.TextBox();
            this.autoresTextBox = new System.Windows.Forms.TextBox();
            this.comentariosTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            iD_EditoraLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            edicaoLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            localizacaoLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            classificacaoLabel = new System.Windows.Forms.Label();
            colecaoLabel = new System.Windows.Forms.Label();
            tomboLabel = new System.Windows.Forms.Label();
            capaLabel = new System.Windows.Forms.Label();
            resenhaLabel = new System.Windows.Forms.Label();
            autoresLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingNavigator)).BeginInit();
            this.livroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaBDDataSet
            // 
            this.bibliotecaBDDataSet.DataSetName = "bibliotecaBDDataSet";
            this.bibliotecaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.bibliotecaBDDataSet;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = null;
            this.tableAdapterManager.LivroTableAdapter = this.livroTableAdapter;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.LocatarioTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca.bibliotecaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // livroBindingNavigator
            // 
            this.livroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.livroBindingNavigator.BindingSource = this.livroBindingSource;
            this.livroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.livroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.livroBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.livroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.livroBindingNavigatorSaveItem});
            this.livroBindingNavigator.Location = new System.Drawing.Point(0, 700);
            this.livroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.livroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.livroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.livroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.livroBindingNavigator.Name = "livroBindingNavigator";
            this.livroBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.livroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.livroBindingNavigator.Size = new System.Drawing.Size(489, 25);
            this.livroBindingNavigator.TabIndex = 0;
            this.livroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // livroBindingNavigatorSaveItem
            // 
            this.livroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livroBindingNavigatorSaveItem.Image")));
            this.livroBindingNavigatorSaveItem.Name = "livroBindingNavigatorSaveItem";
            this.livroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.livroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.livroBindingNavigatorSaveItem.Click += new System.EventHandler(this.livroBindingNavigatorSaveItem_Click);
            // 
            // livroDataGridView
            // 
            this.livroDataGridView.AutoGenerateColumns = false;
            this.livroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.livroDataGridView.DataSource = this.livroBindingSource;
            this.livroDataGridView.Location = new System.Drawing.Point(0, 503);
            this.livroDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.livroDataGridView.Name = "livroDataGridView";
            this.livroDataGridView.Size = new System.Drawing.Size(487, 193);
            this.livroDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Editora";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Editora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Edicao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Edicao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn6.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Localizacao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Localizacao";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Assunto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Assunto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Classificacao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Classificacao";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Colecao";
            this.dataGridViewTextBoxColumn10.HeaderText = "Colecao";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Tombo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Tombo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Capa";
            this.dataGridViewTextBoxColumn11.HeaderText = "Capa";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Resenha";
            this.dataGridViewTextBoxColumn12.HeaderText = "Resenha";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Autores";
            this.dataGridViewTextBoxColumn13.HeaderText = "Autores";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Comentarios";
            this.dataGridViewTextBoxColumn14.HeaderText = "Comentarios";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(115, 15);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(36, 19);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(157, 12);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(49, 26);
            this.iDTextBox.TabIndex = 3;
            // 
            // iD_EditoraLabel
            // 
            iD_EditoraLabel.AutoSize = true;
            iD_EditoraLabel.Location = new System.Drawing.Point(267, 15);
            iD_EditoraLabel.Name = "iD_EditoraLabel";
            iD_EditoraLabel.Size = new System.Drawing.Size(108, 19);
            iD_EditoraLabel.TabIndex = 4;
            iD_EditoraLabel.Text = "ID Editora:";
            // 
            // iD_EditoraTextBox
            // 
            this.iD_EditoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "ID_Editora", true));
            this.iD_EditoraTextBox.Location = new System.Drawing.Point(381, 12);
            this.iD_EditoraTextBox.Name = "iD_EditoraTextBox";
            this.iD_EditoraTextBox.Size = new System.Drawing.Size(62, 26);
            this.iD_EditoraTextBox.TabIndex = 5;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(15, 54);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(72, 19);
            tituloLabel.TabIndex = 6;
            tituloLabel.Text = "Titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(93, 51);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(149, 26);
            this.tituloTextBox.TabIndex = 7;
            // 
            // edicaoLabel
            // 
            edicaoLabel.AutoSize = true;
            edicaoLabel.Location = new System.Drawing.Point(258, 55);
            edicaoLabel.Name = "edicaoLabel";
            edicaoLabel.Size = new System.Drawing.Size(72, 19);
            edicaoLabel.TabIndex = 8;
            edicaoLabel.Text = "Edicao:";
            // 
            // edicaoTextBox
            // 
            this.edicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Edicao", true));
            this.edicaoTextBox.Location = new System.Drawing.Point(336, 51);
            this.edicaoTextBox.Name = "edicaoTextBox";
            this.edicaoTextBox.Size = new System.Drawing.Size(127, 26);
            this.edicaoTextBox.TabIndex = 9;
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(42, 102);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(45, 19);
            anoLabel.TabIndex = 10;
            anoLabel.Text = "Ano:";
            // 
            // anoDateTimePicker
            // 
            this.anoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.livroBindingSource, "Ano", true));
            this.anoDateTimePicker.Location = new System.Drawing.Point(93, 96);
            this.anoDateTimePicker.Name = "anoDateTimePicker";
            this.anoDateTimePicker.Size = new System.Drawing.Size(370, 26);
            this.anoDateTimePicker.TabIndex = 11;
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(33, 150);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(54, 19);
            iSBNLabel.TabIndex = 12;
            iSBNLabel.Text = "ISBN:";
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(93, 148);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(158, 26);
            this.iSBNTextBox.TabIndex = 13;
            // 
            // localizacaoLabel
            // 
            localizacaoLabel.AutoSize = true;
            localizacaoLabel.Location = new System.Drawing.Point(270, 151);
            localizacaoLabel.Name = "localizacaoLabel";
            localizacaoLabel.Size = new System.Drawing.Size(117, 19);
            localizacaoLabel.TabIndex = 14;
            localizacaoLabel.Text = "Localizacao:";
            // 
            // localizacaoTextBox
            // 
            this.localizacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Localizacao", true));
            this.localizacaoTextBox.Location = new System.Drawing.Point(393, 148);
            this.localizacaoTextBox.Name = "localizacaoTextBox";
            this.localizacaoTextBox.Size = new System.Drawing.Size(70, 26);
            this.localizacaoTextBox.TabIndex = 15;
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(6, 210);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(81, 19);
            assuntoLabel.TabIndex = 16;
            assuntoLabel.Text = "Assunto:";
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Assunto", true));
            this.assuntoTextBox.Location = new System.Drawing.Point(93, 208);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(158, 26);
            this.assuntoTextBox.TabIndex = 17;
            // 
            // classificacaoLabel
            // 
            classificacaoLabel.AutoSize = true;
            classificacaoLabel.Location = new System.Drawing.Point(258, 211);
            classificacaoLabel.Name = "classificacaoLabel";
            classificacaoLabel.Size = new System.Drawing.Size(135, 19);
            classificacaoLabel.TabIndex = 18;
            classificacaoLabel.Text = "Classificacao:";
            // 
            // classificacaoTextBox
            // 
            this.classificacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Classificacao", true));
            this.classificacaoTextBox.Location = new System.Drawing.Point(393, 208);
            this.classificacaoTextBox.Name = "classificacaoTextBox";
            this.classificacaoTextBox.Size = new System.Drawing.Size(68, 26);
            this.classificacaoTextBox.TabIndex = 19;
            // 
            // colecaoLabel
            // 
            colecaoLabel.AutoSize = true;
            colecaoLabel.Location = new System.Drawing.Point(6, 256);
            colecaoLabel.Name = "colecaoLabel";
            colecaoLabel.Size = new System.Drawing.Size(81, 19);
            colecaoLabel.TabIndex = 20;
            colecaoLabel.Text = "Colecao:";
            // 
            // colecaoTextBox
            // 
            this.colecaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Colecao", true));
            this.colecaoTextBox.Location = new System.Drawing.Point(93, 253);
            this.colecaoTextBox.Name = "colecaoTextBox";
            this.colecaoTextBox.Size = new System.Drawing.Size(158, 26);
            this.colecaoTextBox.TabIndex = 21;
            // 
            // tomboLabel
            // 
            tomboLabel.AutoSize = true;
            tomboLabel.Location = new System.Drawing.Point(270, 260);
            tomboLabel.Name = "tomboLabel";
            tomboLabel.Size = new System.Drawing.Size(63, 19);
            tomboLabel.TabIndex = 22;
            tomboLabel.Text = "Tombo:";
            // 
            // tomboCheckBox
            // 
            this.tomboCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.livroBindingSource, "Tombo", true));
            this.tomboCheckBox.Location = new System.Drawing.Point(339, 258);
            this.tomboCheckBox.Name = "tomboCheckBox";
            this.tomboCheckBox.Size = new System.Drawing.Size(100, 24);
            this.tomboCheckBox.TabIndex = 23;
            this.tomboCheckBox.Text = "Sim/Não";
            this.tomboCheckBox.UseVisualStyleBackColor = true;
            // 
            // capaLabel
            // 
            capaLabel.AutoSize = true;
            capaLabel.Location = new System.Drawing.Point(33, 298);
            capaLabel.Name = "capaLabel";
            capaLabel.Size = new System.Drawing.Size(54, 19);
            capaLabel.TabIndex = 24;
            capaLabel.Text = "Capa:";
            // 
            // capaTextBox
            // 
            this.capaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Capa", true));
            this.capaTextBox.Location = new System.Drawing.Point(93, 295);
            this.capaTextBox.Name = "capaTextBox";
            this.capaTextBox.Size = new System.Drawing.Size(158, 26);
            this.capaTextBox.TabIndex = 25;
            // 
            // resenhaLabel
            // 
            resenhaLabel.AutoSize = true;
            resenhaLabel.Location = new System.Drawing.Point(270, 298);
            resenhaLabel.Name = "resenhaLabel";
            resenhaLabel.Size = new System.Drawing.Size(81, 19);
            resenhaLabel.TabIndex = 26;
            resenhaLabel.Text = "Resenha:";
            // 
            // resenhaTextBox
            // 
            this.resenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Resenha", true));
            this.resenhaTextBox.Location = new System.Drawing.Point(357, 295);
            this.resenhaTextBox.Name = "resenhaTextBox";
            this.resenhaTextBox.Size = new System.Drawing.Size(106, 26);
            this.resenhaTextBox.TabIndex = 27;
            // 
            // autoresLabel
            // 
            autoresLabel.AutoSize = true;
            autoresLabel.Location = new System.Drawing.Point(6, 341);
            autoresLabel.Name = "autoresLabel";
            autoresLabel.Size = new System.Drawing.Size(81, 19);
            autoresLabel.TabIndex = 28;
            autoresLabel.Text = "Autores:";
            // 
            // autoresTextBox
            // 
            this.autoresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Autores", true));
            this.autoresTextBox.Location = new System.Drawing.Point(93, 338);
            this.autoresTextBox.Name = "autoresTextBox";
            this.autoresTextBox.Size = new System.Drawing.Size(370, 26);
            this.autoresTextBox.TabIndex = 29;
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Location = new System.Drawing.Point(89, 429);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(117, 19);
            comentariosLabel.TabIndex = 30;
            comentariosLabel.Text = "Comentarios:";
            // 
            // comentariosTextBox
            // 
            this.comentariosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Comentarios", true));
            this.comentariosTextBox.Location = new System.Drawing.Point(212, 401);
            this.comentariosTextBox.Multiline = true;
            this.comentariosTextBox.Name = "comentariosTextBox";
            this.comentariosTextBox.Size = new System.Drawing.Size(200, 71);
            this.comentariosTextBox.TabIndex = 31;
            // 
            // Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 725);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(iD_EditoraLabel);
            this.Controls.Add(this.iD_EditoraTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(edicaoLabel);
            this.Controls.Add(this.edicaoTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoDateTimePicker);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(localizacaoLabel);
            this.Controls.Add(this.localizacaoTextBox);
            this.Controls.Add(assuntoLabel);
            this.Controls.Add(this.assuntoTextBox);
            this.Controls.Add(classificacaoLabel);
            this.Controls.Add(this.classificacaoTextBox);
            this.Controls.Add(colecaoLabel);
            this.Controls.Add(this.colecaoTextBox);
            this.Controls.Add(tomboLabel);
            this.Controls.Add(this.tomboCheckBox);
            this.Controls.Add(capaLabel);
            this.Controls.Add(this.capaTextBox);
            this.Controls.Add(resenhaLabel);
            this.Controls.Add(this.resenhaTextBox);
            this.Controls.Add(autoresLabel);
            this.Controls.Add(this.autoresTextBox);
            this.Controls.Add(comentariosLabel);
            this.Controls.Add(this.comentariosTextBox);
            this.Controls.Add(this.livroDataGridView);
            this.Controls.Add(this.livroBindingNavigator);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Livro";
            this.Load += new System.EventHandler(this.Livro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingNavigator)).EndInit();
            this.livroBindingNavigator.ResumeLayout(false);
            this.livroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bibliotecaBDDataSet bibliotecaBDDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private bibliotecaBDDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private bibliotecaBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton livroBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView livroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox iD_EditoraTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox edicaoTextBox;
        private System.Windows.Forms.DateTimePicker anoDateTimePicker;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox localizacaoTextBox;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.TextBox classificacaoTextBox;
        private System.Windows.Forms.TextBox colecaoTextBox;
        private System.Windows.Forms.CheckBox tomboCheckBox;
        private System.Windows.Forms.TextBox capaTextBox;
        private System.Windows.Forms.TextBox resenhaTextBox;
        private System.Windows.Forms.TextBox autoresTextBox;
        private System.Windows.Forms.TextBox comentariosTextBox;
    }
}