using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Door
    {
        //
        public Boolean isOpened = false;
        public Boolean isLocked = false;
        public int password;
        public void ShowState()
        {
            if (isOpened)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Дверь открыта");
                Console.ResetColor();
            }
            else if (isLocked)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Дверь закрыта и заперта");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Дверь закрыта но не заперта");
                Console.ResetColor();
            }
        }
        public void ChangeState()
        {
            if(isLocked)
                Console.WriteLine("Сначала дверь необходимо разблокировать!");
            if (!isOpened && !isLocked)
            {
                isOpened = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Дверь открыта");
                Console.ResetColor();
            }
            else if (isOpened)
            {
                isOpened = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Дверь закрыта");
                Console.ResetColor();
            }
        }
        public void LockDoor()
        {
            if (isOpened)
                Console.WriteLine("Сначала дверь необходимо закрыть!");
            else if(isLocked)
                Console.WriteLine("Дверь уже заблокирована!");
            else
            {
                Console.WriteLine("Введите код: ");
                password= Convert.ToInt32(Console.ReadLine());
                isLocked = true;
            }
        }
        public void UnlockDoor()
        {
            if (!isLocked)
                Console.WriteLine("Дверь не заблокирована...");
            else
            {
                Console.WriteLine("Введите код: ");
                if (password == Convert.ToInt32(Console.ReadLine()))
                {
                    isLocked = false;
                    Console.WriteLine("Дверь разблокирована");
                }
                else
                    Console.WriteLine("Код не верный, в доступе отказано");
            }
        }
        
             

    }
}
