namespace GildedRose.Console.Interfaces
{
    public interface IUpdateable
    {
        int GetQuality();
        int GetSellIn();
        void UpdateQuality();
        void UpdateSellIn();
    }
}