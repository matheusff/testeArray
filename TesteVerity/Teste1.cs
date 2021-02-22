using System;
using System.Collections.Generic;
using System.Text;

namespace TesteVerity
{
    public class Teste1
    {
        public int[] RetornarArrayInvertido(int[] objArray)
        {

            int[] objArrayInvertido = new int[objArray.Length];
            int count = 0;

            for(int i = objArray.Length -1; i >= 0 ; i--)
            {
                objArrayInvertido[count] = objArray[i];
                count++;
            }

            return objArrayInvertido;

        }
    }
}
