using FiorelloFront.Areas.Admin.ViewModels.Slider;
using FiorelloFront.Data;
using FiorelloFront.Helpers;
using FiorelloFront.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloFront.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<SliderVM> list = new();
            List<Slider> sliders = await _context.Sliders.Where(m => !m.SoftDelete).ToListAsync();

            foreach (var slider in sliders)
            {
                SliderVM model = new()
                {
                    Id = slider.Id,
                    Image = slider.Image,
                    Status = slider.Status,
                };
                list.Add(model);
            }

            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(SliderCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (request.Image.CheckFileType("Image/"))
            {
                ModelState.AddModelError("Image", "Please select only image file");
                return View();
            }

            if(request.Image.CheckFileSize(200))
            {
                ModelState.AddModelError("Image", "Image size must be max 200KB");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + request.Image.FileName;

            await request.Image.SaveFileAsync(fileName, _env.WebRootPath, "img");

            Slider slider = new()
            { 
                Image = fileName
            };

            await _context.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





    }
}
