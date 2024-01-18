internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution(2000000000));
        Console.WriteLine(Solution2(200000000));
        Console.WriteLine(Solution3(2000000000));

        Console.ReadKey();
    }

    public static int Solution(int value)
    {
        int result = 0;
        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0) result += i;
        }

        return result;
    }

    //for small numbers;
    public static int Solution2(int value)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < value; i++)
        {
            if(i%3 == 0 || i%5 == 0) list.Add(i);
        }

        return list.Sum();
    }

    //for small numbers;
    public static int Solution3(int value)
    {
        var arr = Enumerable.Range(0, value).ToArray();

        return arr.Sum(number => { 
            if (number % 3 == 0 || number % 5 == 0)
                return number; 
            else return 0;
        });
    }
}