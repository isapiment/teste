using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_teste
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_senha.Text == "Xpark_123@shows#")
            {
                CadastroShow cs = new CadastroShow();
                this.Visible = false;
                cs.ShowDialog();
                this.Visible = true;
            }
            else
            {
                tx_mesagem.Text = "Senha Inválida!";
            }
        }

        private void Acesso_Load(object sender, EventArgs e)
        {

        }
    }
}
