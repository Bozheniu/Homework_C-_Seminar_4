/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33] */

//Вот здесь проблема, не могу понять, как сделать по другому,
// чтобы не выводилась ошибка :(

int MakeArrayWith8Elements(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8)
{
    int[] array = { n1, n2, n3, n4, n5, n6, n7, n8 };
    return array;
}

System.Console.WriteLine(MakeArrayWith8Elements(1, 2, 5, 7, 19, 3, 6, 8));
