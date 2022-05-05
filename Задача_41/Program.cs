// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.Clear();

Console.Write("Введите произвольные числа через запятую: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] numbers = StrToArray(Console.ReadLine());
int count = 0;

for (var i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("-> " + count);

