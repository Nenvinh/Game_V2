namespace Trial;

/*
_name <---- malé písmeno na začátku = privátní člen mother class
Name <---- velké písmeno na začátku = public člen mother class
Damage_ <- velké písmeno na začátku + podtržítko na konci = Polymorphism

*/

public class Entity
{
    private string name;
    private int damage;
    private int max_health;
    private int current_health;
    private int armor;
    private int heal;
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
            if (value <= 0)
            {
                Console.WriteLine("Damage nemůže být 0.");
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
                Console.WriteLine("Damage nemůže být 0 a némě.");
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
            if (value <= 0)
            {
                Console.WriteLine("Damage nemůže být 0 a némě.");
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
            if (value <= 0)
            {
                Console.WriteLine("Damage nemůže být 0 a némě.");
            }
            else
            {
                armor = value;
            }
        }
    }
    
    
    public virtual int Damage_(int damage, int current_health, int armor)
    {
        current_health = current_health + armor - damage;
        return current_health;
    }

    
    public virtual int Heal_(int heal, int current_health, int max_health)
    {
        current_health =+ heal;
        if (current_health > max_health)
        {
            current_health = max_health;
            return current_health;
            Console.WriteLine($"Overheal na max health {max_health} hp.");
        }
        else
        {
            return current_health;
            Console.WriteLine($"Healing +{heal} hp.");
        }
    }


    virtual public string Get_info()
    {
        return $"Jméno: {name} | Útok: {damage} | Max životy: {max_health} | Souč. životy: {current_health} | Ochrana: {armor} | Heal: {heal} |";
    }
    
    public Entity(string name, int damage, int max_health, int current_health, int armor, int heal)
    {
        this.Name = name;
        this.Damage = damage;
        this.Max_Health = max_health;
        this.Current_Health = current_health;
        this.Armor = armor;
        this.Heal = heal;
    }
    
    
    
    
    
    
    
}