using System;

namespace Parametros
{


        static void CatetoA_ref(ref int A)
        {
            A = A*A;
        }

        static int CatetoB_in(in int B, out Resultado)
        {
            Resultado = B*B;
        }

        static void Raiz(int A, int B, out Resultado)
        {
            Resultado = (A + B)^(1/2);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            int A = 4;
            int B = 3;
            int ResB;
            int C;

           CatetoA_ref(ref A);
           CatetoB_in(in B, out ResB);
           Raiz(A, B, out C);
        }
    }
}
