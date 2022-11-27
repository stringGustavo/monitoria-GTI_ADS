using System;

namespace MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, maior = 0, menor = int.MaxValue; //! int.MaxValue é uma constante com o maior valor possível para uma variável do tipo int.
            double soma = 0, media = 0;

            Console.WriteLine("Exemplo 02 - Soma, Média, Maior e Menor número.");

            for(int i = 1; i <= 5; i++)
            {
                do{
                    Console.Write("Digite o {0}º número: ",i);
                    numero = int.Parse(Console.ReadLine());

                    if(numero < 0)
                    {
                        Console.WriteLine("\nValor inválido.\n");
                    }
                } while(numero < 0);

                soma += numero;

                if(maior < numero) //! A variável maior pode ter o valor mais baixo, 0 ou 'int.MinValue'.
                {
                    maior = numero;
                }
                if(menor > numero) //! A variável 'menor' precisa receber um valor inicial bem alto para funcionar, de preferência use 'int.MaxValue'.
                {
                    menor = numero;
                }
            }

            media = soma / 10;

            Console.WriteLine("\nMédia: {0}.", Math.Round(media, 2, MidpointRounding.ToZero)); //! Arredondamento.
            Console.Write("Maior número digitado: {0}.\nMenor número digitado: {1}.", maior, menor);
        }
    }
}
