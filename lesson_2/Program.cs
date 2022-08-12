//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("введите любое число");
string inputnumber =Console.ReadLine();
int len = inputnumber.Length;
if (inputnumber.Length<3)
System.Console.WriteLine("третьего числа нету");
else
    System.Console.WriteLine($"{inputnumber[2]}");
//else System.Console.WriteLine($"Третья цифра числа {digit}");
