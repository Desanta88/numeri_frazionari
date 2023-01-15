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
            try
            {
                int p = 0,n1,d1,n2,d2;
                Fractions f = new Fractions();
                Fractions f2 = new Fractions();
                Fractions ris;
                do
                {
                    Console.WriteLine("scegli tra le seguenti opzioni:");
                    Console.WriteLine("1)Semplifica una frazione");
                    Console.WriteLine("2)Somma due frazioni");
                    Console.WriteLine("3)Sottrai due frazioni");
                    Console.WriteLine("4)Moltiplica due frazioni");
                    Console.WriteLine("5)Dividi due frazioni");
                    p = int.Parse(Console.ReadLine());
                    switch (p)
                    {
                        case 1:
                            Console.WriteLine("Inserisci il numeratore della frazione:");
                            n1 = int.Parse(Console.ReadLine());
                            f.Numeratore = n1;
                            Console.WriteLine("Inserisci il denominatore della frazione:");
                            d1 = int.Parse(Console.ReadLine());
                            f.Denominatore = d1;
                            f.Semplifica();
                            Console.WriteLine(f.ToString());
                            break;    
                        case 2:
                            Console.WriteLine("Inserisci il numeratore della prima frazione:");
                            n1 = int.Parse(Console.ReadLine());
                            f.Numeratore = n1;
                            Console.WriteLine("Inserisci il denominatore della prima frazione:");
                            d1 = int.Parse(Console.ReadLine());
                            f.Denominatore = d1;
                            Console.WriteLine("Inserisci il numeratore della seconda frazione:");
                            n2 = int.Parse(Console.ReadLine());
                            f2.Numeratore = n2;
                            Console.WriteLine("Inserisci il denominatore della seconda frazione:");
                            d2 = int.Parse(Console.ReadLine());
                            f2.Denominatore = d2;
                            ris = new Fractions(1, 1);
                            ris = f.Somma(f2);
                            ris.Semplifica();
                            Console.WriteLine(ris.ToString());
                            break;
                        case 3:
                            Console.WriteLine("Inserisci il numeratore della prima frazione:");
                            n1 = int.Parse(Console.ReadLine());
                            f.Numeratore = n1;
                            Console.WriteLine("Inserisci il denominatore della prima frazione:");
                            d1 = int.Parse(Console.ReadLine());
                            f.Denominatore = d1;
                            Console.WriteLine("Inserisci il numeratore della seconda frazione:");
                            n2 = int.Parse(Console.ReadLine());
                            f2.Numeratore = n2;
                            Console.WriteLine("Inserisci il denominatore della seconda frazione:");
                            d2 = int.Parse(Console.ReadLine());
                            f2.Denominatore = d2;
                            ris = f.Sottrai(f2);
                            ris.Semplifica();
                            Console.WriteLine(ris.ToString());
                            break;
                        case 4:
                            Console.WriteLine("Inserisci il numeratore della prima frazione:");
                            n1 = int.Parse(Console.ReadLine());
                            f.Numeratore = n1;
                            Console.WriteLine("Inserisci il denominatore della prima frazione:");
                            d1 = int.Parse(Console.ReadLine());
                            f.Denominatore = d1;
                            Console.WriteLine("Inserisci il numeratore della seconda frazione:");
                            n2 = int.Parse(Console.ReadLine());
                            f2.Numeratore = n2;
                            Console.WriteLine("Inserisci il denominatore della seconda frazione:");
                            d2 = int.Parse(Console.ReadLine());
                            f2.Denominatore = d2;
                            ris = f.Moltiplica(f2);
                            ris.Semplifica();
                            Console.WriteLine(ris.ToString());
                            break;
                        case 5:
                            Console.WriteLine("Inserisci il numeratore della prima frazione:");
                            n1 = int.Parse(Console.ReadLine());
                            f.Numeratore = n1;
                            Console.WriteLine("Inserisci il denominatore della prima frazione:");
                            d1 = int.Parse(Console.ReadLine());
                            f.Denominatore = d1;
                            Console.WriteLine("Inserisci il numeratore della seconda frazione:");
                            n2 = int.Parse(Console.ReadLine());
                            f2.Numeratore = n2;
                            Console.WriteLine("Inserisci il denominatore della seconda frazione:");
                            d2 = int.Parse(Console.ReadLine());
                            f2.Denominatore = d2;
                            ris = f.Dividi(f2);
                            ris.Semplifica();
                            Console.WriteLine(ris.ToString());
                            break;
                        default:
                            break;
                    }
                } while (p >= 1 && p <= 5);
             
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }      
        }
    }
}
