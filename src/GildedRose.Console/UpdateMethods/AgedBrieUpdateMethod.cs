namespace GildedRose.Console.UpdateMethods
{
    public class AgedBrieUpdateMethod : BaseUpdateMethod
    {
        public AgedBrieUpdateMethod(Item item) : base(item) { }
        public override void UpdateQuality()
        {
            if(_item.Quality < 50) _item.Quality++;
            _item.SellIn--;
        }
    }
}
