using System;
using System.Collections.Generic;
using System.Text;
using Open.Domain.Doctor;

namespace Open.Facade.Doctor
{
    public class DoctorViewModelsList : List<DoctorViewModel>
    {
        public DoctorViewModelsList(IEnumerable<DoctorObject> l)
        {
            foreach (var e in l)
            {
                Add(DoctorViewModelFactory.Create(e));
            }
        }
    }
}
