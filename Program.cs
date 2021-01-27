using System;

namespace SelectionStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your subject choice?");
            string userSubjectChosen = Console.ReadLine();

            switch (userSubjectChosen)
            {
                case "English":
                    Console.WriteLine("You have chosen wisely!");
                    break;
                case "Math":
                    Console.WriteLine("Enjoy Algebra 1!");
                    break;
                case "Art":
                    Console.WriteLine("You are today's Michaelangelo!");
                    break;
                case "Composition":
                    Console.WriteLine("You are Langston Hughes!");
                    break;
                case "Humanities 1":
                    Console.WriteLine("You are a history buff");
                    break;
            } 

        }
    }
}
