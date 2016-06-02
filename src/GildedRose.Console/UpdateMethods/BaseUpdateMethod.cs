namespace GildedRose.Console.UpdateMethods
{
    public class BaseUpdateMethod
    {
        protected readonly Item _item;
        public BaseUpdateMethod(Item item)
        {
            _item = item;
        }
        public virtual void UpdateQuality()
        {
            if (_item.SellIn > 0) _item.Quality--;
            else _item.Quality -= 2;

            _item.SellIn--;

            if (_item.Quality < 0) _item.Quality = 0;
        }
    }
}
