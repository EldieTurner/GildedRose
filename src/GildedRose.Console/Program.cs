using System.Collections.Generic;
using GildedRose.Console.Interfaces;
using GildedRose.Console.Models;

namespace GildedRose.Console
{
    public class Program
    {
        IList<IUpdateable> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");
            var app = new Program()
                          {
                              Items = new List<IUpdateable>
                                {
                                    ItemFactory.CreateItem("+5 Dexterity Vest", 10, 20),
                                    ItemFactory.CreateItem("Aged Brie", 2, 0),
                                    ItemFactory.CreateItem("Elixir of the Mongoose", 5, 7),
                                    ItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", 0, 80),
                                    ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                                    ItemFactory.CreateItem("Conjured Mana Cake", 3, 6)
                                }
                          };
            app.UpdateQuality(app.Items);
            System.Console.ReadKey();
        }
        
        public void UpdateQuality(IList<IUpdateable> items)
        {
            foreach (var enhancedItem in items)
            {
                enhancedItem.UpdateSellIn();
                enhancedItem.UpdateQuality();
            }
        }
    }
    
   
   

    

    

    

    

   

}
