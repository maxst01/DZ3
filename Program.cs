// Задача 19

//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int a = number / 10000;
//int b = (number / 1000) % 10;
//int d = (number / 10) % 10;
//int e = number % 10;
//if (a == e && b == d)
//{
//Console.WriteLine("Число " + number + " является палиндромом");
//}
//else
//{
//Console.WriteLine("Число " + number + " не является палиндромом");
//}
//Задача 21

//int x1 = Coordinate("x", "A");
//int y1 = Coordinate("y", "A");
//int z1 = Coordinate("z", "A");
//int x2 = Coordinate("x", "B");
//int y2 = Coordinate("y", "B");
//int z2 = Coordinate("z", "B");
//int Coordinate(string coorName, string pointName)
//{
//    Console.Write($"Введите координату {coorName} точки {pointName}: ");
//    return Convert.ToInt16(Console.ReadLine());
//}
//double Decision(double x1, double x2, 
//                double y1, double y2, 
//                double z1, double z2){
//  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                   Math.Pow((y2-y1), 2) + 
//                   Math.Pow((z2-z1), 2));
//}
//double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
//Console.WriteLine($"Длина отрезка  {segmentLength}");

// Задача 23
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//    Console.WriteLine(i +"^3 = " + i * i* i);