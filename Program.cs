/*
 * .Net Database Programming 156-101-20024-23
 * A3 - String Interpolation
 * Briana Lindquist
 * 02/11/2023
 */

namespace A3StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now,40:MMMM dd, yyyy}");
            Console.WriteLine($"{DateTime.Now:yyyy.MM.dd}");
            Console.WriteLine($"Day {DateTime.Now:dd} of {DateTime.Now:MMMM, yyyy}");
            Console.WriteLine($"Year: {DateTime.Now:yyyy}, Month: {DateTime.Now:MM}, Day: {DateTime.Now:dd}");
            Console.WriteLine($"{DateTime.Now,10:dddd}");
            Console.WriteLine($"{DateTime.Now,10:hh:mm tt}{DateTime.Now,10:dddd}");
            Console.WriteLine($"h:{DateTime.Now:HH}, m:{DateTime.Now:mm}, s:{DateTime.Now:ss}");
            Console.WriteLine($"{DateTime.Now:yyyy.MM.dd.HH.mm.ss}");
            Console.WriteLine();

            var pi = Math.PI;
            Console.WriteLine($"{pi:C2}");
            Console.WriteLine($"{pi,10:N3}");
        }
    }
}