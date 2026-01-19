namespace Trial;

public class Player : Entity
{
    private int ammo;
    private string trida;
    private string action;
    private char damage_upgrade;
    private char max_health_upgrade;
    private char armor_upgrade;
    private char  heal_upgrade;

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
    
    public override string Get_info()
    {
        return base.Get_info() + $" Trida: {trida} | Action: {action}";
    }

    
    
    
    public Player(string name, int damage, int max_health, int current_health, int armor, int heal, int ammo, string trida, string action, char damage_upgrade, char max_health_upgrade, char armor_upgrade, char  heal_upgrade) :
        base(name, damage, max_health, current_health, armor, heal)
    {
        this.Name = name;
        this.Damage = damage;
        this.Max_Health = max_health;
        this.Current_Health = current_health;
        this.Armor = armor;
        this.Heal = heal;
        this.Ammo = ammo;
        this.Trida = trida;
        this.Action = action;
        this.Damage_upgrade = damage_upgrade;
        this.Max_health_upgrade = max_health_upgrade;
        this.Armor_upgrade = armor_upgrade;
        this.Heal_upgrade = heal_upgrade;
        
    }
    
    
    
}