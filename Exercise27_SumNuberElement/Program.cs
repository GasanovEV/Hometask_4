/*Считывание введенного числа и передача его в переменную, при введении
 не целочисленного значения выводится сообщение об ошибке*/
int number = GetNumberFromUser("Введите число: ", "Ошибка ввода");

//Вычисление суммы всех цифр числа
int sum = SumNumber (number);

//Выводит результат вычислений
Console.WriteLine($"Сумма цифр числа {number}: -> {sum}");

//Производит суммирование всех цифр введенного числа
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
