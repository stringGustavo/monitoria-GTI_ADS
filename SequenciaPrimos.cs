using System;

namespace SequenciaPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequência de números primos.\n");

            long quantidadeTermos, validarPrimo;

            do{
                Console.Write("Digite a quantidade de termos desejados: ");
                quantidadeTermos = Convert.ToInt64(Console.ReadLine());

                if(quantidadeTermos < 0)
                {
                    Console.WriteLine("\nQuantidade inválida!\n");
                }
            } while(quantidadeTermos < 0);

            Console.WriteLine("");
            for(int i = 2; i <= quantidadeTermos+1; i++)
            {
                validarPrimo = 1;
                for(int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        validarPrimo = 0;
                    }
                }

                if(validarPrimo == 1)
                {
                    Console.Write("{0} ",i);
                }
                else
                {
                    quantidadeTermos++;
                }
            }

        }
    }
}
