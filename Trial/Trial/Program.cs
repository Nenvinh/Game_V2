namespace Trial;
using System;

public class Program
{
    static void intro()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("███████         █████         ██████         ███████");
        Thread.Sleep(1000);
        Console.WriteLine("██             ██   ██        ██   ██        ██     ");
        Thread.Sleep(1000);
        Console.WriteLine("█████          ███████        ██████         ███████");
        Thread.Sleep(1000);
        Console.WriteLine("██             ██   ██        ██   ██             ██");
        Thread.Sleep(1000);
        Console.WriteLine("███████ ██     ██   ██ ██     ██   ██ ██     ███████ ██");
        Thread.Sleep(1000);
        Console.WriteLine("Electronic action recording software");
        Console.WriteLine("Developed by Miliware");
        Console.WriteLine("V 0.86");
        Console.Write("Press any key to exit stand by mode...");
        Console.ReadKey();
        Console.Clear();
        Console. WriteLine("Nový uživatel detekován");
        Console. WriteLine("Příprava nové instance....");
        Thread.Sleep(1000);
        Console.WriteLine("Nahrávání programů.....");
        Thread.Sleep(1000);
        Console.WriteLine("Zjištování ůdajů o uživateli.....");
        Console.ResetColor();
        Console.Clear();
    }

    static string vyber_tridy()
    {
        
        
        while (true)
        {
            Console.WriteLine("zadejte vaše zaměření: ");
            Console.WriteLine("1. RIFLEMAN (začíná se armorem)");
            Console.WriteLine("2. COMMANDER  (začíná se více penězi)");
            Console.WriteLine("3. SPECIAL FORCES (začíná se více HP)");
            Console.WriteLine("4. MEDIC (léčí se více HP)");
            Console.Write("Zadejte: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Vybráno: RIFLEMAN");
                    Thread.Sleep(1000);
                    Console.Clear();
                    return "rifleman";
                    break;
                case 2:
                    Console.WriteLine("Vybráno: COMMANDER");
                    Thread.Sleep(1000);
                    Console.Clear();
                    return "commander";
                    break;
                case 3:
                    Console.WriteLine("Vybráno: SPECIAL FORCES");
                    Thread.Sleep(1000);
                    Console.Clear();
                    return "special_forces";
                    break;
                case 4:
                    Console.WriteLine("Vybráno: MEDIC");
                    Thread.Sleep(1000);
                    Console.Clear();
                    return "medic";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Neznámý vztup");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    Console.Clear();
                    break;
                    
            }
        
        
            
        }
        return "random";
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
        Console.Write($"Vítejte {jmeno}, ");
        return jmeno;
    }
    
    static int Main()
    {
        //intro();
        
        Player hrac = new Player("R", 1, 1, 1, 1, 1, 1,"Random","",'0','0','0','0');
        hrac.Name = zadani_jmena();
        hrac.Trida = vyber_tridy();
        Console.WriteLine(hrac.Get_info());
        
        
        return 0;
    }
}


