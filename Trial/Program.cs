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
            Console.WriteLine("3. SPECIAL FORCES (útoky berou více HP)");
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
                    return "special";
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
        
        Player hrac = new Player("Random", 1, 1, 1, 1, 1, 1, 30, "Random", " ", '0', '0', '0', '0', '0');
        hrac.Name = zadani_jmena();
        hrac.Trida = vyber_tridy();
        
        //switch na zadávání dat tříd
        switch (hrac.Trida)
        {
            case "rifleman":
                hrac.Damage = 10;
                hrac.Damage_upgrade = '0';
                hrac.Max_Health = 20;
                hrac.Max_health_upgrade = '0';
                hrac.Current_Health = hrac.Max_Health;
                hrac.Armor = 10;
                hrac.Armor_upgrade = '1';
                hrac.Heal = 5;
                hrac.Heal_upgrade = '0';
                hrac.Money = 10;
                hrac.Ammo = 30;
                //hrac.Ammo_upgrade = '0';
                break;
            case "commander":
                hrac.Damage = 10;
                hrac.Damage_upgrade = '0';
                hrac.Max_Health = 20;
                hrac.Max_health_upgrade = '0';
                hrac.Current_Health = hrac.Max_Health;
                hrac.Armor = 0;
                hrac.Armor_upgrade = '0';
                hrac.Heal = 5;
                hrac.Heal_upgrade = '0';
                hrac.Money = 30;
                hrac.Ammo = 30;
                //hrac.Ammo_upgrade = '0';
                break;
            case "medic":
                hrac.Damage = 10;
                hrac.Damage_upgrade = '0';
                hrac.Max_Health = 20;
                hrac.Max_health_upgrade = '0';
                hrac.Current_Health = 20;
                hrac.Armor = 0;
                hrac.Armor_upgrade = '0';
                hrac.Heal = 10;
                hrac.Heal_upgrade = '1';
                hrac.Money = 10;
                hrac.Ammo = 30;
                //hrac.Ammo_upgrade = '0';
                break;
            case "special":
                hrac.Damage = 20;
                hrac.Damage_upgrade = '1';
                hrac.Max_Health = 20;
                hrac.Max_health_upgrade = '0';
                hrac.Current_Health = hrac.Max_Health;
                hrac.Armor = 10;
                hrac.Armor_upgrade = '0';
                hrac.Heal = 5;
                hrac.Heal_upgrade = '0';
                hrac.Money = 10;
                hrac.Ammo = 30;
                //hrac.Ammo_upgrade = '0';
                break;
        }
        
        /*
        Console.WriteLine(hrac.Get_info());
        hrac.Current_Health = hrac.Damage_(20, hrac.Current_Health, hrac.Armor);
        Console.WriteLine($"Damage: {hrac.Damage_(20, hrac.Current_Health, hrac.Armor)}");
        Console.WriteLine(hrac.Get_info());
        hrac.Current_Health = hrac.Heal_(hrac.Heal, hrac.Current_Health, hrac.Max_Health);
        Console.WriteLine($"Heal: {hrac.Heal_(hrac.Heal, hrac.Current_Health, hrac.Max_Health)}");
        Console.WriteLine(hrac.Get_info());
        */
        
        Console.Clear();
        Enemy random = new Enemy("Shotgun", 5, 10, 10, 5, 0, 5);
        Console.WriteLine(hrac.Get_info());
        Console.WriteLine(random.Get_info());
        
        hrac.Attack(random);
        
        Console.WriteLine(hrac.Get_info());
        Console.WriteLine(random.Get_info());

        
        
        /*while (hrac.is_alive)
        {
          
          hrac.is_alive = hrac.Life_monitoring(hrac.Current_Health); 
        
        
        
        
        
        
        }
        */
        
        
        
        return 0;
    }
}


