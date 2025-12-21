namespace Trial;

public class Entity
{
    int health;
    int maxHealth;
    int damage;
    int armor;
    int ammo;
    int maxAmmo;
    int reload;
    string name;
    string Class;
    
    
    public Entity(int health, int maxHealth, int damage, int armor, int ammo, int maxAmmo, int reload, string name, string Class)
    {
        this.health = health;
        this.maxHealth = maxHealth;
        this.damage = damage;
        this.armor = armor;
        this.ammo = ammo;
        this.maxAmmo = maxAmmo;
        this.reload = reload;
        this.name = name;
        this.Class = Class;
    }
}