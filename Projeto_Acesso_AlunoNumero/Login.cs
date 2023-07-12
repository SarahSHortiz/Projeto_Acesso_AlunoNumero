using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Acesso_AlunoNumero
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Aluno" && txtSenha.Text == "1234")

            {
                MessageBox.Show("Acesso Permitido");

                Formulário_Principal newFormulario_principal = new Formulário_Principal();
                newFormulario_principal.ShowDialog();

            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }

        }
         

     
   
        

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lbltextologin_Click(object sender, EventArgs e)
        {

        }
    }
}
