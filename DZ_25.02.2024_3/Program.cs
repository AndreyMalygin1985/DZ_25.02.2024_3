// Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число,
// содержащее эти цифры. Например, если с клавиатуры введено
// 1, 5, 7, 8 тогда нужно сформировать число 1578.
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите четыре цифры (от 1 до 9, через Enter):");

        int digit1 = Convert.ToInt32(Console.ReadLine());
        int digit2 = Convert.ToInt32(Console.ReadLine());
        int digit3 = Convert.ToInt32(Console.ReadLine());
        int digit4 = Convert.ToInt32(Console.ReadLine());

        int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

        Console.WriteLine("Получившиеся число: " + number);
    }
}