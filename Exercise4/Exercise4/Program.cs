
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Par ou impar 
            Console.WriteLine("Entre com um número inteiro"); 
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("Par");
            } else
            {
                Console.WriteLine("Impar");
            }

            // ------------------------------------------- // ------------------------------------------- //
            //multiplos ou não multiplos 
            Console.WriteLine("Digite o 1º numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º numero: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0 || num2 % num1 == 0) 
            {
                Console.WriteLine("São múltiplos!");
            } else 
            {
                Console.WriteLine("Não são múltiplos!");
            }

            // ------------------------------------------- // ------------------------------------------- //
            //inicio e fim
            Console.WriteLine("Digite o 1º horário: ");
            int hora1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º horário: ");
            int hora2 = int.Parse(Console.ReadLine());
            int result;

            if (hora1 == 0 && hora2 == 0)
            {
                result = 24;
            }
            else if(hora1 < 23 && hora1 > hora2)
            {
                result = (24 - hora1) + hora2;
            }
            else
            {
                result = hora2 - hora1;
            }

            Console.WriteLine($"O jogo durou: {result} horas"); 

            // ------------------------------------------- // ------------------------------------------- //
            //qual plano se encontra 
            Console.WriteLine("Digite o valor de x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y: ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } else
            {
                Console.WriteLine("Q2");
            }


        }
    }
}

