using System;

namespace studies
{
    internal class BroCode
    {
        static void Main()
        {
            int op;
            do
            {
                string? operation = "";
                op=0;
                while (operation == "")
                {
                    Console.WriteLine("Calculadora\n-----------");
                    Console.WriteLine("1-Soma");
                    Console.WriteLine("2-Subtração");
                    Console.WriteLine("3-Multiplicação");
                    Console.WriteLine("4-Divisão");
                    Console.WriteLine("5-Raiz Quadrada");
                    Console.WriteLine("6-Exponencial");
                    Console.WriteLine("7-Sair\n");
                    Console.Write("Operação 1-7: ");
                    operation = Console.ReadLine();
                    if (!int.TryParse(operation, out op) || op>7 || op<1)
                    {
                        Console.WriteLine(operation + " não é uma opção válida!\n");
                        operation = "";
                    }
                }
                double result = 0;
                switch (op)
                {
                    case 1:
                        result = Sum();
                        Console.WriteLine("="+ result);
                        break;
                    case 2:
                        result = Sub();
                        Console.WriteLine("=" + result);
                        break;
                    case 3:
                        result = Mult();
                        Console.WriteLine("="+ result);
                        break;
                    case 4:
                        result = Div();
                        Console.WriteLine("="+ result);
                        break;
                    case 5:
                        result = Sqrt();
                        Console.WriteLine("="+ result);
                        break;
                    case 6:
                        result = Exp();
                        Console.WriteLine("="+ result);
                        break;
                    case 7:
                        break;
                }
                Console.WriteLine();
            }while (op!=7);
        }

        static double Sum()
        {
            Console.WriteLine("a+b");
            double a=Verf('a');
            double b=Verf('b');
            Console.Write(a+"+"+b);
            return a + b;
        }
        static double Sub()
        {
            Console.WriteLine("a-b");
            double a = Verf('a');
            double b = Verf('b');
            Console.Write(a + "-" + b);
            return a - b;
        }
        static double Mult()
        {
            Console.WriteLine("a*b");
            double a = Verf('a');
            double b = Verf('b');
            Console.Write(a + "*" + b);
            return a * b;
        }
        static double Div()
        {
            Console.WriteLine("a/b");
            double a = Verf('a');
            double b = Verf('b');
            if(b == 0)
            {
                Console.WriteLine("Divisão por 0 é impossível.");
                return 0;
            }
            Console.Write(a + "/" + b);
            return a / b;
        }
        static double Sqrt()
        {
            Console.WriteLine("Raiz Quadrada de a");
            double a = Verf('a');
            Console.Write("Raiz Quadrada de "+a);
            return Math.Sqrt(a);
        }
        static double Exp()
        {
            Console.WriteLine("a^b");
            double a = Verf('a');
            double b = Verf('b');
            Console.Write(a + "^" + b);
            return Math.Pow(a,b);
        }

        static double Verf(char c)
        {
            double a = 0;
            string? value = "";
            do
            {
                Console.Write(c+": ");
                value = Console.ReadLine();
                double.TryParse(value, out a);
            } while (a == 0 && value != "0");
            return a;
        }
    }
}