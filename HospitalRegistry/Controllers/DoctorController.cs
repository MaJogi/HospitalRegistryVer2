using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Open.Domain.Doctor;
using Open.Facade.Doctor;

namespace Open.HospitalRegistry.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorObjectsRepository repository;

        public DoctorController(IDoctorObjectsRepository r)
        {
            repository = r;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var l = await repository.GetObjectsList();
            return View(new DoctorViewModelsList(l));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateDoctor([Bind("PatientId,FirstName,LastName,IdCode,PhoneNumber,HierDate")]
            DoctorViewModel p)
        {
            //if (id != patient.PatientId) return NotFound();

            if (ModelState.IsValid)
            {

                var o = DoctorObjectFactory.Create(p.FirstName, p.LastName, p.IdCode, p.PhoneNumber, p.HireDate);
                o.DbRecord.Id = Guid.NewGuid().ToString();

                await repository.AddObject(o);
            }
            else
            {
                return View("CreatePatient");
            }

            return RedirectToAction(nameof(Index));
        }
        [Authorize]
        public IActionResult CreatePatient()
        {
            return View(new DoctorViewModel());
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {

            var o = await repository.GetObject(id);

            await repository.DeleteObject(o);

            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            //if (id == null) return NotFound();
            //Patient patient = db.Patients.Find(id);
            //if (patient == null) return NotFound();
            //return View("Delete", patient);
            var o = await repository.GetObject(id);
            //return View(new PatientViewModel()); 
            return View(DoctorViewModelFactory.Create(o));

        }
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            //if (id == null) return NotFound();
            //var patient = await db.Patients.SingleOrDefaultAsync
            //    (m => m.PatientId == id);
            //if (patient == null) return NotFound();

            var o = await repository.GetObject(id);
            return View(DoctorViewModelFactory.Create(o));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit([Bind("PatientId,FirstName,LastName,IdCode,Problem,PhoneNumber,ValidFrom,ValidTo")] DoctorViewModel p)
        {
            if (!ModelState.IsValid) return View(p);
            var o = await repository.GetObject(p.DoctorId);
            o.DbRecord.FirstName = p.FirstName;
            o.DbRecord.LastName = p.LastName;
            o.DbRecord.IdCode = p.IdCode;
            o.DbRecord.PhoneNumber = p.PhoneNumber;
            o.DbRecord.HireDate = p.HireDate /*?? DateTime.MinValue*/;
            await repository.UpdateObject(o);
            return RedirectToAction("Index");
        }

    }
}