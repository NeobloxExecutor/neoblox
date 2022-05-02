using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace neobloxBootstrapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            logoConsole();

            Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@(//(((((&@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@(///((((%&@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@...........@@@@@@@@@@@@@@@@@@@@@@@@@@@@@((//(((((&@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@,............&@@@@@@@@@@@@@@@@@@@@@@@@@@#(//(((((&@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@*,............,%@@@@@@@@@@@@@@@@@@@@@@@@#(/((((((&@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@/,............,,,%@@@@@@@@@@@@@@@@@@@@@@@(/((((((&&@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@,............,,,,,%@@@@@@@@@@@@@@@@@@@@@(((((((((&@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@,...........,,,,,,,,(@@@@@@@@@@@@@@@@@@@(((((((((&@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@*,.......%@/,,,,,,,,,,*@@@@@@@@@@@@@@@@@#((((((((&@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@*,.......%@@@(*,,,,,,,***@@@@@@@@@@@@@@@@((((((((&@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@#,.......%@@@@@@*,,,,,*****&@@@@@@@@@@@@@((((((((&&@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@,.......(&@@@@@@@/,,,*******%@@@@@@@@@@@#((((((((&@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@*........%@@@@@@@@@/,*********&@@@@@@@@@#((((((((&@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@*,.......%@@@@@@@@@@@/********//#@@@@@@@##(((((((&@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@**.......%@@@@@@@@@@@@@(******/////@@@@@@#(((((((&&@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@*.......%%@@@@@@@@@@@@@@#/***///////@@@@#((((((((&@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@*........%@@@@@@@@@@@@@@@@@///////////@@#((((((((&@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@*,.......%@@@@@@@@@@@@@@@@@@@(/////////((((((((((&@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@*,.......%@@@@@@@@@@@@@@@@@@@@@(///////((((((((((&@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@/*.......%@@@@@@@@@@@@@@@@@@@@@@@(////(((((((((((&&@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@*.......%%@@@@@@@@@@@@@@@@@@@@@@@@#(/((((((((((((&@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@*.......,%@@@@@@@@@@@@@@@@@@@@@@@@@@%((((((((((((&@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@*,......,%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@((((((((((&@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@/*.....,,%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@*....,,%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

            Thread.Sleep(2000);

            // Console managment

            void greenConsole()
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            void redConsole()
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            void logoConsole()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            void normalConsole()
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }

            void space()
            {
                Console.WriteLine("");
            }

            using (var client = new WebClient())
            {
                try
                {
                    space();

                    greenConsole();
                    Console.WriteLine("Downloading Neoblox...");
                    space();
                    normalConsole();

                    if (File.Exists("Neoblox.zip") != false)
                    {
                        redConsole();
                        Console.WriteLine("Neoblox.zip is already downloaded in this directory!");
                        space();
                        normalConsole();
                    }

                    if (File.Exists("Neoblox.zip") == false)
                    {
                        greenConsole();
                        client.DownloadFile("https://plextora.is-from.space/r/Neoblox.zip", "Neoblox.zip");
                        Thread.Sleep(2000);
                        Console.WriteLine("Successfully downloaded Neoblox!");
                        normalConsole();

                        space();
                    }
                }
                catch
                {
                    space();

                    redConsole();
                    Console.WriteLine("Failed to download Neoblox!");

                    Thread.Sleep(2000);

                    System.Environment.Exit(1);
                }
            }

            try
            {
                greenConsole();
                Console.WriteLine("Extracting Neoblox.zip....");

                Thread.Sleep(5000);

                string neobloxArchive = $"{AppDomain.CurrentDomain.BaseDirectory}\\Neoblox.zip";

                ZipFile.ExtractToDirectory(neobloxArchive, AppDomain.CurrentDomain.BaseDirectory);

                File.Delete(neobloxArchive);

                space();

                Console.WriteLine("Successfully extracted Neoblox.zip!");

                Thread.Sleep(2000);

                System.Diagnostics.Process.Start($"{AppDomain.CurrentDomain.BaseDirectory}\\Neoblox");
            }

            catch
            {
                space();

                redConsole();
                Console.WriteLine("Failed to extract Neoblox!");

                Thread.Sleep(2000);

                System.Environment.Exit(1);
            }
        }
    }
}
