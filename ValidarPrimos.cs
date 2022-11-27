using System;

namespace ValidarNumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            long numeroDigitado;
            long maior = 0, menor = Int64.MaxValue;

            Console.WriteLine("Exercício com números primos.\nDigite 0 para encerrar.");

            do{
                long contadorPrimo = 0;

                do{
                    Console.Write("\nDigite um número: ");  
                    numeroDigitado = Convert.ToInt64(Console.ReadLine());

                    if(numeroDigitado < 0)
                    {
                        Console.WriteLine("\nNúmero inválido!");
                    }

                } while(numeroDigitado < 0);
                Console.Clear();

                if(numeroDigitado == 0)
                {
                    Console.WriteLine("\nPrograma Finalizado.\n");
                    break;
                }
                
                for(int i = 1; i <= numeroDigitado; i++) 
                {
                    if(numeroDigitado % i == 0)
                    {
                       contadorPrimo++;
                    }
                }

                if(contadorPrimo == 2)
                {   
                    Console.Write("\n{0} é primo.\n",numeroDigitado);

                    if(numeroDigitado > maior)
                    {
                        maior = numeroDigitado;
                    }

                    if(menor > numeroDigitado)
                    {
                        menor = numeroDigitado;
                    }
                }
                else
                {
                    Console.Write("\n{0} não é primo.\n", numeroDigitado);
                }
            } while(numeroDigitado != 0);

            Console.WriteLine("Maior número primo digitado: {0}\nMenor número primo digitado: {1}",maior,menor);
        }
    }
}
