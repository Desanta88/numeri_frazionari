using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazioni
{
    public class Fractions
    {
        private int _numeratore;
        private int _denominatore;

        public Fractions(int n,int d)
        {
            _numeratore = n;
            _denominatore = d;
        }
        public int Numeratore
        {
            get { return _numeratore; }
            set { _numeratore = value; }
        }
        public int Denominatore
        {
            set { _denominatore = value; }
            get { return _denominatore; }
        }
        /*public int Semplifica(Fractions f)
        {
            

        }*/
        public void Somma(Fractions f, Fractions f2)
        {

        }
        public void Moltiplica(Fractions f)
        {

        }
        public void Sottrai(Fractions f)
        {

        }
        public void Dividi(Fractions f)
        {

        }
        public string getFrazione()
        {
            return Numeratore + "/" + Denominatore;
        }
        /*private int MCD(int n,int d)
        {
            int j = 0, h = 0;
            int[] num=new int[100];
            int[] den = new int[100];
            for (int i = 2; i < n; i++)
            {
                int c = 0;
                c = i;
                if (n % i == 0)
                {
                    n = n / i;
                    num[j] = i;
                    j++;
                    c = i;
                }
           
                    
                    
            }
        }*/
        
    }
}
