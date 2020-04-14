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
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatients _patientService;
        public PatientsController(IPatients patientService)
        {
            _patientService = patientService;
        }

        // GET: api/Patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientsDTO>>> GetPatients() => await _patientService.GetAllPatients();


        // POST: api/Patients
        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            await _patientService.CreatePatient(patient);
            return CreatedAtAction("CreatePatient", new { id = patient.ID }, patient);
        }
    }
}