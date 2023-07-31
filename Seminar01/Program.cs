/* Виды переменных
int intNumber = 25;
double doubleNumber = 12.12;
string text = "some text";
bool logicVar = true;  */

/* Совмещение данных
int num1 = 5;
int num2 = 10;
Console.WriteLine("My number are " + num1 + " end " + num2 + " and it's good!"); - совмещение данных с помощью < + > (concatination)
Console.WriteLine($"My number are {num1} and {num2} and it's good!"); - совмещение данных с помощью < $ > (форматированный вывод) */

/* Конвертировать 
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number's " + num); */

//Task 1. На вход принимаем два числа и проверяем, является ли первое число квадратом второго:

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
} 


/* Task 2. На входе принимаем положительное число (N), на выходе получаем все целые числа в промежутке от -N до N.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current ++;
}
 */

