using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваше имя пользователя:");
        string userID = Console.ReadLine(); //Записываем имя пользователя в переменную userID
        string password = GeneratePassword(userID); // Передаем фунции значение с userID
        Console.Write("Сгенерированный пароль: " + password);
    }

    static string GeneratePassword(string userID)
    {
        Random randomPass = new Random();
        char b1 = (char)('a' + randomPass.Next(0, 26));//случайные строчные буква
        char b2 = (char)('a' + randomPass.Next(0, 26));
        char b3 = userID[randomPass.Next(userID.Length)];//случайная буква из userID
        char b4 = (char)('A' + randomPass.Next(0, 26));//случайная заглавная буква
        char b5 = (char)('A' + randomPass.Next(0, 26));
        int N = randomPass.Next(1, 101); // выбор случайного числа для N от 1 до 100 
        int result = (int)(Math.Pow(N, 4) % 100);
        string b6 = (result < 10) ? "0" : (result / 10).ToString();//символ для пароля на основе результата вычислений
        string b7 = (result < 10) ? result.ToString() : (result % 10).ToString();
        return $"{b1}{b2}{b3}{b4}{b5}{b6}{b7}"; //объеденение и возвращение всех символов
    }
}