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
            set { _numeratore = value;}
        }
        public int Denominatore
        {
            set { _denominatore = value; }
            get { return _denominatore; }
        }
        //semplificazione di una frazione,se non è possibile semplificarla allora non cambierà
        public void Semplifica()
        {
            int[] sNum;
            int[] sDen;
            int massimoComuneDivisore = 0;

            if (this.Denominatore == 0)
                throw new Exception("Il denominatore non può essere 0");
            if (this.Numeratore == this.Denominatore)
            {
                this.Numeratore = 1;
                this.Denominatore = 1;
            }
            else if(this.Numeratore>0)
            {
                sNum = Scomposizione(Numeratore);
                sDen = Scomposizione(Denominatore);
                massimoComuneDivisore = MCD(sNum, sDen);
                Numeratore = Numeratore / massimoComuneDivisore;
                Denominatore = Denominatore / massimoComuneDivisore;
            }
            else if (this.Numeratore < 0)
            {
                this.Numeratore = this.Numeratore * -1;
                sNum = Scomposizione(Numeratore);
                sDen = Scomposizione(Denominatore);
                massimoComuneDivisore = MCD(sNum, sDen);
                Numeratore = Numeratore / massimoComuneDivisore;
                Numeratore = Numeratore * -1;
                Denominatore = Denominatore / massimoComuneDivisore;
            }
        }
        //somma tra due frazioni
        public Fractions Somma(Fractions f)
        {
            Fractions risultato = new Fractions();
            int minimoComuneMultiplo = 0;

            if(this.Denominatore==0 || f.Denominatore==0)
                throw new Exception("Il denominatore non può essere 0");
            if (this.Denominatore == f.Denominatore)
            {
                risultato.Numeratore = this.Numeratore + f.Numeratore;
                risultato.Denominatore = f.Denominatore;
                return risultato;
            }
            minimoComuneMultiplo = this.Denominatore*f.Denominatore;
            risultato.Numeratore = ((minimoComuneMultiplo / this.Denominatore) * this.Numeratore) + ((minimoComuneMultiplo / f.Denominatore) * f.Numeratore);
            risultato.Denominatore = minimoComuneMultiplo;
            return risultato;
        }
        //moltiplicazione tra due frazioni
        public Fractions Moltiplica(Fractions f)
        {
            int risNum = 0,risDen=0;
            Fractions fTemp;

            if (this.Denominatore == 0 || f.Denominatore == 0)
                throw new Exception("Il denominatore non può essere 0");
            risNum = this.Numeratore * f.Numeratore;
            risDen = this.Denominatore * f.Denominatore;
            fTemp = new Fractions(risNum, risDen);
            return fTemp;
        }
        //sottrazione tra due frazioni
        public Fractions Sottrai(Fractions f)
        {
            Fractions risultato = new Fractions();
            int minimoComuneMultiplo = 0;

            if (this.Denominatore == 0 || f.Denominatore == 0)
                throw new Exception("Il denominatore non può essere 0");
            if (this.Denominatore == f.Denominatore)
            {
                risultato.Numeratore = this.Numeratore - f.Numeratore;
                risultato.Denominatore = f.Denominatore;
                return risultato;
            }
            minimoComuneMultiplo = this.Denominatore * f.Denominatore;
            risultato.Numeratore = ((minimoComuneMultiplo / this.Denominatore) * this.Numeratore) - ((minimoComuneMultiplo / f.Denominatore) * f.Numeratore);
            risultato.Denominatore = minimoComuneMultiplo;
            return risultato;
        }
        //divisione tra due frazioni
        public Fractions Dividi(Fractions f)
        {
            Fractions ris=new Fractions();

            if (this.Denominatore == 0 || f.Denominatore == 0)
                throw new Exception("Il denominatore non può essere 0");
            f.Inversione();
            ris=this.Moltiplica(f);
            return ris;
        }
        //restituisce la frazione
        public override string ToString()
        {
            return Numeratore + "/" + Denominatore;
        }
        //scambia di posto il numeratore con il denominatore
        private void Inversione()
        {
            int n = 0;
            n = this.Numeratore;
            this.Numeratore = this.Denominatore;
            this.Denominatore = n;
        }
        //scompone un numero in fattori primi,mettendoli poi in un array
        private int[] Scomposizione(int n)
        {
            int j = 0, i = 2, temp = 1, count = 0, g = 0, stessiNum = 1;
            int[] num = new int[9999999];
            int[] num2 = new int[9999999];
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
            Array.Sort(num);
            return num;
        }
        //esegue l'mcd tra due array contenenti la scomposizione in fattori primi di due numeri
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
        // controlla se l'oggetto creato contiene una frazione oppure no
        public static bool Esiste(Fractions f)
        {
            if (f != null)
                return true;
            return false;
        }
        //copia una frazione in un altro oggetto
        public static Fractions Clone(Fractions f)
        {
            Fractions fTemp;
            if (Fractions.Esiste(f))
            {
                fTemp = new Fractions(f.Numeratore, f.Denominatore);
                return fTemp;
            }
            return null;
        }
    }

}
