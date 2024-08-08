int[] numbers = new int[3];
numbers[0] = 1;
numbers[1] = 15;
numbers[2] = 2;
int sum = 0;

foreach (int digit in numbers)
{
    sum += digit;
}
Console.WriteLine(sum);
Console.WriteLine(numbers.Sum());