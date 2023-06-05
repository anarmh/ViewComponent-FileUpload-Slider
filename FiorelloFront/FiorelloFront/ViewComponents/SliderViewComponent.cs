
using FiorelloFront.Data;
using FiorelloFront.Models;
using FiorelloFront.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace FiorelloFront.ViewComponents
{
    public class SliderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public SliderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Where(m => !m.SoftDelete).ToListAsync();
            SliderInfo sliderInfo = await _context.SliderInfos.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            SliderVM model = new()
            {
                SliderInfo = sliderInfo,
                Sliders = sliders
            };

            return await Task.FromResult(View(model)); 
        }
    }
}
