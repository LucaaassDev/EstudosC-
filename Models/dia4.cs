using System;


namespace Exercicios4
{
    public class Dia4()
    {
        public void While()
        {
            // while
            // Repete enquanto a condição for verdadeira:

            int i = 0;

            while (i < 4)
            {
                Console.WriteLine($"Valor do Indice: {i}");
                i++;
            }
        }
        public void doWhile()
        {

            // do-while
            // Garante pelo menos uma execução:
            int j = 0;

            do
            {
                Console.WriteLine($"Valor de j: {j}");
                j++;
            } while (j < 5);
        }
        public void forr()
        {
            for (int k = 0; k < 8; k++)
            {
                Console.WriteLine($"Valor de k: {k}");
            }
        }
    }
}