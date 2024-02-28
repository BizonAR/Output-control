using System;

namespace OutputControl
{
	internal class OutputControl
	{
		static void Main(string[] args)
		{
			string input = "";
			string commandExit = "exit";

			while (input != commandExit)
			{
				Console.Write($"Введите слово или {commandExit} для завершения программы: ");
				input = Console.ReadLine();
				Console.WriteLine($"Вы ввели: {input}");
			}

			Console.WriteLine("Программа завершена.");
		}
	}
}
