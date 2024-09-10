using PackIT.Application.Dto;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries
{
    public class GetPackingList : IQuery<PackingListDto>
    {
        public Guid Id { get; set; }

    }
}
