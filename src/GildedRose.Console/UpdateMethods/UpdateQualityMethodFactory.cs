using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.UpdateMethods
{
    public class UpdateQualityMethodFactory
    {
        private static readonly Dictionary<string, Func<Item, BaseUpdateMethod>> MethodDictionary = GetMethodDictionary();
        private static readonly KeyValuePair<string, Func<Item, BaseUpdateMethod>> DefaultKeyValuePair =
            new KeyValuePair<string, Func<Item, BaseUpdateMethod>>("", item => new BaseUpdateMethod(item));
        public BaseUpdateMethod GetUpdateQualityMethod(Item item)
            => MethodDictionary
                .Where(x => item.Name.StartsWith(x.Key))
                .DefaultIfEmpty(DefaultKeyValuePair)
                .Single().Value(item);

        private static Dictionary<string, Func<Item, BaseUpdateMethod>> GetMethodDictionary()
            => new Dictionary<string, Func<Item, BaseUpdateMethod>>
            {
                {"Aged Brie", (item) => new AgedBrieUpdateMethod(item)},
                {"Backstage", (item) => new BackstagePassesUpdateMethod(item)},
                {"Sulfuras", (item)=> new SulfurasUpdateMethod(item)},
                {"Conjored", (item) => new ConjuredUpdateMethod(item)},
            };
    }
}
