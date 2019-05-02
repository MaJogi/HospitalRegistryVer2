using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Open.HospitalRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var l = await repository.GetObjectList();
            return View(new PatientViewModelsList(l));
        }
        //private readonly RegistryDbContext db;
        //public PatientController(RegistryDbContext db) { this.db = db; }
        //[Authorize]
        //public IActionResult Index()
        //{

        //    var model = new PatientListViewModel();
        //    var patients = Patients.Get(db);
        //    var list = new List<PatientViewModel>();
        //    foreach (var p in patients)
        //    {
        //        var patient = new PatientViewModel(p);
        //        patient.PatientId = p.PatientId;
        //        list.Add(patient);
        //    }
        //    model.Patients = list;
        //    model.FooterData = new FooterViewModel("Tallinn Hospital");

        //    return View("Index", model);
        //}
        //[Authorize]
        //public IActionResult AddNew()
        //{
        //    return View("CreatePatient", new CreatePatientViewModel());
        //}
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
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null) return NotFound();
        //    Patient patient = db.Patients.Find(id);
        //    if (patient == null) return NotFound();
        //    return View("Delete", patient);

        //}
        //[Authorize]
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var patient = await db.Patients.SingleOrDefaultAsync
        //        (m => m.PatientId == id);
        //    db.Patients.Remove(patient);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
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