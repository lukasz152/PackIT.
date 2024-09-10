using PackIT.Domain.Entities;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries
{
    public class SearchPackingLists : IQuery<IEnumerable<PackingList>>
    {
        public string SearchPhrase { get; set; }
    }
}
