// Theory:
/*  
13254 / 10 = 1325
13254 / 100 = 132
13254 / 1000 = 13
13254 / 10000 = 1

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254

24365 -> 43 = / 100 = 243 % 100 = 43

Метод -вызываемоя подпрограмма
*/

// Task:
/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа:


// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     return hundreds * 10 + units;
// }

int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

    int res = hundreds * 10 + units;
    return res;
}


int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b:

bool IsDivisible(int num, int div1, int div2)
{
    // if(num % div1 == 0 && num % div2 == 0)
    //     return true;
    // else
    //     return false;

    return num % div1 == 0 && num % div2 == 0;
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool res = IsDivisible(number, divider1, divider2);

if(res) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа:

int MaxNum(int num)
{
    int num1 = num % 10;
    int num2 = num / 10;
    if(num1 > num2) return num1;
    else return num2;
}
int number = new Random().Next(10, 100);  // [a;b]
Console.WriteLine(number);

int res = MaxNum(number);
Console.WriteLine(res);
*/

/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого:


bool SquerCheck(int firstNum, int secondNum)
{
    return (firstNum == secondNum * secondNum || secondNum == firstNum * firstNum);
}

Console.Write("Input the first number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

bool res = SquerCheck(numberOne, numberTwo);
if(res) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/




