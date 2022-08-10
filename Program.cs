// Task 1 : Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
/*

int PositiveNum(int[] array)
{ 
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0 ) count++;
    }   
    return count;
}

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new  Random().Next( minValue, maxValue +1);
    }
    return newArray;
}
void ShowArray(int[] array){
    for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");
     Console.WriteLine(); 
}
Console.WriteLine("Введите кол-во элементов массив: ");
int size = Convert.ToInt32(Console.ReadLine());


int min  = 100;
int max  = 999;

int[] array = CreateArray(size, min, max);
int result = PositiveNum(array);
ShowArray(array);
Console.WriteLine($"Кол-во четных чисел равен {result}");



// Task 2 : Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new  Random().Next( minValue, maxValue +1);
    }
    return newArray;
}

void ShowArray(int[] array){
    for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");
     Console.WriteLine(); 
}

int Sum(int []  array)
{
    int sum  = 0;
    for (int i = 1; i < array.Length; i = i + 2 )
      {
      sum = sum + array[i] ;
    }   
    return sum;
}

Console.Write(" Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input min possible value of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input max possible value  of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArray(size, minValue, maxValue);
ShowArray(array);

int result = Sum(array);
Console.Write($" Сумма элементов, стоящих на нечётных позициях равна {result} ");

*/

// Task 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new  Random().Next( minValue, maxValue +1);
    }
    return newArray;
}

void ShowArray(int[] array){
    for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");
     Console.WriteLine(); 
}

int Max (int [] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array [i];
    }
    return max;
}



int Min(int [] array)
{
    int min = array [0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
    return min;
}


Console.Write(" Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input min possible value of the range array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input max possible value  of the range  array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, minValue, maxValue);
ShowArray(array);
int max = Max(array);
int min = Min(array);
int result = max - min;

Console.Write($"Разница между максимальным и минимальным элементов массива равна  {result} ");