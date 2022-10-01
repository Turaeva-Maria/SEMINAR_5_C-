/*Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве. 
 4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

Console.Clear();


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}


string ReleaseArray(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == x)
            return "Да, это число есть в массиве";
    }
    return "Нет, такого числа нет в массиве";
}


Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.Write("Введите число для проверки его нахождения в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, x));
