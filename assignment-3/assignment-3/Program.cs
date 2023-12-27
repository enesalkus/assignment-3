
int max = int.Parse(Console.ReadLine());

int[] numbers = new int[max + 1];

for (int i = 2; i < numbers.Length; i++) numbers[i] = i;

for (int i = 2; i < Math.Sqrt(numbers.Length - 1) + 1; i++)
{
    if (numbers[i] != 0)
    {
        for (int j = (int)Math.Pow(numbers[i], 2); j < numbers.Length; j += numbers[i])
            numbers[j] = 0;
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] != 0) Console.WriteLine(numbers[i]);
}