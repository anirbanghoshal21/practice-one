using System;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=10;
            Int32 j=20;
            float pi = 3.14f;
            int k = i + j;
            Console.WriteLine(k);
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter i for division");
            i =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter j for division");
            j =Convert.ToInt32(Console.ReadLine());
            k= i / j;
            Console.WriteLine("The division of i and j" + k);
            Console.WriteLine("The division of {0} and {1}= {2}" ,i,j,k);

            Console.WriteLine("Hello");
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

        }
    }
}
