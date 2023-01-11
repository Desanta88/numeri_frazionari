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

        public Fractions(int n, int d)
        {
            _numeratore = n;
            _denominatore = d;
        }
        public Fractions()
        {
            Numeratore =_numeratore;
            Denominatore=_denominatore;
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
        public void Semplifica()
        {
            int[] sNum;
            int[] sDen;
            int massimoComuneDivisore = 0;
            sNum = Scomposizione(Numeratore);
            sDen = Scomposizione(Denominatore);
            massimoComuneDivisore = MCD(sNum, sDen);
            Numeratore = Numeratore / massimoComuneDivisore;
            Denominatore = Denominatore / massimoComuneDivisore;
        }
        public void Somma(Fractions f)
        {
            int[] sNum;
            int[] sNum2;
            int minimoComuneMultiplo=0;
            sNum = Scomposizione(this.Denominatore);
            sNum2 = Scomposizione(f.Denominatore);
        }
        public Fractions Moltiplica(Fractions f)
        {
            int risNum = 0,risDen=0;
            Fractions fTemp;
            risNum = this.Numeratore * f.Numeratore;
            risDen = this.Denominatore * f.Denominatore;
            fTemp = new Fractions(risNum, risDen);
            return fTemp;
        }
        public void Sottrai(Fractions f)
        {

        }
        public Fractions Dividi(Fractions f)
        {
            Fractions ris=new Fractions();
            f.Inversione();
            ris=f.Moltiplica(f);
            return ris;

        }
        public string getFrazione()
        {
            return Numeratore + "/" + Denominatore;
        }
        private void Inversione()
        {
            int n = 0;
            n = this.Numeratore;
            this.Numeratore = this.Denominatore;
            this.Denominatore = n;
        }
        private int[] Scomposizione(int n)
        {
            int j = 0, i = 2, temp = 1, count = 0, g = 0, stessiNum = 1;
            int[] num = new int[100];
            int[] num2 = new int[100];
            while (i <= n)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    temp = i;
                    if (count != 0 && temp % i == 0)
                    {
                        temp = temp * Convert.ToInt32(Math.Pow(Convert.ToDouble(i), Convert.ToDouble(stessiNum)));
                        stessiNum++;
                    }
                    count++;
                }
                else
                {
                    num2[j] = temp;
                    j++;
                    i++;
                    count = 0;
                    temp = 1;
                    stessiNum = 1;
                }
            }
            num2[j] = temp;
            Array.Resize(ref num2, j + 1);
            count = 0;
            for (int f = 0; f < num2.Length; f++)
            {
                if (num2[f] != 1)
                {
                    num[g] = num2[f];
                    count++;
                    g++;
                }
            }
            Array.Resize(ref num, count);
            return num;
        }
        private int MCD(int[] n, int[] d)
        {
            //mcd=variabile che conterrà l'mcd,a e b sono variabili che conterranno i resti delle divisione tra i 2 numeri in ogni array
            int mcd = 1, a = 0, b = 0;
            //comparo ogni elemento del primo array con tutti gli elementi del secondo attraverso 2 cicli
            for (int x = 0; x < n.Length; x++)
            {
                for (int y = 0; y < d.Length; y++)
                {
                    a = n[x] % d[y];
                    b = d[y] % n[x];
                    //se entrambi i resti sono 0,allora significa che entrambi i numeri sono uguali e quindi lo aggingo all'mcd
                    if (a == 0 && b == 0)
                    {
                        mcd = mcd * n[x];
                    }
                    //se solo un resto è uguale a 0,allora vuol dire che l'altro resto sarà uguale al numero più piccolo e quindi lo aggiungo all'mcd
                    else if (a == 0 || b == 0)
                    {
                        if (a == 0)
                            mcd = mcd * b;
                        else
                            mcd = mcd * a;
                    }
                }
            }
            return mcd;
        }
        /*private int mcm(int[] n, int[] d)
        {
            int mcd = 1, a = 0, b = 0,count=0;
            //comparo ogni elemento del primo array con tutti gli elementi del secondo attraverso 2 cicli
            for (int x = 0; x < n.Length; x++)
            {
                for (int y = 0; y < d.Length; y++)
                {
                    //num={2,3,5} num2={5,9} num={2,3,5}
                    a = n[x] % d[y];
                    b = d[y] % n[x];
                    //se entrambi i resti sono 0,allora significa che entrambi i numeri sono uguali e quindi lo aggingo all'mcm
                    if (a == 0 && b == 0)
                    {
                        mcd = mcd * n[x];
                    }
                    //se solo un resto è uguale a 0,allora vuol dire che l'altro resto sarà uguale al numero più piccolo e quindi lo aggiungo all'mcd
                    else if (a == 0 || b == 0)
                    {
                        if (a > 0)
                            mcd = mcd * d[y];
                        else
                            mcd = mcd * n[x];
                    }
                    else if (a != 0 && b != 0)
                        count++;
                    if (count == d.Length)
                        mcd = mcd * n[x];
                }
            }
        }*/

    }
}
