// Seminar 3.

// Theory:



/* Task 1. Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (X и Y):

void WriteRange(int quadrant)
{
    if(quadrant < 1 || quadrant > 4) Console.WriteLine("Uncorrect data!");
    else if(quadrant ==1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant ==2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant ==3) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x > 0 and y < 0");
}

Console.WriteLine("Input a number of quadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad); 
*/


/* Task 2. Напишите программу, которая принимает на вход число (N) и выдает квадраты чисел от 1 до N:

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
*/


/* Task 3. Напишите программу, которая принимает на вход координаты двух точек и нахидит росстаяние между ними в 2D пространстве:

double DistanceLine(double x1, double y1, double x2, double y2) 
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double distance = DistanceLine(x1, y1, x2, y2);
Console.WriteLine("Distance = " + distance);
*/


/* Task 4. Напишите программу, которая принимает на вход координаты точек ((X и Y), причем Х и Y не равняются нолю) и выдает
номер четверти плоскости, в которой находится эта точка:

int quadrant(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Inpyt the x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpyt the y: ");
int y = Convert.ToInt32(Console.ReadLine());

int NumChet = quadrant(x, y);
if (NumChet == 0) Console.WriteLine("Uncorrect data!");
else Console.WriteLine("Qadrant nymber is: " + NumChet);
*/



