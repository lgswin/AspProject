using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeartRateTracker.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HeartRateTracker.Controllers
{
    public class HeartRateController : Controller
    {
        private HeartRateDbContext _heartRateDbContext;

        public HeartRateController(HeartRateDbContext heartRateDbContext)
        {
            _heartRateDbContext = heartRateDbContext;
        }

        [HttpGet("/heart-rate-measurements")]
        public IActionResult GetAllMeasurement()
        {
            //_heartRateDbContext.HeartRateMeasurements.OrderBy(a => a.MeasurementDate).ToList();
            var measurements = _heartRateDbContext.HeartRateMeasurements.OrderByDescending(a => a.MeasurementDate).ToList();
            return View("Items", measurements);
        }

        [HttpGet("/heart-rate-measurements/add-request")]
        public IActionResult GetAddMeasurementRequest()
        {
            return View("Add", new HeartRateMeasurement());
        }

        [HttpPost("/heart-rate-measurements")]
        public IActionResult AddNewMeasurement(HeartRateMeasurement measurement)
        {
            if (ModelState.IsValid)
            {
                _heartRateDbContext.HeartRateMeasurements.Add(measurement);
                _heartRateDbContext.SaveChanges();
                TempData["LastActionMessage"] = "Creation was successuful";

                return RedirectToAction("GetAllMeasurement");
                // == return View("Item", measurement);
            } 
            else
            {
                return View("Add", measurement);
            }
        }

        [HttpGet("/heart-rate-measurement/{id}")]
        public IActionResult GetMeasurementById(int id)
        {
            HeartRateMeasurement msmt = _heartRateDbContext.HeartRateMeasurements.Find(id);

            return View("Item", msmt);
        }

        [HttpGet("/heart-rate-measurement/{id}/edit-request")]
        public IActionResult GetEditMeasurementRequestById(int id)
        {
            HeartRateMeasurement msmt = _heartRateDbContext.HeartRateMeasurements.Find(id);

            return View("Edit", msmt);
        }



        [HttpPost("/heart-rate-measurement/{id}/edit-request")]
        public IActionResult ProcessEditMeasurementRequest(int id, HeartRateMeasurement measurement)
        {
            if (id != measurement.HeartRateMeasurementId)
            {
                return NotFound();
            } 

            if (ModelState.IsValid)
            {
                _heartRateDbContext.HeartRateMeasurements.Update(measurement);
                _heartRateDbContext.SaveChanges();
                TempData["LastActionMessage"] = $"The Heart Rate measurement \"{measurement.BPMValue}\" has been updated successfully";

                return RedirectToAction("GetAllMeasurement", "HeartRate");
                // == return View("Item", measurement);
            }
            else
            {
                return View("Edit", measurement);
            }
        }
    }
}

