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
    public partial class Formulário_Principal : Form
    {
        public Formulário_Principal()
        {
            InitializeComponent();

        }
        public string NomeUsuario { get; private set; }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            this.usuario = usuario;
            txtUsuario.Text = usuario;

        }
    }
}
