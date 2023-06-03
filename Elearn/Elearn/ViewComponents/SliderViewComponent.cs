
using Elearn.Data;
using Elearn.Models;
using Elearn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elearn.ViewComponents
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


            SliderVM model = new()
            {
                Sliders = sliders,
            };
            return await Task.FromResult(View(model));
        }
    }
}
