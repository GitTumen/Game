using System;
using consolegame;

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

                int num1 = Rand.GenerateRandomNumber();
                int num2 = Rand.GenerateRandomNumber();

                while (attemptsLeft > 0)
                {
                    Console.WriteLine($"Сложите два числа:\n{num1} + {num2} = ?");
                    Console.Write("Ответ: ");
                    int answer = ReadIntAnswer.ReadIntAnswerFunction();
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
    }
}
