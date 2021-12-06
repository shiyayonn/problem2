// See https://aka.ms/new-console-template for more information

class Problem2
{
    static void Main(string[] args)
    {
        int N = 0;
        int sum1 = 0;
        int sum2 = 0;
        N = Int32.Parse(Console.ReadLine().Trim());

        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine().Trim();
            string[] row = input.Split(' ');
            int[] arr = Array.ConvertAll(row, s => int.Parse(s));
            sum1 += arr[i];
            sum2 += arr[N-i-1];

        }

        Console.WriteLine(Math.Abs(sum1-sum2));

    }
}