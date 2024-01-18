internal class Program
{
    private static void Main(string[] args)
    {

        var result = TwoSum(new int[] { 1,2, 3 }, 4);

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }

        var result2 = TwoSumByLoop(new int[] { 1, 2, 3 }, 4);

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }


    public static int[] TwoSumByLoop(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
            for (int j = i + 1; j < numbers.Length; j++)
                if (numbers[i] + numbers[j] == target)
                    return new int[] { i, j };

        return new int[0];
    }
    public static int[] TwoSum(int[] numbers, int target)
    {
        Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
        List<int> result = new List<int>(); 
        for (int i = 0; i < numbers.Length; i++)
        {
            var diff = target - numbers[i];
            if (keyValuePairs.ContainsKey(diff))
            {
                result.Add(keyValuePairs[diff]);
                result.Add(i);
                return result.ToArray();
            }
            else
            {
                keyValuePairs.Add(numbers[i], i);
            }
        }

        return result.ToArray();
    }
}