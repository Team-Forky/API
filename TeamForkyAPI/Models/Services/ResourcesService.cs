using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamForkyAPI.Data;
using TeamForkyAPI.DTOs;
using TeamForkyAPI.Models.Interfaces;

namespace TeamForkyAPI.Models.Services
{
    //inherit from interface
    public class ResourcesService : IResources
    {
        //gain access to table properties
        private HospitalDbContext _context { get; }

        public ResourcesService(HospitalDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create resource
        /// </summary>
        /// <param name="resources">resource object</param>
        /// <returns></returns>
        public async Task CreateResources(Resources resources)
        {
            _context.Add(resources);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Convert resource object to DTO and get all resources from database
        /// </summary>
        /// <returns></returns>
        public async Task<List<ResourcesDTO>> GetAllResources()
        {
            List<Resources> resources = await _context.Resources.ToListAsync();
            List<ResourcesDTO> rDTO = new List<ResourcesDTO>();
            foreach (var resource in resources)
            {
                ResourcesDTO RDTO = ConvertToDTO(resource);
                rDTO.Add(RDTO);
            }
            return rDTO;
        }

        /// <summary>
        /// Converted resource object to DTO and retrieve single patient with ID
        /// </summary>
        /// <param name="ID">int</param>
        /// <returns>resource DTO object</returns>
        public async Task<ActionResult<ResourcesDTO>> GetResourcesByID(int ID)
        {
            var resources = await _context.Resources.FindAsync(ID);
            ResourcesDTO rDTO = ConvertToDTO(resources);
            return rDTO;
        }

        /// <summary>
        /// Remove a specific resource by entering an ID
        /// </summary>
        /// <param name="ID">in</param>
        /// <returns></returns>
        public async Task RemoveResources(int ID)
        {
            Resources resources = await _context.Resources.FindAsync(ID);

            _context.Resources.Remove(resources);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update resource by entering an ID
        /// </summary>
        /// <param name="ID">int</param>
        /// <param name="resources">resource object</param>
        /// <returns></returns>
        public async Task UpdateResources(int ID, Resources resources)
        {
            _context.Entry(resources).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Convert resources object to DTO object
        /// </summary>
        /// <param name="resources">resources object</param>
        /// <returns>resources DTO object</returns>
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
