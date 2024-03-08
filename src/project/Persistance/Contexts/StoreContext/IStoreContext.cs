using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Contexts.StoreContext
{
    public interface IStoreContext
    {
        Task<Store> GetCurrentStoreAsync();
        Store GetCurrentStore();
        Task<int> GetActiveStoreScopeConfigurationAsync();
    }
}