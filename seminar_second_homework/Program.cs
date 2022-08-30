// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа
/*
int SecondDigit (int num)
{
    int num1, num2, result;

    num1=num/10;
    num2=num1%10;
    result=num2;
    return result;
}

Console.Write("Write three-digit number: ");
int Num=Convert.ToInt32(Console.ReadLine());
int result=SecondDigit(Num);

Console.WriteLine($"Second digit of {Num} is {result}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
/*
int CheckNumbers(int num3);

int count =0; 
    while(count < 999 && count>100)
    {
        Console.WriteLine($"The third digit of {count} is {count%10}");
        if(count>1000)
        {
            count=count%10;
        }
        if (count<100)
        {
            Console.WriteLine("The third digit of {number} is absent");
        }
    }

Console.WriteLine($"Write your number: ");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"The third digit of {number} is {number%10}");
int thirdDigit=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
 
CheckNumbers(thirdDigit);
*/
//Второе решение... Павел, подскажите что в первом пошло не так?Почему то не работает))))))))))))))))))))))))))))))))))
/*
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > -100) Console.WriteLine("The third Digit of number is apsent");

else
{
  int another = number;
    while  (another > 1000)
    {
     another = another / 10;
    }
    Console.WriteLine($" The third digit of number {number} ->  {another % 10}");
}
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void CheckNumbers(int weekand);
int weekand=0;
{
    if((weekand ==6)&(weekand==7))
    {
        Console.WriteLine("This day is weekand!!!");
    }
    else if((weekand<1) && (weekand>7))
    {
        Console.WriteLine("It's not a weekday at all!!!");
    }
    else 
    { 
        Console.WriteLine("It's not a weekand!!!");
    }
}

Console.Write("Write number from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
CheckNumbers(weekand);
*/