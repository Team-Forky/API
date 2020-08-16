using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamForkyAPI.DTOs;
using TeamForkyAPI.Models;
using TeamForkyAPI.Models.Interfaces;

namespace TeamForkyAPI.Controllers
{
    [Route("api/resources")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        // grab methods from interface
        private readonly IResources _resourcesService;

        public ResourcesController(IResources resourcesService)
        {
            _resourcesService = resourcesService;
        }

        // POST: api/resources
        // Create a resource
        [HttpPost]
        public async Task<ActionResult<Resources>> CreateResources(Resources resources)
        {
            await _resourcesService.CreateResources(resources);
            return CreatedAtAction("CreateResources", new { id = resources.ID }, resources);
        }

        // GET: api/resources
        // Get all resources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResourcesDTO>>> GetResources() => await _resourcesService.GetAllResources();



        // GET: api/resources/{id}
        // Get a specific resource by entering ID
        [HttpGet("{id}")]
        public async Task<ActionResult<ResourcesDTO>> GetResourcesByID(int id)
        {
            var resources = await _resourcesService.GetResourcesByID(id);

            if (resources == null)
            {
                return NotFound();
            }

            return resources;
        }

        // DELETE: api/resources/5
        // Delete a specific resource by entering ID
        [HttpDelete("{id}")]
        public async Task<ActionResult<Resources>> DeleteResources(int id)
        {
            await _resourcesService.RemoveResources(id);

            return NoContent();
        }

        // PUT: api/resources/5
        // Update specific resource by entering ID 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResources(int id, Resources resources)
        {
            if (id != resources.ID)
            {
                return BadRequest();
            }

            await _resourcesService.UpdateResources(id, resources);

            return NoContent();
        }
    }
}