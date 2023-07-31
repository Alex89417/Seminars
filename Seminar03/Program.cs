// Seminar 3.

// Theory:



/* Task 1. Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (X и Y):

void WriteRange(int quadrant)
{
    if(quadrant < 1 || quadrant > 4) Console.WriteLine("Uncorrect data!");
    else if(quadrant ==1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant ==2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant ==3) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x < 0 and y > 0");
}

Console.WriteLine("Input a number of quadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad); 
*/
// Task 2. Напишите программу которая принимает на вход число (N) и выдает квадраты чисел от 1 до N:

void WriteQuad(int number)
{
   int count = 1;
   if(number < 1) Console.WriteLine("Uncorrect data!");
   while(count <= number) 
   {
        Console.WriteLine($"{count} - {Math.Pow(count, 2)}; ");
        count++;
   }
}

Console.Write("Input a number: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteQuad(quad);

                               1:28


