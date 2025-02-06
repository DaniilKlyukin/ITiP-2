namespace Practice2Example
{

    /* Задание:
     * Файл Input.txt содержит 2 числа A и B, необходимо посчитать НОД и записать результат в файл Output.txt
     */

    /// <summary>
    /// Поиск наибольшего общего делителя
    /// </summary>
    public class GreatestCommonDivisorCalculator
    {
        private static void readInput(string path, out int a, out int b)
        {
            var input = File.ReadAllText(path);

            var arr = input.Split(' ');

            a = int.Parse(arr[0]);
            b = int.Parse(arr[1]);
        }

        public static int CalculateGCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a + b;
        }

        private static void writeOutput(int gcd, string path)
        {
            File.WriteAllText(path, $"{gcd}");
        }

        public static void Process(string input, string output)
        {
            readInput(input, out var a, out var b);

            var gcd = CalculateGCD(a, b);

            writeOutput(gcd, output);
        }
    }
}
