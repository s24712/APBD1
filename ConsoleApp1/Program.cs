namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + ". Hello, Git!");
            }

            int[] arr = new[] { 1, 3, 4, 5, 6 };

            Console.WriteLine(srednia(arr));
            
            Console.WriteLine(maxValue(arr));
        }

        static int srednia(int[] arr)
        {
            int tmp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tmp += arr[i];
            }

            return tmp / arr.Length;
        }

        static int maxValue(int[] arr)
        {
            return arr.Max();
        }
    }
}