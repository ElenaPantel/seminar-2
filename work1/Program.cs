//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно


int number1=new Random().Next(100,1000);
int number2=new Random().Next(1,10);
Console.WriteLine (number1);
Console.WriteLine (number2);

if (number1 % number2==0) Console.WriteLine("yes");
else Console.WriteLine("no");
