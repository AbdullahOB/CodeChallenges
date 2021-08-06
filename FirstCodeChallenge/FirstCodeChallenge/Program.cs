using System;
using System.Linq;

namespace CodeChallenges
{
    class Program
    {
        public static void NumbersAscending() //Prints Numbers from 1-100 in Ascending Order
        {
            Console.WriteLine("================================== Ascending ==================================\n");
            int i;
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void NumbersDescending() //Prints Numbers from 1-100 in Descending Order
        {
            int i;
            Console.WriteLine("================================== Descending ==================================\n");
            for (i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }



        public static int SumMainMethod(int n) //Method To Sum All numbers Between 1-n, (Takes n as parameter)
        {
            

            Console.WriteLine("\n================================== Printing Numbers From 1 to n ==================================\n");
            Console.WriteLine("n is " + n + "\n");
            int i, sum = 0;
            for(i=0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int Sum_A(int n) //Method To Sum All numbers Between 1-n, (Takes n as parameter) , (using While loop)
        {


            Console.WriteLine("\n================================== Printing Numbers From 1 to n (Using While Loop)==================================\n");
            Console.WriteLine("n is " + n + "\n");
            int i=0, sum = 0;
            while (n>=i)
            {
                sum += i;
                i++;
            }
            return sum;
        }
        

        public static int Sum_B(int n) //Method To Sum All numbers Between 1-n, (Takes n as parameter) , (using LINQ)
        {
            Console.WriteLine("\n================================== Printing Numbers From 1 to n (Using LINQ)==================================\n");
            Console.WriteLine("n is " + n + "\n");
            var sum = Enumerable.Range(1, n).Sum();
            return sum;
        }


        public static int Sum_C(int n) //Method To Sum All numbers Between 1-n, (Takes n as parameter) , (using O(1))
        {
            Console.WriteLine("\n================================== Printing Numbers From 1 to n (Using O(1))==================================\n");
            Console.WriteLine("n is " + n + "\n");
            return (n * (n + 1)) / 2;
        }




        static void Main(string[] args) //Main Method
        {
            NumbersAscending(); //Method Call
            NumbersDescending(); //Method Call
            Console.WriteLine("The sum of numbers from 1 to n is : "+ SumMainMethod(25)); //Method Call and print
            Console.WriteLine("The sum of numbers from 1 to n is : "+ Sum_A(25)); //Method Call and print (While Loop)
            Console.WriteLine("The sum of numbers from 1 to n is : "+ Sum_B(25)); //Method Call and print (LINQ Method)
            Console.WriteLine("The sum of numbers from 1 to n is : "+ Sum_C(25)); //Method Call and print (O(1) Method)
        }
    }
}
