using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Glass
    {
        public int volume;
        public int currentAmt;
        public Glass()
        {
            string input;
            Console.WriteLine("Введите объем создаваемого стакана: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out int num))
                volume = Convert.ToInt32(input);
            else
                Console.WriteLine("Введено неверное значение");
        }

        public void AddLiq(int amount)
        {
            if(currentAmt+amount<=volume)
                currentAmt += amount;
            else
                Console.WriteLine("Заданный объем не помещается в стакан");
        }

        public void PrintAmt()
        {
            Console.WriteLine($"Объем стакана: {volume}\r\nСейчас в нем: {currentAmt}");
        }

        public void LossLiq(int amount)
        {
            if (currentAmt < amount)
            {
                Console.WriteLine($"Запрошенный объем больше имеющегося. Будет налито: {currentAmt}");
                currentAmt = 0;
            }
        }

    }
}
