using System;

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

            int j = 1;
            while ( j <= 10)
            {
                int i = 1;
                while ( i <= 10 )
                {
                    if (i * j < 10)
                        Console.Write("   " + i * j);
                    else if (i * j < 100)
                        Console.Write("  " + i * j);
                    else
                        Console.Write(" " + i * j);
                    i++;
                }
                Console.WriteLine();
                j++;
            }




            //Console.WriteLine("\n\t\\Hello world!\\");

            // The LAST line of code should be ABOVE this line
        }
    }
}