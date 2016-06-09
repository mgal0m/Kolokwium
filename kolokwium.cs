using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pierwsze1 = new List<int>();
            List<int> subprime1 = new List<int>();
            Kolokwium k = new Kolokwium();
            pierwsze1 = k.listaLiczbPierwszy(100);
            subprime1 = k.listaSemiprime(100, pierwsze1);

            foreach(int p in subprime1)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadKey();

        }
    }

    public class Kolokwium
    {
        public List<int> listaLiczbPierwszy(int N)
        {
            List<int> pierwsze = new List<int>();
           
            for (int i = 2; i < N; i++)
            {
                bool pierwsza = true;
                for (int n = 2; n < i; n++)
                {
                    if (i % n == 0)
                    {
                        pierwsza = false;
                        break;
                    }
                }
                if (pierwsza)
                {
                    pierwsze.Add(i);
                }
            }
            return pierwsze;
        }

        

        public List<int> listaSemiprime(int N, List<int> pierwsze)
        {
            List<int> semiprime = new List<int>();
          
            for (int i = 0; i < pierwsze.Count; i++)
            {
                for (int j=0; j<pierwsze.Count; j++)
                {
                    semiprime.Add(pierwsze[i] * pierwsze[j]);
                }
            }

            
            return semiprime;
        }




    }

}
