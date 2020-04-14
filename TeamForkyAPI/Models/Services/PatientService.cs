using TeamForkyAPI.Data;
using TeamForkyAPI.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamForkyAPI.DTOs;

namespace TeamForkyAPI.Models.Services
{
    public class PatientService : IPatients
    {
        private HospitalDbContext _context { get; }

        public PatientService(HospitalDbContext context)
        {
            _context = context;
        }

        public async Task CreatePatient(Patient patient)
        {
            _context.Add(patient);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PatientsDTO>> GetAllPatients()
        {
            List<Patient> patients = await _context.Patient.ToListAsync();
            List<PatientsDTO> pDTO = new List<PatientsDTO>();
            foreach (var patient in patients)
            {
                PatientsDTO PDTO = ConvertToDTO(patient);
                pDTO.Add(PDTO);
            }
            return pDTO;
        }

        public Task GetPatientByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task RemovePatient(int ID)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatient(int ID, Patient patient)
        {
            throw new NotImplementedException();
        }

        public PatientsDTO ConvertToDTO(Patient patient)
        {
            PatientsDTO pDTO = new PatientsDTO()
            {
                ID = patient.ID,
                Name = patient.Name,
                Birthday = patient.Birthday,
                CheckIn = patient.CheckIn,
                Status = patient.Status.ToString()
            };
            return pDTO;
        }
    }
}
