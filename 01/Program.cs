int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Reverse(int num)
{
char[] numrevers = num.ToString().ToCharArray();
Array.Reverse(numrevers);
string value = String.Concat<char>(numrevers);
int nums = Convert.ToInt32(value);
return nums;
}

int num = InputInt("введите число");
int num2 = Reverse(num);
if (num>99)
{
    if (num==num2)
    {
        System.Console.WriteLine($"число {num} палиндром");
    }
    else System.Console.WriteLine($"число {num} не палиндром");

}
else System.Console.WriteLine($"число {num} не палиндром");







