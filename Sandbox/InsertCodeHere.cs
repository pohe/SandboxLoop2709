using System;
using System.Security.AccessControl;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //While loop



            //if (i <= 20)
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 10;  //initialisering
            //while (i <= 20) //condition  - while kører så længe condition er true
            //{
            //    if ( i%5 == 0)
            //        Console.WriteLine(i);
            //    else
            //    {
            //        Console.Write(i +" ");
            //    }

            //    i = i + 1; //i++ eller i+=1  //optælling så betingelsen på et tidspunkt bliver false
            //}

            //Console.WriteLine("For loop");
            ////for(intialisering; condition; optælling)
            //for (int j = 10; j <= 20; j++)
            //{
            //    Console.Write(j + " ");
            //}
            ////Console.WriteLine();

            //for (int i = 1; i <100; i++)
            //{
            //    if (i%10==0)
            //        Console.WriteLine();
            //    Console.Write(" *");
            //}


            //for (int j = 1; j <= 10; j++)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        if (i*j <10)
            //            Console.Write("   " + i * j);
            //        else if (i*j<100)
            //            Console.Write("  " + i * j);
            //        else
            //            Console.Write(" " + i *j);
            //    }
            //    Console.WriteLine();
            //}

            //int j = 1;
            //while ( j <= 10)
            //{
            //    int i = 1;
            //    while ( i <= 10 )
            //    {
            //        if (i * j < 10)
            //            Console.Write("   " + i * j);
            //        else if (i * j < 100)
            //            Console.Write("  " + i * j);
            //        else
            //            Console.Write(" " + i * j);
            //        i++;
            //    }
            //    Console.WriteLine();
            //    j++;
            //}

            //int c1 = 1;
            //while ( c1 <21 )
            //{
            //    //udskriv
            //    Console.WriteLine(c1);
            //    //ændre på variablen/condition
            //    c1 = c1 + 1;
            //}

            //int c1 = 20;
            //while (c1 > 0)
            //{
            //    //udskriv
            //    Console.WriteLine(c1);
            //    //ændre på variablen/condition
            //    c1 = c1 - 1;
            //}

            //for(int c1 = 20; c1 > 0; c1--)
            //{
            //    Console.WriteLine(c1);
            //}

            //for (int i = 0; i < 10; i++ )
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j<i)
            //            Console.Write(" ");
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            const int Height = 10;
            const int Width = 10;
            int iteration = 0;

            while (iteration < Height + 1)
            {
                for (int spaces = iteration; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int w = (Width - iteration); w > 0; w--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                iteration++;
            }




            //Console.WriteLine("\n\t\\Hello world!\\");

            // The LAST line of code should be ABOVE this line
        }
    }
}