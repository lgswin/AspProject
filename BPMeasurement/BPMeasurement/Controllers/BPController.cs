using BPMeasurement.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BPMeasurement.Controllers
{
    public class BPController : Controller
    {
        private BPDbContext _bpDbContext { get; set; }

        public BPController(BPDbContext ctx)
        {
            _bpDbContext = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            var newBloodPressure = new BloodPressure
            {
                DateTime = DateTime.Today
            };
            return View("Edit", newBloodPressure);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var bp = _bpDbContext.BloodPressures.Find(id);
            return View(bp);
        }

        [HttpPost]
        public IActionResult Edit(BloodPressure bp)
        {
            if (ModelState.IsValid)
            {
                if (bp.BloodPressureId == 0)
                    _bpDbContext.Add(bp);
                else
                    _bpDbContext.Update(bp);
                _bpDbContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else
            {
                ViewBag.Action = (bp.BloodPressureId == 0) ? "Add" : "Edit";
                return View(bp);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bp = _bpDbContext.BloodPressures.Find(id);
            return View(bp);
        }

        [HttpPost]
        public IActionResult Delete(BloodPressure bp)
        {
            _bpDbContext.BloodPressures.Remove(bp);
            _bpDbContext.SaveChanges();
            return RedirectToAction("Index", "Home"); 
        }
    }
}

