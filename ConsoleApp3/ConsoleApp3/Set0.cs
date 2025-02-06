using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Set0
    {

       //FIBO
            public static void Fibo()
            {
                int Fn = 0;
                int Sn = 1;
                int Nt;

                Console.WriteLine("ENTER A VALUE FOR n ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fn);
                Console.WriteLine(Sn);
                Fibo2(Fn, Sn, n);

            }
            public static void Fibo2(int Fn, int Sn, int n)
            {

                for (int i = 2; i < n; i++)
                {

                    int Nt = Fn + Sn;
                    Console.WriteLine(Nt);
                    Fn = Sn;
                    Sn = Nt;


                }
            }

        //Armstrong
        public static void CheckArmstrong()
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int check = num;
            int count = 0;
            double sum = 0;
            char[] arr = num.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {

                count++;
            };

            int n = count;
            while (num != 0)
            {
                int rem = num % 10;
                sum += Math.Pow(rem, n);
                num = num / 10;
            }

            if (check == sum)
            {
                Console.WriteLine("Isarmstrong");
            }
            else
            {
                Console.WriteLine("Notarmstrong");
            }

        }
        //Anagram
        public static void Anagram()
        {
            Boolean IsAnagram = true;
            Console.WriteLine("Enter an String 1");
            String one = Console.ReadLine();
            Console.WriteLine("Enter an String 2");
            String two = Console.ReadLine();
            char[] chars = one.ToCharArray();
            char[] chars2 = two.ToCharArray();
            char temp;



            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        temp = chars[i];
                        chars[i] = chars[j];
                        chars[j] = temp;
                    }
                }

            }

            Console.WriteLine(chars);
            for (int i = 0; i < chars2.Length - 1; i++)
            {
                for (int j = i + 1; j < chars2.Length; j++)
                {
                    if (chars2[i] > chars2[j])
                    {
                        temp = chars2[i];
                        chars2[i] = chars2[j];
                        chars2[j] = temp;
                    }
                }

            }
            Console.WriteLine(chars2);

            for (int n = 0; n < chars.Length - 1; n++)
            {
                if (chars[n] != chars2[n])
                {
                    IsAnagram = false;
                }

            }


            Console.WriteLine(IsAnagram);
            Console.ReadLine();
        }
        //Prime
        public static void Prime()
        {
            Boolean IsPrime = true;
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if (n % i != 0)
                {
                    IsPrime = false;
                }
            }

            Console.WriteLine(IsPrime);
            Console.ReadLine();


        }


        //Reverse
        public static void Reverse()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int newnumber = 0;
            while (n > 0)
            {
                int res = n % 10;
                newnumber = newnumber * 10 + res;
                n = n / 10;
            }

            Console.WriteLine(newnumber);
            Console.ReadLine();
        }

        //BubbleSort
        public static void Sort()
        {
            Console.WriteLine("Enter an String 1");
            String one = Console.ReadLine();

            char[] chars = one.ToCharArray();

            char temp;



            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        temp = chars[i];
                        chars[i] = chars[j];
                        chars[j] = temp;
                    }
                }

            }

            Console.WriteLine(chars);
            Console.ReadLine();
        }
        //Factorial
        public static void Factorial()
        {
            int fact = 1;
            Console.WriteLine("Enter an number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
        //ConvertNumber
        public static void ConvertNumber()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());



            switch (number)
            {
                case 1:
                    if (number > 0 && number <= 9) Console.WriteLine("Unit");
                    break;
                case 2:
                    if (number >= 10 && number <= 99) Console.WriteLine("Tens");
                    break;
                case 3:
                    if (number >= 100 && number <= 999) Console.WriteLine("Hundred");
                    break;
                case 4:
                    if (number >= 1000 && number <= 9999) Console.WriteLine("Thousand");
                    break;
                case 5:
                    if (number >= 10000 && number <= 99999) Console.WriteLine("Ten thousand");
                    break;
                case 6:
                    if (number >= 100000 && number <= 999999) Console.WriteLine("LAKHS");
                    break;
                case 7:
                    if (number >= 1000000 && number <= 9999999) Console.WriteLine("Millions");
                    break;
                default:
                    Console.WriteLine("infinity");
                    break;
            }
        }

        //Array
        public static void Arrayoper()
        {
            Console.WriteLine("Enter the Length:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDivisible = true;


                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[j] % arr[i] != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result = arr[i];
                    break;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }


        //Palindrone
        public static void CheckPalindrone()
        {
            Boolean Isplaindrone = true;
            Console.WriteLine("Enter a String");
            String name = Console.ReadLine();
            char[] chars = name.ToCharArray();
            int start = 0;
            int end = chars.Length - 1;

            while (start < end)
            {
                if (chars[start] != chars[end])
                {
                    Isplaindrone = false;
                    break;
                }
                start++;
                end--;
            }

            Console.WriteLine(Isplaindrone);
            Console.ReadLine();
        }

        //FindLargestAndSmallest
        public static void Find()
        {
            Console.WriteLine("Enter an length of an array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter an array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }

        //MaxRepeated
        public static void MaxRepeated()
        {
            int res = 0;
            char rep = ' ';

            Console.WriteLine("Enter an String");
            String name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < name.Length; j++)
                {

                    if (name[i] == name[j])
                    {

                        counter++;

                    }

                    if (counter > res)
                    {
                        res = counter;
                        rep = name[j];
                    }

                }
            }

            Console.WriteLine(rep);
            Console.ReadLine();


        }
        //Patter
        public static void Pattern()
        {
            Console.WriteLine("Enter a number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }
                for (int num = 1; num <= i; num++)
                {
                    Console.Write(num);
                }
                for (int num = i - 1; num >= 1; num--)
                {

                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }

        //AsciValue
        public static void Asc()
        {
            Console.WriteLine("Enter a string");
            String n = Console.ReadLine();
            for (int i = 0; i < n.Length; i++)
            {
                int asc = 0;
                asc = (char)n[i];
                Console.WriteLine(asc);
            }
        }

        //SumOfNumberDivBy3and4
        public static void Sum()
        {
            int sum = 0;
            int[] Arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 3 == 0 && Arr[i] % 4 == 0)
                {

                    sum += Arr[i];

                }

            }
            Console.WriteLine(sum);
        }

    }
}
