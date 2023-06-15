using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolegame
{
    internal class ReadIntAnswer
    {
        public static int ReadIntAnswerFunction()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int answer))
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение. Пожалуйста, введите целое число:");
                }
            }
        }
    }
}
