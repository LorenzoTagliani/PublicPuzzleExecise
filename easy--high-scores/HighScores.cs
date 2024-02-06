using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class HighScores
{
    public List<int> lista {get; set;}
    // https://learn.microsoft.com/en-us/dotnet/csharp/linq/
    public HighScores(List<int> list)
    {
        this.lista = list;
    }

    public List<int> Scores()
    {
        return lista;
    }

    public int Latest()
    {
        return lista[lista.Count - 1];
    }

    public int PersonalBest()
    {
        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - i - 1; j++)
            {
                if (lista[j] > lista[j + 1])
                {
                    int temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
        return lista[lista.Count - 1];
    }

    public List<int> PersonalTopThree()
    {
        /*
        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - i - 1; j++)
            {
                if (lista[j] > lista[j + 1])
                {
                    int temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
        List<int> topthree = new List<int> {lista[lista.Count - 1], lista[lista.Count - 2], lista[lista.Count - 3],};
        return topthree;
        */
        return lista.OrderByDescending(p=> p).Take(3).ToList();
    }
}