using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Wx4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Console.WriteLine(getConsole(4, "Midia Fisica"));
        }

        static string getConsole(int console, string path)
        {

            var consoleExists = Enum.IsDefined(typeof(ConsoleEnum), console);
            if (consoleExists)
            {
                if ((ConsoleEnum)console == ConsoleEnum.PS5)
                {
                    var chosenConsole = new PS5();
                    return chosenConsole.RunGame(new Game(ConsoleEnum.PS5.ToString(), path));
                }
                else if ((ConsoleEnum)console == ConsoleEnum.Switch)
                {
                    var chosenConsole = new Switch();
                    return chosenConsole.RunGame(new Game(ConsoleEnum.Switch.ToString(), path));
                }
                else if ((ConsoleEnum)console == ConsoleEnum.XboxOneX)
                {
                    var chosenConsole = new XboxOne();
                    return chosenConsole.RunGame(new Game(ConsoleEnum.XboxOneX.ToString(), path));
                }
                else if ((ConsoleEnum)console == ConsoleEnum.XboxSeriesX)
                {
                    var chosenConsole = new XboxSeriesX();
                    return chosenConsole.RunGame(new Game(ConsoleEnum.XboxSeriesX.ToString(), path));
                }
            }
            else
            {
                throw new NotImplementedException();
            }
            return "";
        }
    }
}
