namespace GildedRose.Console.UpdateMethods
{
    public class ConjuredUpdateMethod : BaseUpdateMethod
    {
        public ConjuredUpdateMethod(Item item) : base(item) { }
        public override void UpdateQuality()
        {
            if (_item.SellIn > 0) _item.Quality -= 2;
            else _item.Quality -= 4;

            _item.SellIn--;

            if (_item.Quality < 0) _item.Quality = 0;
        }
    }
}
