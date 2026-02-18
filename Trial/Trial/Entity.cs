namespace Trial;

/*
_name <---- malé písmeno na začátku = privátní člen mother class
Name <---- velké písmeno na začátku = public člen mother class
Damage_ <- velké písmeno na začátku + podtržítko na konci = Polymorphism

*/

public interface IEntity
{
    void Get_Info_new();
    void Attack(Entity target);
    int Healing(Entity target);
}

public class Entity : IEntity
{
    private string name;
    private int damage;
    private int max_health;
    private int current_health;
    private int armor;
    private int heal;
    private int money;
    public bool is_alive = true;


    public string Name
    {
        get{return name;}
        set{
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Jméno nemůže být prázdné");
            }
            if (value.Length > 50)
            {
                throw new ArgumentException("Jméno je příliš dlouhý (max 50 znaků).");
            }
            else
            {
                name = value;
            }
            
        }
    }

    public int Damage
    {
        get{return damage;}
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Damage nemůže být méně než 0.");
            }
            else
            {
                damage = value;
            }
        }
    }

    public int Max_Health
    {
        get{return max_health;}
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Max Health nemůže být 0 a némě.");
            }
            else
            {
                max_health = value;
            }
        }
    }

    public int Current_Health
    {
        get{return current_health;}
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Hodnota Současné životy je 0 a méně.");
            }
            else
            {
                current_health = value;
            }
        }
    }

    public int Armor
    {
        get{return armor;}
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Armor nemůže být 0 a némě.");
            }
            else
            {
                armor = value;
            }
        }
    }

    public int Heal
    {
        get{return heal;}
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Heal nemůže být méně než 0.");
            }
            else
            {
                heal = value;
            }
        }
    }

    public int Money
    {
        get { return money; }
        set { money = value; }
    }
    
    
    public int Heal_(int heal, int current_health, int max_health)
    {
        current_health = current_health + heal;
        if (current_health > max_health)
        {
            current_health = max_health;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Overheal na max health {max_health} hp.");
            Console.ResetColor();
            return current_health;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Healing +{heal} hp.");
            Console.ResetColor();
            return current_health;
        }
    }


    virtual public string Get_info()
    {
        return $"Jméno: {name} | Útok: {damage} | Max životy: {max_health} | Souč. životy: {current_health} | Ochrana (armor): {armor} | Heal: {heal} | Money: {money} |";
    }
    
    public virtual void Get_Info_new()
    {
        Console.WriteLine($"============================================{name} stats============================================");
        Console.WriteLine($"Jméno: {name}");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Současné životy: {current_health} hp");
        Console.ResetColor();
        Console.WriteLine($"Armor: {armor}");
        Console.WriteLine($"Heal: {heal}");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Útok: -{damage} hp");
        Console.ResetColor();
    }
    
    
    //============================================ATTACK & UBÍRÁNÍ ŽIVOTA============================================
    
    public virtual int CalculateAttackDamage()
    {
        return Damage;
    }

    public virtual void TakeDamage(int damage)
    {
        int reduced = damage - Armor;
        if (reduced < 0)
        {
            reduced = 0;
            Console.WriteLine($"{name} má až moc tlustý armor.");
        }
        current_health -= reduced;
    }
    
    public virtual void Attack(Entity target)
    {
        int finalDamage = CalculateAttackDamage();
        target.TakeDamage(finalDamage);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{Name} zaútočil -{finalDamage} hp.");
        Console.WriteLine("");
        Console.ResetColor();
    }
    
    //============================================ATTACK & UBÍRÁNÍ ŽIVOTA============================================

    
    //============================================HEALING & PŘIDÁVÁNÍ ŽIVOTA============================================

    public virtual int get_Heal(int heal_points)
    {
        int added = Current_Health +  heal_points;
       if (added > Max_Health)
       {
           Console.ForegroundColor = ConsoleColor.DarkGreen;
           Console.WriteLine($"{Name} Overheal na max health {max_health} hp.");
           Console.ResetColor();
           return Current_Health = Max_Health;
       }
       else
       {
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine($"{Name} se léčí +{heal} hp.");
           Console.ResetColor();
           return Current_Health += heal_points;
       }
       
    }

    public virtual int Healing(Entity target)
    {
        get_Heal(target.Heal);
        return 0;
    }
    
    
    //============================================HEALING & PŘIDÁVÁNÍ ŽIVOTA============================================
    
    
    
    
    public bool Life_monitoring(int status)
    {
        if (status <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    //konstuktor
    public Entity(string name, int damage, int max_health, int current_health, int armor, int heal, int money)
    {
        this.Name = name;
        this.Damage = damage;
        this.Max_Health = max_health;
        this.Current_Health = current_health;
        this.Armor = armor;
        this.Heal = heal;
        this.Money = money;
    }
    
    
    
    
    
    
    
}