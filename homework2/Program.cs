int k1 = GetValue("Чему равен k1");
int b1 = GetValue("Чему равен b1");
int k2 = GetValue("Чему равен k2");
int b2 = GetValue("Чему равен b2");
double x = FindingCoordinatesX(k1, b1, k2, b2);
double y = FindingCoordinatesY(k1, b1, k2, b2);;
string s = PrintCoordinates(x, y);
Console.WriteLine("Координаты точки пересечения = (" + s + ")");

int GetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

double FindingCoordinatesX(int a, int b, int c, int f)
{
    double x = (f - b) * 1.0 / (a - c);;
    return x;
}

double FindingCoordinatesY(int a, int b, int c, int f)
{
    double y = (f - b) * 1.0 / (a - c);;
    return y;
}

string PrintCoordinates(double x, double y)
{
    double[] array = new double[2];
    for (int i = 0; i < array.Length; i++)
    {
        array[0] = x;
        array[1] = y;
    }
    string s = String.Join("; ", array);
    return s;
}