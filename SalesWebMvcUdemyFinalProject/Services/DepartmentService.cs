using SalesWebMvcUdemyFinalProject.Data;
using SalesWebMvcUdemyFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcUdemyFinalProject.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcUdemyFinalProjectContext _context;

        public DepartmentService(SalesWebMvcUdemyFinalProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(dep => dep.Name).ToList();
        }
    }
}
