using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace oopSection1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PART 1 : 

            // 1) Create a string variable and get user input from the keyboard and store it in the variable :
            /* string X = Console.ReadLine();
            Console.WriteLine(X); */

            // 2) Write a C# program to check whether an alphabet is a vowel or consonant using switch case :
            /* char X = char.Parse(Console.ReadLine());
            switch (X)
            {
                case 'a':
                case 'e':
                case 'u':
                case 'o':
                case 'i':
                    Console.WriteLine("Its Vowel.");
                       break;
                default:
                    Console.WriteLine("Its Consonant.");
                       break;
            } */

            // 3) Write a C# program to check whether a triangle is valid or not if angles are given using if , else :
            /* double x, y, z;
            Console.Write("1st angel : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("2nd angel : ");
            y = double.Parse(Console.ReadLine());
            Console.Write("3rd angel : ");
            z = double.Parse(Console.ReadLine());
            if ( x + y + z == 180 )
            {
                Console.WriteLine("Its Triangle y m3lm");
            }
            else 
            {
                Console.WriteLine("Its not a Triangle y m3lm");
            } */

            // 4) Write a C# Sharp program to swap two numbers :
            /* Console.Write("num1 = "); 
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2 = ");
            int num2 = int.Parse(Console.ReadLine());
            int num3 = 0;
            num1 = num3;
            num1 = num2;
            num3 = num2;
            Console.WriteLine("=====================");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2); */

            // 5) Write a C# Sharp program to find the length of a string with using a library function : ==>1
            /* string word = Console.ReadLine();
            Console.WriteLine(word.Length); */

            // 5) Write a C# Sharp program to find the length of a string without using a library function : ==>2
            /* string word = Console.ReadLine();
            int i = 0;
            foreach (char c in word)
            {
                i++;
            }
            Console.WriteLine(i); */

            // 6) Write a C# Sharp program that displays the sum of n natural numbers :
            /* int n = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("=====================");
            for (int i = 0; i < n; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("=====================");
            Console.WriteLine("The Summation is " + sum); */

            //PART 2 :

            // 1) Write a C# Sharp program that stores elements in an array and prints them :
            /* int[] arr;
             int n = int.Parse(Console.ReadLine());
             arr = new int[n]; 
             Console.WriteLine("=====================");
             for (int i = 0 ; i < n ; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("=====================");
             foreach ( int i in arr ) 
             {
                 Console.Write(i + " ");
             }
             Console.WriteLine(); */

            // 2)  Write a program in C# Sharp to find the sum of all array elements : 
            /* int[] arr;
          int n = int.Parse(Console.ReadLine());
          arr = new int[n];
          Console.WriteLine("=====================");
          for (int i = 0; i < n; i++)
          {
              arr[i] = int.Parse(Console.ReadLine());
          }
          Console.WriteLine("=====================");
          int sum = 0;
          foreach (int i in arr) 
          {
          sum += i;
          }
          Console.WriteLine("The Summation of ur Elements is : " + sum); */

            // 3) Write a C# Sharp program to find the maximum and minimum elements in an array : ==> 1
            /* int[] arr;
             int n = int.Parse(Console.ReadLine());
             arr = new int[n];
             Console.WriteLine("=====================");
             for (int i = 0; i < n; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("=====================");
             Console.WriteLine("The Maximum Element is : " + arr.Max());
             Console.WriteLine("The Minimum Element is : " + arr.Min()); */

            // 3) Write a C# Sharp program to find the maximum and minimum elements in an array : ==> 2
            /*  int[] arr;
             int n = int.Parse(Console.ReadLine());
             arr = new int[n];
             Console.WriteLine("=====================");
             for (int i = 0; i < n; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("=====================");
             int max = 0;
             max = arr[0];
             int j;
             for (j = 0; j < n; j++)
             {
                 if (arr[j] > max)
                 {
                     max = arr[j];
                 }
             }
             Console.WriteLine("The Maximum Element is : " + max) ;
             int min = 0 ;
             min = arr[0];
             int k;
             for (k = 0; k < n; k++)
             {
                 if (arr[k] < min) 
                 {
                     min = arr[k];
                 }
             }
             Console.WriteLine("The Minimum Element is : " + min) ; */

            // 4) Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix : ==>1
            /* int[,] arr = new int[3, 3];
           for (int i = 0;i < 3;i++)
           {
               for (int j = 0;j < 3;j++)
               {
                   arr[i, j] = int.Parse(Console.ReadLine());
               }
           }
           Console.WriteLine("=====================");
           for (int i = 0; i < 3;i++) 
           {
               for(int j = 0; j < 3;j++) 
               {
                   Console.Write(arr[i, j] + " ");
               }
               Console.WriteLine();
           } */

            // 4) Write a program in C# Sharp for a 2D array of size NxN and print the matrix : ==>2 (Extra)
            /* int[,] Matrix ;
            int n = int.Parse(Console.ReadLine());
            Matrix = new int[n, n];
            Console.WriteLine("=====================");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("=====================");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine(); 
            } */

            // 5) Write a program in C# to separate odd and even integers into separate arrays :
            /* int[] arr;
            int[] evenARR;
            int[] oddARR;
            int i;
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            evenARR = new int[n];
            oddARR = new int[n];
            Console.WriteLine("=====================");
            for ( i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int j = 0 , k = 0;
            for (i = 0; i < n; i++) 
            {
                if (arr[i] % 2 == 0)
                {
                    evenARR[j] = arr[i];
                    j++;
                }
                else
                {
                    oddARR[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("=====================");
            Console.Write("Even : ");
            for (i = 0; i < j; i++)
            {
                Console.Write(evenARR[i] + "  ");
            }
            Console.WriteLine();
            Console.Write("ODD : ");
            for (i = 0; i < k; i++)
            {
                Console.Write( oddARR[i] + "  ");
            }
            Console.WriteLine(); */

            // 6)  Write a C# program to delete an element at the desired position from an array :
            /* int[] arr;
            int i;
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            Console.WriteLine("=====================");
            for ( i = 0; i < n; i++)
            {
                Console.Write("What is Ur " +(i+1)+ " Element?  " , i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("=====================");
            foreach (int elemnt in arr) // array before deleting any element.
            {
                Console.Write(elemnt + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.Write("3ayez tms7 anhy Index? : ");
            int deletedIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================");
            for (i = 0 ; i < n ; i++) 
            {
                if ( i == deletedIndex)
                {
                    continue;
                }
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine(); */
        }
    }
}

