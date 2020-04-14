using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.DTOs;

namespace TeamForkyAPI.Models.Interfaces
{
    public interface IPatients
    {
        //Create
        Task CreatePatient(Patient patient);

        //Read
        Task<List<PatientsDTO>> GetAllPatients();
        Task<PatientsDTO> GetPatientByID(int ID);

        //Update
        Task UpdatePatient(int ID, Patient patient);

        //Delete
        Task RemovePatient(int ID);
    }
}
