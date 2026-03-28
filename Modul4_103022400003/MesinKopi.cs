using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400003
{
    internal class MesinKopi
    {
        enum State { OFF, STANDBY, BREWING, MAINTENANCE }

        public static void Run()
        {
            State state = State.OFF;

            while (true)
            {
                Console.Write("Masukkan perintah: ");
                string command = Console.ReadLine();

                if (command == "exit") break;

                switch (state)
                {
                    case State.OFF:
                        if (command == "POWER_ON")
                        {
                            state = State.STANDBY;
                            Console.WriteLine("Mesin Off berubah menjadi Standby");
                        }
                        else
                        {
                            Console.WriteLine("Perubahan state tidak valid");
                        }
                        break;

                    case State.STANDBY:
                        if (command == "START_BREW")
                        {
                            state = State.BREWING;
                            Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                        }
                        else if (command == "START_MAINTENANCE")
                        {
                            state = State.MAINTENANCE;
                            Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
                        }
                        else if (command == "POWER_OFF")
                        {
                            state = State.OFF;
                            Console.WriteLine("Mesin Standby berubah menjadi Off");
                        }
                        else
                        {
                            Console.WriteLine("Perubahan state tidak valid");
                        }
                        break;

                    case State.BREWING:
                        if (command == "FINISH_BREW")
                        {
                            state = State.STANDBY;
                            Console.WriteLine("Mesin Brewing berubah menjadi Standby");
                        }
                        else
                        {
                            Console.WriteLine("Perubahan state tidak valid");
                        }
                        break;

                    case State.MAINTENANCE:
                        if (command == "FINISH_MAINTENANCE")
                        {
                            state = State.STANDBY;
                            Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                        }
                        else
                        {
                            Console.WriteLine("Perubahan state tidak valid");
                        }
                        break;
                }
            }
        }
    }
}