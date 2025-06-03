using System;
using Exercicios;
using Exercicios2;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCICIO DIA1");
            Dia1 dia1 = new Dia1();
            dia1.ExibirMensagem();

            Console.WriteLine();

            Console.WriteLine("EXERCICIO DIA2");
            Dia2 dia2 = new Dia2();
            dia2.ExibirInfo();

            Console.WriteLine();


            Console.WriteLine("EXERCICIOS DIA3");
            Dia3 dia3 = new Dia3();
            dia3.OperadoresMatematica();

            Console.WriteLine();
            dia3.OperadoresRelacionais();

            Console.WriteLine();
            dia3.OperadoresLogicos();

            Console.WriteLine();
            dia3.Exercicio1();

            Console.WriteLine();
            dia3.Exercicio2();


        }
    }
}

