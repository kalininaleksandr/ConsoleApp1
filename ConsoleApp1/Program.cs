using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperMenu;
            Console.WriteLine("Выберите задачу:\r\n1 - дверь\r\n2 - стакан\r\n3 - квадратное уравнение");
            upperMenu = Convert.ToInt32(Console.ReadLine());
            int menu = 0;
            string input;
            switch (upperMenu)
            {
                case 1:
                    Door dr = new Door();
                    dr.ShowState();
                    do
                    {
                        Console.WriteLine("1 - узнать состояние двери\r\n2 - закрыть/открыть\r\n3 - заблокировать\r\n4 - разблокировать\r\n9 для выхода");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int num))
                        {
                            menu = Convert.ToInt32(input);
                            if (menu == 1)
                                dr.ShowState();
                            if (menu == 2)
                                dr.ChangeState();
                            if (menu == 3)
                                dr.LockDoor();
                            if (menu == 4)
                                dr.UnlockDoor();
                        }
                        else
                            Console.WriteLine("Вводите только цифры");
                    }
                    while (menu != 9);
                    break;
                case 2:
                    Glass gl = new Glass();
                    do
                    {
                        Console.WriteLine("1 - узнать текущее количество\r\n2 - долить жидкость\r\n3 - вылить жидкость\r\n9 для выхода");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int num))
                        {
                            menu = Convert.ToInt32(input);
                            if (menu == 1)
                            {
                                gl.PrintAmt();
                            }
                            else if (menu == 2)
                            {
                                Console.WriteLine("Введите объем: ");
                                gl.AddLiq(Convert.ToInt32(Console.ReadLine()));
                            }
                            else if (menu == 3)
                            {
                                Console.WriteLine("Введите объем: ");
                                gl.LossLiq(Convert.ToInt32(Console.ReadLine()));
                            }
                        }
                        else
                            Console.WriteLine("Вводите только цифры");
                    }
                    while (menu != 9);
                    break;
                case 3:
                    SquareEquation eq = new SquareEquation();
                    do
                    {
                        Console.WriteLine("1 - вывести текущие значения коэффициентов\r\n2 - вывести количество корней\r\n3 - вывести корни\r\n4 - новые коэффициенты\r\n9 для выхода");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int num))
                        {
                            menu = Convert.ToInt32(input);
                            if (menu == 1)
                            {
                                eq.GetCurrValues();
                            }
                            else if (menu == 2)
                            {
                                Console.WriteLine("Количество корней уравнения: " + eq.GetNumOfRoots());
                            }
                            else if (menu == 3)
                            {
                                Console.WriteLine("Корни уравнения: " + eq.ShowRoots());
                            }
                            else if (menu ==4)
                            {
                               eq = new SquareEquation();
                            }
                        }
                        else
                            Console.WriteLine("Вводите только цифры");
                    }
                    while (menu != 9);
                    break;
            }
        }
    }
}
