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
        //grabbing methods from interface
        private readonly IPatients _patientService;
        public PatientsController(IPatients patientService)
        {
            _patientService = patientService;
        }

        // POST: api/patients
        // Create a patient
        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            await _patientService.CreatePatient(patient);
            return CreatedAtAction("CreatePatient", new { id = patient.ID }, patient);
        }

        // GET: api/patients
        // Get all patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientsDTO>>> GetPatients() => await _patientService.GetAllPatients();

        // GET: api/patients/{patientID}
        // Get specific patient with resources by patient ID and resource ID
        [HttpGet("{patientID}")]
        public async Task<ActionResult<PatientsDTO>> GetPatientWithResources(int patientID)
        {

            var patient = await _patientService.GetPatientByID(patientID);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        // DELETE: api/patients/{id}
        // Delete specific patient by entering ID
        [HttpDelete("{id}")]
        public async Task<ActionResult<Patient>> DeletePatient(int ID)
        {
            await _patientService.RemovePatient(ID);

            return NoContent();
        }

        // PUT: api/patients/{id}
        // update specific patient by entering ID
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int ID, Patient patient)
        {
            if (ID != patient.ID)
            {
                return BadRequest();
            }

            await _patientService.UpdatePatient(ID, patient);

            return NoContent();
        }
    }
}