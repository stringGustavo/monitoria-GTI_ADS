using System;

namespace QuantidadeTermosSequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeTermos, n;

            Console.WriteLine("Exemplo 01 - Quantidade de termos em uma sequência.\n");

            Console.Write("Digite uma quantidade de termos: ");
            quantidadeTermos = int.Parse(Console.ReadLine());

            /* SEQUÊNCIA PADRÃO */
            Console.WriteLine("");
            for(int i = 1; i <= quantidadeTermos; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine("- Sequência Padrão.");
            /* FIM DA SEQUÊNCIA PADRÃO */


            /* SEQUÊNCIA PADRÃO INVERTIDA(DECRESCENTE)*/
            Console.WriteLine("");
            for(int i = quantidadeTermos; i >= 1; i--)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine("- Sequência Padrão invertida.");
            /* FIM DA SEQUÊNCIA PADRÃO INVERTIDA */


            /* SEQUÊNCIA DE MÚLTIPLOS DE 'n' */
            Console.Write("\nDigite um valor para 'n': ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for(int i = 1; i <= quantidadeTermos; i++)
            {
                if(i % n == 0)
                {
                    Console.Write("{0} ",i);
                }
                else{
                    quantidadeTermos++;
                }
            }
            Console.WriteLine("- Sequência de múltiplos de 'n'.");
            /*FIM SEQUÊNCIA DE MÚLTIPLOS DE 'n' */


            //! Essa sequência invertida depende da sequência multíplos de 'n'.
            /* SEQUÊNCIA DE MÚLTIPLOS DE 'n' INVERTIDA*/
            Console.WriteLine("");
            for(int i = quantidadeTermos; i >= 1; i--)
            {
                if(i % n == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("- Sequência de múltiplos de 'n' invertida.");
            /* FIM DA SEQUÊNCIA DE MÚLTIPLOS DE 'n' INVERTIDA*/
        }
    }
}
