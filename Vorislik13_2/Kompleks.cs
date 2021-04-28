using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorislik13_2
{
    class Kompleks
    {
        private string a1;
        private string a2;
        public Kompleks(string a1,string a2)
        {
            this.a1 = a1;
            this.a2 = a2;
        }
        public string A1
        {
            get { return a1; }
            set { a1 = value; }
        }
        public string A2
        {
            get { return a2; }
            set { a2 = value; }
        }
    }
    class Komp_Kv_Tenglama : Kompleks
    {
        private string b1;
        public string B1
        {
            get { return b1; }
            set { b1 = value; }
        }
        public Komp_Kv_Tenglama(string a1, string a2, string b1)
            : base(a1, a2)
        {
            this.b1 = b1;
        }
        public string Yigindi()
        {
            string[] a = A1.Split('+','i','*');
            string[] a1 = A2.Split('+', 'i', '*');
            int c1 = int.Parse(a[0]) + int.Parse(a1[0]);
            int c2 = int.Parse(a[1]) + int.Parse(a1[1]);
            b1 = c1+ "+" + c2+"*i";
            return b1;
        }
        public string Ayirma()
        {
            string[] a = A1.Split('+', 'i', '*');
            string[] a1 = A2.Split('+', 'i', '*');
            int c1 = int.Parse(a[0]) - int.Parse(a1[0]);
            int c2 = int.Parse(a[1]) - int.Parse(a1[1]);
            if(c2==0)
            b1 = c1 + "-" + "("+c2+")" + "*i";
            b1 = b1.Remove(1);
            return b1;
        }
        public string Kopaytma()
        {
            string[] a = A1.Split('+', 'i', '*');
            string[] a1 = A2.Split('+', 'i', '*');
            int c1 = int.Parse(a[0]) * int.Parse(a1[0]) - int.Parse(a[1])*int.Parse(a1[1]);
            int c2 = int.Parse(a[0]) * int.Parse(a1[1]) + int.Parse(a[1]) * int.Parse(a1[0]);
            b1 = c1 + "+" +c2 + "*i";
            return b1;
        }
        public string Bolinma()
        {
            string[] a = A1.Split('+', 'i', '*');
            string[] a1 = A2.Split('+', 'i', '*');
            int c1 = int.Parse(a[0]) * int.Parse(a1[0]) + int.Parse(a[1]) * int.Parse(a1[1]);
            int c2 = int.Parse(a1[0]) * int.Parse(a[1]) - int.Parse(a[0]) * int.Parse(a1[1]);
            int c3 = int.Parse(a[0]) * int.Parse(a[0]) + int.Parse(a[1]) * int.Parse(a[1]);
            if(c2>0 && c2<0)
            b1 = (c1/c3 + " + " + "("+c2/c3+")" + "*i");
            else if(c2==0)
            {
                b1 = (c1 / c3 + " + " + "(" + c2 / c3 + ")" + "*i");
                b1 =b1.Remove(1);
            }
            return b1;
        }
    }
}
