namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 127;    //-128 to 127
            byte n1 = 255;    //only positive

            int n2 = 2147483647;
            long n3 = 2147483648L;    //use L at the and to assign a 'long'

            bool complet = false;
            char genre = 'F';         //Char is always on single quotes '' 
            char letter = '\u0041';   //Unicode for 'A'

            float n4 = 4.5f;     //use 'f' at the and to assign a 'float'
            double n5 = 4.5;

            string name = "Lucas";    //string always between double quotes ""   --- Strings são imutáveis

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(complet);
            Console.WriteLine(genre);
            Console.WriteLine(letter);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(name);

            int max = int.MaxValue;
            int min = int.MinValue;

            decimal maximo = decimal.MaxValue;
            decimal minimo = decimal.MinValue;

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(maximo);
            Console.WriteLine(minimo);
        }
    }
}
