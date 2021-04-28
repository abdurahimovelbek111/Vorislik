using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorislik13_2
{
    class Sanoqsistema
    {
        public int n;
        public Sanoqsistema(int n)
        {
            this.n = n;
        }
    }
    class Ikkilik : Sanoqsistema
    {
       private string x="";
        public string X1
        {
            get { return x; }
            set { x = value; }
        }
        public Ikkilik(int n, string x)
            : base(n)
        {
            this.x = x;
        }
        public string ikkilik()
        {
            while(n!=0)
            {
                x = (n % 2) + x;
                n /= 2;
            }
            return x;
        }
    }
    class Sakkizlik : Sanoqsistema
    {
        private string x = "";
        public string X1
        {
            get { return x; }
            set { x = value; }
        }
        public Sakkizlik(int n, string x)
            : base(n)
        {
            this.x = x;
        }
        public string sakkizlik()
        {
            while (n != 0)
            {
                x = (n % 8) + x;
                n /= 8;
            }
            return x;
        }
    }
    class UnOltilik : Sanoqsistema
    {
        private string x = "";
        public string X1
        {
            get { return x; }
            set { x = value; }
        }
        public UnOltilik(int n, string x)
            : base(n)
        {
            this.x = x;
        }
        public string unoltilik()
        {
            while (n != 0)
            {
                if(n%16==10)
                {
                    x = 'A' + x;
                }
                if (n % 16 == 11)
                {
                    x = 'B' + x;
                }
                if (n % 16 == 12)
                {
                    x = 'C' + x;
                }
                if (n % 16 == 13)
                {
                    x = 'D' + x;
                }

                if (n % 16 == 14)
                {
                    x = 'E' + x;
                }
                if (n % 16 == 15)
                {
                    x = 'F' + x;
                }
                else if(n%16<10)
                {
                    x = (n % 16) + x;
                }               
                n /= 16;
            }
            return x;
        }
    }

   
}
