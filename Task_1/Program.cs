// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write($"{message} ");
    return int.Parse(Console.ReadLine());
}

int Reverse(int userNumber)
{
    int number = 0;
    while (userNumber > 0)
    {
        int i = userNumber % 10;
        number = number * 10 + i;
        userNumber /= 10;
    }
    return number;
}

bool ValidatePalyndrom(int valOne, int valTwo)
{
    return valOne == valTwo;
}

int userNumber = Prompt("Введите число");
int palyndrom = Reverse(userNumber);
if (ValidatePalyndrom(userNumber, palyndrom)) System.Console.WriteLine($"Число {userNumber} является палиндромом");
else System.Console.WriteLine($"Число {userNumber} не палиндром");