IEnumerable<double> Pow2(IEnumerable<double> doubles)
{
    foreach (var value in doubles)
    {
        yield return value * value;
    }
}

IEnumerable<double> Sqrt(IEnumerable<double> doubles)
{
    foreach (var value in doubles)
    {
        yield return Math.Sqrt(value);
    }
}

EnumerableUnaryOperation? operation = null;

var input = Console.ReadLine();
if (input == "Sqrt")
    operation = Sqrt;
else if (input == "Pow2")
    operation = Pow2;

var doubles = new[] { 1.0, 2, 3, 4, 5 };

var linq = Pow2(Sqrt(doubles));

foreach (var value in linq)
{
    Console.WriteLine(value);
}

var result = operation?.Invoke(doubles).ToArray();

delegate IEnumerable<double> EnumerableUnaryOperation(IEnumerable<double> doubles);