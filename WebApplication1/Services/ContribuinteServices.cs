using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ContribuinteServices
    {
        private readonly WebApplication1Context _context;

        public ContribuinteServices(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Contribuinte> findAll()
        {
            return _context.Contribuinte.ToList();
        }
    }
}
