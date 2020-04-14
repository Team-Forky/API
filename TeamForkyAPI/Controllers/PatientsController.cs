using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamForkyAPI.Data;
using TeamForkyAPI.Models;
using TeamForkyAPI.Models.Interfaces;



namespace TeamForkyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatients _context;
        public PatientsController(IPatients context)
        {
            _context = context;
        }

        // GET: api/Patients
        [HttpGet]
        public async Task<ActionResult<List<Patient>>> GetPatients()
        {
            return await _context.GetAllPatients();
        }
    }
}