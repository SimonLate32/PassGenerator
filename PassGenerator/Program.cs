using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите идентификатор пользователя:");
        string userId = Console.ReadLine();

        string password = GenPass(userId);
        Console.Write("Сгенерированный пароль: " + password);
    }

    static string GenPass(string userId)
    {
        Random rand = new Random();

        // Получаем b1 и b2 из идентификатора пользователя
        char b1 = userId[rand.Next(userId.Length)];
        char b2 = userId[rand.Next(userId.Length)];

        // Получаем N^2 (в качестве примера возьмем случайное число от 1 до 100)
        int N = rand.Next(1, 101);
        int N2 = N * N;

        // Вычисляем b3 по заданной формуле
        int b3 = N2 % 10;

        // Генерируем остальные символы
        int b4 = rand.Next(0, 10);
        char[] SpecChar = { '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*' };
        char b5 = SpecChar[rand.Next(SpecChar.Length)];
        char b6 = (char)rand.Next(97, 123); // случайная малая буква английского алфавита

        // Собираем пароль из полученных символов
        string password = string.Concat(b1, b2, b3, b4, b5, b6);

        return password;
    }
}