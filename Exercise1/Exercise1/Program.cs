using System.Globalization;

namespace Exercise1
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador"; 
            string produto2 = "Mesa de Escritório"; 

            byte idade = 30; 
            int codigo = 5290; 
            char genero = 'M'; 

            double preco1 = 2100.0; 
            double preco2 = 650.50; 
            double medida = 53.234567; 
            
            Console.WriteLine("Produtos: "); 
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}"); 
            Console.WriteLine($"{produto2}, cujo preço é R${preco2:F2}"); 
            Console.WriteLine($"Registro: {idade} anos d idade, código {codigo} e gênero: {genero}"); 
            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}"); Console.WriteLine($"Arredondado (3 casas decimais): {medida:F3}"); 
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("", CultureInfo.InvariantCulture)}");

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2) - 4.0 * a * c;

            double result = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(result);


        }
    }
} 