// Tasks:

/* Task 1. Задайте массив из m элементов, заполненный случайными числами из промежутка [a, b]. Найдите сумму отрицательных элементов массива.
 
void RondArr(int len)
{
    int[] arr = new int[len];
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(-99, 100);
        Console.Write(arr[i] + " ");

        if (arr[i] < 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($" Sum the negativ number = {sum}");
}

Console.Write("Enter a length array: ");
int len = Convert.ToInt32(Console.ReadLine());

RondArr(len);


//-----------------------------------ИЛИ ТАК--------------------------------


int[] CreateRandomArray(int len, int minValue, int maxValue)
{
    int[] array = new int[len];

    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumNegIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}


Console.Write("Input the size array: ");
int len = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(len, min, max);
WriteArray(myArray);
Console.WriteLine(SumNegIndex(myArray));
*/


/* Task 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот:


int[] CreateRandomArr(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] RepArrElem(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) array[i] = array[i] * (-1);
        else array[i] = array[i] - (array[i] * 2); 
    }
    return array;
}

Console.Write("Input the size array: ");
int len = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value array: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArr(len, min, max);
WriteArray(myArray);
int[] newArray = RepArrElem(myArray);
WriteArray(newArray);
*/


//Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.:

int[] CreateRandomArr(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

bool ProvArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

Console.Write("Input the size array: ");
int len = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value array: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArr(len, min, max);

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteArray(myArray);

bool res = ProvArray(myArray, number);
Console.WriteLine(res);


//Task 4. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b]:























