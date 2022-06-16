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
            //Raqamlar kom = new Raqamlar(a1, a2, "");
            //Console.WriteLine("Ikkita Kompliks sonlar yig'indisi :" + kom.Yigindi());
            //Console.WriteLine("Ikkita Kompiliks sonlar Bo'linmasi :" + kom.Yigindi_Birinchiga());
            //Console.WriteLine("Ikkita Kompiliks sonlar Bo'linmasi :" + kom.Yigindini_Ikkinchiga());
            //Console.ReadKey();
            //Console.WriteLine("Ikkita Kompliks sonlar ayirmasi :" + kom.Ayirma());
            //Console.WriteLine("Ikkita Kompliks sonlar Ko'paytmasi :" + kom.Kopaytma());
            //-----------3--------------//
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("m=");
            //int m = int.Parse(Console.ReadLine());
            //Vector vec = new Vector(n, m);
            //int[,] A =vec.A_Matrissa();
            //int[,] B =vec.B_Matrissa();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(A[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("------------------------------------>");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(B[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-----------Hosil bulgan vector------------------------->");

            //int[] X = vec.Hisobla();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(X[i] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("------------Matrissa ayirmasi------------------------>");
            //X = arif.Ayirma_Matrissa();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(X[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("----------Matrissa ko'paytmasi------------------------>");
            //int[,] Y = arif.Kopaytma_Matrissa();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(Y[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}


            ////-------------------5---------------------//
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //VECTOR vek = new VECTOR(n);
            //int[,] A = vek.Fazo_elementlar();


            //for (int i = 0; i < n * n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(A[i,j]+"   ");
            //    }
            //    Console.WriteLine();
            //}          
            //mbox:
            //Console.WriteLine('\n');
            //Console.Write("k=");
            //int k = int.Parse(Console.ReadLine());
            //switch (k)
            //{
            //    case 0:
            //        for (int i = 0; i < n ; i++)
            //        {                      
            //            Console.Write(A[i] + "   ");
            //        }
            //     break;
            //    case 1:
            //        for (int i = n; i < 2*n; i++)
            //        {
            //            Console.Write(A[i] + "   ");
            //        }break;
            //    case 2:
            //        for (int i = 2*n; i < 3*n; i++)
            //        {
            //            Console.Write(A[i] + "   ");
            //        }
            //        break;
            //    case 3:
            //        for (int i = 3*n; i < 4* n; i++)
            //        {
            //            Console.Write(A[i] + "   ");
            //        }
            //        break;
            //}
            //Console.WriteLine('\n');
            //Console.Write("k=");
            //int d = int.Parse(Console.ReadLine());
            //switch (d)
            //{
            //    case 0:
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write(A[i] + "   ");
            //        }
            //        break;
            //    case 1:
            //        for (int i = n; i < 2 * n; i++)
            //        {
            //            Console.Write(A[i] + "   ");
            //        }
            //        break;
            //    case 2:
            //        for (int i = 2 * n; i < 3 * n; i++)
            //        {
            //            Console.Write(A[i] + "   ");
            //        }
            //        break;
            //    case 3:
            //        for (int i = 3 * n; i < 4 * n; i++)
            //        {
            //            Console.Write(A[i] + "   ");
            //        }
            //        break;
            //}
            //Console.WriteLine('\n');
            //int[] B = new int[100];
            //Console.Write("Amalni kiriting :");
            //char a = char.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case '+':
            //        for (int i = k*n; i < (k+1) * n; i++)
            //        {
            //            int j = d * n;
            //            B[i] = A[i] + A[j];
            //            Console.Write(B[i] + "   ");
            //            j++;
            //        }
            //        break;
            //case '-':
            //    for (int i = k * n, j = d * n; i < (k + 1) * n; i++)
            //    {
            //        B[i] = A[i] - A[j];
            //        Console.Write(B[i] + "   "); j++;
            //    }
            //    break;
            //case '*':
            //    for (int i = k * n, j = d * n; i < (k + 1) * n; i++, j++)
            //    {
            //        B[i] = A[i] * A[j];
            //        Console.Write(B[i] + "   ");
            //    }
            //    break;
            //case '/':
            //    for (int i = k * n, j = d * n; i < (k + 1) * n; i++, j++)
            //    {
            //        B[i] = A[i] / A[j];
            //        Console.Write(B[i] + "   ");
            //    }
            //    break;
            //Console.Write("n=");
            //int n=int.Parse(Console.ReadLine());
            //Natija natija = new Natija(n);
            // natija.Daraja_Koefsent();
            // string y = natija.kophadd();
            // Console.WriteLine("Berilgan ko'phad :"+y);
            // string x = natija.Xosila();
            // Console.WriteLine("Xosila olingan ko'phad :"+x);

            //+++++++++++++++++++++++++++++++++++++++
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            VECTOR_AMAL vek = new VECTOR_AMAL(n);
            int[]vector = vek.A_Vector();
            Console.WriteLine("A vector elementlari :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i]+"  ");
            }
            Console.WriteLine("\n"+"B vector elementleri :");
            vector= vek.B_Vector();
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + "  ");
            }
            Console.WriteLine("\n"+"A va B vector elementlerini qushish :");
            vector = vek.A_B_Add();
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + "  ");
            }
            Console.WriteLine("\n"+"A va B vector elementlari ayirish :");
            vector = vek.A_B_Ayirish();
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + "  ");
            }
            Console.WriteLine("\n"+"A va B vector elementlarini Ko'paytirish :");
            vector = vek.A_B_Kupaytirish();
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + "  ");
            }
            Console.WriteLine("\n"+"Kosinusi :"+vek.A_B_Kosinusi());
            Console.ReadKey();
         }

           // Console.ReadKey();
            //goto mbox;

        }
    }

