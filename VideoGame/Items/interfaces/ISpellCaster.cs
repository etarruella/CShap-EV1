namespace VideoGame.Inventory
{
    public interface ISpellCaster
    {
        string Spell
        {
            get;
            set;
        }

        List<ItemType> ItemTypes
        {
            get { return new List<ItemType>{ItemType.SPELL_CASTER}; }
        }
    }
}