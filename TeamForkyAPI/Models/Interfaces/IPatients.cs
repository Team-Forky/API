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

        //Read specific patient with resources
        Task<PatientsDTO> GetPatientByID(int patientID);

        //Read All
        Task<List<PatientsDTO>> GetAllPatients();

        //Update
        Task UpdatePatient(int ID, Patient patient);

        //Delete
        Task RemovePatient(int ID);

        //Get 1 resource from 1 patient
        Task<PatientsDTO> GetSpecificResourcesforOnePatient(int patientID, int resourcesID);
    }
}
