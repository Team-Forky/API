using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamForkyAPI.Data;
using TeamForkyAPI.DTOs;
using TeamForkyAPI.Models;
using TeamForkyAPI.Models.Interfaces;



namespace TeamForkyAPI.Controllers
{
    [Route("api/patients")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatients _patientService;
        public PatientsController(IPatients patientService)
        {
            _patientService = patientService;
        }

        // GET: api/patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientsDTO>>> GetPatients() => await _patientService.GetAllPatients();


        // POST: api/patients
        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            await _patientService.CreatePatient(patient);
            return CreatedAtAction("CreatePatient", new { id = patient.ID }, patient);
        }

        // GET: api/Hotels/5
        /// Get route that shows specific Hotel when user picks
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientsDTO>> GetPatient(int ID)
        {
            var patient = await _patientService.GetPatientByID(ID);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }
    }
}