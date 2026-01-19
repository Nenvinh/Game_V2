namespace Trial;
using System;

public class Program
{
    static void intro()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("███████         █████         ██████         ███████");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("██             ██   ██        ██   ██        ██     ");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("█████          ███████        ██████         ███████");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("██             ██   ██        ██   ██             ██");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("███████ ██     ██   ██ ██     ██   ██ ██     ███████ ██");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Electronic action recording software");
        Console.WriteLine("Developed by Miliware");
        Console.WriteLine("V 0.86");
        Console.WriteLine("Press any key to exit stand by mode...");
        Console.ReadKey();
        Console.Clear();
        Console. WriteLine("Nový uživatel detekován");
        Console. WriteLine("Příprava nové instance....");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Nahrávání programů.....");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Zjištování ůdajů o uživateli.....");
        Console.Clear();
    }

    static int vyber_tridy(string jmeno)
    {
        Console.Write($"Vítejte {jmeno} ");
        Console.WriteLine("Zadejte vaše zaměření: ");
        Console.WriteLine("1. RIFLEMAN (začíná se armorem)");
        Console.WriteLine("2. COMMANDER  (začíná se více penězi)");
        Console.WriteLine("3. SPECIAL FORCES (začíná se více HP)");
        Console.WriteLine("4. MEDIC (léčí se více HP)");
        Console.Write("Zadejte: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            default:
                Console.WriteLine("Neznámý vztup");
                break;
                    
        }
        
        
        return 0;
    }

    static string zadani_jmena()
    {
        string jmeno;
        while (true)
        {
            Console.WriteLine("Vitejte");
            Console.Write("Zadjete vase jmeno (bez mezer): ");
            jmeno = Console.ReadLine();
            Console.Write("Jste jsi jistý? (ano/ne): ");
            string confirmation = Console.ReadLine();
            Console.Clear();
            if (confirmation == "ano")
            {
                break;
            }
        }
        return jmeno;
    }
    
    static int Main()
    {
        intro();
        zadani_jmena();
        vyber_tridy(zadani_jmena());
        

        
        
        
        
        
        return 0;
    }
}


