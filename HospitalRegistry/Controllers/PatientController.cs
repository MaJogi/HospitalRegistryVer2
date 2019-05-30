using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Open.Facade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Open.Data.Patient;
using Open.Domain.Patient;
using Open.HospitalRegistry.Data;
using Open.Infra;
using Open.Facade.Patient;

namespace Open.HospitalRegistry.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientObjectsRepository repository;

        public PatientController(IPatientObjectsRepository r)
        {
            repository = r;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var l = await repository.GetObjectsList();
            return View(new PatientViewModelsList(l));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreatePatient([Bind("PatientId,FirstName,LastName,IdCode,Problem,PhoneNumber,ValidFrom,ValidTo")]
            PatientViewModel p)
        {
            //if (id != patient.PatientId) return NotFound();
            
            if (ModelState.IsValid)
            {
                
                var o = PatientObjectFactory.Create(p.FirstName, p.LastName, p.IdCode, p.Problem, p.PhoneNumber, p.ValidFrom,
                    p.ValidTo);
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
            return View(new PatientViewModel());
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
            return View(PatientViewModelFactory.Create(o));

        }
        public async Task<IActionResult> Edit(string id)
        {
            //if (id == null) return NotFound();
            //var patient = await db.Patients.SingleOrDefaultAsync
            //    (m => m.PatientId == id);
            //if (patient == null) return NotFound();

            var o = await repository.GetObject(id);
            return View(PatientViewModelFactory.Create(o));
        }

        [HttpPost] [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("PatientId,FirstName,LastName,IdCode,Problem,PhoneNumber,ValidFrom,ValidTo")] PatientViewModel p)
        {
            if (!ModelState.IsValid) return View(p);
            var o = await repository.GetObject(p.PatientId);
            o.DbRecord.FirstName = p.FirstName;
            o.DbRecord.LastName = p.LastName;
            o.DbRecord.IdCode = p.IdCode;
            o.DbRecord.Problem = p.Problem;
            o.DbRecord.PhoneNumber = p.PhoneNumber;
            o.DbRecord.ValidFrom = p.ValidFrom /*?? DateTime.MinValue*/;
            o.DbRecord.ValidTo = p.ValidTo /*?? DateTime.MaxValue*/;
            await repository.UpdateObject(o);
            return RedirectToAction("Index");
        }

        //[Authorize]
        //[ValidateAntiForgeryToken]
        //public IActionResult SavePatient(Patient p, string BtnSubmit)
        //{

        //    if (BtnSubmit != "Save Patient") return RedirectToAction("Index");
        //    if (!ModelState.IsValid) return View("CreatePatient", new CreatePatientViewModel());
        //    return save(p);
        //}
        //[Authorize]
        //private IActionResult save(Patient p)
        //{
        //    Patients patients = new Patients();
        //    patients.Save(p, db);
        //    return RedirectToAction("Index");
        //}
        //[Authorize]
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null) return NotFound();
        //    var patient = await db.Patients.SingleOrDefaultAsync
        //        (m => m.PatientId == id);
        //    if (patient == null) return NotFound();
        //    return View("Edit", patient);
        //}
        //[Authorize]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("PatientId,FirstName,LastName,IdCode,Problem,ValidFrom,ValidTo")]
        //    Patient patient)
        //{
        //    if (id != patient.PatientId) return NotFound();
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            db.Update(patient);
        //            await db.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PatientExists(patient.PatientId)) return NotFound();
        //            throw;
        //        }

        //        return RedirectToAction(nameof(Index));
        //    }

        //    return View(patient);
        //}

        //private bool PatientExists(int id)
        //{
        //    return db.Patients.Any(e => e.PatientId == id);


        //}

    }
}