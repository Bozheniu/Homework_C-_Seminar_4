/* Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigit(int number)
{
    int length = Convert.ToString(number).Length;
    int move = 0;
    int sum = 0;
    for (int n = 0; n < length; n++)
    {
        move = number - number % 10;
        sum = sum + (number - move);
        number = number / 10;
    }
    return sum;
}

Console.WriteLine(SumOfDigit(number));
