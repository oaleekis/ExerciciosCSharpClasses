﻿using System.Globalization;

namespace ExerciciosCSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            // Primeiros exercícios: Introdução à Programação Orientada a Objetos

            #region Ex - 01
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            //velha.

            /*
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome e idade da primeira pessoa: ");
            string[] dadosPessoa1 = Console.ReadLine().Split(' ');
            pessoa1.Nome = dadosPessoa1[0];
            pessoa1.Idade = int.Parse(dadosPessoa1[1]);

            Console.WriteLine("Informe o nome e idade da segunda pessoa: ");
            string[] dadosPessoa2 = Console.ReadLine().Split(' ');
            pessoa2.Nome = dadosPessoa2[0];
            pessoa2.Idade = int.Parse(dadosPessoa2[1]);

            if(pessoa1.Idade > pessoa2.Idade) 
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }
            */
            #endregion

            #region Ex - 02
            //Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
            //médio dos funcionários.

            /*
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Informe o nome do primeiro funcionario: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Salario do primeiro funcionario: ");
            f1.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome do segundo funcionario: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Salario do segundo funcionario: ");
            f2.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal salarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            // Exercícios de fixação Classes

            #region Ex - 01
            //Fazer um programa para ler os valores da largura e altura
            //de um retângulo.Em seguida, mostrar na tela o valor de
            //sua área, perímetro e diagonal.Usar uma classe como
            //mostrado no projeto ao lado.

            /*
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Informe a largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Ex - 02
            //Fazer um programa para ler os dados de um colaborador (nome, salário bruto e imposto). Em
            //seguida, mostrar os dados do colaborador(nome e salário líquido).Em seguida, aumentar o
            //salário do colaborador com base em uma porcentagem dada(somente o salário bruto é
            //afetado pela porcentagem) e mostrar novamente os dados do colaborador.Use a classe
            //projetada abaixo.

            /*
            Colaborador colaborador = new Colaborador();

            Console.WriteLine("Informe o nome do colaborador: ");
            colaborador.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            colaborador.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            colaborador.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + colaborador);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            colaborador.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + colaborador);
            */
            #endregion

            #region Ex - 03

            #endregion
        }
    }
}