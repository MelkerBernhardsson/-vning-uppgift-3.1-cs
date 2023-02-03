using System;

namespace uppgift31
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hur gammal är du??");
            int age = int.Parse(Console.ReadLine());

            if(age >= 50)
            {
                Console.WriteLine("du får vara med i tävlingen");    
            }
            else
            {
                Console.WriteLine("du är inte tillräcligt gammal för tävlingen");
            }
        }
    }
}