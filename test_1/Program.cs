/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) и возводит число A
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

int RaisingAtoThePowerOfB(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.WriteLine(RaisingAtoThePowerOfB(3, 5));
Console.WriteLine(RaisingAtoThePowerOfB(2, 4));
