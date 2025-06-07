using System;

namespace Exercicios
{
    public class Dia
{
    public void ExibirMensagem()
    {
        string nome = "Lucas";

        Console.WriteLine($"Seja Bem-vindo ao C#, {nome} ");
    }
}

public class Dia1
{
    public void ExibirInfo()
    {
        string nome = "Lucas";
        char letra = 'A';
        bool verdadeiro = true;
        double peso = 56.5;
        float altura = 1.70f;
        int idade = 21;

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Inicial: {letra}");
        Console.WriteLine($"Voce é Desenvolvedor? {verdadeiro}");
        Console.WriteLine($"Peso: {peso}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Idade: {idade}");
    }
}
} 