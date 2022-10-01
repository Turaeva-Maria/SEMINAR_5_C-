/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементом массива.*/


Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1000);
}

int FindMax (int[] array)
{
    int max = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i]>max) max=array[i]; 
    }
    return max;
}

int FindMin (int[] array)
{
    int min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i] < min) min=array[i];   
    }
    return min; 
}

InputArray(array);
FindMax(array);
FindMin(array);

int result = FindMax(array)-FindMin(array);

Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine($"Разница чисел " + FindMax(array) + " и " + FindMin(array) + " = " + result);







