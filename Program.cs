// See https://aka.ms/new-console-template for more information

using System;

namespace ONotation
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, ONotation!");

            // Console.WriteLine(CalculateAverage(new int[] { 2, 5, 8, 19, 17 }));
            // Foo(10);
            // Bar(10);
            // Boom(10);
            //Doubler(new char[] { 'a', 'b', 'c' });


            /* space examples */
            /* recursive example */
            // Zoom(10);
            // Zap(10);

            /* Big O complexity classes */
            // var output = Foo1(4);
            // Bar1Complexity(new int[] { 4, 5, 8, 19 });

            //logarithmic
            // Fun(32);
            // FunRecursive(30);

            /* linear */
            // PrintArray(new string[] { "jone", "mary", "salami" });
            // Bars(5);

            /* loglinear */
            // BarsWithLogLinear("abcdefghijklmnopqrstuvwxyz");
            // FooWithLogLinear(new string[] { "a", "b", "c", "d", "e", "f", "g", "h" });

            /* polynomials */
            // FooPolynomial(new string[] { "pillar", "salt", "office" });
            // BarPolynomial(new string("emmanuel"));

            /* exponentials */
            // FooExponential(4);

            /* factorial */
            // FooFactorial(4);

            /* multiple args */
            // FooMultipleArgs(3, 2);

            // var colors = new string[] { "yellow", "teal", "navy", "white" };
            // var clothes = new string[] { "shirt", "jeans", "skirt" };
            // CrossPairs(colors, clothes);

            // FooMultipleArgs2("swim", "run");
            // FooMultipleArgs2("coat", "jacket");
        }

        // time: O(n) where n is the length of the input array
        public static int CalculateAverage(int[] numbers)
        {
            int average = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                average += number;
            }

            return average / numbers.Length;
        }

        //O(N^2) where N is the size of the input
        public static void Foo(int input)
        {
            for (var a = 0; a < input / 2; a++)
            {
                System.Console.WriteLine(a);
            }
            //O(N)

            for (var b = 0; b < input; b++)
            {
                for (var c = 0; c < input; c++)
                {
                    System.Console.WriteLine(b + ", " + c);
                }
            }
            //O(N * N)=O(N^2)

            //O(N) + O(N^2)=O(N^2)
        }

        //O(N) where N is the size of the input
        public static void Bar(int input)
        {
            //O(3N)
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < input; j++)
                {
                    System.Console.WriteLine(j);
                }
            }

            //O(10000)
            for (var k = 0; k < 10000; k++)
            {
                System.Console.WriteLine(k);
            }

            //O(3n + 10000)=n
        }

        //O(N) where N is the size of the input
        public static void Boom(int n)
        {
            //O(3N)
            for (var i = 0; i < 3; i++)
            {
                Bam(i);
            }
            //O(10000)
            for (var k = 0; k < 10000; k++)
            {
                System.Console.WriteLine(k);
            }
            //O(3N)+O(10000)=O(N)
        }

        public static void Bam(int m)
        {
            for (var j = 0; j < m; j++)
                System.Console.WriteLine(j);
        }

        //space: O(2N)=O(N)
        public static char[] Doubler(char[] items)
        {
            int count = 0;
            var newArray = new char[items.Count() * 2];

            for (var i = 0; i < items.Length; i++)
            {
                newArray[count++] = items[i];
                newArray[count++] = items[i];
            }

            return newArray;
        }

        //recursive examples

        //time: O(n)
        //space: O(n)
        public static void Zoom(int n)
        {
            if (n == 0)
            {
                System.Console.WriteLine("liftoff!");
                return;
            }
            System.Console.WriteLine(n);
            Zoom(n - 1);
        }

        //time: O(n)
        //space: O(n)
        public static void Zap(int n)
        {
            if (n < 1)
            {
                System.Console.WriteLine("blastoff!");
                return;
            }

            System.Console.WriteLine(n);
            Zap(n - 2);
        }

        /* write a funt, unique that takes in an array
        and returns a new array containing the unique elements.
        example: unique(['cat', 'dog','rat','dog','cat','bird'])
        => ['cat','dog','rat','bird'] */

        //soln 1
        /* time: O(N^2)
            space: O(N)
        */
        public static int[] Unique(int[] array)
        {
            var newArray = new int[array.Length];
            var count = 0;

            for (var i = 0; i < array.Length; i++)
            {
                var ele = array[i];

                if (!newArray.Contains(ele))
                    newArray[count++] = ele;
            }

            return newArray;
        }

        //soln 2
        /* time: O(N)+O(N)=O(2N)=O(N)
        space: O(N)
        */

        public static int[] UniqueWithHashSet(int[] array)
        {
            var newSet = new HashSet<int>(); //O(1)

            for (var i = 0; i < array.Length; i++) //O(N)
            {
                var ele = array[i];

                if (!newSet.Contains(ele))
                    newSet.Add(ele);
            }
            return newSet.ToArray(); //O(N)
        }

        /* O(1) examples */
        public static int Foo1(int n)
        {
            int result = 0;

            for (var i = 0; i < 5; i++)
            {
                result += n;
            }
            return result;
        }

        public static int Bar1Complexity(int[] array)
        {
            return array[0] * array[array.Length - 1];
        }

        /* O(log(N)) examples */
        public static void Fun(int n)
        {
            while (n > 1)
            {
                System.Console.WriteLine(n);
                n /= 2;
            }

            System.Console.WriteLine("done");
        }

        public static void FunRecursive(int n)
        {
            if (n <= 1)
            {
                System.Console.WriteLine("hooray");
                return;
            }
            System.Console.WriteLine(n);

            FunRecursive(n /= 2);
        }

        /* O(N) linear examples */
        public static void PrintArray(string[] input)
        {
            for (var i = 0; i < input.Length; i++)
                System.Console.WriteLine(input[i]);
        }

        public static void Bars(int n)
        {
            if (n == 0)
                return;
            System.Console.WriteLine(n);

            Bars(n - 1);
        }

        /* O(n*log(n)) loglinear examples */
        //the BarsWithLogLinear funct is called a O(log(n)) of times but for
        //each call substring funct performs a linear O(n) operation
        //final complexity => O(n*log(n))
        public static void BarsWithLogLinear(string input)
        {
            System.Console.WriteLine(input);

            if (input.Length <= 1)
                return;

            int midIndex = input.Length / 2;
            BarsWithLogLinear(input.Substring(0, midIndex));
        }

        /*  the problem can best b illustrated with a tree
            work done across the width (i.e at each level) = n
            height = log(n) due to halving of the strin in each funct call
            final complexity = O(n*log(n)) 
        */
        public static void FooWithLogLinear(string[] array)
        {
            var str = string.Empty;

            for (var i = 0; i < array.Length; i++) //O(n)
            {
                str += array[i];
            }
            System.Console.WriteLine(str);
            System.Console.WriteLine("------");

            if (array.Length <= 1)
                return;

            var midIndex = array.Length / 2;
            var left = new string[midIndex];
            var right = new string[midIndex];
            var size = array.Length - midIndex;

            Array.Copy(array, 0, left, 0, midIndex); //O(n)
            Array.Copy(array, midIndex, right, 0, size); //O(n)

            //recursive calls evaluate to O(log(n))
            FooWithLogLinear(left);
            FooWithLogLinear(right);
        }

        /* Polynomials */
        public static void FooPolynomial(string[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    System.Console.WriteLine(input[i] + "/" + input[j]);
                }
            }
        }

        /* each recursive call */
        public static void BarPolynomial(string input)
        {
            if (input.Length == 0)
                return;

            var firstChar = input[0];
            System.Console.WriteLine(firstChar);
            var rest = input.Substring(1); //copying the input = O(n)

            BarPolynomial(rest); //each recursive call O(n)
        }

        /* Exponentials */
        public static void FooExponential(int input)
        {
            if (input == 1)
                return;
            Console.WriteLine(input);

            FooExponential(input - 1);
            FooExponential(input - 1);
        }

        /* Factorial n! */
        public static void FooFactorial(int n)
        {
            if (n == 1)
                return;

            Console.WriteLine(n);
            for (var i = 0; i < n; i++)
            {
                FooFactorial(n - 1);
            }
        }

        /* functs with multiple arguments */
        //O(m+n), because one loop follows the other
        public static void FooMultipleArgs(int m, int n)
        {
            for (var i = 0; i < m; i++)
            {
                Console.WriteLine("hi");
            }

            for (var j = 0; j < n; j++)
            {
                Console.WriteLine("bye");
            }
        }

        //time : O(m*n)  where m and n are the array lengths
        public static void CrossPairs(string[] array1, string[] array2)
        {
            for (var i = 0; i < array1.Length; i++)
            {
                for (var j = 0; j < array2.Length; j++)
                {
                    Console.WriteLine($"{array1[i]} {array2[j]}");
                }
            }
        }

        //O(max(m,n)) where m and n are the string lengths

        //or O(n) where n is the length of the longer string
        public static void FooMultipleArgs2(string input1, string input2)
        {
            if (input1.Length > input2.Length)
            {
                for (var i = 0; i < input1.Length; i++)
                {
                    Console.WriteLine(input1[i]);
                }
            }
            else
            {
                for (var j = 0; j < input2.Length; j++)
                {
                    Console.WriteLine(input2[j]);
                }
            }
        }
    }
}
