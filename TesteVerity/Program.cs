using System;

namespace TesteVerity
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste1 teste1 = new Teste1();
            Teste2 teste2 = new Teste2();

            Console.WriteLine("************************************************Iniciando Teste 1****************************************************");

            int[] arrayIni = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int[] arrayFin = teste1.RetornarArrayInvertido(arrayIni);

            foreach(int i in arrayFin)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("************************************************Iniciando Teste 2****************************************************");
            teste2.EscreverSequenciaNumerica();
        }
    }
}
