using System;
using System.Diagnostics;
using System.Globalization;

int row, col, num;
//Console.WriteLine("Enter number: ");
//num = Convert.ToInt32(Console.ReadLine()); //5

//for (row = 1; row <= num; row++) //1,2,3
//{
//    for (col = 1; col <= row; col++) //1,2,3,4
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();


//Console.WriteLine("enter number: ");
//num = Convert.ToInt32(Console.ReadLine()); //5
//for (row = 1; row <= num; row++) //1,2,3
//{
//for (col = row; col <= num; col++) //1,2,3,4
//{
//        Console.Write("* ");
//}
//    Console.WriteLine();
//}
//Console.ReadLine();

//Console.WriteLine("Enter number: ");
//num = Convert.ToInt32(Console.ReadLine()); //5
//int count = 0;
//for (row = 1; row <= num; row++) //1,2,3
//{
//for (col = 1; col <= row; col++) //1,2,3,4
//{
//count++;
//Console.Write(count);
//}
//Console.WriteLine();
//}
//Console.ReadLine();

//Console.WriteLine("Enter number: ");
//num = Convert.ToInt32(Console.ReadLine()); //5
//for (int i = 1; i <= 5; i++)
//{
//for (int j = i; j <= 4; j++)
//{
//Console.Write(" ");
//}
//for (int k = 1; k <= i; k++)
//{
//Console.Write("*");
//}
//for (int l = 2; l <= i; l++)
//{
//Console.Write("*");
//}

//Console.WriteLine();
//}
//Console.ReadLine();



//for (int i = 1; i <= 5; i++)
//{
//for (int j = 2; j <= i; j++)
//{
//Console.Write(" ");
//}
//for (int k = i; k <= 5; k++)
//{
//Console.Write("*");
//}
//for (int l = i; l <= 4; l++)
//{
//Console.Write("*");
//}
//Console.WriteLine();
//}
//Console.ReadLine();


//for (int i = 1; i <= 5; i++)
//{
//for (int j = i; j <= 4; j++)
//{
//Console.Write(" ");
//}
//for (int k = 1; k <= 2 * i - 1; k++)
//{
//Console.Write("*");
//}
//Console.WriteLine();
//}
//for (int i = 2; i <= 5; i++)
//{
//for (int j = 2; j <= i; j++)
//{
//Console.Write(" ");
//}
//for (int k = 2 * i - 1; k <= 9; k++)
//{
//Console.Write("*");
//}
//Console.WriteLine();
//}
//Console.ReadLine();

//Pyramid Pattern

int n, x, y, z;
n = 5;

//for (x = 1; x <= n; x++)
//{
//for (y = 1; y <= n - x; y++)
//{
//Console.Write(" ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write("* ");
//}

//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}

//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}

//Console.WriteLine();
//}
//Console.ReadLine();


//for (x = n; x >= 1; x--)
//{
//for (y = 1; y <= n - x; y++)
//{
//Console.Write(" ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write("* ");
//}

//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}
//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}
//Console.WriteLine();
//}
//Console.ReadLine();

////Diamond Pattern
//for (x = 1; x <= n; x++)
//{
//for (y = 1; y <= n - x; y++)
//{
//Console.Write(" ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write("* ");
//}

//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}

//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}

//Console.WriteLine();
//}

//for (x = n; x >= 1; x--)
//{
//for (y = 1; y <= n - x; y++)
//{
//Console.Write(" ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write("* ");
//}

//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}
//for (y = 1; y <= n - x; y++)
//{
//Console.Write("  ");
//}
//for (z = 1; z <= x; z++)
//{
//Console.Write(" *");
//}
//Console.WriteLine();
//}
//Console.ReadLine();

//while loop

//int n = 5; // Change this value to adjust the height of the pyramid
//int m = 6;// number of pyramids
//int i = 1;
//while (i <= n)
//{
//if (m >= 1)
//{
//int j = 1;
//while (j <= n - i)
//{
//Console.Write(" ");
//j++;
//}
//j = 1;
//while (j <= i)
//{
//Console.Write("* ");
//j++;
//}
//}

//if (m >= 2)
//{
//int k = 1;
//while (k <= n - i)
//{
//Console.Write("  ");
//k++;
//}
//int j = 1;
//while (j <= i)
//{
//Console.Write(" *");
//j++;
//}
//}


