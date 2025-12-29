using System.Threading.Channels;

namespace test_casino
{
    internal class Program
    {
        public class LogoCasino
        {
            private void LogoCSN()
            {
                string[] lines = new string[]
                {
" ██████╗ █████╗ ███████╗██╗███╗   ██╗ ██████╗      █████╗ ██████╗ ███╗   ███╗██╗██████╗  █████╗ ██╗     ",
"██╔════╝██╔══██╗██╔════╝██║████╗  ██║██╔═══██╗    ██╔══██╗██╔══██╗████╗ ████║██║██╔══██╗██╔══██╗██║     ",
"██║     ███████║███████╗██║██╔██╗ ██║██║   ██║    ███████║██║  ██║██╔████╔██║██║██████╔╝███████║██║     ",
"██║     ██╔══██║╚════██║██║██║╚██╗██║██║   ██║    ██╔══██║██║  ██║██║╚██╔╝██║██║██╔══██╗██╔══██║██║     ",
"╚██████╗██║  ██║███████║██║██║ ╚████║╚██████╔╝    ██║  ██║██████╔╝██║ ╚═╝ ██║██║██║  ██║██║  ██║███████╗",
" ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝  ╚═╝╚═════╝ ╚═╝     ╚═╝╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝"

                };

                int startY = (Console.WindowHeight / 2) - (lines.Length / 2) - 2;
                int widthConsole = Console.WindowWidth;

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    int xStart = (widthConsole / 2) - (line.Length / 2);
                    if (xStart < 0) xStart = 0;
                    int y = startY + i;
                    if (y < 0) y = 0;
                    try
                    {
                        Console.SetCursorPosition(xStart, y);
                        Console.WriteLine(line);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Error!!");
                    }
                }
            }
        }
    }
}
