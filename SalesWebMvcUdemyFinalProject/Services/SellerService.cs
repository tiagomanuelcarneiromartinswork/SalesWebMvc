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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.FirstOrDefault(s => s.Id == id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }

    }

}
