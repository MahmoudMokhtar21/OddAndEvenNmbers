

using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

PrintNumbers("numbers", numbers);
PrintNumbers("Even Numbers", numbers.Where(x => IsEven(x)));
PrintNumbers("Odd Numbers", numbers.Where(x => IsOdd(x)));



static void PrintNumbers(string title,IEnumerable<int> nums)
{
    Console.WriteLine();
    Console.Write($"{title} : [");
    foreach(int n in nums)
    {
        Console.Write(n);
    }
    Console.Write(" ]");
}

static bool IsEven(int n) => n%2 == 0;

static bool IsOdd(int n) => !IsEven(n);
