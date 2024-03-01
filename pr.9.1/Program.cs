using System;
using System.IO;

class TextCalculator
{
    static void Main()
    {
        string input1, input2, result;

        Console.WriteLine("Введите первую строку:");
        input1 = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        input2 = Console.ReadLine();

        result = input1 + input2;

        Console.WriteLine("Результат сцепления строк: " + result);

        LogActions(input1, input2, result);
        SaveResult(result);
    }

    static void LogActions(string input1, string input2, string result)
    {
        string logFileName = "log_" + DateTime.Today.ToString("yyyy-MM") + ".txt";

        using (StreamWriter sw = new StreamWriter(logFileName, true))
        {
            sw.WriteLine("Введенная строка 1: " + input1);
            sw.WriteLine("Введенная строка 2: " + input2);
            sw.WriteLine("Результат сцепления: " + result); 
        }

        Console.WriteLine("Лог сохранен в файле: " + logFileName);
    }

    static void SaveResult(string result)
    {
        string resultFileName = "Results/result_" + DateTime.Now.ToString("yyyy-MM") + ".txt";

        using (StreamWriter sw = new StreamWriter(resultFileName))
        {
            sw.WriteLine("Результат сцепления строк: " + result);
        }

        Console.WriteLine("Результат сохранен в файле: " + resultFileName);
        Console.ReadLine();
    }
}