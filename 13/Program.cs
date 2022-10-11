/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


int rand= new Random().Next(10,1000);
Console.WriteLine(rand);
int x = rand%10;
if( rand>100)
{
Console.WriteLine(rand%10);
}
else 
Console.WriteLine("Третьей цифры нет");