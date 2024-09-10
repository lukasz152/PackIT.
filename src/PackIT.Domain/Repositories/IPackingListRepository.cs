﻿using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Repositories
{
    public interface IPackingListRepository
    {
        Task<bool> ExistsAsync(PackingListName name);
        Task<PackingList> GetAsync(PackingListId id);
        Task AddAsync(PackingList packingList);
        Task UpadateAsync(PackingList packingList);
        Task DeleteAsync(PackingList packingList);
    }
}
