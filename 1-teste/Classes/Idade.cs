using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

public static class Idade
{

    public static bool Calculo(DateTime idade)
    {
        
        DateTime dateTime = DateTime.Now;

        TimeSpan idade2 = dateTime.Subtract(idade);
        double calculo = (idade2.Days / 365.2425);

        if (calculo >= 18)
        {
            return true;
        }
        else if (calculo < 18)
        {
            return false;
        }
        return false;
        
    }

}
