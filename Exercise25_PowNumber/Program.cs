﻿/* определяет переменные A и B через метод GetNumberFromUser*/
int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода");
int B = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода");

//Возведение числа А в степень B
double powNumbers = Math.Pow((double)A, (double)B);

//Выводит результат вычислений
Console.WriteLine($"Число{A} возведенное в степень {B}  -> {powNumbers}");

/*Считывание введенного числа и передача его в переменную, при введении
 не целочисленного значения выводится сообщение об ошибке*/

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
