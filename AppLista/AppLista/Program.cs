using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AppLista
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double soma;
            int contarElementos;
            double media ;
            int count = 0;
            List<int> numerosTotal = new List<int>();

            int[] numeros = new int[] { 5, 5, 5, 5, 4 };
            numerosTotal.AddRange(numeros);
            soma = numeros.Sum();
            contarElementos = numerosTotal.Count();
            media = soma / contarElementos;
            
            foreach(int i in numerosTotal)
            {
                if(media < i)
                {
                    count++;
                }
            }

            Console.WriteLine("-= AMOSTRAGEM DA MEDIA DOS VALORES DA LISTA =-");
            Console.WriteLine("Media = " + media.ToString("0.0"));
            Console.WriteLine("-============================================-");
            Console.WriteLine("Total numeros maiores que a media = " + count);
            Console.WriteLine("-============================================-");
            Console.WriteLine("-= LISTA INVERSA =-");
            numerosTotal.Reverse();

            foreach(int item in numerosTotal)
            {
                Console.WriteLine(item.ToString());
            }
            
        }
    }
}
