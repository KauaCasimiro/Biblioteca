
namespace Biblioteca
{
    partial class TelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTXT = new System.Windows.Forms.TextBox();
            this.senhaTXT = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // nomeTXT
            // 
            this.nomeTXT.Location = new System.Drawing.Point(160, 79);
            this.nomeTXT.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTXT.Name = "nomeTXT";
            this.nomeTXT.Size = new System.Drawing.Size(148, 31);
            this.nomeTXT.TabIndex = 3;
            this.nomeTXT.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // senhaTXT
            // 
            this.senhaTXT.Location = new System.Drawing.Point(160, 172);
            this.senhaTXT.Margin = new System.Windows.Forms.Padding(4);
            this.senhaTXT.Name = "senhaTXT";
            this.senhaTXT.Size = new System.Drawing.Size(148, 31);
            this.senhaTXT.TabIndex = 4;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(77, 232);
            this.Enviar.Margin = new System.Windows.Forms.Padding(4);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(112, 34);
            this.Enviar.TabIndex = 5;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(260, 232);
            this.sair.Margin = new System.Windows.Forms.Padding(4);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(112, 34);
            this.sair.TabIndex = 7;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 331);
            this.ControlBox = false;
            this.Controls.Add(this.sair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.senhaTXT);
            this.Controls.Add(this.nomeTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTXT;
        private System.Windows.Forms.TextBox senhaTXT;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sair;
    }
}