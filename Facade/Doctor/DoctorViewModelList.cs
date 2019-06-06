using Open.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Facade.Doctor
{
    class DoctorViewModelList
    {
        public class PatientViewModelsList : List<DoctorViewModel>
        {
            public PatientViewModelsList(IEnumerable<DoctorObject> l)
            {
                foreach (var e in l)
                {
                    Add(DoctorViewModelFactory.Create(e));
                }
            }
        }
    }
}
