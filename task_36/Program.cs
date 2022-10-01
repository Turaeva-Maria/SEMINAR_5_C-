/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 200);
}


int AccountNum (int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i=i+2)
    {       
        {
        count++;
        }     
    }
    return count;
}

int SummNum (int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i=i+2)
    {       
        {
        count=count+array[i];
        }     
    }
    return count;
}

InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine($"Сумма " + AccountNum(array) + " нечетных элементов = " + SummNum(array));



