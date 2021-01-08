using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* For loop */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j <= 10; j = j + 2)
            {
                Console.WriteLine(j);
            }

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            /* Break and continue in For loop */
            for (int i=0; i < 10; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i=0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            /* Break and contionue in While loop*/
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
                if (k == 4)
                {
                    break;
                }
            }

            int l = 0;
            while (l < 10)
            {
                if (l == 4)
                {
                    l++;
                    continue;
                }
                Console.WriteLine(l);
                l++;
            }
        }

    }
}
