/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) и возводит число A
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

double RaisingAtoThePowerOfB(double A, double B)
{
    double i = Math.Pow(A, B);
    return i;
}

Console.WriteLine(RaisingAtoThePowerOfB(3, 5));
Console.WriteLine(RaisingAtoThePowerOfB(2, 4));
