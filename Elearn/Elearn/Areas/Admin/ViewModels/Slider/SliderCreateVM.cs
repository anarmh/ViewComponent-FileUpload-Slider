using Microsoft.AspNetCore.Http;
using Microsoft.Build.Framework;

namespace Elearn.Areas.Admin.ViewModels.Slider
{
    public class SliderCreateVM
    {
        [Required]
        public IFormFile Image { get; set; }
    }
}
