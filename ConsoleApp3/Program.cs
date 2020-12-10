using System;
using System.Globalization;
using System.Collections.Generic;

namespace Projeto
{  
    class Program
    { 
        public static bool Continuar { get; set; }

        public static void Main(String[] args)
        {
            LigarCalculadora();
        }

        public static void LigarCalculadora() 
        {
            Continuar = true;
            Calculadora calc;
            calc = new Calculadora();

            while(Continuar)
            {
                MenuDeOpcoes(calc);
            }
        }
        public static void MenuDeOpcoes(Calculadora calc)
        {
            Console.WriteLine(" _______________________");
            Console.WriteLine("| Calculadora do Pedrin |");
            Console.WriteLine("|Somar [1]              |");
            Console.WriteLine("|Subtrair [2]           |");
            Console.WriteLine("|Multiplicar [3]        |");
            Console.WriteLine("|Dividir [4]            |");
            Console.WriteLine("|Sair [5]               |");
            Console.WriteLine("|_______________________|");
            Console.WriteLine("Digite sua opção:      ");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Somar(calc);
                    break;
                case 2:
                    Subtrair(calc);
                    break;
                case 3:
                    Multiplicar(calc);
                    break;
                case 4:
                    Dividir(calc);
                    break;
                case 5:
                    Continuar = false;
                    Console.WriteLine("Obrigado por usar a melhor calculadora do Brasil!");
                    Console.ReadLine();
                    break;
            }
            
                    
        }

        public static void Somar(Calculadora calc) 
        {
            List<double> numerosSoma  = new List<double>{};

            Console.WriteLine("Quantos números serão somados? ");

            int qtd = int.Parse(Console.ReadLine());
            PopularLista(qtd, ref numerosSoma);

            Console.WriteLine("Resultado da soma: "+ calc.Soma(numerosSoma));
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
        }

        public static void Subtrair(Calculadora calc) 
        {
            List<double> numerosSubtracao  = new List<double>{};

            Console.WriteLine("Quantos números serão subtraidos? ");
            int qtd = int.Parse(Console.ReadLine());

            PopularLista(qtd, ref numerosSubtracao);

            Console.WriteLine("Resultado da subtração: "+ calc.Subtrai(numerosSubtracao));
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
        }

        public static void Multiplicar(Calculadora calc) 
        {
            List<double> numerosMultiplicacao  = new List<double>{};

            Console.WriteLine("Quantos números serão multiplicados? ");

            int qtd = int.Parse(Console.ReadLine());
            PopularLista(qtd, ref numerosMultiplicacao);

            Console.WriteLine("Resultado da multiplicação: "+ calc.Multiplica(numerosMultiplicacao));
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
        }

        public static void Dividir(Calculadora calc) 
        {
            List<double> numerosDivisao  = new List<double>{};

            Console.WriteLine("Quantos números serão divididos? ");

            int qtd = int.Parse(Console.ReadLine());
            PopularLista(qtd, ref numerosDivisao);

            Console.WriteLine("Resultado da multiplicação: "+ calc.Divide(numerosDivisao));
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            
        }

        public static void PopularLista(int qtd, ref List<double> list) 
        {
            for(int i = 0; i < qtd; i ++) 
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                list.Add(double.Parse(Console.ReadLine()));
            }
        }
    }

}



