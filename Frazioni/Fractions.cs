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
        private int[] ScompNum(int n)
        {
            int j = 0,i=2;
            int[] num=new int[100];
            while (i < n)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    num[j] = i;
                    j++;
                    i = 2;
                }
                else
                {
                    i++;
                }

            }
            int[] nume = new int[j];
            nume = num;
            return nume;
        }
        private int[] ScompDen(int d)
        {
            int h = 0, i = 2;
            int[] den = new int[100];
            while (i < d)
            {
                if (d % i == 0)
                {
                    d = d / i;
                    den[h] = i;
                    h++;
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
            int[] deno = new int[h];
            deno = den;
            return deno;
        }
        private int[] Scomposizione(int[] n)
        {
            int count=0,m=2,scomp=0,a=0;
            int[] arr = new int[100];
            Array.Sort(n);
            for(int i = 0; i < n.Length - 1; i++)
            {
                if (n[i] == m)
                    count++;
                else
                {
                    scomp=scomp*Convert.ToInt32(Math.Pow(Convert.ToDouble(n[i]), Convert.ToDouble(count)));
                    arr[a] = scomp;
                    a++;
                    count = 0;
                    m++;
                }
            }
            Array.Resize(ref arr, a);
            return arr;
        }
        //private int MCD(int )
        
    }
}
