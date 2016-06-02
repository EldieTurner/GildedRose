namespace GildedRose.Console.UpdateMethods
{
    public class BackstagePassesUpdateMethod : BaseUpdateMethod
    {
        public BackstagePassesUpdateMethod(Item item) : base(item) { }
        public override void UpdateQuality()
        {
            _item.Quality++;
            if (_item.SellIn <= 10) _item.Quality++;
            if (_item.SellIn <= 5) _item.Quality++;
            if (_item.SellIn <= 0) _item.Quality = 0;

            if (_item.Quality > 50) _item.Quality = 50;
            _item.SellIn--;
        }
    }
}
