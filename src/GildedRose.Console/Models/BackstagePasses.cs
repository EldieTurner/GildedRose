namespace GildedRose.Console.Models
{
    public class BackstagePasses : EnhancedItem
    {
        public override void UpdateQuality()
        {
            if (Quality < 50) Quality += 1;
            if (SellIn < 10 && Quality < 50) Quality += 1;
            if (SellIn < 5 && Quality < 50) Quality += 1;
            if (SellIn < 0) Quality = 0;
        }
    }
}
