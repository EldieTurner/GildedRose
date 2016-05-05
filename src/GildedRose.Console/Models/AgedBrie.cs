namespace GildedRose.Console.Models
{
    public class AgedBrie : EnhancedItem
    {
        public override void UpdateQuality()
        {
            if (Quality < 50) Quality++;
        }
    }
}
