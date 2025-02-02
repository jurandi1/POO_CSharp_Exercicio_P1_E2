﻿using POO_CSharp_Exercicio_P1_E2;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //EXERCÍCIO 02:
        //Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
        //médio dos funcionários.

        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionário: ");
        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine("Dados do segundo funcionário: ");
        Console.Write("Nome: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (f1.Salario + f2.Salario) / 2.0;

        Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}