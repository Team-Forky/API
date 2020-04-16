using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.Data;
using TeamForkyAPI.DTOs;
using TeamForkyAPI.Models.Interfaces;

namespace TeamForkyAPI.Models.Services
{

    public class PatientResourcesService : IPatientResources
    {
        //gain access to table properties
        private HospitalDbContext _context { get; }

        //constructor
        public PatientResourcesService(HospitalDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new patient with resources
        /// </summary>
        /// <param name="patientID">int</param>
        /// <param name="resourcesID">int</param>
        /// <returns></returns>
        public async Task AddPatientResources(int patientID, int resourcesID)
        {
            _context.PatientResources.Add(new PatientResources { PatientID = patientID, ResourcesID = resourcesID });
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get all patient resources
        /// </summary>
        /// <returns>patient resource DTO</returns>
        public async Task<List<PatientResourcesDTO>> GetAllPatientResources()
        {
            List<PatientResources> patientresources = await _context.PatientResources.ToListAsync();
            List<PatientResourcesDTO> pDTO = new List<PatientResourcesDTO>();
            foreach (var patient in patientresources)
            {
                PatientResourcesDTO PDTO = ConvertToDTO(patient);
                pDTO.Add(PDTO);
            }
            return pDTO;
        }

        /// <summary>
        /// Remove patient by entering patient ID
        /// </summary>
        /// <param name="ID">int</param>
        /// <returns></returns>
        public async Task RemovePatientResources(int ID)
        {
            PatientResources patientResources = await _context.PatientResources.FindAsync(ID);
            _context.PatientResources.Remove(patientResources);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Converting patient resource object to DTO
        /// </summary>
        /// <param name="patientResources"></param>
        /// <returns></returns>
        public PatientResourcesDTO ConvertToDTO(PatientResources patientResources)
        {
            PatientResourcesDTO pDTO = new PatientResourcesDTO()
            {
                ResourcesID = patientResources.ResourcesID,
                PatientID = patientResources.PatientID 
            };

            return pDTO;
        }
    }
}
