using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- CHƯƠNG TRÌNH GIT BASIC ---");
        Console.WriteLine("Nhấn phím 1: Hiện 'xin chào'");
        Console.WriteLine("Nhấn phím 2: Hiện 'tạm biệt'");
        
        while (true)
        {
            var key = Console.ReadKey(true).Key;
            
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("xin chào"); // Step 3
            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("tạm biệt"); // Step 6
            }
        }
    }
}