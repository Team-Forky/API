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
        //Create
        Task CreateResources(Resources resources);

        //Read
        Task<ActionResult<ResourcesDTO>> GetResourcesByID(int ID);
        Task<List<ResourcesDTO>> GetAllResources();

        //Update
        Task UpdateResources(int ID, Resources resources);

        //Delete
        Task RemoveResources(int ID);
    }
}
