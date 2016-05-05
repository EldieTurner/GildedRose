using System.Collections.Generic;
using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [TestCase("+5 Dexterity Vest", 10, 20, 19)] // At the end of each day our system lowers both values for every item
        [TestCase("+5 Dexterity Vest", 0, 20, 18)] //Once the sell by date has passed, Quality degrades twice as fast
        [TestCase("+5 Dexterity Vest", 10, 0, 0)] //The Quality of an item is never negative
        [TestCase("Aged Brie", 10, 0, 1)] //"Aged Brie" actually increases in Quality the older it gets
        [TestCase("Aged Brie", 10, 50, 50)] //The Quality of an item is never more than 50
        [TestCase("Sulfuras, Hand of Ragnaros", 10, 20, 20)] //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 11, 20, 21)] //increases by one when there are more than 10 days left
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 10, 20, 22)] //increases by two when there are fewer than 11 days left
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 5, 20, 23)] //increases by three when there are fewer than 6 days left
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 20, 0)] //decreases to zero after the concert
        public void QualityDecreasesAppropriately(string productName, int sellIn, int quality, int expectedQuality)
        {
            var items = new List<Item> { new Item { Name = productName, SellIn = sellIn, Quality = quality } };
            var program = new Program();
            program.UpdateQuality(items);
            Assert.AreEqual(expectedQuality, items[0].Quality);
        }

        [TestCase("+5 Dexterity Vest", 10, 20, 9)] // At the end of each day our system lowers both values for every item
        [TestCase("Sulfuras, Hand of Ragnaros", 10, 20, 10)] //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
        public void SellInDecreasesByOne(string productName, int sellIn, int quality, int expectedSellIn)
        {
            var items = new List<Item> { new Item { Name = productName, SellIn = sellIn, Quality = quality } };
            var program = new Program();
            program.UpdateQuality(items);
            Assert.AreEqual(expectedSellIn, items[0].SellIn);
        }
    }
}
