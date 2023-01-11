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
            Fractions f = new Fractions(3,2);
            Fractions f2 = new Fractions(3,2);
            Fractions ris = new Fractions();
            ris=f.Dividi(f2);
            Console.WriteLine(ris.getFrazione());
            //f.Semplifica();
            //Console.WriteLine(f.getFrazione());
            
            
        }
    }
}
