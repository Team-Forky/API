using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamForkyAPI.Models.Interfaces
{
    public interface IPatientResources
    {
        // PatientID
        Task GetResourcesFromOnePatient(int ID);

    }
}
