
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, -2, 1, -3, 2, 8, -1 ,-4, -5, -8, 9, 5, 2, };

        int negativeCount = numbers.Count(n => n < 0);

       
        int negativeSum = numbers.Where(n => n < 0).Sum();

        Console.WriteLine("Кількість від'ємних елементів: " + negativeCount);
        Console.WriteLine("Сума від'ємних елементів: " + negativeSum);

        // Якщо від'ємних елементів немає, виводимо "0 0" двічі
        if (negativeCount == 0)
        {
            Console.WriteLine("0 0");
        }
    }
}
