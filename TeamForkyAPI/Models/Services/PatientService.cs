using TeamForkyAPI.Data;
using TeamForkyAPI.Data.Models;
using TeamForkyAPI.DTO;
using TeamForkyAPI.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models.Services
{
    public class PatientService : IPatients
    {
        private HospitalDbContext _context { get; }

        public PatientService(HospitalDbContext context)
        {
            _context = context;
        }

        public Task CreatePatient(Patient patients)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Patient>> GetAllPatients() => await _context.Patient.ToListAsync();

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
    }
}
