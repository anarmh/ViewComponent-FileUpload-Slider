﻿using FiorelloFront.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloFront.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly ILayoutService _layoutService;
        public FooterViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas= _layoutService.GetAllDatas();
            return await Task.FromResult(View(datas));
        }
    }
}
