using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorislik13_2
{
    class Kophad
    {
        public int[] koefsent;
        public int[] daraja;
        public int n;
        public string kophad = "";
        Random rand = new Random();
        public Kophad(int n)
        {
            this.n = n;
            koefsent = new int[n];
            daraja = new int[n];
        }
        public void Daraja_Koefsent()
        {
            for (int i = 0; i < n; i++)
            {
                daraja[i] = rand.Next() % 10;
                Console.Write(daraja[i]+"  ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                koefsent[i] = rand.Next() % 10;
                Console.Write(koefsent[i] + "  ");
            }
            Console.WriteLine();
        }
        public string kophadd()
        {

            for (int i = 0; i < n; i++)
            {
                if(i==n-1)
                {
                    kophad += koefsent[i] + "*X^" + daraja[i];
                }
                else
                {
                    kophad += koefsent[i] + "*X^" + daraja[i]+"+";
                }
            }
            return kophad;
        }
       
    }
    class Natija : Kophad
    {
        public string xosilasi = "";
        public Natija(int n)
            : base(n)
        {

        }
        public string Xosila()
        {           
            for (int i = 0; i < n; i++)
            {
                if(i==n-1)
                {
                    xosilasi += koefsent[i] + "*X^" + (daraja[i] - 1) + "+";
                }
                else
                {
                    xosilasi += koefsent[i]*daraja [i] + "*X^" + (daraja[i] - 1)+"+";
                }
            }
            return xosilasi;
        }

    }
}
