///Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
System.Console.WriteLine("введите число, обозначающее день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number<6) System.Console.WriteLine("этот день не является выходным");
else if (number ==6 ) System.Console.WriteLine("этот день является выходным");
else if (number ==7 ) System.Console.WriteLine("этот день является выходным");


