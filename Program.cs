using System;
using Exercicios;
using Exercicios2;
using Exercicios3;
using Exercicios4;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCICIO");

            // Aprendendo Comandos Básicos
            // -input
            // -Declaração de váriaveis
            Dia dia = new Dia();
            dia.ExibirMensagem();

            Console.WriteLine(); // Quebra de linha

            Console.WriteLine("EXERCICIO DIA1");
            // Aprendendo Tipos Primitivos e Apresentando no input como:
            // string nome = "Lucas";
            // char letra = 'A';
            // bool verdadeiro = true;
            // double peso = 56.5;
            // float altura = 1.70f;
            // int idade = 21;
            Dia1 dia1 = new Dia1();
            dia1.ExibirInfo();

            Console.WriteLine(); // Quebra de linha


            Console.WriteLine("EXERCICIOS DIA2");
            // Aprendendo Operadores de Mátematica como:
            // +  Soma
            // -  Subtracao
            // *  Multiplicação
            // /  Divisão
            // %  Módulo (Resto da Divisão)
            Dia2 dia2 = new Dia2();
            dia2.OperadoresMatematica();

            Console.WriteLine(); // Quebra de linha
            // Aprendendo Operadores Relacionais como:
            // == Igual
            // != Diferente
            // < Menor
            // > Maior
            // <= Menor igual
            // >= Maior igual
            dia2.OperadoresRelacionais();

            Console.WriteLine(); // Quebra de linha
            // Aprendendo Operadores Lógicos como:
            // && e/and
            // ! not
            dia2.OperadoresLogicos();

            Console.WriteLine(); // Quebra de linha
            dia2.Exercicio1();

            Console.WriteLine();
            // dia2.Exercicio2();

            Console.WriteLine(); // Quebra de linha


            Console.WriteLine("EXERCICIOS DIA3");
            // Aprendendo a Estrutura Condicional If/Else
            Dia3 dia3 = new Dia3();
            dia3.EstruturaCondicional();

            Console.WriteLine();
            // Aprendendo Bloco de Condição Switch Case
            dia3.BlocoCondicional();

            Console.WriteLine(); // quebra de linha

            Dia4 dia4 = new Dia4();
            dia4.While();

            Console.WriteLine(); // Quebra de linha

            dia4.doWhile();

            Console.WriteLine(); // Quebra de linha

            dia4.forr();



        }
    }
}

