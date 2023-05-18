using System.Globalization;

namespace Exercise5
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            string opcao = "";
            int alcool, gasolina, diesel;
            alcool = gasolina = diesel = 0;

            while (opcao != "4")
            {
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1. Álcool\n2. Gasolina\n3.Diesel\n4. Fim");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    alcool += 1;
                }
                else if (opcao == "2")
                {
                    gasolina += 1;
                }
                else if (opcao == "3")
                {
                    diesel += 1;
                }
            }
            Console.WriteLine($"MUITO OBRIGADO\nÁlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}\n");
        }
    }
}