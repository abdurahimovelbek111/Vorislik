using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorislik13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------1------------------//
            //Console.Write("O'nlik sanoqsistemadagi sonni kiriting :");
            //int n = int.Parse(Console.ReadLine());
            //Ikkilik ikki = new Ikkilik(n, "");
            //Console.WriteLine("Ikkilik sanoq sistemasidagi ko'rinishi :" + ikki.ikkilik());
            //Sakkizlik sakkiz = new Sakkizlik(n, "");
            //Console.WriteLine("Sakkizlik sanoqsistemadagi ko'rinishi :" + sakkiz.sakkizlik());
            //UnOltilik unoltti = new UnOltilik(n, "");
            //Console.WriteLine("O'nOltilik ko'rinishi :" + unoltti.unoltilik());
            ////-----------2-------------//
            //Console.Write("Birinchi kompliks son :");
            //string a1 = Console.ReadLine();
            //Console.Write("Ikkinchi kompliks son :");
            //string a2 = Console.ReadLine();
            //Komp_Kv_Tenglama kom = new Komp_Kv_Tenglama(a1, a2, "");
            //Console.WriteLine("Ikkita Kompliks sonlar yig'indisi :" + kom.Yigindi());
            //Console.WriteLine("Ikkita Kompliks sonlar ayirmasi :" + kom.Ayirma());
            //Console.WriteLine("Ikkita Kompliks sonlar Ko'paytmasi :" + kom.Kopaytma());
            //Console.WriteLine("Ikkita Kompiliks sonlar Bo'linmasi :" + kom.Bolinma());
            //-----------3--------------//
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
           ARIFM_MATRITSA arif = new ARIFM_MATRITSA(n,m);
            int[,] A = arif.A_Matrissa();
            int[,] B =arif.B_Matrissa();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------>");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(B[i, j] + "  ");
                }
                Console.WriteLine();
            } 
            Console.WriteLine("-----------Matrissa yig'indisi------------------------->");
           
            int[,] X = arif.Yig_Matrissa();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(X[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------Matrissa ayirmasi------------------------>");
            X = arif.Ayirma_Matrissa();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(X[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------Matrissa ko'paytmasi------------------------>");
             int s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {   for(int k=0;k<m;k++)
                    {
                        s += arif.A[i, k] * arif.B[k, j];
                    }
                    Console.Write(s + "  ");
                    s = 0;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
