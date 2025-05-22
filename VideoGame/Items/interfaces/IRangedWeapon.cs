namespace VideoGame.Inventory
{
    public interface IRangedWeapon
    {
        int MaxRange
        {
            get;
            set;
        }

        List<ItemType> ItemTypes
        {
            get { return new List<ItemType>{ItemType.RANGED_WEAPON}; }
        }
    }
}