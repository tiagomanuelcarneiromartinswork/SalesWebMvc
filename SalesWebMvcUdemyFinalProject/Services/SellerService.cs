using SalesWebMvcUdemyFinalProject.Data;
using SalesWebMvcUdemyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcUdemyFinalProject.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcUdemyFinalProjectContext _context;

        public SellerService(SalesWebMvcUdemyFinalProjectContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
