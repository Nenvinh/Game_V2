namespace Trial;

public class Enemy : Entity
{
    public Enemy(string name, int damage, int max_health, int current_health, int armor, int heal) :
        base(name, damage, max_health, current_health, armor, heal)
    {
        this.Name = name;
        this.Damage = damage;
        this.Max_Health = max_health;
        this.Current_Health = current_health;
        this.Armor = armor;
        this.Heal = heal;
    }
}