using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.DTOs;
using TeamForkyAPI.Models.Interfaces;

namespace TeamForkyAPI.Models.Services
{
    public class ResourcesService : IResources
    {
        public Task AddResources(Resources resources)
        {
            throw new NotImplementedException();
        }

        public Task DeleteResources(int ID)
        {
            throw new NotImplementedException();
        }

        public Task GetResourcesByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateResourceByID(int ID, Resources resources)
        {
            throw new NotImplementedException();
        }

        public ResourcesDTO ConvertToDTO(Resources resources)
        {
            ResourcesDTO rDTO = new ResourcesDTO()
            {
                ID = resources.ID,
                Name = resources.Name,
                Description = resources.Description,
                ResourcesType = resources.ResourcesType.ToString()
            };
        return rDTO;
        }
    }
}
