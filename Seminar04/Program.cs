// Seminar 4.

/* Task 1. Напишите программу, которая принимает на вход число N и выдает сумму чисел от 1 до N:

 int summare(int number)
    {
    int count = 1;
    int sum = 0; 

        while (count <= number)
        {
        sum += count;
        count++;
        }
    return sum;
    }

 Repeat:
 Console.Write("Input a numbers: ");
 int num = Convert.ToInt32(Console.ReadLine());

 if(num < 1) 
    {
    Console.Write("Uncorrect data! - ");
    goto Repeat; 
    }
 else Console.WriteLine($"Сумма чисел от 1 до {num} = {summare(num)}");
*/



/* //Task 2. Напишите программу, которая принимает на вход число N, и выдает количество цифр в N:

 // void sumSymbol(string input)
 // {
 //     int len = input.Length;
 //     Console.WriteLine($"{len} symbol");
 // }

 // Console.Write("Input numbers or word: ");
 // sumSymbol(Console.ReadLine());

 int CountNumber(int num)
 {
     int count = 1;
     while(10 <= num)
     {
         num/=10;
         count+=1;
     }
     return count; 
 }
 Repeat:
 Console.Write("input a number: ");
 int current = Convert.ToInt32(Console.ReadLine());

 if (current < 1) 
 {
     Console.Write("Uncorrect data! - ");
     goto Repeat;
 }
 else Console.WriteLine(CountNumber(current));
*/
    


/*  Task 3. Напишите программу, которая принимает на вход число N, и выдает произведение нечетных чисел от 1 до N:

 int ComposNumbers(int numbers)
 {
     int current = 1;
     int sum = 1;

     while(current <= numbers)
     {
         sum *= current;
         current +=2;
     }
     return sum;
 }


 Repeat:
 Console.Write("input a number: ");
 int num = Convert.ToInt32(Console.ReadLine());

 if (num < 1) 
 {
     Console.Write("Uncorrect data! - ");
     goto Repeat;
 }
 else Console.WriteLine(ComposNumbers(num));
*/



int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0 ; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

 Console.Write("input a length of an array: ");
 int length = Convert.ToInt32(Console.ReadLine());
 Console.Write("input a min possible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("input a man possible value: ");
 int max = Convert.ToInt32(Console.ReadLine());

 int[] myArray = CreateRandomArray(length, min, max);
 WriteArray(myArray);