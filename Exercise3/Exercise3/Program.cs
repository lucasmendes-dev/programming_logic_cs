using System.Globalization;

namespace Exercise3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            //calcular raio de um círculo
            double pi = 3.14159;

            Console.WriteLine("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (Math.Pow(raio, 2));
            Console.WriteLine("A área é: " + area.ToString("F4", CultureInfo.InvariantCulture));

            //calcular e mostrar valores

            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor recebido por hora: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {nome}");
            Console.WriteLine($"Salário: R${(horas * valor):F2}");

        }
    }
}