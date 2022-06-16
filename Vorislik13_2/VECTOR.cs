using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorislik13_2
{
    class VECTOR
    {
        public int n;
        public int[] A { get; set; }
        public int[] B { get; set; }

        Random rand = new Random();
        public VECTOR(int n)
        {
            this.n = n;
            A = new int[n];
            B = new int[n];            
        }
        public int[] A_Vector()
        {
            for (int i = 0; i < n; i++)
            {
                A[i] = rand.Next() % 10;
            }
            return A;
        }
        public int[] B_Vector()
        {
            for (int i = 0; i < n; i++)
            {
                B[i] = rand.Next() % 10;
            }
            return B;
        }
      
    }
    class VECTOR_AMAL:VECTOR
    {
        public int[] C { get; set; }
        public VECTOR_AMAL(int n)
            :base(n)
        {
            C = new int[n];
        }
        public int[] A_B_Add()
        {
            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] + B[i];
            }
            return C;
        }
        public int[] A_B_Ayirish()
        {
            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] - B[i];
            }
            return C;
        }
        public int[] A_B_Kupaytirish()
        {
            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] * B[i];
            }
            Console.WriteLine(" Uzunligi :" + C.Length);
            return C;
        }
        public int A_B_Kosinusi()
        {
            int cos, s = 0, A1 = 0, B1 = 0;

            for (int i = 0; i < n; i++)
            {
                s += A[i] * B[i];
                A1 += (int)Math.Pow(A[i], 2);
                B1 += (int)Math.Pow(B[i], 2);
            }
            cos = s / (A1 * B1);
            return cos;
        }
    }
}
