int count = 0;
int sum = 0;
while (count < 10)
{
int n = new Random().Next(1, 10);
System.Console.WriteLine(n);
count++;
if (n>5)
{
sum = sum+1;
}
}

System.Console.WriteLine($"в наборе {sum} чисел больше 5");