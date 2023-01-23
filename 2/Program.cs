double InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}

double FindDistance(double x1,double x2, double y1, double y2, double z1, double z2)
{
    double pixelx = Math.Pow(x2-x1,2);
    double pixely = Math.Pow(y2-y1,2);
    double pixelz = Math.Pow(z2-z1,2);
    double distance = Math.Sqrt(pixelx+pixely+pixelz);
    return distance;
}

double x1 = InputInt("введите координату x1");
double x2 = InputInt("введите координату x2");
double y1 = InputInt("введите координату y1");
double y2 = InputInt("введите координату y2");
double z1 = InputInt("введите координату z1");
double z2 = InputInt("введите координату z2");
double distance = FindDistance(x1,x2,y1,y2,z1,z2);
System.Console.WriteLine($"расстояние между точками = {distance:F2}");


