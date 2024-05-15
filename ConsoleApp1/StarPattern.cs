using System;


namespace ConsoleApp1
{
    class StarPattern
    {
        static void Main(string[] args)
        {
            
            int row, col, num;
            Console.WriteLine("Enter number: ");
                num = Convert.ToInt32(Console.ReadLine()); //5

            for(row=1; row<=num; row++) //1,2,3
            {
                for(col=1; col<=row; col++) //1,2,3,4
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
