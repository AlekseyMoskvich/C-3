/*
Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите четверть");
int Quater = int.Parse(Console.ReadLine());

string range = NumbersOfQuater(Quater);

Console.WriteLine(range);

string NumbersOfQuater(int Quater){

    if (Quater == 1){
        return "X > 0 & Y > 0";
    }
    
    if (Quater == 2){
        return "X < 0 & Y > 0";
    }

    if (Quater == 3){
        return "X < 0 & Y < 0";
    }

    if (Quater == 4){
        return "X > 0 & Y < 0";
    }
    
    return " ";
}
*/

/*Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21   AB = √(xb - xa)2 + (yb - ya)2


Console.WriteLine("Введите координаты первой точки");
int xa = int.Parse(Console.ReadLine());
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
int xb = int.Parse(Console.ReadLine());
int yb = int.Parse(Console.ReadLine());

double Distanse = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

Console.WriteLine($"Расстояние между точками = {Distanse}");
*/

/*Задача No22. Работа в группах
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4


Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());

int Pows = PowOfNumbers(Number);

int PowOfNumbers (int Number){

    for(int i = 1; i <= Number; i += 1){

        double a = Math.Pow(i, 2);

        Console.Write($"{a}, ");
    }
    return 0;
}

*/

