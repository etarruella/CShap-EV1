namespace VideoGame.Inventory;

public class RestoreAll : Potion
{
    public RestoreAll(string name, uint price, bool salable, int maxUses, int remaining, string spell) : base(name, price, salable, maxUses, remaining, "Healing\nRecovering\nRecharging")
    {
    }

    public override void Use(Player player)
    {
        if (remaining <= 0)
        {
            Console.WriteLine("Not remaining uses...");
            return;
        }

        remaining--;
        Console.WriteLine(spell);
    }
}