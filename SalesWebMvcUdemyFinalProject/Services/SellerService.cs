using SalesWebMvcUdemyFinalProject.Data;
using SalesWebMvcUdemyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcUdemyFinalProject.Services.Exceptions;


namespace SalesWebMvcUdemyFinalProject.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcUdemyFinalProjectContext _context;

        public SellerService(SalesWebMvcUdemyFinalProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(s => s.Department).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var seller = await _context.Seller.FirstOrDefaultAsync(s => s.Id == id);
            _context.Seller.Remove(seller);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj)
        {
            if(! await _context.Seller.AnyAsync(s => s.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }

    }

}
