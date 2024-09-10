using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature
{
    internal sealed class LowTemperaturePolicy : IPackingItemsPolicy
    {
        public bool IsApplicable(PolicyData data)
       => data.Temperature < 10D;
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>()
        {
                new("winter hat",1),
                new("scarf",1),
                new("Gloves",1),
                new("Hoodie",1),
                new("warm jacket",1),
        };
    }
}
