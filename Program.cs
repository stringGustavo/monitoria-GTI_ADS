using System;

namespace SequenciaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {   int number1, number2, aux;

            Console.WriteLine("Exemplo 00 - Uso do Auxiliar.\nSequências de números.\n");

            Console.Write("Digite o primeiro termo: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo termo: ");
            number2 = int.Parse(Console.ReadLine());

            if(number1 > number2) //! "Se number1 for maior que number2" o auxiliar troca o valor das duas variáveis.
            {
                aux = number1;
                number1 = number2;
                number2 = aux;
            } //! Sem a utilização do auxiliar a condição do 'for' abaixo será falsa e o código não vai funcionar.

            /* SEQUÊNCIA CRESCENTE DE NÚMEROS PARES */
            Console.WriteLine("");
            for(int i = number1; i <= number2; i++)
            {
                if(i % 2 == 0) //! Imprime apenas números múltiplos de 2, ou seja, pares.
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("- Sequência crescente de pares.");
            /* FIM DA SEQUÊNCIA CRESCENTE DE NÚMEROS PARES */
         

            /* SEQUÊNCIA DECRESCENTE DE NÚMEROS PARES */
            Console.WriteLine("");
            for(int i = number2; i >= number1; i--)
            {
                if(i % 2 == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("- Sequência decrescente de pares.");
            /*FIM DA SEQUÊNCIA DECRESCENTE DE NÚMEROS PARES */


            /* SEQUÊNCIA CRESCENTE DE NÚMEROS ÍMPARES */
            Console.WriteLine("");
            for (int i = number1; i <= number2; i++)
            {
                if(i % 2 != 0) //! Imprime apenas números ímpares.
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("- Sequência crescente de ímpares.");
            /* FIM DA SEQUÊNCIA CRESCENTE DE NÚMEROS ÍMPARES */


            /* SEQUÊNCIA DECRESCENTE DE NÚMEROS ÍMPARES */
            Console.WriteLine("");
            for(int i = number2; i >= number1; i--)
            {
                if(i % 2 != 0)
                {
                    Console.Write("{0} ",i);
                }
            }Console.WriteLine("- Sequência decrescente de ímpares.");
            /* FIM DA SEQUÊNCIA DECRESCENTE DE NÚMEROS ÍMPARES */


            /* SEQUÊNCIA CRESCENTE DE NÚMEROS PARES VERDES, ÍMPARES VERMELHOS*/ //! Não recomendo usar na prova.

            Console.WriteLine("");
            for(int i = number1; i <= number2; i++)
            {
                if(i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.Write("{0} ",i);
                    Console.ResetColor();
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} ",i);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("- Pares verdes, ímpares vermelhos.");
            /* FIM DA SEQUÊNCIA CRESCENTE DE NÚMEROS PARES VERDES, ÍMPARES VERMELHOS*/


            /* SEQUÊNCIA CRESCENTE, ÍMPARES SUBSTITUIDOS POR 'X' */
            Console.WriteLine("");
            for(int i = number1; i <= number2; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write("{0} ",i);
                }
                else{
                    Console.Write("X ");
                }
            }
            Console.WriteLine("- Ímpares substituidos por 'X'.");
            /* FIM DA SEQUÊNCIA CRESCENTE, ÍMPARES SUBSTITUIDOS POR 'X' */  


            /* SEQUÊNCIA DE MÚLTIPLOS DE 5 */
            Console.WriteLine("");
            for(int i = number1; i <= number2; i++)
            {
                if(i % 5 == 0) //! Pode ser usada para identificar múltiplos de qualquer número.
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("- Múltiplos de 5.");
            /* FIM DA SEQUÊNCIA DE MÚLTIPLOS DE 3 */
        }
    }
}
