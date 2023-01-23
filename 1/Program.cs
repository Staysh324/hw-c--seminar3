int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool Check5s(int num)
{
    if (num < 100000 & num > 9999)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("введенное число не пятизначное");
        return false;
    }
}



int num = InputInt("введиите пятизначное число");
if (Check5s(num))
{
    int num1 = num / 1000;
    int num2 = num % 100;
    if (num1 / 10 == num % 10 & num1 % 10 == num2 / 10)
    {
        System.Console.WriteLine("число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("число не является палиндромом");
    }
}


