namespace Calculator
{
    internal class Program
    {
        enum Operadores
        {
            Soma = 1,
            Subtração = 2,
            Divisão = 3,
            Multiplicacao = 4,
            Potencia = 5,
        }

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("0 - Desligar");
            Console.WriteLine("-------------------");

            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch ((Operadores) res)
            {
                case Operadores.Soma:
                    Soma();
                break;

                case Operadores.Subtração:
                    Subtracao();
                break;

                case Operadores.Divisão:
                    Divisao();
                break;

                case Operadores.Multiplicacao:
                    Multiplicacao();
                break;

                case Operadores.Potencia:
                    Potencia();
                break;

                case 0:
                    System.Environment.Exit(0);
                break;

                default: Menu(); break;
            }
        }

        static float SolicitacaoPadrao(string numeralValor)
        {
            Console.WriteLine($"{numeralValor} valor: ");
            return float.Parse(Console.ReadLine());
        }

        static void Potencia()
        {
            Console.Clear();

            float valor1 = SolicitacaoPadrao("Primeiro");
            float valor2 = SolicitacaoPadrao("Segundo");

            Console.WriteLine("");

            float resultado = valor1;

            for (short i = 1; i<valor2; i++)
            {
                resultado *= valor1;
            }

            Console.WriteLine($"O resultado da potência é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Soma()
        {
            Console.Clear();

            float valor1 = SolicitacaoPadrao("Primeiro");
            float valor2 = SolicitacaoPadrao("Segundo");

            Console.WriteLine("");

            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            float valor1 = SolicitacaoPadrao("Primeiro");
            float valor2 = SolicitacaoPadrao("Segundo");

            Console.WriteLine("");

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            float valor1 = SolicitacaoPadrao("Primeiro");
            float valor2 = SolicitacaoPadrao("Segundo");

            Console.WriteLine("");

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            float valor1 = SolicitacaoPadrao("Primeiro");
            float valor2 = SolicitacaoPadrao("Segundo");

            Console.WriteLine("");

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();

            Menu();
        }
    }
}