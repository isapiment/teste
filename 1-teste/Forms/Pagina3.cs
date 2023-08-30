using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;


namespace _1_teste
{
    public partial class tx_respostidad : Form
    {
        List<Ingresso> listname = new List<Ingresso>();
        
        public tx_respostidad()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tx_nome.Text;
                string cpf = tx_cpf.Text;
                DateTime dt = Convert.ToDateTime(tx_datanas.Text);
                string tel = tx_numerocont.Text;
                string ingres = tx_ingresso.Text;
                int quantidade = Convert.ToInt32(tx_quant.Text);
                double valor = Convert.ToDouble(tx_ingresso.SelectedValue.ToString()) * quantidade;
                Ingresso ingresso = new Ingresso(nome, cpf, dt, tel, ingres, quantidade, valor, tx_formapagamento.Text );
                


                bool resultado = Validacao.ValidaCpf(tx_cpf.Text);
                bool result = Idade.Calculo(Convert.ToDateTime(tx_datanas.Text));

                if (resultado == true && result == true)
                {
                   
                        ingresso.Salvar();
                }
                
                else if (resultado == false)
                {

                    string resul = tx_cpfvalid.Text;
                    tx_cpfvalid.Text = "CPF inválido!";
                }
                else if (result == false)
                {
                    string resulinva = tx_idade.Text;
                    tx_idade.Text = "Idade Inválida!";
                }

                listname.Add(ingresso);
                tx_valor.Text = Convert.ToString(valor);

            
            
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro Inesperado!!!");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pagina2 pagina3 = new Pagina2();
            this.Visible = false;
            pagina3.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pagina4 pagina4 = new Pagina4();
            this.Visible = false;
            pagina4.ShowDialog();
            this.Visible = true;
        }

        private void tx_respostidad_Load(object sender, EventArgs e)
        {
            try
            {


                List<Shows> lista = new List<Shows>();
                lista = Shows.Cadrastro();

                tx_ingresso.DataSource = null;
                tx_ingresso.DataSource = lista;
                tx_ingresso.DisplayMember = "nome";
                tx_ingresso.ValueMember = "valor";


            }
            catch 
            {
                MessageBox.Show("Erro inesperado!");
            }   
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_idade.Clear();
            tx_numerocont.Clear();
            tx_valor.Clear();
            tx_formapagamento.Text = " ";
            tx_quant.Text = " ";
            tx_ingresso.Text = " ";
            
        }
    }
}
