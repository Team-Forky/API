using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models.Interfaces
{
    public interface IResources
    {
        Task GetResourcesByID(int ID);
        Task UpdateResourceByID(int ID);
        Task AddResources(Resources resources);
        Task DeleteResources(int ID);
    }
}
