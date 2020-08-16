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
        private readonly IResources _resourcesService;

        public PatientsController(IPatients patientService, IResources resourcesService)
        {
            _patientService = patientService;
            _resourcesService = resourcesService;
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

        // GET: api/patients/{patientID}/{resourceID}
        // Get specific patient with specific resource
        [HttpGet("{patientID}/{resourcesID}")]
        public async Task<ActionResult<PatientsDTO>> GetSpecificResourcesforOnePatient(int patientID, int resourcesID)
        {

            var patient = await _patientService.GetSpecificResourcesforOnePatient(patientID, resourcesID);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        // DELETE: api/patients/{id}
        // Delete specific patient by entering ID
        [HttpDelete("{id}")]
        public async Task<ActionResult<Patient>> DeletePatient(int id)
        {
            await _patientService.RemovePatient(id);

            return NoContent();
        }

        // PUT: api/patients/{id}
        // update specific patient by entering ID
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, Patient patient)
        {
            if (id != patient.ID)
            {
                return BadRequest();
            }

            await _patientService.UpdatePatient(id, patient);

            return NoContent();
        }
    }
}