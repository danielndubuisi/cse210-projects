using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        double sum = 0;
        int spn = 999999999;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);    
            }
        }

        foreach (int num in numbers)
        {
            // calculate the sum of the numbers
            sum+= num;
            // find the smallest positive number(spn)
            if (num > 0 && num < spn)
            {
                spn = num;
            }
        }

        int count = numbers.Count;
        double average = sum / count;
        int maxNum = numbers.Max();
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");
        Console.WriteLine($"The smallest positive number is: {spn}");
        Console.WriteLine($"The sorted list is:\n{string.Join("\n", numbers)}");
    }
}