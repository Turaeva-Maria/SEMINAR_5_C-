/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
Найдите сумму отрицательных и положительных элементов массива. 
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20*/


Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}


int PositiveSum(int[] array)
{
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPos += array[i];
    }

    return sumPos;
}

int NegativeSum(int[] array)
{
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sumNeg += array[i];
    }

    return sumNeg;
}



int[] array = new int[12];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма положительных чисел равна {PositiveSum(array)}");
Console.WriteLine($"Сумма отрицательных чисел равна {NegativeSum(array)}");
