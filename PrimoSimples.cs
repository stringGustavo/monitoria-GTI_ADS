using System;

namespace NumeroPrimoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    contador++;
                }
            }

            if(contador == 2)
            {
                Console.Write("\n{0} É primo.",numero);
            }
            else{
                Console.Write("\n{0} Não é primo.",numero);
            }
        }
    }
}
