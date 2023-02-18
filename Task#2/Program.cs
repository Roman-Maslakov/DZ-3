// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
int[] point1 = new int[3];
for (int i = 0; i < point1.Length; i++) point1[i] = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine("Введите координаты второй точки");
int[] point2 = new int[3];
for (int i = 0; i < point2.Length; i++) point2[i] = Convert.ToInt32(Console.ReadLine());

double diffx = Math.Pow(point2[0] - point1[0], 2);
double diffy = Math.Pow(point2[1] - point1[1], 2);
double diffz = Math.Pow(point2[2] - point1[2], 2);

double distance = Math.Sqrt(diffx + diffy + diffz);
Console.WriteLine("Расстояние между точками = " + distance);