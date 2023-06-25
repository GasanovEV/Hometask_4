int number = GetNumberFromUser("Введите число: ", "Ошибка ввода");
int sum = SumNumber (number);

Console.WriteLine($"Сумма цифр числа {number}: -> {sum}");


int SumNumber(int number)
{
    int sum = 0;
    
    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(),out int userNumber))
            return userNumber;
        
        Console.WriteLine(errorMessage);
    }
}
