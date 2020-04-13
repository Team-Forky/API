using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models.Interfaces
{
    public interface IPatients
    {
        Task CreatePatient(Patients patients);
        Task UpdatePatient(int ID);
        Task GetAllPatients();
        Task GetPatientByID(int ID);
        Task RemovePatient(int ID);

    }
}
