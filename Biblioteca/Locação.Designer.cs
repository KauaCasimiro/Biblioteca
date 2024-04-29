
namespace Biblioteca
{
    partial class Locação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locação));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iD_LocatorioLabel;
            System.Windows.Forms.Label iD_FuncionarioLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label dataSaidaLabel;
            System.Windows.Forms.Label dataEntradaLabel;
            this.bibliotecaBDDataSet = new Biblioteca.bibliotecaBDDataSet();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoTableAdapter = new Biblioteca.bibliotecaBDDataSetTableAdapters.LocacaoTableAdapter();
            this.tableAdapterManager = new Biblioteca.bibliotecaBDDataSetTableAdapters.TableAdapterManager();
            this.locacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.locacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.locacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.iD_LocatorioTextBox = new System.Windows.Forms.TextBox();
            this.iD_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            iD_LocatorioLabel = new System.Windows.Forms.Label();
            iD_FuncionarioLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            dataEntradaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).BeginInit();
            this.locacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaBDDataSet
            // 
            this.bibliotecaBDDataSet.DataSetName = "bibliotecaBDDataSet";
            this.bibliotecaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "Locacao";
            this.locacaoBindingSource.DataSource = this.bibliotecaBDDataSet;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = null;
            this.tableAdapterManager.LivroTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = this.locacaoTableAdapter;
            this.tableAdapterManager.LocatarioTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca.bibliotecaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locacaoBindingNavigator
            // 
            this.locacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locacaoBindingNavigator.BindingSource = this.locacaoBindingSource;
            this.locacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locacaoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.locacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.locacaoBindingNavigatorSaveItem});
            this.locacaoBindingNavigator.Location = new System.Drawing.Point(0, 336);
            this.locacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locacaoBindingNavigator.Name = "locacaoBindingNavigator";
            this.locacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locacaoBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.locacaoBindingNavigator.TabIndex = 0;
            this.locacaoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // locacaoDataGridView
            // 
            this.locacaoDataGridView.AutoGenerateColumns = false;
            this.locacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.locacaoDataGridView.DataSource = this.locacaoBindingSource;
            this.locacaoDataGridView.Location = new System.Drawing.Point(0, 215);
            this.locacaoDataGridView.Name = "locacaoDataGridView";
            this.locacaoDataGridView.Size = new System.Drawing.Size(644, 117);
            this.locacaoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Locatorio";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Locatorio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Funcionario";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Funcionario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataSaida";
            this.dataGridViewTextBoxColumn5.HeaderText = "dataSaida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataEntrada";
            this.dataGridViewTextBoxColumn6.HeaderText = "dataEntrada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // locacaoBindingNavigatorSaveItem
            // 
            this.locacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locacaoBindingNavigatorSaveItem.Image")));
            this.locacaoBindingNavigatorSaveItem.Name = "locacaoBindingNavigatorSaveItem";
            this.locacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.locacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.locacaoBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(48, 9);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(36, 19);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(90, 6);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(57, 26);
            this.iDTextBox.TabIndex = 3;
            // 
            // iD_LocatorioLabel
            // 
            iD_LocatorioLabel.AutoSize = true;
            iD_LocatorioLabel.Location = new System.Drawing.Point(165, 9);
            iD_LocatorioLabel.Name = "iD_LocatorioLabel";
            iD_LocatorioLabel.Size = new System.Drawing.Size(126, 19);
            iD_LocatorioLabel.TabIndex = 4;
            iD_LocatorioLabel.Text = "ID Locatorio:";
            iD_LocatorioLabel.Click += new System.EventHandler(this.iD_LocatorioLabel_Click);
            // 
            // iD_LocatorioTextBox
            // 
            this.iD_LocatorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "ID_Locatorio", true));
            this.iD_LocatorioTextBox.Location = new System.Drawing.Point(297, 6);
            this.iD_LocatorioTextBox.Name = "iD_LocatorioTextBox";
            this.iD_LocatorioTextBox.Size = new System.Drawing.Size(58, 26);
            this.iD_LocatorioTextBox.TabIndex = 5;
            // 
            // iD_FuncionarioLabel
            // 
            iD_FuncionarioLabel.AutoSize = true;
            iD_FuncionarioLabel.Location = new System.Drawing.Point(376, 9);
            iD_FuncionarioLabel.Name = "iD_FuncionarioLabel";
            iD_FuncionarioLabel.Size = new System.Drawing.Size(144, 19);
            iD_FuncionarioLabel.TabIndex = 6;
            iD_FuncionarioLabel.Text = "ID Funcionario:";
            // 
            // iD_FuncionarioTextBox
            // 
            this.iD_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "ID_Funcionario", true));
            this.iD_FuncionarioTextBox.Location = new System.Drawing.Point(526, 6);
            this.iD_FuncionarioTextBox.Name = "iD_FuncionarioTextBox";
            this.iD_FuncionarioTextBox.Size = new System.Drawing.Size(58, 26);
            this.iD_FuncionarioTextBox.TabIndex = 7;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(95, 58);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(54, 19);
            horaLabel.TabIndex = 8;
            horaLabel.Text = "Hora:";
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "Hora", true));
            this.horaDateTimePicker.Location = new System.Drawing.Point(155, 52);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.Size = new System.Drawing.Size(374, 26);
            this.horaDateTimePicker.TabIndex = 9;
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.Location = new System.Drawing.Point(39, 107);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(108, 19);
            dataSaidaLabel.TabIndex = 10;
            dataSaidaLabel.Text = "data Saida:";
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "dataSaida", true));
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(153, 101);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(376, 26);
            this.dataSaidaDateTimePicker.TabIndex = 11;
            // 
            // dataEntradaLabel
            // 
            dataEntradaLabel.AutoSize = true;
            dataEntradaLabel.Location = new System.Drawing.Point(21, 166);
            dataEntradaLabel.Name = "dataEntradaLabel";
            dataEntradaLabel.Size = new System.Drawing.Size(126, 19);
            dataEntradaLabel.TabIndex = 12;
            dataEntradaLabel.Text = "data Entrada:";
            // 
            // dataEntradaDateTimePicker
            // 
            this.dataEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "dataEntrada", true));
            this.dataEntradaDateTimePicker.Location = new System.Drawing.Point(153, 160);
            this.dataEntradaDateTimePicker.Name = "dataEntradaDateTimePicker";
            this.dataEntradaDateTimePicker.Size = new System.Drawing.Size(376, 26);
            this.dataEntradaDateTimePicker.TabIndex = 13;
            // 
            // Locação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(iD_LocatorioLabel);
            this.Controls.Add(this.iD_LocatorioTextBox);
            this.Controls.Add(iD_FuncionarioLabel);
            this.Controls.Add(this.iD_FuncionarioTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaDateTimePicker);
            this.Controls.Add(dataSaidaLabel);
            this.Controls.Add(this.dataSaidaDateTimePicker);
            this.Controls.Add(dataEntradaLabel);
            this.Controls.Add(this.dataEntradaDateTimePicker);
            this.Controls.Add(this.locacaoDataGridView);
            this.Controls.Add(this.locacaoBindingNavigator);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Locação";
            this.Load += new System.EventHandler(this.Locação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).EndInit();
            this.locacaoBindingNavigator.ResumeLayout(false);
            this.locacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bibliotecaBDDataSet bibliotecaBDDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private bibliotecaBDDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter;
        private bibliotecaBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton locacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView locacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox iD_LocatorioTextBox;
        private System.Windows.Forms.TextBox iD_FuncionarioTextBox;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataEntradaDateTimePicker;
    }
}