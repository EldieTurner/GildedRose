namespace GildedRose.Console.Models
{
    public class Conjured : EnhancedItem
    {
        public override void UpdateQuality()
        {
            if (Quality > 0) Quality -= 2;
            if (Quality > 0 && SellIn <= 0) Quality -= 2;
        }
    }
}
