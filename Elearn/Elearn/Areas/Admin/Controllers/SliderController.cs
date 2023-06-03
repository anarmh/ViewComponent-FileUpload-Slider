using Elearn.Areas.Admin.ViewModels.Slider;
using Elearn.Data;
using Elearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Elearn.Areas.Admin.Controllers
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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<SliderVM> listSlider = new();
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            foreach (var slider in sliders)
            {
                SliderVM model = new()
                {
                    Id = slider.id,
                    Image = slider.Image,
                    Logo = slider.Logo,
                    Title = slider.Title,
                    Description = slider.Description,
                    Status = slider.Status,
                    CreateDate = slider.CreateDate.ToString("dd-mm-yyyy")
                };
                listSlider.Add(model);
            }

            return View(listSlider);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Slider dbSlider = await _context.Sliders.FirstOrDefaultAsync(m => m.id == id);

            if (dbSlider is null) return NotFound();

            SliderDetailVM model = new()
            {
                Image = dbSlider.Image,
                Logo = dbSlider.Logo,
                Title = dbSlider.Title,
                Description = dbSlider.Description,
                CreateDate = dbSlider.CreateDate.ToString("dd-mm-yyyy"),
                Status = dbSlider.Status
            };

            return View(model);

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


            if (!request.Image.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Image", "Please select onle image file");
                return View();
            }


            if(request.Image.Length /1024 > 200)
            {
                ModelState.AddModelError("image", "Image size must be max 200 KB");
                return View();
            }

            string filename = Guid.NewGuid().ToString() + "_" + request.Image.FileName;

            string path = Path.Combine(_env.WebRootPath, "images", filename);

            using(FileStream stream = new(path, FileMode.Create))
            {
                await request.Image.CopyToAsync(stream);
            }

            Slider slider = new()
            {
                Image = filename,
            };
            await _context.Sliders.AddAsync(slider);

            await _context.SaveChangesAsync();  

            return RedirectToAction("Index");
        }
    }
}
