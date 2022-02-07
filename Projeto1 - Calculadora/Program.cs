using System;

namespace Projeto1___Calculadora
{
    internal class Program
    {

        public enum calc { multiplicacao = 3, divisao = 4, soma = 1, subtracao = 2, raiz = 5, potencia = 6, sair = 7 };
        static void Main(string[] args)
        {


            bool EscolheuSair = !false;
            while (EscolheuSair)
            {
                Console.WriteLine("Bem-vindo(a)! Escolha a opção desejada:");
                Console.WriteLine("1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Raiz\n6.Potência\n7.Sair ");

                calc menu = (calc)int.Parse(Console.ReadLine());

                Console.ReadLine();

                switch (menu)
                { 
                    case calc.soma:
                        Soma();
                        break;
                    case calc.multiplicacao:
                        Mult();
                        break;
                    case calc.subtracao:
                        Sub();
                        break;
                    case calc.divisao:
                        Div();
                        break;
                    case calc.raiz:
                        Raiz();
                        break;
                    case calc.potencia:
                        Exp();
                        break;
                    case calc.sair:
                        EscolheuSair=true;
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida e tente novamente!");
                        break;
                }

                Console.Clear();

            }

            static void Soma()
            {
                Console.WriteLine("Adição:\nPor favor digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite outro número: ");
                int n2 = int.Parse(Console.ReadLine());
                int res = n1 + n2;
                Console.WriteLine($"O resultado é: {res}\n\nPara voltar ao menu principal DIGITE enter!");
                Console.ReadLine();

            }
            
            static void Sub()
            {
                Console.WriteLine("Subtração:\nPor favor digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite outro número: ");
                int n2 = int.Parse(Console.ReadLine());
                int res = n1 - n2;
                Console.WriteLine($"O resultado é {res}\n\nPara voltar ao menu principal DIGITE enter!");
                Console.ReadLine();
            }

            static void Mult()
            {
                Console.WriteLine("Multiplicação:\nPor favor digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite outro número: ");
                int n2 = int.Parse(Console.ReadLine());
                int res = n1 * n2;
                Console.WriteLine($"O resultado é: {res}\n\nPara voltar ao menu principal DIGITE enter!");
                Console.ReadLine();
            }
            
            static void Div()
            {
                Console.WriteLine("Dvisão:\nPor favor digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite outro número: ");
                int n2 = int.Parse(Console.ReadLine());
                float res = (float)n1 / (float)n2;
                Console.WriteLine($"O resultado é: {res}\n\nPara voltar ao menu principal DIGITE enter!");
                Console.ReadLine();
            }
            
            static void Exp()
            {
                Console.WriteLine("Exponenciação:\nPor favor digite o número base: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite o expoente: ");
                int n2 = int.Parse(Console.ReadLine());
                int res = (int)Math.Pow(n1,n2);
                Console.WriteLine($"O resultado é: {res}\n\nPara voltar ao menu principal DIGITE enter!");
                Console.ReadLine();
            }
            
            static void Raiz()
            {
                Console.WriteLine("Raiz Quadrada:\nPor favor digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                double res = Math.Sqrt(n1);
                Console.WriteLine($"O resultado é: {res}\n\nPara voltar ao menu principal DIGITE enter!");
                Console.ReadLine();
            }

        }


    }
}
