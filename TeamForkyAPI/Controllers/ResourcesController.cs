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
        private readonly IResources _resourcesService;

        public ResourcesController(IResources resourcesService)
        {
            _resourcesService = resourcesService;
        }

        // GET: api/resources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResourcesDTO>>> GetResources() => await _resourcesService.GetAllResources();


        // POST: api/resources
        [HttpPost]
        public async Task<ActionResult<Resources>> CreateResources(Resources resources)
        {
            await _resourcesService.CreateResources(resources);
            return CreatedAtAction("CreateResources", new { id = resources.ID }, resources);
        }

        // GET: api/resources/5
        /// Get route that shows specific patient when user picks
        [HttpGet("{id}")]
        public async Task<ActionResult<ResourcesDTO>> GetResourcesByID(int ID)
        {
            var resources = await _resourcesService.GetResourcesByID(ID);

            if (resources == null)
            {
                return NotFound();
            }

            return resources;
        }

        // DELETE: api/resources/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Resources>> DeleteResources(int ID)
        {
            await _resourcesService.RemoveResources(ID);

            return NoContent();
        }

        // PUT: api/resources/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResources(int ID, Resources resources)
        {
            if (ID != resources.ID)
            {
                return BadRequest();
            }

            await _resourcesService.UpdateResources(ID, resources);

            return NoContent();
        }
    }
}