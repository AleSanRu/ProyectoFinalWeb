﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sinmple.Data;
using Sinmple.Models;

namespace Sinmple.Views.Cuentas
{
    public class IndexModel : PageModel
    {
        private readonly Sinmple.Data.SinmpleContext _context;

        public IndexModel(Sinmple.Data.SinmpleContext context)
        {
            _context = context;
        }

        public IList<Cuenta> Cuenta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cuenta != null)
            {
                Cuenta = await _context.Cuenta.ToListAsync();
            }
        }
    }
}
