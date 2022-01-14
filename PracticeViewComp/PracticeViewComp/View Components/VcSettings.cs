using Microsoft.AspNetCore.Mvc;
using PracticeViewComp.Data;
using PracticeViewComp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeViewComp.View_Components
{
    public class VcSettings : ViewComponent
    {
        private readonly AppDbContext _context;

        public VcSettings(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            VmBasics model = new VmBasics();
            //model.Settings = await _context.Settings
            return View(model);
        }
    }
}
