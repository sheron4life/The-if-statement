using System;

namespace The_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sheriff`s big giveaway");
            Console.Write("Choose a Door: 1, 2 or 3?");
            string value = Console.ReadLine();
           
          


            if (value=="1")
            
                Console.WriteLine("You won a house");
            
            else if (value == "2")
            
                Console.WriteLine("You won a car");
            
            else if (value == "3")
            
                Console.WriteLine("You won a Bike");
            
            else
            
                Console.WriteLine("You won nothing please try again later");
            




        }
    }
}
