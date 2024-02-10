using BPMeasurement.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BPMeasurement.Controllers
{
    public class BPController : Controller
    {
        private BPDbContext _bpDbContext;

        public BPController(BPDbContext bpDbContext)
        {
            _bpDbContext = bpDbContext;
        }

        public IActionResult List()
        {
            List<BloodPressure> bPressures = _bpDbContext.BloodPressures.OrderBy(m => m.DateTime).ToList();
            return View(bPressures);
        }
    }
}

