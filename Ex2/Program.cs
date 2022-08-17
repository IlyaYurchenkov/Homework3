Console.Clear();
int x1 = ReadInt ("Введите X точки А: ");
int y1 = ReadInt ("Введите Y точки А: ");
int z1 = ReadInt ("Введите Z точки А: ");
int x2 = ReadInt ("Введите X точки B: ");
int y2 = ReadInt ("Введите Y точки B: ");
int z2 = ReadInt ("Введите Z точки B: ");

int lenghX = x1 - x2;
int lenghY = y1 - y2;
int lenghZ = z1 - z2;
double Distance3D = Math.Sqrt(lenghX * lenghX + lenghY * lenghY + lenghZ * lenghZ);
Console.WriteLine(Distance3D);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
