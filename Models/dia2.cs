using System;
using System.Globalization;

namespace Exercicios2
{
    public class Dia3
    {
        public void OperadoresMatematica()
        {
            int n1 = 5;
            int n2 = 8;

            Console.WriteLine($"Soma: {n1 + n2}");
            Console.WriteLine($"Subtração: {n1 - n2}");
            Console.WriteLine($"Multiplicação: {n1 * n2}");
            Console.WriteLine($"Divisão: {n1 / n2}");
            Console.WriteLine($"Módulo: {n1 % n2}");

        }
        public void OperadoresRelacionais()
        {
            int number1 = 10;
            int number2 = 20;

            Console.WriteLine($"{number1} é igual a {number2}? - {number1 == number2}");
            Console.WriteLine($"{number1} é diferente de {number2}? - {number1 != number2}");
            Console.WriteLine($"{number1} é maior que {number2}? - {number1 > number2}");
            Console.WriteLine($"{number1} é menor que {number2}? - {number1 < number2}");
            Console.WriteLine($"{number1} é maior ou igual a {number2}? - {number1 >= number2}");
            Console.WriteLine($"{number1} é menor ou igual a {number2}? - {number1 <= number2}");
        }
        public void OperadoresLogicos()
        {
            int a = 10;
            int b = 3;

            bool resultado = (a > 5 && b < 5);
            Console.WriteLine($"a > 5 e B < 5? {resultado}");
        }
        public void Exercicio1()
        {
            int numero1 = 10;
            int numero2 = 15;

            Console.WriteLine($"a soma entre o número {numero1} e {numero2} é igual a {numero1 + numero2}");
            Console.WriteLine($"a subtracao entre o número {numero1} e {numero2} é igual a {numero1 - numero2}");
            Console.WriteLine($"a multiplicação entre o número {numero1} e {numero2} é igual a {numero1 * numero2}");
            Console.WriteLine($"a divisão entre o número {numero1} e {numero2} é igual a {numero1 / numero2}");

        }
        public void Exercicio2()
        {
            Console.Write("Digite sua idade: ");
            string? entrada = Console.ReadLine();
            int idade = int.Parse(entrada ?? "0");

            if (idade > 18 && idade < 60)
            {
                Console.WriteLine("Voce está na faixa adulta");

            }
            else
            {
                Console.WriteLine("Voce está fora da faixa adulta ativa");
            }

        }
    }
}