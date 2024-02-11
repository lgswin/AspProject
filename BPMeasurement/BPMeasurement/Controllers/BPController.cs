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
			ViewBag.Positions = _bpDbContext.Positions.OrderBy(p => p.Name).ToList();
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
            ViewBag.Positions = _bpDbContext.Positions.OrderBy(p => p.Name).ToList();
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

                foreach (var modelStateKey in ViewData.ModelState.Keys)
                {
                    var value = ViewData.ModelState[modelStateKey];
                    foreach (var error in value.Errors)
                    {
                        // You can log these errors, or inspect them while debugging
                        var errorMessage = error.ErrorMessage;
                        // Log the error message or set a breakpoint here to inspect
                    }
                }


                ViewBag.Action = (bp.BloodPressureId == 0) ? "Add" : "Edit";
                ViewBag.Positions = _bpDbContext.Positions.OrderBy(p => p.Name).ToList();
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

