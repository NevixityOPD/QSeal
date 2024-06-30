using System.Runtime.InteropServices;
using Spectre.Console;

namespace QSeal
{
    public static class QSealMain
    {
        public static void Main(string[] args)
        {
            //TODO : add windows support so it can cross platform
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) { AnsiConsole.MarkupLine("[red]QSeal does not have a window support yet! I'm sorry :([/]"); Environment.Exit(0); }

            Console.Clear();

            if(args.Length == 0)
            {
                Console.SetCursorPosition((Console.WindowWidth - "█▀█ █▀ █▀▀ ▄▀█ █".Length) / 2, Console.CursorTop + 5);
                AnsiConsole.MarkupLine("[rgb(255,255,255)]█▀█ █▀ █▀▀ ▄▀█ █[/]");
                Console.SetCursorPosition((Console.WindowWidth - " ▀▀█ ▄█ ██▄ █▀█ █▄▄".Length) / 2, Console.CursorTop);
                AnsiConsole.MarkupLine("[rgb(255,255,255)] ▀▀█ ▄█ ██▄ █▀█ █▄▄[/]");
                Console.SetCursorPosition((Console.WindowWidth - "Console file manager by nevixity_".Length) / 2, Console.CursorTop + 1);
                AnsiConsole.MarkupLine("[rgb(255,255,255)]Console file manager by[/] [rgb(0,255,255)]nevixity_[/]");
                Console.CursorTop += 6;

                Console.SetCursorPosition((Console.WindowWidth - "<Ctrl + Esc>: Exit".Length) / 2, Console.CursorTop);
                AnsiConsole.MarkupLine("[rgb(255,255,255)]<Ctrl + Esc>: Exit[/]");
            
                Console.SetCursorPosition((Console.WindowWidth - "<Ctrl + D>: Go to a specific directory".Length) / 2, Console.CursorTop);
                AnsiConsole.MarkupLine("[rgb(255,255,255)]<Ctrl + D>: Go to a specific directory[/]");

                Console.SetCursorPosition((Console.WindowWidth - "<Esc>: Enter command mode".Length) / 2, Console.CursorTop);
                AnsiConsole.MarkupLine("[rgb(255,255,255)]<Esc>: Enter command mode[/]");
                Console.CursorTop += 2;

                short currentyPos = (short)Console.CursorTop;
                Thread blinkingText = new Thread(() => {
                    while(true)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - "Press any key to continue...".Length) / 2, currentyPos);
                        AnsiConsole.Markup("[rgb(255,0,0)]Press any key to continue...[/]");
                        Thread.Sleep(500);
                        Console.SetCursorPosition((Console.WindowWidth - "Press any key to continue...".Length) / 2, currentyPos);
                        AnsiConsole.Markup("[rgb(255,255,255)]Press any key to continue...[/]");
                        Thread.Sleep(500);
                    }
                });
                blinkingText.Start();
                Console.ReadKey(true);
                blinkingText.Interrupt();
            }
            else
            {
                //TODO : add cli command
            }

        }
    }
}