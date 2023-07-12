
namespace Projeto_Acesso_AlunoNumero
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltextologin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.bntEntrar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltextologin
            // 
            this.lbltextologin.AutoSize = true;
            this.lbltextologin.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextologin.Location = new System.Drawing.Point(61, 57);
            this.lbltextologin.Name = "lbltextologin";
            this.lbltextologin.Size = new System.Drawing.Size(216, 38);
            this.lbltextologin.TabIndex = 0;
            this.lbltextologin.Text = "Faça seu Login!";
            this.lbltextologin.Click += new System.EventHandler(this.lbltextologin_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(64, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(68, 139);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 32);
            this.txtNome.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(68, 214);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(256, 32);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(64, 188);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 23);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click_1);
            // 
            // bntEntrar
            // 
            this.bntEntrar.BackColor = System.Drawing.Color.Maroon;
            this.bntEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntEntrar.FlatAppearance.BorderSize = 0;
            this.bntEntrar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEntrar.ForeColor = System.Drawing.Color.White;
            this.bntEntrar.Location = new System.Drawing.Point(68, 287);
            this.bntEntrar.Name = "bntEntrar";
            this.bntEntrar.Size = new System.Drawing.Size(256, 48);
            this.bntEntrar.TabIndex = 5;
            this.bntEntrar.Text = "Entrar";
            this.bntEntrar.UseVisualStyleBackColor = false;
            this.bntEntrar.Click += new System.EventHandler(this.bntEntrar_Click);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.Maroon;
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.FlatAppearance.BorderSize = 0;
            this.bntSair.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.ForeColor = System.Drawing.Color.White;
            this.bntSair.Location = new System.Drawing.Point(68, 341);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(256, 48);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 495);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lbltextologin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltextologin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button bntEntrar;
        private System.Windows.Forms.Button bntSair;
    }
}

