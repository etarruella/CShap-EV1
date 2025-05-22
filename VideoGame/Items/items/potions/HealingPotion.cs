namespace VideoGame.Inventory;

public class HealingPotion : Potion
{
    private uint health;

    public HealingPotion(string name, uint price, bool salable, int maxUses, int remaining, uint health) : base(name, price, salable, maxUses, remaining, "Healing")
    {
        this.health = health;
    }

    public override void Use(Player player)
    {
        if (remaining <= 0)
        {
            Console.WriteLine("Not remaining uses...");
            return;
        }

        remaining--;
        player.Health += health;
        Console.WriteLine($"({spell}) adding {health} health to {player.Name}.");
    }
}