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
    public partial class CadastroShow : Form
    {
        public CadastroShow()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tx_nomeshows.Text;
                string dt = tx_data.Text;
                double valor = Convert.ToDouble(tx_valors.Text);

                Shows shows = new Shows(nome, dt, valor);

                shows.Salvar();

                tx_mensagem.Text = "Cadastrado com sucesso!"; 
            }
            catch 
            {
                MessageBox.Show("ERRO");
            }
           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pagina1 pagina1 = new Pagina1();
            this.Visible = false;
            pagina1.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tx_nomeshows.Text = " ";
            tx_data.Text = " "; 
            tx_valors.Text = " ";
            tx_mensagem.Text = " ";
        }
    }
}
