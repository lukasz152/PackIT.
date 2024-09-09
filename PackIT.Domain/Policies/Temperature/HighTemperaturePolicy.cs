using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature
{
    internal sealed class HighTemperaturePolicy : IPackingItemsPolicy
    {
        public bool IsApplicable(PolicyData data)
       => data.Temperature > 25D;
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>()
        {
                new("Hat",1),
                new("Sunglasses",10),
                new("Cream with UV filter",1)
        };
    }
}
