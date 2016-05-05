using GildedRose.Console.Interfaces;

namespace GildedRose.Console.Models
{
    public class ItemFactory
    {
        public static IUpdateable CreateItem(string name, int sellIn, int quality)
        {
            if (name.Contains("Aged Brie")) return new AgedBrie() { Name = name, SellIn = sellIn, Quality = quality };
            if (name.Contains("Sulfuras")) return new Sulfuras() { Name = name, SellIn = sellIn, Quality = quality };
            if (name.Contains("Backstage passes")) return new BackstagePasses() { Name = name, SellIn = sellIn, Quality = quality };
            if (name.Contains("Conjured")) return new Conjured() { Name = name, SellIn = sellIn, Quality = quality };
            return new EnhancedItem() { Name = name, SellIn = sellIn, Quality = quality };
        }
    }
}
