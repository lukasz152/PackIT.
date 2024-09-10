using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands
{
    public record AddPackingItem(Guid packingListId, string Name, uint Quantity) : ICommand;
}
