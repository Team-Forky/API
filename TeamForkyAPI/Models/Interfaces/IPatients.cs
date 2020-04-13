using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models.Interfaces
{
    public interface IPatients
    {
        Task CreatePatient(Patient patient);
        Task UpdatePatient(int ID, Patient patient);
        Task <List<Patient>> GetAllPatients();
        Task GetPatientByID(int ID);
        Task RemovePatient(int ID);
    }
}
