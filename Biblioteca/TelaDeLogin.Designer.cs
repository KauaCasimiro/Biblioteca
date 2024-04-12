
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enviarBT = new System.Windows.Forms.Button();
            this.sairBT = new System.Windows.Forms.Button();
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.senhaTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.Bibiloteca_Digital_LOG;
            this.pictureBox1.Location = new System.Drawing.Point(422, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // enviarBT
            // 
            this.enviarBT.Location = new System.Drawing.Point(69, 243);
            this.enviarBT.Name = "enviarBT";
            this.enviarBT.Size = new System.Drawing.Size(86, 29);
            this.enviarBT.TabIndex = 4;
            this.enviarBT.Text = "Enviar";
            this.enviarBT.UseVisualStyleBackColor = true;
            this.enviarBT.Click += new System.EventHandler(this.enviarBT_Click);
            // 
            // sairBT
            // 
            this.sairBT.Location = new System.Drawing.Point(277, 243);
            this.sairBT.Name = "sairBT";
            this.sairBT.Size = new System.Drawing.Size(86, 29);
            this.sairBT.TabIndex = 5;
            this.sairBT.Text = "Sair";
            this.sairBT.UseVisualStyleBackColor = true;
            this.sairBT.Click += new System.EventHandler(this.sairBT_Click);
            // 
            // nomeTB
            // 
            this.nomeTB.Location = new System.Drawing.Point(144, 64);
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(133, 26);
            this.nomeTB.TabIndex = 6;
            // 
            // senhaTB
            // 
            this.senhaTB.Location = new System.Drawing.Point(144, 164);
            this.senhaTB.Name = "senhaTB";
            this.senhaTB.Size = new System.Drawing.Size(133, 26);
            this.senhaTB.TabIndex = 7;
            // 
            // TelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 304);
            this.ControlBox = false;
            this.Controls.Add(this.senhaTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.sairBT);
            this.Controls.Add(this.enviarBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enviarBT;
        private System.Windows.Forms.Button sairBT;
        private System.Windows.Forms.TextBox nomeTB;
        private System.Windows.Forms.TextBox senhaTB;
    }
}