// See https://aka.ms/new-console-template for more information

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
            Boom(10);
        }

        // time: O(n) where n is the length of the input array
        public static int CalculateAverage(int[] numbers)
        {
            int sum = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                sum += number;
            }

            return sum / numbers.Length;
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
                Bam(n);
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
            {
                System.Console.WriteLine(j);
            }
        }
    
    }
}
