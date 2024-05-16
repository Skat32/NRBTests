double[] values = [1.0, 2.0, 3.0, 4.0, 5.0];

// Вычисление стандартного отклонения
var standardDeviation = CalculateStandardDeviation(values);

// Вывод результата
Console.WriteLine("Стандартное отклонение: " + standardDeviation);
return;

static double CalculateStandardDeviation(IReadOnlyCollection<double> values)
{
    if (values.Count == 0)
        return 0;

    var average = values.Average();
    var sumOfSquares = values.Sum(x => Math.Pow(x - average, 2));

    return Math.Sqrt(sumOfSquares / (values.Count - 1));
}