// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Math.Abs(number).ToString();

Console.WriteLine(num.Length > 2 ? $"{number} -> {num[2]}" : $"{num} -> There is no third digit");

/*
if(numberS.Length > 2) {
    Console.WriteLine($"{number} -> {numberS[2]}");
} else {
    Console.WriteLine($"{number} -> no third digit");
}
*/

//Previous tries

//Console.Write("Enter a number: ");
//string input = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("{1} -> {2}",input, input[2]);

//int num = Convert.ToInt32(Console.ReadLine());

//if (num > 100 || num <1000)
//{
   // int thirdDigit = num % 10;
    //Console.WriteLine($"The third digit is {thirdDigit}");
//}   
//else if (num < 100)
//{
    //Console.WriteLine("There is no third digit");
//}
//else if (num >= 1000)
//{
    //string input = Console.ReadLine();
    //Console.WriteLine("{0} -> {2}",input, input[2]);
//}
//    int mult1 = num % 100;
 //   int mult2 = mult1 / 10;
 //   Console.WriteLine($"The second digit of the number entered{mult2}");
