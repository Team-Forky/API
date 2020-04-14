using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamForkyAPI.DTOs;

namespace TeamForkyAPI.Models.Interfaces
{
    public interface IResources
    {
        Task<ActionResult<ResourcesDTO>> GetResourcesByID(int ID);
        Task<List<ResourcesDTO>> GetAllResources();
        Task UpdateResources(int ID, Resources resources);
        Task CreateResources(Resources resources);
        Task RemoveResources(int ID);
    }
}