//if (m >= 3)
//{
//int k = 1;
//while (k <= n - i)
//{
//Console.Write("  ");
//k++;
//}
//int j = 1;
//while (j <= i)
//{
//Console.Write(" *");
//j++;
//}
//}
//Console.WriteLine();
//i++;
//}

//Console.ReadLine();
//i = n;
//while (i >= 1)
//{
//if (m >= 4)
//{
//int j = 1;
//while (j <= n - i)
//{
//Console.Write(" ");
//j++;
//}
//j = 1;
//while (j <= i)
//{
//Console.Write("* ");
//j++;
//}
//}

//if (m >= 5)
//{
//int k = 1;
//while (k <= n - i)
//{
//Console.Write("  ");
//k++;
//}
//int j = 1;
//while (j <= i)
//{
//Console.Write(" *");
//j++;
//}
//}


//if (m >= 6)
//{
//int k = 1;
//while (k <= n - i)
//{
//Console.Write("  ");
//k++;
//}
//int j = 1;
//while (j <= i)
//{
//Console.Write(" *");
//j++;
//}
//}
//Console.WriteLine();
//i--;
//}

// do-while loop

{
         //int n = 5;
    // Change n to the number of rows you want in the pyramid

        int i = 1;
        do
        {
            int spaces = n - i;
            int stars =  i ;

            // Print leading spaces
            int j = 0;
            while (j <= spaces)
            {
                Console.Write(" ");
                j++;
            }

            // Print stars
            j = 0;
            while (j < stars)
            if(stars == 5)
            {
                Console.Write("  ");
                j++;
            }
            else
            {
                Console.Write(" *");
                j++;
            }
        Console.Write(' ');

        // Print leading spaces
        j = 0;
        while (j < spaces)
      
            {
            Console.Write("  ");
            j++; 
        }
   
            // Print stars
            j = 0;
        while (j < stars)

        {
            if (stars == 5)
            {
                Console.Write("  ");
                j++;
            }else if (stars == 2)
            {
                Console.Write("  ");
                j++;
            }
            else
            {
                Console.Write(" *");
                j++;
            }

            //Console.Write(" *");
            //  j++;
        }
        Console.Write(' ');

        // Print leading spaces
        j = 0;
        while (j < spaces)
        {
            Console.Write("  ");
            j++;
        }

        // Print stars
        j = 0;
        while (j < stars)
            if(stars==5)
            {
                Console.Write("  ");
                j++;
            }else if (stars == 3)
            {
                Console.Write("  ");
                j++;
            }
        else
        {
            Console.Write(" *");
            j++;
        }
        // Print leading spaces
        j = 0;
        while (j < spaces)
        {
            Console.Write("  ");
            j++;
        }

        // Print stars
        j = 0;
        while (j < stars)
            if(stars == 5)
            {
                Console.Write("  ");
                j++;
            }
         
        else
            {
                Console.Write(" *");
                j++;
            }

        // Move to the next line
        Console.WriteLine();
            i++;
        } while (i <= n);
    }


{
    //int n = 5;
    // Change n to the number of rows you want in the pyramid

    int i = n-1;
    do
    {
        int spaces = n - i;
        int stars = i;

        // Print leading spaces
        int j = 0;
        while (j <= spaces)
        {
            Console.Write(" ");
            j++;
        }

        // Print stars
        j = 0;
        while (j < stars)
            if(stars ==3)
            {
                Console.Write("  ");
                j++;
            }
        else
        {
            Console.Write(" *");
            j++;
        }
        Console.Write(' ');
        // Print leading spaces
        j = 0;
        while (j < spaces)
        {
            Console.Write("  ");
            j++;
        }

        // Print stars
        j = 0;
        while (j < stars)
        {
            Console.Write(" *");
            j++;
        }
        Console.Write(' ');
        // Print leading spaces
        j = 0;
        while (j < spaces)
        {
            Console.Write("  ");
            j++;
        }

        // Print stars
        j = 0;
        while (j < stars)
        {
            if(stars== 2)
            {
                Console.Write("  ");
                j++;
            }
            else
            {
                Console.Write(" *");
                j++;
            }

        }

        // Print leading spaces
        j = 0;
        while (j < spaces)
        {
            Console.Write("  ");
            j++;
        }

        // Print stars
        j = 0;
        while (j < stars)
        {
            {
                Console.Write(" *");
                j++;
            }

        }

        // Move to the next line
        Console.WriteLine();
        i--;
    } while (i >= 1);
}


