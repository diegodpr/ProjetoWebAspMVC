using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.enums;

namespace WebApplication1.Data
{
    public class SeedingService
    {
        private WebApplication1Context _context;

        public SeedingService (WebApplication1Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            
            /*
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Books");

            Seller s1 = new Seller(1, "Diego Ramos", "diegop_ramos@hotmail.com", new DateTime(1993, 6, 8), 100.0, d1);
            Seller s2 = new Seller(2, "Mariliza", "mariliza@hotmail.com", new DateTime(1993, 9, 14), 400.0, d2);
            Seller s3 = new Seller(3, "Jose Carlos", "jose@hotmail.com", new DateTime(1973, 12, 2), 600.0, d3);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2021, 4, 23), 1450.00, SalesStatus.billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2021, 5, 12), 900.00, SalesStatus.pending, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2021, 2, 2), 800.00, SalesStatus.canceled, s3);

            _context.Department.AddRange(d1, d2, d3);
            _context.Seller.AddRange(s1, s2, s3);
            _context.SalesRecord.AddRange(sr1, sr2, sr3);

            _context.SaveChanges(); */

        }
    }
}
