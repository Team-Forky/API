﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.DTOs;

namespace TeamForkyAPI.Models.Interfaces
{
    public interface IPatientResources
    {
        // Create
        Task AddPatientResources(int patientID, int resourcesID);

        //Read all
        Task<List<PatientResourcesDTO>> GetAllPatientResources();

        //Delete
        Task RemovePatientResources(int ID);
    }
}
