int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int numN = InputInt("введите число");
for (int i = 1; i <= numN; i++)
{
    int result = i * i * i;
    System.Console.Write($"{result}, ");
}