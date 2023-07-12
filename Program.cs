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

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Input coordinates of two points: ");
Console.Write("Point A (x): ");
int coordinateAx = Convert.ToInt32(Console.ReadLine());
Console.Write("Point A (y): ");
int coordinateAy = Convert.ToInt32(Console.ReadLine());
Console.Write("Point A (z): ");
int coordinateAz = Convert.ToInt32(Console.ReadLine());
Console.Write("Point B (x): ");
int coordinateBx = Convert.ToInt32(Console.ReadLine());
Console.Write("Point B (y): ");
int coordinateBy = Convert.ToInt32(Console.ReadLine());
Console.Write("Point B (z): ");
int coordinateBz = Convert.ToInt32(Console.ReadLine());
double distance = 0;
distance = Math.Sqrt(Math.Pow(coordinateBx - coordinateAx, 2) +
                     Math.Pow(coordinateBy - coordinateAy, 2) +
                     Math.Pow(coordinateBz - coordinateAz, 2));
Console.Write($"The distance between points in 3D space = {Math.Round(distance, 2)}");

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Input some number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}
else
{
    for (int i = 1; i >= number; i--)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}


