namespace VideoGame.Inventory;

public class StaminaPotion : Potion
{

    private uint stamina;

    public StaminaPotion(string name, uint price, bool salable, int maxUses, int remaining, uint stamina) : base(name, price, salable, maxUses, remaining, "Recovering")
    {
        this.stamina = stamina;
    }

    public override void Use(Player player)
    {
        if (remaining <= 0)
        {
            Console.WriteLine("Not remaining uses...");
            return;
        }

        remaining--;
        player.Stamina += stamina;
        Console.WriteLine($"({spell}) adding {stamina} stamina to {player.Name}.");
    }
}