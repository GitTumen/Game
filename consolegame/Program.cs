using System;

namespace SumGame
{
    class Program
    {
        const int TotalAttempts = 5;
        const int AttemptsPerGame = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру на сложение!");
            Console.WriteLine($"Вы должны ответить на {TotalAttempts} вопросов. У вас есть {AttemptsPerGame} попытки на всю игру.");

            int correctAnswers = 0;
            int attemptsLeft = AttemptsPerGame;
            for (int i = 0; i < TotalAttempts; i++)
            {
                Console.WriteLine($"\nЗадание {i + 1}:");

                int num1 = GenerateRandomNumber();
                int num2 = GenerateRandomNumber();

                while (attemptsLeft > 0)
                {
                    Console.WriteLine($"Сложите два числа:\n{num1} + {num2} = ?");
                    Console.Write("Ответ: ");
                    int answer = ReadIntAnswer();
                    if (answer == num1 + num2)
                    {
                        Console.WriteLine("Правильно!");
                        correctAnswers++;
                        break;
                    }
                    else
                    {
                        attemptsLeft--;
                        Console.WriteLine($"Неправильно! Осталось попыток: {attemptsLeft}.");
                        Console.WriteLine($"Правильный ответ: {num1 + num2}");
                        break;
                    }
                }
                if (attemptsLeft == 0)
                {
                    Console.WriteLine("Вы проиграли, попробуйте еще раз!");
                    break;
                }
            }
            if (correctAnswers >= 3)
            {
                Console.WriteLine($"\nВы победили! Вы ответили правильно на {correctAnswers} из {TotalAttempts} вопросов.");
            }
            Console.WriteLine("\nНажмите Enter, чтобы выйти...");
            Console.ReadLine();
        }

        static int GenerateRandomNumber()
        {
            Random rand = new Random();
            int num = rand.Next(1, 101);
            return num;
        }

        static int ReadIntAnswer()
        {
         while (true) {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int answer)) {
          return answer;
        } else {
          Console.WriteLine("Вы ввели некорректное значение. Пожалуйста, введите целое число:");
        }
      }
        }
    }
}
