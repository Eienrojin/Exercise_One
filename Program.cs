namespace Exercise_One;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FibonachiExtended(100));
    }

    static double FibonachiExtended(int n)
    {
        var results = new List<double>();

        results.Insert(0, 1);
        double lastResult = 0;
        double currentResult = 0;

        for (int i = 0; i < n; i++)
        {
            currentResult = 0;

            if (results.Count >= 3)
                currentResult = results[^1] + results[^2] + results[^3];
            else
                for (int j = 0; j < results.Count; j++)
                    currentResult += results[i];

            lastResult = currentResult;
            results.Add(lastResult);
        }

        return lastResult;
    }
}