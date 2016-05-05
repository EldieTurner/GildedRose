using GildedRose.Console.Interfaces;

namespace GildedRose.Console.Models
{
   
    public class EnhancedItem : Item, IUpdateable
    {
        public int GetQuality() => Quality;

        public int GetSellIn() => SellIn;

        public virtual void UpdateQuality()
        {
            if (Quality > 0) Quality -= 1;
            if (Quality > 0 && SellIn <= 0) Quality -= 1;
        }

        public virtual void UpdateSellIn()
        {
            SellIn = SellIn - 1;
        }
    }
}
