using System;
using System.Diagnostics.Contracts;


namespace Exercicios3
{
    public class Dia3
    {
        public void EstruturaCondicional()
        {
            // Estrutura Condicional If e Else
            int idade = 15;

            if (idade <= 12)
            {
                Console.WriteLine("Voce é menor de idade");
            }
            else if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine("Voce é Adolescente");
            }
            else if (idade >= 18 && idade <= 50)
            {
                Console.WriteLine("Voce é adulto!");
            }
            else
            {
                Console.WriteLine("Voce ja está com a idade avançada");
            }
        }
        public void BlocoCondicional()
        {
            int dia = 6;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;


            }
        }
        public void ExercicioDia3()
        {
            int temperatura = 15;

            if (temperatura < 15)
            {
                Console.WriteLine("Está frio!");
            }
            else if (temperatura >= 15 && temperatura < 25)
            {
                Console.WriteLine("Temperatura Agradável");
            }
            else
            {
                Console.WriteLine("Está calor!");
            }
        }
    }
}