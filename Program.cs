//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int tenThousand = (number / 10000) % 10;
int thousand = (number / 1000) % 10;
int hundreds = (number / 100) % 10;
int dozits = (number / 10) % 10;
int units = number % 10;
if (units == tenThousand && dozits == thousand)
{
    Console.WriteLine($"Yes, {number} is palindrome");
}
else { Console.WriteLine($"No, {number} isn't palindrome"); }


