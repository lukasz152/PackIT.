﻿using PackIT.Application.Dto;
using PackIT.Application.Queries;
using PackIT.Domain.Repositories;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries.Handlers
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        private readonly IPackingListRepository _repository;
        public GetPackingListHandler(IPackingListRepository repository)
        {
            _repository = repository;
        }

        public async Task<PackingListDto> HandleAsync(GetPackingList query)
        {
            var packingList = await _repository.GetAsync(query.Id);

            return packingList?.AsDto();
        }
    }
}
