﻿using System.Threading.Tasks;

namespace VatanAPI.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
