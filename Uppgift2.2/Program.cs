using System;

namespace övning2._2
{

    class övning2_2
    {

        static void Main(string[] args)
        {

            Console.WriteLine("I en längd hopp tävling hoppade Elin längre än Alma.");
            Console.WriteLine("Hur långt hoppade Elin?(i meter)");
            string Le = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma?(i meter)");
            string La = Console.ReadLine();

            double e = double.Parse(Le);
            double a = double.Parse(La);

            double b = e - a;

            Console.WriteLine("Elin hoppade " + b + " meter längre än Alma.");

        }

    }

}