using System;
using System.Collections.Generic;
using System.Text;

namespace PF02_Actividad1
{
    public class FuncionesFactorial
    {
        public int CalcularFactorial(int n)
        {
            // Factorial menor a 0
            if (n < 0)
            {
                return -1;
            }

            // Factorial = 0
            if (n == 0)
            {
                return 1;
            }


            // Factorial número positivo ABRP2627
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
