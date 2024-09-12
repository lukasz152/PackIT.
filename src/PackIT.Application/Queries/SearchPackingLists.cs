using PackIT.Application.Dto;
using PackIT.Domain.Entities;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries
{
    public class SearchPackingLists : IQuery<IEnumerable<PackingListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
