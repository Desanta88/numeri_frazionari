using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazioni
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fractions f = new Fractions(999,45);
            Fractions f2 = new Fractions(1,8888);
            Fractions ris = new Fractions();
            ris=f.Somma(f2);
            Console.WriteLine(ris.getFrazione());//8879112
            ris.Semplifica();
            Console.WriteLine(ris.getFrazione());
            
            
        }
    }
}
