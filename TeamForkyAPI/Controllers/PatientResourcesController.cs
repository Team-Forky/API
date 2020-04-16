using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamForkyAPI.DTOs;
using TeamForkyAPI.Models;
using TeamForkyAPI.Models.Interfaces;

namespace TeamForkyAPI.Controllers
{
    [Route("api/patientresources")]
    [ApiController]
    public class PatientResourcesController : Controller
    {
        private readonly IPatientResources _context;
        public PatientResourcesController(IPatientResources context)
        {
            _context = context;
        }

        // CREATE: api/patientresources/{patientID}/{resourcesID}
        [HttpPost]
        public async Task<ActionResult<PatientResources>> AssignPatientResources(PatientResources patientResources)
        {
            await _context.AssignPatientResources(patientResources);
            
            return CreatedAtAction("AssignPatientResources", new {patientResources});
        }

        // GET: api/patientresources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientResourcesDTO>>> GetPatientResources() => await _context.GetAllPatientResources();

        // DELETE: api/patientresources/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<PatientResources>> DeletePatientResources(int ID)
        {
            await _context.RemovePatientResources(ID);
            return NoContent();
        }
    }
}