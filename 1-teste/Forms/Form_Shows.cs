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
    public partial class Form_Shows : Form
    {
        List<Ingresso>ingressos;
        public Form_Shows()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Shows_Load(object sender, EventArgs e)
        {
            try
            {
                Ingresso ingres = new Ingresso();
                ingressos = ingres.BuscarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = ingressos;
            }
            catch 
            {
                MessageBox.Show("erro");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pagina1 pagina1 = new Pagina1();
            this.Visible = false;
            pagina1.ShowDialog();
            this.Visible = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string cpf = maskedTextBox1.Text.Replace(".", "").Replace("-", "");
                if (cpf.Length == 11)
                {
                    ingressos = ingressos.Where(x => x.cpf == (maskedTextBox1.Text)).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = ingressos;

                }

                else
                {
                    Ingresso ingresso = new Ingresso();
                    ingressos = ingresso.BuscarTodos();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = ingressos;
                }
            }
            catch 
            {
                MessageBox.Show("erro");
            }



        }
        
    }
}
