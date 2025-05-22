namespace VideoGame.Inventory
{
    public interface ILimitedUse
    {
        int Remaining
        {
            get;
            set;
        }

        List<ItemType> ItemTypes
        {
            get { return new List<ItemType>{ItemType.LIMITED_USE}; }
        }
    }
}