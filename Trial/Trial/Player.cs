namespace Trial;

public interface IPlayer
{
    void Obchod();
}
public class Player : Entity
{
    private int ammo;
    private string trida;
    private string action;
    private char damage_upgrade;
    private char max_health_upgrade;
    private char armor_upgrade;
    private char  heal_upgrade;
    private char ammo_upgrade;

    public int Ammo
    {
        get{ return ammo; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Hodnota Ammo nesmí být menší nebor rovno 0.");
            }
            else
            {
                ammo = value; 
            }
        }
    }
    
    public string Trida
    {
        get{ return trida; }
        set{ trida = value; }
    }

    public string Action
    {
        get{ return action; }
        set{ action = value; }
    }

    public char Damage_upgrade
    {
        get{ return damage_upgrade; }
        set{ damage_upgrade = value; }
    }

    public char Max_health_upgrade
    {
        get{ return max_health_upgrade; }
        set{ max_health_upgrade = value; }
    }

    public char Armor_upgrade
    {
        get{ return armor_upgrade; }
        set{ armor_upgrade = value; }
    }

    public char Heal_upgrade
    {
        get{ return heal_upgrade; }
        set{ heal_upgrade = value; }
    }

    public char Ammo_upgrade
    {
        get{ return ammo_upgrade; }
        set{ ammo_upgrade = value; }
    }
    
    public override string Get_info()
    {
        return base.Get_info() + $" Trida: {trida} | Ammo: {ammo} | Action: {action}";
    }
    
    public override void Get_Info_new()
    {
        base.Get_Info_new();
        Console.WriteLine($"Ammo count: {ammo}");
        Console.WriteLine($"Trida: {trida}");
        Console.WriteLine($"============================================{Name} stats============================================");
        Console.WriteLine("");
    }

    public void Obchod()
    {
        while (Action != "exit")
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("VÍTEJTE V OBCHODĚ");
            Console.WriteLine("napište: 'exit' pro odchod.");
            Console.WriteLine($"Peníze: {Money}k $");
            Console.WriteLine($"============================================{Name}'s upgrades============================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Vylepšení maximálního zdraví (max. 10): {Max_health_upgrade}");
            Console.WriteLine($"Vylepšení léčení (max. 10): {Heal_upgrade}");
            Console.WriteLine($"Vylepšení armor (max. 10): {Armor_upgrade}");
            Console.WriteLine($"Vylepšení kapacity nábojů (max. 10): {Ammo_upgrade}");
            Console.WriteLine($"Vylepšení útoku (max. 10): {Damage_upgrade}");
            Console.WriteLine("============================================CONSUMEABLES============================================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Současné zdraví  (max. {Max_Health}): {Current_Health}");
            Console.WriteLine($"Současné množství nábojů: {Ammo}");
            Console.ResetColor();
            Console.WriteLine($"============================================{Name}'s upgrades============================================");
            Console.Write("Nákup: ");
            Action = Console.ReadLine();
            
        }
        
    }
    
    //Konstruktor
    public Player(string name, int damage, int max_health, int current_health, int armor, int heal, int money, int ammo, string trida, string action, char damage_upgrade, char max_health_upgrade, char armor_upgrade, char  heal_upgrade, char ammo_upgrade) :
        base(name, damage, max_health, current_health, armor, heal, money)
    {
        this.Name = name;
        this.Damage = damage;
        this.Max_Health = max_health;
        this.Current_Health = current_health;
        this.Armor = armor;
        this.Heal = heal;
        this.Money = money;
        this.Ammo = ammo;
        this.Trida = trida;
        this.Action = action;
        this.Damage_upgrade = damage_upgrade;
        this.Max_health_upgrade = max_health_upgrade;
        this.Armor_upgrade = armor_upgrade;
        this.Heal_upgrade = heal_upgrade;
        this.Ammo_upgrade = ammo_upgrade;
        
        
    }
    
    
    
}