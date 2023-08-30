using System;
using System.Windows.Forms;

public static class Validacao
{ 
    public static bool ValidaCpf(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length != 11)
        {
            return false;
        }
        else
        {


           

            int n = Convert.ToInt32(cpf[0].ToString()) * 10;
            int n1 = Convert.ToInt32(cpf[1].ToString()) * 9;
            int n2 = Convert.ToInt32(cpf[2].ToString()) * 8;
            int n3 = Convert.ToInt32(cpf[3].ToString()) * 7;
            int n4 = Convert.ToInt32(cpf[4].ToString()) * 6;
            int n5 = Convert.ToInt32(cpf[5].ToString()) * 5;
            int n6 = Convert.ToInt32(cpf[6].ToString()) * 4;
            int n7 = Convert.ToInt32(cpf[7].ToString()) * 3;
            int n8 = Convert.ToInt32(cpf[8].ToString()) * 2;


            int n9 = Convert.ToInt32(cpf[9].ToString());

            int soma = n + n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8;

            if (soma % 11 < 2)
            {
                if (n9 != 0)
                {
                    return false;
                }
            }
            if (n9 != 11 - (soma % 11))
            {
                return false;
            }
            else if (n9 == 11 - (soma % 11))
            {
                return true;
            }

            int nu = Convert.ToInt32(cpf[0].ToString()) * 11;
            int nu1 = Convert.ToInt32(cpf[1].ToString()) * 10;
            int nu2 = Convert.ToInt32(cpf[2].ToString()) * 9;
            int nu3 = Convert.ToInt32(cpf[3].ToString()) * 8;
            int nu4 = Convert.ToInt32(cpf[4].ToString()) * 7;
            int nu5 = Convert.ToInt32(cpf[5].ToString()) * 6;
            int nu6 = Convert.ToInt32(cpf[6].ToString()) * 5;
            int nu7 = Convert.ToInt32(cpf[7].ToString()) * 4;
            int nu8 = Convert.ToInt32(cpf[8].ToString()) * 3;
            int nu9 = Convert.ToInt32(cpf[9].ToString()) * 2;

            int nu10 = Convert.ToInt32(cpf[10].ToString());


            int soma2 = nu + nu1 + nu2 + nu3 + nu4 + nu5 + nu6 + nu7 + nu8 + nu9;

            if (soma2 % 11 < 2)
            {
                if (nu10 != 0)
                {
                    return false;
                }
            }
            if (nu10 != 11 - (soma2 % 11))
            {
                return false;
            }
            else if (nu10 == 11 - (soma2 % 11))
            {
                return true;
            }
        }
        return true;
    }
}

