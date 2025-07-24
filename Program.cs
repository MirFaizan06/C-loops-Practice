using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop2
{
    internal class Program  
    {
        static void Main(string[] args)
        {

             
            //// edit from shayan 
            /// edit was done by faizan

            Console.WriteLine("----7 Loop Based Programs----\n");

            Console.WriteLine("Instructions (please read them carefully): ");
            Console.WriteLine("1. Choose a program you want to run among the list below.");
            Console.WriteLine("2. Enter the required data asked from that specific program.");
            Console.WriteLine("3. Check your output and see if you get the desired output.");
            Console.WriteLine("4. In case you don't get a desired output, enter your issue at the end of the program.");

            Console.WriteLine();

            Console.WriteLine("List of available programs: ");
            Console.WriteLine("1. Range of even/odd.");
            Console.WriteLine("2. Single number prime/composite check.");
            Console.WriteLine("3. Range of prime/composite.");
            Console.WriteLine("4. Fibonacci series.");
            Console.WriteLine("5. Multiplication table for a given number.");
            Console.WriteLine("6. Summation of 'n' terms.");
            Console.WriteLine("7. Factorial of a given number 'n'.");

            Console.WriteLine();

            Console.Write("Enter your choice for the program to be executed (1-7): ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                Console.WriteLine("---Executing 'Range of odd/even' program---\n");

                Console.Write("Enter the minimum value: ");
                int min = int.Parse(Console.ReadLine());

                Console.Write("Enter the maximum value: ");
                int max = int.Parse(Console.ReadLine());

                while (min <= max)
                {
                    if (min % 2 == 0)
                    {
                        Console.WriteLine($"{min} is even!");
                    }
                    else
                    {
                        Console.WriteLine($"{min} is odd!");
                    }
                    min++;
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("---Executing 'Single number prime/composite check' program---\n");

                Console.Write("Enter the number to check if it is prime or not: ");
                int num = int.Parse(Console.ReadLine());
                bool flag = true;              //true means prime.

                int i = 2;
                while (i < num)
                {
                    if (num % i == 0)
                    {
                        flag = false;
                    }
                    i++;
                }

                if (flag == false)
                {
                    Console.WriteLine($"{num} is composite!");
                }
                else
                {
                    Console.WriteLine($"{num} is prime!");
                }
            }

            else if (choice == 3)
            {
                Console.WriteLine("---Executing 'Range of prime/composite' program---\n");

                Console.Write("Enter the minimum value: ");
                int min = int.Parse(Console.ReadLine());

                Console.Write("Enter the maximum value: ");
                int max = int.Parse(Console.ReadLine());

                bool flag = true;           //true means prime.


                while (min <= max)
                {
                    int j = 2;
                    while (j < min)
                    {
                        if (min % j == 0)
                        {
                            flag = false;
                        }
                        j++;
                    }

                    if (flag == true)
                    {
                        Console.WriteLine($"{min} is prime!");
                    }
                    else
                    {
                        Console.WriteLine($"{min} is composite!");
                        flag = true;
                    }
                    min++;
                }
            }

            else if (choice == 4)
            {
                Console.WriteLine("---Executing 'Fibonacci series' program---\n");

                Console.Write("Enter a limit for fibonacci series: ");
                int limit = int.Parse(Console.ReadLine());

                int t1 = 0;
                int t2 = 1;
                int t3 = t1 + t2;

                int idx = 1;

                Console.WriteLine("Generating fibonacci series: ");
                Console.WriteLine($"{idx}: {t1}");
                Console.WriteLine($"{idx + 1}: {t2}");
                Console.WriteLine($"{idx + 2}: {t3}");

                idx = 4;

                int i = 4;
                while (i <= limit)
                {
                    t1 = t2;
                    t2 = t3;
                    t3 = t1 + t2;
                    Console.WriteLine($"{idx}: {t3}");
                    idx++;
                    i++;
                }
            }

            else if (choice == 5)
            {
                Console.WriteLine("---Executing 'Multiplication table' program---\n");

                Console.Write("Enter a number to generate it's table: ");
                int number = int.Parse(Console.ReadLine());
                int product;

                int i = 1;
                while (i <= 10)
                {
                    product = number * i;
                    Console.WriteLine($"{number} x {i} = {product}");
                    i++;
                }
            }

            else if (choice == 6)
            {
                Console.WriteLine("---Executing 'Summation of \"n\" terms' program---\n");

                Console.Write("Perform summation by entering numbers yourself or not?(y/n): ");
                string reply = Console.ReadLine().ToLower();

                if (reply == "y")
                {
                    int sum = 0;
                    Console.Write("Enter the number of elements you want to summate: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] numArray = new int[size];

                    int i = 0;

                    while(i < numArray.Length)
                    {
                        Console.Write($"Enter element {i}: ");
                        numArray[i] = int.Parse(Console.ReadLine());
                        i++;
                    }
                    Console.WriteLine($"Performing summation of {size} elements that you entered: ");

                    int j = 0;

                    while(j < numArray.Length)
                    {
                        sum += numArray[j];
                        j++;
                    }
                    Console.WriteLine($"\nThe sum of {size} numbers that you entered is: {sum}");
                }

                else if(reply == "n")
                {
                    int sum = 0;
                    int count = 0;
                    Console.Write("Enter a maximum number for summation limit: ");
                    int max = int.Parse(Console.ReadLine());

                    int i = 1;

                    while(i <= max)
                    {
                        sum += i;
                        count++;
                        i++;
                    }
                    Console.WriteLine($"The summation of {count} numbers from 1 to {max} is: {sum}");
                }

                else
                {
                    Console.WriteLine($"{reply} is an invalid choice.");
                }
            }

            else if(choice == 7)
            {
                Console.WriteLine("---Executing 'factorial of number n' program---\n");

                Console.Write("Enter a number to find it's factorial: ");
                int num = int.Parse(Console.ReadLine());
                int fact = 1;

                int i = 1;

                while(i <= num)
                {
                    fact *= i;
                    i++;
                }
                Console.WriteLine($"The factorial of {num} is: {fact}");
            }

            else
            {
                Console.WriteLine($"{choice} is an invalid choice!");
            }
        }
    }
}
