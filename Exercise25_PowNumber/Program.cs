﻿//1.Input
int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода");
int B = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода");

//2.Calculation
double powNumbers = Math.Pow((double)A, (double)B);

//3.Output
Console.WriteLine($"Число{A} возведенное в степень {B}  -> {powNumbers}");

////////////////////////////////////

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
