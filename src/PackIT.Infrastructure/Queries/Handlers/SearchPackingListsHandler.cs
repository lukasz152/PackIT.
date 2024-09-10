using PackIT.Application.Dto;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries.Handlers
{
    public class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
    {
        public Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
        {
            return null;
        }
    }
}
