using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class Ingresso
    {

    public string nome { get; set; }

    public string cpf { get; set; }
    public DateTime idade { get; set; }
    public string numerocont { get; set; }
    public string ingressoshow { get; set; }
    public int quantidade { get; set; }

    public double valor { get; set; }

    public string formapag { get; set; }

    public Ingresso() { }

    public Ingresso(string nome, string cpf, DateTime idade, string numerotel, string ingressoshow, int quantidade,double valor, string formapag)
    {
        try
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.numerocont = numerotel;
            this.ingressoshow = ingressoshow;
            this.valor = valor;
            this.formapag = formapag;
            this.quantidade = quantidade;   
        }
        catch (Exception)
        {
            MessageBox.Show("Erro inesperado");
        }
    

    }

    public List<Ingresso> BuscarTodos()
    {
            List<Ingresso> ingressos = new List<Ingresso>();
            
            List<string> linhas = File.ReadAllLines("C:\\Users\\Lenovo\\source\\repos\\1-teste\\text.txt").ToList();

            foreach (string linha in linhas)
            {
                string[] aux = linha.Split('|');
                Ingresso ingre = new Ingresso();
                ingre.nome = aux[0];
                ingre.cpf = aux[1];
                ingre.idade = DateTime.Parse(aux[2]);
                ingre.numerocont = aux[3];
                ingre.ingressoshow = aux[4];
                ingre.quantidade = Convert.ToInt32(aux[5]);
                ingre.valor = Convert.ToDouble(aux[6]);
                ingre.formapag = aux[7];

                ingressos.Add(ingre);
            }
            return ingressos;
        
    }

    public List<Ingresso> ArmazenarShows()
    {
        List<Ingresso> shows = new List<Ingresso>();
        List<string> armazem = File.ReadAllLines("C:\\Users\\Lenovo\\source\\repos\\1-teste\\Shows.txt").ToList();

        foreach(string arma in armazem)
        {
             
            string[] aux = arma.Split('|');
            Ingresso ingre = new Ingresso();
            ingre.ingressoshow = aux[0];
            ingre.valor = Convert.ToDouble(aux[1]);
            shows.Add(ingre);
        }
        
        return shows;
    }
   
    //Responsável por escrever no arquivo de ingresso
    public void Salvar()
    {
        var sw = File.AppendText("C:\\Users\\Lenovo\\source\\repos\\1-teste\\text.txt");

        sw.WriteLine(nome + "|" + cpf + "|" + idade + "|" + numerocont + "|" + ingressoshow + "|" + quantidade + "|" + valor + "|" + formapag);
        sw.Close();

        var sw1 = File.AppendText("C:\\Users\\Lenovo\\source\\repos\\1-teste\\Shows.txt");
        sw1.WriteLine(ingressoshow + "|" + valor);
        sw1.Close();
    }
    
    
}


