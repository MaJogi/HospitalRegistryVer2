using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Open.Core;
using Open.Domain.Patient;

namespace Open.Domain.Doctor
{
    public interface IDoctorPatientObjectsRepository : IObjectsRepository<PatientDoctorObject>
    {
        Task LoadDoctors(PatientObject patient);
        Task LoadPatients(DoctorObject doctor);
    }
}
