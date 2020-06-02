using SalesWebMvcUdemyFinalProject.Data;
using SalesWebMvcUdemyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcUdemyFinalProject.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcUdemyFinalProjectContext _context;

        public DepartmentService(SalesWebMvcUdemyFinalProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(dep => dep.Name).ToListAsync();
        }
    }
}
