/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да


Console.WriteLine("Введите пятизначное число");

int Number = int.Parse(Console.ReadLine());

int Polindrom = KnowPolindrom(Number);

if (Polindrom == 1){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}


int KnowPolindrom(int Number){
    
    if(Number / 10000 == Number % 10){

        int FirstNumber = (Number / 10000) * 10;
        
        if(Number / 1000 - FirstNumber == Number / 10 % 10){

            return 1;
        }
    }
    
    return 0;
}
*/

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


Console.WriteLine("Введите координаты первой точки");
int xa = int.Parse(Console.ReadLine());
int ya = int.Parse(Console.ReadLine());
int za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
int xb = int.Parse(Console.ReadLine());
int yb = int.Parse(Console.ReadLine());
int zb = int.Parse(Console.ReadLine());

double Distanse = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));

Console.WriteLine($"Расстояние между точками = {Distanse}");
*/

/*Задача 23

Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());

int Pows = PowOfNumbers(Number);

int PowOfNumbers (int Number){

    for(int i = 1; i <= Number; i += 1){

        double a = Math.Pow(i, 3);

        Console.Write($"{a}, ");
    }
    return 0;
}