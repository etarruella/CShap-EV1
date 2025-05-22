namespace VideoGame.Inventory;

public class MagicPotion : Potion
{
    private uint magic;

    public MagicPotion(string name, uint price, bool salable, int maxUses, int remaining, uint magic) : base(name, price, salable, maxUses, remaining, "Recharging")
    {
        this.magic = magic;
    }

    public override void Use(Player player)
    {
        if (remaining <= 0)
        {
            Console.WriteLine("Not remaining uses...");
            return;
        }

        remaining--;
        player.Magic += magic;
        Console.WriteLine($"({spell}) adding {magic} magic to {player.Name}.");
    }
}