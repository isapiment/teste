using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

public class Shows
{
    public string nome { get; set; }
    public string data { get; set; }    
    public double valor { get; set; }
    public Shows(string nome, string data, double valor) 
    { 
        this.nome = nome;
        this.data = data;   
        this.valor = valor;
    }
    public Shows()
    {
    }

    public static List<Shows> Cadrastro()
    {
        List<Shows> show = new List<Shows>();

        List<string> linhas = File.ReadAllLines("C:\\Users\\Lenovo\\source\\repos\\1-teste\\Shows\\Shows.txt").ToList();

        foreach (string linha in linhas)
        {
            string[] aux = linha.Split('|');
            Shows shows = new Shows();    
            shows.nome = aux[0];
            shows.data = aux[1];
            shows.valor = Convert.ToDouble(aux[2]);

            show.Add(shows);
        }
        return show;
    }
        
        public void Salvar()
        {
            var sw2 = File.AppendText("C:\\Users\\Lenovo\\source\\repos\\1-teste\\Shows\\Shows.txt");
            sw2.WriteLine(nome + "|" + data + "|" + valor);
            sw2.Close();
        }
   


}


