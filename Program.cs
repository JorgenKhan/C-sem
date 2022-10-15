/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    int result;
    int ed = num % 10;
    int des = num / 10;
    result = des % 10;
     
    return result;
}
int number = new Random().Next(100,1000);
int secondDigit = SecondDigit(number);

Console.WriteLine($"Second number from {number} is {secondDigit}");*/

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ShowThirdDigit(int num)
{
    int result;
    
    if (num < 100)
        result = -1;
    else
    {
        while (num > 999)
        num = num / 10;
        result = num % 10;
    }
    return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ShowThirdDigit(number);
if (thirdDigit > -1)
    Console.WriteLine($"Third digit of {number} is {thirdDigit}");
else
    Console.WriteLine($"There is no third digit");*/

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool TodayHoliday(int day)
{
    bool result;

    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
    return result;
}

Console.Write("Input a number of day in the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool todayHoliday = TodayHoliday(dayNumber);

if (todayHoliday)
    Console.WriteLine($"Yes, {dayNumber} day is a Holiday");
else
    Console.WriteLine($"No, {dayNumber} day is not a Holiday");*/

