using System;
   
namespace Pyramido
    
{
    class Triagle
    {
        
        static void Main()
        {
            int n;
            Console.WriteLine("Enter Any Number of pyramid you want to make:");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                for(int j = 0; j<n-i-1; j++)
                {
                    Console.Write("-");


                    for (int k = 0; k < 2 * i; k++)
                    {
                        Console.Write("*");
                        Console.WriteLine();

                    }
            }
            Console.ReadLine();





        }

    }
}