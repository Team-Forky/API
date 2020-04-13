using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.Models.Interfaces;

namespace TeamForkyAPI.Models.Services
{
    public class PatientService : IPatients
    {
        public Task CreatePatient(Patients patients)
        {
            throw new NotImplementedException();
        }

        public Task GetAllPatients()
        {
            throw new NotImplementedException();
        }

        public Task GetPatientByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task RemovePatient(int ID)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatient(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
